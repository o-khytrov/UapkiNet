﻿using System;
using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class CertificateInformationRequest: BaseRequest<CertificateInformationParameters>
    {
        private const string MethodName = "CERT_INFO";
        public CertificateInformationRequest(byte[] certificate) : base(MethodName)
        {
            Parameters = new CertificateInformationParameters()
            {
                BytesBase64 = Convert.ToBase64String(certificate)
            };
        }

        public CertificateInformationRequest(string certificateId) : base(MethodName)
        {
            Parameters = new CertificateInformationParameters()
            {
                CertificateIdBase64 = certificateId
            };
        }
    }
}
