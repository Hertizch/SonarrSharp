using Newtonsoft.Json;
using SonarrSharp.Enums;
using SonarrSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.ReleasePush
{
    public class ReleasePush : IReleasePush
    {
        private SonarrClient _sonarrClient;

        public ReleasePush(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="downloadProtocol">Usenet or Torrent</param>
        /// <param name="date"></param>
        /// <returns>Data.ReleasePush[]</returns>
        public async Task<Data.ReleasePush[]> PushRelease(string title, string downloadUrl, DownloadProtocol downloadProtocol, DateTime date)
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
                return JsonConvert.DeserializeObject<Data.ReleasePush[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}
