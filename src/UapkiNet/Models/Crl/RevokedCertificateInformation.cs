using System;
using Newtonsoft.Json;
using UapkiNet.Enums;

namespace UapkiNet.Models.Crl
{
    public class RevokedCertificateInformation
    {
        [JsonProperty("userCertificate")]
        public string UserCertificate { get; set; }

        [JsonProperty("revocationDate")]
        public DateTime Date { get; set; }

        [JsonProperty("crlReason")]
        public RevocationReason Reason { get; set; }

        [JsonProperty("invalidityDate")]
        public DateTime InvalidityDate { get; set; }
    }
}
