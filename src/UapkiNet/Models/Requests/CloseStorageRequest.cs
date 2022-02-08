﻿namespace UapkiNet.Models.Requests
{
    internal class CloseStorageRequest: BaseRequest
    {
        private const string MethodName = "CLOSE";
        public CloseStorageRequest() : base(MethodName)
        {
        }
    }
}
