using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Diskspace.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Diskspace
    {
        /// <summary>
        /// 
        /// </summary>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("label")] public string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("freeSpace")] public long FreeSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("totalSpace")] public long TotalSpace { get; set; }
    }
}
