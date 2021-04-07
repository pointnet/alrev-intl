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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Sakha' [sah]
    /// </summary>
    public class SakhaRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "sah";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Era,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Long,
                "Ээрэ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Narrow,
                "Ээрэ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Short,
                "Ээрэ",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "Сыл",
                new Dictionary<int, string> { { -1, "Былырыын" }, { 0, "быйыл" }, { 1, "эһиил" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сыл ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сылынан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "Сыл",
                new Dictionary<int, string> { { -1, "Былырыын" }, { 0, "быйыл" }, { 1, "эһиил" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сыл ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сылынан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "Сыл",
                new Dictionary<int, string> { { -1, "Былырыын" }, { 0, "быйыл" }, { 1, "эһиил" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сыл ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сылынан" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "Чиэппэр",
                new Dictionary<int, string> { { -1, "ааспыт кыбаартал" }, { 0, "бу кыбаартал" }, { 1, "кэлэр кыбаартал" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кыбаартал анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кыбаарталынан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "чпр.",
                new Dictionary<int, string> { { -1, "ааспыт кыбаартал" }, { 0, "бу кыбаартал" }, { 1, "кэлэр кыбаартал" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кыб. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кыбаарталынан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "чпр.",
                new Dictionary<int, string> { { -1, "ааспыт кыбаартал" }, { 0, "бу кыбаартал" }, { 1, "кэлэр кыбаартал" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кыб. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} кыбаарталынан" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "Ый",
                new Dictionary<int, string> { { -1, "ааспыт ый" }, { 0, "бу ый" }, { 1, "аныгыскы ый" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ый ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ыйынан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "Ый",
                new Dictionary<int, string> { { -1, "ааспыт ый" }, { 0, "бу ый" }, { 1, "аныгыскы ый" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ый ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ыйынан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "Ый",
                new Dictionary<int, string> { { -1, "ааспыт ый" }, { 0, "бу ый" }, { 1, "аныгыскы ый" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ый ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ыйынан" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "Нэдиэлэ",
                new Dictionary<int, string> { { -1, "ааспыт нэдиэлэ" }, { 0, "бу нэдиэлэ" }, { 1, "кэлэр нэдиэлэ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} нэдиэлэ анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} нэдиэлэннэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "Нэдиэлэ",
                new Dictionary<int, string> { { -1, "ааспыт нэдиэлэ" }, { 0, "бу нэдиэлэ" }, { 1, "кэлэр нэдиэлэ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} нэдиэлэ анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} нэдиэлэннэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "Нэдиэлэ",
                new Dictionary<int, string> { { -1, "ааспыт нэдиэлэ" }, { 0, "бу нэдиэлэ" }, { 1, "кэлэр нэдиэлэ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} нэдиэлэ анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} нэдиэлэннэн" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Long,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Narrow,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Short,
                "Week Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "Күн",
                new Dictionary<int, string> { { -2, "Иллэрээ күн" }, { -1, "Бэҕэһээ" }, { 0, "Бүгүн" }, { 1, "Сарсын" }, { 2, "Өйүүн" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} күн ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} күнүнэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "Күн",
                new Dictionary<int, string> { { -2, "Иллэрээ күн" }, { -1, "Бэҕэһээ" }, { 0, "Бүгүн" }, { 1, "Сарсын" }, { 2, "Өйүүн" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} күн ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} күнүнэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "Күн",
                new Dictionary<int, string> { { -2, "Иллэрээ күн" }, { -1, "Бэҕэһээ" }, { 0, "Бүгүн" }, { 1, "Сарсын" }, { 2, "Өйүүн" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} күн ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} күнүнэн" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayOfYear,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Long,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Narrow,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Short,
                "Day Of Year",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Weekday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Long,
                "Нэдиэлэ күнэ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Narrow,
                "Нэдиэлэ күнэ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Short,
                "Нэдиэлэ күнэ",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekdayOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Long,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Narrow,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Short,
                "Weekday Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ааспыт баскыһыанньа" }, { 0, "бу баскыһыанньа" }, { 1, "кэлэр баскыһыанньа" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} баскыһыанньа анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} баскыһыанньанан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ааспыт бс." }, { 0, "бу бс." }, { 1, "кэлэр бс." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} баскыһыанньа анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} баскыһыанньанан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ааспыт бс." }, { 0, "бу бс." }, { 1, "кэлэр бс." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} баскыһыанньа анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} баскыһыанньанан" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ааспыт бэнидиэнньик" }, { 0, "бу бэнидиэнньик" }, { 1, "кэлэр бэнидиэнньик" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ааспыт бн." }, { 0, "бу бн." }, { 1, "кэлэр бн." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ааспыт бн." }, { 0, "бу бн." }, { 1, "кэлэр бн." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ааспыт оптуорунньук" }, { 0, "бу оптуорунньук" }, { 1, "кэлэр оптуорунньук" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} оптуорунньук анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} оптуорунньугунан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ааспыт оп." }, { 0, "бу оп." }, { 1, "кэлэр оп." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} оп. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} оптуорунньугунан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ааспыт оп." }, { 0, "бу оп." }, { 1, "кэлэр оп." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} оп. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} оптуорунньугунан" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ааспыт сэрэдэ" }, { 0, "бу сэрэдэ" }, { 1, "кэлэр сэрэдэ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сэрэдэ анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сэрэдэнэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ааспыт сэ." }, { 0, "бу сэ." }, { 1, "кэлэр сэ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сэрэдэ анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сэрэдэнэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ааспыт сэ." }, { 0, "бу сэ." }, { 1, "кэлэр сэ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сэрэдэ анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сэрэдэнэн" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ааспыт чэппиэр" }, { 0, "бу чэппиэр" }, { 1, "кэлэр чэппиэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чэппиэр анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чэппиэринэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ааспыт чп." }, { 0, "бу чп." }, { 1, "кэлэр чп." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чп. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чэппиэринэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ааспыт чп." }, { 0, "бу чп." }, { 1, "кэлэр чп." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чп. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чэппиэринэн" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ааспыт бээтиҥсэ" }, { 0, "бу бээтиҥсэ" }, { 1, "кэлэр бээтиҥсэ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} бээтиҥсэ анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} бээтиҥсэнэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ааспыт бэ." }, { 0, "бу бэ." }, { 1, "кэлэр бэ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} бэ. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} бээтиҥсэнэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ааспыт бэ." }, { 0, "бу бэ." }, { 1, "кэлэр бэ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} бэ. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} бээтиҥсэнэн" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ааспыт субуота" }, { 0, "бу субуота" }, { 1, "кэлэр субуота" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} субуота анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} субуотанан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ааспыт сб." }, { 0, "бу сб." }, { 1, "кэлэр сб." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сб. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} субуотанан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ааспыт сб." }, { 0, "бу сб." }, { 1, "кэлэр сб." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сб. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} субуотанан" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayPeriod,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Long,
                "ЭИ/ЭК",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Narrow,
                "ЭИ/ЭК",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Short,
                "ЭИ/ЭК",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "Чаас",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чаас ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чааһынан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "Чаас",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чаас ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чааһынан" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "Чаас",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чаас ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чааһынан" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "Мүнүүтэ",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мүнүүтэ ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мүнүүтэннэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "Мүнүүтэ",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мүнүүтэ ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мүнүүтэннэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "Мүнүүтэ",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мүнүүтэ ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} мүнүүтэннэн" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "Сөкүүндэ",
                new Dictionary<int, string> { { 0, "билигин" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сөкүүндэ ынараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сөкүүндэннэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "Сөкүүндэ",
                new Dictionary<int, string> { { 0, "билигин" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сөк. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сөкүүндэннэн" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "Сөкүүндэ",
                new Dictionary<int, string> { { 0, "билигин" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сөк. анараа өттүгэр" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сөкүүндэннэн" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Sakha' [sah]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Zone,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Long,
                "Кэм балаһата",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Narrow,
                "Кэм балаһата",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Short,
                "Кэм балаһата",
                null,
                null,
                null));

        /// <summary>
        /// Gets the Relative Time resource styles based on the unit specified
        /// </summary>
        /// <param name="relativeTimeUnit">The resource unit to get</param>
        /// <returns>An <see cref="IRelativeTimeStylesResource"/></returns>
        /// <exception cref="RelativeTimeUnitNotFoundException"></exception>
        public IRelativeTimeStylesResource GetRelativeTimeStylesResource(RelativeTimeUnitValues relativeTimeUnit) => relativeTimeUnit switch
        {
            RelativeTimeUnitValues.Era => this.Era,
            RelativeTimeUnitValues.Year => this.Year,
            RelativeTimeUnitValues.Quarter => this.Quarter,
            RelativeTimeUnitValues.Month => this.Month,
            RelativeTimeUnitValues.Week => this.Week,
            RelativeTimeUnitValues.WeekOfMonth => this.WeekOfMonth,
            RelativeTimeUnitValues.Day => this.Day,
            RelativeTimeUnitValues.DayOfYear => this.DayOfYear,
            RelativeTimeUnitValues.Weekday => this.Weekday,
            RelativeTimeUnitValues.WeekdayOfMonth => this.WeekdayOfMonth,
            RelativeTimeUnitValues.Sunday => this.Sunday,
            RelativeTimeUnitValues.Monday => this.Monday,
            RelativeTimeUnitValues.Tuesday => this.Tuesday,
            RelativeTimeUnitValues.Wednesday => this.Wednesday,
            RelativeTimeUnitValues.Thursday => this.Thursday,
            RelativeTimeUnitValues.Friday => this.Friday,
            RelativeTimeUnitValues.Saturday => this.Saturday,
            RelativeTimeUnitValues.DayPeriod => this.DayPeriod,
            RelativeTimeUnitValues.Hour => this.Hour,
            RelativeTimeUnitValues.Minute => this.Minute,
            RelativeTimeUnitValues.Second => this.Second,
            RelativeTimeUnitValues.Zone => this.Zone,
            _ => throw new RelativeTimeUnitNotFoundException("Relative time unit does not exists", nameof(relativeTimeUnit))
        };
    }
}