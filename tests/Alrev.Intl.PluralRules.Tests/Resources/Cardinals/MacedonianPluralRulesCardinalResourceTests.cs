//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Script: ./scripts/cldr-plural-rules.csx
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.PluralRules.Globalization;
using System;
using System.Globalization;
using System.Threading;
using Xunit;

namespace Alrev.Intl.PluralRules.Tests.Resources.Cardinals
{
    public class MacedonianPluralRulesCardinalResourceTests
    {
        [Fact]
        public void PluralRulesType_ShouldReturn_PluralRulesValuesCardinal()
        {
            CultureInfo culture = new CultureInfo("mk");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Assert.Equal(PluralRulesTypeValues.Cardinal, resource.PluralRulesType);
        }

        [Fact]
        public void EvaluateWithNullPluralRulesContext_ShouldThrow_ArgumentNullExpection()
        {
            CultureInfo culture = new CultureInfo("mk");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Exception ex = Record.Exception(() => resource.Evaluate(null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Theory]
        [InlineData("1", PluralRulesValues.One)]
        [InlineData("21", PluralRulesValues.One)]
        [InlineData("31", PluralRulesValues.One)]
        [InlineData("41", PluralRulesValues.One)]
        [InlineData("51", PluralRulesValues.One)]
        [InlineData("61", PluralRulesValues.One)]
        [InlineData("71", PluralRulesValues.One)]
        [InlineData("81", PluralRulesValues.One)]
        [InlineData("101", PluralRulesValues.One)]
        [InlineData("1001", PluralRulesValues.One)]
        [InlineData("0.1", PluralRulesValues.One)]
        [InlineData("1.1", PluralRulesValues.One)]
        [InlineData("2.1", PluralRulesValues.One)]
        [InlineData("3.1", PluralRulesValues.One)]
        [InlineData("4.1", PluralRulesValues.One)]
        [InlineData("5.1", PluralRulesValues.One)]
        [InlineData("6.1", PluralRulesValues.One)]
        [InlineData("7.1", PluralRulesValues.One)]
        [InlineData("10.1", PluralRulesValues.One)]
        [InlineData("100.1", PluralRulesValues.One)]
        [InlineData("1000.1", PluralRulesValues.One)]
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
        [InlineData("0.2", PluralRulesValues.Other)]
        [InlineData("1.0", PluralRulesValues.Other)]
        [InlineData("1.2", PluralRulesValues.Other)]
        [InlineData("1.7", PluralRulesValues.Other)]
        [InlineData("10.0", PluralRulesValues.Other)]
        [InlineData("100.0", PluralRulesValues.Other)]
        [InlineData("1000.0", PluralRulesValues.Other)]
        [InlineData("10000.0", PluralRulesValues.Other)]
        [InlineData("100000.0", PluralRulesValues.Other)]
        [InlineData("1000000.0", PluralRulesValues.Other)]
        public void Evaluate_ShouldReturn_ExpectedPluralRulesValues(string input, PluralRulesValues expected)
        {
            CultureInfo culture = new CultureInfo("mk");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            PluralRulesValues result = resource.Evaluate(PluralRulesContext.Create(input));
            Assert.Equal(expected, result);
        }
    }
}