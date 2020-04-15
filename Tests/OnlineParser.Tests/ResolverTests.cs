using FluentAssertions;
using NUnit.Framework;
using OnlineParser.Api.Models;
using OnlineParser.Api.Services;

namespace OnlineParser.Tests
{
    public class ResolverTests
    {
        private Resolver _resolver;

        [SetUp]
        public void Setup()
        {
            _resolver = new Resolver();
        }

        [TestCase("http://www.nowinstock.net/modules/history")]
        public void Given_Url_When_Getting_ParserName_Then_Returns_NowInStock(string url)
        {
            var value = _resolver.GetType(url);

            value.Should().Be(ParserName.NowInStock);
        }

        [TestCase("http://www.google.com/")]
        public void Given_Unknown_Url_When_Getting_ParserName_Then_Returns_Unknown(string url)
        {
            var value = _resolver.GetType(url);

            value.Should().Be(ParserName.Unknown);
        }

        [TestCase("http://www.nowinstock.net/modules/history")]
        [TestCase("http://www.nowinstock.net/modules/history")]
        [TestCase("http://nowinstock.net/modules/history")]
        [TestCase("http://amazon.nowinstock.org/modules/history")]
        public void Given_Url_When_Getting_Parser_Then_Parser_Is_Type_NowInStockParser(string url)
        {
            var parser = _resolver.Get(url);

            parser.Should().BeOfType<NowInStockParser>();
        }

        [TestCase("http://www.google.com/modules/history")]
        public void Given_Unknown_Url_When_Getting_Parser_Then_Parser_Is_Type_Parser(string url)
        {
            var parser = _resolver.Get(url);

            parser.Should().BeOfType<Parser>();
        }
    }
}