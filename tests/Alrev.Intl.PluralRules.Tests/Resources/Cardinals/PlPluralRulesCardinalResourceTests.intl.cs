// --------------------------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//   Script: ./scripts/cldr-plural-rules.csx
//
//   Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------------------------
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.PluralRules.Tests.Fixtures;
using System;
using System.Globalization;
using Xunit;

namespace Alrev.Intl.PluralRules.Tests.Resources.Cardinals
{
	[Collection("PluralRulesCardinalResourceLocalizer")]
	public class PlPluralRulesCardinalResourceTests
	{
		private PluralRulesCardinalResourceLocalizerFixture Fixture { get; }

		public PlPluralRulesCardinalResourceTests(PluralRulesCardinalResourceLocalizerFixture fixture)	
		{
			this.Fixture = fixture;
		}

		[Fact]
		public void EvaluateWithNullPluralRulesContext_ShouldThrow_ArgumentNullExpection()
		{
			CultureInfo culture = new CultureInfo("pl");
			IPluralRulesResource resource = this.Fixture.Localizer.ResolveResource(culture);
			Exception ex = Record.Exception(() => resource.Evaluate(null));
			Assert.IsType<ArgumentNullException>(ex);
		}

		[Theory]
		[InlineData("1", PluralRulesValues.One)]
		[InlineData("2", PluralRulesValues.Few)]
		[InlineData("3", PluralRulesValues.Few)]
		[InlineData("4", PluralRulesValues.Few)]
		[InlineData("22", PluralRulesValues.Few)]
		[InlineData("23", PluralRulesValues.Few)]
		[InlineData("24", PluralRulesValues.Few)]
		[InlineData("32", PluralRulesValues.Few)]
		[InlineData("33", PluralRulesValues.Few)]
		[InlineData("34", PluralRulesValues.Few)]
		[InlineData("42", PluralRulesValues.Few)]
		[InlineData("43", PluralRulesValues.Few)]
		[InlineData("44", PluralRulesValues.Few)]
		[InlineData("52", PluralRulesValues.Few)]
		[InlineData("53", PluralRulesValues.Few)]
		[InlineData("54", PluralRulesValues.Few)]
		[InlineData("62", PluralRulesValues.Few)]
		[InlineData("102", PluralRulesValues.Few)]
		[InlineData("1002", PluralRulesValues.Few)]
		[InlineData("0", PluralRulesValues.Many)]
		[InlineData("5", PluralRulesValues.Many)]
		[InlineData("6", PluralRulesValues.Many)]
		[InlineData("7", PluralRulesValues.Many)]
		[InlineData("8", PluralRulesValues.Many)]
		[InlineData("9", PluralRulesValues.Many)]
		[InlineData("10", PluralRulesValues.Many)]
		[InlineData("11", PluralRulesValues.Many)]
		[InlineData("12", PluralRulesValues.Many)]
		[InlineData("13", PluralRulesValues.Many)]
		[InlineData("14", PluralRulesValues.Many)]
		[InlineData("15", PluralRulesValues.Many)]
		[InlineData("16", PluralRulesValues.Many)]
		[InlineData("17", PluralRulesValues.Many)]
		[InlineData("18", PluralRulesValues.Many)]
		[InlineData("19", PluralRulesValues.Many)]
		[InlineData("100", PluralRulesValues.Many)]
		[InlineData("1000", PluralRulesValues.Many)]
		[InlineData("10000", PluralRulesValues.Many)]
		[InlineData("100000", PluralRulesValues.Many)]
		[InlineData("1000000", PluralRulesValues.Many)]
		[InlineData("0.0", PluralRulesValues.Other)]
		[InlineData("1.5", PluralRulesValues.Other)]
		[InlineData("10.0", PluralRulesValues.Other)]
		[InlineData("100.0", PluralRulesValues.Other)]
		[InlineData("1000.0", PluralRulesValues.Other)]
		[InlineData("10000.0", PluralRulesValues.Other)]
		[InlineData("100000.0", PluralRulesValues.Other)]
		[InlineData("1000000.0", PluralRulesValues.Other)]
		public void Evaluate_ShouldReturn_ExpectedPluralRulesValues(string input, PluralRulesValues expected)
		{
			CultureInfo culture = new CultureInfo("pl");
			IPluralRulesResource resource = this.Fixture.Localizer.ResolveResource(culture);
			PluralRulesValues result = resource.Evaluate(PluralRulesContext.Create(input));
			Assert.Equal(expected, result);	
		}
	}
}