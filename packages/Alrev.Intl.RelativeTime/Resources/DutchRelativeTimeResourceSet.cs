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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Dutch' [nl]
    /// </summary>
    public class DutchRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "nl";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "jaar",
                new Dictionary<int, string> { { -1, "vorig jaar" }, { 0, "dit jaar" }, { 1, "volgend jaar" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jaar geleden" }, { PluralRulesValues.Other, "{0} jaar geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} jaar" }, { PluralRulesValues.Other, "over {0} jaar" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "jr",
                new Dictionary<int, string> { { -1, "vorig jaar" }, { 0, "dit jaar" }, { 1, "volgend jaar" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jaar geleden" }, { PluralRulesValues.Other, "{0} jaar geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} jaar" }, { PluralRulesValues.Other, "over {0} jaar" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "jr",
                new Dictionary<int, string> { { -1, "vorig jaar" }, { 0, "dit jaar" }, { 1, "volgend jaar" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jaar geleden" }, { PluralRulesValues.Other, "{0} jaar geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} jaar" }, { PluralRulesValues.Other, "over {0} jaar" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "kwartaal",
                new Dictionary<int, string> { { -1, "vorig kwartaal" }, { 0, "dit kwartaal" }, { 1, "volgend kwartaal" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kwartaal geleden" }, { PluralRulesValues.Other, "{0} kwartalen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} kwartaal" }, { PluralRulesValues.Other, "over {0} kwartalen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "kwartaal",
                new Dictionary<int, string> { { -1, "vorig kwartaal" }, { 0, "dit kwartaal" }, { 1, "volgend kwartaal" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kwartaal geleden" }, { PluralRulesValues.Other, "{0} kwartalen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} kw." }, { PluralRulesValues.Other, "over {0} kwartalen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "kwartaal",
                new Dictionary<int, string> { { -1, "vorig kwartaal" }, { 0, "dit kwartaal" }, { 1, "volgend kwartaal" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kwartaal geleden" }, { PluralRulesValues.Other, "{0} kwartalen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} kwartaal" }, { PluralRulesValues.Other, "over {0} kwartalen" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "maand",
                new Dictionary<int, string> { { -1, "vorige maand" }, { 0, "deze maand" }, { 1, "volgende maand" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maand geleden" }, { PluralRulesValues.Other, "{0} maanden geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maand" }, { PluralRulesValues.Other, "over {0} maanden" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "mnd",
                new Dictionary<int, string> { { -1, "vorige maand" }, { 0, "deze maand" }, { 1, "volgende maand" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maand geleden" }, { PluralRulesValues.Other, "{0} maanden geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maand" }, { PluralRulesValues.Other, "over {0} maanden" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "mnd",
                new Dictionary<int, string> { { -1, "vorige maand" }, { 0, "deze maand" }, { 1, "volgende maand" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maand geleden" }, { PluralRulesValues.Other, "{0} maanden geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maand" }, { PluralRulesValues.Other, "over {0} maanden" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "week",
                new Dictionary<int, string> { { -1, "vorige week" }, { 0, "deze week" }, { 1, "volgende week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} week geleden" }, { PluralRulesValues.Other, "{0} weken geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} week" }, { PluralRulesValues.Other, "over {0} weken" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "wk",
                new Dictionary<int, string> { { -1, "vorige week" }, { 0, "deze week" }, { 1, "volgende week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} week geleden" }, { PluralRulesValues.Other, "{0} weken geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} week" }, { PluralRulesValues.Other, "over {0} weken" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "wk",
                new Dictionary<int, string> { { -1, "vorige week" }, { 0, "deze week" }, { 1, "volgende week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} week geleden" }, { PluralRulesValues.Other, "{0} weken geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} week" }, { PluralRulesValues.Other, "over {0} weken" } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "dag",
                new Dictionary<int, string> { { -2, "eergisteren" }, { -1, "gisteren" }, { 0, "vandaag" }, { 1, "morgen" }, { 2, "overmorgen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag geleden" }, { PluralRulesValues.Other, "{0} dagen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dag" }, { PluralRulesValues.Other, "over {0} dagen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "dag",
                new Dictionary<int, string> { { -2, "eergisteren" }, { -1, "gisteren" }, { 0, "vandaag" }, { 1, "morgen" }, { 2, "overmorgen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag geleden" }, { PluralRulesValues.Other, "{0} dgn geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dag" }, { PluralRulesValues.Other, "over {0} dgn" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "dag",
                new Dictionary<int, string> { { -2, "eergisteren" }, { -1, "gisteren" }, { 0, "vandaag" }, { 1, "morgen" }, { 2, "overmorgen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag geleden" }, { PluralRulesValues.Other, "{0} dgn geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dag" }, { PluralRulesValues.Other, "over {0} dgn" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "afgelopen zondag" }, { 0, "deze zondag" }, { 1, "volgende week zondag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zondag geleden" }, { PluralRulesValues.Other, "{0} zondagen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zondag" }, { PluralRulesValues.Other, "over {0} zondagen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "afgelopen zo" }, { 0, "deze zo" }, { 1, "volgende week zo" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zo geleden" }, { PluralRulesValues.Other, "{0} zo geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zo" }, { PluralRulesValues.Other, "over {0} zo" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "afgelopen zon." }, { 0, "deze zon." }, { 1, "volgende week zon." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zon. geleden" }, { PluralRulesValues.Other, "{0} zon. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zon." }, { PluralRulesValues.Other, "over {0} zon." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "afgelopen maandag" }, { 0, "deze maandag" }, { 1, "volgende week maandag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maandag geleden" }, { PluralRulesValues.Other, "{0} maandagen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maandag" }, { PluralRulesValues.Other, "over {0} maandagen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "afgelopen ma" }, { 0, "deze ma" }, { 1, "volgende week ma" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ma geleden" }, { PluralRulesValues.Other, "{0} ma geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} ma" }, { PluralRulesValues.Other, "over {0} ma" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "afgelopen maan." }, { 0, "deze maan." }, { 1, "volgende week maan." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maan. geleden" }, { PluralRulesValues.Other, "{0} maan. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maan." }, { PluralRulesValues.Other, "over {0} maan." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "afgelopen dinsdag" }, { 0, "deze dinsdag" }, { 1, "volgende week dinsdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dinsdag geleden" }, { PluralRulesValues.Other, "{0} dinsdagen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dinsdag" }, { PluralRulesValues.Other, "over {0} dinsdagen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "afgelopen di" }, { 0, "deze di" }, { 1, "volgende week di" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} di geleden" }, { PluralRulesValues.Other, "{0} di geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} di" }, { PluralRulesValues.Other, "over {0} di" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "afgelopen dins." }, { 0, "deze dins." }, { 1, "volgende week dins." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dins. geleden" }, { PluralRulesValues.Other, "{0} dins. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dins." }, { PluralRulesValues.Other, "over {0} dins." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "afgelopen woensdag" }, { 0, "deze woensdag" }, { 1, "volgende week woensdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} woensdag geleden" }, { PluralRulesValues.Other, "{0} woensdagen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} woensdag" }, { PluralRulesValues.Other, "over {0} woensdagen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "afgelopen wo" }, { 0, "deze wo" }, { 1, "volgende week wo" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} wo geleden" }, { PluralRulesValues.Other, "{0} wo geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} wo" }, { PluralRulesValues.Other, "over {0} wo" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "afgelopen woens." }, { 0, "deze woens." }, { 1, "volgende week woens." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} woens. geleden" }, { PluralRulesValues.Other, "{0} woens. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} woens." }, { PluralRulesValues.Other, "over {0} woens." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "afgelopen donderdag" }, { 0, "deze donderdag" }, { 1, "volgende week donderdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} donderdag geleden" }, { PluralRulesValues.Other, "{0} donderdagen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} donderdag" }, { PluralRulesValues.Other, "over {0} donderdagen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "afgelopen do" }, { 0, "deze do" }, { 1, "volgende week do" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} do geleden" }, { PluralRulesValues.Other, "{0} do geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} do" }, { PluralRulesValues.Other, "over {0} do" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "afgelopen donder." }, { 0, "deze donder." }, { 1, "volgende week donder." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} donder. geleden" }, { PluralRulesValues.Other, "{0} donder. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} donder." }, { PluralRulesValues.Other, "over {0} donder." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "afgelopen vrijdag" }, { 0, "deze vrijdag" }, { 1, "volgende week vrijdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vrijdag geleden" }, { PluralRulesValues.Other, "{0} vrijdagen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} vrijdag" }, { PluralRulesValues.Other, "over {0} vrijdagen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "afgelopen vr" }, { 0, "deze vr" }, { 1, "volgende week vr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vr geleden" }, { PluralRulesValues.Other, "{0} vr geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} vr" }, { PluralRulesValues.Other, "over {0} vr" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "afgelopen vrij." }, { 0, "deze vrij." }, { 1, "volgende week vrij." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vrij. geleden" }, { PluralRulesValues.Other, "{0} vrij. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} vrij." }, { PluralRulesValues.Other, "over {0} vrij." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "afgelopen zaterdag" }, { 0, "deze zaterdag" }, { 1, "volgende week zaterdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zaterdag geleden" }, { PluralRulesValues.Other, "{0} zaterdagen geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zaterdag" }, { PluralRulesValues.Other, "over {0} zaterdagen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "afgelopen za" }, { 0, "deze za" }, { 1, "volgende week za" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} za geleden" }, { PluralRulesValues.Other, "{0} za geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} za" }, { PluralRulesValues.Other, "over {0} za" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "afgelopen zater." }, { 0, "deze zater." }, { 1, "volgende week zater." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zater. geleden" }, { PluralRulesValues.Other, "{0} zater. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zater." }, { PluralRulesValues.Other, "over {0} zater." } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "uur",
                new Dictionary<int, string> { { 0, "binnen een uur" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} uur geleden" }, { PluralRulesValues.Other, "{0} uur geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} uur" }, { PluralRulesValues.Other, "over {0} uur" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "u",
                new Dictionary<int, string> { { 0, "binnen een uur" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} uur geleden" }, { PluralRulesValues.Other, "{0} uur geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} uur" }, { PluralRulesValues.Other, "over {0} uur" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "uur",
                new Dictionary<int, string> { { 0, "binnen een uur" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} uur geleden" }, { PluralRulesValues.Other, "{0} uur geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} uur" }, { PluralRulesValues.Other, "over {0} uur" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "minuut",
                new Dictionary<int, string> { { 0, "binnen een minuut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuut geleden" }, { PluralRulesValues.Other, "{0} minuten geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} minuut" }, { PluralRulesValues.Other, "over {0} minuten" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "binnen een minuut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. geleden" }, { PluralRulesValues.Other, "{0} min. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} min." }, { PluralRulesValues.Other, "over {0} min." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "binnen een minuut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. geleden" }, { PluralRulesValues.Other, "{0} min. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} min." }, { PluralRulesValues.Other, "over {0} min." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Dutch' [nl]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "seconde",
                new Dictionary<int, string> { { 0, "nu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} seconde geleden" }, { PluralRulesValues.Other, "{0} seconden geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} seconde" }, { PluralRulesValues.Other, "over {0} seconden" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "nu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sec. geleden" }, { PluralRulesValues.Other, "{0} sec. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} sec." }, { PluralRulesValues.Other, "over {0} sec." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "sec",
                new Dictionary<int, string> { { 0, "nu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sec. geleden" }, { PluralRulesValues.Other, "{0} sec. geleden" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} sec." }, { PluralRulesValues.Other, "over {0} sec." } }));

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