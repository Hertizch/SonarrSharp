using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Command
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Command[]> GetCommands();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Data.Command> GetCommand(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seriesId"></param>
        /// <returns></returns>
        Task<Data.Command> RefreshSeries([Optional] int seriesId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seriesId"></param>
        /// <returns></returns>
        Task<Data.Command> RescanSeries([Optional] int seriesId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="episodeIds"></param>
        /// <returns></returns>
        Task<Data.Command> EpisodeSearch(int[] episodeIds);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seriesId"></param>
        /// <param name="seasonNumber"></param>
        /// <returns></returns>
        Task<Data.Command> SeasonSearch(int seriesId, int seasonNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seriesId"></param>
        /// <returns></returns>
        Task<Data.Command> SeriesSearch(int seriesId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Data.Command DownloadedEpisodesScan();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Command> RssSync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        Task<Data.Command> RenameFiles(int[] files);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seriesIds"></param>
        /// <returns></returns>
        Task<Data.Command> RenameSeries(int[] seriesIds);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Command> Backup();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Command> MissingEpisodeSearch();
    }
}
