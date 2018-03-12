using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.History.Data
{
    public partial class History
    {
        [J("page")] public long Page { get; set; }
        [J("pageSize")] public long PageSize { get; set; }
        [J("sortKey")] public string SortKey { get; set; }
        [J("sortDirection")] public string SortDirection { get; set; }
        [J("totalRecords")] public long TotalRecords { get; set; }
        [J("records")] public Record[] Records { get; set; }
    }
}
