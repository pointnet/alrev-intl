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
    public class KazakhRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "kk";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "дәуір",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "дәуір",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "дәуір",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "жыл",
                new Dictionary<int, string> { { -1, "былтырғы жыл" }, { 0, "биылғы жыл" }, { 1, "келесі жыл" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жыл бұрын" }, { PluralRulesValues.Other, "{0} жыл бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жылдан кейін" }, { PluralRulesValues.Other, "{0} жылдан кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ж.",
                new Dictionary<int, string> { { -1, "былтырғы жыл" }, { 0, "биылғы жыл" }, { 1, "келесі жыл" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ж. бұрын" }, { PluralRulesValues.Other, "{0} ж. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ж. кейін" }, { PluralRulesValues.Other, "{0} ж. кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ж.",
                new Dictionary<int, string> { { -1, "былтырғы жыл" }, { 0, "биылғы жыл" }, { 1, "келесі жыл" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ж. бұрын" }, { PluralRulesValues.Other, "{0} ж. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ж. кейін" }, { PluralRulesValues.Other, "{0} ж. кейін" } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ширек",
                new Dictionary<int, string> { { -1, "өткен тоқсан" }, { 0, "осы тоқсан" }, { 1, "келесі тоқсан" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} тоқсан бұрын" }, { PluralRulesValues.Other, "{0} тоқсан бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} тоқсаннан кейін" }, { PluralRulesValues.Other, "{0} тоқсаннан кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ш.",
                new Dictionary<int, string> { { -1, "өткен тоқсан" }, { 0, "осы тоқсан" }, { 1, "келесі тоқсан" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} тқс. бұрын" }, { PluralRulesValues.Other, "{0} тқс. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} тқс. кейін" }, { PluralRulesValues.Other, "{0} тқс. кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ш.",
                new Dictionary<int, string> { { -1, "өткен тоқсан" }, { 0, "осы тоқсан" }, { 1, "келесі тоқсан" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} тқс. бұрын" }, { PluralRulesValues.Other, "{0} тқс. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} тқс. кейін" }, { PluralRulesValues.Other, "{0} тқс. кейін" } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ай",
                new Dictionary<int, string> { { -1, "өткен ай" }, { 0, "осы ай" }, { 1, "келесі ай" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ай бұрын" }, { PluralRulesValues.Other, "{0} ай бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} айдан кейін" }, { PluralRulesValues.Other, "{0} айдан кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ай",
                new Dictionary<int, string> { { -1, "өткен ай" }, { 0, "осы ай" }, { 1, "келесі ай" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ай бұрын" }, { PluralRulesValues.Other, "{0} ай бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} айдан кейін" }, { PluralRulesValues.Other, "{0} айдан кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ай",
                new Dictionary<int, string> { { -1, "өткен ай" }, { 0, "осы ай" }, { 1, "келесі ай" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ай бұрын" }, { PluralRulesValues.Other, "{0} ай бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} айдан кейін" }, { PluralRulesValues.Other, "{0} айдан кейін" } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "апта",
                new Dictionary<int, string> { { -1, "өткен апта" }, { 0, "осы апта" }, { 1, "келесі апта" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} апта бұрын" }, { PluralRulesValues.Other, "{0} апта бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} аптадан кейін" }, { PluralRulesValues.Other, "{0} аптадан кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ап.",
                new Dictionary<int, string> { { -1, "өткен апта" }, { 0, "осы апта" }, { 1, "келесі апта" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ап. бұрын" }, { PluralRulesValues.Other, "{0} ап. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ап. кейін" }, { PluralRulesValues.Other, "{0} ап. кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ап.",
                new Dictionary<int, string> { { -1, "өткен апта" }, { 0, "осы апта" }, { 1, "келесі апта" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ап. бұрын" }, { PluralRulesValues.Other, "{0} ап. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ап. кейін" }, { PluralRulesValues.Other, "{0} ап. кейін" } }));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "айдағы апта",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "айдағы апта",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "айдағы апта",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "күн",
                new Dictionary<int, string> { { -2, "алдыңгүні" }, { -1, "кеше" }, { 0, "бүгін" }, { 1, "ертең" }, { 2, "бүрсігүні" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} күн бұрын" }, { PluralRulesValues.Other, "{0} күн бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} күннен кейін" }, { PluralRulesValues.Other, "{0} күннен кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "күн",
                new Dictionary<int, string> { { -2, "алдыңғы күні" }, { -1, "кеше" }, { 0, "бүгін" }, { 1, "ертең" }, { 2, "бүрсігүні" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} күн бұрын" }, { PluralRulesValues.Other, "{0} күн бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} күннен кейін" }, { PluralRulesValues.Other, "{0} күннен кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "күн",
                new Dictionary<int, string> { { -2, "алдыңғы күні" }, { -1, "кеше" }, { 0, "бүгін" }, { 1, "ертең" }, { 2, "бүрсігүні" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} күн бұрын" }, { PluralRulesValues.Other, "{0} күн бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} күннен кейін" }, { PluralRulesValues.Other, "{0} күннен кейін" } }));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "жылдағы күн",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "жылдағы күн",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "жылдағы күн",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "апта күні",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "апта күні",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "апта күні",
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "айдағы апта күні",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "айдағы ап. күні",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "айдағы ап. күні",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "өткен жексенбі" }, { 0, "осы жексенбі" }, { 1, "келесі жексенбі" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жексенбі бұрын" }, { PluralRulesValues.Other, "{0} жексенбі бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жексенбіден кейін" }, { PluralRulesValues.Other, "{0} жексенбіден кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "өткен жс" }, { 0, "осы жс" }, { 1, "келесі жс" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жс бұрын" }, { PluralRulesValues.Other, "{0} жс бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жс кейін" }, { PluralRulesValues.Other, "{0} жс кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "өткен жек." }, { 0, "осы жек." }, { 1, "келесі жек." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жек. бұрын" }, { PluralRulesValues.Other, "{0} жек. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жек. кейін" }, { PluralRulesValues.Other, "{0} жек. кейін" } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "өткен дүйсенбі" }, { 0, "осы дүйсенбі" }, { 1, "келесі дүйсенбі" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дүйсенбі бұрын" }, { PluralRulesValues.Other, "{0} дүйсенбі бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дүйсенбіден кейін" }, { PluralRulesValues.Other, "{0} дүйсенбіден кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "өткен дс" }, { 0, "осы дс" }, { 1, "келесі дс" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дс бұрын" }, { PluralRulesValues.Other, "{0} дс бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дс кейін" }, { PluralRulesValues.Other, "{0} дс кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "өткен дүй." }, { 0, "осы дүй." }, { 1, "келесі дүй." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дүй. бұрын" }, { PluralRulesValues.Other, "{0} дүй. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дүй. кейін" }, { PluralRulesValues.Other, "{0} дүй. кейін" } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "өткен сейсенбі" }, { 0, "осы сейсенбі" }, { 1, "келесі сейсенбі" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сейсенбі бұрын" }, { PluralRulesValues.Other, "{0} сейсенбі бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сейсенбіден кейін" }, { PluralRulesValues.Other, "{0} сейсенбіден кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "өткен сс" }, { 0, "осы сс" }, { 1, "келесі сс" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сс бұрын" }, { PluralRulesValues.Other, "{0} сс бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сс кейін" }, { PluralRulesValues.Other, "{0} сс кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "өткен сей." }, { 0, "осы сей." }, { 1, "келесі сей." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сей. бұрын" }, { PluralRulesValues.Other, "{0} сей. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сей. кейін" }, { PluralRulesValues.Other, "{0} сей. кейін" } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "өткен сәрсенбі" }, { 0, "осы сәрсенбі" }, { 1, "келесі сәрсенбі" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сәрсенбі бұрын" }, { PluralRulesValues.Other, "{0} сәрсенбі бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сәрсенбіден кейін" }, { PluralRulesValues.Other, "{0} сәрсенбіден кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "өткен ср" }, { 0, "осы ср" }, { 1, "келесі ср" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ср бұрын" }, { PluralRulesValues.Other, "{0} ср бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ср кейін" }, { PluralRulesValues.Other, "{0} ср кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "өткен сәр." }, { 0, "осы сәр." }, { 1, "келесі сәр." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сәр. бұрын" }, { PluralRulesValues.Other, "{0} сәр. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сәр. кейін" }, { PluralRulesValues.Other, "{0} сәр. кейін" } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "өткен бейсенбі" }, { 0, "осы бейсенбі" }, { 1, "келесі бейсенбі" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} бейсенбі бұрын" }, { PluralRulesValues.Other, "{0} бейсенбі бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} бейсенбіден кейін" }, { PluralRulesValues.Other, "{0} бейсенбіден кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "өткен бс" }, { 0, "осы бс" }, { 1, "келесі бс" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} бс бұрын" }, { PluralRulesValues.Other, "{0} бс бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} бс кейін" }, { PluralRulesValues.Other, "{0} бс кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "өткен бей." }, { 0, "осы бей." }, { 1, "келесі бей." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} бей. бұрын" }, { PluralRulesValues.Other, "{0} бей. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} бей. кейін" }, { PluralRulesValues.Other, "{0} бей. кейін" } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "өткен жұма" }, { 0, "осы жұма" }, { 1, "келесі жұма" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жұма бұрын" }, { PluralRulesValues.Other, "{0} жұма бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жұмадан кейін" }, { PluralRulesValues.Other, "{0} жұмадан кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "өткен жм" }, { 0, "осы жм" }, { 1, "келесі жм" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жм бұрын" }, { PluralRulesValues.Other, "{0} жм бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жм кейін" }, { PluralRulesValues.Other, "{0} жм кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "өткен жұм." }, { 0, "осы жұм." }, { 1, "келесі жұм." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жұм. бұрын" }, { PluralRulesValues.Other, "{0} жұм. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жұм. кейін" }, { PluralRulesValues.Other, "{0} жұм. кейін" } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "өткен сенбі" }, { 0, "осы сенбі" }, { 1, "келесі сенбі" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сенбі бұрын" }, { PluralRulesValues.Other, "{0} сенбі бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сенбіден кейін" }, { PluralRulesValues.Other, "{0} сенбіден кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "өткен сб" }, { 0, "осы сб" }, { 1, "келесі сб" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сб бұрын" }, { PluralRulesValues.Other, "{0} сб бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сб кейін" }, { PluralRulesValues.Other, "{0} сб кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "өткен сен." }, { 0, "осы сен." }, { 1, "келесі сен." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сен. бұрын" }, { PluralRulesValues.Other, "{0} сен. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сен. кейін" }, { PluralRulesValues.Other, "{0} сен. кейін" } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "АМ/РМ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "АМ/РМ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "АМ/РМ",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "сағат",
                new Dictionary<int, string> { { 0, "осы сағат" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сағат бұрын" }, { PluralRulesValues.Other, "{0} сағат бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сағаттан кейін" }, { PluralRulesValues.Other, "{0} сағаттан кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "сағ",
                new Dictionary<int, string> { { 0, "осы сағат" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сағ. бұрын" }, { PluralRulesValues.Other, "{0} сағ. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сағ. кейін" }, { PluralRulesValues.Other, "{0} сағ. кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "сағ",
                new Dictionary<int, string> { { 0, "осы сағат" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сағ. бұрын" }, { PluralRulesValues.Other, "{0} сағ. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сағ. кейін" }, { PluralRulesValues.Other, "{0} сағ. кейін" } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "минут",
                new Dictionary<int, string> { { 0, "осы минут" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} минут бұрын" }, { PluralRulesValues.Other, "{0} минут бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} минуттан кейін" }, { PluralRulesValues.Other, "{0} минуттан кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "мин",
                new Dictionary<int, string> { { 0, "осы минут" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мин. бұрын" }, { PluralRulesValues.Other, "{0} мин. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мин. кейін" }, { PluralRulesValues.Other, "{0} мин. кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "мин",
                new Dictionary<int, string> { { 0, "осы минут" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мин. бұрын" }, { PluralRulesValues.Other, "{0} мин. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мин. кейін" }, { PluralRulesValues.Other, "{0} мин. кейін" } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "секунд",
                new Dictionary<int, string> { { 0, "қазір" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} секунд бұрын" }, { PluralRulesValues.Other, "{0} секунд бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} секундтан кейін" }, { PluralRulesValues.Other, "{0} секундтан кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "с",
                new Dictionary<int, string> { { 0, "қазір" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сек. бұрын" }, { PluralRulesValues.Other, "{0} сек. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сек. кейін" }, { PluralRulesValues.Other, "{0} сек. кейін" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "с",
                new Dictionary<int, string> { { 0, "қазір" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сек. бұрын" }, { PluralRulesValues.Other, "{0} сек. бұрын" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сек. кейін" }, { PluralRulesValues.Other, "{0} сек. кейін" } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "уақыт белдеуі",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "уақ. белдеуі",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "уақ. белдеуі",
                null,
                null,
                null));
    }
}