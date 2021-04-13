using System.Diagnostics.CodeAnalysis;

namespace Alrev.Intl.Abstractions.PluralRules
{
    /// <summary>
    /// Defines a Plural Rules evaluation context
    /// </summary>
    /// <seealso href="http://unicode.org/reports/tr35/tr35-numbers.html#Operands"/>
    public interface IPluralRulesContext
    {
        /// <summary>
        /// The original value of the <see cref="IPluralRulesContext"/>
        /// </summary>
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        string input { get; }


        /// <summary>
        /// Absolute value of the source number.
        /// </summary>
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        double n { get; }

        /// <summary>
        /// Integer digits of n.
        /// </summary>
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        int i { get; }

        /// <summary>
        /// Number of visible fraction digits in n, with trailing zeros.
        /// </summary>
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        int v { get; }

        /// <summary>
        /// Number of visible fraction digits in n, without trailing zeros.
        /// </summary>
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        int w { get; }

        /// <summary>
        /// Visible fractional digits in n, with trailing zeros.
        /// </summary>
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        int f { get; }

        /// <summary>
        /// Visible fractional digits in n, without trailing zeros.
        /// </summary>
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        int t { get; }

        /// <summary>
        /// Currently, synonym for ‘c’. however, may be redefined in the future.
        /// </summary>
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        int e { get; }

        /// <summary>
        /// Compact decimal exponent value: exponent of the power of 10 used in compact decimal formatting.
        /// </summary>
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        int c { get; }
    }
}
