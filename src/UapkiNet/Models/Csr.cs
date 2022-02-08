using Newtonsoft.Json;

namespace UapkiNet.Models
{
    internal class Csr
    {
        [JsonProperty("bytes")]
        public string BytesBase64 { get; set; }
    }
}
