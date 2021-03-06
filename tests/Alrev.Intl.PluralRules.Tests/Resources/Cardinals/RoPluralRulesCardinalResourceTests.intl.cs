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
	public class RoPluralRulesCardinalResourceTests
	{
		private PluralRulesCardinalResourceLocalizerFixture Fixture { get; }

		public RoPluralRulesCardinalResourceTests(PluralRulesCardinalResourceLocalizerFixture fixture)	
		{
			this.Fixture = fixture;
		}

		[Fact]
		public void EvaluateWithNullPluralRulesContext_ShouldThrow_ArgumentNullExpection()
		{
			CultureInfo culture = new CultureInfo("ro");
			IPluralRulesResource resource = this.Fixture.Localizer.ResolveResource(culture);
			Exception ex = Record.Exception(() => resource.Evaluate(null));
			Assert.IsType<ArgumentNullException>(ex);
		}

		[Theory]
		[InlineData("1", PluralRulesValues.One)]
		[InlineData("0", PluralRulesValues.Few)]
		[InlineData("2", PluralRulesValues.Few)]
		[InlineData("3", PluralRulesValues.Few)]
		[InlineData("4", PluralRulesValues.Few)]
		[InlineData("5", PluralRulesValues.Few)]
		[InlineData("6", PluralRulesValues.Few)]
		[InlineData("7", PluralRulesValues.Few)]
		[InlineData("8", PluralRulesValues.Few)]
		[InlineData("9", PluralRulesValues.Few)]
		[InlineData("10", PluralRulesValues.Few)]
		[InlineData("11", PluralRulesValues.Few)]
		[InlineData("12", PluralRulesValues.Few)]
		[InlineData("13", PluralRulesValues.Few)]
		[InlineData("14", PluralRulesValues.Few)]
		[InlineData("15", PluralRulesValues.Few)]
		[InlineData("16", PluralRulesValues.Few)]
		[InlineData("102", PluralRulesValues.Few)]
		[InlineData("1002", PluralRulesValues.Few)]
		[InlineData("0.0", PluralRulesValues.Few)]
		[InlineData("1.5", PluralRulesValues.Few)]
		[InlineData("10.0", PluralRulesValues.Few)]
		[InlineData("100.0", PluralRulesValues.Few)]
		[InlineData("1000.0", PluralRulesValues.Few)]
		[InlineData("10000.0", PluralRulesValues.Few)]
		[InlineData("100000.0", PluralRulesValues.Few)]
		[InlineData("1000000.0", PluralRulesValues.Few)]
		[InlineData("20", PluralRulesValues.Other)]
		[InlineData("21", PluralRulesValues.Other)]
		[InlineData("22", PluralRulesValues.Other)]
		[InlineData("23", PluralRulesValues.Other)]
		[InlineData("24", PluralRulesValues.Other)]
		[InlineData("25", PluralRulesValues.Other)]
		[InlineData("26", PluralRulesValues.Other)]
		[InlineData("27", PluralRulesValues.Other)]
		[InlineData("28", PluralRulesValues.Other)]
		[InlineData("29", PluralRulesValues.Other)]
		[InlineData("30", PluralRulesValues.Other)]
		[InlineData("31", PluralRulesValues.Other)]
		[InlineData("32", PluralRulesValues.Other)]
		[InlineData("33", PluralRulesValues.Other)]
		[InlineData("34", PluralRulesValues.Other)]
		[InlineData("35", PluralRulesValues.Other)]
		[InlineData("100", PluralRulesValues.Other)]
		[InlineData("1000", PluralRulesValues.Other)]
		[InlineData("10000", PluralRulesValues.Other)]
		[InlineData("100000", PluralRulesValues.Other)]
		[InlineData("1000000", PluralRulesValues.Other)]
		public void Evaluate_ShouldReturn_ExpectedPluralRulesValues(string input, PluralRulesValues expected)
		{
			CultureInfo culture = new CultureInfo("ro");
			IPluralRulesResource resource = this.Fixture.Localizer.ResolveResource(culture);
			PluralRulesValues result = resource.Evaluate(PluralRulesContext.Create(input));
			Assert.Equal(expected, result);	
		}
	}
}