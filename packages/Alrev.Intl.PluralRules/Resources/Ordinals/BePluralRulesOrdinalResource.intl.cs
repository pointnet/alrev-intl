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
	/// Plural Rules Ordinal resources for 'Belarusian' [be]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#be"/>
	public class BePluralRulesOrdinalResource : IPluralRulesOrdinalResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public BePluralRulesOrdinalResource()
		{
			this.Culture = new CultureInfo("be");
		}

		/// <summary>
		/// Evaluates an <see cref="IPluralRulesContext"/> against the 'Belarusian' [be] <see cref="IPluralRulesOrdinalResource"/>
		/// </summary>
		/// <param name="context">An <see cref="IPluralRulesContext"/></param>
		/// <returns>The <see cref="PluralRulesValues"/> of the <see cref="IPluralRulesContext"/></returns>
		/// <remarks>
		/// few - n % 10 = 2,3 and n % 100 != 12,13
		/// other - 
		/// </remarks>
		/// <exception cref="ArgumentNullException"></exception>
		public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
		{
			null => throw new ArgumentNullException(nameof(context), "IPluralRulesContext is null"),
			IPluralRulesContext prc when (prc.n % 10).In(2, 3) && (prc.n % 100).NotIn(12, 13) => PluralRulesValues.Few,
			_ => PluralRulesValues.Other
		};
	}
}