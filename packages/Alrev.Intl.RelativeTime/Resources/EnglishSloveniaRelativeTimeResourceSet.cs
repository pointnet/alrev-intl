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
using Alrev.Intl.Abstractions.RelativeTime;
using System;

namespace Alrev.Intl.RelativeTime.Resources
{
    public class EnglishSloveniaRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "en-SI";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "era",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "era",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "era",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "year",
                "last year",
                "this year",
                "next year",
                new RelativeTimeCountResource("{0} year ago", "{0} years ago"),
                new RelativeTimeCountResource("in {0} year", "in {0} years")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "yr",
                "last yr",
                "this yr",
                "next yr",
                new RelativeTimeCountResource("{0} yr ago", "{0} yr ago"),
                new RelativeTimeCountResource("in {0} yr", "in {0} yr")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "yr",
                "last yr",
                "this yr",
                "next yr",
                new RelativeTimeCountResource("{0} yr ago", "{0} yr ago"),
                new RelativeTimeCountResource("in {0} yr", "in {0} yr")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "quarter",
                "last quarter",
                "this quarter",
                "next quarter",
                new RelativeTimeCountResource("{0} quarter ago", "{0} quarters ago"),
                new RelativeTimeCountResource("in {0} quarter", "in {0} quarters")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "qtr",
                "last qtr.",
                "this qtr.",
                "next qtr.",
                new RelativeTimeCountResource("{0} qtr ago", "{0} qtr ago"),
                new RelativeTimeCountResource("in {0} qtr", "in {0} qtr")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "qtr",
                "last qtr.",
                "this qtr.",
                "next qtr.",
                new RelativeTimeCountResource("{0} qtr ago", "{0} qtr ago"),
                new RelativeTimeCountResource("in {0} qtr", "in {0} qtr")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "month",
                "last month",
                "this month",
                "next month",
                new RelativeTimeCountResource("{0} month ago", "{0} months ago"),
                new RelativeTimeCountResource("in {0} month", "in {0} months")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "mo",
                "last mo",
                "this mo",
                "next mo",
                new RelativeTimeCountResource("{0} mo ago", "{0} mo ago"),
                new RelativeTimeCountResource("in {0} mo", "in {0} mo")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "mo",
                "last mo",
                "this mo",
                "next mo",
                new RelativeTimeCountResource("{0} mo ago", "{0} mo ago"),
                new RelativeTimeCountResource("in {0} mo", "in {0} mo")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "week",
                "last week",
                "this week",
                "next week",
                new RelativeTimeCountResource("{0} week ago", "{0} weeks ago"),
                new RelativeTimeCountResource("in {0} week", "in {0} weeks")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "wk",
                "last wk",
                "this wk",
                "next wk",
                new RelativeTimeCountResource("{0} wk ago", "{0} wk ago"),
                new RelativeTimeCountResource("in {0} wk", "in {0} wk")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "wk",
                "last wk",
                "this wk",
                "next wk",
                new RelativeTimeCountResource("{0} wk ago", "{0} wk ago"),
                new RelativeTimeCountResource("in {0} wk", "in {0} wk")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "week of month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "wk of mo",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "wk of mo",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "day",
                "yesterday",
                "today",
                "tomorrow",
                new RelativeTimeCountResource("{0} day ago", "{0} days ago"),
                new RelativeTimeCountResource("in {0} day", "in {0} days")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "day",
                "yesterday",
                "today",
                "tomorrow",
                new RelativeTimeCountResource("{0} day ago", "{0} days ago"),
                new RelativeTimeCountResource("in {0} day", "in {0} days")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "day",
                "yesterday",
                "today",
                "tomorrow",
                new RelativeTimeCountResource("{0} day ago", "{0} days ago"),
                new RelativeTimeCountResource("in {0} day", "in {0} days")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "day of year",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "day of yr",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "day of yr",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "day of the week",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "day of wk",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "day of wk",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "weekday of the month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "wkday of mo",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "wkday of mo",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Sunday",
                "this Sunday",
                "next Sunday",
                new RelativeTimeCountResource("{0} Sunday ago", "{0} Sundays ago"),
                new RelativeTimeCountResource("in {0} Sunday", "in {0} Sundays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Su",
                "this Su",
                "next Su",
                new RelativeTimeCountResource("{0} Su ago", "{0} Su ago"),
                new RelativeTimeCountResource("in {0} Su", "in {0} Su")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Sun",
                "this Sun",
                "next Sun",
                new RelativeTimeCountResource("{0} Sun ago", "{0} Sun ago"),
                new RelativeTimeCountResource("in {0} Sun", "in {0} Sun")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Monday",
                "this Monday",
                "next Monday",
                new RelativeTimeCountResource("{0} Monday ago", "{0} Mondays ago"),
                new RelativeTimeCountResource("in {0} Monday", "in {0} Mondays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last M",
                "this M",
                "next M",
                new RelativeTimeCountResource("{0} M ago", "{0} M ago"),
                new RelativeTimeCountResource("in {0} M", "in {0} M")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Mon",
                "this Mon",
                "next Mon",
                new RelativeTimeCountResource("{0} Mon ago", "{0} Mon ago"),
                new RelativeTimeCountResource("in {0} Mon", "in {0} Mon")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Tuesday",
                "this Tuesday",
                "next Tuesday",
                new RelativeTimeCountResource("{0} Tuesday ago", "{0} Tuesdays ago"),
                new RelativeTimeCountResource("in {0} Tuesday", "in {0} Tuesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Tu",
                "this Tu",
                "next Tu",
                new RelativeTimeCountResource("{0} Tu ago", "{0} Tu ago"),
                new RelativeTimeCountResource("in {0} Tu", "in {0} Tu")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Tue",
                "this Tue",
                "next Tue",
                new RelativeTimeCountResource("{0} Tue ago", "{0} Tue ago"),
                new RelativeTimeCountResource("in {0} Tue", "in {0} Tue")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Wednesday",
                "this Wednesday",
                "next Wednesday",
                new RelativeTimeCountResource("{0} Wednesday ago", "{0} Wednesdays ago"),
                new RelativeTimeCountResource("in {0} Wednesday", "in {0} Wednesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last W",
                "this W",
                "next W",
                new RelativeTimeCountResource("{0} W ago", "{0} W ago"),
                new RelativeTimeCountResource("in {0} W", "in {0} W")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Wed",
                "this Wed",
                "next Wed",
                new RelativeTimeCountResource("{0} Wed ago", "{0} Wed ago"),
                new RelativeTimeCountResource("in {0} Wed", "in {0} Wed")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Thursday",
                "this Thursday",
                "next Thursday",
                new RelativeTimeCountResource("{0} Thursday ago", "{0} Thursdays ago"),
                new RelativeTimeCountResource("in {0} Thursday", "in {0} Thursdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Th",
                "this Th",
                "next Th",
                new RelativeTimeCountResource("{0} Th ago", "{0} Th ago"),
                new RelativeTimeCountResource("in {0} Th", "in {0} Th")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Thu",
                "this Thu",
                "next Thu",
                new RelativeTimeCountResource("{0} Thu ago", "{0} Thu ago"),
                new RelativeTimeCountResource("in {0} Thu", "in {0} Thu")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Friday",
                "this Friday",
                "next Friday",
                new RelativeTimeCountResource("{0} Friday ago", "{0} Fridays ago"),
                new RelativeTimeCountResource("in {0} Friday", "in {0} Fridays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last F",
                "this F",
                "next F",
                new RelativeTimeCountResource("{0} F ago", "{0} F ago"),
                new RelativeTimeCountResource("in {0} F", "in {0} F")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Fri",
                "this Fri",
                "next Fri",
                new RelativeTimeCountResource("{0} Fri ago", "{0} Fri ago"),
                new RelativeTimeCountResource("in {0} Fri", "in {0} Fri")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Saturday",
                "this Saturday",
                "next Saturday",
                new RelativeTimeCountResource("{0} Saturday ago", "{0} Saturdays ago"),
                new RelativeTimeCountResource("in {0} Saturday", "in {0} Saturdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Sa",
                "this Sa",
                "next Sa",
                new RelativeTimeCountResource("{0} Sa ago", "{0} Sa ago"),
                new RelativeTimeCountResource("in {0} Sa", "in {0} Sa")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Sat",
                "this Sat",
                "next Sat",
                new RelativeTimeCountResource("{0} Sat ago", "{0} Sat ago"),
                new RelativeTimeCountResource("in {0} Sat", "in {0} Sat")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "am/pm",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "am/pm",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "am/pm",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "hour",
                null,
                "this hour",
                null,
                new RelativeTimeCountResource("{0} hour ago", "{0} hours ago"),
                new RelativeTimeCountResource("in {0} hour", "in {0} hours")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "hr",
                null,
                "this hour",
                null,
                new RelativeTimeCountResource("{0} hr ago", "{0} hr ago"),
                new RelativeTimeCountResource("in {0} hr", "in {0} hr")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "hr",
                null,
                "this hour",
                null,
                new RelativeTimeCountResource("{0} hr ago", "{0} hr ago"),
                new RelativeTimeCountResource("in {0} hr", "in {0} hr")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minute",
                null,
                "this minute",
                null,
                new RelativeTimeCountResource("{0} minute ago", "{0} minutes ago"),
                new RelativeTimeCountResource("in {0} minute", "in {0} minutes")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                null,
                "this minute",
                null,
                new RelativeTimeCountResource("{0} min ago", "{0} min ago"),
                new RelativeTimeCountResource("in {0} min", "in {0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                null,
                "this minute",
                null,
                new RelativeTimeCountResource("{0} min ago", "{0} min ago"),
                new RelativeTimeCountResource("in {0} min", "in {0} min")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "second",
                null,
                "now",
                null,
                new RelativeTimeCountResource("{0} second ago", "{0} seconds ago"),
                new RelativeTimeCountResource("in {0} second", "in {0} seconds")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sec",
                null,
                "now",
                null,
                new RelativeTimeCountResource("{0} sec ago", "{0} sec ago"),
                new RelativeTimeCountResource("in {0} sec", "in {0} sec")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sec",
                null,
                "now",
                null,
                new RelativeTimeCountResource("{0} sec ago", "{0} sec ago"),
                new RelativeTimeCountResource("in {0} sec", "in {0} sec")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "time zone",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "zone",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "zone",
                null,
                null,
                null,
                null,
                null));
    }
}