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
    public class AzerbaijaniPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "az";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // one - n = 1
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.n == 1 => PluralRulesValues.One,
            _ => PluralRulesValues.Other
        };
    }
}