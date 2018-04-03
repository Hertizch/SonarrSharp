using Newtonsoft.Json;
using SonarrSharp.Enum;
using System;

namespace SonarrSharp.Extensions
{
    static class ProtocolExtensions
    {
        public static Protocol? ValueForString(string str)
        {
            switch (str)
            {
                case "usenet": return Protocol.Usenet;
                case "torrent": return Protocol.Torrent;
                default: return null;
            }
        }

        public static Protocol ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Protocol value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Protocol.Usenet: serializer.Serialize(writer, "usenet"); break;
                case Protocol.Torrent: serializer.Serialize(writer, "torrent"); break;
            }
        }
    }
}
