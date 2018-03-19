using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Command.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Command
    {
        /// <summary>
        /// 
        /// </summary>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("startedOn")] public DateTimeOffset StartedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("stateChangeTime")] public DateTimeOffset StateChangeTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sendUpdatesToClient")] public bool SendUpdatesToClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("state")] public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("id")] public long Id { get; set; }
    }
}
