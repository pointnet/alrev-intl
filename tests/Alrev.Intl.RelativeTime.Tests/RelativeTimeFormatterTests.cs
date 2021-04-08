using Alrev.Intl.Abstractions.RelativeTime;
using System.Globalization;
using Xunit;

namespace Alrev.Intl.RelativeTime.Tests
{
    [Collection("RelativeTimeFormatter")]
    public class RelativeTimeFormatterTests
    {
        private RelativeTimeFormatterFixture fixture;

        public RelativeTimeFormatterTests(RelativeTimeFormatterFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(-3, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "il y a 3 jours")]
        [InlineData(-2, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "il y a 2 jours")]
        [InlineData(-1, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "il y a 1 jour")]
        [InlineData(0, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "dans 0 jour")]
        [InlineData(1, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "dans 1 jour")]
        [InlineData(1.5, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "dans 1,5 jour")]
        [InlineData(2, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "dans 2 jours")]
        [InlineData(3, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "dans 3 jours")]
        [InlineData(-3, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "il y a 3 jours")]
        [InlineData(-2, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "avant-hier")]
        [InlineData(-1, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "hier")]
        [InlineData(0, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "aujourd’hui")]
        [InlineData(1, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "demain")]
        [InlineData(2, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "après-demain")]
        [InlineData(3, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "dans 3 jours")]
        [InlineData(1000000, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "1 000 000")]
        [InlineData(-1000000, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "-1 000 000")]
        [InlineData(1000001, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "dans 1 000 001 jours")]
        [InlineData(-1000001, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "il y a 1 000 001 jours")]
        public void SpecificCulture_ShouldReturn_LocalizedResource(
            double value,
            RelativeTimeUnitValues unit,
            RelativeTimeStyleValues style,
            RelativeTimeNumericValues numericFormat,
            string expected)
        {
            string localized = this.fixture.Formatter.Format(
                value,
                new CultureInfo("fr"),
                unit,
                style,
                numericFormat);
            Assert.Equal(expected, localized);
        }

        [Theory]
        [InlineData(-3, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "3 days ago")]
        [InlineData(-2, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "2 days ago")]
        [InlineData(-1, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "1 day ago")]
        [InlineData(0, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "in 0 days")]
        [InlineData(1, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "in 1 day")]
        [InlineData(1.5, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "in 1.5 days")]
        [InlineData(2, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "in 2 days")]
        [InlineData(3, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Always, "in 3 days")]
        [InlineData(-3, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "3 days ago")]
        [InlineData(-2, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "2 days ago")]
        [InlineData(-1, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "yesterday")]
        [InlineData(0, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "today")]
        [InlineData(1, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "tomorrow")]
        [InlineData(2, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "in 2 days")]
        [InlineData(3, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "in 3 days")]
        [InlineData(1000000, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "in 1,000,000 days")]
        [InlineData(-1000000, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, RelativeTimeNumericValues.Auto, "1,000,000 days ago")]
        public void CurrentCulture_ShouldReturn_LocalizedResource(
            double value,
            RelativeTimeUnitValues unit,
            RelativeTimeStyleValues style,
            RelativeTimeNumericValues numericFormat,
            string expected)
        {
            string localized = this.fixture.Formatter.Format(
                value,
                unit,
                style,
                numericFormat);
            Assert.Equal(expected, localized);
        }

    }
}
