using Newtonsoft.Json;
using SonarrSharp.Endpoints.Series.Enum;
using System;

namespace SonarrSharp.Endpoints.Series.Extensions
{
    static class StatusExtensions
    {
        public static Status? ValueForString(string str)
        {
            switch (str)
            {
                case "continuing": return Status.Continuing;
                case "ended": return Status.Ended;
                default: return null;
            }
        }

        public static Status ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Status value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Status.Continuing: serializer.Serialize(writer, "continuing"); break;
                case Status.Ended: serializer.Serialize(writer, "ended"); break;
            }
        }
    }
}
