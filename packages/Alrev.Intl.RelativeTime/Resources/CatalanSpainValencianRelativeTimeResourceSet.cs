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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
    /// </summary>
    public class CatalanSpainValencianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ca-es-valencia";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "any",
                new Dictionary<int, string> { { -1, "l’any passat" }, { 0, "enguany" }, { 1, "l’any que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} any" }, { PluralRulesValues.Other, "fa {0} anys" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} any" }, { PluralRulesValues.Other, "d’aquí a {0} anys" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "any",
                new Dictionary<int, string> { { -1, "l’any passat" }, { 0, "enguany" }, { 1, "l’any que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} any" }, { PluralRulesValues.Other, "fa {0} anys" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} any" }, { PluralRulesValues.Other, "d’aquí a {0} anys" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "any",
                new Dictionary<int, string> { { -1, "l’any passat" }, { 0, "enguany" }, { 1, "l’any que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} any" }, { PluralRulesValues.Other, "fa {0} anys" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} any" }, { PluralRulesValues.Other, "d’aquí a {0} anys" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "trimestre",
                new Dictionary<int, string> { { -1, "el trimestre passat" }, { 0, "aquest trimestre" }, { 1, "el trimestre que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} trimestre" }, { PluralRulesValues.Other, "fa {0} trimestres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} trimestre" }, { PluralRulesValues.Other, "d’aquí a {0} trimestres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "trim.",
                new Dictionary<int, string> { { -1, "trim. passat" }, { 0, "aquest trim." }, { 1, "trim. vinent" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} trim." }, { PluralRulesValues.Other, "fa {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} trim." }, { PluralRulesValues.Other, "d’aquí a {0} trim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "trim.",
                new Dictionary<int, string> { { -1, "el trim. passat" }, { 0, "aquest trim." }, { 1, "el trim. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} trim." }, { PluralRulesValues.Other, "fa {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} trim." }, { PluralRulesValues.Other, "d’aquí a {0} trim." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "mes",
                new Dictionary<int, string> { { -1, "el mes passat" }, { 0, "aquest mes" }, { 1, "el mes que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} mes" }, { PluralRulesValues.Other, "fa {0} mesos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} mes" }, { PluralRulesValues.Other, "d’aquí a {0} mesos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "mes",
                new Dictionary<int, string> { { -1, "el mes passat" }, { 0, "aquest mes" }, { 1, "el mes que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} mes" }, { PluralRulesValues.Other, "fa {0} mesos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} mes" }, { PluralRulesValues.Other, "d’aquí a {0} mesos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "mes",
                new Dictionary<int, string> { { -1, "el mes passat" }, { 0, "aquest mes" }, { 1, "el mes que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} mes" }, { PluralRulesValues.Other, "fa {0} mesos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} mes" }, { PluralRulesValues.Other, "d’aquí a {0} mesos" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "setmana",
                new Dictionary<int, string> { { -1, "la setmana passada" }, { 0, "aquesta setmana" }, { 1, "la setmana que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} setmana" }, { PluralRulesValues.Other, "fa {0} setmanes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} setmana" }, { PluralRulesValues.Other, "d’aquí a {0} setmanes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "setm.",
                new Dictionary<int, string> { { -1, "la setm. passada" }, { 0, "aquesta setm." }, { 1, "la setm. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} setm." }, { PluralRulesValues.Other, "fa {0} setm." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} setm." }, { PluralRulesValues.Other, "d’aquí a {0} setm." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "setm.",
                new Dictionary<int, string> { { -1, "la setm. passada" }, { 0, "aquesta setm." }, { 1, "la setm. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} setm." }, { PluralRulesValues.Other, "fa {0} setm." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} setm." }, { PluralRulesValues.Other, "d’aquí a {0} setm." } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "dia",
                new Dictionary<int, string> { { -2, "abans-d’ahir" }, { -1, "ahir" }, { 0, "avui" }, { 1, "demà" }, { 2, "demà passat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dia" }, { PluralRulesValues.Other, "fa {0} dies" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dia" }, { PluralRulesValues.Other, "d’aquí a {0} dies" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "dia",
                new Dictionary<int, string> { { -2, "abans-d’ahir" }, { -1, "ahir" }, { 0, "avui" }, { 1, "demà" }, { 2, "demà passat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dia" }, { PluralRulesValues.Other, "fa {0} dies" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dia" }, { PluralRulesValues.Other, "d’aquí a {0} dies" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "dia",
                new Dictionary<int, string> { { -2, "abans-d’ahir" }, { -1, "ahir" }, { 0, "avui" }, { 1, "demà" }, { 2, "demà passat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dia" }, { PluralRulesValues.Other, "fa {0} dies" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dia" }, { PluralRulesValues.Other, "d’aquí a {0} dies" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "diumenge passat" }, { 0, "aquest diumenge" }, { 1, "diumenge que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} diumenge" }, { PluralRulesValues.Other, "fa {0} diumenges" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} diumenge" }, { PluralRulesValues.Other, "d’aquí a {0} diumenges" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dg. passat" }, { 0, "aquest dg." }, { 1, "dg. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dg." }, { PluralRulesValues.Other, "fa {0} dg." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dg." }, { PluralRulesValues.Other, "d’aquí a {0} dg." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dg. passat" }, { 0, "aquest dg." }, { 1, "dg. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dg." }, { PluralRulesValues.Other, "fa {0} dg." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dg." }, { PluralRulesValues.Other, "d’aquí a {0} dg." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dilluns passat" }, { 0, "aquest dilluns" }, { 1, "dilluns que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dilluns" }, { PluralRulesValues.Other, "fa {0} dilluns" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dilluns" }, { PluralRulesValues.Other, "d’aquí a {0} dilluns" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dl. passat" }, { 0, "aquest dl." }, { 1, "dl. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dl." }, { PluralRulesValues.Other, "fa {0} dl." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dl." }, { PluralRulesValues.Other, "d’aquí a {0} dl." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dl. passat" }, { 0, "aquest dl." }, { 1, "dl. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dl." }, { PluralRulesValues.Other, "fa {0} dl." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dl." }, { PluralRulesValues.Other, "d’aquí a {0} dl." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dimarts passat" }, { 0, "aquest dimarts" }, { 1, "dimarts que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dimarts" }, { PluralRulesValues.Other, "fa {0} dimarts" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dimarts" }, { PluralRulesValues.Other, "d’aquí a {0} dimarts" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dt. passat" }, { 0, "aquest dt." }, { 1, "dt. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dt." }, { PluralRulesValues.Other, "fa {0} dt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dt." }, { PluralRulesValues.Other, "d’aquí a {0} dt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dt. passat" }, { 0, "aquest dt." }, { 1, "dt. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dt." }, { PluralRulesValues.Other, "fa {0} dt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dt." }, { PluralRulesValues.Other, "d’aquí a {0} dt." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dimecres passat" }, { 0, "aquest dimecres" }, { 1, "dimecres que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dimecres" }, { PluralRulesValues.Other, "fa {0} dimecres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dimecres" }, { PluralRulesValues.Other, "d’aquí a {0} dimecres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dc. passat" }, { 0, "aquest dc." }, { 1, "dc. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dc." }, { PluralRulesValues.Other, "fa {0} dc." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dc." }, { PluralRulesValues.Other, "d’aquí a {0} dc." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dc. passat" }, { 0, "aquest dc." }, { 1, "dc. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dc." }, { PluralRulesValues.Other, "fa {0} dc." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dc." }, { PluralRulesValues.Other, "d’aquí a {0} dc." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dijous passat" }, { 0, "aquest dijous" }, { 1, "dijous que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dijous" }, { PluralRulesValues.Other, "fa {0} dijous" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dijous" }, { PluralRulesValues.Other, "d’aquí a {0} dijous" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dj. passat" }, { 0, "aquest dj." }, { 1, "dj. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dj." }, { PluralRulesValues.Other, "fa {0} dj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dj." }, { PluralRulesValues.Other, "d’aquí a {0} dj." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dj. passat" }, { 0, "aquest dj." }, { 1, "dj. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dj." }, { PluralRulesValues.Other, "fa {0} dj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dj." }, { PluralRulesValues.Other, "d’aquí a {0} dj." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "divendres passat" }, { 0, "aquest divendres" }, { 1, "divendres que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} divendres" }, { PluralRulesValues.Other, "fa {0} divendres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} divendres" }, { PluralRulesValues.Other, "d’aquí a {0} divendres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dv. passat" }, { 0, "aquest dv." }, { 1, "dv. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dv." }, { PluralRulesValues.Other, "fa {0} dv." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dv." }, { PluralRulesValues.Other, "d’aquí a {0} dv." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dv. passat" }, { 0, "aquest dv." }, { 1, "dv. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dv." }, { PluralRulesValues.Other, "fa {0} dv." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dv." }, { PluralRulesValues.Other, "d’aquí a {0} dv." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dissabte passat" }, { 0, "aquest dissabte" }, { 1, "dissabte que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dissabte" }, { PluralRulesValues.Other, "fa {0} dissabtes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dissabte" }, { PluralRulesValues.Other, "d’aquí a {0} dissabtes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ds. passat" }, { 0, "aquest ds." }, { 1, "ds. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} ds." }, { PluralRulesValues.Other, "fa {0} ds." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} ds." }, { PluralRulesValues.Other, "d’aquí a {0} ds." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ds. passat" }, { 0, "aquest ds." }, { 1, "ds. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} ds." }, { PluralRulesValues.Other, "fa {0} ds." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} ds." }, { PluralRulesValues.Other, "d’aquí a {0} ds." } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "hora",
                new Dictionary<int, string> { { 0, "aquesta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} hora" }, { PluralRulesValues.Other, "fa {0} hores" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} hora" }, { PluralRulesValues.Other, "d’aquí a {0} hores" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "h",
                new Dictionary<int, string> { { 0, "aquesta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} h" }, { PluralRulesValues.Other, "fa {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d‘aquí a {0} h" }, { PluralRulesValues.Other, "d‘aquí a {0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "h",
                new Dictionary<int, string> { { 0, "aquesta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} h" }, { PluralRulesValues.Other, "fa {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} h" }, { PluralRulesValues.Other, "d’aquí a {0} h" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "minut",
                new Dictionary<int, string> { { 0, "aquest minut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} minut" }, { PluralRulesValues.Other, "fa {0} minuts" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} minut" }, { PluralRulesValues.Other, "d’aquí a {0} minuts" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "aquest minut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} min" }, { PluralRulesValues.Other, "fa {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} min" }, { PluralRulesValues.Other, "d’aquí a {0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "aquest minut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} min" }, { PluralRulesValues.Other, "fa {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} min" }, { PluralRulesValues.Other, "d’aquí a {0} min" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Catalan (Spain, Valencian)' [ca-es-valencia]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "segon",
                new Dictionary<int, string> { { 0, "ara" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} segon" }, { PluralRulesValues.Other, "fa {0} segons" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} segon" }, { PluralRulesValues.Other, "d’aquí a {0} segons" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "ara" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} s" }, { PluralRulesValues.Other, "fa {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} s" }, { PluralRulesValues.Other, "d’aquí a {0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "s",
                new Dictionary<int, string> { { 0, "ara" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} s" }, { PluralRulesValues.Other, "fa {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} s" }, { PluralRulesValues.Other, "d’aquí a {0} s" } }));

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