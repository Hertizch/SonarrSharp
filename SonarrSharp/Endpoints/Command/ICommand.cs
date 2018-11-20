using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Command
{
    /// <summary>
    /// Command endpoint client
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Queries the status of all currently started commands.
        /// </summary>
        /// <returns></returns>
        Task<List<Models.Command>> GetCommands();

        /// <summary>
        /// Queries the status of a previously started command
        /// </summary>
        /// <param name="id">Unique ID of the command</param>
        /// <returns></returns>
        Task<Models.Command> GetCommand(int id);

        /// <summary>
        /// Refresh series information from trakt and rescan disk. If seriesId not set, all series will be refreshed and scanned
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns></returns>
        Task<Models.Command> RefreshSeries([Optional] int seriesId);

        /// <summary>
        /// Refresh rescan disk for a single series. If seriesId not set all series will be scanned
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns></returns>
        Task<Models.Command> RescanSeries([Optional] int seriesId);

        /// <summary>
        /// Search for one or more episodes
        /// </summary>
        /// <param name="episodeIds">Episode ID's</param>
        /// <returns></returns>
        Task<Models.Command> EpisodeSearch(int[] episodeIds);

        /// <summary>
        /// Search for all episodes of a particular season
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <param name="seasonNumber">Season number</param>
        /// <returns></returns>
        Task<Models.Command> SeasonSearch(int seriesId, int seasonNumber);

        /// <summary>
        /// Search for all episodes in a series
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns></returns>
        Task<Models.Command> SeriesSearch(int seriesId);

        /// <summary>
        /// Instruct Sonarr to perform an RSS sync with all enabled indexers
        /// </summary>
        /// <returns></returns>
        Task<Models.Command> RssSync();

        /// <summary>
        /// Instruct Sonarr to rename the list of files provided
        /// </summary>
        /// <param name="files">List of File IDs to rename</param>
        /// <returns></returns>
        Task<Models.Command> RenameFiles(int[] files);

        /// <summary>
        /// Instruct Sonarr to rename all files in the provided series.
        /// </summary>
        /// <param name="seriesIds">List of Series IDs to rename</param>
        /// <returns></returns>
        Task<Models.Command> RenameSeries(int[] seriesIds);

        /// <summary>
        /// Instruct Sonarr to perform a backup of it's database and config file (nzbdrone.db and config.xml)
        /// </summary>
        /// <returns></returns>
        Task<Models.Command> Backup();

        /// <summary>
        /// Instruct Sonarr to perform a backlog search of missing episodes (Similar functionality to Sickbeard)
        /// </summary>
        /// <returns></returns>
        Task<Models.Command> MissingEpisodeSearch();
    }
}
