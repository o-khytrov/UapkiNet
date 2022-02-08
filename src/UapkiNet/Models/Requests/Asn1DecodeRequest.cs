using System.Collections.Generic;
using UapkiNet.Models.Asn1;
using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class Asn1DecodeRequest: BaseRequest<Asn1DecodeParameters>
    {
        private const string MethodName = "ASN1_DECODE";
        public Asn1DecodeRequest(List<ItemToDecode> itemsToDecode) : base(MethodName)
        {
            Parameters = new Asn1DecodeParameters()
            {
                Items = itemsToDecode
            };
        }
    }
}
