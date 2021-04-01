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
    public class ManxPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "gv";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // one - v = 0 and i % 10 = 1
        // two - v = 0 and i % 10 = 2
        // few - v = 0 and i % 100 = 0,20,40,60,80
        // many - v != 0
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.v == 0 && prc.i % 10 == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.v == 0 && prc.i % 10 == 2 => PluralRulesValues.Two,
            IPluralRulesContext prc when prc.v == 0 && (prc.i % 100).In(0, 20, 40, 60, 80) => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.v != 0 => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}