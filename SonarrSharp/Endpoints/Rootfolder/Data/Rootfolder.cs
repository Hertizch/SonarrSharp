using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Rootfolder.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Rootfolder
    {
        /// <summary>
        /// 
        /// </summary>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("freeSpace")] public long FreeSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("unmappedFolders")] public object[] UnmappedFolders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
