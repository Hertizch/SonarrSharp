using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Log.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LogFile
    {
        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>
        /// The filename.
        /// </value>
        [J("filename")] public string Filename { get; set; }

        /// <summary>
        /// Gets or sets the last write time.
        /// </summary>
        /// <value>
        /// The last write time.
        /// </value>
        [J("lastWriteTime")] public DateTimeOffset LastWriteTime { get; set; }

        /// <summary>
        /// Gets or sets the contents URL.
        /// </summary>
        /// <value>
        /// The contents URL.
        /// </value>
        [J("contentsUrl")] public string ContentsUrl { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        [J("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
