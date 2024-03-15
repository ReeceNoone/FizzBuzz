// See https://aka.ms/new-console-template for more information

using FizzBuzz.Application;

var fizzBuzzService = new FizzBuzzService();

fizzBuzzService.Reset(1);

for (var i = 0; i < 100; i++)
{
    Console.WriteLine(fizzBuzzService.Next());
}