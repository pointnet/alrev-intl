//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Script: ./scripts/cldr-relative-time.csx
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.Abstractions.RelativeTime;
using System;
using System.Collections.Generic;

namespace Alrev.Intl.RelativeTime.Resources
{
    /// <summary>
    /// <see cref="IRelativeTimeResourceSet"/> for 'Luo' [luo]
    /// </summary>
    public class LuoRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "luo";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ndalo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ndalo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ndalo",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "higa",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} y" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} y" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "higa",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} y" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} y" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "higa",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} y" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} y" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dwe",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dwe",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dwe",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "juma",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "juma",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "juma",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "Week Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "chieng’",
                new Dictionary<int, string> { { -1, "nyoro" }, { 0, "kawuono" }, { 1, "kiny" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "chieng’",
                new Dictionary<int, string> { { -1, "nyoro" }, { 0, "kawuono" }, { 1, "kiny" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "chieng’",
                new Dictionary<int, string> { { -1, "nyoro" }, { 0, "kawuono" }, { 1, "kiny" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "Day Of Year",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ndalo mar juma",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ndalo mar juma",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ndalo mar juma",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "Weekday Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "odieochieng’/otieno",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "odieochieng’/otieno",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "odieochieng’/otieno",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "saa",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "saa",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "saa",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} h" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dakika",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dakika",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dakika",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} min" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "nyiriri mar saa",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "nyiriri mar saa",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "nyiriri mar saa",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} s" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Luo' [luo]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "kar saa",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "kar saa",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "kar saa",
                null,
                null,
                null));
    }
}