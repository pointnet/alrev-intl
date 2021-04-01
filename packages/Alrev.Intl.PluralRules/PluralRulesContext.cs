using Alrev.Intl.Abstractions.PluralRules;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Alrev.Intl.PluralRules
{
    // http://unicode.org/reports/tr35/tr35-numbers.html#Operands
    public class PluralRulesContext : IPluralRulesContext
    {
        private string _initial = string.Empty;

        public string input { get; private set; } = string.Empty;

        public double n { get; private set; } = 0;

        public int i { get; private set; } = 0;

        public int v { get; private set; } = 0;

        public int w { get; private set; } = 0;

        public int f { get; private set; } = 0;

        public int t { get; private set; } = 0;

        public int e { get; private set; } = 0;

        public int c { get; private set; } = 0;

        private PluralRulesContext(string input) => this.input = input;

        public static PluralRulesContext Create(int value) => Create(value.ToString(CultureInfo.InvariantCulture));

        public static PluralRulesContext Create(decimal value) => Create(value.ToString(CultureInfo.InvariantCulture));

        public static PluralRulesContext Create(double value) => Create(value.ToString(CultureInfo.InvariantCulture));

        public static PluralRulesContext Create(string value)
        {
            if (!Regex.IsMatch(value, @"^-?[0-9]+(\.[0-9]+)?([ce][0-9]+)?$"))
            {
                throw new ArgumentException($"PluralRulesContext invalid format: {value}");
            }
            PluralRulesContext context = new(value);
            context._initial = value;
            if (Regex.IsMatch(value, @"[ce]"))
            {
                string[] splitted = Regex.Split(value, @"[ce]");
                if (double.TryParse(splitted[0], out double sourceNumber)
                    && int.TryParse(splitted[1], out int exponent))
                {
                    context.n = Math.Abs(sourceNumber) * Math.Pow(10, exponent);
                    context.c = context.e = exponent;
                    context._initial = context.n.ToString(CultureInfo.InvariantCulture);
                }
            }
            else if (double.TryParse(value, out double sourceNumber))
            {
                context.n = Math.Abs(sourceNumber);
            }
            context.i = (int)Math.Truncate(context.n);
            if (context._initial.Contains("."))
            {
                string decimals = context._initial.Split('.')[1];
                context.f = decimals.Length > 0 ? int.Parse(decimals) : 0;
                context.v = decimals.Length;
                string trimmed = decimals.TrimEnd('0');
                context.t = trimmed.Length > 0 ? int.Parse(trimmed) : 0;
                context.w = trimmed.Length;
            }
            return context;
        }
    }
}
