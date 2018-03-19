using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Episode
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEpisode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="seriesId"></param>
        /// <returns></returns>
        Task<Data.Episode[]> GetEpisodes(int seriesId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="episodeId"></param>
        /// <returns></returns>
        Task<Data.Episode> GetEpisode(int episodeId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="episode"></param>
        /// <returns></returns>
        Task<Data.Episode> UpdateEpisode(Data.Episode episode);
    }
}
