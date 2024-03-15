namespace FizzBuzz.Application;

[Flags]
public enum FizzBuzzResult
{
    Number = 1,
    Fizz = 1 << 1,
    Buzz = 1 << 2,
    FizzBuzz = Fizz | Buzz
}