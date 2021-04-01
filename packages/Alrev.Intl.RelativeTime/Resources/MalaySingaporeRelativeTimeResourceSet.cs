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
using Alrev.Intl.Abstractions.RelativeTime;
using System;

namespace Alrev.Intl.RelativeTime.Resources
{
    public class MalaySingaporeRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ms-SG";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "era",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "era",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "era",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "tahun",
                "tahun lalu",
                "tahun ini",
                "tahun depan",
                new RelativeTimeCountResource(null, "{0} tahun lalu"),
                new RelativeTimeCountResource(null, "dalam {0} tahun")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "thn",
                "thn lepas",
                "thn ini",
                "thn depan",
                new RelativeTimeCountResource(null, "{0} thn lalu"),
                new RelativeTimeCountResource(null, "dalam {0} thn")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "thn",
                "thn lepas",
                "thn ini",
                "thn depan",
                new RelativeTimeCountResource(null, "{0} thn lalu"),
                new RelativeTimeCountResource(null, "dalam {0} thn")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "suku tahun",
                "suku tahun lalu",
                "suku tahun ini",
                "suku tahun seterusnya",
                new RelativeTimeCountResource(null, "{0} suku tahun lalu"),
                new RelativeTimeCountResource(null, "dalam {0} suku tahun")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "suku",
                "suku lepas",
                "suku ini",
                "suku seterusnya",
                new RelativeTimeCountResource(null, "{0} suku thn lalu"),
                new RelativeTimeCountResource(null, "dlm {0} suku thn")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "suku",
                "suku lepas",
                "suku ini",
                "suku seterusnya",
                new RelativeTimeCountResource(null, "{0} suku thn lalu"),
                new RelativeTimeCountResource(null, "dlm {0} suku thn")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "bulan",
                "bulan lalu",
                "bulan ini",
                "bulan depan",
                new RelativeTimeCountResource(null, "{0} bulan lalu"),
                new RelativeTimeCountResource(null, "dalam {0} bulan")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "bln",
                "bln lalu",
                "bln ini",
                "bln depan",
                new RelativeTimeCountResource(null, "{0} bulan lalu"),
                new RelativeTimeCountResource(null, "dlm {0} bln")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "bln",
                "bln lalu",
                "bln ini",
                "bln depan",
                new RelativeTimeCountResource(null, "{0} bln lalu"),
                new RelativeTimeCountResource(null, "dlm {0} bln")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minggu",
                "minggu lalu",
                "minggu ini",
                "minggu depan",
                new RelativeTimeCountResource(null, "{0} minggu lalu"),
                new RelativeTimeCountResource(null, "dalam {0} minggu")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "mgu",
                "mgu lepas",
                "mgu ini",
                "mgu depan",
                new RelativeTimeCountResource(null, "{0} mgu lalu"),
                new RelativeTimeCountResource(null, "dlm {0} mgu")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "mgu",
                "mgu lepas",
                "mgu ini",
                "mgu depan",
                new RelativeTimeCountResource(null, "{0} mgu lalu"),
                new RelativeTimeCountResource(null, "dlm {0} mgu")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Week Of Month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Week Of Month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Week Of Month",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "hari",
                "semalam",
                "hari ini",
                "esok",
                new RelativeTimeCountResource(null, "{0} hari lalu"),
                new RelativeTimeCountResource(null, "dalam {0} hari")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "hari",
                "semlm",
                "hari ini",
                "esok",
                new RelativeTimeCountResource(null, "{0} hari lalu"),
                new RelativeTimeCountResource(null, "dlm {0} hari")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "hari",
                "semalam",
                "hari ini",
                "esok",
                new RelativeTimeCountResource(null, "{0} hari lalu"),
                new RelativeTimeCountResource(null, "dlm {0} hari")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Day Of Year",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Day Of Year",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Day Of Year",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Hari dalam Minggu",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Hari dalam Minggu",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Hari dalam Minggu",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Weekday Of Month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Weekday Of Month",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Weekday Of Month",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Ahad lalu",
                "Ahad ini",
                "Ahad depan",
                new RelativeTimeCountResource(null, "{0} Ahad lalu"),
                new RelativeTimeCountResource(null, "pada {0} Ahad")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Ahd lalu",
                "Ahd ini",
                "Ahd depan",
                new RelativeTimeCountResource(null, "{0} Ahd lalu"),
                new RelativeTimeCountResource(null, "pd {0} Ahd")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Ahd lalu",
                "Ahd ini",
                "Ahd depan",
                new RelativeTimeCountResource(null, "{0} Ahd lalu"),
                new RelativeTimeCountResource(null, "pada {0} Ahd")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Isnin lalu",
                "Isnin ini",
                "Isnin depan",
                new RelativeTimeCountResource(null, "{0} Isnin lalu"),
                new RelativeTimeCountResource(null, "pada {0} Isnin")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Isn lalu",
                "Isn ini",
                "Isn depan",
                new RelativeTimeCountResource(null, "{0} Isn lalu"),
                new RelativeTimeCountResource(null, "pd {0} Isn")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Isn lalu",
                "Isn ini",
                "Isn depan",
                new RelativeTimeCountResource(null, "{0} Isn lalu"),
                new RelativeTimeCountResource(null, "pada {0} Isn")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Selasa lalu",
                "Selasa ini",
                "Selasa depan",
                new RelativeTimeCountResource(null, "{0} Selasa lalu"),
                new RelativeTimeCountResource(null, "pada {0} Selasa")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Sel lalu",
                "Sel ini",
                "Sel depan",
                new RelativeTimeCountResource(null, "{0} Sel lalu"),
                new RelativeTimeCountResource(null, "pada {0} Sel")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Sel lalu",
                "Sel ini",
                "Sel depan",
                new RelativeTimeCountResource(null, "{0} Sel lalu"),
                new RelativeTimeCountResource(null, "pada {0} Sel")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Rabu lalu",
                "Rabu ini",
                "Rabu depan",
                new RelativeTimeCountResource(null, "{0} Rabu lalu"),
                new RelativeTimeCountResource(null, "pada {0} Rabu")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Rab lalu",
                "Rab ini",
                "Rab depan",
                new RelativeTimeCountResource(null, "{0} Rab lalu"),
                new RelativeTimeCountResource(null, "pd {0} Rab")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Rab lalu",
                "Rab ini",
                "Rab depan",
                new RelativeTimeCountResource(null, "{0} Rab lalu"),
                new RelativeTimeCountResource(null, "pada {0} Rab")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Khamis lalu",
                "Khamis ini",
                "Khamis depan",
                new RelativeTimeCountResource(null, "{0} Khamis lalu"),
                new RelativeTimeCountResource(null, "pada {0} Khamis")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Kha lalu",
                "Kha ini",
                "Kha depan",
                new RelativeTimeCountResource(null, "{0} Kha lalu"),
                new RelativeTimeCountResource(null, "pada {0} Kha")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Kha lalu",
                "Kha ini",
                "Kha depan",
                new RelativeTimeCountResource(null, "{0} Kha lalu"),
                new RelativeTimeCountResource(null, "pada {0} Kha")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Jumaat lalu",
                "Jumaat ini",
                "Jumaat depan",
                new RelativeTimeCountResource(null, "{0} Jumaat lalu"),
                new RelativeTimeCountResource(null, "pada {0} Jumaat")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Jum lalu",
                "Jum ini",
                "Jum depan",
                new RelativeTimeCountResource(null, "{0} Jum lalu"),
                new RelativeTimeCountResource(null, "pd {0} Jum")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Jum lalu",
                "Jum ini",
                "Jum depan",
                new RelativeTimeCountResource(null, "{0} Jum lalu"),
                new RelativeTimeCountResource(null, "pada {0} Jum")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Sabtu lalu",
                "Sabtu ini",
                "Sabtu depan",
                new RelativeTimeCountResource(null, "{0} Sabtu lalu"),
                new RelativeTimeCountResource(null, "pada {0} Sabtu")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Sab lalu",
                "Sab ini",
                "Sab depan",
                new RelativeTimeCountResource(null, "{0} Sab lalu"),
                new RelativeTimeCountResource(null, "pada {0} Sab")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Sab lalu",
                "Sab ini",
                "Sab depan",
                new RelativeTimeCountResource(null, "{0} Sab lalu"),
                new RelativeTimeCountResource(null, "pada {0} Sab")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "PG/PTG",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "PG/PTG",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "PG/PTG",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "jam",
                null,
                "jam ini",
                null,
                new RelativeTimeCountResource(null, "{0} jam lalu"),
                new RelativeTimeCountResource(null, "dalam {0} jam")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "jam",
                null,
                "jam ini",
                null,
                new RelativeTimeCountResource(null, "{0} jam lalu"),
                new RelativeTimeCountResource(null, "dlm {0} jam")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "jam",
                null,
                "jam ini",
                null,
                new RelativeTimeCountResource(null, "{0} jam lalu"),
                new RelativeTimeCountResource(null, "dlm {0} jam")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minit",
                null,
                "pada minit ini",
                null,
                new RelativeTimeCountResource(null, "{0} minit lalu"),
                new RelativeTimeCountResource(null, "dalam {0} minit")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                null,
                "pada minit ini",
                null,
                new RelativeTimeCountResource(null, "{0} min lalu"),
                new RelativeTimeCountResource(null, "dlm {0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                null,
                "pada minit ini",
                null,
                new RelativeTimeCountResource(null, "{0} min lalu"),
                new RelativeTimeCountResource(null, "dlm {0} min")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "saat",
                null,
                "sekarang",
                null,
                new RelativeTimeCountResource(null, "{0} saat lalu"),
                new RelativeTimeCountResource(null, "dalam {0} saat")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "saat",
                null,
                "sekarang",
                null,
                new RelativeTimeCountResource(null, "{0} saat lalu"),
                new RelativeTimeCountResource(null, "dlm {0} saat")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "saat",
                null,
                "sekarang",
                null,
                new RelativeTimeCountResource(null, "{0} saat lalu"),
                new RelativeTimeCountResource(null, "dlm {0} saat")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "zon waktu",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "zon",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "zon",
                null,
                null,
                null,
                null,
                null));
    }
}