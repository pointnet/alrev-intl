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
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#shi
    public class TachelhitPluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "shi";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        // one - i = 0 or n = 1
        // few - n = 2..10
        // other - 
        public PluralRulesValues Evaluate(IPluralRulesContext context) => context switch
        {
            null => throw new ArgumentNullException(nameof(context)),
            IPluralRulesContext prc when prc.i == 0 || prc.n == 1 => PluralRulesValues.One,
            IPluralRulesContext prc when prc.n == prc.i && prc.n.Between(2, 10) => PluralRulesValues.Few,
            _ => PluralRulesValues.Other
        };
    }
}