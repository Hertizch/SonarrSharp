using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Parse.Data
{
    public partial class Parse
    {
        [J("title")] public string Title { get; set; }
        [J("parsedEpisodeInfo")] public ParsedEpisodeInfo ParsedEpisodeInfo { get; set; }
        [J("series")] public Series Series { get; set; }
        [J("episodes")] public object[] Episodes { get; set; }
    }
}
