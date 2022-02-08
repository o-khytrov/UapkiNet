using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class CrlInfoParameters
    {
        [JsonProperty("bytes")]
        public string BytesBase64 { get; set; }
    }
}
