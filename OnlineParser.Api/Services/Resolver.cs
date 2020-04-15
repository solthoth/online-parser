using OnlineParser.Api.Models;
using System;

namespace OnlineParser.Api.Services
{
    public interface IResolver
    {
        public Parser Get(string url);
    }

    public class Resolver
    {
        public Parser Get(string url)
        {
            return (GetType(url)) switch
            {
                ParserName.NowInStock => new NowInStockParser(),
                _ => new Parser(),
            };
        }

        public ParserName GetType(string url)
        {
            var urlParser = new UrlParser(url);
            if (urlParser.HostName.Contains("nowinstock"))
                return ParserName.NowInStock;
            return ParserName.Unknown;
        }
    }
}
