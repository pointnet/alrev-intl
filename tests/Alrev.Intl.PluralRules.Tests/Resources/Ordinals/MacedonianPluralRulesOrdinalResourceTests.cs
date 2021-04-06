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
    public class MacedonianPluralRulesOrdinalResourceTests
    {
        [Fact]
        public void PluralRulesType_ShouldReturn_PluralRulesValuesOrdinal()
        {
            CultureInfo culture = new CultureInfo("mk");
            PluralRulesOrdinalLocalizer localizer = new PluralRulesOrdinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Assert.Equal(PluralRulesTypeValues.Ordinal, resource.PluralRulesType);
        }

        [Fact]
        public void EvaluateWithNullPluralRulesContext_ShouldThrow_ArgumentNullExpection()
        {
            CultureInfo culture = new CultureInfo("mk");
            PluralRulesOrdinalLocalizer localizer = new PluralRulesOrdinalLocalizer();
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
        [InlineData("2", PluralRulesValues.Two)]
        [InlineData("22", PluralRulesValues.Two)]
        [InlineData("32", PluralRulesValues.Two)]
        [InlineData("42", PluralRulesValues.Two)]
        [InlineData("52", PluralRulesValues.Two)]
        [InlineData("62", PluralRulesValues.Two)]
        [InlineData("72", PluralRulesValues.Two)]
        [InlineData("82", PluralRulesValues.Two)]
        [InlineData("102", PluralRulesValues.Two)]
        [InlineData("1002", PluralRulesValues.Two)]
        [InlineData("7", PluralRulesValues.Many)]
        [InlineData("8", PluralRulesValues.Many)]
        [InlineData("27", PluralRulesValues.Many)]
        [InlineData("28", PluralRulesValues.Many)]
        [InlineData("37", PluralRulesValues.Many)]
        [InlineData("38", PluralRulesValues.Many)]
        [InlineData("47", PluralRulesValues.Many)]
        [InlineData("48", PluralRulesValues.Many)]
        [InlineData("57", PluralRulesValues.Many)]
        [InlineData("58", PluralRulesValues.Many)]
        [InlineData("67", PluralRulesValues.Many)]
        [InlineData("68", PluralRulesValues.Many)]
        [InlineData("77", PluralRulesValues.Many)]
        [InlineData("78", PluralRulesValues.Many)]
        [InlineData("87", PluralRulesValues.Many)]
        [InlineData("88", PluralRulesValues.Many)]
        [InlineData("107", PluralRulesValues.Many)]
        [InlineData("1007", PluralRulesValues.Many)]
        [InlineData("0", PluralRulesValues.Other)]
        [InlineData("3", PluralRulesValues.Other)]
        [InlineData("4", PluralRulesValues.Other)]
        [InlineData("5", PluralRulesValues.Other)]
        [InlineData("6", PluralRulesValues.Other)]
        [InlineData("9", PluralRulesValues.Other)]
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
        [InlineData("100", PluralRulesValues.Other)]
        [InlineData("1000", PluralRulesValues.Other)]
        [InlineData("10000", PluralRulesValues.Other)]
        [InlineData("100000", PluralRulesValues.Other)]
        [InlineData("1000000", PluralRulesValues.Other)]
        public void Evaluate_ShouldReturn_ExpectedPluralRulesValues(string input, PluralRulesValues expected)
        {
            CultureInfo culture = new CultureInfo("mk");
            PluralRulesOrdinalLocalizer localizer = new PluralRulesOrdinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            PluralRulesValues result = resource.Evaluate(PluralRulesContext.Create(input));
            Assert.Equal(expected, result);
        }
    }
}