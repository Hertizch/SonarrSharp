using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.ReleasePush.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReleasePushQuality
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
