using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Profile.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Profile
    {
        /// <summary>
        /// 
        /// </summary>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("cutoff")] public Cutoff Cutoff { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("items")] public Item[] Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
