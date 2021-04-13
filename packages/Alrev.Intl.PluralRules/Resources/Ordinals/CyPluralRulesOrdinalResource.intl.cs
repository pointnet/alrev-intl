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
	/// Plural Rules Ordinal resources for 'Welsh' [cy]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#cy"/>
	public class CyPluralRulesOrdinalResource : IPluralRulesOrdinalResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public CyPluralRulesOrdinalResource()
		{
			this.Culture = new CultureInfo("cy");
		}

		/// <summary>
		/// Evaluates an <see cref="IPluralRulesContext"/> against the 'Welsh' [cy] <see cref="IPluralRulesOrdinalResource"/>
		/// </summary>
		/// <param name="context">An <see cref="IPluralRulesContext"/></param>
		/// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
		/// <remarks>
		/// zero - n = 0,7,8,9
		/// one - n = 1
		/// two - n = 2
		/// few - n = 3,4
		/// many - n = 5,6
		/// other - 
		/// </remarks>
		/// <exception cref="ArgumentNullException"></exception>
		public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
		{
			null => throw new ArgumentNullException(nameof(context), "IPluralRulesContext is null"),
			IPluralRulesContext prc when prc.n.In(0, 7, 8, 9) => PluralRulesValues.Zero,
			IPluralRulesContext prc when prc.n == 1 => PluralRulesValues.One,
			IPluralRulesContext prc when prc.n == 2 => PluralRulesValues.Two,
			IPluralRulesContext prc when prc.n.In(3, 4) => PluralRulesValues.Few,
			IPluralRulesContext prc when prc.n.In(5, 6) => PluralRulesValues.Many,
			_ => PluralRulesValues.Other
		};
	}
}