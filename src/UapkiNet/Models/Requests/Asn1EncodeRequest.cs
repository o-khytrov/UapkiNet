using System.Collections.Generic;
using UapkiNet.Models.Asn1;
using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class Asn1EncodeRequest : BaseRequest<Asn1EncodeParameters>
    {
        private const string MethodName = "ASN1_ENCODE";
        public Asn1EncodeRequest(List<ItemToEncode> items) : base(MethodName)
        {
            Parameters = new Asn1EncodeParameters()
            {
                Items = items
            };
        }
    }
}
