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
    public class FrenchStPierreMiquelonRelativeTimeResourceSetTests
    {
        private RelativeTimeLocalizerFixture fixture;

        public FrenchStPierreMiquelonRelativeTimeResourceSetTests(RelativeTimeLocalizerFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void UnknownRelativeTimeUnit_ShouldThrow_NotImplementedException()
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("fr-pm"));
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
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("fr-pm"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            Exception ex = Record.Exception(() => resourceStyles.GetRelativeTimeResource(RelativeTimeStyleValues.Unknown));
            Assert.IsType<NotImplementedException>(ex);
        }

        [Theory]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Long, "ère", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Narrow, "ère", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Short, "ère", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Long, "année", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Narrow, "a", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Short, "an", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Long, "trimestre", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Narrow, "trim.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Short, "trim.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Long, "mois", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Narrow, "m.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Short, "m.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Long, "semaine", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Narrow, "sem.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Short, "sem.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Long, "semaine (mois)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Narrow, "sem. (m.)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Short, "sem. (m.)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, "jour", 5, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Narrow, "j", 5, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Short, "j", 5, 2, 2)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Long, "jour (année)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Narrow, "j (an)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Short, "j (an)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Long, "jour de la semaine", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Narrow, "j (sem.)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Short, "j (sem.)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Long, "jour (mois)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Narrow, "jour (mois)", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Short, "jour (mois)", 0, 0, 0)]
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
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Long, "cadran", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Narrow, "cadran", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Short, "cadran", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Long, "heure", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Narrow, "h", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Short, "h", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Long, "minute", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Narrow, "min", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Short, "min", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Long, "seconde", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Narrow, "s", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Short, "s", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Long, "fuseau horaire", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Narrow, "fuseau horaire", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Short, "fuseau horaire", 0, 0, 0)]
        public void SpecificUnitAndStyle_ShouldReturn_ExpectedDisplayName(RelativeTimeUnitValues unit, RelativeTimeStyleValues style, string displayName, int current, int past, int future)
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("fr-pm"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            IRelativeTimeResource resource = resourceStyles.GetRelativeTimeResource(style);
            Assert.Equal("fr-pm", (resource as IResource).Locale);
            Assert.Equal(unit, resource.RelativeTimeUnit);
            Assert.Equal(style, resource.RelativeTimeStyle);
            Assert.Equal(displayName, resource.DisplayName);
            Assert.Equal(current, resource.Count);
            Assert.Equal(past, resource.Past.Count);
            Assert.Equal(future, resource.Future.Count);
        }
    }
}