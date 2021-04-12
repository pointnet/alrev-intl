using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using System;
using System.Globalization;

namespace Alrev.Intl.PluralRules
{
    /// <summary>
    /// PluralRulesEvaluator class is used to evaluate an input
    /// </summary>
    public class PluralRulesEvaluator : IPluralRulesEvaluator
    {
        private IResourceSetLocalizer<IPluralRulesResource> CardinalLocalizer { get; }
        private IResourceSetLocalizer<IPluralRulesResource> OrdinalLocalizer { get; }

        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="cardinalLocalizer">A Cardinal Plural Rules Localizer</param>
        /// <param name="ordinalLocalizer">An Ordinal Plural Rules Localizer</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PluralRulesEvaluator(IResourceSetLocalizer<IPluralRulesResource> cardinalLocalizer, IResourceSetLocalizer<IPluralRulesResource> ordinalLocalizer)
        {
            this.CardinalLocalizer = cardinalLocalizer ?? throw new ArgumentNullException(nameof(cardinalLocalizer), "IResourceSetLocalizer<IPluralRulesResource> must not be null");
            this.OrdinalLocalizer = ordinalLocalizer ?? throw new ArgumentNullException(nameof(ordinalLocalizer), "IResourceSetLocalizer<IPluralRulesResource> must not be null");
        }

        /// <summary>
        /// Evaluate <see cref="PluralRulesValues"/> for the specific <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="value">The integer value to evaluate</param>
        /// <param name="rulesType">The localizer type</param>
        /// <param name="culture">The <see cref="CultureInfo"/> to evaluate</param>
        /// <returns>A <see cref="PluralRulesValues"/> corresponding to the specified value</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="CultureNotFoundException"></exception>
        public PluralRulesValues Evaluate(int value, PluralRulesTypeValues rulesType, CultureInfo culture)
            => this.Evaluate(PluralRulesContext.Create(value.ToString(CultureInfo.InvariantCulture)), rulesType, culture);

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
        public PluralRulesValues Evaluate(double value, PluralRulesTypeValues rulesType, CultureInfo culture)
            => this.Evaluate(PluralRulesContext.Create(value.ToString(CultureInfo.InvariantCulture)), rulesType, culture);

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
        public PluralRulesValues Evaluate(string value, PluralRulesTypeValues rulesType, CultureInfo culture)
            => this.Evaluate(PluralRulesContext.Create(value), rulesType, culture);

        /// <summary>
        /// Indicates whether the specified <see cref="CultureInfo"/> is supported
        /// </summary>
        /// <param name="rulesType">The localizer type</param>
        /// <param name="culture">The <see cref="CultureInfo"/> to test</param>
        /// <returns>true if the <see cref="CultureInfo"/> is supported, otherwise false</returns>
        /// <remarks>
        /// If the specified <see cref="CultureInfo"/> does not exists, it will try to use the parent <see cref="CultureInfo"/> of the specified one.
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public bool IsSupported(PluralRulesTypeValues rulesType, CultureInfo culture) => rulesType switch
        {
            PluralRulesTypeValues.Cardinal => this.CardinalLocalizer.IsSupported(culture),
            PluralRulesTypeValues.Ordinal => this.OrdinalLocalizer.IsSupported(culture),
            _ => throw new ArgumentException("Unknown PluralRulesTypeValues", nameof(rulesType))
        };

        private PluralRulesValues Evaluate(IPluralRulesContext context, PluralRulesTypeValues rulesType, CultureInfo culture)
        {
            IPluralRulesResource resource = rulesType switch
            {
                PluralRulesTypeValues.Cardinal => this.CardinalLocalizer.GetLocalizer(culture),
                PluralRulesTypeValues.Ordinal => this.OrdinalLocalizer.GetLocalizer(culture),
                _ => throw new ArgumentException("Unknown PluralRulesTypeValues", nameof(rulesType))
            };
            if (resource is null)
            {
                throw new CultureNotFoundException(nameof(culture), "Specified culture was not found in plural rules localizer");
            }
            return resource.Evaluate(context);
        }
    }
}
