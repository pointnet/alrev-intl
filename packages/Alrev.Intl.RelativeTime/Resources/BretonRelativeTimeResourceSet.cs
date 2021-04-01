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
    public class BretonRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "br";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "amzervezh",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "amzerv.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "amzerv.",
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
                "bloaz",
                "warlene",
                "hevlene",
                "ar bloaz a zeu",
                new RelativeTimeCountResource("{0} bloaz zo", "{0} vloaz zo"),
                new RelativeTimeCountResource("a-benn {0} bloaz", "a-benn {0} vloaz")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "b.",
                "warlene",
                "hevlene",
                "ar bl. a zeu",
                new RelativeTimeCountResource("-{0} bl.", "-{0} bl."),
                new RelativeTimeCountResource("+{0} bl.", "+{0} bl.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "bl.",
                "warlene",
                "hevlene",
                "ar bl. a zeu",
                new RelativeTimeCountResource("{0} bl. zo", "{0} bl. zo"),
                new RelativeTimeCountResource("a-benn {0} bl.", "a-benn {0} bl.")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "trimiziad",
                "an trimiziad diaraok",
                "an trimiziad-mañ",
                "an trimiziad a zeu",
                new RelativeTimeCountResource("{0} trimiziad zo", "{0} trimiziad zo"),
                new RelativeTimeCountResource("a-benn {0} trimiziad", "a-benn {0} trimiziad")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "t.",
                "an trim. diaraok",
                "an trim.-mañ",
                "an trim. a zeu",
                new RelativeTimeCountResource("-{0} trim.", "-{0} trim."),
                new RelativeTimeCountResource("+{0} trim.", "+{0} trim.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "trim.",
                "an trim. diaraok",
                "an trim.-mañ",
                "an trim. a zeu",
                new RelativeTimeCountResource("{0} trim. zo", "{0} trim. zo"),
                new RelativeTimeCountResource("a-benn {0} trim.", "a-benn {0} trim.")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "miz",
                "ar miz diaraok",
                "ar miz-mañ",
                "ar miz a zeu",
                new RelativeTimeCountResource("{0} miz zo", "{0} miz zo"),
                new RelativeTimeCountResource("a-benn {0} miz", "a-benn {0} miz")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "m.",
                "ar m. diaraok",
                "ar m.-mañ",
                "ar m. a zeu",
                new RelativeTimeCountResource("-{0} miz", "-{0} miz"),
                new RelativeTimeCountResource("+{0} miz", "+{0} miz")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "miz",
                "ar miz diaraok",
                "ar miz-mañ",
                "ar miz a zeu",
                new RelativeTimeCountResource("{0} miz zo", "{0} miz zo"),
                new RelativeTimeCountResource("a-benn {0} miz", "a-benn {0} miz")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "sizhun",
                "ar sizhun diaraok",
                "ar sizhun-mañ",
                "ar sizhun a zeu",
                new RelativeTimeCountResource("{0} sizhun zo", "{0} sizhun zo"),
                new RelativeTimeCountResource("a-benn {0} sizhun", "a-benn {0} sizhun")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sizh.",
                "ar sizh. diaraok",
                "ar sizh.-mañ",
                "ar sizh. a zeu",
                new RelativeTimeCountResource("{0} sizh. zo", "{0} sizh. zo"),
                new RelativeTimeCountResource("a-benn {0} sizh.", "a-benn {0} sizh.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sizh.",
                "ar sizh. diaraok",
                "ar sizh.-mañ",
                "ar sizh. a zeu",
                new RelativeTimeCountResource("{0} sizh. zo", "{0} sizh. zo"),
                new RelativeTimeCountResource("a-benn {0} sizh.", "a-benn {0} sizh.")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "sizhun ar miz",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sizh. ar m.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sizh. ar miz",
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
                "deiz",
                "decʼh",
                "hiziv",
                "warcʼhoazh",
                new RelativeTimeCountResource("{0} deiz zo", "{0} deiz zo"),
                new RelativeTimeCountResource("a-benn {0} deiz", "a-benn {0} deiz")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "d.",
                "decʼh",
                "hiziv",
                "warcʼhoazh",
                new RelativeTimeCountResource("-{0} d", "-{0} d"),
                new RelativeTimeCountResource("+{0} d", "+{0} d")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "d.",
                "decʼh",
                "hiziv",
                "warcʼhoazh",
                new RelativeTimeCountResource("{0} d zo", "{0} d zo"),
                new RelativeTimeCountResource("a-benn {0} d", "a-benn {0} d")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "deiz ar bloaz",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "d. ar b.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "d. ar bl.",
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
                "deiz ar sizhun",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "d. ar sizh.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "d. ar sizh.",
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
                "deiz ar miz",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "d. ar m.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "d. ar miz",
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
                "Disul diwezhañ",
                "ar Sul-mañ",
                "Disul a zeu",
                new RelativeTimeCountResource("{0} Sul zo", "{0} Sul zo"),
                new RelativeTimeCountResource("a-benn {0} Sul", "a-benn {0} Sul")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Su diwezhañ",
                "Su-mañ",
                "Su a zeu",
                new RelativeTimeCountResource("{0} Su zo", "{0} Su zo"),
                new RelativeTimeCountResource("a-benn {0} Su", "a-benn {0} Su")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Sul diwezhañ",
                "Sul-mañ",
                "Sul a zeu",
                new RelativeTimeCountResource("{0} Sul zo", "{0} Sul zo"),
                new RelativeTimeCountResource("a-benn {0} Sul", "a-benn {0} Sul")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Dilun diwezhañ",
                "al Lun-mañ",
                "Dilun a zeu",
                new RelativeTimeCountResource("{0} Lun zo", "{0} Lun zo"),
                new RelativeTimeCountResource("a-benn {0} Lun", "a-benn {0} Lun")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "L diwezhañ",
                "L-mañ",
                "L a zeu",
                new RelativeTimeCountResource("{0} L zo", "{0} L zo"),
                new RelativeTimeCountResource("a-benn {0} L", "a-benn {0} L")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Lun diwezhañ",
                "Lun-mañ",
                "Lun a zeu",
                new RelativeTimeCountResource("{0} Lun zo", "{0} Lun zo"),
                new RelativeTimeCountResource("a-benn {0} Lun", "a-benn {0} Lun")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Dimeurzh diwezhañ",
                "ar Meurzh-mañ",
                "Dimeurzh a zeu",
                new RelativeTimeCountResource("{0} Meurzh zo", "{0} Meurzh zo"),
                new RelativeTimeCountResource("a-benn {0} Meurzh", "a-benn {0} Meurzh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Mz diwezhañ",
                "Mz-mañ",
                "Mz a zeu",
                new RelativeTimeCountResource("{0} Meurzh zo", "{0} Meurzh zo"),
                new RelativeTimeCountResource("a-benn {0} Meurzh", "a-benn {0} Meurzh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Meu. diwezhañ",
                "Meu.-mañ",
                "Meu. a zeu",
                new RelativeTimeCountResource("{0} Meurzh zo", "{0} Meurzh zo"),
                new RelativeTimeCountResource("a-benn {0} Meurzh", "a-benn {0} Meurzh")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Dimercʼher diwezhañ",
                "ar Mercʼher-mañ",
                "Dimercʼher a zeu",
                new RelativeTimeCountResource("{0} Mercʼher zo", "{0} Mercʼher zo"),
                new RelativeTimeCountResource("a-benn {0} Mercʼher", "a-benn {0} Mercʼher")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Mc diwezhañ",
                "Mc-mañ",
                "Mc a zeu",
                new RelativeTimeCountResource("{0} Mercʼher zo", "{0} Mercʼher zo"),
                new RelativeTimeCountResource("a-benn {0} Mercʼher", "a-benn {0} Mercʼher")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Mer. diwezhañ",
                "Mer.-mañ",
                "Mer. a zeu",
                new RelativeTimeCountResource("{0} Mercʼher zo", "{0} Mercʼher zo"),
                new RelativeTimeCountResource("a-benn {0} Mercʼher", "a-benn {0} Mercʼher")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Diriaou diwezhañ",
                "ar Yaou-mañ",
                "Diriaou a zeu",
                new RelativeTimeCountResource("{0} Yaou zo", "{0} Yaou zo"),
                new RelativeTimeCountResource("a-benn {0} Yaou", "a-benn {0} Yaou")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Y diwezhañ",
                "Y-mañ",
                "Y a zeu",
                new RelativeTimeCountResource("{0} Y zo", "{0} Y zo"),
                new RelativeTimeCountResource("a-benn {0} Y", "a-benn {0} Y")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Yaou diwezhañ",
                "Yaou-mañ",
                "Yaou a zeu",
                new RelativeTimeCountResource("{0} Yaou zo", "{0} Yaou zo"),
                new RelativeTimeCountResource("a-benn {0} Yaou", "a-benn {0} Yaou")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Digwener diwezhañ",
                "ar Gwener-mañ",
                "Digwener a zeu",
                new RelativeTimeCountResource("{0} Gwener zo", "{0} Gwener zo"),
                new RelativeTimeCountResource("a-benn {0} Gwener", "a-benn {0} Gwener")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "G diwezhañ",
                "G-mañ",
                "G a zeu",
                new RelativeTimeCountResource("{0} Gwener zo", "{0} Gwener zo"),
                new RelativeTimeCountResource("a-benn {0} Gwener", "a-benn {0} Gwener")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Gwe. diwezhañ",
                "Gwe.-mañ",
                "Gwe. a zeu",
                new RelativeTimeCountResource("{0} Gwener zo", "{0} Gwener zo"),
                new RelativeTimeCountResource("a-benn {0} Gwener", "a-benn {0} Gwener")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "Disadorn diwezhañ",
                "ar Sadorn-mañ",
                "Disadorn a zeu",
                new RelativeTimeCountResource("{0} Sadorn zo", "{0} Sadorn zo"),
                new RelativeTimeCountResource("a-benn {0} Sadorn", "a-benn {0} Sadorn")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "Sa diwezhañ",
                "Sa-mañ",
                "Sa a zeu",
                new RelativeTimeCountResource("{0} Sa zo", "{0} Sa zo"),
                new RelativeTimeCountResource("a-benn {0} Sa", "a-benn {0} Sa")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "Sad. diwezhañ",
                "Sad.-mañ",
                "Sad. a zeu",
                new RelativeTimeCountResource("{0} Sad. zo", "{0} Sad. zo"),
                new RelativeTimeCountResource("a-benn {0} Sad.", "a-benn {0} Sad.")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "AM/GM",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "AM/GM",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "AM/GM",
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
                "eur",
                null,
                "dʼan eur-mañ",
                null,
                new RelativeTimeCountResource("{0} eur zo", "{0} eur zo"),
                new RelativeTimeCountResource("a-benn {0} eur", "a-benn {0} eur")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "e",
                null,
                "dʼan eur-mañ",
                null,
                new RelativeTimeCountResource("-{0} h", "-{0} h"),
                new RelativeTimeCountResource("+{0} h", "+{0} h")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "e",
                null,
                "dʼan eur-mañ",
                null,
                new RelativeTimeCountResource("{0} e zo", "{0} e zo"),
                new RelativeTimeCountResource("a-benn {0} e", "a-benn {0} e")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "munut",
                null,
                "ar munut-mañ",
                null,
                new RelativeTimeCountResource("{0} munut zo", "{0} munut zo"),
                new RelativeTimeCountResource("a-benn {0} munut", "a-benn {0} munut")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                null,
                "ar munut-mañ",
                null,
                new RelativeTimeCountResource("-{0} min", "-{0} min"),
                new RelativeTimeCountResource("+{0} min", "+{0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                null,
                "ar munut-mañ",
                null,
                new RelativeTimeCountResource("{0} min zo", "{0} min zo"),
                new RelativeTimeCountResource("a-benn {0} min", "a-benn {0} min")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "eilenn",
                null,
                "bremañ",
                null,
                new RelativeTimeCountResource("{0} eilenn zo", "{0} eilenn zo"),
                new RelativeTimeCountResource("a-benn {0} eilenn", "a-benn {0} eilenn")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "s",
                null,
                "brem.",
                null,
                new RelativeTimeCountResource("-{0} s", "-{0} s"),
                new RelativeTimeCountResource("+{0} s", "+{0} s")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "s",
                null,
                "brem.",
                null,
                new RelativeTimeCountResource("{0} s zo", "{0} s zo"),
                new RelativeTimeCountResource("a-benn {0} s", "a-benn {0} s")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "takad eur",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "takad",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "takad",
                null,
                null,
                null,
                null,
                null));
    }
}