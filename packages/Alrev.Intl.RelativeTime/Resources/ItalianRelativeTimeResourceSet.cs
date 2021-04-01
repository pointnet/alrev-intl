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
    public class ItalianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "it";
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
                "anno",
                "anno scorso",
                "quest’anno",
                "anno prossimo",
                new RelativeTimeCountResource("{0} anno fa", "{0} anni fa"),
                new RelativeTimeCountResource("tra {0} anno", "tra {0} anni")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "anno",
                "anno scorso",
                "quest’anno",
                "anno prossimo",
                new RelativeTimeCountResource("{0} anno fa", "{0} anni fa"),
                new RelativeTimeCountResource("tra {0} anno", "tra {0} anni")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "anno",
                "anno scorso",
                "quest’anno",
                "anno prossimo",
                new RelativeTimeCountResource("{0} anno fa", "{0} anni fa"),
                new RelativeTimeCountResource("tra {0} anno", "tra {0} anni")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "trimestre",
                "trimestre scorso",
                "questo trimestre",
                "trimestre prossimo",
                new RelativeTimeCountResource("{0} trimestre fa", "{0} trimestri fa"),
                new RelativeTimeCountResource("tra {0} trimestre", "tra {0} trimestri")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "trim.",
                "trim. scorso",
                "questo trim.",
                "trim. prossimo",
                new RelativeTimeCountResource("{0} trim. fa", "{0} trim. fa"),
                new RelativeTimeCountResource("tra {0} trim.", "tra {0} trim.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "trim.",
                "trim. scorso",
                "questo trim.",
                "trim. prossimo",
                new RelativeTimeCountResource("{0} trim. fa", "{0} trim. fa"),
                new RelativeTimeCountResource("tra {0} trim.", "tra {0} trim.")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "mese",
                "mese scorso",
                "questo mese",
                "mese prossimo",
                new RelativeTimeCountResource("{0} mese fa", "{0} mesi fa"),
                new RelativeTimeCountResource("tra {0} mese", "tra {0} mesi")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "mese",
                "mese scorso",
                "questo mese",
                "mese prossimo",
                new RelativeTimeCountResource("{0} mese fa", "{0} mesi fa"),
                new RelativeTimeCountResource("tra {0} mese", "tra {0} mesi")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "mese",
                "mese scorso",
                "questo mese",
                "mese prossimo",
                new RelativeTimeCountResource("{0} mese fa", "{0} mesi fa"),
                new RelativeTimeCountResource("tra {0} mese", "tra {0} mesi")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "settimana",
                "settimana scorsa",
                "questa settimana",
                "settimana prossima",
                new RelativeTimeCountResource("{0} settimana fa", "{0} settimane fa"),
                new RelativeTimeCountResource("tra {0} settimana", "tra {0} settimane")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sett.",
                "sett. scorsa",
                "questa sett.",
                "sett. prossima",
                new RelativeTimeCountResource("{0} sett. fa", "{0} sett. fa"),
                new RelativeTimeCountResource("tra {0} sett.", "tra {0} sett.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sett.",
                "sett. scorsa",
                "questa sett.",
                "sett. prossima",
                new RelativeTimeCountResource("{0} sett. fa", "{0} sett. fa"),
                new RelativeTimeCountResource("tra {0} sett.", "tra {0} sett.")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "settimana del mese",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sett. mese",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sett. mese",
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
                "giorno",
                "ieri",
                "oggi",
                "domani",
                new RelativeTimeCountResource("{0} giorno fa", "{0} giorni fa"),
                new RelativeTimeCountResource("tra {0} giorno", "tra {0} giorni")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "g.",
                "ieri",
                "oggi",
                "domani",
                new RelativeTimeCountResource("{0} g fa", "{0} gg fa"),
                new RelativeTimeCountResource("tra {0} g", "tra {0} gg")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "g.",
                "ieri",
                "oggi",
                "domani",
                new RelativeTimeCountResource("{0} g fa", "{0} gg fa"),
                new RelativeTimeCountResource("tra {0} g", "tra {0} gg")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "giorno dell’anno",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "giorno anno",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "giorno anno",
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
                "giorno della settimana",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "giorno sett.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "giorno settimana",
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
                "giorno del mese",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "giorno mese",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "giorno mese",
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
                "domenica scorsa",
                "questa domenica",
                "domenica prossima",
                new RelativeTimeCountResource("{0} domenica fa", "{0} domeniche fa"),
                new RelativeTimeCountResource("tra {0} domenica", "tra {0} domeniche")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "dom. scorsa",
                "questa dom.",
                "dom. prossima",
                new RelativeTimeCountResource("{0} dom. fa", "{0} dom. fa"),
                new RelativeTimeCountResource("tra {0} dom.", "tra {0} dom.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "dom. scorsa",
                "questa dom.",
                "dom. prossima",
                new RelativeTimeCountResource("{0} dom. fa", "{0} dom. fa"),
                new RelativeTimeCountResource("tra {0} dom.", "tra {0} dom.")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "lunedì scorso",
                "questo lunedì",
                "lunedì prossimo",
                new RelativeTimeCountResource("{0} lunedì fa", "{0} lunedì fa"),
                new RelativeTimeCountResource("tra {0} lunedì", "tra {0} lunedì")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "lun. scorso",
                "questo lun.",
                "lun. prossimo",
                new RelativeTimeCountResource("{0} lun. fa", "{0} lun. fa"),
                new RelativeTimeCountResource("tra {0} lun.", "tra {0} lun.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "lun. scorso",
                "questo lun.",
                "lun. prossimo",
                new RelativeTimeCountResource("{0} lun. fa", "{0} lun. fa"),
                new RelativeTimeCountResource("tra {0} lun.", "tra {0} lun.")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "martedì scorso",
                "questo martedì",
                "martedì prossimo",
                new RelativeTimeCountResource("{0} martedì fa", "{0} martedì fa"),
                new RelativeTimeCountResource("tra {0} martedì", "tra {0} martedì")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "mar. scorso",
                "questo mar.",
                "mar. prossimo",
                new RelativeTimeCountResource("{0} mar. fa", "{0} mar. fa"),
                new RelativeTimeCountResource("tra {0} mar.", "tra {0} mar.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "mar. scorso",
                "questo mar.",
                "mar. prossimo",
                new RelativeTimeCountResource("{0} mar. fa", "{0} mar. fa"),
                new RelativeTimeCountResource("tra {0} mar.", "tra {0} mar.")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "mercoledì scorso",
                "questo mercoledì",
                "mercoledì prossimo",
                new RelativeTimeCountResource("{0} mercoledì fa", "{0} mercoledì fa"),
                new RelativeTimeCountResource("tra {0} mercoledì", "tra {0} mercoledì")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "mer. scorso",
                "questo mer.",
                "mer. prossimo",
                new RelativeTimeCountResource("{0} mer. fa", "{0} mer. fa"),
                new RelativeTimeCountResource("tra {0} mer.", "tra {0} mer.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "mer. scorso",
                "questo mer.",
                "mer. prossimo",
                new RelativeTimeCountResource("{0} mer. fa", "{0} mer. fa"),
                new RelativeTimeCountResource("tra {0} mer.", "tra {0} mer.")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "giovedì scorso",
                "questo giovedì",
                "giovedì prossimo",
                new RelativeTimeCountResource("{0} giovedì fa", "{0} giovedì fa"),
                new RelativeTimeCountResource("tra {0} giovedì", "tra {0} giovedì")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "gio. scorso",
                "questo gio.",
                "gio. prossimo",
                new RelativeTimeCountResource("{0} gio. fa", "{0} gio. fa"),
                new RelativeTimeCountResource("tra {0} gio.", "tra {0} gio.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "gio. scorso",
                "questo gio.",
                "gio. prossimo",
                new RelativeTimeCountResource("{0} gio. fa", "{0} gio. fa"),
                new RelativeTimeCountResource("tra {0} gio.", "tra {0} gio.")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "venerdì scorso",
                "questo venerdì",
                "venerdì prossimo",
                new RelativeTimeCountResource("{0} venerdì fa", "{0} venerdì fa"),
                new RelativeTimeCountResource("tra {0} venerdì", "tra {0} venerdì")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "ven. scorso",
                "questo ven.",
                "ven. prossimo",
                new RelativeTimeCountResource("{0} ven. fa", "{0} ven. fa"),
                new RelativeTimeCountResource("tra {0} ven.", "tra {0} ven.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "ven. scorso",
                "questo ven.",
                "ven. prossimo",
                new RelativeTimeCountResource("{0} ven. fa", "{0} ven. fa"),
                new RelativeTimeCountResource("tra {0} ven.", "tra {0} ven.")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "sabato scorso",
                "questo sabato",
                "sabato prossimo",
                new RelativeTimeCountResource("{0} sabato fa", "{0} sabati fa"),
                new RelativeTimeCountResource("tra {0} sabato", "tra {0} sabati")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "sab. scorso",
                "questo sab.",
                "sab. prossimo",
                new RelativeTimeCountResource("{0} sab. fa", "{0} sab. fa"),
                new RelativeTimeCountResource("tra {0} sab.", "tra {0} sab.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "sab. scorso",
                "questo sab.",
                "sab. prossimo",
                new RelativeTimeCountResource("{0} sab. fa", "{0} sab. fa"),
                new RelativeTimeCountResource("tra {0} sab.", "tra {0} sab.")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "AM/PM",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "AM/PM",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "AM/PM",
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
                "ora",
                null,
                "quest’ora",
                null,
                new RelativeTimeCountResource("{0} ora fa", "{0} ore fa"),
                new RelativeTimeCountResource("tra {0} ora", "tra {0} ore")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "h",
                null,
                "quest’ora",
                null,
                new RelativeTimeCountResource("{0} h fa", "{0} h fa"),
                new RelativeTimeCountResource("tra {0} h", "tra {0} h")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "h",
                null,
                "quest’ora",
                null,
                new RelativeTimeCountResource("{0} h fa", "{0} h fa"),
                new RelativeTimeCountResource("tra {0} h", "tra {0} h")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minuto",
                null,
                "questo minuto",
                null,
                new RelativeTimeCountResource("{0} minuto fa", "{0} minuti fa"),
                new RelativeTimeCountResource("tra {0} minuto", "tra {0} minuti")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                null,
                "questo minuto",
                null,
                new RelativeTimeCountResource("{0} min fa", "{0} min fa"),
                new RelativeTimeCountResource("tra {0} min", "tra {0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                null,
                "questo minuto",
                null,
                new RelativeTimeCountResource("{0} min fa", "{0} min fa"),
                new RelativeTimeCountResource("tra {0} min", "tra {0} min")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "secondo",
                null,
                "ora",
                null,
                new RelativeTimeCountResource("{0} secondo fa", "{0} secondi fa"),
                new RelativeTimeCountResource("tra {0} secondo", "tra {0} secondi")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "s",
                null,
                "ora",
                null,
                new RelativeTimeCountResource("{0} s fa", "{0} s fa"),
                new RelativeTimeCountResource("tra {0} s", "tra {0} s")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "s",
                null,
                "ora",
                null,
                new RelativeTimeCountResource("{0} sec. fa", "{0} sec. fa"),
                new RelativeTimeCountResource("tra {0} sec.", "tra {0} sec.")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "fuso orario",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "fuso",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "fuso",
                null,
                null,
                null,
                null,
                null));
    }
}