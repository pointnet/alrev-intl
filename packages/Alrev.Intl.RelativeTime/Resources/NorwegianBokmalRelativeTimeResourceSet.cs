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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Norwegian Bokm&#229;l' [nb]
    /// </summary>
    public class NorwegianBokmalRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "nb";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "år",
                new Dictionary<int, string> { { -1, "i fjor" }, { 0, "i år" }, { 1, "neste år" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} år siden" }, { PluralRulesValues.Other, "for {0} år siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} år" }, { PluralRulesValues.Other, "om {0} år" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "år",
                new Dictionary<int, string> { { -1, "i fjor" }, { 0, "i år" }, { 1, "neste år" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "–{0} år" }, { PluralRulesValues.Other, "–{0} år" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} år" }, { PluralRulesValues.Other, "+{0} år" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "år",
                new Dictionary<int, string> { { -1, "i fjor" }, { 0, "i år" }, { 1, "neste år" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} år siden" }, { PluralRulesValues.Other, "for {0} år siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} år" }, { PluralRulesValues.Other, "om {0} år" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "kvartal",
                new Dictionary<int, string> { { -1, "forrige kvartal" }, { 0, "dette kvartalet" }, { 1, "neste kvartal" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} kvartal siden" }, { PluralRulesValues.Other, "for {0} kvartaler siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} kvartal" }, { PluralRulesValues.Other, "om {0} kvartaler" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "kv.",
                new Dictionary<int, string> { { -1, "forrige kv." }, { 0, "dette kv." }, { 1, "neste kv." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "–{0} kv." }, { PluralRulesValues.Other, "–{0} kv." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} kv." }, { PluralRulesValues.Other, "+{0} kv." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "kv.",
                new Dictionary<int, string> { { -1, "forrige kv." }, { 0, "dette kv." }, { 1, "neste kv." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} kv. siden" }, { PluralRulesValues.Other, "for {0} kv. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} kv." }, { PluralRulesValues.Other, "om {0} kv." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "måned",
                new Dictionary<int, string> { { -1, "forrige måned" }, { 0, "denne måneden" }, { 1, "neste måned" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} måned siden" }, { PluralRulesValues.Other, "for {0} måneder siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} måned" }, { PluralRulesValues.Other, "om {0} måneder" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "md.",
                new Dictionary<int, string> { { -1, "forrige md." }, { 0, "denne md." }, { 1, "neste md." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} md." }, { PluralRulesValues.Other, "-{0} md." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} md." }, { PluralRulesValues.Other, "+{0} md." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "mnd.",
                new Dictionary<int, string> { { -1, "forrige md." }, { 0, "denne md." }, { 1, "neste md." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} md. siden" }, { PluralRulesValues.Other, "for {0} md. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} md." }, { PluralRulesValues.Other, "om {0} md." } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "uke",
                new Dictionary<int, string> { { -1, "forrige uke" }, { 0, "denne uken" }, { 1, "neste uke" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} uke siden" }, { PluralRulesValues.Other, "for {0} uker siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} uke" }, { PluralRulesValues.Other, "om {0} uker" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "u.",
                new Dictionary<int, string> { { -1, "forrige uke" }, { 0, "denne uken" }, { 1, "neste uke" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} u." }, { PluralRulesValues.Other, "-{0} u." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} u." }, { PluralRulesValues.Other, "+{0} u." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "uke",
                new Dictionary<int, string> { { -1, "forrige uke" }, { 0, "denne uken" }, { 1, "neste uke" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} u. siden" }, { PluralRulesValues.Other, "for {0} u. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} u." }, { PluralRulesValues.Other, "om {0} u." } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "dag",
                new Dictionary<int, string> { { -2, "i forgårs" }, { -1, "i går" }, { 0, "i dag" }, { 1, "i morgen" }, { 2, "i overmorgen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} døgn siden" }, { PluralRulesValues.Other, "for {0} døgn siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} døgn" }, { PluralRulesValues.Other, "om {0} døgn" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "d.",
                new Dictionary<int, string> { { -2, "-2 d." }, { -1, "i går" }, { 0, "i dag" }, { 1, "i morgen" }, { 2, "+2 d." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} d." }, { PluralRulesValues.Other, "-{0} d." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} d." }, { PluralRulesValues.Other, "+{0} d." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "dag",
                new Dictionary<int, string> { { -2, "i forgårs" }, { -1, "i går" }, { 0, "i dag" }, { 1, "i morgen" }, { 2, "i overmorgen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} d. siden" }, { PluralRulesValues.Other, "for {0} d. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} d." }, { PluralRulesValues.Other, "om {0} d." } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "forrige søndag" }, { 0, "søndag" }, { 1, "neste søndag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} søndag siden" }, { PluralRulesValues.Other, "for {0} søndager siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} søndag" }, { PluralRulesValues.Other, "om {0} søndager" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sist sø." }, { 0, "denne sø." }, { 1, "neste sø." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sø. siden" }, { PluralRulesValues.Other, "for {0} sø. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sø." }, { PluralRulesValues.Other, "om {0} sø." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sist søn." }, { 0, "denne søn." }, { 1, "neste søn." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} søn. siden" }, { PluralRulesValues.Other, "for {0} søn. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} søn." }, { PluralRulesValues.Other, "om {0} søn." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "forrige mandag" }, { 0, "mandag" }, { 1, "neste mandag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} mandag siden" }, { PluralRulesValues.Other, "for {0} mandager siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} mandag" }, { PluralRulesValues.Other, "om {0} mandager" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sist ma." }, { 0, "denne ma." }, { 1, "neste ma." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} ma. siden" }, { PluralRulesValues.Other, "for {0} ma. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ma." }, { PluralRulesValues.Other, "om {0} ma." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sist man." }, { 0, "denne man." }, { 1, "neste man." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} man. siden" }, { PluralRulesValues.Other, "for {0} man. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} man." }, { PluralRulesValues.Other, "om {0} man." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "forrige tirsdag" }, { 0, "tirsdag" }, { 1, "neste tirsdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} tirsdag siden" }, { PluralRulesValues.Other, "for {0} tirsdager siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} tirsdag" }, { PluralRulesValues.Other, "om {0} tirsdager" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sist ti." }, { 0, "denne ti." }, { 1, "neste ti." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} ti. siden" }, { PluralRulesValues.Other, "for {0} ti. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ti." }, { PluralRulesValues.Other, "om {0} ti." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sist tir." }, { 0, "denne tir." }, { 1, "neste tir." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} tir. siden" }, { PluralRulesValues.Other, "for {0} tir. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} tir." }, { PluralRulesValues.Other, "om {0} tir." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "forrige onsdag" }, { 0, "onsdag" }, { 1, "neste onsdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} onsdag siden" }, { PluralRulesValues.Other, "for {0} onsdager siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} onsdag" }, { PluralRulesValues.Other, "om {0} onsdager" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sist on." }, { 0, "denne on." }, { 1, "neste on." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} on. siden" }, { PluralRulesValues.Other, "for {0} on. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} on." }, { PluralRulesValues.Other, "om {0} on." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sist ons." }, { 0, "denne ons." }, { 1, "neste ons." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} ons. siden" }, { PluralRulesValues.Other, "for {0} ons. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ons." }, { PluralRulesValues.Other, "om {0} ons." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "forrige torsdag" }, { 0, "torsdag" }, { 1, "neste torsdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} torsdag siden" }, { PluralRulesValues.Other, "for {0} torsdager siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} torsdag" }, { PluralRulesValues.Other, "om {0} torsdager" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sist to." }, { 0, "denne to." }, { 1, "neste to." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} to. siden" }, { PluralRulesValues.Other, "for {0} to. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} to." }, { PluralRulesValues.Other, "om {0} to." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sist tor." }, { 0, "denne tor." }, { 1, "neste tor." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} tor. siden" }, { PluralRulesValues.Other, "for {0} tor. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} tor." }, { PluralRulesValues.Other, "om {0} tor." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "forrige fredag" }, { 0, "fredag" }, { 1, "neste fredag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} fredag siden" }, { PluralRulesValues.Other, "for {0} fredager siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} fredag" }, { PluralRulesValues.Other, "om {0} fredager" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sist fr." }, { 0, "denne fr." }, { 1, "neste fr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} fr. siden" }, { PluralRulesValues.Other, "for {0} fr. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} fr." }, { PluralRulesValues.Other, "om {0} fr." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sist fre." }, { 0, "denne fre." }, { 1, "neste fre." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} fre. siden" }, { PluralRulesValues.Other, "for {0} fre. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} fre." }, { PluralRulesValues.Other, "om {0} fre." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "forrige lørdag" }, { 0, "lørdag" }, { 1, "neste lørdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} lørdag siden" }, { PluralRulesValues.Other, "for {0} lørdager siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} lørdag" }, { PluralRulesValues.Other, "om {0} lørdager" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sist lø." }, { 0, "denne lø." }, { 1, "neste lø." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} lø. siden" }, { PluralRulesValues.Other, "for {0} lø. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} lø." }, { PluralRulesValues.Other, "om {0} lø." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sist lør." }, { 0, "denne lør." }, { 1, "neste lør." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} lør. siden" }, { PluralRulesValues.Other, "for {0} lør. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} lør." }, { PluralRulesValues.Other, "om {0} lør." } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "time",
                new Dictionary<int, string> { { 0, "denne timen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} time siden" }, { PluralRulesValues.Other, "for {0} timer siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} time" }, { PluralRulesValues.Other, "om {0} timer" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "t",
                new Dictionary<int, string> { { 0, "denne timen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} t" }, { PluralRulesValues.Other, "-{0} t" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} t" }, { PluralRulesValues.Other, "+{0} t" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "t",
                new Dictionary<int, string> { { 0, "denne timen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} t siden" }, { PluralRulesValues.Other, "for {0} t siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} t" }, { PluralRulesValues.Other, "om {0} t" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "minutt",
                new Dictionary<int, string> { { 0, "dette minuttet" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} minutt siden" }, { PluralRulesValues.Other, "for {0} minutter siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} minutt" }, { PluralRulesValues.Other, "om {0} minutter" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "m",
                new Dictionary<int, string> { { 0, "dette minuttet" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} min" }, { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} min" }, { PluralRulesValues.Other, "+{0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "dette minuttet" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} min siden" }, { PluralRulesValues.Other, "for {0} min siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} min" }, { PluralRulesValues.Other, "om {0} min" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Norwegian Bokm&#229;l' [nb]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "sekund",
                new Dictionary<int, string> { { 0, "nå" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sekund siden" }, { PluralRulesValues.Other, "for {0} sekunder siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sekund" }, { PluralRulesValues.Other, "om {0} sekunder" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "nå" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} s" }, { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} s" }, { PluralRulesValues.Other, "+{0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "sek",
                new Dictionary<int, string> { { 0, "nå" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sek siden" }, { PluralRulesValues.Other, "for {0} sek siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sek" }, { PluralRulesValues.Other, "om {0} sek" } }));

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