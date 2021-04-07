using Alrev.Intl.Abstractions.PluralRules;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Alrev.Intl.RelativeTime
{
    /// <summary>
    /// Dictionary of <see cref="PluralRulesValues"/>
    /// </summary>
    public class RelativeTimePluralRulesResource : ReadOnlyDictionary<PluralRulesValues, string>
    {
        /// <summary>
        /// The clas constructor
        /// </summary>
        /// <param name="dictionary">The dictionary of <see cref="PluralRulesValues"/> Relative Time resources</param>
        public RelativeTimePluralRulesResource(IDictionary<PluralRulesValues, string> dictionary) : base(dictionary) { }
    }
}
