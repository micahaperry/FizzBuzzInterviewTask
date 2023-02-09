namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();
            string value = fizzBuzzer.FizzBuzzifyAnInt(3); //I used this to test aswell
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
