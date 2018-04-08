using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Episode
{
    /// <summary>
    /// Episode endpoint client
    /// </summary>
    public interface IEpisode
    {
        /// <summary>
        /// Returns all episodes for the given series
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns></returns>
        Task<IList<Models.Episode>> GetEpisodes(int seriesId);

        /// <summary>
        /// Returns the episode with the matching id
        /// </summary>
        /// <param name="episodeId">Episode ID</param>
        /// <returns></returns>
        Task<Models.Episode> GetEpisode(int episodeId);

        /// <summary>
        /// Update the given episodes, currently only monitored is changed, all other modifications are ignored.
        /// </summary>
        /// <param name="episode">Episode to update - Requires all properties of Models.Episode object</param>
        /// <returns></returns>
        Task<Models.Episode> UpdateEpisode(Models.Episode episode);
    }
}
