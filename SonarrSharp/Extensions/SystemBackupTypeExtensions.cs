using Newtonsoft.Json;
using SonarrSharp.Enum;
using System;

namespace SonarrSharp.Extensions
{
    static class SystemBackupTypeExtensions
    {
        public static SystemBackupType? ValueForString(string str)
        {
            switch (str)
            {
                case "manual": return SystemBackupType.Manual;
                case "scheduled": return SystemBackupType.Scheduled;
                case "update": return SystemBackupType.Update;
                default: return null;
            }
        }

        public static SystemBackupType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this SystemBackupType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case SystemBackupType.Manual: serializer.Serialize(writer, "manual"); break;
                case SystemBackupType.Scheduled: serializer.Serialize(writer, "scheduled"); break;
                case SystemBackupType.Update: serializer.Serialize(writer, "update"); break;
            }
        }
    }
}
