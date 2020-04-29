using Newtonsoft.Json;
using OnlineParser.Api.Models;
using System;

namespace OnlineParser.Api.Services
{
    public interface IParser
    {
        string Transform(string source, string content);
    }

    public class Parser : IParser
    {
        public string Transform(string source, string content)
        {
            var parserType = GetType(source);
            //TODO: decipher html content into object types
            //TODO: -- (parserType / HTML & XML) => XPath.Convert(content)
            return JsonConvert.SerializeObject(new NowInStock());
        }

        public ParserType GetType(string source)
        {
            var urlParser = new UrlParser(source);
            if (urlParser.HostName.Contains("nowinstock"))
                return ParserType.NowInStock;
            return ParserType.Unknown;
        }
    }
}