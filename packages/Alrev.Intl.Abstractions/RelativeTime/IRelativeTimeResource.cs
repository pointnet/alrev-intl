using Alrev.Intl.Abstractions.PluralRules;
using System.Collections.Generic;

namespace Alrev.Intl.Abstractions.RelativeTime
{
    public interface IRelativeTimeResource : IReadOnlyDictionary<int, string>
    {
        string DisplayName { get; }
        RelativeTimeTypeValues RelativeTimeType { get; }
        IReadOnlyDictionary<PluralRulesValues, string> Past { get; }
        IReadOnlyDictionary<PluralRulesValues, string> Future { get; }
    }
}
