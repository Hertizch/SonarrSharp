using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.EpisodeFile
{
    /// <summary>
    /// EpisodeFile endpoint client
    /// </summary>
    public interface IEpisodeFile
    {
        /// <summary>
        /// Returns all episode files for the given series
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns></returns>
        Task<IList<Models.EpisodeFile>> GetEpisodeFiles(int seriesId);

        /// <summary>
        /// Returns the episode file with the matching id
        /// </summary>
        /// <param name="episodeId">Episode ID</param>
        /// <returns></returns>
        Task<Models.EpisodeFile> GetEpisodeFile(int episodeId);

        /// <summary>
        /// Delete the given episode file
        /// </summary>
        /// <param name="id">Episode file ID</param>
        /// <returns></returns>
        Task DeleteEpisodeFile(int id);
    }
}
