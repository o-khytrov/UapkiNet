using System.Collections.Generic;
using Newtonsoft.Json;

namespace UapkiNet.Models
{
    internal class AddCertificateResult
    {
        [JsonProperty("added")]
        public List<CertificateStorageRecord> Certificates { get; set; }
    }


}
