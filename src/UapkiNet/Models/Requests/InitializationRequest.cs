using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class InitializationRequest: BaseRequest<InitializationParameters>
    {
        private const string MethodName = "INIT";
        public InitializationRequest() : base(MethodName)
        {
        }

    }
}
