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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Armenian' [hy]
    /// </summary>
    public class ArmenianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "hy";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "տարի",
                new Dictionary<int, string> { { -1, "նախորդ տարի" }, { 0, "այս տարի" }, { 1, "հաջորդ տարի" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} տարի առաջ" }, { PluralRulesValues.Other, "{0} տարի առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} տարուց" }, { PluralRulesValues.Other, "{0} տարուց" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "տ",
                new Dictionary<int, string> { { -1, "նախորդ տարի" }, { 0, "այս տարի" }, { 1, "հաջորդ տարի" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} տ առաջ" }, { PluralRulesValues.Other, "{0} տ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} տարուց" }, { PluralRulesValues.Other, "{0} տարուց" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "տ",
                new Dictionary<int, string> { { -1, "նախորդ տարի" }, { 0, "այս տարի" }, { 1, "հաջորդ տարի" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} տ առաջ" }, { PluralRulesValues.Other, "{0} տ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} տարուց" }, { PluralRulesValues.Other, "{0} տարուց" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "եռամսյակ",
                new Dictionary<int, string> { { -1, "նախորդ եռամսյակ" }, { 0, "այս եռամսյակ" }, { 1, "հաջորդ եռամսյակ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} եռամսյակ առաջ" }, { PluralRulesValues.Other, "{0} եռամսյակ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} եռամսյակից" }, { PluralRulesValues.Other, "{0} եռամսյակից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "եռմս",
                new Dictionary<int, string> { { -1, "նախորդ եռամսյակ" }, { 0, "այս եռամսյակ" }, { 1, "հաջորդ եռամսյակ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} եռմս առաջ" }, { PluralRulesValues.Other, "{0} եռմս առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} եռմս-ից" }, { PluralRulesValues.Other, "{0} եռմս-ից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "եռմս",
                new Dictionary<int, string> { { -1, "նախորդ եռամսյակ" }, { 0, "այս եռամսյակ" }, { 1, "հաջորդ եռամսյակ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} եռմս առաջ" }, { PluralRulesValues.Other, "{0} եռմս առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} եռմս-ից" }, { PluralRulesValues.Other, "{0} եռմս-ից" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "ամիս",
                new Dictionary<int, string> { { -1, "նախորդ ամիս" }, { 0, "այս ամիս" }, { 1, "հաջորդ ամիս" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ամիս առաջ" }, { PluralRulesValues.Other, "{0} ամիս առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ամսից" }, { PluralRulesValues.Other, "{0} ամսից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "ամս",
                new Dictionary<int, string> { { -1, "նախորդ ամիս" }, { 0, "այս ամիս" }, { 1, "հաջորդ ամիս" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ամիս առաջ" }, { PluralRulesValues.Other, "{0} ամիս առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ամսից" }, { PluralRulesValues.Other, "{0} ամսից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "ամս",
                new Dictionary<int, string> { { -1, "նախորդ ամիս" }, { 0, "այս ամիս" }, { 1, "հաջորդ ամիս" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ամիս առաջ" }, { PluralRulesValues.Other, "{0} ամիս առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ամսից" }, { PluralRulesValues.Other, "{0} ամսից" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "շաբաթ",
                new Dictionary<int, string> { { -1, "նախորդ շաբաթ" }, { 0, "այս շաբաթ" }, { 1, "հաջորդ շաբաթ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շաբաթ առաջ" }, { PluralRulesValues.Other, "{0} շաբաթ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շաբաթից" }, { PluralRulesValues.Other, "{0} շաբաթից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "շաբ",
                new Dictionary<int, string> { { -1, "նախորդ շաբաթ" }, { 0, "այս շաբաթ" }, { 1, "հաջորդ շաբաթ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շաբ առաջ" }, { PluralRulesValues.Other, "{0} շաբ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շաբ անց" }, { PluralRulesValues.Other, "{0} շաբ անց" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "շաբ",
                new Dictionary<int, string> { { -1, "նախորդ շաբաթ" }, { 0, "այս շաբաթ" }, { 1, "հաջորդ շաբաթ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շաբ առաջ" }, { PluralRulesValues.Other, "{0} շաբ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շաբ-ից" }, { PluralRulesValues.Other, "{0} շաբ-ից" } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "օր",
                new Dictionary<int, string> { { -2, "նախանցյալ օրը" }, { -1, "երեկ" }, { 0, "այսօր" }, { 1, "վաղը" }, { 2, "վաղը չէ մյուս օրը" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} օր առաջ" }, { PluralRulesValues.Other, "{0} օր առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} օրից" }, { PluralRulesValues.Other, "{0} օրից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "օր",
                new Dictionary<int, string> { { -2, "երեկ չէ առաջի օրը" }, { -1, "երեկ" }, { 0, "այսօր" }, { 1, "վաղը" }, { 2, "վաղը չէ մյուս օրը" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} օր առաջ" }, { PluralRulesValues.Other, "{0} օր առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} օրից" }, { PluralRulesValues.Other, "{0} օրից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "օր",
                new Dictionary<int, string> { { -2, "երեկ չէ առաջի օրը" }, { -1, "երեկ" }, { 0, "այսօր" }, { 1, "վաղը" }, { 2, "վաղը չէ մյուս օրը" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} օր առաջ" }, { PluralRulesValues.Other, "{0} օր առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} օրից" }, { PluralRulesValues.Other, "{0} օրից" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "նախորդ կիրակի" }, { 0, "այս կիրակի" }, { 1, "հաջորդ կիրակի" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} կիրակի առաջ" }, { PluralRulesValues.Other, "{0} կիրակի առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} կիրակի հետո" }, { PluralRulesValues.Other, "{0} կիրակի հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "նխրդ կիր" }, { 0, "այս կիր" }, { 1, "հջրդ կիր" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} կիր առաջ" }, { PluralRulesValues.Other, "{0} կիր առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} կիր հետո" }, { PluralRulesValues.Other, "{0} կիր հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "նխրդ կիր" }, { 0, "այս կիր" }, { 1, "հջրդ կիր" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} կիր առաջ" }, { PluralRulesValues.Other, "{0} կիր առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} կիր հետո" }, { PluralRulesValues.Other, "{0} կիր հետո" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "նախորդ երկուշաբթի" }, { 0, "այս երկուշաբթի" }, { 1, "հաջորդ երկուշաբթի" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երկուշաբթի առաջ" }, { PluralRulesValues.Other, "{0} երկուշաբթի առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երկուշաբթի հետո" }, { PluralRulesValues.Other, "{0} երկուշաբթի հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "նխրդ երկ" }, { 0, "այս երկ" }, { 1, "հջրդ երկ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երկ առաջ" }, { PluralRulesValues.Other, "{0} երկ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երկ հետո" }, { PluralRulesValues.Other, "{0} երկ հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "նխրդ երկ" }, { 0, "այս երկ" }, { 1, "հջրդ երկ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երկ առաջ" }, { PluralRulesValues.Other, "{0} երկ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երկ հետո" }, { PluralRulesValues.Other, "{0} երկ հետո" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "նախորդ երեքշաբթի" }, { 0, "այս երեքշաբթի" }, { 1, "հաջորդ երեքշաբթի" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երեքշաբթի առաջ" }, { PluralRulesValues.Other, "{0} երեքշաբթի առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երեքշաբթի հետո" }, { PluralRulesValues.Other, "{0} երեքշաբթի հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "նխրդ երք" }, { 0, "այս երք" }, { 1, "հջրդ երք" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երք առաջ" }, { PluralRulesValues.Other, "{0} երք առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երք հետո" }, { PluralRulesValues.Other, "{0} երք հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "նխրդ երք" }, { 0, "այս երք" }, { 1, "հջրդ երք" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երք առաջ" }, { PluralRulesValues.Other, "{0} երք առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} երք հետո" }, { PluralRulesValues.Other, "{0} երք հետո" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "նախորդ չորեքշաբթի" }, { 0, "այս չորեքշաբթի" }, { 1, "հաջորդ չորեքշաբթի" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} չորեքշաբթի առաջ" }, { PluralRulesValues.Other, "{0} չորեքշաբթի առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} չորեքշաբթի հետո" }, { PluralRulesValues.Other, "{0} չորեքշաբթի հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "նխրդ չրք" }, { 0, "այս չրք" }, { 1, "հջրդ չրք" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} չրք առաջ" }, { PluralRulesValues.Other, "{0} չրք առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} չրք հետո" }, { PluralRulesValues.Other, "{0} չրք հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "նխրդ չրք" }, { 0, "այս չրք" }, { 1, "հջրդ չրք" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} չրք առաջ" }, { PluralRulesValues.Other, "{0} չրք առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} չրք հետո" }, { PluralRulesValues.Other, "{0} չրք հետո" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "նախորդ հինգշաբթի" }, { 0, "այս հինգշաբթի" }, { 1, "հաջորդ հինգշաբթի" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} հինգշաբթի առաջ" }, { PluralRulesValues.Other, "{0} հինգշաբթի առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} հինգշաբթի հետո" }, { PluralRulesValues.Other, "{0} հինգշաբթի հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "նխրդ հնգ" }, { 0, "այս հնգ" }, { 1, "հջրդ հնգ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} հնգ առաջ" }, { PluralRulesValues.Other, "{0} հնգ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} հնգ հետո" }, { PluralRulesValues.Other, "{0} հնգ հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "նխրդ հնգ" }, { 0, "այս հնգ" }, { 1, "հջրդ հնգ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} հնգ առաջ" }, { PluralRulesValues.Other, "{0} հնգ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} հնգ հետո" }, { PluralRulesValues.Other, "{0} հնգ հետո" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "նախորդ ուրբաթ" }, { 0, "այս ուրբաթ" }, { 1, "հաջորդ ուրբաթ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ուրբաթ առաջ" }, { PluralRulesValues.Other, "{0} ուրբաթ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ուրբաթ հետո" }, { PluralRulesValues.Other, "{0} ուրբաթ հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "նխրդ ուրբ" }, { 0, "այս ուրբ" }, { 1, "հջրդ ուրբ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ուրբ առաջ" }, { PluralRulesValues.Other, "{0} ուրբ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ուրբ հետո" }, { PluralRulesValues.Other, "{0} ուրբ հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "նխրդ ուրբ" }, { 0, "այս ուրբ" }, { 1, "հջրդ ուրբ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ուրբ առաջ" }, { PluralRulesValues.Other, "{0} ուրբ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ուրբ հետո" }, { PluralRulesValues.Other, "{0} ուրբ հետո" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "նախորդ շաբաթ օրը" }, { 0, "այս շաբաթ օրը" }, { 1, "հաջորդ շաբաթ օրը" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շաբաթ օր առաջ" }, { PluralRulesValues.Other, "{0} շաբաթ օր առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շաբաթ օր հետո" }, { PluralRulesValues.Other, "{0} շաբաթ օր հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "նխրդ շբթ" }, { 0, "այս շբթ" }, { 1, "հջրդ շբթ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շբթ առաջ" }, { PluralRulesValues.Other, "{0} շբթ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շբթ հետո" }, { PluralRulesValues.Other, "{0} շբթ հետո" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "նխրդ շբթ" }, { 0, "այս շբթ" }, { 1, "հջրդ շբթ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շբթ առաջ" }, { PluralRulesValues.Other, "{0} շբթ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} շբթ հետո" }, { PluralRulesValues.Other, "{0} շբթ հետո" } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "ժամ",
                new Dictionary<int, string> { { 0, "այս ժամին" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ժամ առաջ" }, { PluralRulesValues.Other, "{0} ժամ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ժամից" }, { PluralRulesValues.Other, "{0} ժամից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "ժ",
                new Dictionary<int, string> { { 0, "այս ժամին" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ժ առաջ" }, { PluralRulesValues.Other, "{0} ժ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ժ-ից" }, { PluralRulesValues.Other, "{0} ժ-ից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "ժ",
                new Dictionary<int, string> { { 0, "այս ժամին" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ժ առաջ" }, { PluralRulesValues.Other, "{0} ժ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ժ-ից" }, { PluralRulesValues.Other, "{0} ժ-ից" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "րոպե",
                new Dictionary<int, string> { { 0, "այս րոպեին" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} րոպե առաջ" }, { PluralRulesValues.Other, "{0} րոպե առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} րոպեից" }, { PluralRulesValues.Other, "{0} րոպեից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "ր",
                new Dictionary<int, string> { { 0, "այս րոպեին" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ր առաջ" }, { PluralRulesValues.Other, "{0} ր առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ր-ից" }, { PluralRulesValues.Other, "{0} ր-ից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "ր",
                new Dictionary<int, string> { { 0, "այս րոպեին" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ր առաջ" }, { PluralRulesValues.Other, "{0} ր առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ր-ից" }, { PluralRulesValues.Other, "{0} ր-ից" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Armenian' [hy]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "վայրկյան",
                new Dictionary<int, string> { { 0, "հիմա" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} վայրկյան առաջ" }, { PluralRulesValues.Other, "{0} վայրկյան առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} վայրկյանից" }, { PluralRulesValues.Other, "{0} վայրկյանից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "վ",
                new Dictionary<int, string> { { 0, "հիմա" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} վ առաջ" }, { PluralRulesValues.Other, "{0} վ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} վ-ից" }, { PluralRulesValues.Other, "{0} վ-ից" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "վ",
                new Dictionary<int, string> { { 0, "հիմա" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} վրկ առաջ" }, { PluralRulesValues.Other, "{0} վրկ առաջ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} վրկ-ից" }, { PluralRulesValues.Other, "{0} վրկ-ից" } }));

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