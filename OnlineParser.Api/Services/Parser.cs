namespace OnlineParser.Api.Services
{
    public interface IParser
    {
        string Transform(string content);
    }

    public class Parser : IParser
    {
        public string Transform(string content)
        {
            throw new System.NotImplementedException();
        }
    }
}