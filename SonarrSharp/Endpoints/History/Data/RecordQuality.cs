using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RecordQuality
    {
        /// <summary>
        /// 
        /// </summary>
        [J("quality")] public QualityQuality Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("revision")] public Revision Revision { get; set; }
    }
}
