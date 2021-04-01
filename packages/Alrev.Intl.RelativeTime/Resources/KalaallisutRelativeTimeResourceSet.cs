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
    public class KalaallisutRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "kl";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Era",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Year",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} ukioq siden" }, { PluralRulesValues.Other, "for {0} ukioq siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ukioq" }, { PluralRulesValues.Other, "om {0} ukioq" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Year",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} ukioq siden" }, { PluralRulesValues.Other, "for {0} ukioq siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ukioq" }, { PluralRulesValues.Other, "om {0} ukioq" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Year",
                new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} ukioq siden" }, { PluralRulesValues.Other, "for {0} ukioq siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ukioq" }, { PluralRulesValues.Other, "om {0} ukioq" } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Month",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} qaammat siden" }, { PluralRulesValues.Other, "for {0} qaammat siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} qaammat" }, { PluralRulesValues.Other, "om {0} qaammat" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Month",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} qaammat siden" }, { PluralRulesValues.Other, "for {0} qaammat siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} qaammat" }, { PluralRulesValues.Other, "om {0} qaammat" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Month",
                new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} qaammat siden" }, { PluralRulesValues.Other, "for {0} qaammat siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} qaammat" }, { PluralRulesValues.Other, "om {0} qaammat" } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Week",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sapaatip-akunnera siden" }, { PluralRulesValues.Other, "for {0} sapaatip-akunnera siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sapaatip-akunnera" }, { PluralRulesValues.Other, "om {0} sapaatip-akunnera" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Week",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sapaatip-akunnera siden" }, { PluralRulesValues.Other, "for {0} sapaatip-akunnera siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sapaatip-akunnera" }, { PluralRulesValues.Other, "om {0} sapaatip-akunnera" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Week",
                new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sapaatip-akunnera siden" }, { PluralRulesValues.Other, "for {0} sapaatip-akunnera siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sapaatip-akunnera" }, { PluralRulesValues.Other, "om {0} sapaatip-akunnera" } }));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Week Of Month",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Day",
                new Dictionary<int, string> { { -1, "yesterday" }, { 0, "today" }, { 1, "tomorrow" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} ulloq unnuarlu siden" }, { PluralRulesValues.Other, "for {0} ulloq unnuarlu siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ulloq unnuarlu" }, { PluralRulesValues.Other, "om {0} ulloq unnuarlu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Day",
                new Dictionary<int, string> { { -1, "yesterday" }, { 0, "today" }, { 1, "tomorrow" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} ulloq unnuarlu siden" }, { PluralRulesValues.Other, "for {0} ulloq unnuarlu siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ulloq unnuarlu" }, { PluralRulesValues.Other, "om {0} ulloq unnuarlu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Day",
                new Dictionary<int, string> { { -1, "yesterday" }, { 0, "today" }, { 1, "tomorrow" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} ulloq unnuarlu siden" }, { PluralRulesValues.Other, "for {0} ulloq unnuarlu siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ulloq unnuarlu" }, { PluralRulesValues.Other, "om {0} ulloq unnuarlu" } }));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Day Of Year",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Day of the Week",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Day of the Week",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Day of the Week",
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Weekday Of Month",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Dayperiod",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Dayperiod",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Dayperiod",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Hour",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} nalunaaquttap-akunnera siden" }, { PluralRulesValues.Other, "for {0} nalunaaquttap-akunnera siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} nalunaaquttap-akunnera" }, { PluralRulesValues.Other, "om {0} nalunaaquttap-akunnera" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Hour",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} nalunaaquttap-akunnera siden" }, { PluralRulesValues.Other, "for {0} nalunaaquttap-akunnera siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} nalunaaquttap-akunnera" }, { PluralRulesValues.Other, "om {0} nalunaaquttap-akunnera" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Hour",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} nalunaaquttap-akunnera siden" }, { PluralRulesValues.Other, "for {0} nalunaaquttap-akunnera siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} nalunaaquttap-akunnera" }, { PluralRulesValues.Other, "om {0} nalunaaquttap-akunnera" } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Minute",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} minutsi siden" }, { PluralRulesValues.Other, "for {0} minutsi siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} minutsi" }, { PluralRulesValues.Other, "om {0} minutsi" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Minute",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} minutsi siden" }, { PluralRulesValues.Other, "for {0} minutsi siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} minutsi" }, { PluralRulesValues.Other, "om {0} minutsi" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Minute",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} minutsi siden" }, { PluralRulesValues.Other, "for {0} minutsi siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} minutsi" }, { PluralRulesValues.Other, "om {0} minutsi" } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Second",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sekundi siden" }, { PluralRulesValues.Other, "for {0} sekundi siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sekundi" }, { PluralRulesValues.Other, "om {0} sekundi" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Second",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sekundi siden" }, { PluralRulesValues.Other, "for {0} sekundi siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sekundi" }, { PluralRulesValues.Other, "om {0} sekundi" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Second",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sekundi siden" }, { PluralRulesValues.Other, "for {0} sekundi siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sekundi" }, { PluralRulesValues.Other, "om {0} sekundi" } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Zone",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Zone",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Zone",
                null,
                null,
                null));
    }
}