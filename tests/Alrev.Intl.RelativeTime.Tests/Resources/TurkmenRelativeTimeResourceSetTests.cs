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
    public class TurkmenRelativeTimeResourceSetTests
    {
        private RelativeTimeLocalizerFixture fixture;

        public TurkmenRelativeTimeResourceSetTests(RelativeTimeLocalizerFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void UnknownRelativeTimeUnit_ShouldThrow_NotImplementedException()
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("tk"));
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
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("tk"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            Exception ex = Record.Exception(() => resourceStyles.GetRelativeTimeResource(RelativeTimeStyleValues.Unknown));
            Assert.IsType<NotImplementedException>(ex);
        }

        [Theory]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Long, "ýyl", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Narrow, "ý.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Year, RelativeTimeStyleValues.Short, "ý.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Long, "çärýek", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Narrow, "çär.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Quarter, RelativeTimeStyleValues.Short, "çär.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Long, "aý", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Narrow, "aý", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Month, RelativeTimeStyleValues.Short, "aý", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Long, "hepde", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Narrow, "hep.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Week, RelativeTimeStyleValues.Short, "hep.", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Long, "gün", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Narrow, "gün", 3, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Short, "gün", 3, 2, 2)]
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
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Long, "sagat", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Narrow, "sag.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Hour, RelativeTimeStyleValues.Short, "sag.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Long, "minut", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Narrow, "min.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Minute, RelativeTimeStyleValues.Short, "min.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Long, "sekunt", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Narrow, "sek.", 1, 2, 2)]
        [InlineData(RelativeTimeUnitValues.Second, RelativeTimeStyleValues.Short, "sek.", 1, 2, 2)]
        public void SpecificUnitAndStyle_ShouldReturn_ExpectedDisplayName(RelativeTimeUnitValues unit, RelativeTimeStyleValues style, string displayName, int current, int past, int future)
        {
            IRelativeTimeResourceSet resourceSet = this.fixture.Localizer.GetLocalizer(new CultureInfo("tk"));
            IRelativeTimeStylesResource resourceStyles = resourceSet.GetRelativeTimeStylesResource(unit);
            IRelativeTimeResource resource = resourceStyles.GetRelativeTimeResource(style);
            Assert.Equal("tk", (resource as IResource).Locale);
            Assert.Equal(unit, resource.RelativeTimeUnit);
            Assert.Equal(style, resource.RelativeTimeStyle);
            Assert.Equal(displayName, resource.DisplayName);
            Assert.Equal(current, resource.Count);
            Assert.Equal(past, resource.Past.Count);
            Assert.Equal(future, resource.Future.Count);
        }
    }
}