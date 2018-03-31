using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Series
{
    /// <summary>
    /// Series endpoint client
    /// </summary>
    public class Series : ISeries
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Series"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Series(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns all series in your collection
        /// </summary>
        /// <returns>Data.Series[]</returns>
        public async Task<Data.Series[]> GetSeries()
        {
            var json = await _sonarrClient.GetJson("/series");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Series[]>(json, Converter.Settings);

            return null;
        }

        /// <summary>
        /// Returns the series with the matching ID
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns>Data.Series</returns>
        public async Task<Data.Series> GetSeries(int seriesId)
        {
            var json = await _sonarrClient.GetJson($"/series/id={seriesId}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Series>(json, Converter.Settings);

            return null;
        }

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
        /// <param name="addOptions">Object that contains three boolean properties; ignoreEpisodesWithFiles: Unmonitors any episodes with a file, ignoreEpisodesWithoutFiles: Unmonitors any episodes without a file, searchForMissingEpisodes: Searches for missing files after applying ignoreEpisodesWithFiles and ignoreEpisodesWithoutFiles</param>
        /// <returns>Data.Series</returns>
        public async Task<Data.Series> AddSeries(int tvdbId, string title, int qualityProfileId, string titleSlug, Data.Image[] images, Data.Season[] seasons, string rootFolderPath, [Optional] int tvRageId, [Optional] bool seasonFolder, [Optional] bool monitored, [Optional] Dictionary<string, bool> addOptions)
        {
            var dictionary = new Dictionary<string, object>
            {
                ["tvdbId"] = tvdbId,
                ["title"] = title,
                ["qualityProfileId"] = qualityProfileId,
                ["titleSlug"] = titleSlug,
                ["images"] = images,
                ["seasons"] = seasons,
                ["rootFolderPath"] = rootFolderPath,
                ["tvRageId"] = tvRageId,
                ["seasonFolder"] = seasonFolder,
                ["monitored"] = monitored
            };

            if (addOptions != null)
                dictionary.Add("addOptions", addOptions);

            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>(dictionary));

            var json = await _sonarrClient.PostJson("/series", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Series>(json, Converter.Settings);

            return null;
        }

        /// <summary>
        /// Update an existing series
        /// </summary>
        /// <param name="series">Series to update - Requires all properties of Data.Series object</param>
        /// <returns>Data.Series</returns>
        public async Task<Data.Series> UpdateSeries(Data.Series series)
        {
            var json = await _sonarrClient.PostJson("/series", JsonConvert.SerializeObject(series), "PUT");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Series>(json, Converter.Settings);

            return null;
        }

        /// <summary>
        /// Delete the series with the given ID
        /// </summary>
        /// <param name="id">Series ID</param>
        /// <param name="deleteFiles">If true the series folder and all files will be deleted when the series is deleted</param>
        /// <returns>Nothing</returns>
        public async Task DeleteSeries(int id, [Optional] bool deleteFiles)
        {
            await _sonarrClient.Delete($"/series/id={id}{(deleteFiles ? $"?deleteFiles={deleteFiles}" : "")}");
        }
    }
}
