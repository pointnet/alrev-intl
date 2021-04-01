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

namespace Alrev.Intl.PluralRules.Resources.Cardinals
{
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#kw
    public class CornishPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "kw";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // zero - n = 0
        // one - n = 1
        // two - n % 100 = 2,22,42,62,82 or n % 1000 = 0 and n % 100000 = 1000..20000,40000,60000,80000 or n != 0 and n % 1000000 = 100000
        // few - n % 100 = 3,23,43,63,83
        // many - n != 1 and n % 100 = 1,21,41,61,81
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.n == 0 => PluralRulesValues.Zero,
            IPluralRulesContext prc when prc.n == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when (prc.n % 100).In(2, 22, 42, 62, 82) || prc.n % 1000 == 0 && (prc.n % 100000).In(new int[] { 40000, 60000, 80000 }.Concat(Enumerable.Range(1000, 19001)).Cast<double>().ToArray()) || prc.n != 0 && prc.n % 1000000 == 100000 => PluralRulesValues.Two,
            IPluralRulesContext prc when (prc.n % 100).In(3, 23, 43, 63, 83) => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.n != 1 && (prc.n % 100).In(1, 21, 41, 61, 81) => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}