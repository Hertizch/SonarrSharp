using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Parse.Data
{
    public partial class SeriesTitleInfo
    {
        [J("title")] public string Title { get; set; }
        [J("titleWithoutYear")] public string TitleWithoutYear { get; set; }
        [J("year")] public long Year { get; set; }
    }
}
