using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Parse
{
    /// <summary>
    /// Parse endpoint client
    /// </summary>
    public interface IParse
    {
        /// <summary>
        /// Returns the result of parsing a title
        /// </summary>
        /// <param name="title">Title</param>
        /// <returns>Data.Parse</returns>
        Task<Data.Parse> ParseTitle(string title);

        /// <summary>
        /// Returns the result of parsing a path
        /// </summary>
        /// <param name="path">Path</param>
        /// <returns>Data.Parse</returns>
        Task<Data.Parse> ParsePath(string path);
    }
}
