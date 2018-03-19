using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Ratings
    {
        /// <summary>
        /// 
        /// </summary>
        [J("votes")] public long Votes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("value")] public double Value { get; set; }
    }
}
