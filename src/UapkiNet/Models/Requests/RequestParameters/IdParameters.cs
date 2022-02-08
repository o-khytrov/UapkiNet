using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class IdParameters
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
