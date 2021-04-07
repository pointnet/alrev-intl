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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Indonesian' [id]
    /// </summary>
    public class IndonesianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "id";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
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
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "tahun",
                new Dictionary<int, string> { { -1, "tahun lalu" }, { 0, "tahun ini" }, { 1, "tahun depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tahun yang lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} tahun" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "thn.",
                new Dictionary<int, string> { { -1, "thn lalu" }, { 0, "thn ini" }, { 1, "thn depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} thn lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} thn" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "thn.",
                new Dictionary<int, string> { { -1, "thn lalu" }, { 0, "thn ini" }, { 1, "thn depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} thn lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} thn" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "kuartal",
                new Dictionary<int, string> { { -1, "Kuartal lalu" }, { 0, "kuartal ini" }, { 1, "kuartal berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} kuartal yang lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} kuartal" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "krtl.",
                new Dictionary<int, string> { { -1, "Kuartal lalu" }, { 0, "kuartal ini" }, { 1, "kuartal berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} krtl. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} krtl." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "krtl.",
                new Dictionary<int, string> { { -1, "Kuartal lalu" }, { 0, "kuartal ini" }, { 1, "kuartal berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} krtl. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} krtl." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "bulan",
                new Dictionary<int, string> { { -1, "bulan lalu" }, { 0, "bulan ini" }, { 1, "bulan berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} bulan yang lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} bulan" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "bln.",
                new Dictionary<int, string> { { -1, "bln lalu" }, { 0, "bln ini" }, { 1, "bln berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} bln lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} bln" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "bln.",
                new Dictionary<int, string> { { -1, "bln lalu" }, { 0, "bln ini" }, { 1, "bln berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} bln lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} bln" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "minggu",
                new Dictionary<int, string> { { -1, "minggu lalu" }, { 0, "minggu ini" }, { 1, "minggu depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} minggu yang lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} minggu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "mgg.",
                new Dictionary<int, string> { { -1, "mgg lalu" }, { 0, "mgg ini" }, { 1, "mgg depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mgg lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mgg" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "mgg.",
                new Dictionary<int, string> { { -1, "mgg lalu" }, { 0, "mgg ini" }, { 1, "mgg depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mgg lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mgg" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "minggu",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "mgg.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "mgg.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "hari",
                new Dictionary<int, string> { { -2, "kemarin dulu" }, { -1, "kemarin" }, { 0, "hari ini" }, { 1, "besok" }, { 2, "lusa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} hari yang lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} hari" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "h",
                new Dictionary<int, string> { { -2, "kemarin dulu" }, { -1, "kemarin" }, { 0, "hari ini" }, { 1, "besok" }, { 2, "lusa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} h lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "h",
                new Dictionary<int, string> { { -2, "kemarin dulu" }, { -1, "kemarin" }, { 0, "hari ini" }, { 1, "besok" }, { 2, "lusa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} h lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} h" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "hari dalam setahun",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "hari dlm 1 thn",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "hari dlm setahun",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "hari dalam seminggu",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "hari dlm seminggu",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "hari dlm seminggu",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "hari kerja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "hr kerja",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "hr kerja",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "hari Minggu lalu" }, { 0, "hari Minggu ini" }, { 1, "hari Minggu berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} hari Minggu yang lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} hari Minggu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Min. lalu" }, { 0, "Min. ini" }, { 1, "Min. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Min. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Min." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Min. lalu" }, { 0, "Min. ini" }, { 1, "Min. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Min. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Min." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Senin lalu" }, { 0, "Senin ini" }, { 1, "Senin berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Senin lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Senin" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Sen. lalu" }, { 0, "Sen. ini" }, { 1, "Sen. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sen. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sen." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Sen. lalu" }, { 0, "Sen. ini" }, { 1, "Sen. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sen. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sen." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Selasa lalu" }, { 0, "Selasa ini" }, { 1, "Selasa berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Selasa lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Selasa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Sel. lalu" }, { 0, "Sel. ini" }, { 1, "Sel. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sel. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sel." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Sel. lalu" }, { 0, "Sel. ini" }, { 1, "Sel. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sel. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sel." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Rabu lalu" }, { 0, "Rabu ini" }, { 1, "Rabu berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Rabu lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Rabu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Rab. lalu" }, { 0, "Rab. ini" }, { 1, "Rab. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Rab. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Rab." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Rab. lalu" }, { 0, "Rab. ini" }, { 1, "Rab. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Rab. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Rab." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Kamis lalu" }, { 0, "Kamis ini" }, { 1, "Kamis berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Kamis lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Kamis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Kam. lalu" }, { 0, "Kam. ini" }, { 1, "Kam. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Kam. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Kam." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Kam. lalu" }, { 0, "Kam. ini" }, { 1, "Kam. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Kam. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Kam." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Jumat lalu" }, { 0, "Jumat ini" }, { 1, "Jumat berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Jumat lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Jumat" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Jum. lalu" }, { 0, "Jum. ini" }, { 1, "Jum. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Jum. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Jum." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Jum. lalu" }, { 0, "Jum. ini" }, { 1, "Jum. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Jum. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Jum." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Sabtu lalu" }, { 0, "Sabtu ini" }, { 1, "Sabtu berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sabtu lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Sabtu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Sab. lalu" }, { 0, "Sab. ini" }, { 1, "Sab. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sab. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sab." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Sab. lalu" }, { 0, "Sab. ini" }, { 1, "Sab. berikutnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sab. lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sab." } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "AM/PM",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "AM/PM",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "AM/PM",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "Jam",
                new Dictionary<int, string> { { 0, "jam ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} jam yang lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} jam" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "j",
                new Dictionary<int, string> { { 0, "jam ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} jam lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} jam" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "jam",
                new Dictionary<int, string> { { 0, "jam ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} jam lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} jam" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "menit",
                new Dictionary<int, string> { { 0, "menit ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} menit yang lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} menit" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "m",
                new Dictionary<int, string> { { 0, "menit ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mnt lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mnt" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "mnt.",
                new Dictionary<int, string> { { 0, "menit ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mnt lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mnt" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "detik",
                new Dictionary<int, string> { { 0, "sekarang" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} detik yang lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} detik" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "d",
                new Dictionary<int, string> { { 0, "sekarang" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dtk lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} dtk" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "dtk.",
                new Dictionary<int, string> { { 0, "sekarang" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dtk lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} dtk" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Indonesian' [id]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "zona waktu",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "zona wkt",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "zona wkt",
                null,
                null,
                null));
    }
}