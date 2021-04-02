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
    public class IrishPluralRulesCardinalResourceTests
    {
        [Fact]
        public void PluralRulesType_ShouldReturn_PluralRulesValuesCardinal()
        {
            CultureInfo culture = new CultureInfo("ga");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Assert.Equal(PluralRulesTypeValues.Cardinal, resource.PluralRulesType);
        }

        [Fact]
        public void EvaluateWithNullPluralRulesContext_ShouldThrow_ArgumentNullExpection()
        {
            CultureInfo culture = new CultureInfo("ga");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Exception ex = Record.Exception(() => resource.Evaluate(null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Theory]
        [InlineData("1", PluralRulesValues.One)]
        [InlineData("1.0", PluralRulesValues.One)]
        [InlineData("1.00", PluralRulesValues.One)]
        [InlineData("1.000", PluralRulesValues.One)]
        [InlineData("1.0000", PluralRulesValues.One)]
        [InlineData("2", PluralRulesValues.Two)]
        [InlineData("2.0", PluralRulesValues.Two)]
        [InlineData("2.00", PluralRulesValues.Two)]
        [InlineData("2.000", PluralRulesValues.Two)]
        [InlineData("2.0000", PluralRulesValues.Two)]
        [InlineData("3", PluralRulesValues.Few)]
        [InlineData("4", PluralRulesValues.Few)]
        [InlineData("5", PluralRulesValues.Few)]
        [InlineData("6", PluralRulesValues.Few)]
        [InlineData("3.0", PluralRulesValues.Few)]
        [InlineData("4.0", PluralRulesValues.Few)]
        [InlineData("5.0", PluralRulesValues.Few)]
        [InlineData("6.0", PluralRulesValues.Few)]
        [InlineData("3.00", PluralRulesValues.Few)]
        [InlineData("4.00", PluralRulesValues.Few)]
        [InlineData("5.00", PluralRulesValues.Few)]
        [InlineData("6.00", PluralRulesValues.Few)]
        [InlineData("3.000", PluralRulesValues.Few)]
        [InlineData("4.000", PluralRulesValues.Few)]
        [InlineData("5.000", PluralRulesValues.Few)]
        [InlineData("6.000", PluralRulesValues.Few)]
        [InlineData("3.0000", PluralRulesValues.Few)]
        [InlineData("4.0000", PluralRulesValues.Few)]
        [InlineData("5.0000", PluralRulesValues.Few)]
        [InlineData("6.0000", PluralRulesValues.Few)]
        [InlineData("7", PluralRulesValues.Many)]
        [InlineData("8", PluralRulesValues.Many)]
        [InlineData("9", PluralRulesValues.Many)]
        [InlineData("10", PluralRulesValues.Many)]
        [InlineData("7.0", PluralRulesValues.Many)]
        [InlineData("8.0", PluralRulesValues.Many)]
        [InlineData("9.0", PluralRulesValues.Many)]
        [InlineData("10.0", PluralRulesValues.Many)]
        [InlineData("7.00", PluralRulesValues.Many)]
        [InlineData("8.00", PluralRulesValues.Many)]
        [InlineData("9.00", PluralRulesValues.Many)]
        [InlineData("10.00", PluralRulesValues.Many)]
        [InlineData("7.000", PluralRulesValues.Many)]
        [InlineData("8.000", PluralRulesValues.Many)]
        [InlineData("9.000", PluralRulesValues.Many)]
        [InlineData("10.000", PluralRulesValues.Many)]
        [InlineData("7.0000", PluralRulesValues.Many)]
        [InlineData("8.0000", PluralRulesValues.Many)]
        [InlineData("9.0000", PluralRulesValues.Many)]
        [InlineData("10.0000", PluralRulesValues.Many)]
        [InlineData("0", PluralRulesValues.Other)]
        [InlineData("11", PluralRulesValues.Other)]
        [InlineData("12", PluralRulesValues.Other)]
        [InlineData("13", PluralRulesValues.Other)]
        [InlineData("14", PluralRulesValues.Other)]
        [InlineData("15", PluralRulesValues.Other)]
        [InlineData("16", PluralRulesValues.Other)]
        [InlineData("17", PluralRulesValues.Other)]
        [InlineData("18", PluralRulesValues.Other)]
        [InlineData("19", PluralRulesValues.Other)]
        [InlineData("20", PluralRulesValues.Other)]
        [InlineData("21", PluralRulesValues.Other)]
        [InlineData("22", PluralRulesValues.Other)]
        [InlineData("23", PluralRulesValues.Other)]
        [InlineData("24", PluralRulesValues.Other)]
        [InlineData("25", PluralRulesValues.Other)]
        [InlineData("100", PluralRulesValues.Other)]
        [InlineData("1000", PluralRulesValues.Other)]
        [InlineData("10000", PluralRulesValues.Other)]
        [InlineData("100000", PluralRulesValues.Other)]
        [InlineData("1000000", PluralRulesValues.Other)]
        [InlineData("0.0", PluralRulesValues.Other)]
        [InlineData("0.9", PluralRulesValues.Other)]
        [InlineData("1.1", PluralRulesValues.Other)]
        [InlineData("1.6", PluralRulesValues.Other)]
        [InlineData("10.1", PluralRulesValues.Other)]
        [InlineData("100.0", PluralRulesValues.Other)]
        [InlineData("1000.0", PluralRulesValues.Other)]
        [InlineData("10000.0", PluralRulesValues.Other)]
        [InlineData("100000.0", PluralRulesValues.Other)]
        [InlineData("1000000.0", PluralRulesValues.Other)]
        public void Evaluate_ShouldReturn_ExpectedPluralRulesValues(string input, PluralRulesValues expected)
        {
            CultureInfo culture = new CultureInfo("ga");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            PluralRulesValues result = resource.Evaluate(PluralRulesContext.Create(input));
            Assert.Equal(expected, result);
        }
    }
}