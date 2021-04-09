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
    /// <see cref="IRelativeTimeResourceSet"/> for 'French (Mauritania)' [fr-mr]
    /// </summary>
    public class FrenchMauritaniaRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "fr-mr";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "année",
                new Dictionary<int, string> { { -1, "l’année dernière" }, { 0, "cette année" }, { 1, "l’année prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} an" }, { PluralRulesValues.Other, "il y a {0} ans" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} an" }, { PluralRulesValues.Other, "dans {0} ans" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "a",
                new Dictionary<int, string> { { -1, "l’année dernière" }, { 0, "cette année" }, { 1, "l’année prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} a" }, { PluralRulesValues.Other, "-{0} a" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} a" }, { PluralRulesValues.Other, "+{0} a" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "an",
                new Dictionary<int, string> { { -1, "l’année dernière" }, { 0, "cette année" }, { 1, "l’année prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} a" }, { PluralRulesValues.Other, "il y a {0} a" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} a" }, { PluralRulesValues.Other, "dans {0} a" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "trimestre",
                new Dictionary<int, string> { { -1, "le trimestre dernier" }, { 0, "ce trimestre" }, { 1, "le trimestre prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} trimestre" }, { PluralRulesValues.Other, "il y a {0} trimestres" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} trimestre" }, { PluralRulesValues.Other, "dans {0} trimestres" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "trim.",
                new Dictionary<int, string> { { -1, "le trimestre dernier" }, { 0, "ce trimestre" }, { 1, "le trimestre prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} trim." }, { PluralRulesValues.Other, "-{0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} trim." }, { PluralRulesValues.Other, "+{0} trim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "trim.",
                new Dictionary<int, string> { { -1, "le trimestre dernier" }, { 0, "ce trimestre" }, { 1, "le trimestre prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} trim." }, { PluralRulesValues.Other, "il y a {0} trim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} trim." }, { PluralRulesValues.Other, "dans {0} trim." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "mois",
                new Dictionary<int, string> { { -1, "le mois dernier" }, { 0, "ce mois-ci" }, { 1, "le mois prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mois" }, { PluralRulesValues.Other, "il y a {0} mois" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mois" }, { PluralRulesValues.Other, "dans {0} mois" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "m.",
                new Dictionary<int, string> { { -1, "le mois dernier" }, { 0, "ce mois-ci" }, { 1, "le mois prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} m." }, { PluralRulesValues.Other, "-{0} m." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} m." }, { PluralRulesValues.Other, "+{0} m." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "m.",
                new Dictionary<int, string> { { -1, "le mois dernier" }, { 0, "ce mois-ci" }, { 1, "le mois prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} m." }, { PluralRulesValues.Other, "il y a {0} m." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} m." }, { PluralRulesValues.Other, "dans {0} m." } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "semaine",
                new Dictionary<int, string> { { -1, "la semaine dernière" }, { 0, "cette semaine" }, { 1, "la semaine prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} semaine" }, { PluralRulesValues.Other, "il y a {0} semaines" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} semaine" }, { PluralRulesValues.Other, "dans {0} semaines" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "sem.",
                new Dictionary<int, string> { { -1, "la semaine dernière" }, { 0, "cette semaine" }, { 1, "la semaine prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} sem." }, { PluralRulesValues.Other, "-{0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} sem." }, { PluralRulesValues.Other, "+{0} sem." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "sem.",
                new Dictionary<int, string> { { -1, "la semaine dernière" }, { 0, "cette semaine" }, { 1, "la semaine prochaine" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} sem." }, { PluralRulesValues.Other, "il y a {0} sem." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sem." }, { PluralRulesValues.Other, "dans {0} sem." } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "jour",
                new Dictionary<int, string> { { -2, "avant-hier" }, { -1, "hier" }, { 0, "aujourd’hui" }, { 1, "demain" }, { 2, "après-demain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jour" }, { PluralRulesValues.Other, "il y a {0} jours" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jour" }, { PluralRulesValues.Other, "dans {0} jours" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "j",
                new Dictionary<int, string> { { -2, "avant-hier" }, { -1, "hier" }, { 0, "aujourd’hui" }, { 1, "demain" }, { 2, "après-demain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} j" }, { PluralRulesValues.Other, "-{0} j" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} j" }, { PluralRulesValues.Other, "+{0} j" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "j",
                new Dictionary<int, string> { { -2, "avant-hier" }, { -1, "hier" }, { 0, "aujourd’hui" }, { 1, "demain" }, { 2, "après-demain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} j" }, { PluralRulesValues.Other, "il y a {0} j" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} j" }, { PluralRulesValues.Other, "dans {0} j" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "dimanche dernier" }, { 0, "ce dimanche" }, { 1, "dimanche prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} dimanche" }, { PluralRulesValues.Other, "il y a {0} dimanches" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} dimanche" }, { PluralRulesValues.Other, "dans {0} dimanches" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "dim. dernier" }, { 0, "ce dim." }, { 1, "dim. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} dim." }, { PluralRulesValues.Other, "il y a {0} dim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} dim." }, { PluralRulesValues.Other, "dans {0} dim." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "dim. dernier" }, { 0, "ce dim." }, { 1, "dim. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} dim." }, { PluralRulesValues.Other, "il y a {0} dim." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} dim." }, { PluralRulesValues.Other, "dans {0} dim." } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "lundi dernier" }, { 0, "ce lundi" }, { 1, "lundi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} lundi" }, { PluralRulesValues.Other, "il y a {0} lundis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} lundi" }, { PluralRulesValues.Other, "dans {0} lundis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "lun. dernier" }, { 0, "ce lun." }, { 1, "lun. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} lun." }, { PluralRulesValues.Other, "il y a {0} lun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} lun." }, { PluralRulesValues.Other, "dans {0} lun." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "lun. dernier" }, { 0, "ce lun." }, { 1, "lun. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} lun." }, { PluralRulesValues.Other, "il y a {0} lun." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} lun." }, { PluralRulesValues.Other, "dans {0} lun." } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "mardi dernier" }, { 0, "ce mardi" }, { 1, "mardi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mardi" }, { PluralRulesValues.Other, "il y a {0} mardis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mardi" }, { PluralRulesValues.Other, "dans {0} mardis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "mar. dernier" }, { 0, "ce mar." }, { 1, "mar. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mar." }, { PluralRulesValues.Other, "il y a {0} mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mar." }, { PluralRulesValues.Other, "dans {0} mar." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "mar. dernier" }, { 0, "ce mar." }, { 1, "mar. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mar." }, { PluralRulesValues.Other, "il y a {0} mar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mar." }, { PluralRulesValues.Other, "dans {0} mar." } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "mercredi dernier" }, { 0, "ce mercredi" }, { 1, "mercredi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mercredi" }, { PluralRulesValues.Other, "il y a {0} mercredis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mercredi" }, { PluralRulesValues.Other, "dans {0} mercredis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "mer. dernier" }, { 0, "ce mer." }, { 1, "mer. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mer." }, { PluralRulesValues.Other, "il y a {0} mer." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mer." }, { PluralRulesValues.Other, "dans {0} mer." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "mer. dernier" }, { 0, "ce mer." }, { 1, "mer. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mer." }, { PluralRulesValues.Other, "il y a {0} mer." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mer." }, { PluralRulesValues.Other, "dans {0} mer." } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "jeudi dernier" }, { 0, "ce jeudi" }, { 1, "jeudi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jeudi" }, { PluralRulesValues.Other, "il y a {0} jeudis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jeudi" }, { PluralRulesValues.Other, "dans {0} jeudis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "jeu. dernier" }, { 0, "ce jeu." }, { 1, "jeu. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jeu." }, { PluralRulesValues.Other, "il y a {0} jeu." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jeu." }, { PluralRulesValues.Other, "dans {0} jeu." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "jeu. dernier" }, { 0, "ce jeu." }, { 1, "jeu. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jeu." }, { PluralRulesValues.Other, "il y a {0} jeu." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jeu." }, { PluralRulesValues.Other, "dans {0} jeu." } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "vendredi dernier" }, { 0, "ce vendredi" }, { 1, "vendredi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} vendredi" }, { PluralRulesValues.Other, "il y a {0} vendredis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} vendredi" }, { PluralRulesValues.Other, "dans {0} vendredis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ven. dernier" }, { 0, "ce ven." }, { 1, "ven. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} ven." }, { PluralRulesValues.Other, "il y a {0} ven." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} ven." }, { PluralRulesValues.Other, "dans {0} ven." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ven. dernier" }, { 0, "ce ven." }, { 1, "ven. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} ven." }, { PluralRulesValues.Other, "il y a {0} ven." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} ven." }, { PluralRulesValues.Other, "dans {0} ven." } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "samedi dernier" }, { 0, "ce samedi" }, { 1, "samedi prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} samedi" }, { PluralRulesValues.Other, "il y a {0} samedis" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} samedi" }, { PluralRulesValues.Other, "dans {0} samedis" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "sam. dernier" }, { 0, "ce sam." }, { 1, "sam. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} sam." }, { PluralRulesValues.Other, "il y a {0} sam." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sam." }, { PluralRulesValues.Other, "dans {0} sam." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "sam. dernier" }, { 0, "ce sam." }, { 1, "sam. prochain" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sam." }, { PluralRulesValues.Other, "dans {0} sam." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sam." }, { PluralRulesValues.Other, "dans {0} sam." } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "heure",
                new Dictionary<int, string> { { 0, "cette heure-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} heure" }, { PluralRulesValues.Other, "il y a {0} heures" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} heure" }, { PluralRulesValues.Other, "dans {0} heures" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "h",
                new Dictionary<int, string> { { 0, "cette heure-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} h" }, { PluralRulesValues.Other, "-{0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} h" }, { PluralRulesValues.Other, "+{0} h" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "h",
                new Dictionary<int, string> { { 0, "cette heure-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} h" }, { PluralRulesValues.Other, "il y a {0} h" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} h" }, { PluralRulesValues.Other, "dans {0} h" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "minute",
                new Dictionary<int, string> { { 0, "cette minute-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} minute" }, { PluralRulesValues.Other, "il y a {0} minutes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} minute" }, { PluralRulesValues.Other, "dans {0} minutes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "cette minute-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} min" }, { PluralRulesValues.Other, "-{0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} min" }, { PluralRulesValues.Other, "+{0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "cette minute-ci" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} min" }, { PluralRulesValues.Other, "il y a {0} min" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} min" }, { PluralRulesValues.Other, "dans {0} min" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'French (Mauritania)' [fr-mr]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "seconde",
                new Dictionary<int, string> { { 0, "maintenant" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} seconde" }, { PluralRulesValues.Other, "il y a {0} secondes" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} seconde" }, { PluralRulesValues.Other, "dans {0} secondes" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "s",
                new Dictionary<int, string> { { 0, "maintenant" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} s" }, { PluralRulesValues.Other, "-{0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} s" }, { PluralRulesValues.Other, "+{0} s" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "s",
                new Dictionary<int, string> { { 0, "maintenant" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} s" }, { PluralRulesValues.Other, "il y a {0} s" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} s" }, { PluralRulesValues.Other, "dans {0} s" } }));

        /// <summary>
        /// Gets the Relative Time resource styles based on the unit specified
        /// </summary>
        /// <param name="relativeTimeUnit">The resource unit to get</param>
        /// <returns>An <see cref="IRelativeTimeStylesResource"/></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IRelativeTimeStylesResource GetRelativeTimeStylesResource(RelativeTimeUnitValues relativeTimeUnit) => relativeTimeUnit switch
        {
            RelativeTimeUnitValues.Year => this.Year,
            RelativeTimeUnitValues.Quarter => this.Quarter,
            RelativeTimeUnitValues.Month => this.Month,
            RelativeTimeUnitValues.Week => this.Week,
            RelativeTimeUnitValues.Day => this.Day,
            RelativeTimeUnitValues.Sunday => this.Sunday,
            RelativeTimeUnitValues.Monday => this.Monday,
            RelativeTimeUnitValues.Tuesday => this.Tuesday,
            RelativeTimeUnitValues.Wednesday => this.Wednesday,
            RelativeTimeUnitValues.Thursday => this.Thursday,
            RelativeTimeUnitValues.Friday => this.Friday,
            RelativeTimeUnitValues.Saturday => this.Saturday,
            RelativeTimeUnitValues.Hour => this.Hour,
            RelativeTimeUnitValues.Minute => this.Minute,
            RelativeTimeUnitValues.Second => this.Second,
            _ => throw new NotImplementedException($"Relative time unit '{relativeTimeUnit}' is not supported")
        };
    }
}