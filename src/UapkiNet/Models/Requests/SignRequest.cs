using UapkiNet.Models.Signing;

namespace UapkiNet.Models.Requests
{
    internal class SignRequest: BaseRequest<Sign>
    {
        private const string MethodName = "SIGN";
        public SignRequest(Sign parameters) : base(MethodName)
        {
            Parameters = parameters;
        }
    }
}
