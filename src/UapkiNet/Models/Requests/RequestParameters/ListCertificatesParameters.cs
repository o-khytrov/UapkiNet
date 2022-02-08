using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class ListCertificatesParameters
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("pageSize")]
        public int? PageSize { get; set; }
    }
}
