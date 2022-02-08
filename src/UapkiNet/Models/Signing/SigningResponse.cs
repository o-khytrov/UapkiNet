using System.Collections.Generic;
using Newtonsoft.Json;

namespace UapkiNet.Models.Signing
{
    public class SigningResponse
    {
        [JsonProperty("signatures")]
        public List<SignatureResult> Signatures { get; set; }
    }
}
