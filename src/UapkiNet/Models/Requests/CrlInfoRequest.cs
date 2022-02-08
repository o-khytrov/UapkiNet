using System;
using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class CrlInfoRequest: BaseRequest<CrlInfoParameters>
    {
        private const string MethodName = "CRL_INFO";
        public CrlInfoRequest(byte[] crlBytes) : base(MethodName)
        {
            Parameters = new CrlInfoParameters()
            {
                BytesBase64 = Convert.ToBase64String(crlBytes)
            };
        }
    }
}
