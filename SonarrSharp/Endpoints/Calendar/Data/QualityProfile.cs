using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Calendar.Data
{
    public partial class QualityProfile
    {
        [J("value")] public Value Value { get; set; }
        [J("isLoaded")] public bool IsLoaded { get; set; }
    }
}
