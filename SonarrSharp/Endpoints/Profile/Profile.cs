﻿using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.Profile
{
    public class Profile : IProfile
    {
        private SonarrClient _sonarrClient;

        public Profile(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Gets all quality profiles
        /// </summary>
        /// <returns>Data.Profile[]</returns>
        public async Task<Data.Profile[]> GetProfiles()
        {
            var json = await _sonarrClient.GetJson($"/profile");

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Data.Profile[]>(json, JsonHelpers.SerializerSettings);

            return null;
        }
    }
}