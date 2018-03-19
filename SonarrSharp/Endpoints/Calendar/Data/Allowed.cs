using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Calendar.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Allowed
    {
        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("weight")] public long Weight { get; set; }
    }
}
