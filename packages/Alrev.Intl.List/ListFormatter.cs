using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.List;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Alrev.Intl.List
{
    public class ListFormatter : IListFormatter
    {
        private IResourceLocalizer<IListResource> Localizer { get; }

        public ListFormatter(IResourceLocalizer<IListResource> localizer)
        {
            this.Localizer = localizer ?? throw new ArgumentNullException(nameof(localizer), "IResourceLocalizer<IListResource> is null");
        }

        public string Format(params string[] values)
            => this.Format(CultureInfo.CurrentCulture, ListTypeValues.Conjunction, IntlStyleValues.Long, values);

        public string Format(
            ListTypeValues type = ListTypeValues.Conjunction,
            params string[] values)
            => this.Format(CultureInfo.CurrentCulture, type, IntlStyleValues.Long, values);

        public string Format(
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values)
            => this.Format(CultureInfo.CurrentCulture, ListTypeValues.Conjunction, style, values);

        public string Format(
            ListTypeValues type = ListTypeValues.Conjunction,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values)
            => this.Format(CultureInfo.CurrentCulture, type, style, values);

        public string Format(
            CultureInfo culture,
            params string[] values)
            => this.Format(culture, ListTypeValues.Conjunction, IntlStyleValues.Long, values);

        public string Format(
            CultureInfo culture,
            ListTypeValues type = ListTypeValues.Conjunction,
            params string[] values)
            => this.Format(culture, type, IntlStyleValues.Long, values);

        public string Format(
            CultureInfo culture,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values)
            => this.Format(culture, ListTypeValues.Conjunction, style, values);

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
