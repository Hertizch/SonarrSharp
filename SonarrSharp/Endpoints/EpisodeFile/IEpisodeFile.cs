using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.EpisodeFile
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEpisodeFile
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="seriesId"></param>
        /// <returns></returns>
        Task<Data.EpisodeFile[]> GetEpisodeFiles(int seriesId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="episodeId"></param>
        /// <returns></returns>
        Task<Data.EpisodeFile> GetEpisodeFile(int episodeId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteEpisodeFile(int id);
    }
}
