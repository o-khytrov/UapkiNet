using Newtonsoft.Json;
using UapkiNet.Enums;
using UapkiNet.Interfaces;

namespace UapkiNet.Models.Verifying
{
    public class RawVerificationResult: IVerificationResult
    {
        [JsonProperty("statusSignature")]
        public VerificationStatus Status { get; set; }
    }
}
