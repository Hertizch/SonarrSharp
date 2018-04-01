using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.SeriesLookup
{
    /// <summary>
    /// SeriesLookup endpoint client
    /// </summary>
    public interface ISeriesLookup
    {
        /// <summary>
        /// Searches for new shows on trakt
        /// </summary>
        /// <param name="title">Series title</param>
        /// <returns></returns>
        Task<Models.SeriesLookup[]> SearchForSeries(string title);

        /// <summary>
        /// Searches for new shows on trakt
        /// </summary>
        /// <param name="tvdbId">TV Database ID number</param>
        /// <returns></returns>
        Task<Models.SeriesLookup[]> SearchForSeries(int tvdbId);
    }
}
