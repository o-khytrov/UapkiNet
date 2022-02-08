using System;
using Newtonsoft.Json;

namespace UapkiNet.Models.Certificate
{
    public class ValidityTimeStamp
    {
        [JsonProperty("notBefore")]
        public DateTime NotBefore { get; set; }

        [JsonProperty("notAfter")]
        public DateTime NotAfter { get; set; }
    }
}
