using System.Collections.Generic;
using Newtonsoft.Json;

namespace UapkiNet.Models.Certificate
{
    public class DecodedExtensionInformation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public Dictionary<string, object> Value { get; set; }
    }
}
