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

namespace Alrev.Intl.PluralRules.Resources.Ordinals
{
	/// <summary>
	/// Plural Rules Ordinal resources for 'Bangla' [bn]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#bn"/>
	public class BnPluralRulesOrdinalResource : IPluralRulesOrdinalResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public BnPluralRulesOrdinalResource()
		{
			this.Culture = new CultureInfo("bn");
		}

		/// <summary>
		/// Evaluates an <see cref="IPluralRulesContext"/> against the 'Bangla' [bn] <see cref="IPluralRulesOrdinalResource"/>
		/// </summary>
		/// <param name="context">An <see cref="IPluralRulesContext"/></param>
		/// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
		/// <remarks>
		/// one - n = 1,5,7,8,9,10
		/// two - n = 2,3
		/// few - n = 4
		/// many - n = 6
		/// other - 
		/// </remarks>
		/// <exception cref="ArgumentNullException"></exception>
		public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
		{
			null => throw new ArgumentNullException(nameof(context), "IPluralRulesContext is null"),
			IPluralRulesContext prc when prc.n.In(1, 5, 7, 8, 9, 10) => PluralRulesValues.One,
			IPluralRulesContext prc when prc.n.In(2, 3) => PluralRulesValues.Two,
			IPluralRulesContext prc when prc.n == 4 => PluralRulesValues.Few,
			IPluralRulesContext prc when prc.n == 6 => PluralRulesValues.Many,
			_ => PluralRulesValues.Other
		};
	}
}