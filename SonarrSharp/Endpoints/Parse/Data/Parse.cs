using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Parse.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Parse
    {
        /// <summary>
        /// 
        /// </summary>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("parsedEpisodeInfo")] public ParsedEpisodeInfo ParsedEpisodeInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("series")] public Series Series { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("episodes")] public object[] Episodes { get; set; }
    }
}
