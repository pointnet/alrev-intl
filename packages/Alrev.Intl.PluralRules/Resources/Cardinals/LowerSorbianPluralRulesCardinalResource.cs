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
    public class LowerSorbianPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "dsb";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // one - v = 0 and i % 100 = 1 or f % 100 = 1
        // two - v = 0 and i % 100 = 2 or f % 100 = 2
        // few - v = 0 and i % 100 = 3..4 or f % 100 = 3..4
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.v == 0 && prc.i % 100 == 1 || prc.f % 100 == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.v == 0 && prc.i % 100 == 2 || prc.f % 100 == 2 => PluralRulesValues.Two,
            IPluralRulesContext prc when prc.v == 0 && (prc.i % 100).Between(3, 4) || (prc.f % 100).Between(3, 4) => PluralRulesValues.Few,
            _ => PluralRulesValues.Other
        };
    }
}