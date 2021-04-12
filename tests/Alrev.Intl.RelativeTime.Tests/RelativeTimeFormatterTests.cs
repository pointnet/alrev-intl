using Alrev.Intl.Abstractions.RelativeTime;
using Alrev.Intl.PluralRules;
using Alrev.Intl.PluralRules.Globalization;
using Alrev.Intl.RelativeTime.Globalization;
using System;
using System.Globalization;
using System.Threading;
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

        [Fact]
        public void NullRelativeTimeLocalizer_ShouldThrow_ArgumentNullException()
        {
            Exception ex = Record.Exception(() => new RelativeTimeFormatter(
                null,
                new PluralRulesEvaluator(new PluralRulesCardinalLocalizer(), new PluralRulesOrdinalLocalizer())));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Fact]
        public void NullPluralRulesEvaluator_ShouldThrow_ArgumentNullException()
        {
            Exception ex = Record.Exception(() => new RelativeTimeFormatter(new RelativeTimeLocalizer(), null));
            Assert.IsType<ArgumentNullException>(ex);
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

        [Fact]
        public void SpecificFrenchMillion_ShouldReturn_LocalizedValue()
        {
            string localized = this.fixture.Formatter.Format(
                1000000,
                new CultureInfo("fr"),
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                RelativeTimeNumericValues.Auto);
            Assert.StartsWith("1", localized);
            Assert.EndsWith("0", localized);
            Assert.Equal(9, localized.Length);
        }

        [Fact]
        public void SpecificFrenchNegativeMillion_ShouldReturn_LocalizedValue()
        {
            string localized = this.fixture.Formatter.Format(
                -1000000,
                new CultureInfo("fr"),
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                RelativeTimeNumericValues.Auto);
            Assert.StartsWith("-", localized);
            Assert.EndsWith("0", localized);
            Assert.Equal(10, localized.Length);
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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            string localized = this.fixture.Formatter.Format(
                value,
                unit,
                style,
                numericFormat);
            Assert.Equal(expected, localized);
        }


        [Fact]
        public void IsSupportedNullCultureInfo_ShouldThrow_ArgumentNullException()
        {
            Exception ex = Record.Exception(() => this.fixture.Formatter.IsSupported(null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Fact]
        public void IsSupportedFrench_ShouldReturn_True()
        {
            bool supported = this.fixture.Formatter.IsSupported(new CultureInfo("fr"));
            Assert.True(supported);
        }
    }
}
