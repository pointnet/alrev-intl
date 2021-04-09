using System;
using System.Globalization;

namespace Alrev.Intl.Abstractions.PluralRules
{
    /// <summary>
    /// Interface of the Pural Rules Evaluator
    /// </summary>
    public interface IPluralRulesEvaluator
    {
        /// <summary>
        /// Evaluate <see cref="PluralRulesValues"/> for the specific <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="value">The decimal value to evaluate</param>
        /// <param name="rulesType">The localizer type</param>
        /// <param name="culture">The <see cref="CultureInfo"/> to evaluate</param>
        /// <returns>A <see cref="PluralRulesValues"/> corresponding to the specified value</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="CultureNotFoundException"></exception>
        PluralRulesValues Evaluate(double value, PluralRulesTypeValues rulesType, CultureInfo culture);

        /// <summary>
        /// Evaluate <see cref="PluralRulesValues"/> for the specific <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="value">The double value to evaluate</param>
        /// <param name="rulesType">The localizer type</param>
        /// <param name="culture">The <see cref="CultureInfo"/> to evaluate</param>
        /// <returns>A <see cref="PluralRulesValues"/> corresponding to the specified value</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="CultureNotFoundException"></exception>
        PluralRulesValues Evaluate(int value, PluralRulesTypeValues rulesType, CultureInfo culture);

        /// <summary>
        /// Evaluate <see cref="PluralRulesValues"/> for the specific <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="value">The string value to evaluate</param>
        /// <param name="rulesType">The localizer type</param>
        /// <param name="culture">The <see cref="CultureInfo"/> to evaluate</param>
        /// <returns>A <see cref="PluralRulesValues"/> corresponding to the specified value</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="CultureNotFoundException"></exception>
        PluralRulesValues Evaluate(string value, PluralRulesTypeValues rulesType, CultureInfo culture);
    }
}