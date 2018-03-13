using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Release
{
    public interface IRelease
    {
        Task<Data.Release[]> GetReleases(int episodeId);
        Task<Data.Release[]> AddRelease(string guid);
    }
}
