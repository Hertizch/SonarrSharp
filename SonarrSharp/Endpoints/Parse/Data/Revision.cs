using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Parse.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Revision
    {
        /// <summary>
        /// 
        /// </summary>
        [J("version")] public long Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("real")] public long Real { get; set; }
    }
}
