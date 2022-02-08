using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UapkiNet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum  StorageOpenMode
    {
        [EnumMember(Value = "RW")]
        ReadWrite,

        [EnumMember(Value = "RO")]
        ReadOnly,

        [EnumMember(Value = "CREATE")]
        Create
    }
}
