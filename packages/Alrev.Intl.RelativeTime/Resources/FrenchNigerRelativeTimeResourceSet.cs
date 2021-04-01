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
    public class FrenchNigerRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "fr-NE";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ère",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ère",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ère",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "année",
                new Dictionary<int, string> { { -1, "l’année dernière" }, { 0, "cette année" }, { 1, "l’année prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} an" }, { PluralRulesValues.Other, "il y a {0} ans" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} an" }, { PluralRulesValues.Other, "dans {0} ans" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "a",
                new Dictionary<int, string> { { -1, "l’année dernière" }, { 0, "cette année" }, { 1, "l’année prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} a" }, { PluralRulesValues.Other, "-{0} a" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} a" }, { PluralRulesValues.Other, "+{0} a" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "an",
                new Dictionary<int, string> { { -1, "l’année dernière" }, { 0, "cette année" }, { 1, "l’année prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} a" }, { PluralRulesValues.Other, "il y a {0} a" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} a" }, { PluralRulesValues.Other, "dans {0} a" } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "trimestre",
                new Dictionary<int, string> { { -1, "le trimestre dernier" }, { 0, "ce trimestre" }, { 1, "le trimestre prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} trimestre" }, { PluralRulesValues.Other, "il y a {0} trimestres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} trimestre" }, { PluralRulesValues.Other, "dans {0} trimestres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "trim.",
                new Dictionary<int, string> { { -1, "le trimestre dernier" }, { 0, "ce trimestre" }, { 1, "le trimestre prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} trim." }, { PluralRulesValues.Other, "-{0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} trim." }, { PluralRulesValues.Other, "+{0} trim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "trim.",
                new Dictionary<int, string> { { -1, "le trimestre dernier" }, { 0, "ce trimestre" }, { 1, "le trimestre prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} trim." }, { PluralRulesValues.Other, "il y a {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} trim." }, { PluralRulesValues.Other, "dans {0} trim." } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "mois",
                new Dictionary<int, string> { { -1, "le mois dernier" }, { 0, "ce mois-ci" }, { 1, "le mois prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mois" }, { PluralRulesValues.Other, "il y a {0} mois" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mois" }, { PluralRulesValues.Other, "dans {0} mois" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "m.",
                new Dictionary<int, string> { { -1, "le mois dernier" }, { 0, "ce mois-ci" }, { 1, "le mois prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} m." }, { PluralRulesValues.Other, "-{0} m." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} m." }, { PluralRulesValues.Other, "+{0} m." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "m.",
                new Dictionary<int, string> { { -1, "le mois dernier" }, { 0, "ce mois-ci" }, { 1, "le mois prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} m." }, { PluralRulesValues.Other, "il y a {0} m." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} m." }, { PluralRulesValues.Other, "dans {0} m." } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "semaine",
                new Dictionary<int, string> { { -1, "la semaine dernière" }, { 0, "cette semaine" }, { 1, "la semaine prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} semaine" }, { PluralRulesValues.Other, "il y a {0} semaines" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} semaine" }, { PluralRulesValues.Other, "dans {0} semaines" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sem.",
                new Dictionary<int, string> { { -1, "la semaine dernière" }, { 0, "cette semaine" }, { 1, "la semaine prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} sem." }, { PluralRulesValues.Other, "-{0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} sem." }, { PluralRulesValues.Other, "+{0} sem." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sem.",
                new Dictionary<int, string> { { -1, "la semaine dernière" }, { 0, "cette semaine" }, { 1, "la semaine prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} sem." }, { PluralRulesValues.Other, "il y a {0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sem." }, { PluralRulesValues.Other, "dans {0} sem." } }));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "semaine (mois)",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sem. (m.)",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sem. (m.)",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "jour",
                new Dictionary<int, string> { { -2, "avant-hier" }, { -1, "hier" }, { 0, "aujourd’hui" }, { 1, "demain" }, { 2, "après-demain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jour" }, { PluralRulesValues.Other, "il y a {0} jours" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jour" }, { PluralRulesValues.Other, "dans {0} jours" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "j",
                new Dictionary<int, string> { { -2, "avant-hier" }, { -1, "hier" }, { 0, "aujourd’hui" }, { 1, "demain" }, { 2, "après-demain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} j" }, { PluralRulesValues.Other, "-{0} j" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} j" }, { PluralRulesValues.Other, "+{0} j" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "j",
                new Dictionary<int, string> { { -2, "avant-hier" }, { -1, "hier" }, { 0, "aujourd’hui" }, { 1, "demain" }, { 2, "après-demain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} j" }, { PluralRulesValues.Other, "il y a {0} j" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} j" }, { PluralRulesValues.Other, "dans {0} j" } }));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "jour (année)",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "j (an)",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "j (an)",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "jour de la semaine",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "j (sem.)",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "j (sem.)",
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "jour (mois)",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "jour (mois)",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "jour (mois)",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dimanche dernier" }, { 0, "ce dimanche" }, { 1, "dimanche prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} dimanche" }, { PluralRulesValues.Other, "il y a {0} dimanches" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} dimanche" }, { PluralRulesValues.Other, "dans {0} dimanches" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dim. dernier" }, { 0, "ce dim." }, { 1, "dim. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} dim." }, { PluralRulesValues.Other, "il y a {0} dim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} dim." }, { PluralRulesValues.Other, "dans {0} dim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dim. dernier" }, { 0, "ce dim." }, { 1, "dim. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} dim." }, { PluralRulesValues.Other, "il y a {0} dim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} dim." }, { PluralRulesValues.Other, "dans {0} dim." } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "lundi dernier" }, { 0, "ce lundi" }, { 1, "lundi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} lundi" }, { PluralRulesValues.Other, "il y a {0} lundis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} lundi" }, { PluralRulesValues.Other, "dans {0} lundis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "lun. dernier" }, { 0, "ce lun." }, { 1, "lun. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} lun." }, { PluralRulesValues.Other, "il y a {0} lun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} lun." }, { PluralRulesValues.Other, "dans {0} lun." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "lun. dernier" }, { 0, "ce lun." }, { 1, "lun. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} lun." }, { PluralRulesValues.Other, "il y a {0} lun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} lun." }, { PluralRulesValues.Other, "dans {0} lun." } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "mardi dernier" }, { 0, "ce mardi" }, { 1, "mardi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mardi" }, { PluralRulesValues.Other, "il y a {0} mardis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mardi" }, { PluralRulesValues.Other, "dans {0} mardis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "mar. dernier" }, { 0, "ce mar." }, { 1, "mar. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mar." }, { PluralRulesValues.Other, "il y a {0} mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mar." }, { PluralRulesValues.Other, "dans {0} mar." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "mar. dernier" }, { 0, "ce mar." }, { 1, "mar. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mar." }, { PluralRulesValues.Other, "il y a {0} mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mar." }, { PluralRulesValues.Other, "dans {0} mar." } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "mercredi dernier" }, { 0, "ce mercredi" }, { 1, "mercredi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mercredi" }, { PluralRulesValues.Other, "il y a {0} mercredis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mercredi" }, { PluralRulesValues.Other, "dans {0} mercredis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "mer. dernier" }, { 0, "ce mer." }, { 1, "mer. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mer." }, { PluralRulesValues.Other, "il y a {0} mer." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mer." }, { PluralRulesValues.Other, "dans {0} mer." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "mer. dernier" }, { 0, "ce mer." }, { 1, "mer. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mer." }, { PluralRulesValues.Other, "il y a {0} mer." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mer." }, { PluralRulesValues.Other, "dans {0} mer." } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "jeudi dernier" }, { 0, "ce jeudi" }, { 1, "jeudi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jeudi" }, { PluralRulesValues.Other, "il y a {0} jeudis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jeudi" }, { PluralRulesValues.Other, "dans {0} jeudis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "jeu. dernier" }, { 0, "ce jeu." }, { 1, "jeu. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jeu." }, { PluralRulesValues.Other, "il y a {0} jeu." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jeu." }, { PluralRulesValues.Other, "dans {0} jeu." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "jeu. dernier" }, { 0, "ce jeu." }, { 1, "jeu. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jeu." }, { PluralRulesValues.Other, "il y a {0} jeu." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jeu." }, { PluralRulesValues.Other, "dans {0} jeu." } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "vendredi dernier" }, { 0, "ce vendredi" }, { 1, "vendredi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} vendredi" }, { PluralRulesValues.Other, "il y a {0} vendredis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} vendredi" }, { PluralRulesValues.Other, "dans {0} vendredis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ven. dernier" }, { 0, "ce ven." }, { 1, "ven. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} ven." }, { PluralRulesValues.Other, "il y a {0} ven." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} ven." }, { PluralRulesValues.Other, "dans {0} ven." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ven. dernier" }, { 0, "ce ven." }, { 1, "ven. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} ven." }, { PluralRulesValues.Other, "il y a {0} ven." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} ven." }, { PluralRulesValues.Other, "dans {0} ven." } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "samedi dernier" }, { 0, "ce samedi" }, { 1, "samedi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} samedi" }, { PluralRulesValues.Other, "il y a {0} samedis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} samedi" }, { PluralRulesValues.Other, "dans {0} samedis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sam. dernier" }, { 0, "ce sam." }, { 1, "sam. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} sam." }, { PluralRulesValues.Other, "il y a {0} sam." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sam." }, { PluralRulesValues.Other, "dans {0} sam." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sam. dernier" }, { 0, "ce sam." }, { 1, "sam. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sam." }, { PluralRulesValues.Other, "dans {0} sam." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sam." }, { PluralRulesValues.Other, "dans {0} sam." } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "cadran",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "cadran",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "cadran",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "heure",
                new Dictionary<int, string> { { 0, "cette heure-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} heure" }, { PluralRulesValues.Other, "il y a {0} heures" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} heure" }, { PluralRulesValues.Other, "dans {0} heures" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "h",
                new Dictionary<int, string> { { 0, "cette heure-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} h" }, { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} h" }, { PluralRulesValues.Other, "+{0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "h",
                new Dictionary<int, string> { { 0, "cette heure-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} h" }, { PluralRulesValues.Other, "il y a {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} h" }, { PluralRulesValues.Other, "dans {0} h" } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minute",
                new Dictionary<int, string> { { 0, "cette minute-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} minute" }, { PluralRulesValues.Other, "il y a {0} minutes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} minute" }, { PluralRulesValues.Other, "dans {0} minutes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "cette minute-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} min" }, { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} min" }, { PluralRulesValues.Other, "+{0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "cette minute-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} min" }, { PluralRulesValues.Other, "il y a {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} min" }, { PluralRulesValues.Other, "dans {0} min" } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "seconde",
                new Dictionary<int, string> { { 0, "maintenant" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} seconde" }, { PluralRulesValues.Other, "il y a {0} secondes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} seconde" }, { PluralRulesValues.Other, "dans {0} secondes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "maintenant" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} s" }, { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} s" }, { PluralRulesValues.Other, "+{0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "s",
                new Dictionary<int, string> { { 0, "maintenant" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} s" }, { PluralRulesValues.Other, "il y a {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} s" }, { PluralRulesValues.Other, "dans {0} s" } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "fuseau horaire",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "fuseau horaire",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "fuseau horaire",
                null,
                null,
                null));
    }
}