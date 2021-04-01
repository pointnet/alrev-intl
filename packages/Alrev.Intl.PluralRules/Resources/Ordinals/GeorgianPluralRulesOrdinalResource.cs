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
using System;
using System.Linq;

namespace Alrev.Intl.PluralRules.Resources.Ordinals
{
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#ka
    public class GeorgianPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "ka";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        // one - i = 1
        // many - i = 0 or i % 100 = 2..20,40,60,80
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.i == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.i == 0 || (prc.i % 100).In(new int[] { 40, 60, 80 }.Concat(Enumerable.Range(2, 19)).Cast<double>().ToArray()) => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}