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

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...", 31.570771)]
        [InlineData("32.524378,-84.88839,Taco Bell Columbus...", 32.524378)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoLongitude = new TacoParser();
            //Act
            var actual = tacoLongitude.Parse(line);
            //Assert
            Assert.NotNull(actual);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("30.392476,-86.498396,Taco Bell Desti...", 30.392476)]
        [InlineData("34.118399,-87.989494,Taco Bell Hamilto...", 34.118399)]
        [InlineData("33.701519,-84.268396,Taco Bell Decatur...", 33.701519)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var tacoLatitude = new TacoParser();

            //Act
            var actual = tacoLatitude.Parse(line);

            //Assert
            Assert.NotNull (actual);
        }

    }
}
