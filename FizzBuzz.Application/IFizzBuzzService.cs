namespace FizzBuzz.Application;

public interface IFizzBuzzService
{
    public void Reset(int start = 1);

    public string Next();
}