using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Parse.Data
{
    public partial class ParsedEpisodeInfoQuality
    {
        [J("quality")] public QualityQuality Quality { get; set; }
        [J("revision")] public Revision Revision { get; set; }
    }
}
