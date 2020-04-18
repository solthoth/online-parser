using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NHibernate.Mapping;
using NSubstitute;
using NUnit.Framework;
using OnlineParser.Api.Controllers;

namespace OnlineParser.Tests.Controllers
{
    public class ParserControllerTests
    {
        private ParserController _parser;
        private IParserService _service;

        [SetUp]
        public void Setup()
        {
            _service = Substitute.For<IParserService>();
            _parser = new ParserController(_service);
        }

        [TestCase("http://google.com?q=testing")]
        [TestCase("http://www.nowinstock.com")]
        [TestCase("http://www.nowinstock.com/history/data")]
        public void Given_Unknown_Url_When_Getting_Content_Then_Returns_BadRequest(string url)
        {
            var result = _parser.Get(url);

            result.Should().BeOfType<BadRequestResult>();
        }

        [TestCase("http://google.com?q=testing")]
        [TestCase("http://www.nowinstock.com")]
        [TestCase("http://www.nowinstock.com/history/data")]
        public void Given_Known_Url_When_Getting_Content_Then_Returns_OkObjectResult(string url)
        {
            _service.Parse("").ReturnsForAnyArgs("[]");
            var result = _parser.Get(url);

            result.Should().BeOfType<OkObjectResult>();
        }
    }
}
