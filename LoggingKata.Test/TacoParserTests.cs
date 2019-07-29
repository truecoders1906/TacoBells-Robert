using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }

        [Theory]
        [InlineData("34.073638,-84.677017,Taco Bell Acwort... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("34.035985,-84.683302,Taco Bell Acworth/... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("34.087508,-84.575512,Taco Bell Acworth/... (Free trial * Add to Cart for a full POI info)")]
        public void ShouldParse(string str)
        {
            // Arrange
            TacoParser tacoParser = new TacoParser();

            // Act
            ITrackable actual = tacoParser.Parse(str);

            // Assert
            Assert.NotNull(actual);
            Assert.NotNull(actual.Location);
            Assert.NotNull(actual.Name);
            Assert.True(actual.Name.Length > 0);

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            TacoParser tacoparser = new TacoParser();
            ITrackable actual = tacoparser.Parse(str);
            Assert.Null(actual);
        }
    }
}
