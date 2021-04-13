// --------------------------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//   Script: ./scripts/cldr-plural-rules.csx
//
//   Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------------------------
using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using System;
using System.Globalization;
using System.Linq;

namespace Alrev.Intl.PluralRules.Resources.Cardinals
{
	/// <summary>
	/// Plural Rules Cardinal resources for 'Polish' [pl]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#pl"/>
	public class PlPluralRulesCardinalResource : IPluralRulesCardinalResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public PlPluralRulesCardinalResource()
		{
			this.Culture = new CultureInfo("pl");
		}

		/// <summary>
		/// Evaluates an <see cref="IPluralRulesContext"/> against the 'Polish' [pl] <see cref="IPluralRulesCardinalResource"/>
		/// </summary>
		/// <param name="context">An <see cref="IPluralRulesContext"/></param>
		/// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
		/// <remarks>
		/// one - i = 1 and v = 0
		/// few - v = 0 and i % 10 = 2..4 and i % 100 != 12..14
		/// many - v = 0 and i != 1 and i % 10 = 0..1 or v = 0 and i % 10 = 5..9 or v = 0 and i % 100 = 12..14
		/// other - 
		/// </remarks>
		/// <exception cref="ArgumentNullException"></exception>
		public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
		{
			null => throw new ArgumentNullException(nameof(context), "IPluralRulesContext is null"),
			IPluralRulesContext prc when prc.i == 1 && prc.v == 0 => PluralRulesValues.One,
			IPluralRulesContext prc when prc.v == 0 && (prc.i % 10).Between(2, 4) && (prc.i % 100).NotBetween(12, 14) => PluralRulesValues.Few,
			IPluralRulesContext prc when prc.v == 0 && prc.i != 1 && (prc.i % 10).Between(0, 1) || prc.v == 0 && (prc.i % 10).Between(5, 9) || prc.v == 0 && (prc.i % 100).Between(12, 14) => PluralRulesValues.Many,
			_ => PluralRulesValues.Other
		};
	}
}