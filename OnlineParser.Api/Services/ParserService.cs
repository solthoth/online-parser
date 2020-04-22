using OnlineParser.Api.Services;
using System;

namespace OnlineParser.Api.Controllers
{
    public interface IParserService
    {
        string Parse(string url);
    }

    public class ParserService
    {
        private readonly IInvoker _invoker;
        private readonly IParser _parser;

        public ParserService(IInvoker invoker, IParser parser)
        {
            _invoker = invoker;
            _parser = parser;
        }

        public string Parse(string url)
        {
            var content = _invoker.Get(url);
            return _parser.Transform(url, content);
        }
    }
}