using Alrev.Intl.Abstractions.PluralRules;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Alrev.Intl.PluralRules
{
    /// <summary>
    ///   The context to evaluate.
    /// </summary>
    /// <seealso href="http://unicode.org/reports/tr35/tr35-numbers.html#Operands"/>
    public class PluralRulesContext : IPluralRulesContext
    {
        private string _initial = string.Empty;

        /// <summary>
        ///   The original value of the <see cref="PluralRulesContext"/>
        /// </summary>
        public string input { get; private set; } = string.Empty;

        /// <summary>
        ///   Absolute value of the source number.
        /// </summary>
        public double n { get; private set; } = 0;

        /// <summary>
        ///   Integer digits of n.
        /// </summary>
        public int i { get; private set; } = 0;

        /// <summary>
        ///   Number of visible fraction digits in n, with trailing zeros.
        /// </summary>
        public int v { get; private set; } = 0;

        /// <summary>
        ///   Number of visible fraction digits in n, without trailing zeros.
        /// </summary>
        public int w { get; private set; } = 0;

        /// <summary>
        ///   Visible fractional digits in n, with trailing zeros.
        /// </summary>
        public int f { get; private set; } = 0;

        /// <summary>
        ///   Visible fractional digits in n, without trailing zeros.
        /// </summary>
        public int t { get; private set; } = 0;

        /// <summary>
        ///   Currently, synonym for ‘c’. however, may be redefined in the future.
        /// </summary>
        public int e { get; private set; } = 0;

        /// <summary>
        ///   Compact decimal exponent value: exponent of the power of 10 used in compact decimal formatting.
        /// </summary>
        public int c { get; private set; } = 0;

        private PluralRulesContext(string input) => this.input = input;

        /// <summary>
        ///   Creates a <see cref="PluralRulesContext"/> for a specific string.
        /// </summary>
        /// <param name="value">
        ///   The specific string.
        /// </param>
        /// <returns>
        ///   A new context.
        /// </returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static PluralRulesContext Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value), "value must not be null");
            }
            if (!Regex.IsMatch(value, @"^-?[0-9]+(\.[0-9]+)?([ce][0-9]+)?$"))
            {
                throw new ArgumentException($"PluralRulesContext invalid format: {value}", nameof(value));
            }
            PluralRulesContext context = new(value);
            context._initial = value;
            if (Regex.IsMatch(value, @"[ce]"))
            {
                string[] splitted = Regex.Split(value, @"[ce]");
                double sourceNumber = double.Parse(splitted[0], CultureInfo.InvariantCulture);
                int exponent = int.Parse(splitted[1], CultureInfo.InvariantCulture);
                context.n = Math.Abs(sourceNumber) * Math.Pow(10, exponent);
                context.c = context.e = exponent;
                context._initial = context.n.ToString(CultureInfo.InvariantCulture);
            }
            else if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double sourceNumber))
            {
                context.n = Math.Abs(sourceNumber);
            }
            context.i = (int)Math.Truncate(context.n);
            if (context._initial.Contains("."))
            {
                string decimals = context._initial.Split('.')[1];
                context.f = int.Parse(decimals, CultureInfo.InvariantCulture);
                context.v = decimals.Length;
                string trimmed = decimals.TrimEnd('0');
                context.t = trimmed.Length > 0 ? int.Parse(trimmed, CultureInfo.InvariantCulture) : 0;
                context.w = trimmed.Length;
            }
            return context;
        }
    }
}
