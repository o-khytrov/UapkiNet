using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class CreateKeyRequest: BaseRequest<CreateKeyParameters>
    {
        private const string MethodName = "CREATE_KEY";
        public CreateKeyRequest(CreateKeyParameters parameters) : base(MethodName)
        {
            Parameters = parameters;
        }
    }
}
