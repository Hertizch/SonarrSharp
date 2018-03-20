using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Calendar.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// Gets or sets the type of the cover.
        /// </summary>
        /// <value>
        /// The type of the cover.
        /// </value>
        [J("coverType")] public string CoverType { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [J("url")] public string Url { get; set; }
    }
}
