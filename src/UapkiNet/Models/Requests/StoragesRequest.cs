using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class StoragesRequest : BaseRequest<StoragesParameters>
    {
        private const string MethodName = "STORAGES";
        public StoragesRequest(string providerId) : base(MethodName)
        {
            Parameters = new StoragesParameters()
            {
                Provider = providerId
            };
        }
    }
}
