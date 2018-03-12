using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Diskspace.Data
{
    public partial class Diskspace
    {
        [J("path")] public string Path { get; set; }
        [J("label")] public string Label { get; set; }
        [J("freeSpace")] public long FreeSpace { get; set; }
        [J("totalSpace")] public long TotalSpace { get; set; }
    }
}
