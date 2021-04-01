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
    public class NorwegianBokmalRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "nb";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "tidsalder",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "tidsalder",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "tidsalder",
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
                "år",
                "i fjor",
                "i år",
                "neste år",
                new RelativeTimeCountResource("for {0} år siden", "for {0} år siden"),
                new RelativeTimeCountResource("om {0} år", "om {0} år")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "år",
                "i fjor",
                "i år",
                "neste år",
                new RelativeTimeCountResource("–{0} år", "–{0} år"),
                new RelativeTimeCountResource("+{0} år", "+{0} år")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "år",
                "i fjor",
                "i år",
                "neste år",
                new RelativeTimeCountResource("for {0} år siden", "for {0} år siden"),
                new RelativeTimeCountResource("om {0} år", "om {0} år")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "kvartal",
                "forrige kvartal",
                "dette kvartalet",
                "neste kvartal",
                new RelativeTimeCountResource("for {0} kvartal siden", "for {0} kvartaler siden"),
                new RelativeTimeCountResource("om {0} kvartal", "om {0} kvartaler")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "kv.",
                "forrige kv.",
                "dette kv.",
                "neste kv.",
                new RelativeTimeCountResource("–{0} kv.", "–{0} kv."),
                new RelativeTimeCountResource("+{0} kv.", "+{0} kv.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "kv.",
                "forrige kv.",
                "dette kv.",
                "neste kv.",
                new RelativeTimeCountResource("for {0} kv. siden", "for {0} kv. siden"),
                new RelativeTimeCountResource("om {0} kv.", "om {0} kv.")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "måned",
                "forrige måned",
                "denne måneden",
                "neste måned",
                new RelativeTimeCountResource("for {0} måned siden", "for {0} måneder siden"),
                new RelativeTimeCountResource("om {0} måned", "om {0} måneder")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "md.",
                "forrige md.",
                "denne md.",
                "neste md.",
                new RelativeTimeCountResource("-{0} md.", "-{0} md."),
                new RelativeTimeCountResource("+{0} md.", "+{0} md.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "mnd.",
                "forrige md.",
                "denne md.",
                "neste md.",
                new RelativeTimeCountResource("for {0} md. siden", "for {0} md. siden"),
                new RelativeTimeCountResource("om {0} md.", "om {0} md.")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "uke",
                "forrige uke",
                "denne uken",
                "neste uke",
                new RelativeTimeCountResource("for {0} uke siden", "for {0} uker siden"),
                new RelativeTimeCountResource("om {0} uke", "om {0} uker")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "u.",
                "forrige uke",
                "denne uken",
                "neste uke",
                new RelativeTimeCountResource("-{0} u.", "-{0} u."),
                new RelativeTimeCountResource("+{0} u.", "+{0} u.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "uke",
                "forrige uke",
                "denne uken",
                "neste uke",
                new RelativeTimeCountResource("for {0} u. siden", "for {0} u. siden"),
                new RelativeTimeCountResource("om {0} u.", "om {0} u.")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "uke i måneden",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "uke i md.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "uke i mnd.",
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
                "dag",
                "i går",
                "i dag",
                "i morgen",
                new RelativeTimeCountResource("for {0} døgn siden", "for {0} døgn siden"),
                new RelativeTimeCountResource("om {0} døgn", "om {0} døgn")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "d.",
                "i går",
                "i dag",
                "i morgen",
                new RelativeTimeCountResource("-{0} d.", "-{0} d."),
                new RelativeTimeCountResource("+{0} d.", "+{0} d.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "dag",
                "i går",
                "i dag",
                "i morgen",
                new RelativeTimeCountResource("for {0} d. siden", "for {0} d. siden"),
                new RelativeTimeCountResource("om {0} d.", "om {0} d.")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "dag i året",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "d. i året",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "dag i året",
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
                "ukedag",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "uked.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ukedag",
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
                "ukedag i måneden",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "uked. i md.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "uked. i mnd.",
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
                "forrige søndag",
                "søndag",
                "neste søndag",
                new RelativeTimeCountResource("for {0} søndag siden", "for {0} søndager siden"),
                new RelativeTimeCountResource("om {0} søndag", "om {0} søndager")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "sist sø.",
                "denne sø.",
                "neste sø.",
                new RelativeTimeCountResource("for {0} sø. siden", "for {0} sø. siden"),
                new RelativeTimeCountResource("om {0} sø.", "om {0} sø.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "sist søn.",
                "denne søn.",
                "neste søn.",
                new RelativeTimeCountResource("for {0} søn. siden", "for {0} søn. siden"),
                new RelativeTimeCountResource("om {0} søn.", "om {0} søn.")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "forrige mandag",
                "mandag",
                "neste mandag",
                new RelativeTimeCountResource("for {0} mandag siden", "for {0} mandager siden"),
                new RelativeTimeCountResource("om {0} mandag", "om {0} mandager")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "sist ma.",
                "denne ma.",
                "neste ma.",
                new RelativeTimeCountResource("for {0} ma. siden", "for {0} ma. siden"),
                new RelativeTimeCountResource("om {0} ma.", "om {0} ma.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "sist man.",
                "denne man.",
                "neste man.",
                new RelativeTimeCountResource("for {0} man. siden", "for {0} man. siden"),
                new RelativeTimeCountResource("om {0} man.", "om {0} man.")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "forrige tirsdag",
                "tirsdag",
                "neste tirsdag",
                new RelativeTimeCountResource("for {0} tirsdag siden", "for {0} tirsdager siden"),
                new RelativeTimeCountResource("om {0} tirsdag", "om {0} tirsdager")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "sist ti.",
                "denne ti.",
                "neste ti.",
                new RelativeTimeCountResource("for {0} ti. siden", "for {0} ti. siden"),
                new RelativeTimeCountResource("om {0} ti.", "om {0} ti.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "sist tir.",
                "denne tir.",
                "neste tir.",
                new RelativeTimeCountResource("for {0} tir. siden", "for {0} tir. siden"),
                new RelativeTimeCountResource("om {0} tir.", "om {0} tir.")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "forrige onsdag",
                "onsdag",
                "neste onsdag",
                new RelativeTimeCountResource("for {0} onsdag siden", "for {0} onsdager siden"),
                new RelativeTimeCountResource("om {0} onsdag", "om {0} onsdager")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "sist on.",
                "denne on.",
                "neste on.",
                new RelativeTimeCountResource("for {0} on. siden", "for {0} on. siden"),
                new RelativeTimeCountResource("om {0} on.", "om {0} on.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "sist ons.",
                "denne ons.",
                "neste ons.",
                new RelativeTimeCountResource("for {0} ons. siden", "for {0} ons. siden"),
                new RelativeTimeCountResource("om {0} ons.", "om {0} ons.")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "forrige torsdag",
                "torsdag",
                "neste torsdag",
                new RelativeTimeCountResource("for {0} torsdag siden", "for {0} torsdager siden"),
                new RelativeTimeCountResource("om {0} torsdag", "om {0} torsdager")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "sist to.",
                "denne to.",
                "neste to.",
                new RelativeTimeCountResource("for {0} to. siden", "for {0} to. siden"),
                new RelativeTimeCountResource("om {0} to.", "om {0} to.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "sist tor.",
                "denne tor.",
                "neste tor.",
                new RelativeTimeCountResource("for {0} tor. siden", "for {0} tor. siden"),
                new RelativeTimeCountResource("om {0} tor.", "om {0} tor.")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "forrige fredag",
                "fredag",
                "neste fredag",
                new RelativeTimeCountResource("for {0} fredag siden", "for {0} fredager siden"),
                new RelativeTimeCountResource("om {0} fredag", "om {0} fredager")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "sist fr.",
                "denne fr.",
                "neste fr.",
                new RelativeTimeCountResource("for {0} fr. siden", "for {0} fr. siden"),
                new RelativeTimeCountResource("om {0} fr.", "om {0} fr.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "sist fre.",
                "denne fre.",
                "neste fre.",
                new RelativeTimeCountResource("for {0} fre. siden", "for {0} fre. siden"),
                new RelativeTimeCountResource("om {0} fre.", "om {0} fre.")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "forrige lørdag",
                "lørdag",
                "neste lørdag",
                new RelativeTimeCountResource("for {0} lørdag siden", "for {0} lørdager siden"),
                new RelativeTimeCountResource("om {0} lørdag", "om {0} lørdager")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "sist lø.",
                "denne lø.",
                "neste lø.",
                new RelativeTimeCountResource("for {0} lø. siden", "for {0} lø. siden"),
                new RelativeTimeCountResource("om {0} lø.", "om {0} lø.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "sist lør.",
                "denne lør.",
                "neste lør.",
                new RelativeTimeCountResource("for {0} lør. siden", "for {0} lør. siden"),
                new RelativeTimeCountResource("om {0} lør.", "om {0} lør.")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "a.m./p.m.",
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
                "time",
                null,
                "denne timen",
                null,
                new RelativeTimeCountResource("for {0} time siden", "for {0} timer siden"),
                new RelativeTimeCountResource("om {0} time", "om {0} timer")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "t",
                null,
                "denne timen",
                null,
                new RelativeTimeCountResource("-{0} t", "-{0} t"),
                new RelativeTimeCountResource("+{0} t", "+{0} t")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "t",
                null,
                "denne timen",
                null,
                new RelativeTimeCountResource("for {0} t siden", "for {0} t siden"),
                new RelativeTimeCountResource("om {0} t", "om {0} t")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minutt",
                null,
                "dette minuttet",
                null,
                new RelativeTimeCountResource("for {0} minutt siden", "for {0} minutter siden"),
                new RelativeTimeCountResource("om {0} minutt", "om {0} minutter")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "m",
                null,
                "dette minuttet",
                null,
                new RelativeTimeCountResource("-{0} min", "-{0} min"),
                new RelativeTimeCountResource("+{0} min", "+{0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                null,
                "dette minuttet",
                null,
                new RelativeTimeCountResource("for {0} min siden", "for {0} min siden"),
                new RelativeTimeCountResource("om {0} min", "om {0} min")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "sekund",
                null,
                "nå",
                null,
                new RelativeTimeCountResource("for {0} sekund siden", "for {0} sekunder siden"),
                new RelativeTimeCountResource("om {0} sekund", "om {0} sekunder")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "s",
                null,
                "nå",
                null,
                new RelativeTimeCountResource("-{0} s", "-{0} s"),
                new RelativeTimeCountResource("+{0} s", "+{0} s")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sek",
                null,
                "nå",
                null,
                new RelativeTimeCountResource("for {0} sek siden", "for {0} sek siden"),
                new RelativeTimeCountResource("om {0} sek", "om {0} sek")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "tidssone",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "tidssone",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "tidssone",
                null,
                null,
                null,
                null,
                null));
    }
}