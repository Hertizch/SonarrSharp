using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.SystemStatus.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SystemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [J("version")] public string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("buildTime")] public DateTimeOffset BuildTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isDebug")] public bool IsDebug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isProduction")] public bool IsProduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isAdmin")] public bool IsAdmin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isUserInteractive")] public bool IsUserInteractive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("startupPath")] public string StartupPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("appData")] public string AppData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("osVersion")] public string OsVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isMono")] public bool IsMono { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isLinux")] public bool IsLinux { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("isWindows")] public bool IsWindows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("branch")] public string Branch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("authentication")] public string Authentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("startOfWeek")] public long StartOfWeek { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("urlBase")] public string UrlBase { get; set; }
    }
}
