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
        /// Gets the RelativeTimeUnitValues of the resource
        /// </summary>
        RelativeTimeUnitValues RelativeTimeUnit { get; }

        /// <summary>
        /// Gets the RelativeTimeStyleValues of the resource
        /// </summary>
        RelativeTimeStyleValues RelativeTimeStyle { get; }

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
