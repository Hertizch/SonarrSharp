using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
{
    public partial class Value
    {
        [J("name")] public string Name { get; set; }
        [J("cutoff")] public Cutoff Cutoff { get; set; }
        [J("items")] public Item[] Items { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
