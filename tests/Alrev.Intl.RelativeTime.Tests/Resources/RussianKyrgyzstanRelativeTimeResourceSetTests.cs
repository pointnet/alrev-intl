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
    public class RussianKyrgyzstanRelativeTimeResourceSetTests
    {
        private RelativeTimeLocalizerFixture fixture;

        public RussianKyrgyzstanRelativeTimeResourceSetTests(RelativeTimeLocalizerFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void UnknownRelativeTimeUnit_ShouldThrow_NotImplementedException()
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("ru-kg"));
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
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("ru-kg"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            Exception ex = Record.Exception(() => resourceStyles.GetRelativeTimeResource(RelativeTimeStyleValues.Unknown));
            Assert.IsType<NotImplementedException>(ex);
        }

        [Theory]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Long, "эра", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Narrow, "эра", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Era, RelativeTimeStyleValues.Short, "эра", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Long, "год", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Narrow, "г.", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Short, "г.", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Long, "квартал", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Narrow, "кв.", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Short, "кв.", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Long, "месяц", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Narrow, "мес.", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Short, "мес.", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Long, "неделя", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Narrow, "нед.", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Short, "нед.", 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Long, "неделя месяца", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Narrow, "нед. мес.", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekOfMonth, RelativeTimeStyleValues.Short, "нед. месяца", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, "день", 5, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Narrow, "дн.", 5, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Short, "дн.", 5, 4, 4)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Long, "день года", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Narrow, "дн. года", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayOfYear, RelativeTimeStyleValues.Short, "дн. года", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Long, "день недели", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Narrow, "дн. нед.", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Weekday, RelativeTimeStyleValues.Short, "дн. недели", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Long, "день недели в месяце", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Narrow, "дн. нед. в мес.", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.WeekdayOfMonth, RelativeTimeStyleValues.Short, "дн. нед. в месяце", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Sunday, RelativeTimeStyleValues.Long, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Sunday, RelativeTimeStyleValues.Narrow, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Sunday, RelativeTimeStyleValues.Short, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Monday, RelativeTimeStyleValues.Long, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Monday, RelativeTimeStyleValues.Narrow, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Monday, RelativeTimeStyleValues.Short, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Tuesday, RelativeTimeStyleValues.Long, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Tuesday, RelativeTimeStyleValues.Narrow, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Tuesday, RelativeTimeStyleValues.Short, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Wednesday, RelativeTimeStyleValues.Long, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Wednesday, RelativeTimeStyleValues.Narrow, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Wednesday, RelativeTimeStyleValues.Short, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Thursday, RelativeTimeStyleValues.Long, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Thursday, RelativeTimeStyleValues.Narrow, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Thursday, RelativeTimeStyleValues.Short, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Friday, RelativeTimeStyleValues.Long, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Friday, RelativeTimeStyleValues.Narrow, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Friday, RelativeTimeStyleValues.Short, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Saturday, RelativeTimeStyleValues.Long, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Saturday, RelativeTimeStyleValues.Narrow, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Saturday, RelativeTimeStyleValues.Short, null, 3, 4, 4)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Long, "AM/PM", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Narrow, "AM/PM", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.DayPeriod, RelativeTimeStyleValues.Short, "AM/PM", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Long, "час", 1, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Narrow, "ч", 1, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Short, "ч", 1, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Long, "минута", 1, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Narrow, "мин", 1, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Short, "мин.", 1, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Long, "секунда", 1, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Narrow, "с", 1, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Short, "сек.", 1, 4, 4)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Long, "часовой пояс", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Narrow, "час. пояс", 0, 0, 0)]
        [InlineData(RelativeTimeUnitValues.Zone, RelativeTimeStyleValues.Short, "час. пояс", 0, 0, 0)]
        public void SpecificUnitAndStyle_ShouldReturn_ExpectedDisplayName(RelativeTimeUnitValues unit, RelativeTimeStyleValues style, string displayName, int current, int past, int future)
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("ru-kg"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            IRelativeTimeResource resource = resourceStyles.GetRelativeTimeResource(style);
            Assert.Equal("ru-kg", (resource as IResource).Locale);
            Assert.Equal(unit, resource.RelativeTimeUnit);
            Assert.Equal(style, resource.RelativeTimeStyle);
            Assert.Equal(displayName, resource.DisplayName);
            Assert.Equal(current, resource.Count);
            Assert.Equal(past, resource.Past.Count);
            Assert.Equal(future, resource.Future.Count);
        }
    }
}