using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UapkiNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CertificateValidationType
    {
        [EnumMember(Value = "CRL")]
        Crl,

        [EnumMember(Value = "OCSP")]
        Ocsp,
    }
}
