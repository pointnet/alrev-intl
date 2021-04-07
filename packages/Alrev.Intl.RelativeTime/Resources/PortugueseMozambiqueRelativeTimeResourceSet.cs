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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Portuguese (Mozambique)' [pt-MZ]
    /// </summary>
    public class PortugueseMozambiqueRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "pt-MZ";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
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
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ano",
                new Dictionary<int, string> { { -1, "ano passado" }, { 0, "este ano" }, { 1, "próximo ano" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} ano" }, { PluralRulesValues.Other, "há {0} anos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} ano" }, { PluralRulesValues.Other, "dentro de {0} anos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ano",
                new Dictionary<int, string> { { -1, "ano passado" }, { 0, "este ano" }, { 1, "próximo ano" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} ano" }, { PluralRulesValues.Other, "-{0} anos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} ano" }, { PluralRulesValues.Other, "+{0} anos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ano",
                new Dictionary<int, string> { { -1, "ano passado" }, { 0, "este ano" }, { 1, "próximo ano" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} ano" }, { PluralRulesValues.Other, "há {0} anos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} ano" }, { PluralRulesValues.Other, "dentro de {0} anos" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "trimestre",
                new Dictionary<int, string> { { -1, "trimestre passado" }, { 0, "este trimestre" }, { 1, "próximo trimestre" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} trimestre" }, { PluralRulesValues.Other, "há {0} trimestres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} trimestre" }, { PluralRulesValues.Other, "dentro de {0} trimestres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "trim.",
                new Dictionary<int, string> { { -1, "trim. passado" }, { 0, "este trim." }, { 1, "próximo trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} trim." }, { PluralRulesValues.Other, "-{0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} trim." }, { PluralRulesValues.Other, "+{0} trim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "trim.",
                new Dictionary<int, string> { { -1, "trim. passado" }, { 0, "este trim." }, { 1, "próximo trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} trim." }, { PluralRulesValues.Other, "há {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} trim." }, { PluralRulesValues.Other, "dentro de {0} trim." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "mês",
                new Dictionary<int, string> { { -1, "mês passado" }, { 0, "este mês" }, { 1, "próximo mês" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} mês" }, { PluralRulesValues.Other, "há {0} meses" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} mês" }, { PluralRulesValues.Other, "dentro de {0} meses" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "mês",
                new Dictionary<int, string> { { -1, "mês passado" }, { 0, "este mês" }, { 1, "próximo mês" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} mês" }, { PluralRulesValues.Other, "-{0} meses" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} mês" }, { PluralRulesValues.Other, "+{0} meses" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "mês",
                new Dictionary<int, string> { { -1, "mês passado" }, { 0, "este mês" }, { 1, "próximo mês" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} mês" }, { PluralRulesValues.Other, "há {0} meses" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} mês" }, { PluralRulesValues.Other, "dentro de {0} meses" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "semana",
                new Dictionary<int, string> { { -1, "semana passada" }, { 0, "esta semana" }, { 1, "próxima semana" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} semana" }, { PluralRulesValues.Other, "há {0} semanas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} semana" }, { PluralRulesValues.Other, "dentro de {0} semanas" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "sem.",
                new Dictionary<int, string> { { -1, "semana passada" }, { 0, "esta semana" }, { 1, "próxima semana" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} sem." }, { PluralRulesValues.Other, "-{0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} sem." }, { PluralRulesValues.Other, "+{0} sem." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sem.",
                new Dictionary<int, string> { { -1, "semana passada" }, { 0, "esta semana" }, { 1, "próxima semana" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sem." }, { PluralRulesValues.Other, "há {0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sem." }, { PluralRulesValues.Other, "dentro de {0} sem." } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "semana do mês",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "sem. do mês",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "sem. do mês",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dia",
                new Dictionary<int, string> { { -2, "anteontem" }, { -1, "ontem" }, { 0, "hoje" }, { 1, "amanhã" }, { 2, "depois de amanhã" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} dia" }, { PluralRulesValues.Other, "há {0} dias" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} dia" }, { PluralRulesValues.Other, "dentro de {0} dias" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dia",
                new Dictionary<int, string> { { -2, "anteontem" }, { -1, "ontem" }, { 0, "hoje" }, { 1, "amanhã" }, { 2, "depois de amanhã" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} dia" }, { PluralRulesValues.Other, "-{0} dias" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} dia" }, { PluralRulesValues.Other, "+{0} dias" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dia",
                new Dictionary<int, string> { { -2, "anteontem" }, { -1, "ontem" }, { 0, "hoje" }, { 1, "amanhã" }, { 2, "depois de amanhã" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} dia" }, { PluralRulesValues.Other, "há {0} dias" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} dia" }, { PluralRulesValues.Other, "dentro de {0} dias" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dia do ano",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dia do ano",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dia do ano",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dia da semana",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dia da sem.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dia da sem.",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "dia da semana do mês",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "dia da sem. do mês",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dia da sem. do mês",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "domingo passado" }, { 0, "este domingo" }, { 1, "próximo domingo" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} domingo" }, { PluralRulesValues.Other, "há {0} domingos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} domingo" }, { PluralRulesValues.Other, "dentro de {0} domingos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dom. passado" }, { 0, "este dom." }, { 1, "próximo dom." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} dom." }, { PluralRulesValues.Other, "há {0} dom." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} dom." }, { PluralRulesValues.Other, "dentro de {0} dom." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "domingo passado" }, { 0, "este domingo" }, { 1, "próximo domingo" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} dom." }, { PluralRulesValues.Other, "há {0} dom." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} domingo" }, { PluralRulesValues.Other, "dentro de {0} domingos" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "segunda-feira passada" }, { 0, "esta segunda-feira" }, { 1, "próxima segunda-feira" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} segunda-feira" }, { PluralRulesValues.Other, "há {0} segundas-feiras" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} segunda-feira" }, { PluralRulesValues.Other, "dentro de {0} segundas-feiras" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "seg. passada" }, { 0, "esta seg." }, { 1, "próxima seg." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} seg." }, { PluralRulesValues.Other, "há {0} seg." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} seg." }, { PluralRulesValues.Other, "dentro de {0} seg." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "segunda passada" }, { 0, "esta segunda" }, { 1, "próxima segunda" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} segunda" }, { PluralRulesValues.Other, "há {0} segundas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} segunda" }, { PluralRulesValues.Other, "dentro de {0} segundas" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "terça-feira passada" }, { 0, "esta terça-feira" }, { 1, "próxima terça-feira" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} terça-feira" }, { PluralRulesValues.Other, "há {0} terças-feiras" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} terça-feira" }, { PluralRulesValues.Other, "dentro de {0} terças-feiras" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ter. passada" }, { 0, "esta ter." }, { 1, "próxima ter." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} ter." }, { PluralRulesValues.Other, "há {0} ter." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} ter." }, { PluralRulesValues.Other, "dentro de {0} ter." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "terça passada" }, { 0, "esta terça" }, { 1, "próxima terça" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} terça" }, { PluralRulesValues.Other, "há {0} terças" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} terça" }, { PluralRulesValues.Other, "dentro de {0} terças" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "quarta-feira passada" }, { 0, "esta quarta-feira" }, { 1, "próxima quarta-feira" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} quarta-feira" }, { PluralRulesValues.Other, "há {0} quartas-feiras" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} quarta-feira" }, { PluralRulesValues.Other, "dentro de {0} quartas-feiras" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "qua. passada" }, { 0, "esta qua." }, { 1, "próxima qua." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} qua." }, { PluralRulesValues.Other, "há {0} qua." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} qua." }, { PluralRulesValues.Other, "dentro de {0} qua." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "quarta passada" }, { 0, "esta quarta" }, { 1, "próxima quarta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} quarta" }, { PluralRulesValues.Other, "há {0} quartas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} quarta" }, { PluralRulesValues.Other, "dentro de {0} quartas" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "quinta-feira passada" }, { 0, "esta quinta-feira" }, { 1, "próxima quinta-feira" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} quinta-feira" }, { PluralRulesValues.Other, "há {0} quintas-feiras" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} quinta-feira" }, { PluralRulesValues.Other, "dentro de {0} quintas-feiras" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "qui. passada" }, { 0, "esta qui." }, { 1, "próxima qui." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} qui." }, { PluralRulesValues.Other, "há {0} qui." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} qui." }, { PluralRulesValues.Other, "dentro de {0} qui." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "quinta passada" }, { 0, "esta quinta" }, { 1, "próxima quinta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} quinta" }, { PluralRulesValues.Other, "há {0} quintas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} quinta" }, { PluralRulesValues.Other, "dentro de {0} quintas" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sexta-feira passada" }, { 0, "esta sexta-feira" }, { 1, "próxima sexta-feira" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sexta-feira" }, { PluralRulesValues.Other, "há {0} sextas-feiras" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sexta-feira" }, { PluralRulesValues.Other, "dentro de {0} sextas-feiras" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sex. passada" }, { 0, "esta sex." }, { 1, "próxima sex." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sex." }, { PluralRulesValues.Other, "há {0} sex." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sex." }, { PluralRulesValues.Other, "dentro de {0} sex." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sexta passada" }, { 0, "esta sexta" }, { 1, "próxima sexta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sexta" }, { PluralRulesValues.Other, "há {0} sextas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sexta" }, { PluralRulesValues.Other, "dentro de {0} sextas" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "sábado passado" }, { 0, "este sábado" }, { 1, "próximo sábado" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sábado" }, { PluralRulesValues.Other, "há {0} sábados" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sábado" }, { PluralRulesValues.Other, "dentro de {0} sábados" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sáb. passado" }, { 0, "este sáb." }, { 1, "próximo sáb." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sáb." }, { PluralRulesValues.Other, "há {0} sáb." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sáb." }, { PluralRulesValues.Other, "dentro de {0} sáb." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sábado passado" }, { 0, "este sábado" }, { 1, "próximo sábado" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sábado" }, { PluralRulesValues.Other, "há {0} sábados" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sábado" }, { PluralRulesValues.Other, "dentro de {0} sábados" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "am/pm",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "am/pm",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "am/pm",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "hora",
                new Dictionary<int, string> { { 0, "esta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} hora" }, { PluralRulesValues.Other, "há {0} horas" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} hora" }, { PluralRulesValues.Other, "dentro de {0} horas" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "h",
                new Dictionary<int, string> { { 0, "esta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} h" }, { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} h" }, { PluralRulesValues.Other, "+{0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "h",
                new Dictionary<int, string> { { 0, "esta hora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} h" }, { PluralRulesValues.Other, "há {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} h" }, { PluralRulesValues.Other, "dentro de {0} h" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "minuto",
                new Dictionary<int, string> { { 0, "este minuto" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} minuto" }, { PluralRulesValues.Other, "há {0} minutos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} minuto" }, { PluralRulesValues.Other, "dentro de {0} minutos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "este minuto" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} min" }, { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} min" }, { PluralRulesValues.Other, "+{0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "este minuto" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} min" }, { PluralRulesValues.Other, "há {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} min" }, { PluralRulesValues.Other, "dentro de {0} min" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "segundo",
                new Dictionary<int, string> { { 0, "agora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} segundo" }, { PluralRulesValues.Other, "há {0} segundos" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} segundo" }, { PluralRulesValues.Other, "dentro de {0} segundos" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "agora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} s" }, { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} s" }, { PluralRulesValues.Other, "+{0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "s",
                new Dictionary<int, string> { { 0, "agora" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} s" }, { PluralRulesValues.Other, "há {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} s" }, { PluralRulesValues.Other, "dentro de {0} s" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Portuguese (Mozambique)' [pt-MZ]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "fuso horário",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "fuso horário",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "fuso horário",
                null,
                null,
                null));
    }
}