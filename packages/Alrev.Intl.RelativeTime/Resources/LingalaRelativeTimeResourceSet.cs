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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Lingala' [ln]
    /// </summary>
    public class LingalaRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ln";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Era,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Long,
                "Ntángo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Narrow,
                "Ntángo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Short,
                "Ntángo",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "Mobú",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} y" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} y" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "Mobú",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} y" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} y" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "Mobú",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} y" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} y" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "Sánzá",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "Sánzá",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "Sánzá",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "Pɔ́sɔ",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "Pɔ́sɔ",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "Pɔ́sɔ",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Long,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Narrow,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Short,
                "Week Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "Mokɔlɔ",
                new Dictionary<int, string> { { -1, "Lóbi elékí" }, { 0, "Lɛlɔ́" }, { 1, "Lóbi ekoyâ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "Mokɔlɔ",
                new Dictionary<int, string> { { -1, "Lóbi elékí" }, { 0, "Lɛlɔ́" }, { 1, "Lóbi ekoyâ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "Mokɔlɔ",
                new Dictionary<int, string> { { -1, "Lóbi elékí" }, { 0, "Lɛlɔ́" }, { 1, "Lóbi ekoyâ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayOfYear,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Long,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Narrow,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Short,
                "Day Of Year",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Weekday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Long,
                "Mokɔlɔ ya pɔ́sɔ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Narrow,
                "Mokɔlɔ ya pɔ́sɔ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Short,
                "Mokɔlɔ ya pɔ́sɔ",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekdayOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Long,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Narrow,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Short,
                "Weekday Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayPeriod,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Long,
                "Eleko ya mokɔlɔ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Narrow,
                "Eleko ya mokɔlɔ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Short,
                "Eleko ya mokɔlɔ",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "Ngonga",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "Ngonga",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "Ngonga",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} h" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "Monúti",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "Monúti",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "Monúti",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} min" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "Sɛkɔ́ndɛ",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "Sɛkɔ́ndɛ",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "Sɛkɔ́ndɛ",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} s" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Lingala' [ln]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Zone,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Long,
                "Ntáká ya ngonga",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Narrow,
                "Ntáká ya ngonga",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Short,
                "Ntáká ya ngonga",
                null,
                null,
                null));

        /// <summary>
        /// Gets the Relative Time resource styles based on the unit specified
        /// </summary>
        /// <param name="relativeTimeUnit">The resource unit to get</param>
        /// <returns>An <see cref="IRelativeTimeStylesResource"/></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IRelativeTimeStylesResource GetRelativeTimeStylesResource(RelativeTimeUnitValues relativeTimeUnit) => relativeTimeUnit switch
        {
            RelativeTimeUnitValues.Era => this.Era,
            RelativeTimeUnitValues.Year => this.Year,
            RelativeTimeUnitValues.Quarter => this.Quarter,
            RelativeTimeUnitValues.Month => this.Month,
            RelativeTimeUnitValues.Week => this.Week,
            RelativeTimeUnitValues.WeekOfMonth => this.WeekOfMonth,
            RelativeTimeUnitValues.Day => this.Day,
            RelativeTimeUnitValues.DayOfYear => this.DayOfYear,
            RelativeTimeUnitValues.Weekday => this.Weekday,
            RelativeTimeUnitValues.WeekdayOfMonth => this.WeekdayOfMonth,
            RelativeTimeUnitValues.Sunday => this.Sunday,
            RelativeTimeUnitValues.Monday => this.Monday,
            RelativeTimeUnitValues.Tuesday => this.Tuesday,
            RelativeTimeUnitValues.Wednesday => this.Wednesday,
            RelativeTimeUnitValues.Thursday => this.Thursday,
            RelativeTimeUnitValues.Friday => this.Friday,
            RelativeTimeUnitValues.Saturday => this.Saturday,
            RelativeTimeUnitValues.DayPeriod => this.DayPeriod,
            RelativeTimeUnitValues.Hour => this.Hour,
            RelativeTimeUnitValues.Minute => this.Minute,
            RelativeTimeUnitValues.Second => this.Second,
            RelativeTimeUnitValues.Zone => this.Zone,
            _ => throw new NotImplementedException($"Relative time unit '{relativeTimeUnit}' is not supported")
        };
    }
}