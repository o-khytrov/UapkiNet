using Newtonsoft.Json;
using UapkiNet.Enums;

namespace UapkiNet.Models.Certificate
{
    internal class VerifyCertificateParameters
    {
        [JsonProperty("bytes")]
        public string BytesBase64 { get; set; }

        [JsonProperty("certId")]
        public string CertificateIdBase64 { get; set; }

        [JsonProperty("validationType")]
        public CertificateValidationType ValidationType { get; set; }

        [JsonProperty("validateTime")]
        public string ValidationTime { get; set; }
    }
}
