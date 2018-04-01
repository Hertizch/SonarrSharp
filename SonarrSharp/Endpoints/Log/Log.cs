using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Log
{
    /// <summary>
    /// 
    /// </summary>
    public class Log : ILog
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public Log(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets the log files.
        /// </summary>
        /// <returns></returns>
        public async Task<Data.LogFile> GetLogFiles()
        {
            var json = await _sonarrClient.GetJson($"/log/file");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.LogFile>(json, Converter.Settings);

            return null;
        }

        /// <summary>
        /// Gets the log file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public async Task<string[]> GetLogFile(string filename)
        {
            var json = await _sonarrClient.GetJson($"/log/file/filename={filename}");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<string[]>(json, Converter.Settings);

            return null;
        }

        /// <summary>
        /// Gets the log.
        /// </summary>
        /// <returns></returns>
        public async Task<Data.Log> GetLog()
        {
            var json = await _sonarrClient.GetJson($"/log");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Log>(json, Converter.Settings);

            return null;
        }
    }
}
