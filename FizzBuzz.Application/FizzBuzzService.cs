using System.Text;

namespace FizzBuzz.Application;

public class FizzBuzzService : IFizzBuzzService
{
    private int _current;

    public void Reset(int start = 1)
    {
        _current = start;
    }

    public string Next()
    {
        var result = GetResult(_current) switch
        {
            FizzBuzzResult.FizzBuzz => "Fizzbuzz",
            FizzBuzzResult.Fizz => "Fizz",
            FizzBuzzResult.Buzz => "Buzz",
            _ => _current.ToString()
        };

        _current++;

        return result;
    }

    private static FizzBuzzResult GetResult(int number)
    {
        var result = (FizzBuzzResult)0;

        if (number % 3 == 0)
        {
            result |= FizzBuzzResult.Fizz;
        }

        if (number % 5 == 0)
        {
            result |= FizzBuzzResult.Buzz;
        }

        return result == 0 ? FizzBuzzResult.Number : result;
    }
}