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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Icelandic' [is]
    /// </summary>
    public class IcelandicRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "is";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "tímabil",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "tímabil",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "tímabil",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ár",
                new Dictionary<int, string> { { -1, "á síðasta ári" }, { 0, "á þessu ári" }, { 1, "á næsta ári" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} ári" }, { PluralRulesValues.Other, "fyrir {0} árum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} ár" }, { PluralRulesValues.Other, "eftir {0} ár" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ár",
                new Dictionary<int, string> { { -1, "á síðasta ári" }, { 0, "á þessu ári" }, { 1, "á næsta ári" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} árum" }, { PluralRulesValues.Other, "fyrir {0} árum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} ár" }, { PluralRulesValues.Other, "eftir {0} ár" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ár",
                new Dictionary<int, string> { { -1, "á síðasta ári" }, { 0, "á þessu ári" }, { 1, "á næsta ári" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} ári" }, { PluralRulesValues.Other, "fyrir {0} árum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} ár" }, { PluralRulesValues.Other, "eftir {0} ár" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ársfjórðungur",
                new Dictionary<int, string> { { -1, "síðasti ársfjórðungur" }, { 0, "þessi ársfjórðungur" }, { 1, "næsti ársfjórðungur" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} ársfjórðungi" }, { PluralRulesValues.Other, "fyrir {0} ársfjórðungum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} ársfjórðung" }, { PluralRulesValues.Other, "eftir {0} ársfjórðunga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ársfj.",
                new Dictionary<int, string> { { -1, "síðasti ársfj." }, { 0, "þessi ársfj." }, { 1, "næsti ársfj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} ársfj." }, { PluralRulesValues.Other, "fyrir {0} ársfj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} ársfj." }, { PluralRulesValues.Other, "eftir {0} ársfj." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ársfjórð.",
                new Dictionary<int, string> { { -1, "síðasti ársfj." }, { 0, "þessi ársfj." }, { 1, "næsti ársfj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} ársfj." }, { PluralRulesValues.Other, "fyrir {0} ársfj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} ársfj." }, { PluralRulesValues.Other, "eftir {0} ársfj." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "mánuður",
                new Dictionary<int, string> { { -1, "í síðasta mánuði" }, { 0, "í þessum mánuði" }, { 1, "í næsta mánuði" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mánuði" }, { PluralRulesValues.Other, "fyrir {0} mánuðum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mánuð" }, { PluralRulesValues.Other, "eftir {0} mánuði" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "mán.",
                new Dictionary<int, string> { { -1, "í síðasta mán." }, { 0, "í þessum mán." }, { 1, "í næsta mán." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mán." }, { PluralRulesValues.Other, "fyrir {0} mán." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mán." }, { PluralRulesValues.Other, "eftir {0} mán." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "mán.",
                new Dictionary<int, string> { { -1, "í síðasta mán." }, { 0, "í þessum mán." }, { 1, "í næsta mán." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mán." }, { PluralRulesValues.Other, "fyrir {0} mán." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mán." }, { PluralRulesValues.Other, "eftir {0} mán." } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "vika",
                new Dictionary<int, string> { { -1, "í síðustu viku" }, { 0, "í þessari viku" }, { 1, "í næstu viku" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} viku" }, { PluralRulesValues.Other, "fyrir {0} vikum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} viku" }, { PluralRulesValues.Other, "eftir {0} vikur" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "v.",
                new Dictionary<int, string> { { -1, "í síðustu viku" }, { 0, "í þessari viku" }, { 1, "í næstu viku" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} viku" }, { PluralRulesValues.Other, "-{0} vikur" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} viku" }, { PluralRulesValues.Other, "+{0} vikur" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "vika",
                new Dictionary<int, string> { { -1, "í síðustu viku" }, { 0, "í þessari viku" }, { 1, "í næstu viku" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} viku" }, { PluralRulesValues.Other, "fyrir {0} vikum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} viku" }, { PluralRulesValues.Other, "eftir {0} vikur" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "vika í mánuði",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "vika í mánuði",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "vika í mánuði",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dagur",
                new Dictionary<int, string> { { -2, "í fyrradag" }, { -1, "í gær" }, { 0, "í dag" }, { 1, "á morgun" }, { 2, "eftir tvo daga" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} degi" }, { PluralRulesValues.Other, "fyrir {0} dögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} dag" }, { PluralRulesValues.Other, "eftir {0} daga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dagur",
                new Dictionary<int, string> { { -2, "í fyrradag" }, { -1, "í gær" }, { 0, "í dag" }, { 1, "á morgun" }, { 2, "eftir tvo daga" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} degi" }, { PluralRulesValues.Other, "-{0} dögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} dag" }, { PluralRulesValues.Other, "+{0} daga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dagur",
                new Dictionary<int, string> { { -2, "í fyrradag" }, { -1, "í gær" }, { 0, "í dag" }, { 1, "á morgun" }, { 2, "eftir tvo daga" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} degi" }, { PluralRulesValues.Other, "fyrir {0} dögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} dag" }, { PluralRulesValues.Other, "eftir {0} daga" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dagur í ári",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dagur í ári",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dagur í ári",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "vikudagur",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "vikud.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "vikud.",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "vikudagur í mánuði",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "vikud. í mán.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "vikud. í mán.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "síðasta sunnudag" }, { 0, "núna á sunnudag" }, { 1, "næsta sunnudag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} sunnudegi" }, { PluralRulesValues.Other, "fyrir {0} sunnudögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} sunnudag" }, { PluralRulesValues.Other, "eftir {0} sunnudaga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "síðasti sun." }, { 0, "þessi sun." }, { 1, "nk. sun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} sun." }, { PluralRulesValues.Other, "fyrir {0} sun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} sun." }, { PluralRulesValues.Other, "eftir {0} sun." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "síðasta sun." }, { 0, "þessi sun." }, { 1, "næsta sun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} sun." }, { PluralRulesValues.Other, "fyrir {0} sun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} sun." }, { PluralRulesValues.Other, "eftir {0} sun." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "síðasta mánudag" }, { 0, "núna á mánudag" }, { 1, "næsta mánudag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mánudegi" }, { PluralRulesValues.Other, "fyrir {0} mánudögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mánudag" }, { PluralRulesValues.Other, "eftir {0} mánudaga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "síðasti mán." }, { 0, "þessi mán." }, { 1, "nk. mán." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mán." }, { PluralRulesValues.Other, "fyrir {0} mán." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mán." }, { PluralRulesValues.Other, "eftir {0} mán." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "síðasta mán." }, { 0, "núna á mán." }, { 1, "næsta mán." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mán." }, { PluralRulesValues.Other, "fyrir {0} mán." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mán." }, { PluralRulesValues.Other, "eftir {0} mán." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "síðasta þriðjudag" }, { 0, "núna á þriðjudaginn" }, { 1, "næsta þriðjudag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} þriðjudegi" }, { PluralRulesValues.Other, "fyrir {0} þriðjudögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} þriðjudag" }, { PluralRulesValues.Other, "eftir {0} þriðjudaga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "síðasti þri." }, { 0, "þessi þri." }, { 1, "nk. þri." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} þri." }, { PluralRulesValues.Other, "fyrir {0} þri." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} þri." }, { PluralRulesValues.Other, "eftir {0} þri." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "síðasti þri." }, { 0, "þessi þri." }, { 1, "næstkomandi þri." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} þri." }, { PluralRulesValues.Other, "fyrir {0} þri." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} þri." }, { PluralRulesValues.Other, "eftir {0} þri." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "síðasta miðvikudag" }, { 0, "núna á miðvikudaginn" }, { 1, "næsta miðvikudag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} miðvikudegi" }, { PluralRulesValues.Other, "fyrir {0} miðvikudögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} miðvikudag" }, { PluralRulesValues.Other, "eftir {0} miðvikudaga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "síðasti mið." }, { 0, "þessi mið." }, { 1, "nk. mið." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mið." }, { PluralRulesValues.Other, "fyrir {0} mið." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mið." }, { PluralRulesValues.Other, "eftir {0} mið." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "síðasti mið." }, { 0, "þessi mið." }, { 1, "næstkomandi mið." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mið." }, { PluralRulesValues.Other, "fyrir {0} mið." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mið." }, { PluralRulesValues.Other, "eftir {0} mið." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "síðasta fimmtudag" }, { 0, "núna á fimmtudaginn" }, { 1, "næsta fimmtudag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} fimmtudegi" }, { PluralRulesValues.Other, "fyrir {0} fimmtudögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} fimmtudag" }, { PluralRulesValues.Other, "eftir {0} fimmtudaga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "síðasti fim." }, { 0, "þessi fim." }, { 1, "nk. fim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} fim." }, { PluralRulesValues.Other, "fyrir {0} fim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} fim." }, { PluralRulesValues.Other, "eftir {0} fim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "síðasti fim." }, { 0, "þessi fim." }, { 1, "næstkomandi fim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} fim." }, { PluralRulesValues.Other, "fyrir {0} fim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} fim." }, { PluralRulesValues.Other, "eftir {0} fim." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "síðasta föstudag" }, { 0, "núna á föstudaginn" }, { 1, "næsta föstudag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} föstudegi" }, { PluralRulesValues.Other, "fyrir {0} föstudögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} föstudag" }, { PluralRulesValues.Other, "eftir {0} föstudaga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "síðasta fös." }, { 0, "á fös." }, { 1, "næsta fös." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} fös." }, { PluralRulesValues.Other, "fyrir {0} fös." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} fös." }, { PluralRulesValues.Other, "eftir {0} fös." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "síðasta fös." }, { 0, "á fös." }, { 1, "næsta fös." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} fös." }, { PluralRulesValues.Other, "fyrir {0} fös." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} fös." }, { PluralRulesValues.Other, "eftir {0} fös." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "síðasta laugardag" }, { 0, "núna á laugardaginn" }, { 1, "næsta laugardag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} laugardegi" }, { PluralRulesValues.Other, "fyrir {0} laugardögum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} laugardag" }, { PluralRulesValues.Other, "eftir {0} laugardaga" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "síðasta lau." }, { 0, "á lau." }, { 1, "næsta lau." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} lau." }, { PluralRulesValues.Other, "fyrir {0} lau." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} lau." }, { PluralRulesValues.Other, "eftir {0} lau." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "síðasta lau." }, { 0, "á lau." }, { 1, "næsta lau." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} lau." }, { PluralRulesValues.Other, "fyrir {0} lau." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} lau." }, { PluralRulesValues.Other, "eftir {0} lau." } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "f.h./e.h.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "f.h./e.h.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "f.h./e.h.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "klukkustund",
                new Dictionary<int, string> { { 0, "þessa stundina" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} klukkustund" }, { PluralRulesValues.Other, "fyrir {0} klukkustundum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} klukkustund" }, { PluralRulesValues.Other, "eftir {0} klukkustundir" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "klst.",
                new Dictionary<int, string> { { 0, "þessa stundina" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} klst." }, { PluralRulesValues.Other, "-{0} klst." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} klst." }, { PluralRulesValues.Other, "+{0} klst." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "klst.",
                new Dictionary<int, string> { { 0, "þessa stundina" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} klst." }, { PluralRulesValues.Other, "fyrir {0} klst." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} klst." }, { PluralRulesValues.Other, "eftir {0} klst." } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "mínúta",
                new Dictionary<int, string> { { 0, "á þessari mínútu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mínútu" }, { PluralRulesValues.Other, "fyrir {0} mínútum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mínútu" }, { PluralRulesValues.Other, "eftir {0} mínútur" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "mín.",
                new Dictionary<int, string> { { 0, "á þessari mínútu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} mín." }, { PluralRulesValues.Other, "-{0} mín." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} mín." }, { PluralRulesValues.Other, "+{0} mín." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "mín.",
                new Dictionary<int, string> { { 0, "á þessari mínútu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} mín." }, { PluralRulesValues.Other, "fyrir {0} mín." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} mín." }, { PluralRulesValues.Other, "eftir {0} mín." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "sekúnda",
                new Dictionary<int, string> { { 0, "núna" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} sekúndu" }, { PluralRulesValues.Other, "fyrir {0} sekúndum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} sekúndu" }, { PluralRulesValues.Other, "eftir {0} sekúndur" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "sek.",
                new Dictionary<int, string> { { 0, "núna" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} sek." }, { PluralRulesValues.Other, "-{0} sek." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} sek." }, { PluralRulesValues.Other, "+{0} sek." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sek.",
                new Dictionary<int, string> { { 0, "núna" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fyrir {0} sek." }, { PluralRulesValues.Other, "fyrir {0} sek." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "eftir {0} sek." }, { PluralRulesValues.Other, "eftir {0} sek." } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Icelandic' [is]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "tímabelti",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "tímab.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "tímab.",
                null,
                null,
                null));
    }
}