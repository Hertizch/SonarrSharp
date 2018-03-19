using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SeriesLookup
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISeriesLookup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        Task<Data.SeriesLookup[]> SearchForSeries(string title);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tvdbId"></param>
        /// <returns></returns>
        Task<Data.SeriesLookup[]> SearchForSeries(int tvdbId);
    }
}
