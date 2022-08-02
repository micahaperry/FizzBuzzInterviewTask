namespace FizzBuzzLib
{
    using System.Collections.Generic;

    /// <summary>
    /// Implements FizzBuzz across an inclusive range
    /// </summary>
    interface IFizzBuzzRange
    {
        /// <summary>
        /// Runs FizzBuzz across a set range, including both the <paramref name="start"/> and <paramref name="end"/> ints.
        /// </summary>
        /// <param name="start">The int to begin the operation on.</param>
        /// <param name="end">The int to end the operation on.</param>
        /// <returns>An IEnumerable with the values substituted for applicable integers.</returns>
        /// <remarks>Should throw when an int is negative or <paramref name="end"/> is lower than <paramref name="start"/></remarks>
        /// <exception cref="System.NotImplementedException"></exception>
        IEnumerable<string> FizzBuzzValuesForRange(int start, int end);
    }
}
