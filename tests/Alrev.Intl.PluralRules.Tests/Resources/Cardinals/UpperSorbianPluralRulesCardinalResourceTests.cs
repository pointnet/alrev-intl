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
    public class UpperSorbianPluralRulesCardinalResourceTests
    {
        [Fact]
        public void PluralRulesType_ShouldReturn_PluralRulesValuesCardinal()
        {
            CultureInfo culture = new CultureInfo("hsb");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Assert.Equal(PluralRulesTypeValues.Cardinal, resource.PluralRulesType);
        }

        [Fact]
        public void EvaluateWithNullPluralRulesContext_ShouldThrow_ArgumentNullExpection()
        {
            CultureInfo culture = new CultureInfo("hsb");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            Exception ex = Record.Exception(() => resource.Evaluate(null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Theory]
        [InlineData("1", PluralRulesValues.One)]
        [InlineData("101", PluralRulesValues.One)]
        [InlineData("201", PluralRulesValues.One)]
        [InlineData("301", PluralRulesValues.One)]
        [InlineData("401", PluralRulesValues.One)]
        [InlineData("501", PluralRulesValues.One)]
        [InlineData("601", PluralRulesValues.One)]
        [InlineData("701", PluralRulesValues.One)]
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
        [InlineData("2", PluralRulesValues.Two)]
        [InlineData("102", PluralRulesValues.Two)]
        [InlineData("202", PluralRulesValues.Two)]
        [InlineData("302", PluralRulesValues.Two)]
        [InlineData("402", PluralRulesValues.Two)]
        [InlineData("502", PluralRulesValues.Two)]
        [InlineData("602", PluralRulesValues.Two)]
        [InlineData("702", PluralRulesValues.Two)]
        [InlineData("1002", PluralRulesValues.Two)]
        [InlineData("0.2", PluralRulesValues.Two)]
        [InlineData("1.2", PluralRulesValues.Two)]
        [InlineData("2.2", PluralRulesValues.Two)]
        [InlineData("3.2", PluralRulesValues.Two)]
        [InlineData("4.2", PluralRulesValues.Two)]
        [InlineData("5.2", PluralRulesValues.Two)]
        [InlineData("6.2", PluralRulesValues.Two)]
        [InlineData("7.2", PluralRulesValues.Two)]
        [InlineData("10.2", PluralRulesValues.Two)]
        [InlineData("100.2", PluralRulesValues.Two)]
        [InlineData("1000.2", PluralRulesValues.Two)]
        [InlineData("3", PluralRulesValues.Few)]
        [InlineData("4", PluralRulesValues.Few)]
        [InlineData("103", PluralRulesValues.Few)]
        [InlineData("104", PluralRulesValues.Few)]
        [InlineData("203", PluralRulesValues.Few)]
        [InlineData("204", PluralRulesValues.Few)]
        [InlineData("303", PluralRulesValues.Few)]
        [InlineData("304", PluralRulesValues.Few)]
        [InlineData("403", PluralRulesValues.Few)]
        [InlineData("404", PluralRulesValues.Few)]
        [InlineData("503", PluralRulesValues.Few)]
        [InlineData("504", PluralRulesValues.Few)]
        [InlineData("603", PluralRulesValues.Few)]
        [InlineData("604", PluralRulesValues.Few)]
        [InlineData("703", PluralRulesValues.Few)]
        [InlineData("704", PluralRulesValues.Few)]
        [InlineData("1003", PluralRulesValues.Few)]
        [InlineData("0.3", PluralRulesValues.Few)]
        [InlineData("0.4", PluralRulesValues.Few)]
        [InlineData("1.3", PluralRulesValues.Few)]
        [InlineData("1.4", PluralRulesValues.Few)]
        [InlineData("2.3", PluralRulesValues.Few)]
        [InlineData("2.4", PluralRulesValues.Few)]
        [InlineData("3.3", PluralRulesValues.Few)]
        [InlineData("3.4", PluralRulesValues.Few)]
        [InlineData("4.3", PluralRulesValues.Few)]
        [InlineData("4.4", PluralRulesValues.Few)]
        [InlineData("5.3", PluralRulesValues.Few)]
        [InlineData("5.4", PluralRulesValues.Few)]
        [InlineData("6.3", PluralRulesValues.Few)]
        [InlineData("6.4", PluralRulesValues.Few)]
        [InlineData("7.3", PluralRulesValues.Few)]
        [InlineData("7.4", PluralRulesValues.Few)]
        [InlineData("10.3", PluralRulesValues.Few)]
        [InlineData("100.3", PluralRulesValues.Few)]
        [InlineData("1000.3", PluralRulesValues.Few)]
        [InlineData("0", PluralRulesValues.Other)]
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
        [InlineData("17", PluralRulesValues.Other)]
        [InlineData("18", PluralRulesValues.Other)]
        [InlineData("19", PluralRulesValues.Other)]
        [InlineData("100", PluralRulesValues.Other)]
        [InlineData("1000", PluralRulesValues.Other)]
        [InlineData("10000", PluralRulesValues.Other)]
        [InlineData("100000", PluralRulesValues.Other)]
        [InlineData("1000000", PluralRulesValues.Other)]
        [InlineData("0.0", PluralRulesValues.Other)]
        [InlineData("0.5", PluralRulesValues.Other)]
        [InlineData("1.0", PluralRulesValues.Other)]
        [InlineData("1.5", PluralRulesValues.Other)]
        [InlineData("2.0", PluralRulesValues.Other)]
        [InlineData("2.5", PluralRulesValues.Other)]
        [InlineData("2.7", PluralRulesValues.Other)]
        [InlineData("10.0", PluralRulesValues.Other)]
        [InlineData("100.0", PluralRulesValues.Other)]
        [InlineData("1000.0", PluralRulesValues.Other)]
        [InlineData("10000.0", PluralRulesValues.Other)]
        [InlineData("100000.0", PluralRulesValues.Other)]
        [InlineData("1000000.0", PluralRulesValues.Other)]
        public void Evaluate_ShouldReturn_ExpectedPluralRulesValues(string input, PluralRulesValues expected)
        {
            CultureInfo culture = new CultureInfo("hsb");
            PluralRulesCardinalLocalizer localizer = new PluralRulesCardinalLocalizer();
            IPluralRulesResource resource = localizer.GetLocalizer(culture);
            PluralRulesValues result = resource.Evaluate(PluralRulesContext.Create(input));
            Assert.Equal(expected, result);
        }
    }
}