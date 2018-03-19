using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Profile.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Item
    {
        /// <summary>
        /// 
        /// </summary>
        [J("quality")] public Cutoff Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("allowed")] public bool Allowed { get; set; }
    }
}
