using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Release
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRelease
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="episodeId"></param>
        /// <returns></returns>
        Task<Data.Release[]> GetReleases(int episodeId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        Task<Data.Release[]> AddRelease(string guid);
    }
}
