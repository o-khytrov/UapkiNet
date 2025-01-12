﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UapkiNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FullVerificationStatus
    {
        [EnumMember(Value = "INDETERMINATE")]
        Indeterminate,

        [EnumMember(Value = "TOTAL-FAILED")]
        TotalFailed,

        [EnumMember(Value = "TOTAL-VALID")]
        TotalValid
    }
}
