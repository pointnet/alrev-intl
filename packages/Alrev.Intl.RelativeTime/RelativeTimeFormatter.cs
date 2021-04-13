using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.Abstractions.RelativeTime;
using Alrev.Intl.PluralRules;
using System;
using System.Globalization;

namespace Alrev.Intl.RelativeTime
{
    /// <summary>
    /// Relative Time Formatter
    /// </summary>
    public class RelativeTimeFormatter : IRelativeTimeFormatter
    {
        private IResourceLocalizer<IRelativeTimeUnitsResource> Localizer { get; }
        private IPluralRulesEvaluator PluralRules { get; }

        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="localizer">A Relative Time ResourceSet Localizer</param>
        /// <param name="pluralRules">A Plural Rules Evaluator</param>
        /// <exception cref="ArgumentNullException"></exception>
        public RelativeTimeFormatter(IResourceLocalizer<IRelativeTimeUnitsResource> localizer, IPluralRulesEvaluator pluralRules)
        {
            this.Localizer = localizer ?? throw new ArgumentNullException(nameof(localizer), "IResourceLocalizer<IRelativeTimeUnitsResource> is null");
            this.PluralRules = pluralRules ?? throw new ArgumentNullException(nameof(pluralRules), "IPluralRulesEvaluator is null");
        }

        /// <summary>
        /// Format the current value to a localized relative time using <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="value">The value to format</param>
        /// <param name="unit">The <see cref="RelativeTimeUnitValues"/> used for formatting, default: RelativeTimeUnitValues.Second</param>
        /// <param name="style">The <see cref="IntlStyleValues"/> used for formatting, default: IntlStyleValues.Long</param>
        /// <param name="numericFormat">The <see cref="RelativeTimeNumericValues"/> used for formatting, default: RelativeTimeNumericValues.Always</param>
        /// <returns>The relative time localized resource of the specified value</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="CultureNotFoundException"></exception>
        /// <exception cref="NotImplementedException"></exception>
        public string Format(
            double value,
            RelativeTimeUnitValues unit = RelativeTimeUnitValues.Second,
            IntlStyleValues style = IntlStyleValues.Long,
            RelativeTimeNumericValues numericFormat = RelativeTimeNumericValues.Always)
            => this.Format(value, CultureInfo.CurrentCulture, unit, style, numericFormat);

        /// <summary>
        /// Format the current value to a localized relative time using the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="value">The value to format</param>
        /// <param name="culture">The <see cref="CultureInfo"/> to use</param>
        /// <param name="unit">The <see cref="RelativeTimeUnitValues"/> used for formatting, default: RelativeTimeUnitValues.Second</param>
        /// <param name="style">The <see cref="IntlStyleValues"/> used for formatting, default: IntlStyleValues.Long</param>
        /// <param name="numericFormat">The <see cref="RelativeTimeNumericValues"/> used for formatting, default: RelativeTimeNumericValues.Always</param>
        /// <returns>The relative time localized resource of the specified value</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="CultureNotFoundException"></exception>
        /// <exception cref="NotImplementedException"></exception>
        public string Format(
            double value,
            CultureInfo culture,
            RelativeTimeUnitValues unit = RelativeTimeUnitValues.Second,
            IntlStyleValues style = IntlStyleValues.Long,
            RelativeTimeNumericValues numericFormat = RelativeTimeNumericValues.Always)
        {
            return unit switch
            {
                RelativeTimeUnitValues.Unknown => throw new ArgumentException("RelativeTimeUnitValues.Unknown is not supported", nameof(unit)),
                _ => style switch
                {
                    IntlStyleValues.Unknown => throw new ArgumentException("IntlStyleValues.Unknown is not supported", nameof(style)),
                    _ => numericFormat switch
                    {
                        RelativeTimeNumericValues.Unknown => throw new ArgumentException("RelativeTimeNumericValues.Unknown is not supported", nameof(unit)),
                        _ => this.FormatInternal(value, culture, unit, style, numericFormat)
                    }
                }
            };
        }

        private string FormatInternal(
            double value,
            CultureInfo culture,
            RelativeTimeUnitValues unit = RelativeTimeUnitValues.Second,
            IntlStyleValues style = IntlStyleValues.Long,
            RelativeTimeNumericValues numericFormat = RelativeTimeNumericValues.Always)
        {
            IPluralRulesContext context = PluralRulesContext.Create(value.ToString(CultureInfo.InvariantCulture));
            if (this.Localizer.IsSupported(culture))
            {
                IRelativeTimeResource resource = this.Localizer
                    .ResolveResource(culture)[unit][style];
                PluralRulesValues rule = this.PluralRules.Evaluate(value, PluralRulesTypeValues.Cardinal, culture);
                if (Math.Ceiling(value) == Math.Floor(value)
                    && numericFormat == RelativeTimeNumericValues.Auto
                    && resource.ContainsKey((int)value))
                {
                    return string.Format(resource[(int)value], value.ToString($"N{context.v}", culture));
                }
                if (value < 0 && resource.Past.ContainsKey(rule))
                {
                    return string.Format(resource.Past[rule], Math.Abs(value).ToString($"N{context.v}", culture));
                }
                if (value >= 0 && resource.Future.ContainsKey(rule))
                {
                    return string.Format(resource.Future[rule], value.ToString($"N{context.v}", culture));
                }
            }
            return value.ToString($"N{context.v}", culture);
        }

        /// <summary>
        /// Indicates whether the specified <see cref="CultureInfo"/> is supported
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/> to test</param>
        /// <returns>true if the <see cref="CultureInfo"/> is supported, otherwise false</returns>
        /// <remarks>
        /// If the specified <see cref="CultureInfo"/> does not exists, it will try to use the parent <see cref="CultureInfo"/> of the specified one.
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        public bool IsSupported(CultureInfo culture) => this.Localizer.IsSupported(culture);
    }
}
