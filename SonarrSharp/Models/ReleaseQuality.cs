using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReleaseQuality
    {
        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [J("quality")] public QualityQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReleaseQuality"/> is proper.
        /// </summary>
        /// <value>
        ///   <c>true</c> if proper; otherwise, <c>false</c>.
        /// </value>
        [J("proper")] public bool Proper { get; set; }
    }
}
