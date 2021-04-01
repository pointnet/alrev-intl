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
    public class MacedonianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "mk";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ера",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ера",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ера",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "година",
                new Dictionary<int, string> { { -1, "минатата година" }, { 0, "оваа година" }, { 1, "следната година" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} година" }, { PluralRulesValues.Other, "пред {0} години" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} година" }, { PluralRulesValues.Other, "за {0} години" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "год.",
                new Dictionary<int, string> { { -1, "минатата год." }, { 0, "оваа год." }, { 1, "следната год." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} год." }, { PluralRulesValues.Other, "пред {0} год." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} год." }, { PluralRulesValues.Other, "за {0} год." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "год.",
                new Dictionary<int, string> { { -1, "минатата год." }, { 0, "оваа год." }, { 1, "следната год." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} год." }, { PluralRulesValues.Other, "пред {0} год." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} год." }, { PluralRulesValues.Other, "за {0} год." } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "тромесечје",
                new Dictionary<int, string> { { -1, "последното тромесечје" }, { 0, "ова тромесечје" }, { 1, "следното тромесечје" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} тромесечје" }, { PluralRulesValues.Other, "пред {0} тромесечја" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} тромесечје" }, { PluralRulesValues.Other, "за {0} тромесечја" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "тромес.",
                new Dictionary<int, string> { { -1, "последното тромесечје" }, { 0, "ова тромесечје" }, { 1, "следното тромесечје" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} тромес." }, { PluralRulesValues.Other, "пред {0} тромес." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} тромес." }, { PluralRulesValues.Other, "за {0} тромес." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "тромес.",
                new Dictionary<int, string> { { -1, "последното тромесечје" }, { 0, "ова тромесечје" }, { 1, "следното тромесечје" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} тромес." }, { PluralRulesValues.Other, "пред {0} тромес." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} тромес." }, { PluralRulesValues.Other, "за {0} тромес." } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "месец",
                new Dictionary<int, string> { { -1, "минатиот месец" }, { 0, "овој месец" }, { 1, "следниот месец" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} месец" }, { PluralRulesValues.Other, "пред {0} месеци" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} месец" }, { PluralRulesValues.Other, "за {0} месеци" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "мес.",
                new Dictionary<int, string> { { -1, "минатиот месец" }, { 0, "овој месец" }, { 1, "следниот месец" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} месец" }, { PluralRulesValues.Other, "пред {0} месеци" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} месец" }, { PluralRulesValues.Other, "за {0} месеци" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "мес.",
                new Dictionary<int, string> { { -1, "минатиот месец" }, { 0, "овој месец" }, { 1, "следниот месец" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} месец" }, { PluralRulesValues.Other, "пред {0} месеци" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} месец" }, { PluralRulesValues.Other, "за {0} месеци" } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "седмица",
                new Dictionary<int, string> { { -1, "минатата седмица" }, { 0, "оваа седмица" }, { 1, "следната седмица" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} седмица" }, { PluralRulesValues.Other, "пред {0} седмици" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} седмица" }, { PluralRulesValues.Other, "за {0} седмици" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "сед.",
                new Dictionary<int, string> { { -1, "минатата седмица" }, { 0, "оваа седмица" }, { 1, "следната седмица" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} седмица" }, { PluralRulesValues.Other, "пред {0} седмици" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} седмица" }, { PluralRulesValues.Other, "за {0} седмици" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "сед.",
                new Dictionary<int, string> { { -1, "минатата седмица" }, { 0, "оваа седмица" }, { 1, "следната седмица" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} седмица" }, { PluralRulesValues.Other, "пред {0} седмици" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} седмица" }, { PluralRulesValues.Other, "за {0} седмици" } }));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "седмица од месецот",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "седмица од месецот",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "седмица од месецот",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ден",
                new Dictionary<int, string> { { -2, "завчера" }, { -1, "вчера" }, { 0, "денес" }, { 1, "утре" }, { 2, "задутре" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} ден" }, { PluralRulesValues.Other, "пред {0} дена" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} ден" }, { PluralRulesValues.Other, "за {0} дена" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ден",
                new Dictionary<int, string> { { -2, "завчера" }, { -1, "вчера" }, { 0, "денес" }, { 1, "утре" }, { 2, "задутре" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} ден" }, { PluralRulesValues.Other, "пред {0} дена" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} ден" }, { PluralRulesValues.Other, "за {0} дена" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ден",
                new Dictionary<int, string> { { -2, "завчера" }, { -1, "вчера" }, { 0, "денес" }, { 1, "утре" }, { 2, "задутре" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} ден" }, { PluralRulesValues.Other, "пред {0} дена" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} ден" }, { PluralRulesValues.Other, "за {0} дена" } }));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ден од годината",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ден од год.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ден од год.",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ден од неделата",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ден во неделата",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ден во неделата",
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ден од месецот",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ден од мес.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ден од мес.",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "минатата недела" }, { 0, "оваа недела" }, { 1, "следната недела" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} недела" }, { PluralRulesValues.Other, "пред {0} недели" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} недела" }, { PluralRulesValues.Other, "за {0} недели" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "минатата нед." }, { 0, "оваа нед." }, { 1, "следната нед." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} нед." }, { PluralRulesValues.Other, "пред {0} нед." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} нед." }, { PluralRulesValues.Other, "за {0} нед." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "минатата нед." }, { 0, "оваа нед." }, { 1, "следната нед." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} нед." }, { PluralRulesValues.Other, "пред {0} нед." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} нед." }, { PluralRulesValues.Other, "за {0} нед." } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "минатиот понеделник" }, { 0, "овој понеделник" }, { 1, "следниот понеделник" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} понеделник" }, { PluralRulesValues.Other, "пред {0} понеделници" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} понеделник" }, { PluralRulesValues.Other, "за {0} понеделници" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "минатиот пон." }, { 0, "овој пон." }, { 1, "следниот пон." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} пон." }, { PluralRulesValues.Other, "пред {0} пон." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} пон." }, { PluralRulesValues.Other, "за {0} пон." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "минатиот пон." }, { 0, "овој пон." }, { 1, "следниот пон." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} пон." }, { PluralRulesValues.Other, "пред {0} пон." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} пон." }, { PluralRulesValues.Other, "за {0} пон." } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "минатиот вторник" }, { 0, "овој вторник" }, { 1, "следниот вторник" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} вторник" }, { PluralRulesValues.Other, "пред {0} вторници" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} вторник" }, { PluralRulesValues.Other, "за {0} вторници" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "минатиот вто." }, { 0, "овој вто." }, { 1, "следниот вто." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} вто." }, { PluralRulesValues.Other, "пред {0} вто." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} вто." }, { PluralRulesValues.Other, "за {0} вто." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "минатиот вто." }, { 0, "овој вто." }, { 1, "следниот вто." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} вто." }, { PluralRulesValues.Other, "пред {0} вто." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} вто." }, { PluralRulesValues.Other, "за {0} вто." } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "минатата среда" }, { 0, "оваа среда" }, { 1, "следната среда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} среда" }, { PluralRulesValues.Other, "пред {0} среди" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} среда" }, { PluralRulesValues.Other, "за {0} среди" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "минатата сре." }, { 0, "оваа сре." }, { 1, "следната сре." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} сре." }, { PluralRulesValues.Other, "пред {0} сре." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} сре." }, { PluralRulesValues.Other, "за {0} сре." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "минатата сре." }, { 0, "оваа сре." }, { 1, "следната сре." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} сре." }, { PluralRulesValues.Other, "пред {0} сре." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} сре." }, { PluralRulesValues.Other, "за {0} сре." } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "минатиот четврток" }, { 0, "овој четврток" }, { 1, "следниот четврток" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} четврток" }, { PluralRulesValues.Other, "пред {0} четвртоци" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} четврток" }, { PluralRulesValues.Other, "за {0} четвртоци" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "минатиот чет." }, { 0, "овој чет." }, { 1, "следниот чет." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} чет." }, { PluralRulesValues.Other, "пред {0} чет." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} чет." }, { PluralRulesValues.Other, "за {0} чет." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "минатиот чет." }, { 0, "овој чет." }, { 1, "следниот чет." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} чет." }, { PluralRulesValues.Other, "пред {0} чет." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} чет." }, { PluralRulesValues.Other, "за {0} чет." } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "минатиот петок" }, { 0, "овој петок" }, { 1, "следниот петок" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} петок" }, { PluralRulesValues.Other, "пред {0} петоци" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} петок" }, { PluralRulesValues.Other, "за {0} петоци" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "минатиот пет." }, { 0, "овој пет." }, { 1, "следниот пет." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} пет." }, { PluralRulesValues.Other, "пред {0} пет." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} пет." }, { PluralRulesValues.Other, "за {0} пет." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "минатиот пет." }, { 0, "овој пет." }, { 1, "следниот пет." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} пет." }, { PluralRulesValues.Other, "пред {0} пет." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} пет." }, { PluralRulesValues.Other, "за {0} пет." } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "минатата сабота" }, { 0, "оваа сабота" }, { 1, "следната сабота" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} сабота" }, { PluralRulesValues.Other, "пред {0} саботи" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} сабота" }, { PluralRulesValues.Other, "за {0} саботи" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "минатата саб." }, { 0, "оваа саб." }, { 1, "следната саб." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} саб." }, { PluralRulesValues.Other, "пред {0} саб." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} саб." }, { PluralRulesValues.Other, "за {0} саб." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "минатата саб." }, { 0, "оваа саб." }, { 1, "следната саб." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} саб." }, { PluralRulesValues.Other, "пред {0} саб." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} саб." }, { PluralRulesValues.Other, "за {0} саб." } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "претпладне/попладне",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "претпладне/попладне",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "претпладне/попладне",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "час",
                new Dictionary<int, string> { { 0, "часов" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} час" }, { PluralRulesValues.Other, "пред {0} часа" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} час" }, { PluralRulesValues.Other, "за {0} часа" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ч.",
                new Dictionary<int, string> { { 0, "часов" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} час" }, { PluralRulesValues.Other, "пред {0} часа" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} час" }, { PluralRulesValues.Other, "за {0} часа" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ч.",
                new Dictionary<int, string> { { 0, "часов" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} час" }, { PluralRulesValues.Other, "пред {0} часа" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} час" }, { PluralRulesValues.Other, "за {0} часа" } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "минута",
                new Dictionary<int, string> { { 0, "оваа минута" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} минута" }, { PluralRulesValues.Other, "пред {0} минути" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} минута" }, { PluralRulesValues.Other, "за {0} минути" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "мин.",
                new Dictionary<int, string> { { 0, "оваа минута" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} мин." }, { PluralRulesValues.Other, "пред {0} мин." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} мин." }, { PluralRulesValues.Other, "за {0} мин." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "мин.",
                new Dictionary<int, string> { { 0, "оваа минута" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} мин." }, { PluralRulesValues.Other, "пред {0} мин." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} мин." }, { PluralRulesValues.Other, "за {0} мин." } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "секунда",
                new Dictionary<int, string> { { 0, "сега" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} секунда" }, { PluralRulesValues.Other, "пред {0} секунди" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} секунда" }, { PluralRulesValues.Other, "за {0} секунди" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "сек.",
                new Dictionary<int, string> { { 0, "сега" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} сек." }, { PluralRulesValues.Other, "пред {0} сек." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} сек." }, { PluralRulesValues.Other, "за {0} сек." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "сек.",
                new Dictionary<int, string> { { 0, "сега" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пред {0} сек." }, { PluralRulesValues.Other, "пред {0} сек." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "за {0} сек." }, { PluralRulesValues.Other, "за {0} сек." } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "временска зона",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "зона",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "зона",
                null,
                null,
                null));
    }
}