using UapkiNet.Interfaces;

namespace UapkiNet.Models.Requests
{
    internal class OpenStorageRequest : BaseRequest<IStorageOpenParameters>
    {
        private const string MethodName = "OPEN";
        public OpenStorageRequest(IStorageOpenParameters storageOpenParameters) : base(MethodName)
        {
            Parameters = storageOpenParameters;
        }
    }
}
