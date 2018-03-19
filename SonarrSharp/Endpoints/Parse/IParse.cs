using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Parse
{
    /// <summary>
    /// 
    /// </summary>
    public interface IParse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        Task<Data.Parse> ParseTitle(string title);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        Task<Data.Parse> ParsePath(string path);
    }
}
