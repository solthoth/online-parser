using FluentAssertions;
using NUnit.Framework;
using OnlineParser.Api.Controllers;
using System;
using NSubstitute;
using RestSharp;

namespace OnlineParser.Tests.UnitTests.Services
{
    [TestFixture]
    public class InvokerTests
    {
        private Invoker _service;
        private IRestClient _client;

        [SetUp]
        public void Setup()
        {
            _client = Substitute.For<IRestClient>();
            _service = new Invoker(_client);
        }

        [Test]
        public void Given_Url_When_Getting_Cotent_Then_Does_Not_Raise_Exception()
        {
            var url = "https://www.google.com";

            Action action = () => _service.Get(url);

            action.Should().NotThrow();
        }
    }
}
