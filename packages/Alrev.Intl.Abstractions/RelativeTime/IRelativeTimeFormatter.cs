using System;
using System.Globalization;

namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// Interface of a Relative Time Formatter
    /// </summary>
    public interface IRelativeTimeFormatter
    {
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
        string Format(
            double value,
            RelativeTimeUnitValues unit = RelativeTimeUnitValues.Second,
            RelativeTimeStyleValues style = RelativeTimeStyleValues.Long,
            RelativeTimeNumericValues numericFormat = RelativeTimeNumericValues.Always);

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
        string Format(
            double value,
            CultureInfo culture,
            RelativeTimeUnitValues unit = RelativeTimeUnitValues.Second,
            RelativeTimeStyleValues style = RelativeTimeStyleValues.Long,
            RelativeTimeNumericValues numericFormat = RelativeTimeNumericValues.Always);
    }
}