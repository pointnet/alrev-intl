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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Galician' [gl]
    /// </summary>
    public class GalicianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "gl";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
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
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ano",
                new Dictionary<int, string> { { -1, "o ano pasado" }, { 0, "este ano" }, { 1, "o próximo ano" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} ano" }, { PluralRulesValues.Other, "hai {0} anos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} ano" }, { PluralRulesValues.Other, "en {0} anos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ano",
                new Dictionary<int, string> { { -1, "o ano pas." }, { 0, "este ano" }, { 1, "o próx. ano" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} ano" }, { PluralRulesValues.Other, "hai {0} anos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} ano" }, { PluralRulesValues.Other, "en {0} anos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ano",
                new Dictionary<int, string> { { -1, "o ano pasado" }, { 0, "este ano" }, { 1, "o próximo ano" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} ano" }, { PluralRulesValues.Other, "hai {0} anos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} ano" }, { PluralRulesValues.Other, "en {0} anos" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "trimestre",
                new Dictionary<int, string> { { -1, "o trimestre pasado" }, { 0, "este trimestre" }, { 1, "o próximo trimestre" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} trimestre" }, { PluralRulesValues.Other, "hai {0} trimestres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} trimestre" }, { PluralRulesValues.Other, "en {0} trimestres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "trim.",
                new Dictionary<int, string> { { -1, "trim. pasado" }, { 0, "este trim." }, { 1, "trim. seguinte" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} trim." }, { PluralRulesValues.Other, "hai {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} trim." }, { PluralRulesValues.Other, "en {0} trim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "trim.",
                new Dictionary<int, string> { { -1, "trim. pasado" }, { 0, "este trim." }, { 1, "trim. seguinte" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} trim." }, { PluralRulesValues.Other, "hai {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} trim." }, { PluralRulesValues.Other, "en {0} trim." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "mes",
                new Dictionary<int, string> { { -1, "o mes pasado" }, { 0, "este mes" }, { 1, "o próximo mes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} mes" }, { PluralRulesValues.Other, "hai {0} meses" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} mes" }, { PluralRulesValues.Other, "en {0} meses" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "mes",
                new Dictionary<int, string> { { -1, "o mes pas." }, { 0, "este mes" }, { 1, "o próx. mes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} mes" }, { PluralRulesValues.Other, "hai {0} meses" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} mes" }, { PluralRulesValues.Other, "en {0} meses" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "mes",
                new Dictionary<int, string> { { -1, "o mes pasado" }, { 0, "este mes" }, { 1, "o próximo mes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} mes" }, { PluralRulesValues.Other, "hai {0} meses" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} mes" }, { PluralRulesValues.Other, "en {0} meses" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "semana",
                new Dictionary<int, string> { { -1, "a semana pasada" }, { 0, "esta semana" }, { 1, "a próxima semana" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} semana" }, { PluralRulesValues.Other, "hai {0} semanas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} semana" }, { PluralRulesValues.Other, "en {0} semanas" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "sem.",
                new Dictionary<int, string> { { -1, "a sem. pas." }, { 0, "esta sem." }, { 1, "a próx. sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} sem." }, { PluralRulesValues.Other, "hai {0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} sem." }, { PluralRulesValues.Other, "en {0} sem." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sem.",
                new Dictionary<int, string> { { -1, "a sem. pasada" }, { 0, "esta sem." }, { 1, "a próxima sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} sem." }, { PluralRulesValues.Other, "hai {0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} sem." }, { PluralRulesValues.Other, "en {0} sem." } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "semana do mes",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "sem. do mes",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sem. do mes",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "día",
                new Dictionary<int, string> { { -2, "antonte" }, { -1, "onte" }, { 0, "hoxe" }, { 1, "mañá" }, { 2, "pasadomañá" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} día" }, { PluralRulesValues.Other, "hai {0} días" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} día" }, { PluralRulesValues.Other, "en {0} días" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "día",
                new Dictionary<int, string> { { -2, "antonte" }, { -1, "onte" }, { 0, "hoxe" }, { 1, "mañá" }, { 2, "pasadomañá" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} día" }, { PluralRulesValues.Other, "hai {0} días" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} día" }, { PluralRulesValues.Other, "en {0} días" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "día",
                new Dictionary<int, string> { { -2, "antonte" }, { -1, "onte" }, { 0, "hoxe" }, { 1, "mañá" }, { 2, "pasadomañá" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} día" }, { PluralRulesValues.Other, "hai {0} días" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} día" }, { PluralRulesValues.Other, "en {0} días" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "día do ano",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "día do ano",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "día do ano",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "día da semana",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "día da sem.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "día da sem.",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "semana do mes",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "sem. do mes",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sem. do mes",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "o domingo pasado" }, { 0, "este domingo" }, { 1, "o próximo domingo" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} domingo" }, { PluralRulesValues.Other, "hai {0} domingos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} domingo" }, { PluralRulesValues.Other, "en {0} domingos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "o dom. pas." }, { 0, "este dom." }, { 1, "o próx. dom." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} dom." }, { PluralRulesValues.Other, "hai {0} dom." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} dom." }, { PluralRulesValues.Other, "en {0} dom." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "o dom. pasado" }, { 0, "este dom." }, { 1, "o próximo dom." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} dom." }, { PluralRulesValues.Other, "hai {0} dom." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} dom." }, { PluralRulesValues.Other, "en {0} dom." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "o luns pasado" }, { 0, "este luns" }, { 1, "o próximo luns" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} luns" }, { PluralRulesValues.Other, "hai {0} luns" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} luns" }, { PluralRulesValues.Other, "en {0} luns" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "o luns pas." }, { 0, "este luns" }, { 1, "o próx. luns" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} luns" }, { PluralRulesValues.Other, "hai {0} luns" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} luns" }, { PluralRulesValues.Other, "en {0} luns" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "o luns pas." }, { 0, "este luns" }, { 1, "o próx. luns" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} luns" }, { PluralRulesValues.Other, "hai {0} luns" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} luns" }, { PluralRulesValues.Other, "en {0} luns" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "o martes pasado" }, { 0, "este martes" }, { 1, "o próximo martes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} martes" }, { PluralRulesValues.Other, "hai {0} martes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} martes" }, { PluralRulesValues.Other, "en {0} martes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "o mar. pas." }, { 0, "este mar." }, { 1, "o próx. mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} mar." }, { PluralRulesValues.Other, "hai {0} mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} mar." }, { PluralRulesValues.Other, "en {0} mar." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "o mar. pasado" }, { 0, "este mar." }, { 1, "o próximo mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} mar." }, { PluralRulesValues.Other, "hai {0} mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} mar." }, { PluralRulesValues.Other, "en {0} mar." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "o mércores pasado" }, { 0, "este mércores" }, { 1, "o próximo mércores" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} mércores" }, { PluralRulesValues.Other, "hai {0} mércores" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} mércores" }, { PluralRulesValues.Other, "en {0} mércores" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "o mér. pas." }, { 0, "este mér." }, { 1, "o próx. mér." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} mér." }, { PluralRulesValues.Other, "hai {0} mér." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} mér." }, { PluralRulesValues.Other, "en {0} mér." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "o mér. pasado" }, { 0, "este mér." }, { 1, "o próximo mér." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} mér." }, { PluralRulesValues.Other, "hai {0} mér." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} mér." }, { PluralRulesValues.Other, "en {0} mér." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "o xoves pasado" }, { 0, "este xoves" }, { 1, "o próximo xoves" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} xoves" }, { PluralRulesValues.Other, "hai {0} xoves" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} xoves" }, { PluralRulesValues.Other, "en {0} xoves" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "o xov. pas." }, { 0, "este xov." }, { 1, "o próx. xov." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} xov." }, { PluralRulesValues.Other, "hai {0} xov." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} xov." }, { PluralRulesValues.Other, "en {0} xov." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "o xov. pasado" }, { 0, "este xov." }, { 1, "o próximo xov." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} xov." }, { PluralRulesValues.Other, "hai {0} xov." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} xov." }, { PluralRulesValues.Other, "en {0} xov." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "o venres pasado" }, { 0, "este venres" }, { 1, "o próximo venres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} venres" }, { PluralRulesValues.Other, "hai {0} venres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} venres" }, { PluralRulesValues.Other, "en {0} venres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "o ven. pas." }, { 0, "este ven." }, { 1, "o próx. ven." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} ven." }, { PluralRulesValues.Other, "hai {0} ven." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} ven." }, { PluralRulesValues.Other, "en {0} ven." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "o ven. pasado" }, { 0, "este ven." }, { 1, "o próximo ven." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} ven." }, { PluralRulesValues.Other, "hai {0} ven." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} ven." }, { PluralRulesValues.Other, "en {0} ven." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "o sábado pasado" }, { 0, "este sábado" }, { 1, "o próximo sábado" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} sábado" }, { PluralRulesValues.Other, "hai {0} sábados" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} sábado" }, { PluralRulesValues.Other, "en {0} sábados" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "o sáb. pas." }, { 0, "este sáb." }, { 1, "o próx. sáb." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} sáb." }, { PluralRulesValues.Other, "hai {0} sáb." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} sáb." }, { PluralRulesValues.Other, "en {0} sáb." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "o sáb. pasado" }, { 0, "este sáb." }, { 1, "o próximo sáb." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} sáb." }, { PluralRulesValues.Other, "hai {0} sáb." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} sáb." }, { PluralRulesValues.Other, "en {0} sáb." } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "a.m./p.m.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "a.m./p.m.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "a.m./p.m.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "hora",
                new Dictionary<int, string> { { 0, "esta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} hora" }, { PluralRulesValues.Other, "hai {0} horas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} hora" }, { PluralRulesValues.Other, "en {0} horas" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "h",
                new Dictionary<int, string> { { 0, "esta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} h" }, { PluralRulesValues.Other, "hai {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} h" }, { PluralRulesValues.Other, "en {0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "h",
                new Dictionary<int, string> { { 0, "esta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} h" }, { PluralRulesValues.Other, "hai {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} h" }, { PluralRulesValues.Other, "en {0} h" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "minuto",
                new Dictionary<int, string> { { 0, "este minuto" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} minuto" }, { PluralRulesValues.Other, "hai {0} minutos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} minuto" }, { PluralRulesValues.Other, "en {0} minutos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "este minuto" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} min" }, { PluralRulesValues.Other, "hai {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} min" }, { PluralRulesValues.Other, "en {0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "este minuto" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} min" }, { PluralRulesValues.Other, "hai {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} min" }, { PluralRulesValues.Other, "en {0} min" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "segundo",
                new Dictionary<int, string> { { 0, "agora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} segundo" }, { PluralRulesValues.Other, "hai {0} segundos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} segundo" }, { PluralRulesValues.Other, "en {0} segundos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "agora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} s" }, { PluralRulesValues.Other, "hai {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} s" }, { PluralRulesValues.Other, "en {0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "s",
                new Dictionary<int, string> { { 0, "agora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "hai {0} s" }, { PluralRulesValues.Other, "hai {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "en {0} s" }, { PluralRulesValues.Other, "en {0} s" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Galician' [gl]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "fuso horario",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "fuso",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "fuso",
                null,
                null,
                null));
    }
}