using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Calendar.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class QualityProfile
    {
        /// <summary>
        /// 
        /// </summary>
        [J("value")] public Value Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isLoaded")] public bool IsLoaded { get; set; }
    }
}
