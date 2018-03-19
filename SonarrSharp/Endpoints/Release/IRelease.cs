using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Release
{
    /// <summary>
    /// Release endpoint client
    /// </summary>
    public interface IRelease
    {
        /// <summary>
        /// Gets releases by episode ID from Sonarr's search cache (30 minute cache)
        /// </summary>
        /// <param name="episodeId">Episode ID</param>
        /// <returns>Data.Release[]</returns>
        Task<Data.Release[]> GetReleases(int episodeId);

        /// <summary>
        /// Adds a previously searched release to the download client, if the release is still in Sonarr's search cache (30 minute cache)
        /// </summary>
        /// <param name="guid">Release GUID</param>
        /// <returns>Data.Release[]</returns>
        Task<Data.Release[]> AddRelease(string guid);
    }
}
