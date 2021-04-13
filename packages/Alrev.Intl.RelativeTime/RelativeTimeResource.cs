using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.Abstractions.RelativeTime;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Alrev.Intl.RelativeTime
{
    /// <summary>
    /// Relative time resource
    /// </summary>
    public class RelativeTimeResource : ReadOnlyDictionary<int, string>, IRelativeTimeResource
    {
        /// <summary>
        /// Gets the Past resources dictionary
        /// </summary>
        public IReadOnlyDictionary<PluralRulesValues, string> Past { get; }

        /// <summary>
        /// Gets the Future resources dictionary
        /// </summary>
        public IReadOnlyDictionary<PluralRulesValues, string> Future { get; }

        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="dictionary">The resource current dictionary</param>
        /// <param name="past">The resource past dictionary</param>
        /// <param name="future">The resource future dictionary</param>
        public RelativeTimeResource(
            IDictionary<int, string> dictionary,
            IDictionary<PluralRulesValues, string> past,
            IDictionary<PluralRulesValues, string> future)
            : base(dictionary ?? new Dictionary<int, string>())
        {
            this.Past = new ReadOnlyDictionary<PluralRulesValues, string>(past ?? new Dictionary<PluralRulesValues, string>());
            this.Future = new ReadOnlyDictionary<PluralRulesValues, string>(future ?? new Dictionary<PluralRulesValues, string>());
        }
    }
}
