using Alrev.Intl.Abstractions.PluralRules;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Alrev.Intl.RelativeTime
{
    public class RelativeTimePluralRulesResource : ReadOnlyDictionary<PluralRulesValues, string>
    {
        public RelativeTimePluralRulesResource(IDictionary<PluralRulesValues, string> dictionary) : base(dictionary) { }
    }
}
