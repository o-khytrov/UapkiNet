using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class GetCsrParameters
    {
        [JsonProperty("signAlgo")]
        public string SignAlgorithm { get; set; }
    }
}
