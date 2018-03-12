using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Queue.Data
{
    public partial class QueueQuality
    {
        [J("quality")] public QualityQuality Quality { get; set; }
        [J("revision")] public Revision Revision { get; set; }
    }
}
