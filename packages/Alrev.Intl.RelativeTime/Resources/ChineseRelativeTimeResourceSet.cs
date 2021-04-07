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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Chinese' [zh-Hant]
    /// </summary>
    public class ChineseRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "zh-Hant";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Era,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Long,
                "年代",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Narrow,
                "年代",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Short,
                "年代",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "年",
                new Dictionary<int, string> { { -1, "去年" }, { 0, "今年" }, { 1, "明年" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "年",
                new Dictionary<int, string> { { -1, "去年" }, { 0, "今年" }, { 1, "明年" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "年",
                new Dictionary<int, string> { { -1, "去年" }, { 0, "今年" }, { 1, "明年" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年後" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "季",
                new Dictionary<int, string> { { -1, "上一季" }, { 0, "這一季" }, { 1, "下一季" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 季前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 季後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "季",
                new Dictionary<int, string> { { -1, "上一季" }, { 0, "這一季" }, { 1, "下一季" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 季前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 季後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "季",
                new Dictionary<int, string> { { -1, "上一季" }, { 0, "這一季" }, { 1, "下一季" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 季前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 季後" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "月",
                new Dictionary<int, string> { { -1, "上個月" }, { 0, "本月" }, { 1, "下個月" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個月前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個月後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "月",
                new Dictionary<int, string> { { -1, "上個月" }, { 0, "本月" }, { 1, "下個月" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個月前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個月後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "月",
                new Dictionary<int, string> { { -1, "上個月" }, { 0, "本月" }, { 1, "下個月" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個月前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個月後" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "週",
                new Dictionary<int, string> { { -1, "上週" }, { 0, "本週" }, { 1, "下週" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "週",
                new Dictionary<int, string> { { -1, "上週" }, { 0, "本週" }, { 1, "下週" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "週",
                new Dictionary<int, string> { { -1, "上週" }, { 0, "本週" }, { 1, "下週" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週後" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Long,
                "週",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Narrow,
                "週",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Short,
                "週",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "日",
                new Dictionary<int, string> { { -2, "前天" }, { -1, "昨天" }, { 0, "今天" }, { 1, "明天" }, { 2, "後天" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 天前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 天後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "日",
                new Dictionary<int, string> { { -2, "前天" }, { -1, "昨天" }, { 0, "今天" }, { 1, "明天" }, { 2, "後天" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 天前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 天後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "日",
                new Dictionary<int, string> { { -2, "前天" }, { -1, "昨天" }, { 0, "今天" }, { 1, "明天" }, { 2, "後天" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 天前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 天後" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayOfYear,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Long,
                "年天",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Narrow,
                "年天",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Short,
                "年天",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Weekday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Long,
                "週天",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Narrow,
                "週天",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Short,
                "週天",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekdayOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Long,
                "每月平日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Narrow,
                "每月平日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Short,
                "每月平日",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上週日" }, { 0, "本週日" }, { 1, "下週日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週日前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週日後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上週日" }, { 0, "本週日" }, { 1, "下週日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週日前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週日後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上週日" }, { 0, "本週日" }, { 1, "下週日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週日前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週日後" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上週一" }, { 0, "本週一" }, { 1, "下週一" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週一前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週一後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上週一" }, { 0, "本週一" }, { 1, "下週一" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週一前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週一後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上週一" }, { 0, "本週一" }, { 1, "下週一" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週一前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週一後" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上週二" }, { 0, "本週二" }, { 1, "下週二" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週二前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週二後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上週二" }, { 0, "本週二" }, { 1, "下週二" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週二前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週二後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上週二" }, { 0, "本週二" }, { 1, "下週二" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週二前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週二後" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上週三" }, { 0, "本週三" }, { 1, "下週三" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週三前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週三後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上週三" }, { 0, "本週三" }, { 1, "下週三" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週三前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週三後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上週三" }, { 0, "本週三" }, { 1, "下週三" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週三前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週三後" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上週四" }, { 0, "本週四" }, { 1, "下週四" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週四前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週四後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上週四" }, { 0, "本週四" }, { 1, "下週四" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週四前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週四後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上週四" }, { 0, "本週四" }, { 1, "下週四" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週四前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週四後" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上週五" }, { 0, "本週五" }, { 1, "下週五" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週五前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週五後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上週五" }, { 0, "本週五" }, { 1, "下週五" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週五前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週五後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上週五" }, { 0, "本週五" }, { 1, "下週五" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週五前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週五後" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上週六" }, { 0, "本週六" }, { 1, "下週六" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週六前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週六後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上週六" }, { 0, "本週六" }, { 1, "下週六" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週六前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週六後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上週六" }, { 0, "本週六" }, { 1, "下週六" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週六前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個週六後" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayPeriod,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Long,
                "上午/下午",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Narrow,
                "上午/下午",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Short,
                "上午/下午",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "小時",
                new Dictionary<int, string> { { 0, "這一小時" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 小時前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 小時後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "小時",
                new Dictionary<int, string> { { 0, "這一小時" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 小時前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 小時後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "小時",
                new Dictionary<int, string> { { 0, "這一小時" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 小時前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 小時後" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "分鐘",
                new Dictionary<int, string> { { 0, "這一分鐘" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分鐘前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分鐘後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "分鐘",
                new Dictionary<int, string> { { 0, "這一分鐘" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分鐘前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分鐘後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "分鐘",
                new Dictionary<int, string> { { 0, "這一分鐘" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分鐘前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分鐘後" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "秒",
                new Dictionary<int, string> { { 0, "現在" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "秒",
                new Dictionary<int, string> { { 0, "現在" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "秒",
                new Dictionary<int, string> { { 0, "現在" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒後" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Chinese' [zh-Hant]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Zone,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Long,
                "時區",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Narrow,
                "時區",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Short,
                "時區",
                null,
                null,
                null));

        /// <summary>
        /// Gets the Relative Time resource styles based on the unit specified
        /// </summary>
        /// <param name="relativeTimeUnit">The resource unit to get</param>
        /// <returns>An <see cref="IRelativeTimeStylesResource"/></returns>
        /// <exception cref="NotImplementedException"></exception>
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
            _ => throw new NotImplementedException($"Relative time unit '{relativeTimeUnit}' is not supported")
        };
    }
}