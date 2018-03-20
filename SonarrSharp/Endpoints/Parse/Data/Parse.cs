using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Parse.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Parse
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the parsed episode information.
        /// </summary>
        /// <value>
        /// The parsed episode information.
        /// </value>
        [J("parsedEpisodeInfo")] public ParsedEpisodeInfo ParsedEpisodeInfo { get; set; }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        [J("series")] public Series Series { get; set; }

        /// <summary>
        /// Gets or sets the episodes.
        /// </summary>
        /// <value>
        /// The episodes.
        /// </value>
        [J("episodes")] public object[] Episodes { get; set; }
    }
}
