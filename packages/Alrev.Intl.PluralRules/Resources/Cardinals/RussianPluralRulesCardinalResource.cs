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
    public class RussianPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "ru";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // one - v = 0 and i % 10 = 1 and i % 100 != 11
        // few - v = 0 and i % 10 = 2..4 and i % 100 != 12..14
        // many - v = 0 and i % 10 = 0 or v = 0 and i % 10 = 5..9 or v = 0 and i % 100 = 11..14
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.v == 0 && prc.i % 10 == 1 && prc.i % 100 != 11 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.v == 0 && (prc.i % 10).Between(2, 4) && (prc.i % 100).Between(12, 14) => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.v == 0 && prc.i % 10 == 0 || prc.v == 0 && (prc.i % 10).Between(5, 9) || prc.v == 0 && (prc.i % 100).Between(11, 14) => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}