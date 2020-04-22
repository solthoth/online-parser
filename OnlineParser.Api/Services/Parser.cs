namespace OnlineParser.Api.Services
{
    public interface IParser
    {
        string Transform(string url, string content);
    }

    public class Parser : IParser
    {
        public string Transform(string url, string content)
        {
            throw new System.NotImplementedException();
            //TODO: Determine type of parser from url
            //TODO: decipher html content into object types
            //TODO: Serialize objects into JSON string - Might be another service
        }
    }
}