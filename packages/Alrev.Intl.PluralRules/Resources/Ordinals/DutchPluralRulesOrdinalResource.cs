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
    public class DutchPluralRulesOrdinalResource : IPluralRulesResource, IResource
    {
        public string Locale { get; } = "nl";

        public PluralRulesTypeValues PluralRulesType => PluralRulesTypeValues.Ordinal;

        public PluralRulesValues Evaluate(IPluralRulesContext context) => PluralRulesValues.Other;
    }
}