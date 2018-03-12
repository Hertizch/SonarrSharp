using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    public partial class RecordQuality
    {
        [J("quality")] public QualityQuality Quality { get; set; }
        [J("revision")] public Revision Revision { get; set; }
    }
}
