using System;
using Newtonsoft.Json;
using UapkiNet.Enums;
using UapkiNet.Interfaces;

namespace UapkiNet.Models.Certificate
{
    public class CrlCertificateValidation : ICertificateValidation
    {
        [JsonProperty("status")]
        public CertificateStatus Status { get ; set; }

        [JsonProperty("revocationReason")]
        public RevocationReason? RevocationReason { get; set; }

        [JsonProperty("revocationTime")]
        public DateTime? RevocationTime { get; set; }

        [JsonProperty("full")]
        public CrlValidationInformation FullInformation { get; set; }

        [JsonProperty("delta")]
        public CrlValidationInformation DeltaInformation { get; set; }
    }
}
