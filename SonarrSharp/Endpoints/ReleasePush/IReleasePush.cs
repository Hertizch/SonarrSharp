using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.ReleasePush
{
    /// <summary>
    /// ReleasePush endpoint client
    /// </summary>
    public interface IReleasePush
    {
        /// <summary>
        /// No description
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="downloadUrl">The download URL.</param>
        /// <param name="downloadProtocol">Download protocol, usenet or torrent</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        Task<IList<Models.ReleasePush>> PushRelease(string title, string downloadUrl, string downloadProtocol, DateTime date);
    }
}
