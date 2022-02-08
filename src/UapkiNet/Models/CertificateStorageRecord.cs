using Newtonsoft.Json;

namespace UapkiNet.Models
{
    public class CertificateStorageRecord
    {
        [JsonProperty("certId")]
        public string Id { get; set; }

        [JsonProperty("isUnique")]
        public bool IsUnique { get; set; }
    }
}
