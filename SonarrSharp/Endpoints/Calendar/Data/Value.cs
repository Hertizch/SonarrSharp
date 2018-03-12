using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Calendar.Data
{
    public partial class Value
    {
        [J("name")] public string Name { get; set; }
        [J("allowed")] public Allowed[] Allowed { get; set; }
        [J("cutoff")] public Allowed Cutoff { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
