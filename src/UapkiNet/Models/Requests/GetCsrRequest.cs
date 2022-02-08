using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class GetCsrRequest: BaseRequest<GetCsrParameters>
    {
        private const string MethodName = "GET_CSR";
        public GetCsrRequest(string signAlgorithm = null) : base(MethodName)
        {
            Parameters = new GetCsrParameters()
            {
                SignAlgorithm = signAlgorithm
            };
        }
    }
}
