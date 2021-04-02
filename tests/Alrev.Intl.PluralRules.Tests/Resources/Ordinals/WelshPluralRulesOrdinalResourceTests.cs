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

namespace Alrev.Intl.PluralRules.Tests.Resources.Ordinals
{
    public class WelshPluralRulesOrdinalResourceTests
    {
        [Fact]
        public void PluralRulesType_ShouldReturn_PluralRulesValuesOrdinal()
        {
            CultureInfo culture = new CultureInfo("cy");
            PluralRulesOrdinalLocalizer localizer = new PluralRulesOrdinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Assert.Equal(PluralRulesTypeValues.Ordinal, resource.PluralRulesType);
        }

        [Fact]
        public void EvaluateWithNullPluralRulesContext_ShouldThrow_ArgumentNullExpection()
        {
            CultureInfo culture = new CultureInfo("cy");
            PluralRulesOrdinalLocalizer localizer = new PluralRulesOrdinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Exception ex = Record.Exception(() => resource.Evaluate(null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Theory]
        [InlineData("0", PluralRulesValues.Zero)]
        [InlineData("7", PluralRulesValues.Zero)]
        [InlineData("8", PluralRulesValues.Zero)]
        [InlineData("9", PluralRulesValues.Zero)]
        [InlineData("1", PluralRulesValues.One)]
        [InlineData("2", PluralRulesValues.Two)]
        [InlineData("3", PluralRulesValues.Few)]
        [InlineData("4", PluralRulesValues.Few)]
        [InlineData("5", PluralRulesValues.Many)]
        [InlineData("6", PluralRulesValues.Many)]
        [InlineData("10", PluralRulesValues.Other)]
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
        public void Evaluate_ShouldReturn_ExpectedPluralRulesValues(string input, PluralRulesValues expected)
        {
            CultureInfo culture = new CultureInfo("cy");
            PluralRulesOrdinalLocalizer localizer = new PluralRulesOrdinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            PluralRulesValues result = resource.Evaluate(PluralRulesContext.Create(input));
            Assert.Equal(expected, result);
        }
    }
}