using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
{
    public partial class Item
    {
        [J("quality")] public Cutoff Quality { get; set; }
        [J("allowed")] public bool Allowed { get; set; }
    }
}
