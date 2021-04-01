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
    public class UpperSorbianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "hsb";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "doba",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "doba",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "doba",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "lěto",
                new Dictionary<int, string> { { -1, "loni" }, { 0, "lětsa" }, { 1, "klětu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} lětom" }, { PluralRulesValues.Two, "před {0} lětomaj" }, { PluralRulesValues.Few, "před {0} lětami" }, { PluralRulesValues.Other, "před {0} lětami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} lěto" }, { PluralRulesValues.Two, "za {0} lěće" }, { PluralRulesValues.Few, "za {0} lěta" }, { PluralRulesValues.Other, "za {0} lět" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "l.",
                new Dictionary<int, string> { { -1, "loni" }, { 0, "lětsa" }, { 1, "klětu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} l." }, { PluralRulesValues.Two, "před {0} l." }, { PluralRulesValues.Few, "před {0} l." }, { PluralRulesValues.Other, "před {0} l." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} l." }, { PluralRulesValues.Two, "za {0} l." }, { PluralRulesValues.Few, "za {0} l." }, { PluralRulesValues.Other, "za {0} l." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "l.",
                new Dictionary<int, string> { { -1, "loni" }, { 0, "lětsa" }, { 1, "klětu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} l." }, { PluralRulesValues.Two, "před {0} l." }, { PluralRulesValues.Few, "před {0} l." }, { PluralRulesValues.Other, "před {0} l." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} l." }, { PluralRulesValues.Two, "za {0} l." }, { PluralRulesValues.Few, "za {0} l." }, { PluralRulesValues.Other, "za {0} l." } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "kwartal",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} kwartalom" }, { PluralRulesValues.Two, "před {0} kwartalomaj" }, { PluralRulesValues.Few, "před {0} kwartalemi" }, { PluralRulesValues.Other, "před {0} kwartalemi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kwartal" }, { PluralRulesValues.Two, "za {0} kwartalej" }, { PluralRulesValues.Few, "za {0} kwartale" }, { PluralRulesValues.Other, "za {0} kwartalow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "kw.",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} kw." }, { PluralRulesValues.Two, "před {0} kw." }, { PluralRulesValues.Few, "před {0} kw." }, { PluralRulesValues.Other, "před {0} kw." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kw." }, { PluralRulesValues.Two, "za {0} kw." }, { PluralRulesValues.Few, "za {0} kw." }, { PluralRulesValues.Other, "za {0} kw." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "kwart.",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} kwart." }, { PluralRulesValues.Two, "před {0} kwart." }, { PluralRulesValues.Few, "před {0} kwart." }, { PluralRulesValues.Other, "před {0} kwart." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kwart." }, { PluralRulesValues.Two, "za {0} kwart." }, { PluralRulesValues.Few, "za {0} kwart." }, { PluralRulesValues.Other, "za {0} kwart." } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "měsac",
                new Dictionary<int, string> { { -1, "zašły měsac" }, { 0, "tutón měsac" }, { 1, "přichodny měsac" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} měsacom" }, { PluralRulesValues.Two, "před {0} měsacomaj" }, { PluralRulesValues.Few, "před {0} měsacami" }, { PluralRulesValues.Other, "před {0} měsacami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} měsac" }, { PluralRulesValues.Two, "za {0} měsacaj" }, { PluralRulesValues.Few, "za {0} měsacy" }, { PluralRulesValues.Other, "za {0} měsacow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "měs.",
                new Dictionary<int, string> { { -1, "zašły měsac" }, { 0, "tutón měsac" }, { 1, "přichodny měsac" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} měs." }, { PluralRulesValues.Two, "před {0} měs." }, { PluralRulesValues.Few, "před {0} měs." }, { PluralRulesValues.Other, "před {0} měs." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} měs." }, { PluralRulesValues.Two, "za {0} měs." }, { PluralRulesValues.Few, "za {0} měs." }, { PluralRulesValues.Other, "za {0} měs." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "měs.",
                new Dictionary<int, string> { { -1, "zašły měsac" }, { 0, "tutón měsac" }, { 1, "přichodny měsac" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} měs." }, { PluralRulesValues.Two, "před {0} měs." }, { PluralRulesValues.Few, "před {0} měs." }, { PluralRulesValues.Other, "před {0} měs." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} měs." }, { PluralRulesValues.Two, "za {0} měs." }, { PluralRulesValues.Few, "za {0} měs." }, { PluralRulesValues.Other, "za {0} měs." } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "tydźeń",
                new Dictionary<int, string> { { -1, "zašły tydźeń" }, { 0, "tutón tydźeń" }, { 1, "přichodny tydźeń" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} tydźenjom" }, { PluralRulesValues.Two, "před {0} tydźenjomaj" }, { PluralRulesValues.Few, "před {0} tydźenjemi" }, { PluralRulesValues.Other, "před {0} tydźenjemi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} tydźeń" }, { PluralRulesValues.Two, "za {0} tydźenjej" }, { PluralRulesValues.Few, "za {0} tydźenje" }, { PluralRulesValues.Other, "za {0} tydźenjow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "tydź.",
                new Dictionary<int, string> { { -1, "zašły tydźeń" }, { 0, "tutón tydźeń" }, { 1, "přichodny tydźeń" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} tydź." }, { PluralRulesValues.Two, "před {0} tydź." }, { PluralRulesValues.Few, "před {0} tydź." }, { PluralRulesValues.Other, "před {0} tydź." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} tydź." }, { PluralRulesValues.Two, "za {0} tydź." }, { PluralRulesValues.Few, "za {0} tydź." }, { PluralRulesValues.Other, "za {0} tydź." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "tydź.",
                new Dictionary<int, string> { { -1, "zašły tydźeń" }, { 0, "tutón tydźeń" }, { 1, "přichodny tydźeń" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} tydź." }, { PluralRulesValues.Two, "před {0} tydź." }, { PluralRulesValues.Few, "před {0} tydź." }, { PluralRulesValues.Other, "před {0} tydź." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} tydź." }, { PluralRulesValues.Two, "za {0} tydź." }, { PluralRulesValues.Few, "za {0} tydź." }, { PluralRulesValues.Other, "za {0} tydź." } }));

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
                "dźeń",
                new Dictionary<int, string> { { -1, "wčera" }, { 0, "dźensa" }, { 1, "jutře" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} dnjom" }, { PluralRulesValues.Two, "před {0} dnjomaj" }, { PluralRulesValues.Few, "před {0} dnjemi" }, { PluralRulesValues.Other, "před {0} dnjemi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} dźeń" }, { PluralRulesValues.Two, "za {0} dnjej" }, { PluralRulesValues.Few, "za {0} dny" }, { PluralRulesValues.Other, "za {0} dnjow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "d",
                new Dictionary<int, string> { { -1, "wčera" }, { 0, "dźensa" }, { 1, "jutře" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} d" }, { PluralRulesValues.Two, "před {0} d" }, { PluralRulesValues.Few, "před {0} d" }, { PluralRulesValues.Other, "před {0} d" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} d" }, { PluralRulesValues.Two, "za {0} d" }, { PluralRulesValues.Few, "za {0} d" }, { PluralRulesValues.Other, "za {0} d" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "dźeń",
                new Dictionary<int, string> { { -1, "wčera" }, { 0, "dźensa" }, { 1, "jutře" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} dnj." }, { PluralRulesValues.Two, "před {0} dnj." }, { PluralRulesValues.Few, "před {0} dnj." }, { PluralRulesValues.Other, "před {0} dnj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} dźeń" }, { PluralRulesValues.Two, "za {0} dnj." }, { PluralRulesValues.Few, "za {0} dny" }, { PluralRulesValues.Other, "za {0} dnj." } }));

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
                "dźeń tydźenja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "dźeń tydźenja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "dźeń tydźenja",
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
                new Dictionary<int, string> { { -1, "zašłu njedźelu" }, { 0, "tutu njedźelu" }, { 1, "přichodnu njedźelu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "zašłu nj." }, { 0, "tutu nj." }, { 1, "přichodnu nj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "zašłu nje." }, { 0, "tutu nje." }, { 1, "přichodnu nje." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "zašłu póndźelu" }, { 0, "tutu póndźelu" }, { 1, "přichodnu póndźelu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "zašłu pó." }, { 0, "tutu pó." }, { 1, "přichodnu pó." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "zašłu pón." }, { 0, "tutu pón." }, { 1, "přichodnu pón." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "zašłu wutoru" }, { 0, "tutu wutoru" }, { 1, "přichodnu wutoru" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "zašłu wu." }, { 0, "tutu wu." }, { 1, "přichodnu wu." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "zašłu wut." }, { 0, "tutu wut." }, { 1, "přichodnu wut." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "zašłu srjedu" }, { 0, "tutu srjedu" }, { 1, "přichodnu srjedu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "zašłu sr." }, { 0, "tutu sr." }, { 1, "přichodnu sr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "zašłu srj." }, { 0, "tutu srj." }, { 1, "přichodnu srj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "zašły štwórtk" }, { 0, "tutón štwórtk" }, { 1, "přichodny štwórtk" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "zašły št." }, { 0, "tutón št." }, { 1, "přichodny št." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "zašły štw." }, { 0, "tutón štw." }, { 1, "přichodny štw." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "zašły pjatk" }, { 0, "tutón pjatk" }, { 1, "přichodny pjatk" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "zašły pj." }, { 0, "tutón pj." }, { 1, "přichodny pj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "zašły pja." }, { 0, "tutón pja." }, { 1, "přichodny pja." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "zašłu sobotu" }, { 0, "tutu sobotu" }, { 1, "přichodnu sobotu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "zašłu so." }, { 0, "tutu so." }, { 1, "přichodnu so." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "zašłu sob." }, { 0, "tutu sob." }, { 1, "přichodnu sob." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "połojca dnja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "połojca dnja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "połojca dnja",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "hodźina",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} hodźinu" }, { PluralRulesValues.Two, "před {0} hodźinomaj" }, { PluralRulesValues.Few, "před {0} hodźinami" }, { PluralRulesValues.Other, "před {0} hodźinami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} hodźinu" }, { PluralRulesValues.Two, "za {0} hodźinje" }, { PluralRulesValues.Few, "za {0} hodźiny" }, { PluralRulesValues.Other, "za {0} hodźin" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "h",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} h" }, { PluralRulesValues.Two, "před {0} h" }, { PluralRulesValues.Few, "před {0} h" }, { PluralRulesValues.Other, "před {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} h" }, { PluralRulesValues.Two, "za {0} h" }, { PluralRulesValues.Few, "za {0} h" }, { PluralRulesValues.Other, "za {0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "hodź.",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} hodź." }, { PluralRulesValues.Two, "před {0} hodź." }, { PluralRulesValues.Few, "před {0} hodź." }, { PluralRulesValues.Other, "před {0} hodź." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} hodź." }, { PluralRulesValues.Two, "za {0} hodź." }, { PluralRulesValues.Few, "za {0} hodź." }, { PluralRulesValues.Other, "za {0} hodź." } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minuta",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} minutu" }, { PluralRulesValues.Two, "před {0} minutomaj" }, { PluralRulesValues.Few, "před {0} minutami" }, { PluralRulesValues.Other, "před {0} minutami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} minutu" }, { PluralRulesValues.Two, "za {0} minuće" }, { PluralRulesValues.Few, "za {0} minuty" }, { PluralRulesValues.Other, "za {0} minutow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "m",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} m" }, { PluralRulesValues.Two, "před {0} m" }, { PluralRulesValues.Few, "před {0} m" }, { PluralRulesValues.Other, "před {0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} m" }, { PluralRulesValues.Two, "za {0} m" }, { PluralRulesValues.Few, "za {0} m" }, { PluralRulesValues.Other, "za {0} m" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min.",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} min." }, { PluralRulesValues.Two, "před {0} min." }, { PluralRulesValues.Few, "před {0} min." }, { PluralRulesValues.Other, "před {0} min." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} min." }, { PluralRulesValues.Two, "za {0} min." }, { PluralRulesValues.Few, "za {0} min." }, { PluralRulesValues.Other, "za {0} min." } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "sekunda",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} sekundu" }, { PluralRulesValues.Two, "před {0} sekundomaj" }, { PluralRulesValues.Few, "před {0} sekundami" }, { PluralRulesValues.Other, "před {0} sekundami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sekundu" }, { PluralRulesValues.Two, "za {0} sekundźe" }, { PluralRulesValues.Few, "za {0} sekundy" }, { PluralRulesValues.Other, "za {0} sekundow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} s" }, { PluralRulesValues.Two, "před {0} s" }, { PluralRulesValues.Few, "před {0} s" }, { PluralRulesValues.Other, "před {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} s" }, { PluralRulesValues.Two, "za {0} s" }, { PluralRulesValues.Few, "za {0} s" }, { PluralRulesValues.Other, "za {0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sek.",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "před {0} sek." }, { PluralRulesValues.Two, "před {0} sek." }, { PluralRulesValues.Few, "před {0} sek." }, { PluralRulesValues.Other, "před {0} sek." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sek." }, { PluralRulesValues.Two, "za {0} sek." }, { PluralRulesValues.Few, "za {0} sek." }, { PluralRulesValues.Other, "za {0} sek." } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "časowe pasmo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "časowe pasmo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "časowe pasmo",
                null,
                null,
                null));
    }
}