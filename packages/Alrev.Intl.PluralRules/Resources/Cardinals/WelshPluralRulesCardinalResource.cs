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
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#cy
    public class WelshPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "cy";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // zero - n = 0
        // one - n = 1
        // two - n = 2
        // few - n = 3
        // many - n = 6
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            IPluralRulesContext prc when prc.n == 0 => PluralRulesValues.Zero,
            IPluralRulesContext prc when prc.n == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.n == 2 => PluralRulesValues.Two,
            IPluralRulesContext prc when prc.n == 3 => PluralRulesValues.Few,
            IPluralRulesContext prc when prc.n == 6 => PluralRulesValues.Many,
            _ => PluralRulesValues.Other
        };
    }
}