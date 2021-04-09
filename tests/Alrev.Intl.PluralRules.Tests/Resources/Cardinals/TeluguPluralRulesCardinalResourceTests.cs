//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Script: ./scripts/cldr-plural-rules.csx
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Alrev.Intl.Abstractions.PluralRules;
using System;
using System.Globalization;
using Xunit;

namespace Alrev.Intl.PluralRules.Tests.Resources.Cardinals
{
    [Collection("PluralRulesLocalizers")]
    public class TeluguPluralRulesCardinalResourceTests
    {
        private PluralRulesLocalizersFixture fixture;

        public TeluguPluralRulesCardinalResourceTests(PluralRulesLocalizersFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void PluralRulesType_ShouldReturn_PluralRulesValuesCardinal()
        {
            CultureInfo culture = new CultureInfo("te");
            IPluralRulesResource resource = this.fixture.CardinalLocalizer.GetLocalizer(culture);
            Assert.Equal(PluralRulesTypeValues.Cardinal, resource.PluralRulesType);
        }

        [Fact]
        public void EvaluateWithNullPluralRulesContext_ShouldThrow_ArgumentNullExpection()
        {
            CultureInfo culture = new CultureInfo("te");
            IPluralRulesResource resource = this.fixture.CardinalLocalizer.GetLocalizer(culture);
            Exception ex = Record.Exception(() => resource.Evaluate(null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Theory]
        [InlineData("1", PluralRulesValues.One)]
        [InlineData("1.0", PluralRulesValues.One)]
        [InlineData("1.00", PluralRulesValues.One)]
        [InlineData("1.000", PluralRulesValues.One)]
        [InlineData("1.0000", PluralRulesValues.One)]
        [InlineData("0", PluralRulesValues.Other)]
        [InlineData("2", PluralRulesValues.Other)]
        [InlineData("3", PluralRulesValues.Other)]
        [InlineData("4", PluralRulesValues.Other)]
        [InlineData("5", PluralRulesValues.Other)]
        [InlineData("6", PluralRulesValues.Other)]
        [InlineData("7", PluralRulesValues.Other)]
        [InlineData("8", PluralRulesValues.Other)]
        [InlineData("9", PluralRulesValues.Other)]
        [InlineData("10", PluralRulesValues.Other)]
        [InlineData("11", PluralRulesValues.Other)]
        [InlineData("12", PluralRulesValues.Other)]
        [InlineData("13", PluralRulesValues.Other)]
        [InlineData("14", PluralRulesValues.Other)]
        [InlineData("15", PluralRulesValues.Other)]
        [InlineData("16", PluralRulesValues.Other)]
        [InlineData("100", PluralRulesValues.Other)]
        [InlineData("1000", PluralRulesValues.Other)]
        [InlineData("10000", PluralRulesValues.Other)]
        [InlineData("100000", PluralRulesValues.Other)]
        [InlineData("1000000", PluralRulesValues.Other)]
        [InlineData("0.0", PluralRulesValues.Other)]
        [InlineData("0.9", PluralRulesValues.Other)]
        [InlineData("1.1", PluralRulesValues.Other)]
        [InlineData("1.6", PluralRulesValues.Other)]
        [InlineData("10.0", PluralRulesValues.Other)]
        [InlineData("100.0", PluralRulesValues.Other)]
        [InlineData("1000.0", PluralRulesValues.Other)]
        [InlineData("10000.0", PluralRulesValues.Other)]
        [InlineData("100000.0", PluralRulesValues.Other)]
        [InlineData("1000000.0", PluralRulesValues.Other)]
        public void Evaluate_ShouldReturn_ExpectedPluralRulesValues(string input, PluralRulesValues expected)
        {
            CultureInfo culture = new CultureInfo("te");
            IPluralRulesResource resource = this.fixture.CardinalLocalizer.GetLocalizer(culture);
            PluralRulesValues result = resource.Evaluate(PluralRulesContext.Create(input));
            Assert.Equal(expected, result);
        }
    }
}