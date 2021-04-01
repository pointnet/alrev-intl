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
    public class CatalanItalyRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ca-IT";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "era",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "any",
                new Dictionary<int, string> { { -1, "l’any passat" }, { 0, "enguany" }, { 1, "l’any que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} any" }, { PluralRulesValues.Other, "fa {0} anys" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} any" }, { PluralRulesValues.Other, "d’aquí a {0} anys" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "any",
                new Dictionary<int, string> { { -1, "l’any passat" }, { 0, "enguany" }, { 1, "l’any que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} any" }, { PluralRulesValues.Other, "fa {0} anys" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} any" }, { PluralRulesValues.Other, "d’aquí a {0} anys" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "any",
                new Dictionary<int, string> { { -1, "l’any passat" }, { 0, "enguany" }, { 1, "l’any que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} any" }, { PluralRulesValues.Other, "fa {0} anys" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} any" }, { PluralRulesValues.Other, "d’aquí a {0} anys" } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "trimestre",
                new Dictionary<int, string> { { -1, "el trimestre passat" }, { 0, "aquest trimestre" }, { 1, "el trimestre que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} trimestre" }, { PluralRulesValues.Other, "fa {0} trimestres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} trimestre" }, { PluralRulesValues.Other, "d’aquí a {0} trimestres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "trim.",
                new Dictionary<int, string> { { -1, "trim. passat" }, { 0, "aquest trim." }, { 1, "trim. vinent" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} trim." }, { PluralRulesValues.Other, "fa {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} trim." }, { PluralRulesValues.Other, "d’aquí a {0} trim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "trim.",
                new Dictionary<int, string> { { -1, "el trim. passat" }, { 0, "aquest trim." }, { 1, "el trim. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} trim." }, { PluralRulesValues.Other, "fa {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} trim." }, { PluralRulesValues.Other, "d’aquí a {0} trim." } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "mes",
                new Dictionary<int, string> { { -1, "el mes passat" }, { 0, "aquest mes" }, { 1, "el mes que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} mes" }, { PluralRulesValues.Other, "fa {0} mesos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} mes" }, { PluralRulesValues.Other, "d’aquí a {0} mesos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "mes",
                new Dictionary<int, string> { { -1, "el mes passat" }, { 0, "aquest mes" }, { 1, "el mes que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} mes" }, { PluralRulesValues.Other, "fa {0} mesos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} mes" }, { PluralRulesValues.Other, "d’aquí a {0} mesos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "mes",
                new Dictionary<int, string> { { -1, "el mes passat" }, { 0, "aquest mes" }, { 1, "el mes que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} mes" }, { PluralRulesValues.Other, "fa {0} mesos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} mes" }, { PluralRulesValues.Other, "d’aquí a {0} mesos" } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "setmana",
                new Dictionary<int, string> { { -1, "la setmana passada" }, { 0, "aquesta setmana" }, { 1, "la setmana que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} setmana" }, { PluralRulesValues.Other, "fa {0} setmanes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} setmana" }, { PluralRulesValues.Other, "d’aquí a {0} setmanes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "setm.",
                new Dictionary<int, string> { { -1, "la setm. passada" }, { 0, "aquesta setm." }, { 1, "la setm. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} setm." }, { PluralRulesValues.Other, "fa {0} setm." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} setm." }, { PluralRulesValues.Other, "d’aquí a {0} setm." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "setm.",
                new Dictionary<int, string> { { -1, "la setm. passada" }, { 0, "aquesta setm." }, { 1, "la setm. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} setm." }, { PluralRulesValues.Other, "fa {0} setm." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} setm." }, { PluralRulesValues.Other, "d’aquí a {0} setm." } }));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "setmana del mes",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "setm. del mes",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "setm. del mes",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "dia",
                new Dictionary<int, string> { { -2, "abans-d’ahir" }, { -1, "ahir" }, { 0, "avui" }, { 1, "demà" }, { 2, "demà passat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dia" }, { PluralRulesValues.Other, "fa {0} dies" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dia" }, { PluralRulesValues.Other, "d’aquí a {0} dies" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "dia",
                new Dictionary<int, string> { { -2, "abans-d’ahir" }, { -1, "ahir" }, { 0, "avui" }, { 1, "demà" }, { 2, "demà passat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dia" }, { PluralRulesValues.Other, "fa {0} dies" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dia" }, { PluralRulesValues.Other, "d’aquí a {0} dies" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "dia",
                new Dictionary<int, string> { { -2, "abans-d’ahir" }, { -1, "ahir" }, { 0, "avui" }, { 1, "demà" }, { 2, "demà passat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dia" }, { PluralRulesValues.Other, "fa {0} dies" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dia" }, { PluralRulesValues.Other, "d’aquí a {0} dies" } }));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "dia de l’any",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "dia de l’any",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "dia de l’any",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "dia de la setmana",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "dia de la setm.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "dia de la setm.",
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "dia de la setmana del mes",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "dia de la setm. del mes",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "dia de la setm. del mes",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "diumenge passat" }, { 0, "aquest diumenge" }, { 1, "diumenge que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} diumenge" }, { PluralRulesValues.Other, "fa {0} diumenges" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} diumenge" }, { PluralRulesValues.Other, "d’aquí a {0} diumenges" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dg. passat" }, { 0, "aquest dg." }, { 1, "dg. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dg." }, { PluralRulesValues.Other, "fa {0} dg." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dg." }, { PluralRulesValues.Other, "d’aquí a {0} dg." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dg. passat" }, { 0, "aquest dg." }, { 1, "dg. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dg." }, { PluralRulesValues.Other, "fa {0} dg." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dg." }, { PluralRulesValues.Other, "d’aquí a {0} dg." } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dilluns passat" }, { 0, "aquest dilluns" }, { 1, "dilluns que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dilluns" }, { PluralRulesValues.Other, "fa {0} dilluns" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dilluns" }, { PluralRulesValues.Other, "d’aquí a {0} dilluns" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dl. passat" }, { 0, "aquest dl." }, { 1, "dl. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dl." }, { PluralRulesValues.Other, "fa {0} dl." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dl." }, { PluralRulesValues.Other, "d’aquí a {0} dl." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dl. passat" }, { 0, "aquest dl." }, { 1, "dl. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dl." }, { PluralRulesValues.Other, "fa {0} dl." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dl." }, { PluralRulesValues.Other, "d’aquí a {0} dl." } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dimarts passat" }, { 0, "aquest dimarts" }, { 1, "dimarts que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dimarts" }, { PluralRulesValues.Other, "fa {0} dimarts" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dimarts" }, { PluralRulesValues.Other, "d’aquí a {0} dimarts" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dt. passat" }, { 0, "aquest dt." }, { 1, "dt. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dt." }, { PluralRulesValues.Other, "fa {0} dt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dt." }, { PluralRulesValues.Other, "d’aquí a {0} dt." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dt. passat" }, { 0, "aquest dt." }, { 1, "dt. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dt." }, { PluralRulesValues.Other, "fa {0} dt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dt." }, { PluralRulesValues.Other, "d’aquí a {0} dt." } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dimecres passat" }, { 0, "aquest dimecres" }, { 1, "dimecres que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dimecres" }, { PluralRulesValues.Other, "fa {0} dimecres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dimecres" }, { PluralRulesValues.Other, "d’aquí a {0} dimecres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dc. passat" }, { 0, "aquest dc." }, { 1, "dc. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dc." }, { PluralRulesValues.Other, "fa {0} dc." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dc." }, { PluralRulesValues.Other, "d’aquí a {0} dc." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dc. passat" }, { 0, "aquest dc." }, { 1, "dc. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dc." }, { PluralRulesValues.Other, "fa {0} dc." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dc." }, { PluralRulesValues.Other, "d’aquí a {0} dc." } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dijous passat" }, { 0, "aquest dijous" }, { 1, "dijous que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dijous" }, { PluralRulesValues.Other, "fa {0} dijous" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dijous" }, { PluralRulesValues.Other, "d’aquí a {0} dijous" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dj. passat" }, { 0, "aquest dj." }, { 1, "dj. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dj." }, { PluralRulesValues.Other, "fa {0} dj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dj." }, { PluralRulesValues.Other, "d’aquí a {0} dj." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dj. passat" }, { 0, "aquest dj." }, { 1, "dj. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dj." }, { PluralRulesValues.Other, "fa {0} dj." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dj." }, { PluralRulesValues.Other, "d’aquí a {0} dj." } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "divendres passat" }, { 0, "aquest divendres" }, { 1, "divendres que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} divendres" }, { PluralRulesValues.Other, "fa {0} divendres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} divendres" }, { PluralRulesValues.Other, "d’aquí a {0} divendres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dv. passat" }, { 0, "aquest dv." }, { 1, "dv. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dv." }, { PluralRulesValues.Other, "fa {0} dv." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dv." }, { PluralRulesValues.Other, "d’aquí a {0} dv." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dv. passat" }, { 0, "aquest dv." }, { 1, "dv. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dv." }, { PluralRulesValues.Other, "fa {0} dv." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dv." }, { PluralRulesValues.Other, "d’aquí a {0} dv." } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dissabte passat" }, { 0, "aquest dissabte" }, { 1, "dissabte que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} dissabte" }, { PluralRulesValues.Other, "fa {0} dissabtes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} dissabte" }, { PluralRulesValues.Other, "d’aquí a {0} dissabtes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ds. passat" }, { 0, "aquest ds." }, { 1, "ds. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} ds." }, { PluralRulesValues.Other, "fa {0} ds." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} ds." }, { PluralRulesValues.Other, "d’aquí a {0} ds." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ds. passat" }, { 0, "aquest ds." }, { 1, "ds. que ve" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} ds." }, { PluralRulesValues.Other, "fa {0} ds." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} ds." }, { PluralRulesValues.Other, "d’aquí a {0} ds." } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "a. m./p. m.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "a. m./p. m.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "a. m./p. m.",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "hora",
                new Dictionary<int, string> { { 0, "aquesta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} hora" }, { PluralRulesValues.Other, "fa {0} hores" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} hora" }, { PluralRulesValues.Other, "d’aquí a {0} hores" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "h",
                new Dictionary<int, string> { { 0, "aquesta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} h" }, { PluralRulesValues.Other, "fa {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d‘aquí a {0} h" }, { PluralRulesValues.Other, "d‘aquí a {0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "h",
                new Dictionary<int, string> { { 0, "aquesta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} h" }, { PluralRulesValues.Other, "fa {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} h" }, { PluralRulesValues.Other, "d’aquí a {0} h" } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minut",
                new Dictionary<int, string> { { 0, "aquest minut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} minut" }, { PluralRulesValues.Other, "fa {0} minuts" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} minut" }, { PluralRulesValues.Other, "d’aquí a {0} minuts" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "aquest minut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} min" }, { PluralRulesValues.Other, "fa {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} min" }, { PluralRulesValues.Other, "d’aquí a {0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "aquest minut" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} min" }, { PluralRulesValues.Other, "fa {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} min" }, { PluralRulesValues.Other, "d’aquí a {0} min" } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "segon",
                new Dictionary<int, string> { { 0, "ara" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} segon" }, { PluralRulesValues.Other, "fa {0} segons" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} segon" }, { PluralRulesValues.Other, "d’aquí a {0} segons" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "ara" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} s" }, { PluralRulesValues.Other, "fa {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} s" }, { PluralRulesValues.Other, "d’aquí a {0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "s",
                new Dictionary<int, string> { { 0, "ara" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "fa {0} s" }, { PluralRulesValues.Other, "fa {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "d’aquí a {0} s" }, { PluralRulesValues.Other, "d’aquí a {0} s" } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "fus horari",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "fus horari",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "fus horari",
                null,
                null,
                null));
    }
}