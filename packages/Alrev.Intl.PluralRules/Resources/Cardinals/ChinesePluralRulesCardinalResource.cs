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
    // https://unicode-org.github.io/cldr-staging/charts/39/supplemental/language_plural_rules.html#zh
    public class ChinesePluralRulesCardinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "zh";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Cardinal;

        public PluralRulesValues Evaluate(IPluralRulesContext context) => PluralRulesValues.Other;
    }
}