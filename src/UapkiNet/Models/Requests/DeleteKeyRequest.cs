using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class DeleteKeyRequest: BaseRequest<IdParameters>
    {
        private const string MethodName = "DELETE_KEY";
        public DeleteKeyRequest(string id) : base(MethodName)
        {
            Parameters = new IdParameters
            {
                Id = id
            };
        }
    }
}
