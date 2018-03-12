using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Profile.Data
{
    public partial class Cutoff
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string Name { get; set; }
    }
}
