//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Script: ./scripts/cldr-relative-time.csx
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.RelativeTime;
using System;
using System.Globalization;
using Xunit;


namespace Alrev.Intl.RelativeTime.Tests.Resources.Tests.Resources
{
    [Collection("RelativeTimeLocalizer")]
    public class TurkishCyprusRelativeTimeResourceSetTests
    {
        private RelativeTimeLocalizerFixture fixture;

        public TurkishCyprusRelativeTimeResourceSetTests(RelativeTimeLocalizerFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void UnknownRelativeTimeUnit_ShouldThrow_NotImplementedException()
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("tr-cy"));
            Exception ex = Record.Exception(() => resourceSet.GetRelativeTimeStylesResource(RelativeTimeUnitValues.Unknown));
            Assert.IsType<NotImplementedException>(ex);
        }

        [Theory]
        [InlineData(RelativeTimeUnitValues.Era)]
        [InlineData(RelativeTimeUnitValues.Year)]
        [InlineData(RelativeTimeUnitValues.Quarter)]
        [InlineData(RelativeTimeUnitValues.Month)]
        [InlineData(RelativeTimeUnitValues.Week)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth)]
        [InlineData(RelativeTimeUnitValues.Day)]
        [InlineData(RelativeTimeUnitValues.DayOfYear)]
        [InlineData(RelativeTimeUnitValues.Weekday)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth)]
        [InlineData(RelativeTimeUnitValues.Sunday)]
        [InlineData(RelativeTimeUnitValues.Monday)]
        [InlineData(RelativeTimeUnitValues.Tuesday)]
        [InlineData(RelativeTimeUnitValues.Wednesday)]
        [InlineData(RelativeTimeUnitValues.Thursday)]
        [InlineData(RelativeTimeUnitValues.Friday)]
        [InlineData(RelativeTimeUnitValues.Saturday)]
        [InlineData(RelativeTimeUnitValues.DayPeriod)]
        [InlineData(RelativeTimeUnitValues.Hour)]
        [InlineData(RelativeTimeUnitValues.Minute)]
        [InlineData(RelativeTimeUnitValues.Second)]
        [InlineData(RelativeTimeUnitValues.Zone)]
        public void UnknownRelativeTimeStyle_ShouldThrow_NotImplementedException(RelativeTimeUnitValues unit)
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("tr-cy"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            Exception ex = Record.Exception(() => resourceStyles.GetRelativeTimeResource(RelativeTimeStyleValues.Unknown));
            Assert.IsType<NotImplementedException>(ex);
        }

        [Theory]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Long, "çağ", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Narrow, "çağ", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Short, "çağ", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Long, "yıl", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Narrow, "yıl", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Short, "yıl", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Long, "çeyrek", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Narrow, "çyr.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Short, "çyr.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Long, "ay", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Narrow, "ay", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Short, "ay", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Long, "hafta", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Narrow, "hf.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Short, "hf.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Long, "ayın haftası", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Narrow, "ayın haftası", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Short, "ayın haftası", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, "gün", 5, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Narrow, "gün", 5, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Short, "gün", 5, 2, 2)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Long, "yılın günü", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Narrow, "yılın günü", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Short, "yılın günü", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Long, "haftanın günü", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Narrow, "haftanın günü", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Short, "haftanın günü", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Long, "ayın günü", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Narrow, "ayın günü", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Short, "ayın günü", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Sunday, RelativeTimeStyleValues.Long, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Sunday, RelativeTimeStyleValues.Narrow, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Sunday, RelativeTimeStyleValues.Short, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Monday, RelativeTimeStyleValues.Long, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Monday, RelativeTimeStyleValues.Narrow, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Monday, RelativeTimeStyleValues.Short, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Tuesday, RelativeTimeStyleValues.Long, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Tuesday, RelativeTimeStyleValues.Narrow, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Tuesday, RelativeTimeStyleValues.Short, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Wednesday, RelativeTimeStyleValues.Long, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Wednesday, RelativeTimeStyleValues.Narrow, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Wednesday, RelativeTimeStyleValues.Short, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Thursday, RelativeTimeStyleValues.Long, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Thursday, RelativeTimeStyleValues.Narrow, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Thursday, RelativeTimeStyleValues.Short, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Friday, RelativeTimeStyleValues.Long, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Friday, RelativeTimeStyleValues.Narrow, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Friday, RelativeTimeStyleValues.Short, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Saturday, RelativeTimeStyleValues.Long, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Saturday, RelativeTimeStyleValues.Narrow, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Saturday, RelativeTimeStyleValues.Short, null, 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Long, "ÖÖ/ÖS", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Narrow, "ÖÖ/ÖS", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Short, "ÖÖ/ÖS", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Long, "saat", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Narrow, "sa.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Short, "sa.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Long, "dakika", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Narrow, "dk.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Short, "dk.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Long, "saniye", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Narrow, "sn.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Short, "sn.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Long, "saat dilimi", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Narrow, "dilim", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Short, "dilim", 0, 0, 0)]
        public void SpecificUnitAndStyle_ShouldReturn_ExpectedDisplayName(RelativeTimeUnitValues unit, RelativeTimeStyleValues style, string displayName, int current, int past, int future)
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("tr-cy"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            IRelativeTimeResource resource = resourceStyles.GetRelativeTimeResource(style);
            Assert.Equal("tr-cy", (resource as IResource).Locale);
            Assert.Equal(unit, resource.RelativeTimeUnit);
            Assert.Equal(style, resource.RelativeTimeStyle);
            Assert.Equal(displayName, resource.DisplayName);
            Assert.Equal(current, resource.Count);
            Assert.Equal(past, resource.Past.Count);
            Assert.Equal(future, resource.Future.Count);
        }
    }
}