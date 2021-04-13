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
	/// Plural Rules Cardinal resources for 'Northern Sami' [se]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#se"/>
	public class SePluralRulesCardinalResource : IPluralRulesCardinalResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public SePluralRulesCardinalResource()
		{
			this.Culture = new CultureInfo("se");
		}

		/// <summary>
		/// Evaluates an <see cref="IPluralRulesContext"/> against the 'Northern Sami' [se] <see cref="IPluralRulesCardinalResource"/>
		/// </summary>
		/// <param name="context">An <see cref="IPluralRulesContext"/></param>
		/// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
		/// <remarks>
		/// one - n = 1
		/// two - n = 2
		/// other - 
		/// </remarks>
		/// <exception cref="ArgumentNullException"></exception>
		public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
		{
			null => throw new ArgumentNullException(nameof(context), "IPluralRulesContext is null"),
			IPluralRulesContext prc when prc.n == 1 => PluralRulesValues.One,
			IPluralRulesContext prc when prc.n == 2 => PluralRulesValues.Two,
			_ => PluralRulesValues.Other
		};
	}
}