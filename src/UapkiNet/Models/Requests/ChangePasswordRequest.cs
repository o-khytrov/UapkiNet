using UapkiNetStandard20.Models.Requests.RequestParameters;

namespace UapkiNetStandard20.Models.Requests
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
