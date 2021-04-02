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
    public class BretonPluralRulesCardinalResourceTests
    {
        [Fact]
        public void PluralRulesType_ShouldReturn_PluralRulesValuesCardinal()
        {
            CultureInfo culture = new CultureInfo("br");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Assert.Equal(PluralRulesTypeValues.Cardinal, resource.PluralRulesType);
        }

        [Fact]
        public void EvaluateWithNullPluralRulesContext_ShouldThrow_ArgumentNullExpection()
        {
            CultureInfo culture = new CultureInfo("br");
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
        [InlineData("81", PluralRulesValues.One)]
        [InlineData("101", PluralRulesValues.One)]
        [InlineData("1001", PluralRulesValues.One)]
        [InlineData("1.0", PluralRulesValues.One)]
        [InlineData("21.0", PluralRulesValues.One)]
        [InlineData("31.0", PluralRulesValues.One)]
        [InlineData("41.0", PluralRulesValues.One)]
        [InlineData("51.0", PluralRulesValues.One)]
        [InlineData("61.0", PluralRulesValues.One)]
        [InlineData("81.0", PluralRulesValues.One)]
        [InlineData("101.0", PluralRulesValues.One)]
        [InlineData("1001.0", PluralRulesValues.One)]
        [InlineData("2", PluralRulesValues.Two)]
        [InlineData("22", PluralRulesValues.Two)]
        [InlineData("32", PluralRulesValues.Two)]
        [InlineData("42", PluralRulesValues.Two)]
        [InlineData("52", PluralRulesValues.Two)]
        [InlineData("62", PluralRulesValues.Two)]
        [InlineData("82", PluralRulesValues.Two)]
        [InlineData("102", PluralRulesValues.Two)]
        [InlineData("1002", PluralRulesValues.Two)]
        [InlineData("2.0", PluralRulesValues.Two)]
        [InlineData("22.0", PluralRulesValues.Two)]
        [InlineData("32.0", PluralRulesValues.Two)]
        [InlineData("42.0", PluralRulesValues.Two)]
        [InlineData("52.0", PluralRulesValues.Two)]
        [InlineData("62.0", PluralRulesValues.Two)]
        [InlineData("82.0", PluralRulesValues.Two)]
        [InlineData("102.0", PluralRulesValues.Two)]
        [InlineData("1002.0", PluralRulesValues.Two)]
        [InlineData("3", PluralRulesValues.Few)]
        [InlineData("4", PluralRulesValues.Few)]
        [InlineData("9", PluralRulesValues.Few)]
        [InlineData("23", PluralRulesValues.Few)]
        [InlineData("24", PluralRulesValues.Few)]
        [InlineData("29", PluralRulesValues.Few)]
        [InlineData("33", PluralRulesValues.Few)]
        [InlineData("34", PluralRulesValues.Few)]
        [InlineData("39", PluralRulesValues.Few)]
        [InlineData("43", PluralRulesValues.Few)]
        [InlineData("44", PluralRulesValues.Few)]
        [InlineData("49", PluralRulesValues.Few)]
        [InlineData("103", PluralRulesValues.Few)]
        [InlineData("1003", PluralRulesValues.Few)]
        [InlineData("3.0", PluralRulesValues.Few)]
        [InlineData("4.0", PluralRulesValues.Few)]
        [InlineData("9.0", PluralRulesValues.Few)]
        [InlineData("23.0", PluralRulesValues.Few)]
        [InlineData("24.0", PluralRulesValues.Few)]
        [InlineData("29.0", PluralRulesValues.Few)]
        [InlineData("33.0", PluralRulesValues.Few)]
        [InlineData("34.0", PluralRulesValues.Few)]
        [InlineData("103.0", PluralRulesValues.Few)]
        [InlineData("1003.0", PluralRulesValues.Few)]
        [InlineData("1000000", PluralRulesValues.Many)]
        [InlineData("1000000.0", PluralRulesValues.Many)]
        [InlineData("1000000.00", PluralRulesValues.Many)]
        [InlineData("1000000.000", PluralRulesValues.Many)]
        [InlineData("1000000.0000", PluralRulesValues.Many)]
        [InlineData("0", PluralRulesValues.Other)]
        [InlineData("5", PluralRulesValues.Other)]
        [InlineData("6", PluralRulesValues.Other)]
        [InlineData("7", PluralRulesValues.Other)]
        [InlineData("8", PluralRulesValues.Other)]
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
        [InlineData("100", PluralRulesValues.Other)]
        [InlineData("1000", PluralRulesValues.Other)]
        [InlineData("10000", PluralRulesValues.Other)]
        [InlineData("100000", PluralRulesValues.Other)]
        [InlineData("0.0", PluralRulesValues.Other)]
        [InlineData("0.9", PluralRulesValues.Other)]
        [InlineData("1.1", PluralRulesValues.Other)]
        [InlineData("1.6", PluralRulesValues.Other)]
        [InlineData("10.0", PluralRulesValues.Other)]
        [InlineData("100.0", PluralRulesValues.Other)]
        [InlineData("1000.0", PluralRulesValues.Other)]
        [InlineData("10000.0", PluralRulesValues.Other)]
        [InlineData("100000.0", PluralRulesValues.Other)]
        public void Evaluate_ShouldReturn_ExpectedPluralRulesValues(string input, PluralRulesValues expected)
        {
            CultureInfo culture = new CultureInfo("br");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            PluralRulesValues result = resource.Evaluate(PluralRulesContext.Create(input));
            Assert.Equal(expected, result);
        }
    }
}