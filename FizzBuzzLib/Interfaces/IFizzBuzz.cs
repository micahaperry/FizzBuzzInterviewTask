namespace FizzBuzzLib
{
    /// <summary>
    /// Implents simple fizzbuzz
    /// </summary>
    interface IFizzBuzz
    {
        /// <summary>
        /// Simple fizzbuzz implementation, using Fizz=3 and Buzz=5
        /// </summary>
        /// <param name="input">The integer to convert</param>
        /// <returns>string that contains Fizz when divisible by 3, Buzz when divisible by 5, FizzBuzz when divisible by both, or the <paramref name="input"/> as a string if none of the conditions apply.</returns>
        string FizzBuzzifyAnInt(int input);
    }
}
