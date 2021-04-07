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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Malay (Brunei)' [ms-bn]
    /// </summary>
    public class MalayBruneiRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ms-bn";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Era,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Long,
                "era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Narrow,
                "era",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Short,
                "era",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "tahun",
                new Dictionary<int, string> { { -1, "tahun lalu" }, { 0, "tahun ini" }, { 1, "tahun depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tahun lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} tahun" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "thn",
                new Dictionary<int, string> { { -1, "thn lepas" }, { 0, "thn ini" }, { 1, "thn depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} thn lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} thn" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "thn",
                new Dictionary<int, string> { { -1, "thn lepas" }, { 0, "thn ini" }, { 1, "thn depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} thn lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} thn" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "suku tahun",
                new Dictionary<int, string> { { -1, "suku tahun lalu" }, { 0, "suku tahun ini" }, { 1, "suku tahun seterusnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} suku tahun lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} suku tahun" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "suku",
                new Dictionary<int, string> { { -1, "suku lepas" }, { 0, "suku ini" }, { 1, "suku seterusnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} suku thn lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} suku thn" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "suku",
                new Dictionary<int, string> { { -1, "suku lepas" }, { 0, "suku ini" }, { 1, "suku seterusnya" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} suku thn lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} suku thn" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "bulan",
                new Dictionary<int, string> { { -1, "bulan lalu" }, { 0, "bulan ini" }, { 1, "bulan depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} bulan lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} bulan" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "bln",
                new Dictionary<int, string> { { -1, "bln lalu" }, { 0, "bln ini" }, { 1, "bln depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} bulan lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} bln" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "bln",
                new Dictionary<int, string> { { -1, "bln lalu" }, { 0, "bln ini" }, { 1, "bln depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} bln lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} bln" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "minggu",
                new Dictionary<int, string> { { -1, "minggu lalu" }, { 0, "minggu ini" }, { 1, "minggu depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} minggu lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} minggu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "mgu",
                new Dictionary<int, string> { { -1, "mgu lepas" }, { 0, "mgu ini" }, { 1, "mgu depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mgu lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mgu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "mgu",
                new Dictionary<int, string> { { -1, "mgu lepas" }, { 0, "mgu ini" }, { 1, "mgu depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mgu lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mgu" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
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
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "hari",
                new Dictionary<int, string> { { -2, "kelmarin" }, { -1, "semalam" }, { 0, "hari ini" }, { 1, "esok" }, { 2, "lusa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} hari lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} hari" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "hari",
                new Dictionary<int, string> { { -2, "kelmarin" }, { -1, "semlm" }, { 0, "hari ini" }, { 1, "esok" }, { 2, "lusa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} hari lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} hari" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "hari",
                new Dictionary<int, string> { { -2, "kelmarin" }, { -1, "semalam" }, { 0, "hari ini" }, { 1, "esok" }, { 2, "lusa" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} hari lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} hari" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
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
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Weekday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Long,
                "Hari dalam Minggu",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Narrow,
                "Hari dalam Minggu",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Short,
                "Hari dalam Minggu",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
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
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Ahad lalu" }, { 0, "Ahad ini" }, { 1, "Ahad depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Ahad lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Ahad" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Ahd lalu" }, { 0, "Ahd ini" }, { 1, "Ahd depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Ahd lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pd {0} Ahd" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Ahd lalu" }, { 0, "Ahd ini" }, { 1, "Ahd depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Ahd lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Ahd" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Isnin lalu" }, { 0, "Isnin ini" }, { 1, "Isnin depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Isnin lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Isnin" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Isn lalu" }, { 0, "Isn ini" }, { 1, "Isn depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Isn lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pd {0} Isn" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Isn lalu" }, { 0, "Isn ini" }, { 1, "Isn depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Isn lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Isn" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Selasa lalu" }, { 0, "Selasa ini" }, { 1, "Selasa depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Selasa lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Selasa" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Sel lalu" }, { 0, "Sel ini" }, { 1, "Sel depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sel lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Sel" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Sel lalu" }, { 0, "Sel ini" }, { 1, "Sel depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sel lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Sel" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Rabu lalu" }, { 0, "Rabu ini" }, { 1, "Rabu depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Rabu lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Rabu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Rab lalu" }, { 0, "Rab ini" }, { 1, "Rab depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Rab lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pd {0} Rab" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Rab lalu" }, { 0, "Rab ini" }, { 1, "Rab depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Rab lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Rab" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Khamis lalu" }, { 0, "Khamis ini" }, { 1, "Khamis depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Khamis lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Khamis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Kha lalu" }, { 0, "Kha ini" }, { 1, "Kha depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Kha lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Kha" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Kha lalu" }, { 0, "Kha ini" }, { 1, "Kha depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Kha lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Kha" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Jumaat lalu" }, { 0, "Jumaat ini" }, { 1, "Jumaat depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Jumaat lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Jumaat" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Jum lalu" }, { 0, "Jum ini" }, { 1, "Jum depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Jum lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pd {0} Jum" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Jum lalu" }, { 0, "Jum ini" }, { 1, "Jum depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Jum lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Jum" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Sabtu lalu" }, { 0, "Sabtu ini" }, { 1, "Sabtu depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sabtu lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Sabtu" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Sab lalu" }, { 0, "Sab ini" }, { 1, "Sab depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sab lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Sab" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Sab lalu" }, { 0, "Sab ini" }, { 1, "Sab depan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sab lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "pada {0} Sab" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayPeriod,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Long,
                "PG/PTG",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Narrow,
                "PG/PTG",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Short,
                "PG/PTG",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "jam",
                new Dictionary<int, string> { { 0, "jam ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} jam lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} jam" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "jam",
                new Dictionary<int, string> { { 0, "jam ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} jam lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} jam" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "jam",
                new Dictionary<int, string> { { 0, "jam ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} jam lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} jam" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "minit",
                new Dictionary<int, string> { { 0, "pada minit ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} minit lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} minit" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "pada minit ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} min lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "pada minit ini" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} min lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} min" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "saat",
                new Dictionary<int, string> { { 0, "sekarang" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} saat lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} saat" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "saat",
                new Dictionary<int, string> { { 0, "sekarang" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} saat lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} saat" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "saat",
                new Dictionary<int, string> { { 0, "sekarang" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} saat lalu" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} saat" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Malay (Brunei)' [ms-bn]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Zone,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Long,
                "zon waktu",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Narrow,
                "zon",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Short,
                "zon",
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