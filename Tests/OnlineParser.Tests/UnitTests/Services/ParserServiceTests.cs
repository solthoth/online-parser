using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using OnlineParser.Api.Controllers;
using OnlineParser.Api.Services;

namespace OnlineParser.Tests.UnitTests.Services
{
    [TestFixture]
    public class ParserServiceTests
    {
        private IInvoker _invoker;
        private ParserService _service;
        private IParser _parser;

        [SetUp]
        public void Setup()
        {
            _invoker = Substitute.For<IInvoker>();
            _parser = Substitute.For<IParser>();
            _service = new ParserService(_invoker, _parser);
        }

        [Test]
        public void Given_Url_When_Parsing_Content_Then_Returns_NotEmptyString()
        {
            //Arrange
            var url = "http://www.solthoth.com/dev-test.html";
            _parser.Transform("","").ReturnsForAnyArgs("TEST");

            //ACT
            var content = _service.Parse(url);//SUT

            //ASSERT
            content.Should().NotBeNullOrEmpty();
        }
    }
}
