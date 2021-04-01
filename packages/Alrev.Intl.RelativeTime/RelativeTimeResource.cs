using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.Abstractions.RelativeTime;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Alrev.Intl.RelativeTime
{
    public class RelativeTimeResource : ReadOnlyDictionary<int, string>, IRelativeTimeResource, IResource
    {
        public string Locale { get; }
        public RelativeTimeTypeValues RelativeTimeType { get; }
        public string DisplayName { get; }
        public IReadOnlyDictionary<PluralRulesValues, string> Past { get; }
        public IReadOnlyDictionary<PluralRulesValues, string> Future { get; }

        public RelativeTimeResource(
            string locale,
            RelativeTimeTypeValues relativeTimeType,
            string displayName,
            IDictionary<int, string> dictionary,
            IDictionary<PluralRulesValues, string> past,
            IDictionary<PluralRulesValues, string> future)
            : base(dictionary)
        {
            this.Locale = locale;
            this.RelativeTimeType = relativeTimeType;
            this.DisplayName = displayName;
            this.Past = new RelativeTimePluralRulesResource(past ?? new Dictionary<PluralRulesValues, string>());
            this.Future = new RelativeTimePluralRulesResource(future ?? new Dictionary<PluralRulesValues, string>());
        }
    }
}
