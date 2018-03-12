using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    public partial class AlternateTitle
    {
        [J("title")] public string Title { get; set; }
        [J("seasonNumber")] public long SeasonNumber { get; set; }
    }
}
