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
    /// <see cref="IRelativeTimeResourceSet"/> for 'English (Canada)' [en-CA]
    /// </summary>
    public class EnglishCanadaRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "en-CA";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "era",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "year",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} year ago" }, { PluralRulesValues.Other, "{0} years ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} year" }, { PluralRulesValues.Other, "in {0} years" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "yr.",
                new Dictionary<int, string> { { -1, "last yr" }, { 0, "this yr" }, { 1, "next yr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yr. ago" }, { PluralRulesValues.Other, "{0} yrs. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} yr." }, { PluralRulesValues.Other, "in {0} yrs." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "yr.",
                new Dictionary<int, string> { { -1, "last yr" }, { 0, "this yr" }, { 1, "next yr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yr. ago" }, { PluralRulesValues.Other, "{0} yrs. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} yr." }, { PluralRulesValues.Other, "in {0} yrs." } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} quarter ago" }, { PluralRulesValues.Other, "{0} quarters ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} quarter" }, { PluralRulesValues.Other, "in {0} quarters" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "qtr.",
                new Dictionary<int, string> { { -1, "last qtr." }, { 0, "this qtr." }, { 1, "next qtr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} qtr. ago" }, { PluralRulesValues.Other, "{0} qtrs. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} qtr." }, { PluralRulesValues.Other, "in {0} qtrs." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "qtr.",
                new Dictionary<int, string> { { -1, "last qtr." }, { 0, "this qtr." }, { 1, "next qtr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} qtr. ago" }, { PluralRulesValues.Other, "{0} qtrs. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} qtr." }, { PluralRulesValues.Other, "in {0} qtrs." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "month",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} month ago" }, { PluralRulesValues.Other, "{0} months ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} month" }, { PluralRulesValues.Other, "in {0} months" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "mo.",
                new Dictionary<int, string> { { -1, "last mo" }, { 0, "this mo" }, { 1, "next mo" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mo. ago" }, { PluralRulesValues.Other, "{0} mos. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} mo." }, { PluralRulesValues.Other, "in {0} mos." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "mo.",
                new Dictionary<int, string> { { -1, "last mo" }, { 0, "this mo" }, { 1, "next mo" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mo. ago" }, { PluralRulesValues.Other, "{0} mos. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} mo." }, { PluralRulesValues.Other, "in {0} mos." } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "week",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} week ago" }, { PluralRulesValues.Other, "{0} weeks ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} week" }, { PluralRulesValues.Other, "in {0} weeks" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "wk.",
                new Dictionary<int, string> { { -1, "last wk" }, { 0, "this wk" }, { 1, "next wk" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} wk. ago" }, { PluralRulesValues.Other, "{0} wks. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} wk." }, { PluralRulesValues.Other, "in {0} wks." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "wk.",
                new Dictionary<int, string> { { -1, "last wk" }, { 0, "this wk" }, { 1, "next wk" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} wk. ago" }, { PluralRulesValues.Other, "{0} wks. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} wk." }, { PluralRulesValues.Other, "in {0} wks." } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "week of month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "wk of mo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "wk of mo",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "day",
                new Dictionary<int, string> { { -1, "yesterday" }, { 0, "today" }, { 1, "tomorrow" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} day ago" }, { PluralRulesValues.Other, "{0} days ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} day" }, { PluralRulesValues.Other, "in {0} days" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "day",
                new Dictionary<int, string> { { -1, "yesterday" }, { 0, "today" }, { 1, "tomorrow" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} day ago" }, { PluralRulesValues.Other, "{0} days ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} day" }, { PluralRulesValues.Other, "in {0} days" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "day",
                new Dictionary<int, string> { { -1, "yesterday" }, { 0, "today" }, { 1, "tomorrow" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} day ago" }, { PluralRulesValues.Other, "{0} days ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} day" }, { PluralRulesValues.Other, "in {0} days" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "day of year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "day of yr",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "day of yr",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "day of the week",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "day of wk",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "day of wk",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "weekday of the month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "wkday of mo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "wkday of mo",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sunday ago" }, { PluralRulesValues.Other, "{0} Sundays ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sunday" }, { PluralRulesValues.Other, "in {0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Su" }, { 0, "this Su" }, { 1, "next Su" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Su ago" }, { PluralRulesValues.Other, "{0} Su’s ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Su" }, { PluralRulesValues.Other, "in {0} Su’s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Sun" }, { 0, "this Sun" }, { 1, "next Sun" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sun. ago" }, { PluralRulesValues.Other, "{0} Sun’s. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sun." }, { PluralRulesValues.Other, "in {0} Sun’s." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Monday ago" }, { PluralRulesValues.Other, "{0} Mondays ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Monday" }, { PluralRulesValues.Other, "in {0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last M" }, { 0, "this M" }, { 1, "next M" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} M ago" }, { PluralRulesValues.Other, "{0} Mo’s ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} M" }, { PluralRulesValues.Other, "in {0} Mo’s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Mon" }, { 0, "this Mon" }, { 1, "next Mon" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Mon. ago" }, { PluralRulesValues.Other, "{0} Mon’s. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Mon." }, { PluralRulesValues.Other, "in {0} Mon’s." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tuesday ago" }, { PluralRulesValues.Other, "{0} Tuesdays ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Tuesday" }, { PluralRulesValues.Other, "in {0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Tu" }, { 0, "this Tu" }, { 1, "next Tu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tu ago" }, { PluralRulesValues.Other, "{0} Tu’s ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Tu" }, { PluralRulesValues.Other, "in {0} Tu’s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Tue" }, { 0, "this Tue" }, { 1, "next Tue" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tue. ago" }, { PluralRulesValues.Other, "{0} Tue’s. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Tue." }, { PluralRulesValues.Other, "in {0} Tue’s." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Wednesday ago" }, { PluralRulesValues.Other, "{0} Wednesdays ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Wednesday" }, { PluralRulesValues.Other, "in {0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last We" }, { 0, "this We" }, { 1, "next We" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} We ago" }, { PluralRulesValues.Other, "{0} We’s ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} We" }, { PluralRulesValues.Other, "in {0} We’s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Wed" }, { 0, "this Wed" }, { 1, "next Wed" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Wed. ago" }, { PluralRulesValues.Other, "{0} Wed’s. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Wed." }, { PluralRulesValues.Other, "in {0} Wed’s." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Thursday ago" }, { PluralRulesValues.Other, "{0} Thursdays ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Thursday" }, { PluralRulesValues.Other, "in {0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Th" }, { 0, "this Th" }, { 1, "next Th" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Th ago" }, { PluralRulesValues.Other, "{0} Th’s ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Th" }, { PluralRulesValues.Other, "in {0} Th’s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Thu" }, { 0, "this Thu" }, { 1, "next Thu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Thu. ago" }, { PluralRulesValues.Other, "{0} Thu’s ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Thu." }, { PluralRulesValues.Other, "in {0} Thu’s." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Friday ago" }, { PluralRulesValues.Other, "{0} Fridays ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Friday" }, { PluralRulesValues.Other, "in {0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Fr" }, { 0, "this Fr" }, { 1, "next Fr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Fr ago" }, { PluralRulesValues.Other, "{0} Fr’s ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Fr" }, { PluralRulesValues.Other, "in {0} Fr’s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Fri" }, { 0, "this Fri" }, { 1, "next Fri" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Fri. ago" }, { PluralRulesValues.Other, "{0} Fri’s. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Fri." }, { PluralRulesValues.Other, "in {0} Fri’s." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Saturday ago" }, { PluralRulesValues.Other, "{0} Saturdays ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Saturday" }, { PluralRulesValues.Other, "in {0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Sa" }, { 0, "this Sa" }, { 1, "next Sa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sa ago" }, { PluralRulesValues.Other, "{0} Sa’s ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sa" }, { PluralRulesValues.Other, "in {0} Sa’s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Sat" }, { 0, "this Sat" }, { 1, "next Sat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sat. ago" }, { PluralRulesValues.Other, "{0} Sat’s. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sat." }, { PluralRulesValues.Other, "in {0} Sat’s." } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "a.m./p.m.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "a.m./p.m.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "a.m./p.m.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "hour",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hour ago" }, { PluralRulesValues.Other, "{0} hours ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} hour" }, { PluralRulesValues.Other, "in {0} hours" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "hr.",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hr. ago" }, { PluralRulesValues.Other, "{0} hrs. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} hr." }, { PluralRulesValues.Other, "in {0} hrs." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "hr.",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hr. ago" }, { PluralRulesValues.Other, "{0} hrs. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} hr." }, { PluralRulesValues.Other, "in {0} hrs." } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "minute",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minute ago" }, { PluralRulesValues.Other, "{0} minutes ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} minute" }, { PluralRulesValues.Other, "in {0} minutes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "min.",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. ago" }, { PluralRulesValues.Other, "{0} mins. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} min." }, { PluralRulesValues.Other, "in {0} mins." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "min.",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. ago" }, { PluralRulesValues.Other, "{0} mins. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} min." }, { PluralRulesValues.Other, "in {0} mins." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "second",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} second ago" }, { PluralRulesValues.Other, "{0} seconds ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} second" }, { PluralRulesValues.Other, "in {0} seconds" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "sec.",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sec. ago" }, { PluralRulesValues.Other, "{0} secs. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} sec." }, { PluralRulesValues.Other, "in {0} secs." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sec.",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sec. ago" }, { PluralRulesValues.Other, "{0} secs. ago" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} sec." }, { PluralRulesValues.Other, "in {0} secs." } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'English (Canada)' [en-CA]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "time zone",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "zone",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "zone",
                null,
                null,
                null));
    }
}