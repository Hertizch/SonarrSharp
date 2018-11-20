using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Command
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the started on.
        /// </summary>
        /// <value>
        /// The started on.
        /// </value>
        [J("startedOn")] public DateTimeOffset StartedOn { get; set; }

        /// <summary>
        /// Gets or sets the state change time.
        /// </summary>
        /// <value>
        /// The state change time.
        /// </value>
        [J("stateChangeTime")] public DateTimeOffset StateChangeTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send updates to client].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [send updates to client]; otherwise, <c>false</c>.
        /// </value>
        [J("sendUpdatesToClient")] public bool SendUpdatesToClient { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [J("state")] public string State { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public int Id { get; set; }
    }
}
