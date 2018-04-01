using Newtonsoft.Json;
using SonarrSharp.Enum;
using System;

namespace SonarrSharp.Extensions
{
    static class SeriesTypeExtensions
    {
        public static SeriesType? ValueForString(string str)
        {
            switch (str)
            {
                case "anime": return SeriesType.Anime;
                case "standard": return SeriesType.Standard;
                default: return null;
            }
        }

        public static SeriesType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this SeriesType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case SeriesType.Anime: serializer.Serialize(writer, "anime"); break;
                case SeriesType.Standard: serializer.Serialize(writer, "standard"); break;
            }
        }
    }
}
