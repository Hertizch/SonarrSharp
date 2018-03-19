using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.WantedMissing.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class WantedMissing
    {
        /// <summary>
        /// 
        /// </summary>
        [J("page")] public long Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("pageSize")] public long PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sortKey")] public string SortKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("sortDirection")] public string SortDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("totalRecords")] public long TotalRecords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("records")] public Record[] Records { get; set; }
    }
}
