using SonarrSharp.Enums;
using System;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.ReleasePush
{
    /// <summary>
    /// 
    /// </summary>
    public interface IReleasePush
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="downloadProtocol"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<Data.ReleasePush[]> PushRelease(string title, string downloadUrl, DownloadProtocol downloadProtocol, DateTime date);
    }
}
