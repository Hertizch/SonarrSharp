using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Calendar.Data
{
    public partial class Allowed
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("weight")] public long Weight { get; set; }
    }
}
