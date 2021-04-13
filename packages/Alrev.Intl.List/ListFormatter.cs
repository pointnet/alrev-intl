using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.List;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Alrev.Intl.List
{
    /// <summary>
    /// List Formatter
    /// </summary>
    public class ListFormatter : IListFormatter
    {
        private IResourceLocalizer<IListResource> Localizer { get; }

        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="localizer">a List resource localizer</param>
        public ListFormatter(IResourceLocalizer<IListResource> localizer)
        {
            this.Localizer = localizer ?? throw new ArgumentNullException(nameof(localizer), "IResourceLocalizer<IListResource> is null");
        }

        /// <summary>
        /// Combines an array of strings into a localized List string using the <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public string Format(params string[] values)
            => this.Format(CultureInfo.CurrentCulture, ListTypeValues.Conjunction, IntlStyleValues.Long, values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="type">A <see cref="ListTypeValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public string Format(
            ListTypeValues type = ListTypeValues.Conjunction,
            params string[] values)
            => this.Format(CultureInfo.CurrentCulture, type, IntlStyleValues.Long, values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="style">A <see cref="IntlStyleValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public string Format(
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values)
            => this.Format(CultureInfo.CurrentCulture, ListTypeValues.Conjunction, style, values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="type">A <see cref="ListTypeValues"/></param>
        /// <param name="style">A <see cref="IntlStyleValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public string Format(
            ListTypeValues type = ListTypeValues.Conjunction,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values)
            => this.Format(CultureInfo.CurrentCulture, type, style, values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">A <see cref="CultureInfo"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public string Format(
            CultureInfo culture,
            params string[] values)
            => this.Format(culture, ListTypeValues.Conjunction, IntlStyleValues.Long, values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">A <see cref="CultureInfo"/></param>
        /// <param name="type">A <see cref="ListTypeValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public string Format(
            CultureInfo culture,
            ListTypeValues type = ListTypeValues.Conjunction,
            params string[] values)
            => this.Format(culture, type, IntlStyleValues.Long, values);

        /// <summary>
        /// Combines an array of strings into a localized List string using the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">A <see cref="CultureInfo"/></param>
        /// <param name="style">A <see cref="IntlStyleValues"/></param>
        /// <param name="values">An array of strings</param>
        /// <returns>A localized List string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public string Format(
            CultureInfo culture,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values)
            => this.Format(culture, ListTypeValues.Conjunction, style, values);

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
        public string Format(
            CultureInfo culture,
            ListTypeValues type = ListTypeValues.Conjunction,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values)
        {
            return values switch
            {
                null => throw new ArgumentNullException(nameof(values), "values is null"),
                string[] v when v.Length == 0 => string.Empty,
                string[] v when v.Length == 1 => v[0],
                _ => type switch
                {
                    ListTypeValues.Unknown => throw new ArgumentException("ListTypeValues.Unknown is not supported", nameof(type)),
                    _ => style switch
                    {
                        IntlStyleValues.Unknown => throw new ArgumentException("IntlStyleValues.Unknown is not supported", nameof(style)),
                        _ => this.FormatInternal(culture, type, style, values)
                    }
                }
            };
        }

        private string FormatInternal(
            CultureInfo culture,
            ListTypeValues type = ListTypeValues.Conjunction,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values)
        {
            if (!this.Localizer.IsSupported(culture))
            {
                return string.Join(" ", values);
            }
            IListResource resource = this.Localizer.ResolveResource(culture);
            IReadOnlyDictionary<ListPartValues, string> parts = resource[type][style];
            if (values.Length == 2)
            {
                return string.Format(parts[ListPartValues.Pair], values[0], values[1]);
            }
            string formatted = values[0];
            for (int i = 0; i < values.Length - 1; i++)
            {
                string pattern = i switch
                {
                    0 => parts[ListPartValues.Start],
                    int v when v == values.Length - 2 => parts[ListPartValues.End],
                    _ => parts[ListPartValues.Middle]
                };
                formatted = string.Format(pattern, formatted, values[i + 1]);
            }
            return formatted;
        }
    }
}
