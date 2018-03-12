﻿using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.SeriesLookup.Data
{
    public partial class Ratings
    {
        [J("votes")] public long Votes { get; set; }
        [J("value")] public double Value { get; set; }
    }
}