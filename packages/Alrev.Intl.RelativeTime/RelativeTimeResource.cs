using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.Abstractions.RelativeTime;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Alrev.Intl.RelativeTime
{
    /// <summary>
    /// Relative time resource
    /// </summary>
    public class RelativeTimeResource : ReadOnlyDictionary<int, string>, IRelativeTimeResource, IResource
    {
        /// <summary>
        /// The resource locale
        /// </summary>
        public string Locale { get; }

        /// <summary>
        /// Gets the RelativeTimeUnitValues of the resource
        /// </summary>
        public RelativeTimeUnitValues RelativeTimeUnit { get; }

        /// <summary>
        /// Gets the RelativeTimeStyleValues of the resource
        /// </summary>
        public RelativeTimeStyleValues RelativeTimeStyle { get; }

        /// <summary>
        /// Gets the resource display name
        /// </summary>
        public string DisplayName { get; }

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
        /// <param name="locale">The resource locale</param>
        /// <param name="relativeTimeUnit">The resource <see cref="RelativeTimeUnitValues"/></param>
        /// <param name="relativeTimeStyle">The resource <see cref="RelativeTimeStyleValues"/></param>
        /// <param name="displayName">The resource display name</param>
        /// <param name="dictionary">The resource current dictionary</param>
        /// <param name="past">The resource past dictionary</param>
        /// <param name="future">The resource future dictionary</param>
        public RelativeTimeResource(
            string locale,
            RelativeTimeUnitValues relativeTimeUnit,
            RelativeTimeStyleValues relativeTimeStyle,
            string displayName,
            IDictionary<int, string> dictionary,
            IDictionary<PluralRulesValues, string> past,
            IDictionary<PluralRulesValues, string> future)
            : base(dictionary)
        {
            this.Locale = locale;
            this.RelativeTimeUnit = relativeTimeUnit;
            this.RelativeTimeStyle = relativeTimeStyle;
            this.DisplayName = displayName;
            this.Past = new RelativeTimePluralRulesResource(past ?? new Dictionary<PluralRulesValues, string>());
            this.Future = new RelativeTimePluralRulesResource(future ?? new Dictionary<PluralRulesValues, string>());
        }
    }
}
