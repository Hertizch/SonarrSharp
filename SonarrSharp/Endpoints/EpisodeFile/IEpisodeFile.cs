using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.EpisodeFile
{
    public interface IEpisodeFile
    {
        Task<Data.EpisodeFile[]> GetEpisodeFiles(int seriesId);
        Task<Data.EpisodeFile> GetEpisodeFile(int episodeId);
        Task DeleteEpisodeFile(int id);
    }
}
