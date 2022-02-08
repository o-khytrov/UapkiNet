using System.Collections.Generic;
using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class AddCertificateParameters
    {
        [JsonProperty("certificates")]
        public IEnumerable<string> CertificatesBase64 { get; set; }

        [JsonProperty("bundle")]
        public string Bundle { get; set; }

        [JsonProperty("permanent")]
        public bool Permanent { get; set; }
    }
}
