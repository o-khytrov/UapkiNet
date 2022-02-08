using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class CertificateInformationParameters: CertificateIdParameters
    {
        [JsonProperty("bytes")]
        public string BytesBase64 { get; set; }
    }
}
