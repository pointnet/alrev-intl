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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Somali (Ethiopia)' [so-et]
    /// </summary>
    public class SomaliEthiopiaRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "so-et";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "Sannad",
                new Dictionary<int, string> { { -1, "Sannadkii hore" }, { 0, "Sannadkan" }, { 1, "Sannadka danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sannad kahor" }, { PluralRulesValues.Other, "{0} sannadood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sannad" }, { PluralRulesValues.Other, "{0} sannadood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "Snd",
                new Dictionary<int, string> { { -1, "Sannadkii la soo dhaafay" }, { 0, "Sannadkan" }, { 1, "Sannadka xiga" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} snd khr" }, { PluralRulesValues.Other, "{0} Snd khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} snd" }, { PluralRulesValues.Other, "{0} snd" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "snd",
                new Dictionary<int, string> { { -1, "Sannadkii hore" }, { 0, "Sannadkan" }, { 1, "Sannadka danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} snd khr" }, { PluralRulesValues.Other, "{0} Snd khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} snd" }, { PluralRulesValues.Other, "{0} snd" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "Rubuc",
                new Dictionary<int, string> { { -1, "Rubucii hore" }, { 0, "Rubucan" }, { 1, "Rubuca danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} rubuc kahor" }, { PluralRulesValues.Other, "{0} rubuc kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} rubuc" }, { PluralRulesValues.Other, "{0} rubuc" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "rbc",
                new Dictionary<int, string> { { -1, "Rubucii ugu dambeeyay" }, { 0, "Rubucan" }, { 1, "Rubuca xiga" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} rbc khr" }, { PluralRulesValues.Other, "{0} rbc khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} rbc" }, { PluralRulesValues.Other, "{0} rbc" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "rbc",
                new Dictionary<int, string> { { -1, "Rubucii ugu dambeeyay" }, { 0, "Rubucan" }, { 1, "Rubuca xiga" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} rbc khr" }, { PluralRulesValues.Other, "{0} rbc khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} rbc" }, { PluralRulesValues.Other, "{0} rbc" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "Bil",
                new Dictionary<int, string> { { -1, "Bishii hore" }, { 0, "Bishan" }, { 1, "Bisha danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} bil kahor" }, { PluralRulesValues.Other, "{0} bilood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} bil" }, { PluralRulesValues.Other, "{0} bilood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "bil",
                new Dictionary<int, string> { { -1, "Bishii hore" }, { 0, "Bishan" }, { 1, "Bisha danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} bil khr" }, { PluralRulesValues.Other, "{0} bil khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} bil" }, { PluralRulesValues.Other, "{0} bil" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "Bil",
                new Dictionary<int, string> { { -1, "Bishii hore" }, { 0, "Bishan" }, { 1, "Bisha danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} bil khr" }, { PluralRulesValues.Other, "{0} bil khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} bil" }, { PluralRulesValues.Other, "{0} bil" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "Toddobaad",
                new Dictionary<int, string> { { -1, "Toddobaadkii hore" }, { 0, "Usbuucan" }, { 1, "Toddobaadka danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} toddobaad kahor" }, { PluralRulesValues.Other, "{0} toddobaad kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} toddobaad" }, { PluralRulesValues.Other, "{0} toddobaad" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "tdbd",
                new Dictionary<int, string> { { -1, "Toddobaadkii hore" }, { 0, "Toddobaadkan" }, { 1, "Toddobaadka danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tdbd khr" }, { PluralRulesValues.Other, "{0} tdbd khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tdbd" }, { PluralRulesValues.Other, "{0} tdbd" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "tdbd",
                new Dictionary<int, string> { { -1, "Toddobaadkii hore" }, { 0, "Usbuucan" }, { 1, "Toddobaadka danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tdbd khr" }, { PluralRulesValues.Other, "{0} tdbd khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tdbd" }, { PluralRulesValues.Other, "{0} tdbd" } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "maalin",
                new Dictionary<int, string> { { -1, "Shalay" }, { 0, "Maanta" }, { 1, "Berri" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maalin kahor" }, { PluralRulesValues.Other, "{0} maalmood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maalin" }, { PluralRulesValues.Other, "{0} maalmood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "mln",
                new Dictionary<int, string> { { -1, "Shalay" }, { 0, "Maanta" }, { 1, "Berri" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mln khr" }, { PluralRulesValues.Other, "{0} mlmd khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mln" }, { PluralRulesValues.Other, "{0} mlmd" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "mln",
                new Dictionary<int, string> { { -1, "Shalay" }, { 0, "Maanta" }, { 1, "Berri" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mln khr" }, { PluralRulesValues.Other, "{0} mlmd khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mln" }, { PluralRulesValues.Other, "{0} mlmd" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Axadii hore" }, { 0, "Axadan" }, { 1, "Axada danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Axad kahor" }, { PluralRulesValues.Other, "{0} Axadood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Axad" }, { PluralRulesValues.Other, "{0} Axadood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "axadii hore" }, { 0, "axadan" }, { 1, "axada xigta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Axad kahor" }, { PluralRulesValues.Other, "{0} Axadood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Axad" }, { PluralRulesValues.Other, "{0} Axadood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Axadii hore" }, { 0, "Axadan" }, { 1, "Axada danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Axad kahor" }, { PluralRulesValues.Other, "{0} Axadood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Axad" }, { PluralRulesValues.Other, "{0} Axadood" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Isniintii hore" }, { 0, "Isniintan" }, { 1, "Isniinta danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Isniin kahor" }, { PluralRulesValues.Other, "{0} Isniinood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Isniin" }, { PluralRulesValues.Other, "{0} Isniinood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Isnti hre" }, { 0, "Isntn" }, { 1, "Isnta dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Isn khr" }, { PluralRulesValues.Other, "{0} Isn khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Isn" }, { PluralRulesValues.Other, "{0} Isn" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Isnti hre" }, { 0, "Isntn" }, { 1, "Isnta dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Isn khr" }, { PluralRulesValues.Other, "{0} Isn khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Isn" }, { PluralRulesValues.Other, "{0} Isn" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Talaadadii hore" }, { 0, "Talaadadan" }, { 1, "Talaadada xigta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Talaado kahor" }, { PluralRulesValues.Other, "{0} Talaadood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Talaado" }, { PluralRulesValues.Other, "{0} Talaadood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Tlddi hre" }, { 0, "Tlddn" }, { 1, "Tldda xgta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tldo khr" }, { PluralRulesValues.Other, "{0} Tldod khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tldo" }, { PluralRulesValues.Other, "{0} Tldo" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Tlddi hre" }, { 0, "Tlddn" }, { 1, "Tldda xgta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tldo khr" }, { PluralRulesValues.Other, "{0} Tldod khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tldo" }, { PluralRulesValues.Other, "{0} Tldo" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Arbacadii hore" }, { 0, "Arbacadan" }, { 1, "Arbacada danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Arbaca kahor" }, { PluralRulesValues.Other, "{0} Arbacood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Arbaca" }, { PluralRulesValues.Other, "{0} Arbacood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Arbcdi hre" }, { 0, "Arbcdn" }, { 1, "Arbcda dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Arbc khr" }, { PluralRulesValues.Other, "{0} Arbc khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Arbc" }, { PluralRulesValues.Other, "{0} Arbc" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Arbcdi hre" }, { 0, "Arbcdn" }, { 1, "Arbcda dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Arbc khr" }, { PluralRulesValues.Other, "{0} Arbc khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Arbc" }, { PluralRulesValues.Other, "{0} Arbc" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Khamiistii hore" }, { 0, "Khamiistan" }, { 1, "Khamiista danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Khamiis kahor" }, { PluralRulesValues.Other, "{0} Khamiisood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Khamiis" }, { PluralRulesValues.Other, "{0} Khamiisood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Khmsti hre" }, { 0, "Khmstn" }, { 1, "Khmsta dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} khms khr" }, { PluralRulesValues.Other, "{0} khms khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} khms" }, { PluralRulesValues.Other, "{0} khms" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Khmsti hre" }, { 0, "Khmstn" }, { 1, "Khmsta dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} khms khr" }, { PluralRulesValues.Other, "{0} khms khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} khms" }, { PluralRulesValues.Other, "{0} khms" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Jimcihii hore" }, { 0, "Jimcahan" }, { 1, "Jimcaha danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Jimce kahor" }, { PluralRulesValues.Other, "{0} Jimcood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Jimce" }, { PluralRulesValues.Other, "{0} Jimcood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Jmchi hre" }, { 0, "Jmchn" }, { 1, "Jmcha dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Jmc khr" }, { PluralRulesValues.Other, "{0} jmc khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Jmc" }, { PluralRulesValues.Other, "{0} Jmc" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Jmchi hre" }, { 0, "Jmchn" }, { 1, "Jmcha dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Jmc khr" }, { PluralRulesValues.Other, "{0} jmc khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Jmc" }, { PluralRulesValues.Other, "{0} Jmc" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "Sabtidii hore" }, { 0, "Sabtidan" }, { 1, "Sabtida danbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sabti kahor" }, { PluralRulesValues.Other, "{0} Sabtiyood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sabti" }, { PluralRulesValues.Other, "{0} Sabtiyood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "Sbtdi hre" }, { 0, "Sbtdn" }, { 1, "Sbtda dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sbti khr" }, { PluralRulesValues.Other, "{0} Sbti khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sbti" }, { PluralRulesValues.Other, "{0} Sbti" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "Sbtdi hre" }, { 0, "Sbtdn" }, { 1, "Sbtda dbe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sbti khr" }, { PluralRulesValues.Other, "{0} Sbti khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sbti" }, { PluralRulesValues.Other, "{0} Sbti" } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "Saacad",
                new Dictionary<int, string> { { 0, "Saacadan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} saacad kahor" }, { PluralRulesValues.Other, "{0} saacadood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} saacad" }, { PluralRulesValues.Other, "{0} saacadood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "scd",
                new Dictionary<int, string> { { 0, "Saacadan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} scd khr" }, { PluralRulesValues.Other, "{0} scd khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} scd" }, { PluralRulesValues.Other, "{0} scd" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "scd",
                new Dictionary<int, string> { { 0, "Saacadan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} scd khr" }, { PluralRulesValues.Other, "{0} scd khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} scd" }, { PluralRulesValues.Other, "{0} scd" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "daqiiqad",
                new Dictionary<int, string> { { 0, "Daqiiqadan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} daqiiqad kahor" }, { PluralRulesValues.Other, "{0} daqiiqadood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} daqiiqad" }, { PluralRulesValues.Other, "{0} daqiidadood" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "dqqd",
                new Dictionary<int, string> { { 0, "Daqiiqadan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dqqd khr" }, { PluralRulesValues.Other, "{0} daqiiqadood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dqqd" }, { PluralRulesValues.Other, "{0} dqqd" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "dqqd",
                new Dictionary<int, string> { { 0, "Daqiiqadan" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dqqd khr" }, { PluralRulesValues.Other, "{0} daqiiqadood kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dqqd" }, { PluralRulesValues.Other, "{0} dqqd" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Somali (Ethiopia)' [so-et]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "ilbiriqsi",
                new Dictionary<int, string> { { 0, "Imika" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ilbiriqsi kahor" }, { PluralRulesValues.Other, "{0} ilbiriqsi kahor" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ilbiriqsi" }, { PluralRulesValues.Other, "{0} ilbiriqsi" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "ilbrqsi",
                new Dictionary<int, string> { { 0, "Iminka" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ilbrqsi khr" }, { PluralRulesValues.Other, "{0} ilbrqsi khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ilbrqsi" }, { PluralRulesValues.Other, "{0} ilbrqsi" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "ilbrqsi",
                new Dictionary<int, string> { { 0, "Iminka" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ilbrqsi khr" }, { PluralRulesValues.Other, "{0} ilbrqsi khr" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ilbrqsi" }, { PluralRulesValues.Other, "{0} ilbrqsi" } }));

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