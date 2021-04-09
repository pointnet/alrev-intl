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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Romanian' [ro]
    /// </summary>
    public class RomanianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ro";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "an",
                new Dictionary<int, string> { { -1, "anul trecut" }, { 0, "anul acesta" }, { 1, "anul viitor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} an" }, { PluralRulesValues.Few, "acum {0} ani" }, { PluralRulesValues.Other, "acum {0} de ani" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} an" }, { PluralRulesValues.Few, "peste {0} ani" }, { PluralRulesValues.Other, "peste {0} de ani" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "an",
                new Dictionary<int, string> { { -1, "anul trecut" }, { 0, "anul acesta" }, { 1, "anul viitor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} an" }, { PluralRulesValues.Few, "-{0} ani" }, { PluralRulesValues.Other, "-{0} ani" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} an" }, { PluralRulesValues.Few, "+{0} ani" }, { PluralRulesValues.Other, "+{0} ani" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "an",
                new Dictionary<int, string> { { -1, "anul trecut" }, { 0, "anul acesta" }, { 1, "anul viitor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} an" }, { PluralRulesValues.Few, "acum {0} ani" }, { PluralRulesValues.Other, "acum {0} de ani" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} an" }, { PluralRulesValues.Few, "peste {0} ani" }, { PluralRulesValues.Other, "peste {0} de ani" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "trimestru",
                new Dictionary<int, string> { { -1, "trimestrul trecut" }, { 0, "trimestrul acesta" }, { 1, "trimestrul viitor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} trimestru" }, { PluralRulesValues.Few, "acum {0} trimestre" }, { PluralRulesValues.Other, "acum {0} de trimestre" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} trimestru" }, { PluralRulesValues.Few, "peste {0} trimestre" }, { PluralRulesValues.Other, "peste {0} de trimestre" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "trim.",
                new Dictionary<int, string> { { -1, "trim. trecut" }, { 0, "trim. acesta" }, { 1, "trim. viitor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} trim." }, { PluralRulesValues.Few, "-{0} trim." }, { PluralRulesValues.Other, "-{0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} trim." }, { PluralRulesValues.Few, "+{0} trim." }, { PluralRulesValues.Other, "+{0} trim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "trim.",
                new Dictionary<int, string> { { -1, "trim. trecut" }, { 0, "trim. acesta" }, { 1, "trim. viitor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} trim." }, { PluralRulesValues.Few, "acum {0} trim." }, { PluralRulesValues.Other, "acum {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} trim." }, { PluralRulesValues.Few, "peste {0} trim." }, { PluralRulesValues.Other, "peste {0} trim." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "lună",
                new Dictionary<int, string> { { -1, "luna trecută" }, { 0, "luna aceasta" }, { 1, "luna viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} lună" }, { PluralRulesValues.Few, "acum {0} luni" }, { PluralRulesValues.Other, "acum {0} de luni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} lună" }, { PluralRulesValues.Few, "peste {0} luni" }, { PluralRulesValues.Other, "peste {0} de luni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "lună",
                new Dictionary<int, string> { { -1, "luna trecută" }, { 0, "luna aceasta" }, { 1, "luna viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} lună" }, { PluralRulesValues.Few, "-{0} luni" }, { PluralRulesValues.Other, "-{0} luni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} lună" }, { PluralRulesValues.Few, "+{0} luni" }, { PluralRulesValues.Other, "+{0} luni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "lună",
                new Dictionary<int, string> { { -1, "luna trecută" }, { 0, "luna aceasta" }, { 1, "luna viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} lună" }, { PluralRulesValues.Few, "acum {0} luni" }, { PluralRulesValues.Other, "acum {0} luni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} lună" }, { PluralRulesValues.Few, "peste {0} luni" }, { PluralRulesValues.Other, "peste {0} luni" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "săptămână",
                new Dictionary<int, string> { { -1, "săptămâna trecută" }, { 0, "săptămâna aceasta" }, { 1, "săptămâna viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} săptămână" }, { PluralRulesValues.Few, "acum {0} săptămâni" }, { PluralRulesValues.Other, "acum {0} de săptămâni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} săptămână" }, { PluralRulesValues.Few, "peste {0} săptămâni" }, { PluralRulesValues.Other, "peste {0} de săptămâni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "săpt.",
                new Dictionary<int, string> { { -1, "săpt. trecută" }, { 0, "săpt. aceasta" }, { 1, "săpt. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} săpt." }, { PluralRulesValues.Few, "-{0} săpt." }, { PluralRulesValues.Other, "-{0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} săpt." }, { PluralRulesValues.Few, "+{0} săpt." }, { PluralRulesValues.Other, "+{0} săpt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "săpt.",
                new Dictionary<int, string> { { -1, "săpt. trecută" }, { 0, "săpt. aceasta" }, { 1, "săpt. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} săpt." }, { PluralRulesValues.Few, "acum {0} săpt." }, { PluralRulesValues.Other, "acum {0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} săpt." }, { PluralRulesValues.Few, "peste {0} săpt." }, { PluralRulesValues.Other, "peste {0} săpt." } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "zi",
                new Dictionary<int, string> { { -2, "alaltăieri" }, { -1, "ieri" }, { 0, "azi" }, { 1, "mâine" }, { 2, "poimâine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} zi" }, { PluralRulesValues.Few, "acum {0} zile" }, { PluralRulesValues.Other, "acum {0} de zile" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} zi" }, { PluralRulesValues.Few, "peste {0} zile" }, { PluralRulesValues.Other, "peste {0} de zile" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "zi",
                new Dictionary<int, string> { { -2, "alaltăieri" }, { -1, "ieri" }, { 0, "azi" }, { 1, "mâine" }, { 2, "poimâine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} zi" }, { PluralRulesValues.Few, "-{0} zile" }, { PluralRulesValues.Other, "-{0} zile" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} zi" }, { PluralRulesValues.Few, "+{0} zile" }, { PluralRulesValues.Other, "+{0} zile" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "zi",
                new Dictionary<int, string> { { -2, "alaltăieri" }, { -1, "ieri" }, { 0, "azi" }, { 1, "mâine" }, { 2, "poimâine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} zi" }, { PluralRulesValues.Few, "acum {0} zile" }, { PluralRulesValues.Other, "acum {0} de zile" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} zi" }, { PluralRulesValues.Few, "peste {0} zile" }, { PluralRulesValues.Other, "peste {0} de zile" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "duminica trecută" }, { 0, "duminica aceasta" }, { 1, "duminica viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "duminică, acum {0} săptămână" }, { PluralRulesValues.Few, "duminică, acum {0} săptămâni" }, { PluralRulesValues.Other, "duminică, acum {0} de săptămâni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "duminică, peste {0} săptămână" }, { PluralRulesValues.Few, "duminică, peste {0} săptămâni" }, { PluralRulesValues.Other, "duminică, peste {0} de săptămâni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "du. trecută" }, { 0, "du. aceasta" }, { 1, "du. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "du. -{0} săpt." }, { PluralRulesValues.Few, "du. -{0} săpt." }, { PluralRulesValues.Other, "du. -{0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "du. +{0} săpt." }, { PluralRulesValues.Few, "du. +{0} săpt." }, { PluralRulesValues.Other, "du. +{0} săpt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dum. trecută" }, { 0, "dum. aceasta" }, { 1, "dum. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "duminică, acum {0} săpt." }, { PluralRulesValues.Few, "duminică, acum {0} săpt." }, { PluralRulesValues.Other, "duminică, acum {0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "duminică, peste {0} săpt." }, { PluralRulesValues.Few, "duminică, peste {0} săpt." }, { PluralRulesValues.Other, "duminică, peste {0} săpt." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "lunea trecută" }, { 0, "lunea aceasta" }, { 1, "lunea viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "luni, acum {0} săptămână" }, { PluralRulesValues.Few, "luni, acum {0} săptămâni" }, { PluralRulesValues.Other, "luni, acum {0} de săptămâni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "luni, peste {0} săptămână" }, { PluralRulesValues.Few, "luni, peste {0} săptămâni" }, { PluralRulesValues.Other, "luni, peste {0} de săptămâni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "lu. trecută" }, { 0, "lu. aceasta" }, { 1, "lu. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "lu. -{0} săpt." }, { PluralRulesValues.Few, "lu. -{0} săpt." }, { PluralRulesValues.Other, "lu. -{0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "lu. +{0} săpt." }, { PluralRulesValues.Few, "lu. +{0} săpt." }, { PluralRulesValues.Other, "lu. +{0} săpt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "lun. trecută" }, { 0, "lun. aceasta" }, { 1, "lun. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "luni, acum {0} săpt." }, { PluralRulesValues.Few, "luni, acum {0} săpt." }, { PluralRulesValues.Other, "luni, acum {0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "luni, peste {0} săpt." }, { PluralRulesValues.Few, "luni, peste {0} săpt." }, { PluralRulesValues.Other, "luni, peste {0} săpt." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "marțea trecută" }, { 0, "marțea aceasta" }, { 1, "marțea viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "marți, acum {0} săptămână" }, { PluralRulesValues.Few, "marți, acum {0} săptămâni" }, { PluralRulesValues.Other, "marți, acum {0} de săptămâni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "marți, peste {0} săptămână" }, { PluralRulesValues.Few, "marți, peste {0} săptămâni" }, { PluralRulesValues.Other, "marți, peste {0} de săptămâni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ma. trecută" }, { 0, "ma. aceasta" }, { 1, "ma. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ma. -{0} săpt." }, { PluralRulesValues.Few, "ma. -{0} săpt." }, { PluralRulesValues.Other, "ma. -{0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ma. +{0} săpt." }, { PluralRulesValues.Few, "ma. +{0} săpt." }, { PluralRulesValues.Other, "ma. +{0} săpt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "mar. trecută" }, { 0, "mar. aceasta" }, { 1, "mar. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "marți, acum {0} săpt." }, { PluralRulesValues.Few, "marți, acum {0} săpt." }, { PluralRulesValues.Other, "marți, acum {0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "marți, peste {0} săpt." }, { PluralRulesValues.Few, "marți, peste {0} săpt." }, { PluralRulesValues.Other, "marți, peste {0} săpt." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "miercurea trecută" }, { 0, "miercurea aceasta" }, { 1, "miercurea viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "miercuri, acum {0} săptămână" }, { PluralRulesValues.Few, "miercuri, acum {0} săptămâni" }, { PluralRulesValues.Other, "miercuri, acum {0} de săptămâni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "miercuri, peste {0} săptămână" }, { PluralRulesValues.Few, "miercuri, peste {0} săptămâni" }, { PluralRulesValues.Other, "miercuri, peste {0} de săptămâni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "mi. trecută" }, { 0, "mi. aceasta" }, { 1, "mi. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mi. -{0} săpt." }, { PluralRulesValues.Few, "mi. -{0} săpt." }, { PluralRulesValues.Other, "mi. -{0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mi. +{0} săpt." }, { PluralRulesValues.Few, "mi. +{0} săpt." }, { PluralRulesValues.Other, "mi. +{0} săpt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "mie. trecută" }, { 0, "mie. aceasta" }, { 1, "mie. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "miercuri, acum {0} săpt." }, { PluralRulesValues.Few, "miercuri, acum {0} săpt." }, { PluralRulesValues.Other, "miercuri, acum {0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "miercuri, peste {0} săpt." }, { PluralRulesValues.Few, "miercuri, peste {0} săpt." }, { PluralRulesValues.Other, "miercuri, peste {0} săpt." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "joia trecută" }, { 0, "joia aceasta" }, { 1, "joia viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "joi, acum {0} săptămână" }, { PluralRulesValues.Few, "joi, acum {0} săptămâni" }, { PluralRulesValues.Other, "joi, acum {0} de săptămâni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "joi, peste {0} săptămână" }, { PluralRulesValues.Few, "joi, peste {0} săptămâni" }, { PluralRulesValues.Other, "joi, peste {0} de săptămâni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "jo. trecută" }, { 0, "jo. aceasta" }, { 1, "jo. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "jo. -{0} săpt." }, { PluralRulesValues.Few, "jo. -{0} săpt." }, { PluralRulesValues.Other, "jo. -{0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "jo. +{0} săpt." }, { PluralRulesValues.Few, "jo. +{0} săpt." }, { PluralRulesValues.Other, "jo. +{0} săpt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "joia trecută" }, { 0, "joia aceasta" }, { 1, "joia viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "joi, acum {0} săpt." }, { PluralRulesValues.Few, "joi, acum {0} săpt." }, { PluralRulesValues.Other, "joi, acum {0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "joi, peste {0} săpt." }, { PluralRulesValues.Few, "joi, peste {0} săpt." }, { PluralRulesValues.Other, "joi, peste {0} săpt." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "vinerea trecută" }, { 0, "vinerea aceasta" }, { 1, "vinerea viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vineri, acum {0} săptămână" }, { PluralRulesValues.Few, "vineri, acum {0} săptămâni" }, { PluralRulesValues.Other, "vineri, acum {0} de săptămâni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vineri, peste {0} săptămână" }, { PluralRulesValues.Few, "vineri, peste {0} săptămâni" }, { PluralRulesValues.Other, "vineri, peste {0} de săptămâni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "vi. trecută" }, { 0, "vi. aceasta" }, { 1, "vi. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vi. -{0} săpt." }, { PluralRulesValues.Few, "vi. -{0} săpt." }, { PluralRulesValues.Other, "vi. -{0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vi. +{0} săpt." }, { PluralRulesValues.Few, "vi. +{0} săpt." }, { PluralRulesValues.Other, "vi. +{0} săpt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "vin. trecută" }, { 0, "vin. aceasta" }, { 1, "vin. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vineri, acum {0} săpt." }, { PluralRulesValues.Few, "vineri, acum {0} săpt." }, { PluralRulesValues.Other, "vineri, acum {0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vineri, peste {0} săpt." }, { PluralRulesValues.Few, "vineri, peste {0} săpt." }, { PluralRulesValues.Other, "vineri, peste {0} săpt." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sâmbăta trecută" }, { 0, "sâmbăta aceasta" }, { 1, "sâmbăta viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "sâmbătă, acum {0} săptămână" }, { PluralRulesValues.Few, "sâmbătă, acum {0} săptămâni" }, { PluralRulesValues.Other, "sâmbătă, acum {0} de săptămâni" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "sâmbătă, peste {0} săptămână" }, { PluralRulesValues.Few, "sâmbătă, peste {0} săptămâni" }, { PluralRulesValues.Other, "sâmbătă, peste {0} de săptămâni" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sâ. trecută" }, { 0, "sâ. aceasta" }, { 1, "sâ. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "sâ. -{0} săpt." }, { PluralRulesValues.Few, "sâ. -{0} săpt." }, { PluralRulesValues.Other, "sâ. -{0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "sâ. +{0} săpt." }, { PluralRulesValues.Few, "sâ. +{0} săpt." }, { PluralRulesValues.Other, "sâ. +{0} săpt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sâm. trecută" }, { 0, "sâm. aceasta" }, { 1, "sâm. viitoare" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "sâmbătă, acum {0} săpt." }, { PluralRulesValues.Few, "sâmbătă, acum {0} săpt." }, { PluralRulesValues.Other, "sâmbătă, acum {0} săpt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "sâmbătă, peste {0} săpt." }, { PluralRulesValues.Few, "sâmbătă, peste {0} săpt." }, { PluralRulesValues.Other, "sâmbătă, peste {0} săpt." } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "oră",
                new Dictionary<int, string> { { 0, "ora aceasta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} oră" }, { PluralRulesValues.Few, "acum {0} ore" }, { PluralRulesValues.Other, "acum {0} de ore" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} oră" }, { PluralRulesValues.Few, "peste {0} ore" }, { PluralRulesValues.Other, "peste {0} de ore" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "h",
                new Dictionary<int, string> { { 0, "ora aceasta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} h" }, { PluralRulesValues.Few, "-{0} h" }, { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} h" }, { PluralRulesValues.Few, "+{0} h" }, { PluralRulesValues.Other, "+{0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "h",
                new Dictionary<int, string> { { 0, "ora aceasta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} h" }, { PluralRulesValues.Few, "acum {0} h" }, { PluralRulesValues.Other, "acum {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} h" }, { PluralRulesValues.Few, "peste {0} h" }, { PluralRulesValues.Other, "peste {0} h" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "minut",
                new Dictionary<int, string> { { 0, "minutul acesta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} minut" }, { PluralRulesValues.Few, "acum {0} minute" }, { PluralRulesValues.Other, "acum {0} de minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} minut" }, { PluralRulesValues.Few, "peste {0} minute" }, { PluralRulesValues.Other, "peste {0} de minute" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "m",
                new Dictionary<int, string> { { 0, "minutul acesta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} m" }, { PluralRulesValues.Few, "-{0} m" }, { PluralRulesValues.Other, "-{0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} m" }, { PluralRulesValues.Few, "+{0} m" }, { PluralRulesValues.Other, "+{0} m" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "min.",
                new Dictionary<int, string> { { 0, "minutul acesta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} min." }, { PluralRulesValues.Few, "acum {0} min." }, { PluralRulesValues.Other, "acum {0} min." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} min." }, { PluralRulesValues.Few, "peste {0} min." }, { PluralRulesValues.Other, "peste {0} min." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Romanian' [ro]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "secundă",
                new Dictionary<int, string> { { 0, "acum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} secundă" }, { PluralRulesValues.Few, "acum {0} secunde" }, { PluralRulesValues.Other, "acum {0} de secunde" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} secundă" }, { PluralRulesValues.Few, "peste {0} secunde" }, { PluralRulesValues.Other, "peste {0} de secunde" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "acum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} s" }, { PluralRulesValues.Few, "-{0} s" }, { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} s" }, { PluralRulesValues.Few, "+{0} s" }, { PluralRulesValues.Other, "+{0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "sec.",
                new Dictionary<int, string> { { 0, "acum" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} sec." }, { PluralRulesValues.Few, "acum {0} sec." }, { PluralRulesValues.Other, "acum {0} sec." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} sec." }, { PluralRulesValues.Few, "peste {0} sec." }, { PluralRulesValues.Other, "peste {0} sec." } }));

        /// <summary>
        /// Gets the Relative Time resource styles based on the unit specified
        /// </summary>
        /// <param name="relativeTimeUnit">The resource unit to get</param>
        /// <returns>An <see cref="IRelativeTimeStylesResource"/></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IRelativeTimeStylesResource GetRelativeTimeStylesResource(RelativeTimeUnitValues relativeTimeUnit) => relativeTimeUnit switch
        {
            RelativeTimeUnitValues.Year => this.Year,
            RelativeTimeUnitValues.Quarter => this.Quarter,
            RelativeTimeUnitValues.Month => this.Month,
            RelativeTimeUnitValues.Week => this.Week,
            RelativeTimeUnitValues.Day => this.Day,
            RelativeTimeUnitValues.Sunday => this.Sunday,
            RelativeTimeUnitValues.Monday => this.Monday,
            RelativeTimeUnitValues.Tuesday => this.Tuesday,
            RelativeTimeUnitValues.Wednesday => this.Wednesday,
            RelativeTimeUnitValues.Thursday => this.Thursday,
            RelativeTimeUnitValues.Friday => this.Friday,
            RelativeTimeUnitValues.Saturday => this.Saturday,
            RelativeTimeUnitValues.Hour => this.Hour,
            RelativeTimeUnitValues.Minute => this.Minute,
            RelativeTimeUnitValues.Second => this.Second,
            _ => throw new NotImplementedException($"Relative time unit '{relativeTimeUnit}' is not supported")
        };
    }
}