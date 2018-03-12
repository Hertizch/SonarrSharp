using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Episode
{
    public interface IEpisode
    {
        Task<Data.Episode[]> GetEpisodes(int seriesId);
        Task<Data.Episode> GetEpisode(int episodeId);
        Task<Data.Episode> UpdateEpisode(Data.Episode episode);
    }
}
