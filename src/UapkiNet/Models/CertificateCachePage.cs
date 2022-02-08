using System.Collections.Generic;
using Newtonsoft.Json;

namespace UapkiNet.Models
{
    public class CertificateCachePage
    {
        [JsonProperty("certIds")]
        public List<string> Ids { get; set; }

        [JsonProperty("count")]
        public int TotalCount { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
    }
}
