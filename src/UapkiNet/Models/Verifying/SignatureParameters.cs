using Newtonsoft.Json;

namespace UapkiNet.Models.Verifying
{
    public class SignatureParameters
    {
        [JsonProperty("signAlgo")]
        public string SignatureAlgorithm { get; set; }
    }
}
