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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Afrikaans' [af]
    /// </summary>
    public class AfrikaansRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "af";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "era",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "jaar",
                new Dictionary<int, string> { { -1, "verlede jaar" }, { 0, "hierdie jaar" }, { 1, "volgende jaar" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jaar gelede" }, { PluralRulesValues.Other, "{0} jaar gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} jaar" }, { PluralRulesValues.Other, "oor {0} jaar" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "j.",
                new Dictionary<int, string> { { -1, "verlede j." }, { 0, "hierdie j." }, { 1, "volgende j." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} j. gelede" }, { PluralRulesValues.Other, "{0} j. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} j." }, { PluralRulesValues.Other, "oor {0} j." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "j.",
                new Dictionary<int, string> { { -1, "verlede j." }, { 0, "hierdie j." }, { 1, "volgende j." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} j. gelede" }, { PluralRulesValues.Other, "{0} j. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} j." }, { PluralRulesValues.Other, "oor {0} j." } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "kwartaal",
                new Dictionary<int, string> { { -1, "verlede kwartaal" }, { 0, "hierdie kwartaal" }, { 1, "volgende kwartaal" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kwartaal gelede" }, { PluralRulesValues.Other, "{0} kwartale gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} kwartaal" }, { PluralRulesValues.Other, "oor {0} kwartale" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "kw.",
                new Dictionary<int, string> { { -1, "verlede kwartaal" }, { 0, "hierdie kwartaal" }, { 1, "volgende kwartaal" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kw. gelede" }, { PluralRulesValues.Other, "{0} kw. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} kw." }, { PluralRulesValues.Other, "oor {0} kw." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "kw.",
                new Dictionary<int, string> { { -1, "verlede kwartaal" }, { 0, "hierdie kwartaal" }, { 1, "volgende kwartaal" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kw. gelede" }, { PluralRulesValues.Other, "{0} kw. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} kw." }, { PluralRulesValues.Other, "oor {0} kw." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "maand",
                new Dictionary<int, string> { { -1, "verlede maand" }, { 0, "vandeesmaand" }, { 1, "volgende maand" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maand gelede" }, { PluralRulesValues.Other, "{0} maande gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} maand" }, { PluralRulesValues.Other, "oor {0} maande" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "md.",
                new Dictionary<int, string> { { -1, "verlede md." }, { 0, "hierdie md." }, { 1, "volgende md." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} md. gelede" }, { PluralRulesValues.Other, "{0} md. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} md." }, { PluralRulesValues.Other, "oor {0} md." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "md.",
                new Dictionary<int, string> { { -1, "verlede md." }, { 0, "hierdie md." }, { 1, "volgende md." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} md. gelede" }, { PluralRulesValues.Other, "{0} md. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} md." }, { PluralRulesValues.Other, "oor {0} md." } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "week",
                new Dictionary<int, string> { { -1, "verlede week" }, { 0, "hierdie week" }, { 1, "volgende week" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} week gelede" }, { PluralRulesValues.Other, "{0} weke gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} week" }, { PluralRulesValues.Other, "oor {0} weke" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "wk.",
                new Dictionary<int, string> { { -1, "verlede w." }, { 0, "hierdie w." }, { 1, "volgende w." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} w. gelede" }, { PluralRulesValues.Other, "{0} w. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} w." }, { PluralRulesValues.Other, "oor {0} w." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "wk.",
                new Dictionary<int, string> { { -1, "verlede w." }, { 0, "hierdie w." }, { 1, "volgende w." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} w. gelede" }, { PluralRulesValues.Other, "{0} w. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} w." }, { PluralRulesValues.Other, "oor {0} w." } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "week van maand",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "wk. v. md.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "wk. v. md.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dag",
                new Dictionary<int, string> { { -2, "eergister" }, { -1, "gister" }, { 0, "vandag" }, { 1, "môre" }, { 2, "oormôre" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag gelede" }, { PluralRulesValues.Other, "{0} dae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} dag" }, { PluralRulesValues.Other, "oor {0} dae" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "d.",
                new Dictionary<int, string> { { -2, "eergister" }, { -1, "gister" }, { 0, "vandag" }, { 1, "môre" }, { 2, "oormôre" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag gelede" }, { PluralRulesValues.Other, "{0} dae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} dag" }, { PluralRulesValues.Other, "oor {0} dae" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "d.",
                new Dictionary<int, string> { { -2, "eergister" }, { -1, "gister" }, { 0, "vandag" }, { 1, "môre" }, { 2, "oormôre" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag gelede" }, { PluralRulesValues.Other, "{0} dae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} dag" }, { PluralRulesValues.Other, "oor {0} dae" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dag van jaar",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dag van j.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dag van j.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dag van die week",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dag van wk.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dag van wk.",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "weekdag van die jaar",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "wk.-dag van md.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "wk.-dag van md.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "verlede Sondag" }, { 0, "hierdie Sondag" }, { 1, "volgende Sondag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sondag gelede" }, { PluralRulesValues.Other, "{0} Sondae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Sondag" }, { PluralRulesValues.Other, "oor {0} Sondae" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "verlede So." }, { 0, "hierdie So." }, { 1, "volgende So." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} So. gelede" }, { PluralRulesValues.Other, "{0} So. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} So." }, { PluralRulesValues.Other, "oor {0} So." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "verlede So." }, { 0, "hierdie So." }, { 1, "volgende So." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} So. gelede" }, { PluralRulesValues.Other, "{0} So. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} So." }, { PluralRulesValues.Other, "oor {0} So." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "verlede Maandag" }, { 0, "hierdie Maandag" }, { 1, "volgende Maandag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Maandag gelede" }, { PluralRulesValues.Other, "{0} Maandae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Maandag" }, { PluralRulesValues.Other, "oor {0} Maandae" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "verlede Ma." }, { 0, "hierdie Ma." }, { 1, "volgende Ma." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ma. gelede" }, { PluralRulesValues.Other, "{0} Ma. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Ma." }, { PluralRulesValues.Other, "oor {0} Ma." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "verlede Ma." }, { 0, "hierdie Ma." }, { 1, "volgende Ma." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ma. gelede" }, { PluralRulesValues.Other, "{0} Ma. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Ma." }, { PluralRulesValues.Other, "oor {0} Ma." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "verlede Dinsdag" }, { 0, "hierdie Dinsdag" }, { 1, "volgende Dinsdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Dinsdag gelede" }, { PluralRulesValues.Other, "{0} Dinsdae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Dinsdag" }, { PluralRulesValues.Other, "oor {0} Dinsdae" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "verlede Di." }, { 0, "dié Di." }, { 1, "volgende Di." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Di. gelede" }, { PluralRulesValues.Other, "{0} Di. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Di." }, { PluralRulesValues.Other, "oor {0} Di." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "verlede Di." }, { 0, "hierdie Di." }, { 1, "volgende Di." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Di. gelede" }, { PluralRulesValues.Other, "{0} Di. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Di." }, { PluralRulesValues.Other, "oor {0} Di." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "verlede Woensdag" }, { 0, "hierdie Woensdag" }, { 1, "volgende Woensdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Woensdag gelede" }, { PluralRulesValues.Other, "{0} Woensdae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Woensdag" }, { PluralRulesValues.Other, "oor {0} Woensdae" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "verlede Wo." }, { 0, "dié Wo." }, { 1, "vlg. Wo." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Wo. gelede" }, { PluralRulesValues.Other, "{0} Wo. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Wo." }, { PluralRulesValues.Other, "oor {0} Wo." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "verlede Wo." }, { 0, "hierdie Wo." }, { 1, "volgende Wo." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Wo. gelede" }, { PluralRulesValues.Other, "{0} Wo. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Wo." }, { PluralRulesValues.Other, "oor {0} Wo." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "verlede Donderdag" }, { 0, "hierdie Donderdag" }, { 1, "volgende Donderdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Donderdag gelede" }, { PluralRulesValues.Other, "{0} Donderdae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Donderdag" }, { PluralRulesValues.Other, "oor {0} Donderdae" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "verlede Do." }, { 0, "dié Do." }, { 1, "vlg. Do." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Do. gelede" }, { PluralRulesValues.Other, "{0} Do. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Do." }, { PluralRulesValues.Other, "oor {0} Do." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "verlede Do." }, { 0, "hierdie Do." }, { 1, "volgende Do." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Do. gelede" }, { PluralRulesValues.Other, "{0} Do. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Do." }, { PluralRulesValues.Other, "oor {0} Do." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "verlede Vrydag" }, { 0, "hierdie Vrydag" }, { 1, "volgende Vrydag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Vrydag gelede" }, { PluralRulesValues.Other, "{0} Vrydae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Vrydag" }, { PluralRulesValues.Other, "oor {0} Vrydae" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "verlede Vr." }, { 0, "hierdie Vr." }, { 1, "volgende Vr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Vr. gelede" }, { PluralRulesValues.Other, "{0} Vr. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Vr." }, { PluralRulesValues.Other, "oor {0} Vr." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "verlede Vr." }, { 0, "hierdie Vr." }, { 1, "vlg. Vr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Vr. gelede" }, { PluralRulesValues.Other, "{0} Vr. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Vr." }, { PluralRulesValues.Other, "oor {0} Vr." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "verlede Saterdag" }, { 0, "hierdie Saterdag" }, { 1, "volgende Saterdag" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Saterdag gelede" }, { PluralRulesValues.Other, "{0} Saterdae gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Saterdag" }, { PluralRulesValues.Other, "oor {0} Saterdae" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "verlede Sa." }, { 0, "hierdie Sa." }, { 1, "volgende Sa." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sa. gelede" }, { PluralRulesValues.Other, "{0} Sa. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Sa." }, { PluralRulesValues.Other, "oor {0} Sa." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "verlede Sa." }, { 0, "dié Sa." }, { 1, "volgende Sa." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sa. gelede" }, { PluralRulesValues.Other, "{0} Sa. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} Sa." }, { PluralRulesValues.Other, "oor {0} Sa." } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "vm./nm.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "vm./nm.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "vm./nm.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "uur",
                new Dictionary<int, string> { { 0, "hierdie uur" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} uur gelede" }, { PluralRulesValues.Other, "{0} uur gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} uur" }, { PluralRulesValues.Other, "oor {0} uur" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "u.",
                new Dictionary<int, string> { { 0, "hierdie uur" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} u. gelede" }, { PluralRulesValues.Other, "{0} u. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} u." }, { PluralRulesValues.Other, "oor {0} u." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "u.",
                new Dictionary<int, string> { { 0, "hierdie uur" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} u. gelede" }, { PluralRulesValues.Other, "{0} u. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} u." }, { PluralRulesValues.Other, "oor {0} u." } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "minuut",
                new Dictionary<int, string> { { 0, "hierdie minuut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuut gelede" }, { PluralRulesValues.Other, "{0} minute gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} minuut" }, { PluralRulesValues.Other, "oor {0} minute" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "m.",
                new Dictionary<int, string> { { 0, "hierdie minuut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. gelede" }, { PluralRulesValues.Other, "{0} min. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} min." }, { PluralRulesValues.Other, "oor {0} min." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "min.",
                new Dictionary<int, string> { { 0, "hierdie minuut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. gelede" }, { PluralRulesValues.Other, "{0} min. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} min." }, { PluralRulesValues.Other, "oor {0} min." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "sekonde",
                new Dictionary<int, string> { { 0, "nou" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekonde gelede" }, { PluralRulesValues.Other, "{0} sekondes gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} sekonde" }, { PluralRulesValues.Other, "oor {0} sekondes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "s.",
                new Dictionary<int, string> { { 0, "nou" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} s. gelede" }, { PluralRulesValues.Other, "{0} s. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} s." }, { PluralRulesValues.Other, "oor {0} s." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "s.",
                new Dictionary<int, string> { { 0, "nou" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} s. gelede" }, { PluralRulesValues.Other, "{0} s. gelede" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "oor {0} s." }, { PluralRulesValues.Other, "oor {0} s." } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Afrikaans' [af]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "tydsone",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "sone",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sone",
                null,
                null,
                null));
    }
}