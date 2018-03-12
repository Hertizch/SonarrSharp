using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.EpisodeFile.Data
{
    public partial class EpisodeFileQuality
    {
        [J("quality")] public QualityQuality Quality { get; set; }
        [J("proper")] public bool Proper { get; set; }
    }
}
