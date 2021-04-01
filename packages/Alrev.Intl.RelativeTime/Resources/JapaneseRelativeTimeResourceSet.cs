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
    public class JapaneseRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ja";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "時代",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "時代",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "時代",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "年",
                new Dictionary<int, string> { { -1, "昨年" }, { 0, "今年" }, { 1, "来年" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "年",
                new Dictionary<int, string> { { -1, "昨年" }, { 0, "今年" }, { 1, "来年" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "年",
                new Dictionary<int, string> { { -1, "昨年" }, { 0, "今年" }, { 1, "来年" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 年後" } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "四半期",
                new Dictionary<int, string> { { -1, "前四半期" }, { 0, "今四半期" }, { 1, "翌四半期" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 四半期前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 四半期後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "四半期",
                new Dictionary<int, string> { { -1, "前四半期" }, { 0, "今四半期" }, { 1, "翌四半期" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}四半期前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}四半期後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "四半期",
                new Dictionary<int, string> { { -1, "前四半期" }, { 0, "今四半期" }, { 1, "翌四半期" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 四半期前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 四半期後" } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "月",
                new Dictionary<int, string> { { -1, "先月" }, { 0, "今月" }, { 1, "来月" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} か月前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} か月後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "月",
                new Dictionary<int, string> { { -1, "先月" }, { 0, "今月" }, { 1, "来月" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}か月前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}か月後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "月",
                new Dictionary<int, string> { { -1, "先月" }, { 0, "今月" }, { 1, "来月" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} か月前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} か月後" } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "週",
                new Dictionary<int, string> { { -1, "先週" }, { 0, "今週" }, { 1, "来週" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週間前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週間後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "週",
                new Dictionary<int, string> { { -1, "先週" }, { 0, "今週" }, { 1, "来週" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}週間前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}週間後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "週",
                new Dictionary<int, string> { { -1, "先週" }, { 0, "今週" }, { 1, "来週" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週間前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 週間後" } }));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "月の週番号",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "月の週番号",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "月の週番号",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "日",
                new Dictionary<int, string> { { -2, "一昨日" }, { -1, "昨日" }, { 0, "今日" }, { 1, "明日" }, { 2, "明後日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 日前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 日後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "日",
                new Dictionary<int, string> { { -2, "一昨日" }, { -1, "昨日" }, { 0, "今日" }, { 1, "明日" }, { 2, "明後日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}日前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}日後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "日",
                new Dictionary<int, string> { { -2, "一昨日" }, { -1, "昨日" }, { 0, "今日" }, { 1, "明日" }, { 2, "明後日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 日前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 日後" } }));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "年の通日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "通日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "年の通日",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "曜日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "曜日",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "曜日",
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "月の曜日番号",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "月の曜日番号",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "月の曜日番号",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "先週の日曜日" }, { 0, "今週の日曜日" }, { 1, "来週の日曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の日曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の日曜日" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "先週の日曜" }, { 0, "今週の日曜" }, { 1, "来週の日曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個前の日曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個後の日曜" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "先週の日曜" }, { 0, "今週の日曜" }, { 1, "来週の日曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の日曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の日曜" } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "先週の月曜日" }, { 0, "今週の月曜日" }, { 1, "来週の月曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の月曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の月曜日" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "先週の月曜" }, { 0, "今週の月曜" }, { 1, "来週の月曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個前の月曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個後の月曜" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "先週の月曜" }, { 0, "今週の月曜" }, { 1, "来週の月曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の月曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の月曜" } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "先週の火曜日" }, { 0, "今週の火曜日" }, { 1, "来週の火曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の火曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の火曜日" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "先週の火曜" }, { 0, "今週の火曜" }, { 1, "来週の火曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個前の火曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個後の火曜" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "先週の火曜" }, { 0, "今週の火曜" }, { 1, "来週の火曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の火曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の火曜" } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "先週の水曜日" }, { 0, "今週の水曜日" }, { 1, "来週の水曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の水曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の水曜日" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "先週の水曜" }, { 0, "今週の水曜" }, { 1, "来週の水曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個前の水曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個後の水曜" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "先週の水曜" }, { 0, "今週の水曜" }, { 1, "来週の水曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の水曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の水曜" } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "先週の木曜日" }, { 0, "今週の木曜日" }, { 1, "来週の木曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の木曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の木曜日" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "先週の木曜" }, { 0, "今週の木曜" }, { 1, "来週の木曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個前の木曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個後の木曜" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "先週の木曜" }, { 0, "今週の木曜" }, { 1, "来週の木曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の木曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の木曜" } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "先週の金曜日" }, { 0, "今週の金曜日" }, { 1, "来週の金曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の金曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の金曜日" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "先週の金曜" }, { 0, "今週の金曜" }, { 1, "来週の金曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個前の金曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個後の金曜" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "先週の金曜" }, { 0, "今週の金曜" }, { 1, "来週の金曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の金曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の金曜" } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "先週の土曜日" }, { 0, "今週の土曜日" }, { 1, "来週の土曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の土曜日" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の土曜日" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "先週の土曜" }, { 0, "今週の土曜" }, { 1, "来週の土曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個前の土曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}個後の土曜" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "先週の土曜" }, { 0, "今週の土曜" }, { 1, "来週の土曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個前の土曜" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 個後の土曜" } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "午前/午後",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "午前/午後",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "午前/午後",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "時",
                new Dictionary<int, string> { { 0, "1 時間以内" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 時間前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 時間後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "時",
                new Dictionary<int, string> { { 0, "1 時間以内" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}時間前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}時間後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "時",
                new Dictionary<int, string> { { 0, "1 時間以内" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 時間前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 時間後" } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "分",
                new Dictionary<int, string> { { 0, "1 分以内" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "分",
                new Dictionary<int, string> { { 0, "1 分以内" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "分",
                new Dictionary<int, string> { { 0, "1 分以内" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 分後" } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "秒",
                new Dictionary<int, string> { { 0, "今" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "秒",
                new Dictionary<int, string> { { 0, "今" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒後" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "秒",
                new Dictionary<int, string> { { 0, "今" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒前" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} 秒後" } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "タイムゾーン",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "タイムゾーン",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "タイムゾーン",
                null,
                null,
                null));
    }
}