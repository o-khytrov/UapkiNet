using Newtonsoft.Json;

namespace UapkiNet.Models.Verifying
{
    public class VerificationContentInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("bytes")]
        public string ExtractedDataBase64 { get; set; }
    }
}
