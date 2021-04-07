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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Danish (Greenland)' [da-GL]
    /// </summary>
    public class DanishGreenlandRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "da-GL";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "æra",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "æra",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "æra",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "år",
                new Dictionary<int, string> { { -1, "sidste år" }, { 0, "i år" }, { 1, "næste år" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} år siden" }, { PluralRulesValues.Other, "for {0} år siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} år" }, { PluralRulesValues.Other, "om {0} år" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "år",
                new Dictionary<int, string> { { -1, "sidste år" }, { 0, "i år" }, { 1, "næste år" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} år siden" }, { PluralRulesValues.Other, "{0} år siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} år" }, { PluralRulesValues.Other, "om {0} år" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "år",
                new Dictionary<int, string> { { -1, "sidste år" }, { 0, "i år" }, { 1, "næste år" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} år siden" }, { PluralRulesValues.Other, "{0} år siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} år" }, { PluralRulesValues.Other, "om {0} år" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "kvartal",
                new Dictionary<int, string> { { -1, "sidste kvartal" }, { 0, "dette kvartal" }, { 1, "næste kvartal" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} kvartal siden" }, { PluralRulesValues.Other, "for {0} kvartaler siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} kvartal" }, { PluralRulesValues.Other, "om {0} kvartaler" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "kvt.",
                new Dictionary<int, string> { { -1, "sidste kvt." }, { 0, "dette kvt." }, { 1, "næste kvt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kvt. siden" }, { PluralRulesValues.Other, "{0} kvt. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} kvt." }, { PluralRulesValues.Other, "om {0} kvt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "kvt.",
                new Dictionary<int, string> { { -1, "sidste kvt." }, { 0, "dette kvt." }, { 1, "næste kvt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kvt. siden" }, { PluralRulesValues.Other, "{0} kvt. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} kvt." }, { PluralRulesValues.Other, "om {0} kvt." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "måned",
                new Dictionary<int, string> { { -1, "sidste måned" }, { 0, "denne måned" }, { 1, "næste måned" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} måned siden" }, { PluralRulesValues.Other, "for {0} måneder siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} måned" }, { PluralRulesValues.Other, "om {0} måneder" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "md.",
                new Dictionary<int, string> { { -1, "sidste md." }, { 0, "denne md." }, { 1, "næste md." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} md. siden" }, { PluralRulesValues.Other, "{0} mdr. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} md." }, { PluralRulesValues.Other, "om {0} mdr." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "md.",
                new Dictionary<int, string> { { -1, "sidste md." }, { 0, "denne md." }, { 1, "næste md." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} md. siden" }, { PluralRulesValues.Other, "{0} mdr. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} md." }, { PluralRulesValues.Other, "om {0} mdr." } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "uge",
                new Dictionary<int, string> { { -1, "sidste uge" }, { 0, "denne uge" }, { 1, "næste uge" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} uge siden" }, { PluralRulesValues.Other, "for {0} uger siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} uge" }, { PluralRulesValues.Other, "om {0} uger" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "uge",
                new Dictionary<int, string> { { -1, "sidste uge" }, { 0, "denne uge" }, { 1, "næste uge" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} uge siden" }, { PluralRulesValues.Other, "{0} uger siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} uge" }, { PluralRulesValues.Other, "om {0} uger" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "uge",
                new Dictionary<int, string> { { -1, "sidste uge" }, { 0, "denne uge" }, { 1, "næste uge" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} uge siden" }, { PluralRulesValues.Other, "{0} uger siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} uge" }, { PluralRulesValues.Other, "om {0} uger" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "uge i måneden",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "uge i md.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "uge i md.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dag",
                new Dictionary<int, string> { { -2, "i forgårs" }, { -1, "i går" }, { 0, "i dag" }, { 1, "i morgen" }, { 2, "i overmorgen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} dag siden" }, { PluralRulesValues.Other, "for {0} dage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} dag" }, { PluralRulesValues.Other, "om {0} dage" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dag",
                new Dictionary<int, string> { { -2, "i forgårs" }, { -1, "i går" }, { 0, "i dag" }, { 1, "i morgen" }, { 2, "i overmorgen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag siden" }, { PluralRulesValues.Other, "{0} dage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} dag" }, { PluralRulesValues.Other, "om {0} dage" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dag",
                new Dictionary<int, string> { { -2, "i forgårs" }, { -1, "i går" }, { 0, "i dag" }, { 1, "i morgen" }, { 2, "i overmorgen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag siden" }, { PluralRulesValues.Other, "{0} dage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} dag" }, { PluralRulesValues.Other, "om {0} dage" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dag i året",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dag i året",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dag i året",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ugedag",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ugedag",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ugedag",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ugedag i måneden",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ugedag i md.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ugedag i md.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sidste søndag" }, { 0, "på søndag" }, { 1, "på søndag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} søndag siden" }, { PluralRulesValues.Other, "for {0} søndage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} søndag" }, { PluralRulesValues.Other, "om {0} søndage" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sidste sø." }, { 0, "på sø." }, { 1, "på sø." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sø. siden" }, { PluralRulesValues.Other, "{0} sø. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sø." }, { PluralRulesValues.Other, "om {0} sø." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sidste søn." }, { 0, "på søn." }, { 1, "på søn." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} søn. siden" }, { PluralRulesValues.Other, "{0} søn. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} søn." }, { PluralRulesValues.Other, "om {0} søn." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sidste mandag" }, { 0, "på mandag" }, { 1, "på mandag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} mandag siden" }, { PluralRulesValues.Other, "for {0} mandage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} mandag" }, { PluralRulesValues.Other, "om {0} mandage" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sidste ma." }, { 0, "på ma." }, { 1, "på ma." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ma. siden" }, { PluralRulesValues.Other, "{0} ma. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ma." }, { PluralRulesValues.Other, "om {0} ma." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sidste man." }, { 0, "på man." }, { 1, "på man." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} man. siden" }, { PluralRulesValues.Other, "{0} man. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} man." }, { PluralRulesValues.Other, "om {0} man." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sidste tirsdag" }, { 0, "på tirsdag" }, { 1, "på tirsdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} tirsdag siden" }, { PluralRulesValues.Other, "for {0} tirsdage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} tirsdag" }, { PluralRulesValues.Other, "om {0} tirsdage" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sidste ti." }, { 0, "på ti." }, { 1, "på ti." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ti. siden" }, { PluralRulesValues.Other, "{0} ti. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ti." }, { PluralRulesValues.Other, "om {0} ti." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sidste tir." }, { 0, "på tir." }, { 1, "på tir." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tir. siden" }, { PluralRulesValues.Other, "{0} tir. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} tir." }, { PluralRulesValues.Other, "om {0} tir." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sidste onsdag" }, { 0, "på onsdag" }, { 1, "på onsdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} onsdag siden" }, { PluralRulesValues.Other, "for {0} onsdage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} onsdag" }, { PluralRulesValues.Other, "om {0} onsdage" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sidste on." }, { 0, "på on." }, { 1, "på on." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} on. siden" }, { PluralRulesValues.Other, "{0} on. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} on." }, { PluralRulesValues.Other, "om {0} on." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sidste ons." }, { 0, "på ons." }, { 1, "på ons." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ons. siden" }, { PluralRulesValues.Other, "{0} ons. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} ons." }, { PluralRulesValues.Other, "om {0} ons." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sidste torsdag" }, { 0, "på torsdag" }, { 1, "på torsdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} torsdag siden" }, { PluralRulesValues.Other, "for {0} torsdage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} torsdag" }, { PluralRulesValues.Other, "om {0} torsdage" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sidste to." }, { 0, "på to." }, { 1, "på to." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} to. siden" }, { PluralRulesValues.Other, "{0} to. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} to." }, { PluralRulesValues.Other, "om {0} to." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sidste tor." }, { 0, "på tor." }, { 1, "på tor." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tor. siden" }, { PluralRulesValues.Other, "{0} tor. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} tor." }, { PluralRulesValues.Other, "om {0} tor." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sidste fredag" }, { 0, "på fredag" }, { 1, "på fredag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} fredag siden" }, { PluralRulesValues.Other, "for {0} fredage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} fredag" }, { PluralRulesValues.Other, "om {0} fredage" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sidste fr." }, { 0, "på fr." }, { 1, "på fr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} fr. siden" }, { PluralRulesValues.Other, "{0} fr. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} fr." }, { PluralRulesValues.Other, "om {0} fr." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sidste fre." }, { 0, "på fre." }, { 1, "på fre." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} fre. siden" }, { PluralRulesValues.Other, "{0} fre. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} fre." }, { PluralRulesValues.Other, "om {0} fre." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sidste lørdag" }, { 0, "på lørdag" }, { 1, "på lørdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} lørdag siden" }, { PluralRulesValues.Other, "for {0} lørdage siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} lørdag" }, { PluralRulesValues.Other, "om {0} lørdage" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sidste lø." }, { 0, "på lø." }, { 1, "på lø." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} lø. siden" }, { PluralRulesValues.Other, "{0} lø. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} lø." }, { PluralRulesValues.Other, "om {0} lø." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sidste lør." }, { 0, "på lør." }, { 1, "på lør." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} lør. siden" }, { PluralRulesValues.Other, "{0} lør. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} lør." }, { PluralRulesValues.Other, "om {0} lør." } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "AM/PM",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "AM/PM",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "AM/PM",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "time",
                new Dictionary<int, string> { { 0, "denne time" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} time siden" }, { PluralRulesValues.Other, "for {0} timer siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} time" }, { PluralRulesValues.Other, "om {0} timer" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "t.",
                new Dictionary<int, string> { { 0, "denne time" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} time siden" }, { PluralRulesValues.Other, "{0} timer siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} time" }, { PluralRulesValues.Other, "om {0} timer" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "t.",
                new Dictionary<int, string> { { 0, "denne time" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} time siden" }, { PluralRulesValues.Other, "{0} timer siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} time" }, { PluralRulesValues.Other, "om {0} timer" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "minut",
                new Dictionary<int, string> { { 0, "dette minut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} minut siden" }, { PluralRulesValues.Other, "for {0} minutter siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} minut" }, { PluralRulesValues.Other, "om {0} minutter" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "min.",
                new Dictionary<int, string> { { 0, "dette minut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. siden" }, { PluralRulesValues.Other, "{0} min. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} min." }, { PluralRulesValues.Other, "om {0} min." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "min.",
                new Dictionary<int, string> { { 0, "dette minut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. siden" }, { PluralRulesValues.Other, "{0} min. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} min." }, { PluralRulesValues.Other, "om {0} min." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "sekund",
                new Dictionary<int, string> { { 0, "nu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "for {0} sekund siden" }, { PluralRulesValues.Other, "for {0} sekunder siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sekund" }, { PluralRulesValues.Other, "om {0} sekunder" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "nu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek. siden" }, { PluralRulesValues.Other, "{0} sek. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sek." }, { PluralRulesValues.Other, "om {0} sek." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sek.",
                new Dictionary<int, string> { { 0, "nu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek. siden" }, { PluralRulesValues.Other, "{0} sek. siden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "om {0} sek." }, { PluralRulesValues.Other, "om {0} sek." } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Danish (Greenland)' [da-GL]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "tidszone",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "zone",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "zone",
                null,
                null,
                null));
    }
}