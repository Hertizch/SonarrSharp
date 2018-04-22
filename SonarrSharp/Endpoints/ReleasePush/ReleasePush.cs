using Newtonsoft.Json;
using SonarrSharp.Enum;
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
        /// <param name="protocol">Download protocol</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public async Task<IList<Models.ReleasePush>> PushRelease(string title, string downloadUrl, Protocol protocol, DateTime date)
        {
            string parameter = JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                ["title"] = title,
                ["downloadUrl"] = downloadUrl,
                ["protocol"] = protocol.ToString(),
                ["date"] = date.ToString("yyyy-MM-ddTHH:mm:ssZ")
            });

            var json = await _sonarrClient.PostJson($"/releasePush", parameter, "POST");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Models.ReleasePush>>(json, Converter.Settings));
        }
    }
}
