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
    public class FulahLatinNigerRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ff-Latn-NE";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Jamaanu",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Jamaanu",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Jamaanu",
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
                "Hitaande",
                "last year",
                "this year",
                "next year",
                new RelativeTimeCountResource(null, "-{0} y"),
                new RelativeTimeCountResource(null, "+{0} y")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Hitaande",
                "last year",
                "this year",
                "next year",
                new RelativeTimeCountResource(null, "-{0} y"),
                new RelativeTimeCountResource(null, "+{0} y")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Hitaande",
                "last year",
                "this year",
                "next year",
                new RelativeTimeCountResource(null, "-{0} y"),
                new RelativeTimeCountResource(null, "+{0} y")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Quarter",
                "last quarter",
                "this quarter",
                "next quarter",
                new RelativeTimeCountResource(null, "-{0} Q"),
                new RelativeTimeCountResource(null, "+{0} Q")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Quarter",
                "last quarter",
                "this quarter",
                "next quarter",
                new RelativeTimeCountResource(null, "-{0} Q"),
                new RelativeTimeCountResource(null, "+{0} Q")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Quarter",
                "last quarter",
                "this quarter",
                "next quarter",
                new RelativeTimeCountResource(null, "-{0} Q"),
                new RelativeTimeCountResource(null, "+{0} Q")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Lewru",
                "last month",
                "this month",
                "next month",
                new RelativeTimeCountResource(null, "-{0} m"),
                new RelativeTimeCountResource(null, "+{0} m")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Lewru",
                "last month",
                "this month",
                "next month",
                new RelativeTimeCountResource(null, "-{0} m"),
                new RelativeTimeCountResource(null, "+{0} m")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Lewru",
                "last month",
                "this month",
                "next month",
                new RelativeTimeCountResource(null, "-{0} m"),
                new RelativeTimeCountResource(null, "+{0} m")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Yontere",
                "last week",
                "this week",
                "next week",
                new RelativeTimeCountResource(null, "-{0} w"),
                new RelativeTimeCountResource(null, "+{0} w")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Yontere",
                "last week",
                "this week",
                "next week",
                new RelativeTimeCountResource(null, "-{0} w"),
                new RelativeTimeCountResource(null, "+{0} w")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Yontere",
                "last week",
                "this week",
                "next week",
                new RelativeTimeCountResource(null, "-{0} w"),
                new RelativeTimeCountResource(null, "+{0} w")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Week Of Month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Week Of Month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Week Of Month",
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
                "Ñalnde",
                "Haŋki",
                "Hannde",
                "Jaŋngo",
                new RelativeTimeCountResource(null, "-{0} d"),
                new RelativeTimeCountResource(null, "+{0} d")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Ñalnde",
                "Haŋki",
                "Hannde",
                "Jaŋngo",
                new RelativeTimeCountResource(null, "-{0} d"),
                new RelativeTimeCountResource(null, "+{0} d")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Ñalnde",
                "Haŋki",
                "Hannde",
                "Jaŋngo",
                new RelativeTimeCountResource(null, "-{0} d"),
                new RelativeTimeCountResource(null, "+{0} d")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Day Of Year",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Day Of Year",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Day Of Year",
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
                "Ñalɗi yontere",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Ñalɗi yontere",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Ñalɗi yontere",
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
                "Weekday Of Month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Weekday Of Month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Weekday Of Month",
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
                new RelativeTimeCountResource(null, "-{0} Sundays"),
                new RelativeTimeCountResource(null, "+{0} Sundays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Sunday",
                "this Sunday",
                "next Sunday",
                new RelativeTimeCountResource(null, "-{0} Sundays"),
                new RelativeTimeCountResource(null, "+{0} Sundays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Sunday",
                "this Sunday",
                "next Sunday",
                new RelativeTimeCountResource(null, "-{0} Sundays"),
                new RelativeTimeCountResource(null, "+{0} Sundays")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Monday",
                "this Monday",
                "next Monday",
                new RelativeTimeCountResource(null, "-{0} Mondays"),
                new RelativeTimeCountResource(null, "+{0} Mondays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Monday",
                "this Monday",
                "next Monday",
                new RelativeTimeCountResource(null, "-{0} Mondays"),
                new RelativeTimeCountResource(null, "+{0} Mondays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Monday",
                "this Monday",
                "next Monday",
                new RelativeTimeCountResource(null, "-{0} Mondays"),
                new RelativeTimeCountResource(null, "+{0} Mondays")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Tuesday",
                "this Tuesday",
                "next Tuesday",
                new RelativeTimeCountResource(null, "-{0} Tuesdays"),
                new RelativeTimeCountResource(null, "+{0} Tuesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Tuesday",
                "this Tuesday",
                "next Tuesday",
                new RelativeTimeCountResource(null, "-{0} Tuesdays"),
                new RelativeTimeCountResource(null, "+{0} Tuesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Tuesday",
                "this Tuesday",
                "next Tuesday",
                new RelativeTimeCountResource(null, "-{0} Tuesdays"),
                new RelativeTimeCountResource(null, "+{0} Tuesdays")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Wednesday",
                "this Wednesday",
                "next Wednesday",
                new RelativeTimeCountResource(null, "-{0} Wednesdays"),
                new RelativeTimeCountResource(null, "+{0} Wednesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Wednesday",
                "this Wednesday",
                "next Wednesday",
                new RelativeTimeCountResource(null, "-{0} Wednesdays"),
                new RelativeTimeCountResource(null, "+{0} Wednesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Wednesday",
                "this Wednesday",
                "next Wednesday",
                new RelativeTimeCountResource(null, "-{0} Wednesdays"),
                new RelativeTimeCountResource(null, "+{0} Wednesdays")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Thursday",
                "this Thursday",
                "next Thursday",
                new RelativeTimeCountResource(null, "-{0} Thursdays"),
                new RelativeTimeCountResource(null, "+{0} Thursdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Thursday",
                "this Thursday",
                "next Thursday",
                new RelativeTimeCountResource(null, "-{0} Thursdays"),
                new RelativeTimeCountResource(null, "+{0} Thursdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Thursday",
                "this Thursday",
                "next Thursday",
                new RelativeTimeCountResource(null, "-{0} Thursdays"),
                new RelativeTimeCountResource(null, "+{0} Thursdays")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Friday",
                "this Friday",
                "next Friday",
                new RelativeTimeCountResource(null, "-{0} Fridays"),
                new RelativeTimeCountResource(null, "+{0} Fridays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Friday",
                "this Friday",
                "next Friday",
                new RelativeTimeCountResource(null, "-{0} Fridays"),
                new RelativeTimeCountResource(null, "+{0} Fridays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Friday",
                "this Friday",
                "next Friday",
                new RelativeTimeCountResource(null, "-{0} Fridays"),
                new RelativeTimeCountResource(null, "+{0} Fridays")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "last Saturday",
                "this Saturday",
                "next Saturday",
                new RelativeTimeCountResource(null, "-{0} Saturdays"),
                new RelativeTimeCountResource(null, "+{0} Saturdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "last Saturday",
                "this Saturday",
                "next Saturday",
                new RelativeTimeCountResource(null, "-{0} Saturdays"),
                new RelativeTimeCountResource(null, "+{0} Saturdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "last Saturday",
                "this Saturday",
                "next Saturday",
                new RelativeTimeCountResource(null, "-{0} Saturdays"),
                new RelativeTimeCountResource(null, "+{0} Saturdays")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Sahnga",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Sahnga",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Sahnga",
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
                "Waktu",
                null,
                "this hour",
                null,
                new RelativeTimeCountResource(null, "-{0} h"),
                new RelativeTimeCountResource(null, "+{0} h")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Waktu",
                null,
                "this hour",
                null,
                new RelativeTimeCountResource(null, "-{0} h"),
                new RelativeTimeCountResource(null, "+{0} h")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Waktu",
                null,
                "this hour",
                null,
                new RelativeTimeCountResource(null, "-{0} h"),
                new RelativeTimeCountResource(null, "+{0} h")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Hoƴom",
                null,
                "this minute",
                null,
                new RelativeTimeCountResource(null, "-{0} min"),
                new RelativeTimeCountResource(null, "+{0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Hoƴom",
                null,
                "this minute",
                null,
                new RelativeTimeCountResource(null, "-{0} min"),
                new RelativeTimeCountResource(null, "+{0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Hoƴom",
                null,
                "this minute",
                null,
                new RelativeTimeCountResource(null, "-{0} min"),
                new RelativeTimeCountResource(null, "+{0} min")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Majaango",
                null,
                "now",
                null,
                new RelativeTimeCountResource(null, "-{0} s"),
                new RelativeTimeCountResource(null, "+{0} s")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Majaango",
                null,
                "now",
                null,
                new RelativeTimeCountResource(null, "-{0} s"),
                new RelativeTimeCountResource(null, "+{0} s")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Majaango",
                null,
                "now",
                null,
                new RelativeTimeCountResource(null, "-{0} s"),
                new RelativeTimeCountResource(null, "+{0} s")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Diiwaan waktu",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Diiwaan waktu",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Diiwaan waktu",
                null,
                null,
                null,
                null,
                null));
    }
}