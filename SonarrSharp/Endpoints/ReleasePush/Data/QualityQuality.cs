using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.ReleasePush.Data
{
    public partial class QualityQuality
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string Name { get; set; }
    }
}
