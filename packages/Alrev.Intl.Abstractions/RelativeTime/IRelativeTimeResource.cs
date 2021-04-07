using Alrev.Intl.Abstractions.PluralRules;
using System.Collections.Generic;

namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    ///   Interface of a Relative Time resource.
    /// </summary>
    public interface IRelativeTimeResource : IReadOnlyDictionary<int, string>
    {
        /// <summary>
        /// Gets the resource display name
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Gets the RelativeTimeStylesValues of the resource
        /// </summary>
        RelativeTimeStylesValues RelativeTimeStyle { get; }

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
