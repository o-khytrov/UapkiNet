using System.Collections.Generic;
using Newtonsoft.Json;
using UapkiNet.Models.Asn1;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class Asn1DecodeParameters
    {
        [JsonProperty("items")]
        public List<ItemToDecode> Items { get; set; }
    }
}
