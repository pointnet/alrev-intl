using System;
using System.Globalization;

namespace Alrev.Intl.Abstractions.List
{
    /// <summary>
    /// Defines a List formatter
    /// </summary>
    public interface IListFormatter
    {
        /// <summary>
        /// Combines an array of strings into a localized List string using the <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        string Format(params string[] values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="type">A <see cref="ListTypeValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        string Format(
            ListTypeValues type = ListTypeValues.Conjunction,
            params string[] values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="style">A <see cref="IntlStyleValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        string Format(
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="type">A <see cref="ListTypeValues"/></param>
        /// <param name="style">A <see cref="IntlStyleValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        string Format(
            ListTypeValues type = ListTypeValues.Conjunction,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">A <see cref="CultureInfo"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        string Format(
            CultureInfo culture,
            params string[] values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">A <see cref="CultureInfo"/></param>
        /// <param name="type">A <see cref="ListTypeValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        string Format(
            CultureInfo culture,
            ListTypeValues type = ListTypeValues.Conjunction,
            params string[] values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">A <see cref="CultureInfo"/></param>
        /// <param name="style">A <see cref="IntlStyleValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        string Format(
            CultureInfo culture,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">A <see cref="CultureInfo"/></param>
        /// <param name="type">A <see cref="ListTypeValues"/></param>
        /// <param name="style">A <see cref="IntlStyleValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        string Format(
            CultureInfo culture,
            ListTypeValues type = ListTypeValues.Conjunction,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values);
    }
}
