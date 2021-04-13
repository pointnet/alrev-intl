using Alrev.Intl.Abstractions.PluralRules;
using System.Collections.Generic;

namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// Defines a Relative Time resource.
    /// </summary>
    public interface IRelativeTimeResource : IReadOnlyDictionary<int, string>
    {
        /// <summary>
        /// Gets the Past resources dictionary
        /// </summary>
        IReadOnlyDictionary<PluralRulesValues, string> Past { get; }

        /// <summary>
        /// Gets the Future resources dictionary
        /// </summary>
        IReadOnlyDictionary<PluralRulesValues, string> Future { get; }
    }
}
