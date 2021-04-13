using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.RelativeTime;
using Alrev.Intl.RelativeTime.Tests.Fixtures;
using System;
using System.Globalization;
using System.Threading;
using Xunit;

namespace Alrev.Intl.RelativeTime.Tests
{
    [Collection("RelativeTimeFormatter")]
    public class RelativeTimeFormatterTests
    {
        private RelativeTimeFormatterFixture Fixture { get; }

        public RelativeTimeFormatterTests(RelativeTimeFormatterFixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public void NullRelativeTimeLocalizer_ShouldThrow_ArgumentNullException()
        {
            Exception ex = Record.Exception(() => new RelativeTimeFormatter(null, this.Fixture.Evaluator));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Fact]
        public void NullPluralRulesEvaluator_ShouldThrow_ArgumentNullException()
        {
            Exception ex = Record.Exception(() => new RelativeTimeFormatter(this.Fixture.Localizer, null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Theory]
        [InlineData(-3, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "il y a 3 jours")]
        [InlineData(-2, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "il y a 2 jours")]
        [InlineData(-1, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "il y a 1 jour")]
        [InlineData(0, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "dans 0 jour")]
        [InlineData(1, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "dans 1 jour")]
        [InlineData(1.5, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "dans 1,5 jour")]
        [InlineData(2, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "dans 2 jours")]
        [InlineData(3, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "dans 3 jours")]
        [InlineData(-3, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "il y a 3 jours")]
        [InlineData(-2, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "avant-hier")]
        [InlineData(-1, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "hier")]
        [InlineData(0, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "aujourd’hui")]
        [InlineData(1, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "demain")]
        [InlineData(2, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "après-demain")]
        [InlineData(3, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "dans 3 jours")]
        public void SpecificCulture_ShouldReturn_LocalizedResource(
            double value,
            RelativeTimeUnitValues unit,
            IntlStyleValues style,
            RelativeTimeNumericValues numericFormat,
            string expected)
        {
            string localized = this.Fixture.Formatter.Format(
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
            string localized = this.Fixture.Formatter.Format(
                1000000,
                new CultureInfo("fr"),
                RelativeTimeUnitValues.Day,
                IntlStyleValues.Long,
                RelativeTimeNumericValues.Auto);
            Assert.StartsWith("1", localized);
            Assert.EndsWith("0", localized);
            Assert.Equal(9, localized.Length);
        }

        [Fact]
        public void SpecificFrenchNegativeMillion_ShouldReturn_LocalizedValue()
        {
            string localized = this.Fixture.Formatter.Format(
                -1000000,
                new CultureInfo("fr"),
                RelativeTimeUnitValues.Day,
                IntlStyleValues.Long,
                RelativeTimeNumericValues.Auto);
            Assert.StartsWith("-", localized);
            Assert.EndsWith("0", localized);
            Assert.Equal(10, localized.Length);
        }

        [Theory]
        [InlineData(-3, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "3 days ago")]
        [InlineData(-2, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "2 days ago")]
        [InlineData(-1, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "1 day ago")]
        [InlineData(0, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "in 0 days")]
        [InlineData(1, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "in 1 day")]
        [InlineData(1.5, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "in 1.5 days")]
        [InlineData(2, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "in 2 days")]
        [InlineData(3, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Always, "in 3 days")]
        [InlineData(-3, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "3 days ago")]
        [InlineData(-2, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "2 days ago")]
        [InlineData(-1, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "yesterday")]
        [InlineData(0, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "today")]
        [InlineData(1, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "tomorrow")]
        [InlineData(2, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "in 2 days")]
        [InlineData(3, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "in 3 days")]
        [InlineData(1000000, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "in 1,000,000 days")]
        [InlineData(-1000000, RelativeTimeUnitValues.Day, IntlStyleValues.Long, RelativeTimeNumericValues.Auto, "1,000,000 days ago")]
        public void CurrentCulture_ShouldReturn_LocalizedResource(
            double value,
            RelativeTimeUnitValues unit,
            IntlStyleValues style,
            RelativeTimeNumericValues numericFormat,
            string expected)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            string localized = this.Fixture.Formatter.Format(
                value,
                unit,
                style,
                numericFormat);
            Assert.Equal(expected, localized);
        }


        [Fact]
        public void IsSupportedNullCultureInfo_ShouldThrow_ArgumentNullException()
        {
            Exception ex = Record.Exception(() => this.Fixture.Formatter.IsSupported(null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Fact]
        public void IsSupportedFrench_ShouldReturn_True()
        {
            bool supported = this.Fixture.Formatter.IsSupported(new CultureInfo("fr"));
            Assert.True(supported);
        }

        [Fact]
        public void UnitUnknown_ShouldThrow_ArgumentException()
        {
            Exception ex = Record.Exception(() => this.Fixture.Formatter.Format(0, RelativeTimeUnitValues.Unknown));
            Assert.IsType<ArgumentException>(ex);
        }

        [Fact]
        public void StyleUnknown_ShouldThrow_ArgumentException()
        {
            Exception ex = Record.Exception(() => this.Fixture.Formatter.Format(0, style: IntlStyleValues.Unknown));
            Assert.IsType<ArgumentException>(ex);
        }

        [Fact]
        public void NumericUnknown_ShouldThrow_ArgumentException()
        {
            Exception ex = Record.Exception(() => this.Fixture.Formatter.Format(0, numericFormat: RelativeTimeNumericValues.Unknown));
            Assert.IsType<ArgumentException>(ex);
        }
    }
}
