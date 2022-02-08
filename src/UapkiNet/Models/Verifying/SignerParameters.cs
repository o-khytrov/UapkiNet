using Newtonsoft.Json;

namespace UapkiNet.Models.Verifying
{
    public class SignerParameters
    {
        [JsonProperty("certificate")]
        public string CertificateBase64 { get; set; }

        [JsonProperty("certId")]
        public string CertificateIdBase64 { get; set; }

        [JsonProperty("spki")]
        public object SubjectPublicKeyInfo { get; set; }
    }
}
