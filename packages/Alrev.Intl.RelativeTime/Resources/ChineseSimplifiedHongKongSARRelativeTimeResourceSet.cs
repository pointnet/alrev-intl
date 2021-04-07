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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
    /// </summary>
    public class ChineseSimplifiedHongKongSARRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "zh-hans-hk";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Era,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Long,
                "纪元",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Narrow,
                "纪元",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Short,
                "纪元",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
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
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "年",
                new Dictionary<int, string> { { -1, "去年" }, { 0, "今年" }, { 1, "明年" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "年",
                new Dictionary<int, string> { { -1, "去年" }, { 0, "今年" }, { 1, "明年" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年后" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "季度",
                new Dictionary<int, string> { { -1, "上季度" }, { 0, "本季度" }, { 1, "下季度" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "季",
                new Dictionary<int, string> { { -1, "上季度" }, { 0, "本季度" }, { 1, "下季度" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "季",
                new Dictionary<int, string> { { -1, "上季度" }, { 0, "本季度" }, { 1, "下季度" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度后" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "月",
                new Dictionary<int, string> { { -1, "上个月" }, { 0, "本月" }, { 1, "下个月" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "月",
                new Dictionary<int, string> { { -1, "上个月" }, { 0, "本月" }, { 1, "下个月" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "月",
                new Dictionary<int, string> { { -1, "上个月" }, { 0, "本月" }, { 1, "下个月" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月后" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "周",
                new Dictionary<int, string> { { -1, "上周" }, { 0, "本周" }, { 1, "下周" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "周",
                new Dictionary<int, string> { { -1, "上周" }, { 0, "本周" }, { 1, "下周" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "周",
                new Dictionary<int, string> { { -1, "上周" }, { 0, "本周" }, { 1, "下周" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周后" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Long,
                "月中周",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Narrow,
                "月中周",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Short,
                "月中周",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "日",
                new Dictionary<int, string> { { -2, "前天" }, { -1, "昨天" }, { 0, "今天" }, { 1, "明天" }, { 2, "后天" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "日",
                new Dictionary<int, string> { { -2, "前天" }, { -1, "昨天" }, { 0, "今天" }, { 1, "明天" }, { 2, "后天" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "日",
                new Dictionary<int, string> { { -2, "前天" }, { -1, "昨天" }, { 0, "今天" }, { 1, "明天" }, { 2, "后天" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天后" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayOfYear,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Long,
                "年中日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Narrow,
                "年中日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Short,
                "年中日",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Weekday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Long,
                "工作日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Narrow,
                "工作日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Short,
                "工作日",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekdayOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Long,
                "月中日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Narrow,
                "月中日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Short,
                "月中日",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上周日" }, { 0, "本周日" }, { 1, "下周日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上周日" }, { 0, "本周日" }, { 1, "下周日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上周日" }, { 0, "本周日" }, { 1, "下周日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日后" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上周一" }, { 0, "本周一" }, { 1, "下周一" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上周一" }, { 0, "本周一" }, { 1, "下周一" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上周一" }, { 0, "本周一" }, { 1, "下周一" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一后" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上周二" }, { 0, "本周二" }, { 1, "下周二" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上周二" }, { 0, "本周二" }, { 1, "下周二" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上周二" }, { 0, "本周二" }, { 1, "下周二" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二后" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上周三" }, { 0, "本周三" }, { 1, "下周三" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上周三" }, { 0, "本周三" }, { 1, "下周三" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上周三" }, { 0, "本周三" }, { 1, "下周三" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三后" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上周四" }, { 0, "本周四" }, { 1, "下周四" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上周四" }, { 0, "本周四" }, { 1, "下周四" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上周四" }, { 0, "本周四" }, { 1, "下周四" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四后" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上周五" }, { 0, "本周五" }, { 1, "下周五" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上周五" }, { 0, "本周五" }, { 1, "下周五" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上周五" }, { 0, "本周五" }, { 1, "下周五" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五后" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "上周六" }, { 0, "本周六" }, { 1, "下周六" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "上周六" }, { 0, "本周六" }, { 1, "下周六" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "上周六" }, { 0, "本周六" }, { 1, "下周六" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六后" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
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
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "小时",
                new Dictionary<int, string> { { 0, "这一时间 / 此时" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "小时",
                new Dictionary<int, string> { { 0, "这一时间 / 此时" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "小时",
                new Dictionary<int, string> { { 0, "这一时间 / 此时" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时后" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "分钟",
                new Dictionary<int, string> { { 0, "此刻" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "分",
                new Dictionary<int, string> { { 0, "此刻" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "分",
                new Dictionary<int, string> { { 0, "此刻" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟后" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "秒",
                new Dictionary<int, string> { { 0, "现在" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "秒",
                new Dictionary<int, string> { { 0, "现在" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒后" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "秒",
                new Dictionary<int, string> { { 0, "现在" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒后" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Chinese (Simplified, Hong Kong SAR)' [zh-hans-hk]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Zone,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Long,
                "时区",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Narrow,
                "时区",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Short,
                "时区",
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