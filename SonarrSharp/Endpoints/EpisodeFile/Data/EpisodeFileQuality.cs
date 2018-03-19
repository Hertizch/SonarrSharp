using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.EpisodeFile.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EpisodeFileQuality
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
