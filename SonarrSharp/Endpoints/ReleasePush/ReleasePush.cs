using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.ReleasePush
{
    /// <summary>
    /// ReleasePush endpoint client
    /// </summary>
    public class ReleasePush : IReleasePush
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleasePush"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public ReleasePush(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// No description
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="downloadUrl">The download URL.</param>
        /// <param name="downloadProtocol">Download protocol, usenet or torrent</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public async Task<Models.ReleasePush[]> PushRelease(string title, string downloadUrl, string downloadProtocol, DateTime date)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["title"] = title,
                ["downloadUrl"] = downloadUrl,
                ["protocol"] = downloadProtocol,
                ["date"] = date.ToString("yyyy-MM-ddTHH:mm:ssZ")
            });

            var json = await _sonarrClient.PostJson($"/releasePush", parameter, "POST");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Models.ReleasePush[]>(json, Converter.Settings);

            return null;
        }
    }
}
