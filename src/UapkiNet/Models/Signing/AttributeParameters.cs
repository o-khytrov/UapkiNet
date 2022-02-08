using Newtonsoft.Json;

namespace UapkiNet.Models.Signing
{
    public class AttributeParameters
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("bytes")]
        public string BytesBase64 { get; set; }
    }
}
