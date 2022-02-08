using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class ChangePasswordRequest: BaseRequest<ChangePasswordParameters>
    {
        private const string MethodName = "CREATE_KEY";
        public ChangePasswordRequest(string oldPassword, string newPassword) : base(MethodName)
        {
            Parameters = new ChangePasswordParameters()
            {
                OldPassword = oldPassword,
                NewPassword = newPassword
            };
        }
    }
}
