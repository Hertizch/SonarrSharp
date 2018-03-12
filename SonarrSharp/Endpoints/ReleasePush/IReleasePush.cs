using SonarrSharp.Enums;
using System;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.ReleasePush
{
    public interface IReleasePush
    {
        Task<Data.ReleasePush[]> PushRelease(string title, string downloadUrl, DownloadProtocol downloadProtocol, DateTime date);
    }
}
