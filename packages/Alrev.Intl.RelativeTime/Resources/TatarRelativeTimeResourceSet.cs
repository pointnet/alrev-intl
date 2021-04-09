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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Tatar' [tt]
    /// </summary>
    public class TatarRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "tt";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "ел",
                new Dictionary<int, string> { { -1, "узган ел" }, { 0, "быел" }, { 1, "киләсе елда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ел элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} елдан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "ел",
                new Dictionary<int, string> { { -1, "узган ел" }, { 0, "быел" }, { 1, "киләсе елда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ел элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} елдан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "ел",
                new Dictionary<int, string> { { -1, "узган ел" }, { 0, "быел" }, { 1, "киләсе елда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ел элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} елдан" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "квартал",
                new Dictionary<int, string> { { -1, "узган кварталда" }, { 0, "бу кварталда" }, { 1, "киләсе кварталда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} квартал элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кварталдан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "кв.",
                new Dictionary<int, string> { { -1, "узган кварталда" }, { 0, "бу кварталда" }, { 1, "киләсе кварталда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кв. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кв." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "кв.",
                new Dictionary<int, string> { { -1, "узган кварталда" }, { 0, "бу кварталда" }, { 1, "киләсе кварталда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кв. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кв." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "ай",
                new Dictionary<int, string> { { -1, "узган айда" }, { 0, "бу айда" }, { 1, "киләсе айда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ай элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} айдан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "ай",
                new Dictionary<int, string> { { -1, "узган айда" }, { 0, "бу айда" }, { 1, "киләсе айда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ай элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} айдан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "ай",
                new Dictionary<int, string> { { -1, "узган айда" }, { 0, "бу айда" }, { 1, "киләсе айда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ай элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} айдан" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "атна",
                new Dictionary<int, string> { { -1, "узган атнада" }, { 0, "бу атнада" }, { 1, "киләсе атнада" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} атна элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} атнадан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "атна",
                new Dictionary<int, string> { { -1, "узган атнада" }, { 0, "бу атнада" }, { 1, "киләсе атнада" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} атна элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} атнадан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "атна",
                new Dictionary<int, string> { { -1, "узган атнада" }, { 0, "бу атнада" }, { 1, "киләсе атнада" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} атна элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} атнадан" } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "көн",
                new Dictionary<int, string> { { -1, "кичә" }, { 0, "бүген" }, { 1, "иртәгә" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} көн элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} көннән" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "көн",
                new Dictionary<int, string> { { -1, "кичә" }, { 0, "бүген" }, { 1, "иртәгә" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} көн элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} көннән" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "көн",
                new Dictionary<int, string> { { -1, "кичә" }, { 0, "бүген" }, { 1, "иртәгә" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} көн элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} көннән" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "узган якшәмбе" }, { 0, "бу якшәмбе" }, { 1, "киләсе якшәмбе" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} якшәмбе элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} якшәмбе узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "узган якш." }, { 0, "бу якш." }, { 1, "киләсе якш." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} якш. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} якш. узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "узган якш." }, { 0, "бу якш." }, { 1, "киләсе якш." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} якш. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} якш. узгач" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "узган дүшәмбе" }, { 0, "бу дүшәмбе" }, { 1, "киләсе дүшәмбе" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дүшәмбе элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дүшәмбе узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "узган дүш." }, { 0, "бу дүш." }, { 1, "киләсе дүш." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дүш. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дүш. узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "узган дүш." }, { 0, "бу дүш." }, { 1, "киләсе дүш." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дүш. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дүш. узгач" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "узган сишәмбе" }, { 0, "бу сишәмбе" }, { 1, "киләсе сишәмбе" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сишәмбе элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сишәмбе узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "узган сиш." }, { 0, "бу сиш." }, { 1, "киләсе сиш." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сиш. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сиш. узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "узган сиш." }, { 0, "бу сиш." }, { 1, "киләсе сиш." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сиш. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сиш. узгач" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "узган чәршәмбе" }, { 0, "бу чәршәмбе" }, { 1, "киләсе чәршәмбе" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чәршәмбе элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чәршәмбе узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "узган чәр." }, { 0, "бу чәр." }, { 1, "киләсе чәр." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чәр. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чәр. узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "узган чәр." }, { 0, "бу чәр." }, { 1, "киләсе чәр." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чәр. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чәр. узгач" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "узган пәнҗешәмбе" }, { 0, "бу пәнҗешәмбе" }, { 1, "киләсе пәнҗешәмбе" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} пәнҗешәмбе элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} пәнҗешәмбе узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "узган пәнҗ." }, { 0, "бу пәнҗ." }, { 1, "киләсе пәнҗ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} пәнҗ. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} пәнҗ. узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "узган пәнҗ." }, { 0, "бу пәнҗ." }, { 1, "киләсе пәнҗ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} пәнҗ. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} пәнҗ. узгач" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "узган җомга" }, { 0, "бу җомга" }, { 1, "киләсе җомга" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} җомга элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} җомга узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "узган җом." }, { 0, "бу җом." }, { 1, "киләсе җом." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} җом. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} җом. узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "узган җом." }, { 0, "бу җом." }, { 1, "киләсе җом." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} җом. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} җом. узгач" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "узган шимбә" }, { 0, "бу шимбә" }, { 1, "киләсе шимбә" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} шимбә элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} шимбә узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "узган шим." }, { 0, "бу шим." }, { 1, "киләсе шим." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} шим. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} шим. узгач" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "узган шим." }, { 0, "бу шим." }, { 1, "киләсе шим." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} шим. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} шим. узгач" } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "сәгать",
                new Dictionary<int, string> { { 0, "бу сәгатьтә" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сәгать элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сәгатьтән" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "сәг.",
                new Dictionary<int, string> { { 0, "бу сәгатьтә" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сәг. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сәг." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "сәг.",
                new Dictionary<int, string> { { 0, "бу сәгатьтә" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сәг. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сәг." } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "минут",
                new Dictionary<int, string> { { 0, "бу минутта" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} минут элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} минуттан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "мин.",
                new Dictionary<int, string> { { 0, "бу минутта" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мин. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мин." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "мин.",
                new Dictionary<int, string> { { 0, "бу минутта" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мин. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мин." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Tatar' [tt]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "секунд",
                new Dictionary<int, string> { { 0, "хәзер" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} секунд элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} секундтан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "с.",
                new Dictionary<int, string> { { 0, "хәзер" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} с. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} с." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "с.",
                new Dictionary<int, string> { { 0, "хәзер" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} с. элек" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} с." } }));

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