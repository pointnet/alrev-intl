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
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ère",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ère",
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
                "année",
                "l’année dernière",
                "cette année",
                "l’année prochaine",
                new RelativeTimeCountResource("il y a {0} an", "il y a {0} ans"),
                new RelativeTimeCountResource("dans {0} an", "dans {0} ans")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "a",
                "l’année dernière",
                "cette année",
                "l’année prochaine",
                new RelativeTimeCountResource("-{0} a", "-{0} a"),
                new RelativeTimeCountResource("+{0} a", "+{0} a")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "an",
                "l’année dernière",
                "cette année",
                "l’année prochaine",
                new RelativeTimeCountResource("il y a {0} a", "il y a {0} a"),
                new RelativeTimeCountResource("dans {0} a", "dans {0} a")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "trimestre",
                "le trimestre dernier",
                "ce trimestre",
                "le trimestre prochain",
                new RelativeTimeCountResource("il y a {0} trimestre", "il y a {0} trimestres"),
                new RelativeTimeCountResource("dans {0} trimestre", "dans {0} trimestres")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "trim.",
                "le trimestre dernier",
                "ce trimestre",
                "le trimestre prochain",
                new RelativeTimeCountResource("-{0} trim.", "-{0} trim."),
                new RelativeTimeCountResource("+{0} trim.", "+{0} trim.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "trim.",
                "le trimestre dernier",
                "ce trimestre",
                "le trimestre prochain",
                new RelativeTimeCountResource("il y a {0} trim.", "il y a {0} trim."),
                new RelativeTimeCountResource("dans {0} trim.", "dans {0} trim.")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "mois",
                "le mois dernier",
                "ce mois-ci",
                "le mois prochain",
                new RelativeTimeCountResource("il y a {0} mois", "il y a {0} mois"),
                new RelativeTimeCountResource("dans {0} mois", "dans {0} mois")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "m.",
                "le mois dernier",
                "ce mois-ci",
                "le mois prochain",
                new RelativeTimeCountResource("-{0} m.", "-{0} m."),
                new RelativeTimeCountResource("+{0} m.", "+{0} m.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "m.",
                "le mois dernier",
                "ce mois-ci",
                "le mois prochain",
                new RelativeTimeCountResource("il y a {0} m.", "il y a {0} m."),
                new RelativeTimeCountResource("dans {0} m.", "dans {0} m.")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "semaine",
                "la semaine dernière",
                "cette semaine",
                "la semaine prochaine",
                new RelativeTimeCountResource("il y a {0} semaine", "il y a {0} semaines"),
                new RelativeTimeCountResource("dans {0} semaine", "dans {0} semaines")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sem.",
                "la semaine dernière",
                "cette semaine",
                "la semaine prochaine",
                new RelativeTimeCountResource("-{0} sem.", "-{0} sem."),
                new RelativeTimeCountResource("+{0} sem.", "+{0} sem.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sem.",
                "la semaine dernière",
                "cette semaine",
                "la semaine prochaine",
                new RelativeTimeCountResource("il y a {0} sem.", "il y a {0} sem."),
                new RelativeTimeCountResource("dans {0} sem.", "dans {0} sem.")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "semaine (mois)",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sem. (m.)",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sem. (m.)",
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
                "jour",
                "hier",
                "aujourd’hui",
                "demain",
                new RelativeTimeCountResource("il y a {0} jour", "il y a {0} jours"),
                new RelativeTimeCountResource("dans {0} jour", "dans {0} jours")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "j",
                "hier",
                "aujourd’hui",
                "demain",
                new RelativeTimeCountResource("-{0} j", "-{0} j"),
                new RelativeTimeCountResource("+{0} j", "+{0} j")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "j",
                "hier",
                "aujourd’hui",
                "demain",
                new RelativeTimeCountResource("il y a {0} j", "il y a {0} j"),
                new RelativeTimeCountResource("dans {0} j", "dans {0} j")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "jour (année)",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "j (an)",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "j (an)",
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
                "jour de la semaine",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "j (sem.)",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "j (sem.)",
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
                "jour (mois)",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "jour (mois)",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "jour (mois)",
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
                "dimanche dernier",
                "ce dimanche",
                "dimanche prochain",
                new RelativeTimeCountResource("il y a {0} dimanche", "il y a {0} dimanches"),
                new RelativeTimeCountResource("dans {0} dimanche", "dans {0} dimanches")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "dim. dernier",
                "ce dim.",
                "dim. prochain",
                new RelativeTimeCountResource("il y a {0} dim.", "il y a {0} dim."),
                new RelativeTimeCountResource("dans {0} dim.", "dans {0} dim.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "dim. dernier",
                "ce dim.",
                "dim. prochain",
                new RelativeTimeCountResource("il y a {0} dim.", "il y a {0} dim."),
                new RelativeTimeCountResource("dans {0} dim.", "dans {0} dim.")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "lundi dernier",
                "ce lundi",
                "lundi prochain",
                new RelativeTimeCountResource("il y a {0} lundi", "il y a {0} lundis"),
                new RelativeTimeCountResource("dans {0} lundi", "dans {0} lundis")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "lun. dernier",
                "ce lun.",
                "lun. prochain",
                new RelativeTimeCountResource("il y a {0} lun.", "il y a {0} lun."),
                new RelativeTimeCountResource("dans {0} lun.", "dans {0} lun.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "lun. dernier",
                "ce lun.",
                "lun. prochain",
                new RelativeTimeCountResource("il y a {0} lun.", "il y a {0} lun."),
                new RelativeTimeCountResource("dans {0} lun.", "dans {0} lun.")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "mardi dernier",
                "ce mardi",
                "mardi prochain",
                new RelativeTimeCountResource("il y a {0} mardi", "il y a {0} mardis"),
                new RelativeTimeCountResource("dans {0} mardi", "dans {0} mardis")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "mar. dernier",
                "ce mar.",
                "mar. prochain",
                new RelativeTimeCountResource("il y a {0} mar.", "il y a {0} mar."),
                new RelativeTimeCountResource("dans {0} mar.", "dans {0} mar.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "mar. dernier",
                "ce mar.",
                "mar. prochain",
                new RelativeTimeCountResource("il y a {0} mar.", "il y a {0} mar."),
                new RelativeTimeCountResource("dans {0} mar.", "dans {0} mar.")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "mercredi dernier",
                "ce mercredi",
                "mercredi prochain",
                new RelativeTimeCountResource("il y a {0} mercredi", "il y a {0} mercredis"),
                new RelativeTimeCountResource("dans {0} mercredi", "dans {0} mercredis")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "mer. dernier",
                "ce mer.",
                "mer. prochain",
                new RelativeTimeCountResource("il y a {0} mer.", "il y a {0} mer."),
                new RelativeTimeCountResource("dans {0} mer.", "dans {0} mer.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "mer. dernier",
                "ce mer.",
                "mer. prochain",
                new RelativeTimeCountResource("il y a {0} mer.", "il y a {0} mer."),
                new RelativeTimeCountResource("dans {0} mer.", "dans {0} mer.")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "jeudi dernier",
                "ce jeudi",
                "jeudi prochain",
                new RelativeTimeCountResource("il y a {0} jeudi", "il y a {0} jeudis"),
                new RelativeTimeCountResource("dans {0} jeudi", "dans {0} jeudis")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "jeu. dernier",
                "ce jeu.",
                "jeu. prochain",
                new RelativeTimeCountResource("il y a {0} jeu.", "il y a {0} jeu."),
                new RelativeTimeCountResource("dans {0} jeu.", "dans {0} jeu.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "jeu. dernier",
                "ce jeu.",
                "jeu. prochain",
                new RelativeTimeCountResource("il y a {0} jeu.", "il y a {0} jeu."),
                new RelativeTimeCountResource("dans {0} jeu.", "dans {0} jeu.")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "vendredi dernier",
                "ce vendredi",
                "vendredi prochain",
                new RelativeTimeCountResource("il y a {0} vendredi", "il y a {0} vendredis"),
                new RelativeTimeCountResource("dans {0} vendredi", "dans {0} vendredis")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "ven. dernier",
                "ce ven.",
                "ven. prochain",
                new RelativeTimeCountResource("il y a {0} ven.", "il y a {0} ven."),
                new RelativeTimeCountResource("dans {0} ven.", "dans {0} ven.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "ven. dernier",
                "ce ven.",
                "ven. prochain",
                new RelativeTimeCountResource("il y a {0} ven.", "il y a {0} ven."),
                new RelativeTimeCountResource("dans {0} ven.", "dans {0} ven.")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "samedi dernier",
                "ce samedi",
                "samedi prochain",
                new RelativeTimeCountResource("il y a {0} samedi", "il y a {0} samedis"),
                new RelativeTimeCountResource("dans {0} samedi", "dans {0} samedis")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "sam. dernier",
                "ce sam.",
                "sam. prochain",
                new RelativeTimeCountResource("il y a {0} sam.", "il y a {0} sam."),
                new RelativeTimeCountResource("dans {0} sam.", "dans {0} sam.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "sam. dernier",
                "ce sam.",
                "sam. prochain",
                new RelativeTimeCountResource("dans {0} sam.", "dans {0} sam."),
                new RelativeTimeCountResource("dans {0} sam.", "dans {0} sam.")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "cadran",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "cadran",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "cadran",
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
                "heure",
                null,
                "cette heure-ci",
                null,
                new RelativeTimeCountResource("il y a {0} heure", "il y a {0} heures"),
                new RelativeTimeCountResource("dans {0} heure", "dans {0} heures")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "h",
                null,
                "cette heure-ci",
                null,
                new RelativeTimeCountResource("-{0} h", "-{0} h"),
                new RelativeTimeCountResource("+{0} h", "+{0} h")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "h",
                null,
                "cette heure-ci",
                null,
                new RelativeTimeCountResource("il y a {0} h", "il y a {0} h"),
                new RelativeTimeCountResource("dans {0} h", "dans {0} h")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minute",
                null,
                "cette minute-ci",
                null,
                new RelativeTimeCountResource("il y a {0} minute", "il y a {0} minutes"),
                new RelativeTimeCountResource("dans {0} minute", "dans {0} minutes")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                null,
                "cette minute-ci",
                null,
                new RelativeTimeCountResource("-{0} min", "-{0} min"),
                new RelativeTimeCountResource("+{0} min", "+{0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                null,
                "cette minute-ci",
                null,
                new RelativeTimeCountResource("il y a {0} min", "il y a {0} min"),
                new RelativeTimeCountResource("dans {0} min", "dans {0} min")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "seconde",
                null,
                "maintenant",
                null,
                new RelativeTimeCountResource("il y a {0} seconde", "il y a {0} secondes"),
                new RelativeTimeCountResource("dans {0} seconde", "dans {0} secondes")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "s",
                null,
                "maintenant",
                null,
                new RelativeTimeCountResource("-{0} s", "-{0} s"),
                new RelativeTimeCountResource("+{0} s", "+{0} s")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "s",
                null,
                "maintenant",
                null,
                new RelativeTimeCountResource("il y a {0} s", "il y a {0} s"),
                new RelativeTimeCountResource("dans {0} s", "dans {0} s")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "fuseau horaire",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "fuseau horaire",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "fuseau horaire",
                null,
                null,
                null,
                null,
                null));
    }
}