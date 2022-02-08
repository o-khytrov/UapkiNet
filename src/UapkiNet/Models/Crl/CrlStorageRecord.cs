using Newtonsoft.Json;

namespace UapkiNet.Models.Crl
{
    public class CrlStorageRecord
    {
        [JsonProperty("crlId")]
        public string Id { get; set; }

        [JsonProperty("isUnique")]
        public bool IsUnique { get; set; }
    }
}
