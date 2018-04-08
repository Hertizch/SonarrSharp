using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.History
{
    /// <summary>
    /// History endpoint client
    /// </summary>
    public interface IHistory
    {
        /// <summary>
        /// Gets history (grabs/failures/completed)
        /// </summary>
        /// <param name="sortKey">Series title or Date - Default date</param>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 10</param>
        /// <param name="sortDir">Sort direction, asc or desc - Default desc</param>
        /// <returns></returns>
        Task<Models.History> GetHistory(string sortKey, int page = 1, int pageSize = 10, string sortDir = "default");
    }
}
