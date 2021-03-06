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
	/// Plural Rules Cardinal resources for 'Maltese' [mt]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#mt"/>
	public class MtPluralRulesCardinalResource : IPluralRulesCardinalResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public MtPluralRulesCardinalResource()
		{
			this.Culture = new CultureInfo("mt");
		}

		/// <summary>
		/// Evaluates an <see cref="IPluralRulesContext"/> against the 'Maltese' [mt] <see cref="IPluralRulesCardinalResource"/>
		/// </summary>
		/// <param name="context">An <see cref="IPluralRulesContext"/></param>
		/// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
		/// <remarks>
		/// one - n = 1
		/// few - n = 0 or n % 100 = 2..10
		/// many - n % 100 = 11..19
		/// other - 
		/// </remarks>
		/// <exception cref="ArgumentNullException"></exception>
		public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
		{
			null => throw new ArgumentNullException(nameof(context), "IPluralRulesContext is null"),
			IPluralRulesContext prc when prc.n == 1 => PluralRulesValues.One,
			IPluralRulesContext prc when prc.n == 0 || (prc.n % 100).Between(2, 10) => PluralRulesValues.Few,
			IPluralRulesContext prc when (prc.n % 100).Between(11, 19) => PluralRulesValues.Many,
			_ => PluralRulesValues.Other
		};
	}
}