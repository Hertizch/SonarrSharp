using Newtonsoft.Json;
using SonarrSharp.Enum;
using System;

namespace SonarrSharp.Extensions
{
    static class CoverTypeExtensions
    {
        public static CoverType? ValueForString(string str)
        {
            switch (str)
            {
                case "banner": return CoverType.Banner;
                case "fanart": return CoverType.Fanart;
                case "poster": return CoverType.Poster;
                default: return null;
            }
        }

        public static CoverType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this CoverType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case CoverType.Banner: serializer.Serialize(writer, "banner"); break;
                case CoverType.Fanart: serializer.Serialize(writer, "fanart"); break;
                case CoverType.Poster: serializer.Serialize(writer, "poster"); break;
            }
        }
    }
}
