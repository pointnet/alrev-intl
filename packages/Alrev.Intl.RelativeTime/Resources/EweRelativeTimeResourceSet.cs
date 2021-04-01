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
    public class EweRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ee";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ŋɔli",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ŋɔli",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ŋɔli",
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
                "ƒe",
                "ƒe si va yi",
                "ƒe sia",
                "ƒe si gbɔ na",
                new RelativeTimeCountResource("ƒe {0} si va yi", "ƒe {0} si wo va yi"),
                new RelativeTimeCountResource("le ƒe {0} me", "le ƒe {0} me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ƒe",
                "ƒe si va yi",
                "ƒe sia",
                "ƒe si gbɔ na",
                new RelativeTimeCountResource("ƒe {0} si va yi me", "ƒe {0} si va yi me"),
                new RelativeTimeCountResource("le ƒe {0} si gbɔna me", "le ƒe {0} si gbɔna me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ƒe",
                "ƒe si va yi",
                "ƒe sia",
                "ƒe si gbɔ na",
                new RelativeTimeCountResource("le ƒe {0} si va yi me", "le ƒe {0} si va yi me"),
                new RelativeTimeCountResource("le ƒe {0} me", "le ƒe {0} me")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "kɔta",
                "last quarter",
                "this quarter",
                "next quarter",
                new RelativeTimeCountResource("kɔta {0} si va yi me", "kɔta {0} si va yi me"),
                new RelativeTimeCountResource("le kɔta {0} si gbɔ na me", "le kɔta {0} si gbɔ na me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "kɔta",
                "last quarter",
                "this quarter",
                "next quarter",
                new RelativeTimeCountResource("kɔta {0} si va yi me", "kɔta {0} si va yi me"),
                new RelativeTimeCountResource("le kɔta {0} si gbɔna me", "le kɔta {0} si gbɔ na me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "kɔta",
                "last quarter",
                "this quarter",
                "next quarter",
                new RelativeTimeCountResource("kɔta {0} si va yi me", "kɔta {0} si va yi me"),
                new RelativeTimeCountResource("le kɔta {0} si gbɔ na me", "le kɔta {0} si gbɔ na me")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ɣleti",
                "ɣleti si va yi",
                "ɣleti sia",
                "ɣleti si gbɔ na",
                new RelativeTimeCountResource("ɣleti {0} si va yi", "ɣleti {0} si wo va yi"),
                new RelativeTimeCountResource("le ɣleti {0} me", "le ɣleti {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ɣleti",
                "ɣleti si va yi",
                "ɣleti sia",
                "ɣleti si gbɔ na",
                new RelativeTimeCountResource("ɣleti {0} si va yi", "ɣleti {0} si wo va yi"),
                new RelativeTimeCountResource("le ɣleti {0} me", "le ɣleti {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ɣleti",
                "ɣleti si va yi",
                "ɣleti sia",
                "ɣleti si gbɔ na",
                new RelativeTimeCountResource("ɣleti {0} si va yi", "ɣleti {0} si wo va yi"),
                new RelativeTimeCountResource("le ɣleti {0} me", "le ɣleti {0} wo me")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "kɔsiɖa ɖeka",
                "kɔsiɖa si va yi",
                "kɔsiɖa sia",
                "kɔsiɖa si gbɔ na",
                new RelativeTimeCountResource("kɔsiɖa {0} si va yi", "kɔsiɖa {0} si wo va yi"),
                new RelativeTimeCountResource("le kɔsiɖa {0} me", "le kɔsiɖa {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "kɔsiɖa ɖeka",
                "kɔsiɖa si va yi",
                "kɔsiɖa sia",
                "kɔsiɖa si gbɔ na",
                new RelativeTimeCountResource("kɔsiɖa {0} si va yi", "kɔsiɖa {0} si wo va yi"),
                new RelativeTimeCountResource("le kɔsiɖa {0} me", "le kɔsiɖa {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "kɔsiɖa ɖeka",
                "kɔsiɖa si va yi",
                "kɔsiɖa sia",
                "kɔsiɖa si gbɔ na",
                new RelativeTimeCountResource("kɔsiɖa {0} si va yi", "kɔsiɖa {0} si wo va yi"),
                new RelativeTimeCountResource("le kɔsiɖa {0} me", "le kɔsiɖa {0} wo me")));

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
                "ŋkeke",
                "etsɔ si va yi",
                "egbe",
                "etsɔ si gbɔna",
                new RelativeTimeCountResource("ŋkeke {0} si va yi", "ŋkeke {0} si wo va yi"),
                new RelativeTimeCountResource("le ŋkeke {0} me", "le ŋkeke {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ŋkeke",
                "etsɔ si va yi",
                "egbe",
                "etsɔ si gbɔna",
                new RelativeTimeCountResource("ŋkeke {0} si va yi", "ŋkeke {0} si wo va yi"),
                new RelativeTimeCountResource("le ŋkeke {0} me", "le ŋkeke {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ŋkeke",
                "etsɔ si va yi",
                "egbe",
                "etsɔ si gbɔna",
                new RelativeTimeCountResource("ŋkeke {0} si va yi", "ŋkeke {0} si wo va yi"),
                new RelativeTimeCountResource("le ŋkeke {0} me", "le ŋkeke {0} wo me")));

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
                "kɔsiɖa me ŋkeke",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "kɔsiɖa me ŋkeke",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "kɔsiɖa me ŋkeke",
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
                "kɔsiɖagbe si va yi",
                "kɔsiɖa sia gbe",
                "kɔsiɖagbe si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Sundays"),
                new RelativeTimeCountResource(null, "+{0} Sundays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "kɔsiɖagbe si va yi",
                "kɔsiɖa sia gbe",
                "kɔsiɖagbe si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Sundays"),
                new RelativeTimeCountResource(null, "+{0} Sundays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "kɔsiɖagbe si va yi",
                "kɔsiɖa sia gbe",
                "kɔsiɖagbe si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Sundays"),
                new RelativeTimeCountResource(null, "+{0} Sundays")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "dzoɖa si va yi",
                "dzoɖa sia",
                "dzoɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Mondays"),
                new RelativeTimeCountResource(null, "+{0} Mondays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "dzoɖa si va yi",
                "dzoɖa sia",
                "dzoɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Mondays"),
                new RelativeTimeCountResource(null, "+{0} Mondays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "dzoɖa si va yi",
                "dzoɖa sia",
                "dzoɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Mondays"),
                new RelativeTimeCountResource(null, "+{0} Mondays")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "blaɖa si va yi",
                "blaɖa sia",
                "blaɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Tuesdays"),
                new RelativeTimeCountResource(null, "+{0} Tuesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "blaɖa si va yi",
                "blaɖa sia",
                "blaɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Tuesdays"),
                new RelativeTimeCountResource(null, "+{0} Tuesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "blaɖa si va yi",
                "blaɖa sia",
                "blaɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Tuesdays"),
                new RelativeTimeCountResource(null, "+{0} Tuesdays")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "kuɖa si va yi",
                "kuɖa sia",
                "kuɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Wednesdays"),
                new RelativeTimeCountResource(null, "+{0} Wednesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "kuɖa si va yi",
                "kuɖa sia",
                "kuɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Wednesdays"),
                new RelativeTimeCountResource(null, "+{0} Wednesdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "kuɖa si va yi",
                "kuɖa sia",
                "kuɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Wednesdays"),
                new RelativeTimeCountResource(null, "+{0} Wednesdays")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "yawoɖa si va yi",
                "yawoɖa sia",
                "yawoɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Thursdays"),
                new RelativeTimeCountResource(null, "+{0} Thursdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "yawoɖa si va yi",
                "yawoɖa sia",
                "yawoɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Thursdays"),
                new RelativeTimeCountResource(null, "+{0} Thursdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "yawoɖa si va yi",
                "yawoɖa sia",
                "yawoɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Thursdays"),
                new RelativeTimeCountResource(null, "+{0} Thursdays")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "fiɖa si va yi",
                "fiɖa sia",
                "fiɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Fridays"),
                new RelativeTimeCountResource(null, "+{0} Fridays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "fiɖa si va yi",
                "fiɖa sia",
                "fiɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Fridays"),
                new RelativeTimeCountResource(null, "+{0} Fridays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "fiɖa si va yi",
                "fiɖa sia",
                "fiɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Fridays"),
                new RelativeTimeCountResource(null, "+{0} Fridays")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "memleɖa si va yi",
                "memleɖa sia",
                "memleɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Saturdays"),
                new RelativeTimeCountResource(null, "+{0} Saturdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "memleɖa si va yi",
                "memleɖa sia",
                "memleɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Saturdays"),
                new RelativeTimeCountResource(null, "+{0} Saturdays")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "memleɖa si va yi",
                "memleɖa sia",
                "memleɖa si gbɔ na",
                new RelativeTimeCountResource(null, "-{0} Saturdays"),
                new RelativeTimeCountResource(null, "+{0} Saturdays")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ŋkekea me",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ŋkekea me",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ŋkekea me",
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
                "gaƒoƒo",
                null,
                "this hour",
                null,
                new RelativeTimeCountResource("gaƒoƒo {0} si va yi", "gaƒoƒo {0} si wo va yi"),
                new RelativeTimeCountResource("le gaƒoƒo {0} me", "le gaƒoƒo {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "gaƒoƒo",
                null,
                "this hour",
                null,
                new RelativeTimeCountResource("gaƒoƒo {0} si va yi", "gaƒoƒo {0} si wo va yi"),
                new RelativeTimeCountResource("le gaƒoƒo {0} me", "le gaƒoƒo {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "gaƒoƒo",
                null,
                "this hour",
                null,
                new RelativeTimeCountResource("gaƒoƒo {0} si va yi", "gaƒoƒo {0} si wo va yi"),
                new RelativeTimeCountResource("le gaƒoƒo {0} me", "le gaƒoƒo {0} wo me")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "aɖabaƒoƒo",
                null,
                "this minute",
                null,
                new RelativeTimeCountResource("aɖabaƒoƒo {0} si va yi", "aɖabaƒoƒo {0} si wo va yi"),
                new RelativeTimeCountResource("le aɖabaƒoƒo {0} me", "le aɖabaƒoƒo {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "aɖabaƒoƒo",
                null,
                "this minute",
                null,
                new RelativeTimeCountResource("aɖabaƒoƒo {0} si va yi", "aɖabaƒoƒo {0} si wo va yi"),
                new RelativeTimeCountResource("le aɖabaƒoƒo {0} me", "le aɖabaƒoƒo {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "aɖabaƒoƒo",
                null,
                "this minute",
                null,
                new RelativeTimeCountResource("aɖabaƒoƒo {0} si va yi", "aɖabaƒoƒo {0} si wo va yi"),
                new RelativeTimeCountResource("le aɖabaƒoƒo {0} me", "le aɖabaƒoƒo {0} wo me")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "sekend",
                null,
                "fifi",
                null,
                new RelativeTimeCountResource("sekend {0} si va yi", "sekend {0} si wo va yi"),
                new RelativeTimeCountResource("le sekend {0} me", "le sekend {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sekend",
                null,
                "fifi",
                null,
                new RelativeTimeCountResource("sekend {0} si va yi", "sekend {0} si wo va yi"),
                new RelativeTimeCountResource("le sekend {0} me", "le sekend {0} wo me")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sekend",
                null,
                "fifi",
                null,
                new RelativeTimeCountResource("sekend {0} si va yi", "sekend {0} si wo va yi"),
                new RelativeTimeCountResource("le sekend {0} me", "le sekend {0} wo me")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "nutomegaƒoƒo",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "nutomegaƒoƒo",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "nutomegaƒoƒo",
                null,
                null,
                null,
                null,
                null));
    }
}