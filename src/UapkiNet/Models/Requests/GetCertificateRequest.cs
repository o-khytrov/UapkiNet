using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class GetCertificateRequest: BaseRequest<CertificateIdParameters>
    {
        private const string MethodName = "GET_CERT";
        public GetCertificateRequest(string certificateId) : base(MethodName)
        {
            Parameters = new CertificateIdParameters()
            {
                CertificateIdBase64 = certificateId
            };
        }
    }
}
