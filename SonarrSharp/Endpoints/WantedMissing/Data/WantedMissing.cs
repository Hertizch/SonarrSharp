using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
{
    public partial class WantedMissing
    {
        [J("page")] public long Page { get; set; }
        [J("pageSize")] public long PageSize { get; set; }
        [J("sortKey")] public string SortKey { get; set; }
        [J("sortDirection")] public string SortDirection { get; set; }
        [J("totalRecords")] public long TotalRecords { get; set; }
        [J("records")] public Record[] Records { get; set; }
    }
}
