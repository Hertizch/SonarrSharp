using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Series
{
    /// <summary>
    /// Series endpoint client
    /// </summary>
    public interface ISeries
    {
        /// <summary>
        /// Returns all series in your collection
        /// </summary>
        /// <param name="includeSeasonImages">if set to <c>true</c> [include season images].</param>
        /// <returns></returns>
        Task<List<Models.Series>> GetSeries([Optional] bool includeSeasonImages);

        /// <summary>
        /// Returns the series with the matching ID
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <param name="includeSeasonImages">if set to <c>true</c> [include season images].</param>
        /// <returns></returns>
        Task<Models.Series> GetSeries(int seriesId, [Optional] bool includeSeasonImages);

        /// <summary>
        /// Adds a new series to your collection (Refer to https://github.com/Sonarr/Sonarr/wiki/Series for more information on usage)
        /// </summary>
        /// <param name="tvdbId">TV Database ID</param>
        /// <param name="title">Title</param>
        /// <param name="qualityProfileId">Quality profile ID</param>
        /// <param name="titleSlug">Title slug</param>
        /// <param name="images">Images array</param>
        /// <param name="seasons">Seasons array</param>
        /// <param name="rootFolderPath">Full path will be created by combining the rootFolderPath with the series title</param>
        /// <param name="tvRageId">TV Rage ID</param>
        /// <param name="seasonFolder">Use season folders</param>
        /// <param name="monitored">Is monitored</param>
        /// <param name="addOptions">Object that contains three boolean properties - If supplied, all properties are required</param>
        /// <returns></returns>
        Task<Models.Series> AddSeries(int tvdbId, string title, int qualityProfileId, string titleSlug, Models.Image[] images, Models.Season[] seasons, string rootFolderPath, [Optional] int tvRageId, [Optional] bool seasonFolder, [Optional] bool monitored, [Optional] AddOptions addOptions);

        /// <summary>
        /// Update an existing series
        /// </summary>
        /// <param name="series">Series to update - Requires all properties of Data.Series object</param>
        /// <returns></returns>
        Task<Models.Series> UpdateSeries(Models.Series series);

        /// <summary>
        /// Delete the series with the given ID
        /// </summary>
        /// <param name="id">Series ID</param>
        /// <param name="deleteFiles">if set to <c>true</c> the series folder and all files will be deleted when the series is deleted.</param>
        /// <returns></returns>
        Task DeleteSeries(int id, [Optional] bool deleteFiles);
    }
}
