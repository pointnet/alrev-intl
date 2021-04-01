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
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#sk
    public class SlovakPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "sk";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // one - i = 1 and v = 0
        // few - i = 2..4 and v = 0
        // many - v != 0
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.i == 1 && prc.v == 0 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.i.Between(2, 4) && prc.v == 0 => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.v != 0 => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}