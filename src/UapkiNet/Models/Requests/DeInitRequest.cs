namespace UapkiNet.Models.Requests
{
    internal class DeInitRequest: BaseRequest
    {
        private const string MethodName = "DEINIT";
        public DeInitRequest() : base(MethodName)
        {
        }
    }
}
