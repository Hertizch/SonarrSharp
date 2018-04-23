using Newtonsoft.Json;
using SonarrSharp.Enum;
using System;

namespace SonarrSharp.Extensions
{
    static class QualityNameExtensions
    {
        public static QualityName? ValueForString(string str)
        {
            switch (str)
            {
                case "Unknown": return QualityName.Unknown;
                case "SDTV": return QualityName.SDTV;
                case "WEBDL-480p": return QualityName.WebDL480P;
                case "DVD": return QualityName.Dvd;
                case "HDTV-720p": return QualityName.HDTV720P;
                case "HDTV-1080p": return QualityName.HDTV1080P;
                case "Raw-HD": return QualityName.RawHd;
                case "WEBDL-720p": return QualityName.WebDL720P;
                case "Bluray-720p": return QualityName.Bluray720P;
                case "WEBDL-1080p": return QualityName.WebDL1080P;
                case "Bluray-1080p": return QualityName.Bluray1080P;
                case "HDTV-2160p": return QualityName.HDTV2160P;
                case "WEBDL-2160p": return QualityName.WebDL2160P;
                case "Bluray-2160p": return QualityName.Bluray2160P;

                default: return null;
            }
        }

        public static QualityName ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this QualityName value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case QualityName.Unknown: serializer.Serialize(writer, "Unknown"); break;
                case QualityName.SDTV: serializer.Serialize(writer, "SDTV"); break;
                case QualityName.WebDL480P: serializer.Serialize(writer, "WEBDL-480p"); break;
                case QualityName.Dvd: serializer.Serialize(writer, "DVD"); break;
                case QualityName.HDTV720P: serializer.Serialize(writer, "HDTV-720p"); break;
                case QualityName.HDTV1080P: serializer.Serialize(writer, "HDTV-1080p"); break;
                case QualityName.RawHd: serializer.Serialize(writer, "Raw-HD"); break;
                case QualityName.WebDL720P: serializer.Serialize(writer, "WEBDL-720p"); break;
                case QualityName.Bluray720P: serializer.Serialize(writer, "Bluray-720p"); break;
                case QualityName.WebDL1080P: serializer.Serialize(writer, "WEBDL-1080p"); break;
                case QualityName.Bluray1080P: serializer.Serialize(writer, "Bluray-1080p"); break;
                case QualityName.HDTV2160P: serializer.Serialize(writer, "HDTV-2160p"); break;
                case QualityName.WebDL2160P: serializer.Serialize(writer, "WEBDL-2160p"); break;
                case QualityName.Bluray2160P: serializer.Serialize(writer, "Bluray-2160p"); break;

            }
        }
    }
}
