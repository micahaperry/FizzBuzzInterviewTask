namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_WhenPassedAndInt_ReturnsAString()
        {
            //test here
            var FizzBuzz = new FizzBuzz();

            var output = FizzBuzz.FizzBuzzifyAnInt(1);

            output.Should().Be("1");
        }
    }
}
