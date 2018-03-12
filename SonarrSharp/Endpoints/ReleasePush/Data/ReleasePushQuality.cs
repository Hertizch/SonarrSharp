using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.ReleasePush.Data
{
    public partial class ReleasePushQuality
    {
        [J("quality")] public QualityQuality Quality { get; set; }
        [J("proper")] public bool Proper { get; set; }
    }
}
