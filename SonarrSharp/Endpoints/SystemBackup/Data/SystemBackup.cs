using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.SystemBackup.Data
{
    public partial class SystemBackup
    {
        [J("name")] public string Name { get; set; }
        [J("path")] public string Path { get; set; }
        [J("type")] public string Type { get; set; }
        [J("time")] public DateTimeOffset Time { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
