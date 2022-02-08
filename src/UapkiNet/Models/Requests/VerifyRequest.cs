using System;
using UapkiNet.Enums;
using UapkiNet.Models.Verifying;

namespace UapkiNet.Models.Requests
{
    internal class VerifyRequest: BaseRequest<Verify>
    {
        private const string MethodName = "VERIFY";
        public VerifyRequest(SignatureFormat format, Verify verify) : base(MethodName)
        {
            Parameters = verify;
            EnsureFieldsSet(format);
        }

        private void EnsureFieldsSet(SignatureFormat format)
        {
            var rawNotValid = string.IsNullOrEmpty(Parameters.SignatureData.SignedDataBase64) ||
                              string.IsNullOrEmpty(Parameters.SignatureData.OriginalDataBase64) ||
                              string.IsNullOrEmpty(Parameters.SignatureParameters.SignatureAlgorithm) ||
                              string.IsNullOrEmpty(Parameters.SignerParameters.CertificateIdBase64);

            var cadesCmsNotValid = string.IsNullOrEmpty(Parameters.SignatureData.SignedDataBase64);

            if ((cadesCmsNotValid && format != SignatureFormat.Raw) ||
                (rawNotValid && format == SignatureFormat.Raw))
            {
                throw new ArgumentException($"Parameters not valid for format {format:G}");
            }
        }
    }
}
