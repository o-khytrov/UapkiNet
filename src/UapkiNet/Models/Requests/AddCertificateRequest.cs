﻿using System;
using System.Linq;
using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class AddCertificateRequest: BaseRequest<AddCertificateParameters>
    {
        private const string MethodName = "ADD_CERT";
        public AddCertificateRequest(byte[][] certificates, bool permanent) : base(MethodName)
        {
            Parameters = new AddCertificateParameters()
            {
                CertificatesBase64 = certificates.Select(s=>Convert.ToBase64String(s)),
                Permanent = permanent
            };
        }

        public AddCertificateRequest(byte[] bundle, bool permanent) : base(MethodName)
        {
            Parameters = new AddCertificateParameters()
            {
                Bundle = Convert.ToBase64String(bundle),
                Permanent = permanent
            };
        }
    }
}
