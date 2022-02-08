using Newtonsoft.Json;
using UapkiNet.Enums;

namespace UapkiNet.Models.Certificate
{
    public class CrlValidationInformation
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("crlId")]
        public string CrlId { get;set; }

        [JsonProperty("statusSignature")]
        public VerificationStatus StatusSignature { get; set; }
    }
}
