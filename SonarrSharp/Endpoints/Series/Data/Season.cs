using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    public partial class Season
    {
        [J("seasonNumber")] public long SeasonNumber { get; set; }
        [J("monitored")] public bool Monitored { get; set; }
        [J("statistics")] public Statistics Statistics { get; set; }
    }
}
