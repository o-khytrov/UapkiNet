using System;
using Newtonsoft.Json;
using UapkiNet.Utils;

namespace UapkiNet.Models.Asn1
{
    public class ItemToDecode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("bytes")]
        internal string BytesBase64 { get; set; } 

        public byte[] Bytes
        {
            get => ConvertExtension.FromBase64OrNull(BytesBase64);
            set => BytesBase64 = Convert.ToBase64String(value);
        }
    }
}
