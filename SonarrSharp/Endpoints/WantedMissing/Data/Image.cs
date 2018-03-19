using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
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
