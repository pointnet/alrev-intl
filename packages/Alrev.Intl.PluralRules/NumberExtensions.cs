using System;
using System.Linq;

namespace Alrev.Intl.PluralRules
{
    /// <summary>
    /// Provides numbers extensions methods
    /// </summary>
    public static class NumberExtensions
    {
        /// <summary>
        /// Check if a number is in a specific list of numbers
        /// </summary>
        /// <param name="input">A number to test</param>
        /// <param name="args">An array of numbers</param>
        /// <returns>true if the number is in the list, otherwise false</returns>
        public static bool In(this double input, params double[] args) => args.Contains(input);

        /// <summary>
        /// Check if a number is in a specific list of numbers
        /// </summary>
        /// <param name="input">A number to test</param>
        /// <param name="args">An array of numbers</param>
        /// <returns>true if the number is in the list, otherwise false</returns>
        public static bool In(this int input, params double[] args) => ((double)input).In(args);

        /// <summary>
        /// Check if a number is not in a specific list of numbers
        /// </summary>
        /// <param name="input">A number to test</param>
        /// <param name="args">An array of numbers</param>
        /// <returns>true if the number is not in the list, otherwise false</returns>
        public static bool NotIn(this double input, params double[] args) => !input.In(args);

        /// <summary>
        /// Check if a number is in not a specific list of numbers
        /// </summary>
        /// <param name="input">A number to test</param>
        /// <param name="args">An array of numbers</param>
        /// <returns>true if the number is not in the list, otherwise false</returns>
        public static bool NotIn(this int input, params double[] args) => ((double)input).NotIn(args);

        /// <summary>
        /// Check if a number is between two specific numbers
        /// </summary>
        /// <param name="input">A number to test</param>
        /// <param name="from">The lowest number included</param>
        /// <param name="to">The highest number included</param>
        /// <returns>true if the number is between the two specified numbers, otherwise false</returns>
        public static bool Between(this double input, int from, int to) => input >= from && input <= to;

        /// <summary>
        /// Check if a number is between two specific numbers
        /// </summary>
        /// <param name="input">A number to test</param>
        /// <param name="from">The lowest number included</param>
        /// <param name="to">The highest number included</param>
        /// <returns>true if the number is between the two specified numbers, otherwise false</returns>
        public static bool Between(this int input, int from, int to) => ((double)input).Between(from, to);

        /// <summary>
        /// Check if a number is not between two specific numbers
        /// </summary>
        /// <param name="input">A number to test</param>
        /// <param name="from">The lowest number included</param>
        /// <param name="to">The highest number included</param>
        /// <returns>true if the number is not between the two specified numbers, otherwise false</returns>
        public static bool NotBetween(this double input, int from, int to) => !input.Between(from, to);

        /// <summary>
        /// Check if a number is not between two specific numbers
        /// </summary>
        /// <param name="input">A number to test</param>
        /// <param name="from">The lowest number included</param>
        /// <param name="to">The highest number included</param>
        /// <returns>true if the number is not between the two specified numbers, otherwise false</returns>
        public static bool NotBetween(this int input, int from, int to) => ((double)input).NotBetween(from, to);
    }
}
