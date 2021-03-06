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
	/// Plural Rules Cardinal resources for 'Belarusian' [be]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#be"/>
	public class BePluralRulesCardinalResource : IPluralRulesCardinalResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public BePluralRulesCardinalResource()
		{
			this.Culture = new CultureInfo("be");
		}

		/// <summary>
		/// Evaluates an <see cref="IPluralRulesContext"/> against the 'Belarusian' [be] <see cref="IPluralRulesCardinalResource"/>
		/// </summary>
		/// <param name="context">An <see cref="IPluralRulesContext"/></param>
		/// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
		/// <remarks>
		/// one - n % 10 = 1 and n % 100 != 11
		/// few - n % 10 = 2..4 and n % 100 != 12..14
		/// many - n % 10 = 0 or n % 10 = 5..9 or n % 100 = 11..14
		/// other - 
		/// </remarks>
		/// <exception cref="ArgumentNullException"></exception>
		public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
		{
			null => throw new ArgumentNullException(nameof(context), "IPluralRulesContext is null"),
			IPluralRulesContext prc when prc.n % 10 == 1 && prc.n % 100 != 11 => PluralRulesValues.One,
			IPluralRulesContext prc when (prc.n % 10).Between(2, 4) && (prc.n % 100).NotBetween(12, 14) => PluralRulesValues.Few,
			IPluralRulesContext prc when prc.n % 10 == 0 || (prc.n % 10).Between(5, 9) || (prc.n % 100).Between(11, 14) => PluralRulesValues.Many,
			_ => PluralRulesValues.Other
		};
	}
}