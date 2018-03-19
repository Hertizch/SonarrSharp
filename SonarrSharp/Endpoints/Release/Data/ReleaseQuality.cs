using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Release.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReleaseQuality
    {
        /// <summary>
        /// 
        /// </summary>
        [J("quality")] public QualityQuality Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("proper")] public bool Proper { get; set; }
    }
}
