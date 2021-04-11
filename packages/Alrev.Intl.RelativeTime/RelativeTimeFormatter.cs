﻿using Alrev.Intl.Abstractions;
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
        private IResourceSetLocalizer<IRelativeTimeResourceSet> Localizer { get; }
        private IPluralRulesEvaluator PluralRules { get; }

        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="localizer">A Relative Time ResourceSet Localizer</param>
        /// <param name="pluralRules">A Plural Rules Evaluator</param>
        public RelativeTimeFormatter(IResourceSetLocalizer<IRelativeTimeResourceSet> localizer, IPluralRulesEvaluator pluralRules)
        {
            //this.Localizer = localizer ?? new RelativeTimeLocalizer();
            //this.PluralRules = pluralRules ?? new PluralRulesEvaluator();
            this.Localizer = localizer ?? throw new ArgumentNullException(nameof(localizer), "IResourceSetLocalizer<IRelativeTimeResourceSet> must not be null");
            this.PluralRules = pluralRules ?? throw new ArgumentNullException(nameof(pluralRules), "IPluralRulesEvaluator must not be null");
        }

        /// <summary>
        /// Format the current value to a localized relative time using <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="value">The value to format</param>
        /// <param name="unit">The <see cref="RelativeTimeUnitValues"/> used for formatting, default: RelativeTimeUnitValues.Second</param>
        /// <param name="style">The <see cref="RelativeTimeStyleValues"/> used for formatting, default: RelativeTimeStyleValues.Long</param>
        /// <param name="numericFormat">The <see cref="RelativeTimeNumericValues"/> used for formatting, default: RelativeTimeNumericValues.Always</param>
        /// <returns>The relative time localized resource of the specified value</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="CultureNotFoundException"></exception>
        /// <exception cref="NotImplementedException"></exception>
        public string Format(
            double value,
            RelativeTimeUnitValues unit = RelativeTimeUnitValues.Second,
            RelativeTimeStyleValues style = RelativeTimeStyleValues.Long,
            RelativeTimeNumericValues numericFormat = RelativeTimeNumericValues.Always)
            => this.Format(value, CultureInfo.CurrentCulture, unit, style, numericFormat);

        /// <summary>
        /// Format the current value to a localized relative time using the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="value">The value to format</param>
        /// <param name="culture">The <see cref="CultureInfo"/> to use</param>
        /// <param name="unit">The <see cref="RelativeTimeUnitValues"/> used for formatting, default: RelativeTimeUnitValues.Second</param>
        /// <param name="style">The <see cref="RelativeTimeStyleValues"/> used for formatting, default: RelativeTimeStyleValues.Long</param>
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
            RelativeTimeStyleValues style = RelativeTimeStyleValues.Long,
            RelativeTimeNumericValues numericFormat = RelativeTimeNumericValues.Always)
        {
            IRelativeTimeResource resource = this.Localizer
                .GetLocalizer(culture)
                .GetRelativeTimeStylesResource(unit)
                .GetRelativeTimeResource(style);
            PluralRulesValues rule = this.PluralRules.Evaluate(value, PluralRulesTypeValues.Cardinal, culture);
            IPluralRulesContext context = PluralRulesContext.Create(value.ToString(CultureInfo.InvariantCulture));
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
            return value.ToString($"N{context.v}", culture);
        }
    }
}
