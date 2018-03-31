using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SonarrSharp.Endpoints.Log.Enum;
using SonarrSharp.Endpoints.Log.Extensions;
using System;
using System.Globalization;

namespace SonarrSharp.Helpers
{
    internal class Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Level) || t == typeof(Level?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(Level))
                return LevelExtensions.ReadJson(reader, serializer);

            if (t == typeof(Level?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return LevelExtensions.ReadJson(reader, serializer);
            }

            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(Level))
            {
                ((Level)value).WriteJson(writer, serializer);
                return;
            }

            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new Converter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            }
        };
    }
}
