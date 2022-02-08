using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class StoragesParameters
    {

        [JsonProperty("provider")]
        public string Provider { get; set; }
    }
}
