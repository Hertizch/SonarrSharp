using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Queue.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class QualityQuality
    {
        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("name")] public string Name { get; set; }
    }
}
