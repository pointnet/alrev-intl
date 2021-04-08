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
    public class MetaRelativeTimeResourceSetTests
    {
        private RelativeTimeLocalizerFixture fixture;

        public MetaRelativeTimeResourceSetTests(RelativeTimeLocalizerFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void UnknownRelativeTimeUnit_ShouldThrow_NotImplementedException()
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("mgo"));
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
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("mgo"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            Exception ex = Record.Exception(() => resourceStyles.GetRelativeTimeResource(RelativeTimeStyleValues.Unknown));
            Assert.IsType<NotImplementedException>(ex);
        }

        [Theory]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Long, "Era", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Narrow, "Era", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Short, "Era", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Long, "fituʼ", 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Narrow, "fituʼ", 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Short, "fituʼ", 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Long, "Quarter", 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Narrow, "Quarter", 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Short, "Quarter", 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Long, "iməg", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Narrow, "iməg", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Short, "iməg", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Long, "nkap", 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Narrow, "nkap", 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Short, "nkap", 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Long, "Week Of Month", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Narrow, "Week Of Month", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Short, "Week Of Month", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, "anəg", 4, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Narrow, "anəg", 4, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Short, "anəg", 4, 2, 2)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Long, "Day Of Year", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Narrow, "Day Of Year", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Short, "Day Of Year", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Long, "anəg agu nkap", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Narrow, "anəg agu nkap", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Short, "anəg agu nkap", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Long, "Weekday Of Month", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Narrow, "Weekday Of Month", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Short, "Weekday Of Month", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Sunday, RelativeTimeStyleValues.Long, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Sunday, RelativeTimeStyleValues.Narrow, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Sunday, RelativeTimeStyleValues.Short, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Monday, RelativeTimeStyleValues.Long, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Monday, RelativeTimeStyleValues.Narrow, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Monday, RelativeTimeStyleValues.Short, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Tuesday, RelativeTimeStyleValues.Long, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Tuesday, RelativeTimeStyleValues.Narrow, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Tuesday, RelativeTimeStyleValues.Short, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Wednesday, RelativeTimeStyleValues.Long, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Wednesday, RelativeTimeStyleValues.Narrow, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Wednesday, RelativeTimeStyleValues.Short, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Thursday, RelativeTimeStyleValues.Long, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Thursday, RelativeTimeStyleValues.Narrow, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Thursday, RelativeTimeStyleValues.Short, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Friday, RelativeTimeStyleValues.Long, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Friday, RelativeTimeStyleValues.Narrow, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Friday, RelativeTimeStyleValues.Short, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Saturday, RelativeTimeStyleValues.Long, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Saturday, RelativeTimeStyleValues.Narrow, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.Saturday, RelativeTimeStyleValues.Short, null, 3, 1, 1)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Long, "Dayperiod", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Narrow, "Dayperiod", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Short, "Dayperiod", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Long, "Hour", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Narrow, "Hour", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Short, "Hour", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Long, "Minute", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Narrow, "Minute", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Short, "Minute", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Long, "Second", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Narrow, "Second", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Short, "Second", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Long, "Zone", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Narrow, "Zone", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Short, "Zone", 0, 0, 0)]
        public void SpecificUnitAndStyle_ShouldReturn_ExpectedDisplayName(RelativeTimeUnitValues unit, RelativeTimeStyleValues style, string displayName, int current, int past, int future)
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("mgo"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            IRelativeTimeResource resource = resourceStyles.GetRelativeTimeResource(style);
            Assert.Equal("mgo", (resource as IResource).Locale);
            Assert.Equal(unit, resource.RelativeTimeUnit);
            Assert.Equal(style, resource.RelativeTimeStyle);
            Assert.Equal(displayName, resource.DisplayName);
            Assert.Equal(current, resource.Count);
            Assert.Equal(past, resource.Past.Count);
            Assert.Equal(future, resource.Future.Count);
        }
    }
}