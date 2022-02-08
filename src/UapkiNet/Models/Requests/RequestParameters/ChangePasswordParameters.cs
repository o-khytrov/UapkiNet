using Newtonsoft.Json;

namespace UapkiNet.Models.Requests.RequestParameters
{
    internal class ChangePasswordParameters
    {
        [JsonProperty("password")]
        public string OldPassword { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }
    }
}
