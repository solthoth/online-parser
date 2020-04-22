using RestSharp;
using System;

namespace OnlineParser.Api.Controllers
{
    public interface IInvoker
    {
        string Get(string url);
    }

    public class Invoker : IInvoker
    {
        private readonly IRestClient _restClient;

        public Invoker(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public string Get(string url)
        {
            return GetWebRequest(url);
        }

        private string GetWebRequest(string url)
        {
            var request = new RestRequest(url);
            return _restClient.Get(request).Content;
        }
    }
}