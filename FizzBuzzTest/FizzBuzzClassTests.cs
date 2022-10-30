using FizzBuzz.Models;

namespace FizzBuzzTest
{
    // Thought about doing tests for the database, but I haven't done
    // the likes of that before and I'm unfortunately too busy currently
    // to go learn it
    public class FizzBuzzClassTests
    {
        [Fact]
        public void NumbersNotDivisibleByThreeOrFiveShouldReturnItself()
        {
            Assert.Equal("1", FizzBuzzClass.GetFizzBuzzText(1));
            Assert.Equal("2", FizzBuzzClass.GetFizzBuzzText(2));
            Assert.Equal("7", FizzBuzzClass.GetFizzBuzzText(7));
            Assert.Equal("62", FizzBuzzClass.GetFizzBuzzText(62));
        }


        [Theory]
        [InlineData(3)]
        [InlineData(21)]
        [InlineData(57)]
        [InlineData(72)]
        public void NumbersDivisibleByThreeShouldFizz(int x)
        {
            string text = FizzBuzzClass.GetFizzBuzzText(x);
            Assert.Equal("Fizz", text);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(25)]
        [InlineData(50)]
        [InlineData(70)]
        public void NumbersDivisibleByFiveShouldBuzz(int x)
        {
            string text = FizzBuzzClass.GetFizzBuzzText(x);
            Assert.Equal("Buzz", text);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(45)]
        [InlineData(90)]
        public void NumbersDivisibleByFifteenShouldFizzBuzz(int n)
        {
            string text = FizzBuzzClass.GetFizzBuzzText(n);
            Assert.Equal("FizzBuzz", text);
        }

    }
}