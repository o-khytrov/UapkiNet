using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class ListCertificatesRequest: BaseRequest<ListCertificatesParameters>
    {
        private const string MethodName = "INIT";
        public ListCertificatesRequest(int pageNumber, int? pageSize) : base(MethodName)
        {
            Parameters = new ListCertificatesParameters()
            {
                Offset = pageSize.HasValue ? pageNumber * pageSize.Value : 0,
                PageSize = pageSize
            };
        }
    }
}
