using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
{
    public partial class Cutoff
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string Name { get; set; }
    }
}
