using System.Collections.Generic;
using Newtonsoft.Json;

namespace UapkiNet.Models.Signing
{
    public class Sign
    {
        [JsonProperty("signParams")]
        public SignParameters SignParameters { get; set; }

        [JsonProperty("dataTbs")]
        public List<DataParameters> DataParameters { get; set; }

        [JsonProperty("keyParams")]
        public KeyParameters KeyParameters { get; set; }
    }
}
