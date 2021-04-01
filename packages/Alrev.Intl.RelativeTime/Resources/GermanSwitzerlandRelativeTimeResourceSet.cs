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
    public class GermanSwitzerlandRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "de-CH";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Epoche",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Epoche",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Epoche",
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
                "Jahr",
                "letztes Jahr",
                "dieses Jahr",
                "nächstes Jahr",
                new RelativeTimeCountResource("vor {0} Jahr", "vor {0} Jahren"),
                new RelativeTimeCountResource("in {0} Jahr", "in {0} Jahren")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "J",
                "letztes Jahr",
                "dieses Jahr",
                "nächstes Jahr",
                new RelativeTimeCountResource("vor {0} Jahr", "vor {0} Jahren"),
                new RelativeTimeCountResource("in {0} Jahr", "in {0} Jahren")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Jahr",
                "letztes Jahr",
                "dieses Jahr",
                "nächstes Jahr",
                new RelativeTimeCountResource("vor {0} Jahr", "vor {0} Jahren"),
                new RelativeTimeCountResource("in {0} Jahr", "in {0} Jahren")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Quartal",
                "letztes Quartal",
                "dieses Quartal",
                "nächstes Quartal",
                new RelativeTimeCountResource("vor {0} Quartal", "vor {0} Quartalen"),
                new RelativeTimeCountResource("in {0} Quartal", "in {0} Quartalen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Q",
                "letztes Quartal",
                "dieses Quartal",
                "nächstes Quartal",
                new RelativeTimeCountResource("vor {0} Q", "vor {0} Q"),
                new RelativeTimeCountResource("in {0} Q", "in {0} Q")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Quart.",
                "letztes Quartal",
                "dieses Quartal",
                "nächstes Quartal",
                new RelativeTimeCountResource("vor {0} Quart.", "vor {0} Quart."),
                new RelativeTimeCountResource("in {0} Quart.", "in {0} Quart.")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Monat",
                "letzten Monat",
                "diesen Monat",
                "nächsten Monat",
                new RelativeTimeCountResource("vor {0} Monat", "vor {0} Monaten"),
                new RelativeTimeCountResource("in {0} Monat", "in {0} Monaten")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "M",
                "letzten Monat",
                "diesen Monat",
                "nächsten Monat",
                new RelativeTimeCountResource("vor {0} Monat", "vor {0} Monaten"),
                new RelativeTimeCountResource("in {0} Monat", "in {0} Monaten")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Monat",
                "letzten Monat",
                "diesen Monat",
                "nächsten Monat",
                new RelativeTimeCountResource("vor {0} Monat", "vor {0} Monaten"),
                new RelativeTimeCountResource("in {0} Monat", "in {0} Monaten")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Woche",
                "letzte Woche",
                "diese Woche",
                "nächste Woche",
                new RelativeTimeCountResource("vor {0} Woche", "vor {0} Wochen"),
                new RelativeTimeCountResource("in {0} Woche", "in {0} Wochen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "W",
                "letzte Woche",
                "diese Woche",
                "nächste Woche",
                new RelativeTimeCountResource("vor {0} Wo.", "vor {0} Wo."),
                new RelativeTimeCountResource("in {0} Wo.", "in {0} Wo.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Woche",
                "letzte Woche",
                "diese Woche",
                "nächste Woche",
                new RelativeTimeCountResource("vor {0} Woche", "vor {0} Wochen"),
                new RelativeTimeCountResource("in {0} Woche", "in {0} Wochen")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Woche im Monat",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "W. i. Mon.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Wo. i. M.",
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
                "Tag",
                "gestern",
                "heute",
                "morgen",
                new RelativeTimeCountResource("vor {0} Tag", "vor {0} Tagen"),
                new RelativeTimeCountResource("in {0} Tag", "in {0} Tagen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Tag",
                "gestern",
                "heute",
                "morgen",
                new RelativeTimeCountResource("vor {0} Tag", "vor {0} Tagen"),
                new RelativeTimeCountResource("in {0} Tag", "in {0} Tagen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Tag",
                "gestern",
                "heute",
                "morgen",
                new RelativeTimeCountResource("vor {0} Tag", "vor {0} Tagen"),
                new RelativeTimeCountResource("in {0} Tag", "in {0} Tagen")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Tag des Jahres",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "T/J",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Tag d. J.",
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
                "Wochentag",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Wochentag",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Wochentag",
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
                "Wochentag im Monat",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Wochent. i. Mon.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Wochent. i. Mo.",
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
                "letzten Sonntag",
                "diesen Sonntag",
                "nächsten Sonntag",
                new RelativeTimeCountResource("Sonntag vor {0} Woche", "Sonntag vor {0} Wochen"),
                new RelativeTimeCountResource("Sonntag in {0} Woche", "Sonntag in {0} Wochen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "letzten So.",
                "diesen So.",
                "nächsten So.",
                new RelativeTimeCountResource("So. vor {0} W.", "So. vor {0} W."),
                new RelativeTimeCountResource("So. in {0} W.", "So. in {0} W.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "letzten So.",
                "diesen So.",
                "nächsten So.",
                new RelativeTimeCountResource("So. vor {0} Woche", "So. vor {0} Wochen"),
                new RelativeTimeCountResource("So. in {0} Woche", "So. in {0} Wochen")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "letzten Montag",
                "diesen Montag",
                "nächsten Montag",
                new RelativeTimeCountResource("Montag vor {0} Woche", "Montag vor {0} Wochen"),
                new RelativeTimeCountResource("Montag in {0} Woche", "Montag in {0} Wochen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "letzten Mo.",
                "diesen Mo.",
                "nächsten Mo.",
                new RelativeTimeCountResource("Mo. vor {0} W.", "Mo. vor {0} W."),
                new RelativeTimeCountResource("Mo. in {0} W.", "Mo. in {0} W.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "letzten Mo.",
                "diesen Mo.",
                "nächsten Mo.",
                new RelativeTimeCountResource("Mo. vor {0} Woche", "Mo. vor {0} Wochen"),
                new RelativeTimeCountResource("Mo. in {0} Woche", "Mo. in {0} Wochen")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "letzten Dienstag",
                "diesen Dienstag",
                "nächsten Dienstag",
                new RelativeTimeCountResource("Dienstag vor {0} Woche", "Dienstag vor {0} Wochen"),
                new RelativeTimeCountResource("Dienstag in {0} Woche", "Dienstag in {0} Wochen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "letzten Di.",
                "diesen Di.",
                "nächsten Di.",
                new RelativeTimeCountResource("Di. vor {0} W.", "Di. vor {0} W."),
                new RelativeTimeCountResource("Di. in {0} W.", "Di. in {0} W.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "letzten Di.",
                "diesen Di.",
                "nächsten Di.",
                new RelativeTimeCountResource("Di. vor {0} Woche", "Di. vor {0} Wochen"),
                new RelativeTimeCountResource("Di. in {0} Woche", "Di. in {0} Wochen")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "letzten Mittwoch",
                "diesen Mittwoch",
                "nächsten Mittwoch",
                new RelativeTimeCountResource("Mittwoch vor {0} Woche", "Mittwoch vor {0} Wochen"),
                new RelativeTimeCountResource("Mittwoch in {0} Woche", "Mittwoch in {0} Wochen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "letzten Mi.",
                "diesen Mi.",
                "nächsten Mi.",
                new RelativeTimeCountResource("Mi. vor {0} W.", "Mi. vor {0} W."),
                new RelativeTimeCountResource("Mi. in {0} W.", "Mi. in {0} W.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "letzten Mi.",
                "diesen Mi.",
                "nächsten Mi.",
                new RelativeTimeCountResource("Mi. vor {0} Woche", "Mi. vor {0} Wochen"),
                new RelativeTimeCountResource("Mi. in {0} Woche", "Mi. in {0} Wochen")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "letzten Donnerstag",
                "diesen Donnerstag",
                "nächsten Donnerstag",
                new RelativeTimeCountResource("Donnerstag vor {0} Woche", "Donnerstag vor {0} Wochen"),
                new RelativeTimeCountResource("Donnerstag in {0} Woche", "Donnerstag in {0} Wochen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "letzten Do.",
                "diesen Do.",
                "nächsten Do.",
                new RelativeTimeCountResource("Do. vor {0} W.", "Do. vor {0} W."),
                new RelativeTimeCountResource("Do. in {0} W.", "Do. in {0} W.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "letzten Do.",
                "diesen Do.",
                "nächsten Do.",
                new RelativeTimeCountResource("Do. vor {0} Woche", "Do. vor {0} Wochen"),
                new RelativeTimeCountResource("Do. in {0} Woche", "Do. in {0} Wochen")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "letzten Freitag",
                "diesen Freitag",
                "nächsten Freitag",
                new RelativeTimeCountResource("Freitag vor {0} Woche", "Freitag vor {0} Wochen"),
                new RelativeTimeCountResource("Freitag in {0} Woche", "Freitag in {0} Wochen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "letzten Fr.",
                "diesen Fr.",
                "nächsten Fr.",
                new RelativeTimeCountResource("Fr. vor {0} W.", "Fr. vor {0} W."),
                new RelativeTimeCountResource("Fr. in {0} W.", "Fr. in {0} W.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "letzten Fr.",
                "diesen Fr.",
                "nächsten Fr.",
                new RelativeTimeCountResource("Fr. vor {0} Woche", "Fr. vor {0} Wochen"),
                new RelativeTimeCountResource("Fr. in {0} Woche", "Fr. in {0} Wochen")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "letzten Samstag",
                "diesen Samstag",
                "nächsten Samstag",
                new RelativeTimeCountResource("Samstag vor {0} Woche", "Samstag vor {0} Wochen"),
                new RelativeTimeCountResource("Samstag in {0} Woche", "Samstag in {0} Wochen")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "letzten Sa.",
                "diesen Sa.",
                "nächsten Sa.",
                new RelativeTimeCountResource("Sa. vor {0} W.", "Sa. vor {0} W."),
                new RelativeTimeCountResource("Sa. in {0} W.", "Sa. in {0} W.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "letzten Sa.",
                "diesen Sa.",
                "nächsten Sa.",
                new RelativeTimeCountResource("Sa. vor {0} Woche", "Sa. vor {0} Wochen"),
                new RelativeTimeCountResource("Sa. in {0} Woche", "Sa. in {0} Wochen")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Tageshälfte",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Tagesh.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Tageshälfte",
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
                "Stunde",
                null,
                "in dieser Stunde",
                null,
                new RelativeTimeCountResource("vor {0} Stunde", "vor {0} Stunden"),
                new RelativeTimeCountResource("in {0} Stunde", "in {0} Stunden")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Std.",
                null,
                "in dieser Stunde",
                null,
                new RelativeTimeCountResource("vor {0} Std.", "vor {0} Std."),
                new RelativeTimeCountResource("in {0} Std.", "in {0} Std.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Std.",
                null,
                "in dieser Stunde",
                null,
                new RelativeTimeCountResource("vor {0} Std.", "vor {0} Std."),
                new RelativeTimeCountResource("in {0} Std.", "in {0} Std.")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Minute",
                null,
                "in dieser Minute",
                null,
                new RelativeTimeCountResource("vor {0} Minute", "vor {0} Minuten"),
                new RelativeTimeCountResource("in {0} Minute", "in {0} Minuten")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Min.",
                null,
                "in dieser Minute",
                null,
                new RelativeTimeCountResource("vor {0} m", "vor {0} m"),
                new RelativeTimeCountResource("in {0} m", "in {0} m")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Min.",
                null,
                "in dieser Minute",
                null,
                new RelativeTimeCountResource("vor {0} Min.", "vor {0} Min."),
                new RelativeTimeCountResource("in {0} Min.", "in {0} Min.")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Sekunde",
                null,
                "jetzt",
                null,
                new RelativeTimeCountResource("vor {0} Sekunde", "vor {0} Sekunden"),
                new RelativeTimeCountResource("in {0} Sekunde", "in {0} Sekunden")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Sek.",
                null,
                "jetzt",
                null,
                new RelativeTimeCountResource("vor {0} s", "vor {0} s"),
                new RelativeTimeCountResource("in {0} s", "in {0} s")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Sek.",
                null,
                "jetzt",
                null,
                new RelativeTimeCountResource("vor {0} Sek.", "vor {0} Sek."),
                new RelativeTimeCountResource("in {0} Sek.", "in {0} Sek.")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Zeitzone",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Zeitz.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Zeitzone",
                null,
                null,
                null,
                null,
                null));
    }
}