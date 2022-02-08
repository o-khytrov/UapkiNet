using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UapkiNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CertificateStatus
    {
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        [EnumMember(Value = "GOOD")]
        Good,

        [EnumMember(Value = "REVOKED")]
        Revoked,

        [EnumMember(Value = "UNKNOWN")]
        Unknown
    }
}
