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
    public class ArabicSomaliaRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ar-SO";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "العصر",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "العصر",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "العصر",
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
                "السنة",
                "السنة الماضية",
                "السنة الحالية",
                "السنة القادمة",
                new RelativeTimeCountResource("قبل سنة واحدة", "قبل {0} سنة"),
                new RelativeTimeCountResource("خلال سنة واحدة", "خلال {0} سنة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "السنة",
                "السنة الماضية",
                "السنة الحالية",
                "السنة القادمة",
                new RelativeTimeCountResource("قبل سنة واحدة", "قبل {0} سنة"),
                new RelativeTimeCountResource("خلال سنة واحدة", "خلال {0} سنة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "السنة",
                "السنة الماضية",
                "السنة الحالية",
                "السنة القادمة",
                new RelativeTimeCountResource("قبل سنة واحدة", "قبل {0} سنة"),
                new RelativeTimeCountResource("خلال سنة واحدة", "خلال {0} سنة")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ربع السنة",
                "الربع الأخير",
                "هذا الربع",
                "الربع القادم",
                new RelativeTimeCountResource("قبل ربع سنة واحد", "قبل {0} ربع سنة"),
                new RelativeTimeCountResource("خلال ربع سنة واحد", "خلال {0} ربع سنة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ربع السنة",
                "الربع الأخير",
                "هذا الربع",
                "الربع القادم",
                new RelativeTimeCountResource("قبل ربع سنة واحد", "قبل {0} ربع سنة"),
                new RelativeTimeCountResource("خلال ربع سنة واحد", "خلال {0} ربع سنة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ربع السنة",
                "الربع الأخير",
                "هذا الربع",
                "الربع القادم",
                new RelativeTimeCountResource("قبل ربع سنة واحد", "قبل {0} ربع سنة"),
                new RelativeTimeCountResource("خلال ربع سنة واحد", "خلال {0} ربع سنة")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "الشهر",
                "الشهر الماضي",
                "هذا الشهر",
                "الشهر القادم",
                new RelativeTimeCountResource("قبل شهر واحد", "قبل {0} شهر"),
                new RelativeTimeCountResource("خلال شهر واحد", "خلال {0} شهر")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "الشهر",
                "الشهر الماضي",
                "هذا الشهر",
                "الشهر القادم",
                new RelativeTimeCountResource("قبل شهر واحد", "قبل {0} شهر"),
                new RelativeTimeCountResource("خلال شهر واحد", "خلال {0} شهر")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "الشهر",
                "الشهر الماضي",
                "هذا الشهر",
                "الشهر القادم",
                new RelativeTimeCountResource("قبل شهر واحد", "قبل {0} شهر"),
                new RelativeTimeCountResource("خلال شهر واحد", "خلال {0} شهر")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "الأسبوع",
                "الأسبوع الماضي",
                "هذا الأسبوع",
                "الأسبوع القادم",
                new RelativeTimeCountResource("قبل أسبوع واحد", "قبل {0} أسبوع"),
                new RelativeTimeCountResource("خلال أسبوع واحد", "خلال {0} أسبوع")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "الأسبوع",
                "الأسبوع الماضي",
                "هذا الأسبوع",
                "الأسبوع القادم",
                new RelativeTimeCountResource("قبل أسبوع واحد", "قبل {0} أسبوع"),
                new RelativeTimeCountResource("خلال أسبوع واحد", "خلال {0} أسبوع")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "الأسبوع",
                "الأسبوع الماضي",
                "هذا الأسبوع",
                "الأسبوع القادم",
                new RelativeTimeCountResource("قبل أسبوع واحد", "قبل {0} أسبوع"),
                new RelativeTimeCountResource("خلال أسبوع واحد", "خلال {0} أسبوع")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "الأسبوع من الشهر",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "أسبوع/شهر",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "أسبوع من شهر",
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
                "يوم",
                "أمس",
                "اليوم",
                "غدًا",
                new RelativeTimeCountResource("قبل يوم واحد", "قبل {0} يوم"),
                new RelativeTimeCountResource("خلال يوم واحد", "خلال {0} يوم")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "يوم",
                "أمس",
                "اليوم",
                "غدًا",
                new RelativeTimeCountResource("قبل يوم واحد", "قبل {0} يوم"),
                new RelativeTimeCountResource("خلال يوم واحد", "خلال {0} يوم")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "يوم",
                "أمس",
                "اليوم",
                "غدًا",
                new RelativeTimeCountResource("قبل يوم واحد", "قبل {0} يوم"),
                new RelativeTimeCountResource("خلال يوم واحد", "خلال {0} يوم")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "يوم من السنة",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "يوم/سنة",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "يوم من سنة",
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
                "اليوم",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "اليوم",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "اليوم",
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
                "يوم عمل من الشهر",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "يوم عمل/شهر",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "يوم عمل من شهر",
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
                "الأحد الماضي",
                "الأحد الحالي",
                "الأحد القادم",
                new RelativeTimeCountResource("الأحد الماضي", "قبل {0} أحد"),
                new RelativeTimeCountResource("الأحد القادم", "خلال {0} أحد")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "الأحد الماضي",
                "الأحد الحالي",
                "الأحد القادم",
                new RelativeTimeCountResource("أحد ماضي", "قبل {0} أحد"),
                new RelativeTimeCountResource("أحد قادم", "خلال {0} أحد")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "الأحد الماضي",
                "الأحد الحالي",
                "الأحد القادم",
                new RelativeTimeCountResource("أحد ماضي", "قبل {0} أحد"),
                new RelativeTimeCountResource("أحد قادم", "خلال {0} أحد")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "الإثنين الماضي",
                "الإثنين الحالي",
                "الإثنين القادم",
                new RelativeTimeCountResource("الإثنين الماضي", "قبل {0} يوم إثنين"),
                new RelativeTimeCountResource("الإثنين القادم", "خلال {0} يوم إثنين")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "الإثنين الماضي",
                "الإثنين الحالي",
                "الإثنين القادم",
                new RelativeTimeCountResource("إثنين ماضي", "قبل {0} إثنين"),
                new RelativeTimeCountResource("إثنين قادم", "خلال {0} إثنين")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "الإثنين الماضي",
                "الإثنين الحالي",
                "الإثنين القادم",
                new RelativeTimeCountResource("الإثنين الماضي", "قبل {0} إثنين"),
                new RelativeTimeCountResource("الإثنين القادم", "خلال {0} إثنين")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "الثلاثاء الماضي",
                "الثلاثاء الحالي",
                "الثلاثاء القادم",
                new RelativeTimeCountResource("الثلاثاء الماضي", "قبل {0} يوم ثلاثاء"),
                new RelativeTimeCountResource("الثلاثاء القادم", "خلال {0} يوم ثلاثاء")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "الثلاثاء الماضي",
                "الثلاثاء الحالي",
                "الثلاثاء القادم",
                new RelativeTimeCountResource("ثلاثاء ماضي", "قبل {0} ثلاثاء"),
                new RelativeTimeCountResource("ثلاثاء قادم", "خلال {0} ثلاثاء")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "الثلاثاء الماضي",
                "الثلاثاء الحالي",
                "الثلاثاء القادم",
                new RelativeTimeCountResource("ثلاثاء ماضي", "قبل {0} ثلاثاء"),
                new RelativeTimeCountResource("ثلاثاء قادم", "خلال {0} ثلاثاء")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "الأربعاء الماضي",
                "الأربعاء الحالي",
                "الأربعاء القادم",
                new RelativeTimeCountResource("الأربعاء الماضي", "قبل {0} يوم أربعاء"),
                new RelativeTimeCountResource("الأربعاء القادم", "خلال {0} يوم أربعاء")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "الأربعاء الماضي",
                "الأربعاء الحالي",
                "الأربعاء القادم",
                new RelativeTimeCountResource("أربعاء ماضي", "قبل {0} أربعاء"),
                new RelativeTimeCountResource("أربعاء قادم", "خلال {0} أربعاء")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "الأربعاء الماضي",
                "الأربعاء الحالي",
                "الأربعاء القادم",
                new RelativeTimeCountResource("أربعاء ماضي", "قبل {0} أربعاء"),
                new RelativeTimeCountResource("خلال {0} أربعاء", "خلال {0} أربعاء")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "الخميس الماضي",
                "الخميس الحالي",
                "الخميس القادم",
                new RelativeTimeCountResource("الخميس الماضي", "قبل {0} يوم خميس"),
                new RelativeTimeCountResource("الخميس القادم", "خلال {0} يوم خميس")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "الخميس الماضي",
                "الخميس الحالي",
                "الخميس القادم",
                new RelativeTimeCountResource("خميس ماضي", "قبل {0} خميس"),
                new RelativeTimeCountResource("خلال {0} يوم خميس", "خلال {0} خميس")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "الخميس الماضي",
                "الخميس الحالي",
                "الخميس القادم",
                new RelativeTimeCountResource("خميس ماضي", "قبل {0} خميس"),
                new RelativeTimeCountResource("الخميس القادم", "خلال {0} خميس")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "الجمعة الماضي",
                "الجمعة الحالي",
                "الجمعة القادم",
                new RelativeTimeCountResource("الجمعة الماضي", "قبل {0} يوم جمعة"),
                new RelativeTimeCountResource("الجمعة القادم", "خلال {0} يوم جمعة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "الجمعة الماضي",
                "الجمعة الحالي",
                "الجمعة القادم",
                new RelativeTimeCountResource("جمعة ماضي", "قبل {0} جمعة"),
                new RelativeTimeCountResource("جمعة قادم", "خلال {0} جمعة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "الجمعة الماضي",
                "الجمعة الحالي",
                "الجمعة القادم",
                new RelativeTimeCountResource("جمعة ماضي", "قبل {0} جمعة"),
                new RelativeTimeCountResource("جمعة قادم", "خلال {0} جمعة")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "السبت الماضي",
                "السبت الحالي",
                "السبت القادم",
                new RelativeTimeCountResource("السبت الماضي", "قبل {0} يوم سبت"),
                new RelativeTimeCountResource("السبت القادم", "بعد {0} يوم سبت")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "السبت الماضي",
                "السبت الحالي",
                "السبت القادم",
                new RelativeTimeCountResource("سبت ماضي", "قبل {0} سبت"),
                new RelativeTimeCountResource("سبت قادم", "خلال {0} سبت")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "السبت الماضي",
                "السبت الحالي",
                "السبت القادم",
                new RelativeTimeCountResource("سبت ماضي", "قبل {0} سبت"),
                new RelativeTimeCountResource("سبت قادم", "خلال {0} سبت")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ص/م",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ص/م",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ص/م",
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
                "الساعات",
                null,
                "الساعة الحالية",
                null,
                new RelativeTimeCountResource("قبل ساعة واحدة", "قبل {0} ساعة"),
                new RelativeTimeCountResource("خلال ساعة واحدة", "خلال {0} ساعة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "الساعات",
                null,
                "الساعة الحالية",
                null,
                new RelativeTimeCountResource("قبل ساعة واحدة", "قبل {0} ساعة"),
                new RelativeTimeCountResource("خلال ساعة واحدة", "خلال {0} ساعة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "الساعات",
                null,
                "الساعة الحالية",
                null,
                new RelativeTimeCountResource("قبل ساعة واحدة", "قبل {0} ساعة"),
                new RelativeTimeCountResource("خلال ساعة واحدة", "خلال {0} ساعة")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "الدقائق",
                null,
                "هذه الدقيقة",
                null,
                new RelativeTimeCountResource("قبل دقيقة واحدة", "قبل {0} دقيقة"),
                new RelativeTimeCountResource("خلال دقيقة واحدة", "خلال {0} دقيقة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "الدقائق",
                null,
                "هذه الدقيقة",
                null,
                new RelativeTimeCountResource("قبل دقيقة واحدة", "قبل {0} دقيقة"),
                new RelativeTimeCountResource("خلال دقيقة واحدة", "خلال {0} دقيقة")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "الدقائق",
                null,
                "هذه الدقيقة",
                null,
                new RelativeTimeCountResource("قبل دقيقة واحدة", "قبل {0} دقيقة"),
                new RelativeTimeCountResource("خلال دقيقة واحدة", "خلال {0} دقيقة")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "الثواني",
                null,
                "الآن",
                null,
                new RelativeTimeCountResource("قبل ثانية واحدة", "قبل {0} ثانية"),
                new RelativeTimeCountResource("خلال ثانية واحدة", "خلال {0} ثانية")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "الثواني",
                null,
                "الآن",
                null,
                new RelativeTimeCountResource("قبل ثانية واحدة", "قبل {0} ثانية"),
                new RelativeTimeCountResource("خلال ثانية واحدة", "خلال {0} ثانية")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "الثواني",
                null,
                "الآن",
                null,
                new RelativeTimeCountResource("قبل ثانية واحدة", "قبل {0} ثانية"),
                new RelativeTimeCountResource("خلال ثانية واحدة", "خلال {0} ثانية")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "التوقيت",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "توقيت",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "توقيت",
                null,
                null,
                null,
                null,
                null));
    }
}