using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.QualityDefinition
{
    /// <summary>
    /// QualityDefinition endpoint client
    /// </summary>
    public interface IQualityDefinition
    {
        /// <summary>
        /// Returns all quality definitions
        /// </summary>
        /// <returns></returns>
        Task<List<Models.QualityDefinition>> GetQualityDefinitions();

        /// <summary>
        /// Returns specific quality definition based on given id
        /// </summary>
        /// <returns></returns>
        Task<Models.QualityDefinition> GetQualityDefinition(int id);

        /// <summary>
        /// Update an existing quality definition
        /// </summary>
        /// <param name="qualityDefinition">QualityDefinition to update - Requires all properties of Models.QualityDefinition object</param>
        /// <returns></returns>
        Task<Models.QualityDefinition> UpdateQualityDefinition(Models.QualityDefinition qualityDefinition);
    }
}
