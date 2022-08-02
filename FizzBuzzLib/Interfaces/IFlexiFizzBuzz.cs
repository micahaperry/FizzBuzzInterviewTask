namespace FizzBuzzLib
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface that adds the ability to set custom translations (instead of the default Fizz=3, Buzz=5)
    /// </summary>
    interface IFlexiFizzBuzz
    {
        /// <summary>
        /// Dictionary listing all translations as key and value.
        /// </summary>
        /// 
        /// <example>
        /// Default FizzBuzz dictionary would be 
        /// <code>
        /// Dictionary&lt;int,string&gt; pairs = new Dictionary&lt;int,string&gt;()
        /// {
        ///     {3, "Fizz"},
        ///     {5, "Buzz"}
        /// };
        /// </code>
        /// </example>
    Dictionary<int,string> ReplacementPairs { get; }
    }
}
