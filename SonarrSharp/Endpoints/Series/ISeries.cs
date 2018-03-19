using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Series
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISeries
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Data.Series[]> GetSeries();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seriesId"></param>
        /// <returns></returns>
        Task<Data.Series> GetSeries(int seriesId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tvdbId"></param>
        /// <param name="title"></param>
        /// <param name="qualityProfileId"></param>
        /// <param name="titleSlug"></param>
        /// <param name="images"></param>
        /// <param name="seasons"></param>
        /// <param name="rootFolderPath"></param>
        /// <param name="tvRageId"></param>
        /// <param name="seasonFolder"></param>
        /// <param name="monitored"></param>
        /// <param name="addOptions"></param>
        /// <returns></returns>
        Task<Data.Series> AddSeries(int tvdbId, string title, int qualityProfileId, string titleSlug, Data.Image[] images, Data.Season[] seasons, string rootFolderPath, [Optional] int tvRageId, [Optional] bool seasonFolder, [Optional] bool monitored, [Optional] Dictionary<string, bool> addOptions);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deleteFiles"></param>
        /// <returns></returns>
        Task DeleteSeries(int id, [Optional] bool deleteFiles);
    }
}
