using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SeriesLookup
{
    public interface ISeriesLookup
    {
        Task<Data.SeriesLookup[]> SearchForSeries(string title);
        Task<Data.SeriesLookup[]> SearchForSeries(int tvdbId);
    }
}
