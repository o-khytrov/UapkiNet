using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class StorageInfoParameters
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("storage")]
        public string Storage { get; set; }
    }
}
