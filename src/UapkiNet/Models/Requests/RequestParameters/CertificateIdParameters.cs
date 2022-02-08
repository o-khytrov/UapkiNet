using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class CertificateIdParameters
    {
        [JsonProperty("certId")]
        public string CertificateIdBase64 { get; set; }
    }
}
