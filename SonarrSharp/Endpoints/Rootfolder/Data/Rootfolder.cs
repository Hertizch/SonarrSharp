using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Rootfolder.Data
{
    public partial class Rootfolder
    {
        [J("path")] public string Path { get; set; }
        [J("freeSpace")] public long FreeSpace { get; set; }
        [J("unmappedFolders")] public object[] UnmappedFolders { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
