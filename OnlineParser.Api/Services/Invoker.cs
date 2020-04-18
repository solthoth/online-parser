using System;

namespace OnlineParser.Api.Controllers
{
    public interface IInvoker
    {
        string Get(string url);
    }

    public class Invoker : IInvoker
    {
        public string Get(string url)
        {
            //TODO: Make web request call
            //TODO: Return conten
            throw new NotImplementedException();
        }
    }
}