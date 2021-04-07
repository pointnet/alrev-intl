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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Wolof' [wo]
    /// </summary>
    public class WolofRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "wo";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Era,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Long,
                "jamono",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Narrow,
                "jamono",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Short,
                "jamono",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "at",
                new Dictionary<int, string> { { -1, "daaw" }, { 0, "ren" }, { 1, "dewen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} at ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} at" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "at.",
                new Dictionary<int, string> { { -1, "daaw" }, { 0, "ren" }, { 1, "dewen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} at ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} at" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "at.",
                new Dictionary<int, string> { { -1, "daaw" }, { 0, "ren" }, { 1, "dewen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} at ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} at" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "ñeenti-weer",
                new Dictionary<int, string> { { -1, "trimestre bi weesu" }, { 0, "trimestre bii" }, { 1, "trimestre biy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} trimestre ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} trimestre" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "ñw.",
                new Dictionary<int, string> { { -1, "trimestre bi weesu" }, { 0, "trimestre bii" }, { 1, "trimestre biy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} trim. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} trim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "ñw.",
                new Dictionary<int, string> { { -1, "trimestre bi weesu" }, { 0, "trimestre bii" }, { 1, "trimestre biy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} trim. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} trim." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "weer",
                new Dictionary<int, string> { { -1, "weer wi weesu" }, { 0, "weer wii" }, { 1, "weer wiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} weer ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} weer" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "we.",
                new Dictionary<int, string> { { -1, "we. wi wees" }, { 0, "we. wii" }, { 1, "we. wiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} we. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} we." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "we.",
                new Dictionary<int, string> { { -1, "we. wi wees" }, { 0, "we. wii" }, { 1, "we. wiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} we. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} we." } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "ayu-bis",
                new Dictionary<int, string> { { -1, "ayu-bis bi weesu" }, { 0, "ayu-bis bii" }, { 1, "ayu-bis biy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ayi-bis ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} ayi-bis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "ayu-b.",
                new Dictionary<int, string> { { -1, "ayu-b bi wees" }, { 0, "ayu-b bii" }, { 1, "ayu-b. ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ayi-b. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} ayi-b." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "ayu-b.",
                new Dictionary<int, string> { { -1, "ayu-b bi wees" }, { 0, "ayu-b bii" }, { 1, "ayu-b. ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ayi-b. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} ayi-b." } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Long,
                "ayu-bisu weer",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Narrow,
                "ayu-b. we.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Short,
                "ayu-b. we.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "fan",
                new Dictionary<int, string> { { -1, "démb" }, { 0, "tay" }, { 1, "suba" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} fan ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} fan" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "fan",
                new Dictionary<int, string> { { -1, "démb" }, { 0, "tay" }, { 1, "suba" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} fan ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} fan" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "fan",
                new Dictionary<int, string> { { -1, "démb" }, { 0, "tay" }, { 1, "suba" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} fan ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} fan" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayOfYear,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Long,
                "bisu at mi",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Narrow,
                "bisu at",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Short,
                "bisu at",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Weekday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Long,
                "bisu ayu-bis",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Narrow,
                "bisu ayu-bis",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Short,
                "bisu ayu-bis",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekdayOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Long,
                "bisu ayu-bisu weer wi",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Narrow,
                "bisu ayu-b. weer",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Short,
                "bisu ayu-b. weer",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dibéer bi weesu" }, { 0, "tay ci dibéer bi" }, { 1, "dibéer biy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dibéer ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} dibéer" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dib. bi weesu" }, { 0, "tay ci dib. bi" }, { 1, "dib. biy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dib. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} dib." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dib. bi weesu" }, { 0, "tay ci dib. bi" }, { 1, "dib. biy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dib. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} dib." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "altine ji weesu" }, { 0, "tay ci altine ji" }, { 1, "altine jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} altine ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} altine" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "alt. ji weesu" }, { 0, "tay ci alt. ji" }, { 1, "alt. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alt. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "alti. ji weesu" }, { 0, "tay ci alti. ji" }, { 1, "alti. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alti. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alti." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "talaata ji weesu" }, { 0, "tay ci talaata ji" }, { 1, "talaata jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} talaata ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} talaata" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ta. ji weesu" }, { 0, "tay ci ta. ji" }, { 1, "ta. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ta. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} ta." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "tal. ji weesu" }, { 0, "tay ci tal. ji" }, { 1, "tal. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tal. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} tal." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "àllarba ji weesu" }, { 0, "tay ci àllarba ji" }, { 1, "àllarba jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àllarba ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àllarba" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "àla. ji weesu" }, { 0, "tay ci àla. ji" }, { 1, "àla. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àla. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àla." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "àlla. ji weesu" }, { 0, "tay ci àlla. ji" }, { 1, "àlla. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àlla. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àlla." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "alxamis ji weesu" }, { 0, "tay ci alxamis ji" }, { 1, "alxamis jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alxamis ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alxamis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "alx. ji weesu" }, { 0, "tay ci alx. ji" }, { 1, "alx. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alx. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alx." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "alxa. ji weesu" }, { 0, "tay ci alxa. ji" }, { 1, "alxa. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alxa. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alxa." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "àjjuma ji weesu" }, { 0, "tay ci àjjuma ji" }, { 1, "àjjuma jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àjjuma ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àjjuma" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "àj. ji weesu" }, { 0, "tay ci àj. ji" }, { 1, "àj. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àj. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àj." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "àjj. ji weesu" }, { 0, "tay ci àjj. ji" }, { 1, "àjj. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àjj. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àjj." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "gàwwu ji weesu" }, { 0, "tay ci gàwwu ji" }, { 1, "gàwwu jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} gàwwu ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} gàwwu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "gà. ji weesu" }, { 0, "tay ci gà. ji" }, { 1, "gà. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} gà. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} gà." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "gàw. ji weesu" }, { 0, "tay ci gàw. ji" }, { 1, "gàw. jiy ñëw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} gàw. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} gàw." } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayPeriod,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Long,
                "Sub/Ngo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Narrow,
                "Sub/Ngo",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Short,
                "Sub/Ngo",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "waxt",
                new Dictionary<int, string> { { 0, "ci waxtu wii" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} waxtu ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} waxtu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "wxt.",
                new Dictionary<int, string> { { 0, "ci waxtu wii" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} wax. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} wax." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "wxt.",
                new Dictionary<int, string> { { 0, "ci waxtu wii" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} wax. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} wax." } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "simili",
                new Dictionary<int, string> { { 0, "ci simili bii" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} simili ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} simili" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "sim.",
                new Dictionary<int, string> { { 0, "ci simili bii" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} sim. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} sim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "sim.",
                new Dictionary<int, string> { { 0, "ci simili bii" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} sim. ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} sim." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "saa",
                new Dictionary<int, string> { { 0, "leegi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} saa ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} saa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "saa.",
                new Dictionary<int, string> { { 0, "leegi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} saa ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} saa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "saa.",
                new Dictionary<int, string> { { 0, "leegi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} saa ci ginaaw" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} saa" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Wolof' [wo]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Zone,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Long,
                "goxu waxtu",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Narrow,
                "gox",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Short,
                "goxu",
                null,
                null,
                null));

        /// <summary>
        /// Gets the Relative Time resource styles based on the unit specified
        /// </summary>
        /// <param name="relativeTimeUnit">The resource unit to get</param>
        /// <returns>An <see cref="IRelativeTimeStylesResource"/></returns>
        /// <exception cref="RelativeTimeUnitNotFoundException"></exception>
        public IRelativeTimeStylesResource GetRelativeTimeStylesResource(RelativeTimeUnitValues relativeTimeUnit) => relativeTimeUnit switch
        {
            RelativeTimeUnitValues.Era => this.Era,
            RelativeTimeUnitValues.Year => this.Year,
            RelativeTimeUnitValues.Quarter => this.Quarter,
            RelativeTimeUnitValues.Month => this.Month,
            RelativeTimeUnitValues.Week => this.Week,
            RelativeTimeUnitValues.WeekOfMonth => this.WeekOfMonth,
            RelativeTimeUnitValues.Day => this.Day,
            RelativeTimeUnitValues.DayOfYear => this.DayOfYear,
            RelativeTimeUnitValues.Weekday => this.Weekday,
            RelativeTimeUnitValues.WeekdayOfMonth => this.WeekdayOfMonth,
            RelativeTimeUnitValues.Sunday => this.Sunday,
            RelativeTimeUnitValues.Monday => this.Monday,
            RelativeTimeUnitValues.Tuesday => this.Tuesday,
            RelativeTimeUnitValues.Wednesday => this.Wednesday,
            RelativeTimeUnitValues.Thursday => this.Thursday,
            RelativeTimeUnitValues.Friday => this.Friday,
            RelativeTimeUnitValues.Saturday => this.Saturday,
            RelativeTimeUnitValues.DayPeriod => this.DayPeriod,
            RelativeTimeUnitValues.Hour => this.Hour,
            RelativeTimeUnitValues.Minute => this.Minute,
            RelativeTimeUnitValues.Second => this.Second,
            RelativeTimeUnitValues.Zone => this.Zone,
            _ => throw new RelativeTimeUnitNotFoundException("Relative time unit does not exists", nameof(relativeTimeUnit))
        };
    }
}