using System;

namespace OnlineParser.Api.Services
{
    public interface IUrlParser
    { 
    }

    public class UrlParser
    {
        private readonly Uri uri;
        public UrlParser(string url)
        {
            uri = new Uri(url.ToLower());
        }

        public string HostName => uri.Host;
    }
}
