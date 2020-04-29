using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using OnlineParser.Api.Models;
using OnlineParser.Api.Services;
using System;

namespace OnlineParser.Tests.UnitTests.Services
{
    [TestFixture]
    public class ParserTests
    {
        private Parser _service;

        [SetUp]
        public void SetUp()
        {
            _service = new Parser();
        }

        [Test]
        public void Given_Source_And_Content_When_Transmforming_Content_Then_Should_Return_Serialized_String_Of_Type_NowInStock()
        {
            //Arrange - Given
            var source = "http://www.nowinstock.net";
            var content = "<td>Apr 28 - 9:33 PM EST</td><td>Amazon : Seventh Generation 2 - ply 6 / 2 Out of Stock </td>";
            NowInStock expected = new NowInStock
            {
                Vendor = "Amazon",
                Description = "Seventh Generation 2 - ply 6 / 2",
                Status = "Out of Stock",
                LastStock = new DateTime(2020, 4, 28, 21, 33, 00, 000)
            };

            //Act - When
            var json = _service.Transform(source, content);
            var result = JsonConvert.DeserializeObject<NowInStock>(json);

            //Assert - Then
            result.Should().BeSameAs(expected);
        }

        [TestCase("http://www.nowinstock.net/modules/history")]
        public void Given_Url_When_Getting_ParserName_Then_Returns_NowInStock(string url)
        {
            var value = _service.GetType(url);

            value.Should().Be(ParserType.NowInStock);
        }

        [TestCase("http://www.google.com/")]
        public void Given_Unknown_Url_When_Getting_ParserName_Then_Returns_Unknown(string url)
        {
            var value = _service.GetType(url);

            value.Should().Be(ParserType.Unknown);
        }
    }
}
