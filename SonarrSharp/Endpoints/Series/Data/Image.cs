using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// 
        /// </summary>
        [J("coverType")] public string CoverType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("url")] public string Url { get; set; }
    }
}
