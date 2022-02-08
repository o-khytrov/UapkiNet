using Newtonsoft.Json;

namespace UapkiNet.Models.Signing
{
    public class SignatureResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("bytes")]
        public string BytesBase64 { get; set; }
    }
}
