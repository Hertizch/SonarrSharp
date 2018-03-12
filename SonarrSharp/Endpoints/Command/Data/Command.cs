using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Command.Data
{
    public partial class Command
    {
        [J("name")] public string Name { get; set; }
        [J("startedOn")] public DateTimeOffset StartedOn { get; set; }
        [J("stateChangeTime")] public DateTimeOffset StateChangeTime { get; set; }
        [J("sendUpdatesToClient")] public bool SendUpdatesToClient { get; set; }
        [J("state")] public string State { get; set; }
        [J("id")] public long Id { get; set; }
    }
}
