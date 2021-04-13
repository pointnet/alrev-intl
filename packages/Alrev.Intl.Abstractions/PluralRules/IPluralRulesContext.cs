namespace Alrev.Intl.Abstractions.PluralRules
{
    /// <summary>
    ///   Defines a Plural Rules Context
    /// </summary>
    /// <seealso href="http://unicode.org/reports/tr35/tr35-numbers.html#Operands"/>
    public interface IPluralRulesContext
    {
        /// <summary>
        ///   The original value of the <see cref="IPluralRulesContext"/>
        /// </summary>
        string input { get; }

        /// <summary>
        ///   Absolute value of the source number.
        /// </summary>
        double n { get; }

        /// <summary>
        ///   Integer digits of n.
        /// </summary>
        int i { get; }

        /// <summary>
        ///   Number of visible fraction digits in n, with trailing zeros.
        /// </summary>
        int v { get; }

        /// <summary>
        ///   Number of visible fraction digits in n, without trailing zeros.
        /// </summary>
        int w { get; }

        /// <summary>
        ///   Visible fractional digits in n, with trailing zeros.
        /// </summary>
        int f { get; }

        /// <summary>
        ///   Visible fractional digits in n, without trailing zeros.
        /// </summary>
        int t { get; }

        /// <summary>
        ///   Currently, synonym for ‘c’. however, may be redefined in the future.
        /// </summary>
        int e { get; }

        /// <summary>
        ///   Compact decimal exponent value: exponent of the power of 10 used in compact decimal formatting.
        /// </summary>
        int c { get; }
    }
}
