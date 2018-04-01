using Newtonsoft.Json;
using SonarrSharp.Enum;
using System;

namespace SonarrSharp.Extensions
{
    static class LevelExtensions
    {
        public static Level? ValueForString(string str)
        {
            switch (str)
            {
                case "Info": return Level.Info;
                case "Warn": return Level.Warn;
                case "Error": return Level.Error;
                default: return null;
            }
        }

        public static Level ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Level value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Level.Info: serializer.Serialize(writer, "Info"); break;
                case Level.Warn: serializer.Serialize(writer, "Warn"); break;
                case Level.Error: serializer.Serialize(writer, "Error"); break;
            }
        }
    }
}
