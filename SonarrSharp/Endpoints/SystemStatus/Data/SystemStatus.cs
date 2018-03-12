using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.SystemStatus.Data
{
    public partial class SystemStatus
    {
        [J("version")] public string Version { get; set; }
        [J("buildTime")] public DateTimeOffset BuildTime { get; set; }
        [J("isDebug")] public bool IsDebug { get; set; }
        [J("isProduction")] public bool IsProduction { get; set; }
        [J("isAdmin")] public bool IsAdmin { get; set; }
        [J("isUserInteractive")] public bool IsUserInteractive { get; set; }
        [J("startupPath")] public string StartupPath { get; set; }
        [J("appData")] public string AppData { get; set; }
        [J("osVersion")] public string OsVersion { get; set; }
        [J("isMono")] public bool IsMono { get; set; }
        [J("isLinux")] public bool IsLinux { get; set; }
        [J("isWindows")] public bool IsWindows { get; set; }
        [J("branch")] public string Branch { get; set; }
        [J("authentication")] public string Authentication { get; set; }
        [J("startOfWeek")] public long StartOfWeek { get; set; }
        [J("urlBase")] public string UrlBase { get; set; }
    }
}
