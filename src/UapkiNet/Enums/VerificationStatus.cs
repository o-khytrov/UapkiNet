using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UapkiNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VerificationStatus
    {
        [EnumMember(Value = "VALID")]
        Valid,

        [EnumMember(Value = "INVALID")]
        Invalid,

        [EnumMember(Value = "FAILED")]
        Failed
    }
}
