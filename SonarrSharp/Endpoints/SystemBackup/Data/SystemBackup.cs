using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.SystemBackup.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SystemBackup
    {
        /// <summary>
        /// 
        /// </summary>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("path")] public string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("type")] public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("time")] public DateTimeOffset Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
