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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Vietnamese' [vi]
    /// </summary>
    public class VietnameseRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "vi";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "Năm",
                new Dictionary<int, string> { { -1, "năm ngoái" }, { 0, "năm nay" }, { 1, "năm sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} năm trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} năm nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "Năm",
                new Dictionary<int, string> { { -1, "năm ngoái" }, { 0, "năm nay" }, { 1, "năm sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} năm trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} năm nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "Năm",
                new Dictionary<int, string> { { -1, "năm ngoái" }, { 0, "năm nay" }, { 1, "năm sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} năm trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} năm nữa" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "Quý",
                new Dictionary<int, string> { { -1, "quý trước" }, { 0, "quý này" }, { 1, "quý sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} quý trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} quý nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "Quý",
                new Dictionary<int, string> { { -1, "quý trước" }, { 0, "quý này" }, { 1, "quý sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} quý trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} quý nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "Quý",
                new Dictionary<int, string> { { -1, "quý trước" }, { 0, "quý này" }, { 1, "quý sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} quý trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} quý nữa" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "Tháng",
                new Dictionary<int, string> { { -1, "tháng trước" }, { 0, "tháng này" }, { 1, "tháng sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tháng trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tháng nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "Tháng",
                new Dictionary<int, string> { { -1, "tháng trước" }, { 0, "tháng này" }, { 1, "tháng sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tháng trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tháng nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "Tháng",
                new Dictionary<int, string> { { -1, "tháng trước" }, { 0, "tháng này" }, { 1, "tháng sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tháng trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tháng nữa" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "Tuần",
                new Dictionary<int, string> { { -1, "tuần trước" }, { 0, "tuần này" }, { 1, "tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tuần trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tuần nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "Tuần",
                new Dictionary<int, string> { { -1, "tuần trước" }, { 0, "tuần này" }, { 1, "tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tuần trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tuần nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "Tuần",
                new Dictionary<int, string> { { -1, "tuần trước" }, { 0, "tuần này" }, { 1, "tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tuần trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tuần nữa" } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "Ngày",
                new Dictionary<int, string> { { -2, "Hôm kia" }, { -1, "Hôm qua" }, { 0, "Hôm nay" }, { 1, "Ngày mai" }, { 2, "Ngày kia" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ngày trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} ngày nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "Ngày",
                new Dictionary<int, string> { { -2, "Hôm kia" }, { -1, "hôm qua" }, { 0, "hôm nay" }, { 1, "ngày mai" }, { 2, "Ngày kia" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ngày trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} ngày nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "Ngày",
                new Dictionary<int, string> { { -2, "Hôm kia" }, { -1, "hôm qua" }, { 0, "hôm nay" }, { 1, "ngày mai" }, { 2, "Ngày kia" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ngày trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} ngày nữa" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Chủ Nhật tuần trước" }, { 0, "Chủ Nhật tuần này" }, { 1, "Chủ Nhật tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Chủ Nhật trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Chủ Nhật nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Chủ Nhật tuần trước" }, { 0, "Chủ Nhật tuần này" }, { 1, "Chủ Nhật tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Chủ Nhật trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Chủ Nhật nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Chủ Nhật tuần trước" }, { 0, "Chủ Nhật tuần này" }, { 1, "Chủ Nhật tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Chủ Nhật trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Chủ Nhật nữa" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Thứ Hai tuần trước" }, { 0, "Thứ Hai tuần này" }, { 1, "Thứ Hai tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Hai trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Hai nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Thứ Hai tuần trước" }, { 0, "Thứ Hai tuần này" }, { 1, "Thứ Hai tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Hai trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Hai nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Thứ Hai tuần trước" }, { 0, "Thứ Hai tuần này" }, { 1, "Thứ Hai tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Hai trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Hai nữa" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Thứ Ba tuần trước" }, { 0, "Thứ Ba tuần này" }, { 1, "Thứ Ba tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Ba trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Ba nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Thứ Ba tuần trước" }, { 0, "Thứ Ba tuần này" }, { 1, "Thứ Ba tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Ba trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Ba nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Thứ Ba tuần trước" }, { 0, "Thứ Ba tuần này" }, { 1, "Thứ Ba tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Ba trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Ba nữa" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Thứ Tư tuần trước" }, { 0, "Thứ Tư tuần này" }, { 1, "Thứ Tư tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Tư trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Tư nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Thứ Tư tuần trước" }, { 0, "Thứ Tư tuần này" }, { 1, "Thứ Tư tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Tư trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Tư nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Thứ Tư tuần trước" }, { 0, "Thứ Tư tuần này" }, { 1, "Thứ Tư tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Tư trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Tư nữa" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Thứ Năm tuần trước" }, { 0, "Thứ Năm tuần này" }, { 1, "Thứ Năm tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Năm trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Năm nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Thứ Năm tuần trước" }, { 0, "Thứ Năm tuần này" }, { 1, "Thứ Năm tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Năm trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Năm nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Thứ Năm tuần trước" }, { 0, "Thứ Năm tuần này" }, { 1, "Thứ Năm tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Năm trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Năm nữa" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Thứ Sáu tuần trước" }, { 0, "Thứ Sáu tuần này" }, { 1, "Thứ Sáu tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Sáu trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Sáu nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Thứ Sáu tuần trước" }, { 0, "Thứ Sáu tuần này" }, { 1, "Thứ Sáu tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Sáu trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Sáu nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Thứ Sáu tuần trước" }, { 0, "Thứ Sáu tuần này" }, { 1, "Thứ Sáu tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Sáu trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Sáu nữa" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Thứ Bảy tuần trước" }, { 0, "Thứ Bảy tuần này" }, { 1, "Thứ Bảy tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Bảy trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Bảy nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Thứ Bảy tuần trước" }, { 0, "Thứ Bảy tuần này" }, { 1, "Thứ Bảy tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Bảy trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Bảy nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Thứ Bảy tuần trước" }, { 0, "Thứ Bảy tuần này" }, { 1, "Thứ Bảy tuần sau" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Bảy trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Bảy nữa" } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "Giờ",
                new Dictionary<int, string> { { 0, "giờ này" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giờ trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giờ nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "Giờ",
                new Dictionary<int, string> { { 0, "giờ này" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giờ trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giờ nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "Giờ",
                new Dictionary<int, string> { { 0, "giờ này" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giờ trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giờ nữa" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "Phút",
                new Dictionary<int, string> { { 0, "phút này" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} phút trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} phút nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "Phút",
                new Dictionary<int, string> { { 0, "phút này" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} phút trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} phút nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "Phút",
                new Dictionary<int, string> { { 0, "phút này" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} phút trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} phút nữa" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Vietnamese' [vi]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "Giây",
                new Dictionary<int, string> { { 0, "bây giờ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giây trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giây nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "Giây",
                new Dictionary<int, string> { { 0, "bây giờ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giây trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giây nữa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "Giây",
                new Dictionary<int, string> { { 0, "bây giờ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giây trước" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giây nữa" } }));

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