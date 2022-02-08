using System;
using UapkiNet.Enums;
using UapkiNet.Models.Certificate;

namespace UapkiNet.Models.Requests
{
    internal class VerifyCertificateRequest: BaseRequest<VerifyCertificateParameters>
    {
        private const string MethodName = "VERIFY_CERT";
        private const string DateFormat = "yyyy-MM-dd HH:mm:ss";
        public VerifyCertificateRequest(byte[] certificate, CertificateValidationType validationType, DateTime? validationTime) : base(MethodName)
        {
            Parameters = new VerifyCertificateParameters()
            {
                BytesBase64 = Convert.ToBase64String(certificate),
                ValidationType = validationType,
                ValidationTime = validationTime?.ToString(DateFormat)
            };
            ValidateParameters();
        }

        public VerifyCertificateRequest(string certificateId, CertificateValidationType validationType, DateTime? validationTime) : base(MethodName)
        {
            Parameters = new VerifyCertificateParameters()
            {
                CertificateIdBase64 = certificateId,
                ValidationType = validationType,
                ValidationTime = validationTime?.ToString(DateFormat)
            };
            ValidateParameters();
        }

        private void ValidateParameters()
        {
            if (Parameters.ValidationType == CertificateValidationType.Crl && Parameters.ValidationTime == null)
            {
                throw new ArgumentNullException("crlValidateTime", "Parameter crlValidateTime can not be null when validationType is Crl");
            }
        }
    }
}
