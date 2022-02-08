namespace UapkiNet.Models.Requests
{
    internal class KeysRequest: BaseRequest
    {
        private const string MethodName = "KEYS";
        public KeysRequest() : base(MethodName)
        {
        }
    }
}
