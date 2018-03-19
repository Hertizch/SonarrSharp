using SonarrSharp.Enums;
using System;
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
        /// <param name="title"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="downloadProtocol">Usenet or Torrent</param>
        /// <param name="date"></param>
        /// <returns>Data.ReleasePush[]</returns>
        Task<Data.ReleasePush[]> PushRelease(string title, string downloadUrl, DownloadProtocol downloadProtocol, DateTime date);
    }
}
