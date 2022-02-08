using System.Collections.Generic;
using Newtonsoft.Json;
using UapkiNet.Models.Asn1;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class Asn1EncodeParameters
    {
        [JsonProperty("items")]
        public List<ItemToEncode> Items { get; set; }
    }
}
