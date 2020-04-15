using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using OnlineParser.Api.Controllers;

namespace OnlineParser.Tests.Controllers
{
    public class ParserTests
    {
        private ParserController _parser;

        [SetUp]
        public void Setup()
        {
            _parser = new ParserController();
        }

        [TestCase("http://google.com?q=testing")]
        public void Given_Unknown_Url_When_Getting_Content_Then_Returns_BadRequest(string url)
        {
            var result = _parser.Get(url);

            result.Should().BeOfType<BadRequestResult>();
        }

        [TestCase("http://www.nowinstock.com")]
        [TestCase("http://www.nowinstock.com/history/data")]
        public void Given_Known_Url_When_Getting_Content_Then_Returns_OkObjectResult(string url)
        {
            var result = _parser.Get(url);

            result.Should().BeOfType<OkObjectResult>();
        }
    }
}
