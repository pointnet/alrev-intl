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
    public class CebuanoPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "ceb";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // one - v = 0 and i = 1,2,3 or v = 0 and i % 10 != 4,6,9 or v != 0 and f % 10 != 4,6,9
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.v == 0 && prc.i.In(1, 2, 3) || prc.v == 0 && (prc.i % 10).NotIn(4, 6, 9) || prc.v != 0 && (prc.f % 10).NotIn(4, 6, 9) => PluralRulesValues.One,
            _ => PluralRulesValues.Other
        };
    }
}