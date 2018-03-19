using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Cutoff
    {
        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("name")] public string Name { get; set; }
    }
}
