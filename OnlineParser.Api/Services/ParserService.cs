using System;

namespace OnlineParser.Api.Controllers
{
    public interface IParserService
    {
        string Parse(string url);
    }

    public class ParserService
    {
        public string Parse(string url)
        {
            throw new NotImplementedException();
        }
    }
}