using System;
using UapkiNet.Enums;

namespace UapkiNet.Interfaces
{
    public interface ICertificateValidation
    {
        CertificateStatus Status { get; set; }
        RevocationReason? RevocationReason { get; set; }
        DateTime? RevocationTime { get; set; }
    }
}
