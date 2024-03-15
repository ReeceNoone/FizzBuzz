using FizzBuzz.Application;
using Xunit;

namespace FizzBuzz.UnitTests;

public class FizzBuzzServiceTests
{
    private readonly FizzBuzzService _fizzBuzzService;

    public FizzBuzzServiceTests()
    {
        _fizzBuzzService = new FizzBuzzService();
    }

    [Theory]
    [InlineData(1, "1")]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "Fizzbuzz")]
    public void NextShould_ReturnExpectedResult(int number, string expectedResult)
    {
        // Arrange
        _fizzBuzzService.Reset(number);

        // Act
        var result = _fizzBuzzService.Next();

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RestartShould_ResetCurrentNumber()
    {
        // Arrange
        _fizzBuzzService.Reset(1);
        _fizzBuzzService.Next();
        _fizzBuzzService.Next();
        _fizzBuzzService.Next();

        // Act
        _fizzBuzzService.Reset(1);

        // Assert
        Assert.Equal("1", _fizzBuzzService.Next());
    }
}