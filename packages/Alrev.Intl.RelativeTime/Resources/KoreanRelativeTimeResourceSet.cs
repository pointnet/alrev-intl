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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Korean' [ko]
    /// </summary>
    public class KoreanRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ko";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Era,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Long,
                "연호",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Narrow,
                "연호",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Short,
                "연호",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "년",
                new Dictionary<int, string> { { -1, "작년" }, { 0, "올해" }, { 1, "내년" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}년 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}년 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "년",
                new Dictionary<int, string> { { -1, "작년" }, { 0, "올해" }, { 1, "내년" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}년 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}년 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "년",
                new Dictionary<int, string> { { -1, "작년" }, { 0, "올해" }, { 1, "내년" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}년 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}년 후" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "분기",
                new Dictionary<int, string> { { -1, "지난 분기" }, { 0, "이번 분기" }, { 1, "다음 분기" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분기 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분기 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "분기",
                new Dictionary<int, string> { { -1, "지난 분기" }, { 0, "이번 분기" }, { 1, "다음 분기" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분기 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분기 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "분기",
                new Dictionary<int, string> { { -1, "지난 분기" }, { 0, "이번 분기" }, { 1, "다음 분기" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분기 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분기 후" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "월",
                new Dictionary<int, string> { { -1, "지난달" }, { 0, "이번 달" }, { 1, "다음 달" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}개월 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}개월 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "월",
                new Dictionary<int, string> { { -1, "지난달" }, { 0, "이번 달" }, { 1, "다음 달" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}개월 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}개월 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "월",
                new Dictionary<int, string> { { -1, "지난달" }, { 0, "이번 달" }, { 1, "다음 달" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}개월 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}개월 후" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "주",
                new Dictionary<int, string> { { -1, "지난주" }, { 0, "이번 주" }, { 1, "다음 주" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "주",
                new Dictionary<int, string> { { -1, "지난주" }, { 0, "이번 주" }, { 1, "다음 주" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "주",
                new Dictionary<int, string> { { -1, "지난주" }, { 0, "이번 주" }, { 1, "다음 주" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Long,
                "월의 주",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Narrow,
                "월의 주",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Short,
                "월의 주",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "일",
                new Dictionary<int, string> { { -2, "그저께" }, { -1, "어제" }, { 0, "오늘" }, { 1, "내일" }, { 2, "모레" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}일 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}일 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "일",
                new Dictionary<int, string> { { -2, "그저께" }, { -1, "어제" }, { 0, "오늘" }, { 1, "내일" }, { 2, "모레" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}일 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}일 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "일",
                new Dictionary<int, string> { { -2, "그저께" }, { -1, "어제" }, { 0, "오늘" }, { 1, "내일" }, { 2, "모레" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}일 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}일 후" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayOfYear,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Long,
                "년의 일",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Narrow,
                "년의 일",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Short,
                "년의 일",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Weekday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Long,
                "요일",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Narrow,
                "요일",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Short,
                "요일",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekdayOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Long,
                "월의 평일",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Narrow,
                "월의 평일",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Short,
                "월의 평일",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "지난 일요일" }, { 0, "이번 일요일" }, { 1, "다음 일요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 일요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 일요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "지난 일요일" }, { 0, "이번 일요일" }, { 1, "다음 일요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 일요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 일요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "지난 일요일" }, { 0, "이번 일요일" }, { 1, "다음 일요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 일요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 일요일" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "지난 월요일" }, { 0, "이번 월요일" }, { 1, "다음 월요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 월요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 월요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "지난 월요일" }, { 0, "이번 월요일" }, { 1, "다음 월요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 월요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 월요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "지난 월요일" }, { 0, "이번 월요일" }, { 1, "다음 월요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 월요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 월요일" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "지난 화요일" }, { 0, "이번 화요일" }, { 1, "다음 화요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 화요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 화요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "지난 화요일" }, { 0, "이번 화요일" }, { 1, "다음 화요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 화요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 화요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "지난 화요일" }, { 0, "이번 화요일" }, { 1, "다음 화요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 화요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 화요일" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "지난 수요일" }, { 0, "이번 수요일" }, { 1, "다음 수요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 수요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 수요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "지난 수요일" }, { 0, "이번 수요일" }, { 1, "다음 수요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 수요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 수요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "지난 수요일" }, { 0, "이번 수요일" }, { 1, "다음 수요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 수요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 수요일" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "지난 목요일" }, { 0, "이번 목요일" }, { 1, "다음 목요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 목요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 목요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "지난 목요일" }, { 0, "이번 목요일" }, { 1, "다음 목요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 목요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 목요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "지난 목요일" }, { 0, "이번 목요일" }, { 1, "다음 목요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 목요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 목요일" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "지난 금요일" }, { 0, "이번 금요일" }, { 1, "다음 금요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 금요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 금요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "지난 금요일" }, { 0, "이번 금요일" }, { 1, "다음 금요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 금요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 금요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "지난 금요일" }, { 0, "이번 금요일" }, { 1, "다음 금요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 금요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 금요일" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "지난 토요일" }, { 0, "이번 토요일" }, { 1, "다음 토요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 토요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 토요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "지난 토요일" }, { 0, "이번 토요일" }, { 1, "다음 토요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 토요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 토요일" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "지난 토요일" }, { 0, "이번 토요일" }, { 1, "다음 토요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 전 토요일" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}주 후 토요일" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayPeriod,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Long,
                "오전/오후",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Narrow,
                "오전/오후",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Short,
                "오전/오후",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "시",
                new Dictionary<int, string> { { 0, "현재 시간" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}시간 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}시간 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "시",
                new Dictionary<int, string> { { 0, "현재 시간" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}시간 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}시간 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "시",
                new Dictionary<int, string> { { 0, "현재 시간" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}시간 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}시간 후" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "분",
                new Dictionary<int, string> { { 0, "현재 분" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "분",
                new Dictionary<int, string> { { 0, "현재 분" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "분",
                new Dictionary<int, string> { { 0, "현재 분" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}분 후" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "초",
                new Dictionary<int, string> { { 0, "지금" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}초 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}초 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "초",
                new Dictionary<int, string> { { 0, "지금" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}초 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}초 후" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "초",
                new Dictionary<int, string> { { 0, "지금" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}초 전" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}초 후" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Korean' [ko]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Zone,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Long,
                "시간대",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Narrow,
                "시간대",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Short,
                "시간대",
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