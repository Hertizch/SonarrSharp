using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Parse.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SeriesTitleInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("titleWithoutYear")] public string TitleWithoutYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("year")] public long Year { get; set; }
    }
}
