using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace SonarrSharp.Helpers
{
    internal class JsonHelpers
    {
        internal static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = { new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal } }
        };
    }
}
