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
    public class LuxembourgishRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "lb";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Epoch",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Epoch",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Epoch",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Joer",
                new Dictionary<int, string> { { -1, "lescht Joer" }, { 0, "dëst Joer" }, { 1, "nächst Joer" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Joer" }, { PluralRulesValues.Other, "viru(n) {0} Joer" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Joer" }, { PluralRulesValues.Other, "a(n) {0} Joer" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "J.",
                new Dictionary<int, string> { { -1, "lescht Joer" }, { 0, "dëst Joer" }, { 1, "nächst Joer" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} J." }, { PluralRulesValues.Other, "-{0} J." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} J." }, { PluralRulesValues.Other, "+{0} J." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "J.",
                new Dictionary<int, string> { { -1, "lescht Joer" }, { 0, "dëst Joer" }, { 1, "nächst Joer" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} J." }, { PluralRulesValues.Other, "viru(n) {0} J." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} J." }, { PluralRulesValues.Other, "a(n) {0} J." } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Quartal",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Quartal" }, { PluralRulesValues.Other, "viru(n) {0} Quartaler" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Quartal" }, { PluralRulesValues.Other, "a(n) {0} Quartaler" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Q.",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} Q." }, { PluralRulesValues.Other, "-{0} Q." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} Q." }, { PluralRulesValues.Other, "+{0} Q." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Q.",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Q." }, { PluralRulesValues.Other, "viru(n) {0} Q." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Q." }, { PluralRulesValues.Other, "a(n) {0} Q." } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Mount",
                new Dictionary<int, string> { { -1, "leschte Mount" }, { 0, "dëse Mount" }, { 1, "nächste Mount" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Mount" }, { PluralRulesValues.Other, "viru(n) {0} Méint" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Mount" }, { PluralRulesValues.Other, "a(n) {0} Méint" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "M.",
                new Dictionary<int, string> { { -1, "leschte Mount" }, { 0, "dëse Mount" }, { 1, "nächste Mount" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} M." }, { PluralRulesValues.Other, "-{0} M." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} M." }, { PluralRulesValues.Other, "+{0} M." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "M.",
                new Dictionary<int, string> { { -1, "leschte Mount" }, { 0, "dëse Mount" }, { 1, "nächste Mount" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} M." }, { PluralRulesValues.Other, "viru(n) {0} M." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} M." }, { PluralRulesValues.Other, "a(n) {0} M." } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Woch",
                new Dictionary<int, string> { { -1, "lescht Woch" }, { 0, "dës Woch" }, { 1, "nächst Woch" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Woch" }, { PluralRulesValues.Other, "viru(n) {0} Wochen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Woch" }, { PluralRulesValues.Other, "a(n) {0} Wochen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "W.",
                new Dictionary<int, string> { { -1, "lescht Woch" }, { 0, "dës Woch" }, { 1, "nächst Woch" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} W." }, { PluralRulesValues.Other, "-{0} W." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} W." }, { PluralRulesValues.Other, "+{0} W." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "W.",
                new Dictionary<int, string> { { -1, "lescht Woch" }, { 0, "dës Woch" }, { 1, "nächst Woch" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} W." }, { PluralRulesValues.Other, "viru(n) {0} W." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} W." }, { PluralRulesValues.Other, "a(n) {0} W." } }));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Week Of Month",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Dag",
                new Dictionary<int, string> { { -1, "gëschter" }, { 0, "haut" }, { 1, "muer" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Dag" }, { PluralRulesValues.Other, "viru(n) {0} Deeg" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Dag" }, { PluralRulesValues.Other, "a(n) {0} Deeg" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "D.",
                new Dictionary<int, string> { { -1, "gëschter" }, { 0, "haut" }, { 1, "muer" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} D." }, { PluralRulesValues.Other, "-{0} D." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} D." }, { PluralRulesValues.Other, "+{0} D." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "D.",
                new Dictionary<int, string> { { -1, "gëschter" }, { 0, "haut" }, { 1, "muer" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} D." }, { PluralRulesValues.Other, "viru(n) {0} D." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} D." }, { PluralRulesValues.Other, "a(n) {0} D." } }));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Day Of Year",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Wochendag",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Wochendag",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Wochendag",
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
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Weekday Of Month",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "leschte Sonndeg" }, { 0, "dëse Sonndeg" }, { 1, "nächste Sonndeg" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "leschte So." }, { 0, "dëse So." }, { 1, "nächste So." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "leschte Son." }, { 0, "dëse Son." }, { 1, "nächste Son." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "leschte Méindeg" }, { 0, "dëse Méindeg" }, { 1, "nächste Méindeg" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "leschte Mé." }, { 0, "dëse Mé." }, { 1, "nächste Mé." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "leschte Méi." }, { 0, "dëse Méi." }, { 1, "nächste Méi." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "leschten Dënschdeg" }, { 0, "dësen Dënschdeg" }, { 1, "nächsten Dënschdeg" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "leschten Dë." }, { 0, "dësen Dë." }, { 1, "nächsten Dë." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "leschten Dë." }, { 0, "dësen Dë." }, { 1, "nächsten Dë." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "leschte Mëttwoch" }, { 0, "dëse Mëttwoch" }, { 1, "nächste Mëttwoch" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "leschte Më." }, { 0, "dëse Më." }, { 1, "nächste Më." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "leschte Mët." }, { 0, "dëse Mët." }, { 1, "nächste Mët." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "leschten Donneschdeg" }, { 0, "dësen Donneschdeg" }, { 1, "nächsten Donneschdeg" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "leschten Do." }, { 0, "dësen Do." }, { 1, "nächsten Do." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "leschten Don." }, { 0, "dësen Don." }, { 1, "nächsten Don." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "leschte Freideg" }, { 0, "dëse Freideg" }, { 1, "nächste Freideg" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "leschte Fr." }, { 0, "dëse Fr." }, { 1, "nächste Fr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "leschte Fre." }, { 0, "dëse Fre." }, { 1, "nächste Fre." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "leschte Samschdeg" }, { 0, "dëse Samschdeg" }, { 1, "nächste Samschdeg" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "leschte Sa." }, { 0, "dëse Sa." }, { 1, "nächste Sa." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "leschte Sam." }, { 0, "dëse Sam." }, { 1, "nächste Sam." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Dageshallschent",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Dageshallschent",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Dageshallschent",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Stonn",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Stonn" }, { PluralRulesValues.Other, "viru(n) {0} Stonnen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Stonn" }, { PluralRulesValues.Other, "a(n) {0} Stonnen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "St.",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} St." }, { PluralRulesValues.Other, "-{0} St." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} St." }, { PluralRulesValues.Other, "+{0} St." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "St.",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} St." }, { PluralRulesValues.Other, "viru(n) {0} St." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} St." }, { PluralRulesValues.Other, "a(n) {0} St." } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Minutt",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Minutt" }, { PluralRulesValues.Other, "viru(n) {0} Minutten" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Minutt" }, { PluralRulesValues.Other, "a(n) {0} Minutten" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Min.",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} Min." }, { PluralRulesValues.Other, "-{0} Min." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} Min." }, { PluralRulesValues.Other, "+{0} Min." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Min.",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Min." }, { PluralRulesValues.Other, "viru(n) {0} Min." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Min." }, { PluralRulesValues.Other, "a(n) {0} Min." } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Sekonn",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Sekonn" }, { PluralRulesValues.Other, "viru(n) {0} Sekonnen" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Sekonn" }, { PluralRulesValues.Other, "a(n) {0} Sekonnen" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Sek.",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} Sek." }, { PluralRulesValues.Other, "-{0} Sek." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} Sek." }, { PluralRulesValues.Other, "+{0} Sek." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Sek.",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "virun {0} Sek." }, { PluralRulesValues.Other, "viru(n) {0} Sek." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "an {0} Sek." }, { PluralRulesValues.Other, "a(n) {0} Sek." } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "Zäitzon",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "Zäitzon",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "Zäitzon",
                null,
                null,
                null));
    }
}