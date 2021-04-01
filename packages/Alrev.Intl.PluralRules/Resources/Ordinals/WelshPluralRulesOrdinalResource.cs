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
    public class WelshPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "cy";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        // zero - n = 0,7,8,9
        // one - n = 1
        // two - n = 2
        // few - n = 3,4
        // many - n = 5,6
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.n.In(0, 7, 8, 9) => PluralRulesValues.Zero,
            IPluralRulesContext prc when prc.n == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.n == 2 => PluralRulesValues.Two,
            IPluralRulesContext prc when prc.n.In(3, 4) => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.n.In(5, 6) => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}