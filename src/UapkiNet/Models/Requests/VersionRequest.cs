namespace UapkiNet.Models.Requests
{
    internal class VersionRequest: BaseRequest
    {
        private const string MethodName = "VERSION";
        public VersionRequest(): base(MethodName)
        {
        }
    }
}
