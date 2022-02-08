using System;
using Newtonsoft.Json;
using UapkiNet.Enums;

namespace UapkiNet.Models.Verifying
{
    public class VerificationTimeStamp
    {
        [JsonProperty("genTime")]
        public DateTime GenerationTime { get; set; }

        [JsonProperty("policyId")]
        public string PolicyId { get; set; }

        [JsonProperty("statusDigest")]
        public VerificationStatus DigestStatus { get; set; }

        //TODO: Uncomment after UAPKI update
        //[JsonProperty("statusSign")]
        //public VerificationStatus SignStatus { get; set; }

        [JsonProperty("hashAlgo")]
        public string HashAlgorithm { get; set; }

        [JsonProperty("hashedMessage")]
        public string HashedMessage { get; set; }
    }
}
