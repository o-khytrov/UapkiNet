using System.Collections.Generic;
using Newtonsoft.Json;
using UapkiNet.Interfaces;

namespace UapkiNet.Models.Verifying
{
    public class CadesOrCmsVerificationResult: IVerificationResult
    {
        [JsonProperty("content")]
        public VerificationContentInfo Content { get; set; }

        [JsonProperty("certIds")]
        public List<string> CertificateIds { get; set; }

        [JsonProperty("signatureInfos")]
        public List<SignatureInformation> SignatureInformations { get; set; }
    }
}
