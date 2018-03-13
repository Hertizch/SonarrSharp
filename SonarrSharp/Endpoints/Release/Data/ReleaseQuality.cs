using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Release.Data
{
    public partial class ReleaseQuality
    {
        [J("quality")] public QualityQuality Quality { get; set; }
        [J("proper")] public bool Proper { get; set; }
    }
}
