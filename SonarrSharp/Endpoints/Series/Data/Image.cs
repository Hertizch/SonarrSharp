using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    public partial class Image
    {
        [J("coverType")] public string CoverType { get; set; }
        [J("url")] public string Url { get; set; }
    }
}
