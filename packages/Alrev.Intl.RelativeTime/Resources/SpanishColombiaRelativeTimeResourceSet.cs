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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Spanish (Colombia)' [es-co]
    /// </summary>
    public class SpanishColombiaRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "es-co";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "año",
                new Dictionary<int, string> { { -1, "el año pasado" }, { 0, "este año" }, { 1, "el próximo año" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} año" }, { PluralRulesValues.Other, "hace {0} años" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} año" }, { PluralRulesValues.Other, "dentro de {0} años" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "a",
                new Dictionary<int, string> { { -1, "el año pasado" }, { 0, "este año" }, { 1, "el próximo año" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} a" }, { PluralRulesValues.Other, "hace {0} a" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} a" }, { PluralRulesValues.Other, "dentro de {0} a" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "a",
                new Dictionary<int, string> { { -1, "el año pasado" }, { 0, "este año" }, { 1, "el próximo año" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} a" }, { PluralRulesValues.Other, "hace {0} a" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} a" }, { PluralRulesValues.Other, "dentro de {0} a" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "trimestre",
                new Dictionary<int, string> { { -1, "el trimestre pasado" }, { 0, "este trimestre" }, { 1, "el próximo trimestre" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} trimestre" }, { PluralRulesValues.Other, "hace {0} trimestres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} trimestre" }, { PluralRulesValues.Other, "dentro de {0} trimestres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "trim.",
                new Dictionary<int, string> { { -1, "el trimestre pasado" }, { 0, "este trimestre" }, { 1, "el próximo trimestre" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} trim." }, { PluralRulesValues.Other, "hace {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} trim." }, { PluralRulesValues.Other, "dentro de {0} trim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "trim.",
                new Dictionary<int, string> { { -1, "el trimestre pasado" }, { 0, "este trimestre" }, { 1, "el próximo trimestre" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} trim." }, { PluralRulesValues.Other, "hace {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} trim." }, { PluralRulesValues.Other, "dentro de {0} trim." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "mes",
                new Dictionary<int, string> { { -1, "el mes pasado" }, { 0, "este mes" }, { 1, "el próximo mes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} mes" }, { PluralRulesValues.Other, "hace {0} meses" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} mes" }, { PluralRulesValues.Other, "dentro de {0} meses" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "m",
                new Dictionary<int, string> { { -1, "el mes pasado" }, { 0, "este mes" }, { 1, "el próximo mes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} m" }, { PluralRulesValues.Other, "hace {0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} m" }, { PluralRulesValues.Other, "dentro de {0} m" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "m",
                new Dictionary<int, string> { { -1, "el mes pasado" }, { 0, "este mes" }, { 1, "el próximo mes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} m" }, { PluralRulesValues.Other, "hace {0} m" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} m" }, { PluralRulesValues.Other, "dentro de {0} m" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "semana",
                new Dictionary<int, string> { { -1, "la semana pasada" }, { 0, "esta semana" }, { 1, "la próxima semana" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} semana" }, { PluralRulesValues.Other, "hace {0} semanas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} semana" }, { PluralRulesValues.Other, "dentro de {0} semanas" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "sem.",
                new Dictionary<int, string> { { -1, "sem. pas." }, { 0, "esta sem." }, { 1, "próx. sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} sem." }, { PluralRulesValues.Other, "hace {0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sem." }, { PluralRulesValues.Other, "dentro de {0} sem." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "sem.",
                new Dictionary<int, string> { { -1, "sem. pas." }, { 0, "esta sem." }, { 1, "próx. sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} sem." }, { PluralRulesValues.Other, "hace {0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sem." }, { PluralRulesValues.Other, "dentro de {0} sem." } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "día",
                new Dictionary<int, string> { { -2, "anteayer" }, { -1, "ayer" }, { 0, "hoy" }, { 1, "mañana" }, { 2, "pasado mañana" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} día" }, { PluralRulesValues.Other, "hace {0} días" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} día" }, { PluralRulesValues.Other, "dentro de {0} días" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "d",
                new Dictionary<int, string> { { -2, "anteayer" }, { -1, "ayer" }, { 0, "hoy" }, { 1, "mañana" }, { 2, "pasado mañana" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} día" }, { PluralRulesValues.Other, "hace {0} días" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} día" }, { PluralRulesValues.Other, "dentro de {0} días" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "d",
                new Dictionary<int, string> { { -2, "anteayer" }, { -1, "ayer" }, { 0, "hoy" }, { 1, "mañana" }, { 2, "pasado mañana" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} día" }, { PluralRulesValues.Other, "hace {0} días" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} día" }, { PluralRulesValues.Other, "dentro de {0} días" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "el domingo pasado" }, { 0, "este domingo" }, { 1, "el próximo domingo" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} domingo" }, { PluralRulesValues.Other, "hace {0} domingos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} domingo" }, { PluralRulesValues.Other, "en {0} domingos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "el DO pasado" }, { 0, "este DO" }, { 1, "el próximo DO" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} DO" }, { PluralRulesValues.Other, "hace {0} DO" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} DO" }, { PluralRulesValues.Other, "dentro de {0} DO" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "el dom. pasado" }, { 0, "este dom." }, { 1, "el próximo dom." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} dom." }, { PluralRulesValues.Other, "hace {0} dom." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} dom." }, { PluralRulesValues.Other, "dentro de {0} dom." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "el lunes pasado" }, { 0, "este lunes" }, { 1, "el próximo lunes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} lunes" }, { PluralRulesValues.Other, "hace {0} lunes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} lunes" }, { PluralRulesValues.Other, "dentro de {0} lunes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "el LU pasado" }, { 0, "este LU" }, { 1, "el próximo LU" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} LU" }, { PluralRulesValues.Other, "hace {0} LU" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} LU" }, { PluralRulesValues.Other, "dentro de {0} LU" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "el lun. pasado" }, { 0, "este lun." }, { 1, "el próximo lun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} lun." }, { PluralRulesValues.Other, "hace {0} lun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} lun." }, { PluralRulesValues.Other, "dentro de {0} lun." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "el martes pasado" }, { 0, "este martes" }, { 1, "el próximo martes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} martes" }, { PluralRulesValues.Other, "hace {0} martes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} martes" }, { PluralRulesValues.Other, "en {0} martes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "el MA pasado" }, { 0, "este MA" }, { 1, "el próximo MA" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} MA" }, { PluralRulesValues.Other, "hace {0} MA" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} MA" }, { PluralRulesValues.Other, "dentro de {0} MA" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "el mar. pasado" }, { 0, "este mar." }, { 1, "el próximo mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} mar." }, { PluralRulesValues.Other, "hace {0} mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} mar." }, { PluralRulesValues.Other, "dentro de {0} mar." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "el miércoles pasado" }, { 0, "este miércoles" }, { 1, "el próximo miércoles" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} miércoles" }, { PluralRulesValues.Other, "hace {0} miércoles" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} miércoles" }, { PluralRulesValues.Other, "dentro de {0} miércoles" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "el MI pasado" }, { 0, "este MI" }, { 1, "el próximo MI" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} MI" }, { PluralRulesValues.Other, "hace {0} MI" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} MI" }, { PluralRulesValues.Other, "dentro de {0} MI" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "el mié. pasado" }, { 0, "este mié." }, { 1, "el próximo mié." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} mié." }, { PluralRulesValues.Other, "hace {0} mié." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} mié." }, { PluralRulesValues.Other, "dentro de {0} mié." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "el jueves pasado" }, { 0, "este jueves" }, { 1, "el próximo jueves" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} jueves" }, { PluralRulesValues.Other, "hace {0} jueves" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} jueves" }, { PluralRulesValues.Other, "dentro de {0} jueves" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "el JU pasado" }, { 0, "este JU" }, { 1, "el próximo JU" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} JU" }, { PluralRulesValues.Other, "hace {0} JU" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} JU" }, { PluralRulesValues.Other, "dentro de {0} JU" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "el jue. pasado" }, { 0, "este jue." }, { 1, "el próximo jue." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} jue." }, { PluralRulesValues.Other, "hace {0} jue." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} jue." }, { PluralRulesValues.Other, "dentro de {0} jue." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "el viernes pasado" }, { 0, "este viernes" }, { 1, "el próximo viernes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} viernes" }, { PluralRulesValues.Other, "hace {0} viernes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} viernes" }, { PluralRulesValues.Other, "dentro de {0} viernes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "el VI pasado" }, { 0, "este VI" }, { 1, "el próximo VI" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} viernes" }, { PluralRulesValues.Other, "hace {0} viernes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} VI" }, { PluralRulesValues.Other, "dentro de {0} VI" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "el vie. pasado" }, { 0, "este vie." }, { 1, "el próximo vie." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} viernes" }, { PluralRulesValues.Other, "hace {0} viernes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} vie." }, { PluralRulesValues.Other, "dentro de {0} vie." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "el sábado pasado" }, { 0, "este sábado" }, { 1, "el próximo sábado" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} sábado" }, { PluralRulesValues.Other, "hace {0} sábados" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sábado" }, { PluralRulesValues.Other, "dentro de {0} sábados" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "el SA pasado" }, { 0, "este SA" }, { 1, "el próximo SA" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} sábados" }, { PluralRulesValues.Other, "hace {0} sábados" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} SA" }, { PluralRulesValues.Other, "dentro de {0} SA" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "el sáb. pasado" }, { 0, "este sáb." }, { 1, "el próximo sáb." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} sáb." }, { PluralRulesValues.Other, "hace {0} sáb." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sáb." }, { PluralRulesValues.Other, "dentro de {0} sáb." } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "hora",
                new Dictionary<int, string> { { 0, "esta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} hora" }, { PluralRulesValues.Other, "hace {0} horas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} hora" }, { PluralRulesValues.Other, "dentro de {0} horas" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "h",
                new Dictionary<int, string> { { 0, "esta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} h" }, { PluralRulesValues.Other, "hace {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} h" }, { PluralRulesValues.Other, "dentro de {0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "h",
                new Dictionary<int, string> { { 0, "esta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} h" }, { PluralRulesValues.Other, "hace {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} h" }, { PluralRulesValues.Other, "dentro de {0} h" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "minuto",
                new Dictionary<int, string> { { 0, "este minuto" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} minuto" }, { PluralRulesValues.Other, "hace {0} minutos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} minuto" }, { PluralRulesValues.Other, "dentro de {0} minutos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "este minuto" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} min" }, { PluralRulesValues.Other, "hace {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} min" }, { PluralRulesValues.Other, "dentro de {0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "este minuto" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} min" }, { PluralRulesValues.Other, "hace {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} min" }, { PluralRulesValues.Other, "dentro de {0} min" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Spanish (Colombia)' [es-co]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "segundo",
                new Dictionary<int, string> { { 0, "ahora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} segundo" }, { PluralRulesValues.Other, "hace {0} segundos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} segundo" }, { PluralRulesValues.Other, "dentro de {0} segundos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "ahora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} s" }, { PluralRulesValues.Other, "hace {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} s" }, { PluralRulesValues.Other, "dentro de {0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "s",
                new Dictionary<int, string> { { 0, "ahora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hace {0} s" }, { PluralRulesValues.Other, "hace {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} s" }, { PluralRulesValues.Other, "dentro de {0} s" } }));

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