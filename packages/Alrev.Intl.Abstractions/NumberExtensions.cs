using System;
using System.Linq;

namespace Alrev.Intl.Abstractions
{
    public static class NumberExtensions
    {
        public static bool In(this double input, params double[] args) => args.Contains(input);
        public static bool In(this int input, params double[] args) => ((double)input).In(args);
        public static bool NotIn(this double input, params double[] args) => !input.In(args);
        public static bool NotIn(this int input, params double[] args) => ((double)input).NotIn(args);
        public static bool Between(this double input, int from, int to) => input >= from && input <= to;
        public static bool Between(this int input, int from, int to) => ((double)input).Between(from, to);
        public static bool NotBetween(this double input, int from, int to) => !input.Between(from, to);
        public static bool NotBetween(this int input, int from, int to) => ((double)input).NotBetween(from, to);
    }
}
