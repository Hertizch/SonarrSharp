using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SonarrSharp.Enum;
using SonarrSharp.Extensions;
using System;
using System.Globalization;

namespace SonarrSharp.Helpers
{
    internal class Converter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(Level) ||
            t == typeof(CoverType) ||
            t == typeof(SeriesType) ||
            t == typeof(Status) ||
            t == typeof(SystemBackupType) ||
            t == typeof(Protocol) ||
            t == typeof(QualityName) ||

            t == typeof(Level?) ||
            t == typeof(CoverType?) ||
            t == typeof(SeriesType?) ||
            t == typeof(Status?) ||
            t == typeof(SystemBackupType?) ||
            t == typeof(Protocol?) ||
            t == typeof(QualityName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(Level))
                return LevelExtensions.ReadJson(reader, serializer);
            if (t == typeof(CoverType))
                return CoverTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(SeriesType))
                return SeriesTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Status))
                return StatusExtensions.ReadJson(reader, serializer);
            if (t == typeof(SystemBackupType))
                return SystemBackupTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Protocol))
                return ProtocolExtensions.ReadJson(reader, serializer);
            if (t == typeof(QualityName))
                return QualityNameExtensions.ReadJson(reader, serializer);

            if (t == typeof(Level?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return LevelExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(CoverType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return CoverTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(SeriesType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return SeriesTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Status?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return StatusExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(SystemBackupType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return SystemBackupTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Protocol?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ProtocolExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(QualityName?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return QualityNameExtensions.ReadJson(reader, serializer);
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
            if (t == typeof(CoverType))
            {
                ((CoverType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(SeriesType))
            {
                ((SeriesType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Status))
            {
                ((Status)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(SystemBackupType))
            {
                ((SystemBackupType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Protocol))
            {
                ((Protocol)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(QualityName))
            {
                ((QualityName)value).WriteJson(writer, serializer);
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
