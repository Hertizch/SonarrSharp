using Newtonsoft.Json;
using SonarrSharp.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.QualityDefinition
{
    /// <summary>
    /// QualityDefinition endpoint client
    /// </summary>
    public class QualityDefinition : IQualityDefinition
    {
        private SonarrClient _sonarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityDefinition"/> class.
        /// </summary>
        /// <param name="sonarrClient">The sonarr client.</param>
        public QualityDefinition(SonarrClient sonarrClient)
        {
            _sonarrClient = sonarrClient;
        }

        /// <summary>
        /// Returns all quality definitions
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.QualityDefinition>> GetQualityDefinitions()
        {
            var json = await _sonarrClient.GetJson("/qualityDefinition");
            return await Task.Run(() => JsonConvert.DeserializeObject<List<Models.QualityDefinition>>(json, Converter.Settings));
        }

        /// <summary>
        /// Returns specific quality definition based on given id
        /// </summary>
        /// <returns></returns>
        public async Task<Models.QualityDefinition> GetQualityDefinition(int id)
        {
            var json = await _sonarrClient.GetJson($"/qualityDefinition/id={id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.QualityDefinition>(json, Converter.Settings));
        }

        /// <summary>
        /// Update an existing quality definition
        /// </summary>
        /// <param name="qualityDefinition">QualityDefinition to update - Requires all properties of Models.QualityDefinition object</param>
        /// <returns></returns>
        public async Task<Models.QualityDefinition> UpdateQualityDefinition(Models.QualityDefinition qualityDefinition)
        {
            var json = await _sonarrClient.PostJson("/qualityDefinition", JsonConvert.SerializeObject(qualityDefinition, Converter.Settings), "PUT");
            return await Task.Run(() => JsonConvert.DeserializeObject<Models.QualityDefinition>(json, Converter.Settings));
        }
    }
}
