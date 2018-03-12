using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Command
{
    public interface ICommand
    {
        Task<Data.Command[]> GetCommands();
        Task<Data.Command> GetCommand(int id);
        Task<Data.Command> RefreshSeries([Optional] int seriesId);
        Task<Data.Command> RescanSeries([Optional] int seriesId);
        Task<Data.Command> EpisodeSearch(int[] episodeIds);
        Task<Data.Command> SeasonSearch(int seriesId, int seasonNumber);
        Task<Data.Command> SeriesSearch(int seriesId);
        Data.Command DownloadedEpisodesScan();
        Task<Data.Command> RssSync();
        Task<Data.Command> RenameFiles(int[] files);
        Task<Data.Command> RenameSeries(int[] seriesIds);
        Task<Data.Command> Backup();
        Task<Data.Command> MissingEpisodeSearch();
    }
}
