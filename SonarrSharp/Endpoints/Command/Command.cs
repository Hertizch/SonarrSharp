using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Command
{
    public class Command : ICommand
    {
        private SonarrClient _sonarrClient;

        public Command(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Queries the status of all currently started commands.
        /// </summary>
        /// <returns>Data.Command[]</returns>
        public async Task<Data.Command[]> GetCommands()
        {
            var json = await _sonarrClient.GetJson($"/command");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Queries the status of a previously started command
        /// </summary>
        /// <param name="id">Unique ID of the command</param>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> GetCommand(int id)
        {
            var json = await _sonarrClient.GetJson($"/command/{id}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Refresh series information from trakt and rescan disk. If seriesId not set, all series will be refreshed and scanned
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> RefreshSeries([Optional] int seriesId)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "refreshSeries",
                ["seriesId"] = seriesId
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Refresh rescan disk for a single series. If seriesId not set all series will be scanned
        /// </summary>
        /// <param name="seriesId"></param>
        /// <returns></returns>
        public async Task<Data.Command> RescanSeries([Optional] int seriesId)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "rescanSeries",
                ["seriesId"] = seriesId
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Search for one or more episodes
        /// </summary>
        /// <param name="episodeIds">Episode ID's</param>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> EpisodeSearch(int[] episodeIds)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "episodeSearch",
                ["episodeIds"] = episodeIds
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Search for all episodes of a particular season
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <param name="seasonNumber">Season number</param>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> SeasonSearch(int seriesId, int seasonNumber)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "seasonSearch",
                ["seriesId"] = seriesId,
                ["seasonNumber"] = seasonNumber
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Search for all episodes in a series
        /// </summary>
        /// <param name="seriesId">Series ID</param>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> SeriesSearch(int seriesId)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "seriesSearch",
                ["seriesId"] = seriesId
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Deprecated
        /// </summary>
        /// <returns>Data.Command</returns>
        public Data.Command DownloadedEpisodesScan()
        {
            throw new NotImplementedException("This API call is deprecated and should not be used");
        }

        /// <summary>
        /// Instruct Sonarr to perform an RSS sync with all enabled indexers
        /// </summary>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> RssSync()
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "rssSync"
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Instruct Sonarr to rename the list of files provided
        /// </summary>
        /// <param name="files">List of File IDs to rename</param>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> RenameFiles(int[] files)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "renameFiles",
                ["files"] = files
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Instruct Sonarr to rename all files in the provided series.
        /// </summary>
        /// <param name="seriesIds">List of Series IDs to rename</param>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> RenameSeries(int[] seriesIds)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "renameSeries",
                ["seriesIds"] = seriesIds
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Instruct Sonarr to perform a backup of it's database and config file (nzbdrone.db and config.xml)
        /// </summary>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> Backup()
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "backup"
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }

        /// <summary>
        /// Instruct Sonarr to perform a backlog search of missing episodes (Similar functionality to Sickbeard)
        /// </summary>
        /// <returns>Data.Command</returns>
        public async Task<Data.Command> MissingEpisodeSearch()
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["name"] = "missingEpisodeSearch"
            });

            var json = await _sonarrClient.PostJson("/command", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Command>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
