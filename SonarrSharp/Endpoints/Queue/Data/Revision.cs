using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Queue.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Revision
    {
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        [J("version")] public long Version { get; set; }

        /// <summary>
        /// Gets or sets the real.
        /// </summary>
        /// <value>
        /// The real.
        /// </value>
        [J("real")] public long Real { get; set; }
    }
}
