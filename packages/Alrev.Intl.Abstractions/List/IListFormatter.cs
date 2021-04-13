using System.Globalization;

namespace Alrev.Intl.Abstractions.List
{
    public interface IListFormatter
    {
        string Format(params string[] values);

        string Format(
            ListTypeValues type = ListTypeValues.Conjunction,
            params string[] values);

        string Format(
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values);

        string Format(
            ListTypeValues type = ListTypeValues.Conjunction,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values);

        string Format(
            CultureInfo culture,
            params string[] values);

        string Format(
            CultureInfo culture,
            ListTypeValues type = ListTypeValues.Conjunction,
            params string[] values);

        string Format(
            CultureInfo culture,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values);

        string Format(
            CultureInfo culture,
            ListTypeValues type = ListTypeValues.Conjunction,
            IntlStyleValues style = IntlStyleValues.Long,
            params string[] values);
    }
}
