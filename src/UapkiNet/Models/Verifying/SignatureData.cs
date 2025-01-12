﻿using Newtonsoft.Json;

namespace UapkiNet.Models.Verifying
{
    public class SignatureData
    {
        [JsonProperty("bytes")]
        public string SignedDataBase64 { get; set; }

        [JsonProperty("content")]
        public string OriginalDataBase64 { get; set; }

        [JsonProperty("isDigest")]
        public bool IsDigest { get; set; }
    }
}
