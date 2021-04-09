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
    public class UzbekRelativeTimeResourceSetTests
    {
        private RelativeTimeLocalizerFixture fixture;

        public UzbekRelativeTimeResourceSetTests(RelativeTimeLocalizerFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void UnknownRelativeTimeUnit_ShouldThrow_NotImplementedException()
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("uz-latn"));
            Exception ex = Record.Exception(() => resourceSet.GetRelativeTimeStylesResource(RelativeTimeUnitValues.Unknown));
            Assert.IsType<NotImplementedException>(ex);
        }

        [Theory]
        [InlineData(RelativeTimeUnitValues.Year)]
        [InlineData(RelativeTimeUnitValues.Quarter)]
        [InlineData(RelativeTimeUnitValues.Month)]
        [InlineData(RelativeTimeUnitValues.Week)]
        [InlineData(RelativeTimeUnitValues.Day)]
        [InlineData(RelativeTimeUnitValues.Sunday)]
        [InlineData(RelativeTimeUnitValues.Monday)]
        [InlineData(RelativeTimeUnitValues.Tuesday)]
        [InlineData(RelativeTimeUnitValues.Wednesday)]
        [InlineData(RelativeTimeUnitValues.Thursday)]
        [InlineData(RelativeTimeUnitValues.Friday)]
        [InlineData(RelativeTimeUnitValues.Saturday)]
        [InlineData(RelativeTimeUnitValues.Hour)]
        [InlineData(RelativeTimeUnitValues.Minute)]
        [InlineData(RelativeTimeUnitValues.Second)]
        public void UnknownRelativeTimeStyle_ShouldThrow_NotImplementedException(RelativeTimeUnitValues unit)
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("uz-latn"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            Exception ex = Record.Exception(() => resourceStyles.GetRelativeTimeResource(RelativeTimeStyleValues.Unknown));
            Assert.IsType<NotImplementedException>(ex);
        }

        [Theory]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Long, "yil", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Narrow, "yil", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Short, "yil", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Long, "chorak", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Narrow, "ch", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Short, "ch", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Long, "oy", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Narrow, "oy", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Short, "oy", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Long, "hafta", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Narrow, "hafta", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Short, "hafta", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, "kun", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Narrow, "kun", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Short, "kun", 3, 2, 2)]
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
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Long, "soat", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Narrow, "soat", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Short, "soat", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Long, "daqiqa", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Narrow, "daq.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Short, "daq.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Long, "soniya", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Narrow, "son.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Short, "son.", 1, 2, 2)]
        public void SpecificUnitAndStyle_ShouldReturn_ExpectedDisplayName(RelativeTimeUnitValues unit, RelativeTimeStyleValues style, string displayName, int current, int past, int future)
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("uz-latn"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            IRelativeTimeResource resource = resourceStyles.GetRelativeTimeResource(style);
            Assert.Equal("uz-latn", (resource as IResource).Locale);
            Assert.Equal(unit, resource.RelativeTimeUnit);
            Assert.Equal(style, resource.RelativeTimeStyle);
            Assert.Equal(displayName, resource.DisplayName);
            Assert.Equal(current, resource.Count);
            Assert.Equal(past, resource.Past.Count);
            Assert.Equal(future, resource.Future.Count);
        }
    }
}