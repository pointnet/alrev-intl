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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Lower Sorbian' [dsb]
    /// </summary>
    public class LowerSorbianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "dsb";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "epocha",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "epocha",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "epocha",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "lěto",
                new Dictionary<int, string> { { -1, "łoni" }, { 0, "lětosa" }, { 1, "znowa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} lětom" }, { PluralRulesValues.Two, "pśed {0} lětoma" }, { PluralRulesValues.Few, "pśed {0} lětami" }, { PluralRulesValues.Other, "pśed {0} lětami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} lěto" }, { PluralRulesValues.Two, "za {0} lěśe" }, { PluralRulesValues.Few, "za {0} lěta" }, { PluralRulesValues.Other, "za {0} lět" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "l.",
                new Dictionary<int, string> { { -1, "łoni" }, { 0, "lětosa" }, { 1, "znowa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} l." }, { PluralRulesValues.Two, "pśed {0} l." }, { PluralRulesValues.Few, "pśed {0} l." }, { PluralRulesValues.Other, "pśed {0} l." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} l." }, { PluralRulesValues.Two, "za {0} l." }, { PluralRulesValues.Few, "za {0} l." }, { PluralRulesValues.Other, "za {0} l." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "l.",
                new Dictionary<int, string> { { -1, "łoni" }, { 0, "lětosa" }, { 1, "znowa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} l." }, { PluralRulesValues.Two, "pśed {0} l." }, { PluralRulesValues.Few, "pśed {0} l." }, { PluralRulesValues.Other, "pśed {0} l." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} l." }, { PluralRulesValues.Two, "za {0} l." }, { PluralRulesValues.Few, "za {0} l." }, { PluralRulesValues.Other, "za {0} l." } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "kwartal",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} kwartalom" }, { PluralRulesValues.Two, "pśed {0} kwartaloma" }, { PluralRulesValues.Few, "pśed {0} kwartalami" }, { PluralRulesValues.Other, "pśed {0} kwartalami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kwartal" }, { PluralRulesValues.Two, "za {0} kwartala" }, { PluralRulesValues.Few, "za {0} kwartale" }, { PluralRulesValues.Other, "za {0} kwartalow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "kw.",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} kw." }, { PluralRulesValues.Two, "pśed {0} kw." }, { PluralRulesValues.Few, "pśed {0} kw." }, { PluralRulesValues.Other, "pśed {0} kw." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kw." }, { PluralRulesValues.Two, "za {0} kw." }, { PluralRulesValues.Few, "za {0} kw." }, { PluralRulesValues.Other, "za {0} kw." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "kwart.",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} kwart." }, { PluralRulesValues.Two, "pśed {0} kwart." }, { PluralRulesValues.Few, "pśed {0} kwart." }, { PluralRulesValues.Other, "pśed {0} kwart." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kwart." }, { PluralRulesValues.Two, "za {0} kwart." }, { PluralRulesValues.Few, "za {0} kwart." }, { PluralRulesValues.Other, "za {0} kwart." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "mjasec",
                new Dictionary<int, string> { { -1, "slědny mjasec" }, { 0, "ten mjasec" }, { 1, "pśiducy mjasec" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} mjasecom" }, { PluralRulesValues.Two, "pśed {0} mjasecoma" }, { PluralRulesValues.Few, "pśed {0} mjasecami" }, { PluralRulesValues.Other, "pśed {0} mjasecami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} mjasec" }, { PluralRulesValues.Two, "za {0} mjaseca" }, { PluralRulesValues.Few, "za {0} mjasecy" }, { PluralRulesValues.Other, "za {0} mjasecow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "mjas.",
                new Dictionary<int, string> { { -1, "slědny mjasec" }, { 0, "ten mjasec" }, { 1, "pśiducy mjasec" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} mjas." }, { PluralRulesValues.Two, "pśed {0} mjas." }, { PluralRulesValues.Few, "pśed {0} mjas." }, { PluralRulesValues.Other, "pśed {0} mjas." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} mjas." }, { PluralRulesValues.Two, "za {0} mjas." }, { PluralRulesValues.Few, "za {0} mjas." }, { PluralRulesValues.Other, "za {0} mjas." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "mjas.",
                new Dictionary<int, string> { { -1, "slědny mjasec" }, { 0, "ten mjasec" }, { 1, "pśiducy mjasec" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} mjas." }, { PluralRulesValues.Two, "pśed {0} mjas." }, { PluralRulesValues.Few, "pśed {0} mjas." }, { PluralRulesValues.Other, "pśed {0} mjas." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} mjas." }, { PluralRulesValues.Two, "za {0} mjas." }, { PluralRulesValues.Few, "za {0} mjas." }, { PluralRulesValues.Other, "za {0} mjas." } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "tyźeń",
                new Dictionary<int, string> { { -1, "slědny tyźeń" }, { 0, "ten tyźeń" }, { 1, "pśiducy tyźeń" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} tyźenjom" }, { PluralRulesValues.Two, "pśed {0} tyźenjoma" }, { PluralRulesValues.Few, "pśed {0} tyźenjami" }, { PluralRulesValues.Other, "pśed {0} tyźenjami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} tyźeń" }, { PluralRulesValues.Two, "za {0} tyźenja" }, { PluralRulesValues.Few, "za {0} tyźenje" }, { PluralRulesValues.Other, "za {0} tyźenjow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "tyź.",
                new Dictionary<int, string> { { -1, "slědny tyźeń" }, { 0, "ten tyźeń" }, { 1, "pśiducy tyźeń" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} tyź." }, { PluralRulesValues.Two, "pśed {0} tyź." }, { PluralRulesValues.Few, "pśed {0} tyź." }, { PluralRulesValues.Other, "pśed {0} tyź." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} tyź." }, { PluralRulesValues.Two, "za {0} tyź." }, { PluralRulesValues.Few, "za {0} tyź." }, { PluralRulesValues.Other, "za {0} tyź." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "tyź.",
                new Dictionary<int, string> { { -1, "slědny tyźeń" }, { 0, "ten tyźeń" }, { 1, "pśiducy tyźeń" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} tyź." }, { PluralRulesValues.Two, "pśed {0} tyź." }, { PluralRulesValues.Few, "pśed {0} tyź." }, { PluralRulesValues.Other, "pśed {0} tyź." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} tyź." }, { PluralRulesValues.Two, "za {0} tyź." }, { PluralRulesValues.Few, "za {0} tyź." }, { PluralRulesValues.Other, "za {0} tyź." } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "Week Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "źeń",
                new Dictionary<int, string> { { -1, "cora" }, { 0, "źinsa" }, { 1, "witśe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} dnjom" }, { PluralRulesValues.Two, "pśed {0} dnjoma" }, { PluralRulesValues.Few, "pśed {0} dnjami" }, { PluralRulesValues.Other, "pśed {0} dnjami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} źeń" }, { PluralRulesValues.Two, "za {0} dnja" }, { PluralRulesValues.Few, "za {0} dny" }, { PluralRulesValues.Other, "za {0} dnjow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ź",
                new Dictionary<int, string> { { -1, "cora" }, { 0, "źinsa" }, { 1, "witśe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} d" }, { PluralRulesValues.Two, "pśed {0} d" }, { PluralRulesValues.Few, "pśed {0} d" }, { PluralRulesValues.Other, "pśed {0} d" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} ź" }, { PluralRulesValues.Two, "za {0} ź" }, { PluralRulesValues.Few, "za {0} ź" }, { PluralRulesValues.Other, "za {0} ź" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "źeń",
                new Dictionary<int, string> { { -1, "cora" }, { 0, "źinsa" }, { 1, "witśe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} dnj." }, { PluralRulesValues.Two, "pśed {0} dnj." }, { PluralRulesValues.Few, "pśed {0} dnj." }, { PluralRulesValues.Other, "pśed {0} dnj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} źeń" }, { PluralRulesValues.Two, "za {0} dnj." }, { PluralRulesValues.Few, "za {0} dny" }, { PluralRulesValues.Other, "za {0} dnj." } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "Day Of Year",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "źeń tyźenja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "źeń tyźenja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "źeń tyźenja",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "Weekday Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "slědnu njeźelu" }, { 0, "tu njeźelu" }, { 1, "pśiducu njeźelu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "slědnu nj." }, { 0, "tu nj." }, { 1, "pśiducu nj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "slědnu nje." }, { 0, "tu nje." }, { 1, "pśiducu nje." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "slědne pónjeźele" }, { 0, "to pónjeźele" }, { 1, "pśiduce pónjeźele" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "slědne pó." }, { 0, "to pó." }, { 1, "pśiduce pó." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "slědne pónj." }, { 0, "to pónj." }, { 1, "pśiduce pónj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "slědnu wałtoru" }, { 0, "tu wałtoru" }, { 1, "pśiducu wałtoru" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "slědnu wa." }, { 0, "tu wa." }, { 1, "pśiducu wa." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "slědnu wałt." }, { 0, "tu wałt." }, { 1, "pśiducu wałt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "slědnu srjodu" }, { 0, "tu srjodu" }, { 1, "pśiducu srjodu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "slědnu sr." }, { 0, "tu sr." }, { 1, "pśiducu sr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "slědnu srj." }, { 0, "tu srj." }, { 1, "pśiducu srj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "slědny stwórtk" }, { 0, "ten stwórtk" }, { 1, "pśiducy stwórtk" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "slědny st." }, { 0, "ten st." }, { 1, "pśiducy st." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "slědny stw." }, { 0, "ten stw." }, { 1, "pśiducy stw." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "slědny pětk" }, { 0, "ten pětk" }, { 1, "pśiducy pětk" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "slědny pě." }, { 0, "ten pě." }, { 1, "pśiducy pě." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "slědny pět." }, { 0, "ten pět." }, { 1, "pśiducy pět." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "slědnu sobotu" }, { 0, "tu sobotu" }, { 1, "pśiducu sobotu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "slědnu so." }, { 0, "tu so." }, { 1, "pśiducu so." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "slědnu sob." }, { 0, "tu sob." }, { 1, "pśiducu sob." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "połojca dnja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "połojca dnja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "połojca dnja",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "góźina",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} góźinu" }, { PluralRulesValues.Two, "pśed {0} góźinoma" }, { PluralRulesValues.Few, "pśed {0} góźinami" }, { PluralRulesValues.Other, "pśed {0} góźinami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} góźinu" }, { PluralRulesValues.Two, "za {0} góźinje" }, { PluralRulesValues.Few, "za {0} góźiny" }, { PluralRulesValues.Other, "za {0} góźin" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "g",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} g" }, { PluralRulesValues.Two, "pśed {0} g" }, { PluralRulesValues.Few, "pśed {0} g" }, { PluralRulesValues.Other, "pśed {0} g" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} g" }, { PluralRulesValues.Two, "za {0} g" }, { PluralRulesValues.Few, "za {0} g" }, { PluralRulesValues.Other, "za {0} g" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "góź.",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} góź." }, { PluralRulesValues.Two, "pśed {0} góź." }, { PluralRulesValues.Few, "pśed {0} góź." }, { PluralRulesValues.Other, "pśed {0} góź." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} góź." }, { PluralRulesValues.Two, "za {0} góź." }, { PluralRulesValues.Few, "za {0} góź." }, { PluralRulesValues.Other, "za {0} góź." } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "minuta",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} minutu" }, { PluralRulesValues.Two, "pśed {0} minutoma" }, { PluralRulesValues.Few, "pśed {0} minutami" }, { PluralRulesValues.Other, "pśed {0} minutami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} minutu" }, { PluralRulesValues.Two, "za {0} minuśe" }, { PluralRulesValues.Few, "za {0} minuty" }, { PluralRulesValues.Other, "za {0} minutow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "m",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} m" }, { PluralRulesValues.Two, "pśed {0} m" }, { PluralRulesValues.Few, "pśed {0} m" }, { PluralRulesValues.Other, "pśed {0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} m" }, { PluralRulesValues.Two, "za {0} m" }, { PluralRulesValues.Few, "za {0} m" }, { PluralRulesValues.Other, "za {0} m" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "min.",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} min." }, { PluralRulesValues.Two, "pśed {0} min." }, { PluralRulesValues.Few, "pśed {0} min." }, { PluralRulesValues.Other, "pśed {0} min." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} min." }, { PluralRulesValues.Two, "za {0} min." }, { PluralRulesValues.Few, "za {0} min." }, { PluralRulesValues.Other, "za {0} min." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "sekunda",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} sekundu" }, { PluralRulesValues.Two, "pśed {0} sekundoma" }, { PluralRulesValues.Few, "pśed {0} sekundami" }, { PluralRulesValues.Other, "pśed {0} sekundami" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sekundu" }, { PluralRulesValues.Two, "za {0} sekunźe" }, { PluralRulesValues.Few, "za {0} sekundy" }, { PluralRulesValues.Other, "za {0} sekundow" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} s" }, { PluralRulesValues.Two, "pśed {0} s" }, { PluralRulesValues.Few, "pśed {0} s" }, { PluralRulesValues.Other, "pśed {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} s" }, { PluralRulesValues.Two, "za {0} s" }, { PluralRulesValues.Few, "za {0} s" }, { PluralRulesValues.Other, "za {0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sek.",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pśed {0} sek." }, { PluralRulesValues.Two, "pśed {0} sek." }, { PluralRulesValues.Few, "pśed {0} sek." }, { PluralRulesValues.Other, "pśed {0} sek." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sek." }, { PluralRulesValues.Two, "za {0} sek." }, { PluralRulesValues.Few, "za {0} sek." }, { PluralRulesValues.Other, "za {0} sek." } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Lower Sorbian' [dsb]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "casowe pasmo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "casowe pasmo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "casowe pasmo",
                null,
                null,
                null));
    }
}