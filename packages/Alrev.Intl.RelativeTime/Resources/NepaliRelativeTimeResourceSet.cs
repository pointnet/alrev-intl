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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Nepali' [ne]
    /// </summary>
    public class NepaliRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ne";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "वर्ष",
                new Dictionary<int, string> { { -1, "गत वर्ष" }, { 0, "यो वर्ष" }, { 1, "आगामी वर्ष" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्ष अघि" }, { PluralRulesValues.Other, "{0} वर्ष अघि" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षमा" }, { PluralRulesValues.Other, "{0} वर्षमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "वर्ष",
                new Dictionary<int, string> { { -1, "गत वर्ष" }, { 0, "यो वर्ष" }, { 1, "आगामी वर्ष" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्ष अघि" }, { PluralRulesValues.Other, "{0} वर्ष अघि" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षमा" }, { PluralRulesValues.Other, "{0} वर्षमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "वर्ष",
                new Dictionary<int, string> { { -1, "गत वर्ष" }, { 0, "यो वर्ष" }, { 1, "आगामी वर्ष" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्ष अघि" }, { PluralRulesValues.Other, "{0} वर्ष अघि" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षमा" }, { PluralRulesValues.Other, "{0} वर्षमा" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "सत्र",
                new Dictionary<int, string> { { -1, "अघिल्लो सत्र" }, { 0, "यो सत्र" }, { 1, "अर्को सत्र" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्र अघि" }, { PluralRulesValues.Other, "{0}सत्र अघि" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} सत्रमा" }, { PluralRulesValues.Other, "{0}सत्रमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "सत्र",
                new Dictionary<int, string> { { -1, "अघिल्लो सत्र" }, { 0, "यो सत्र" }, { 1, "अर्को सत्र" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्र अघि" }, { PluralRulesValues.Other, "{0}सत्र अघि" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्रमा" }, { PluralRulesValues.Other, "{0}सत्रमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "सत्र",
                new Dictionary<int, string> { { -1, "अघिल्लो सत्र" }, { 0, "यो सत्र" }, { 1, "अर्को सत्र" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्र अघि" }, { PluralRulesValues.Other, "{0}सत्र अघि" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्रमा" }, { PluralRulesValues.Other, "{0}सत्रमा" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "महिना",
                new Dictionary<int, string> { { -1, "गत महिना" }, { 0, "यो महिना" }, { 1, "अर्को महिना" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिना पहिले" }, { PluralRulesValues.Other, "{0} महिना पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिनामा" }, { PluralRulesValues.Other, "{0} महिनामा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "महिना",
                new Dictionary<int, string> { { -1, "गत महिना" }, { 0, "यो महिना" }, { 1, "आगामी महिना" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिना पहिले" }, { PluralRulesValues.Other, "{0} महिना पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिनामा" }, { PluralRulesValues.Other, "{0} महिनामा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "महिना",
                new Dictionary<int, string> { { -1, "गत महिना" }, { 0, "यो महिना" }, { 1, "आगामी महिना" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिना पहिले" }, { PluralRulesValues.Other, "{0} महिना पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिनामा" }, { PluralRulesValues.Other, "{0} महिनामा" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "हप्ता",
                new Dictionary<int, string> { { -1, "गत हप्ता" }, { 0, "यो हप्ता" }, { 1, "आउने हप्ता" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्ता पहिले" }, { PluralRulesValues.Other, "{0} हप्ता पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्तामा" }, { PluralRulesValues.Other, "{0} हप्तामा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "हप्ता",
                new Dictionary<int, string> { { -1, "गत हप्ता" }, { 0, "यो हप्ता" }, { 1, "आगामी हप्ता" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्ता पहिले" }, { PluralRulesValues.Other, "{0} हप्ता पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्तामा" }, { PluralRulesValues.Other, "{0} हप्तामा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "हप्ता",
                new Dictionary<int, string> { { -1, "गत हप्ता" }, { 0, "यो हप्ता" }, { 1, "आगामी हप्ता" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्ता पहिले" }, { PluralRulesValues.Other, "{0} हप्ता पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्तामा" }, { PluralRulesValues.Other, "{0} हप्तामा" } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "बार",
                new Dictionary<int, string> { { -2, "अस्ति" }, { -1, "हिजो" }, { 0, "आज" }, { 1, "भोलि" }, { 2, "पर्सि" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिन पहिले" }, { PluralRulesValues.Other, "{0} दिन पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिनमा" }, { PluralRulesValues.Other, "{0} दिनमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "बार",
                new Dictionary<int, string> { { -2, "अस्ति" }, { -1, "हिजो" }, { 0, "आज" }, { 1, "भोलि" }, { 2, "पर्सि" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिन पहिले" }, { PluralRulesValues.Other, "{0} दिन पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिनमा" }, { PluralRulesValues.Other, "{0} दिनमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "बार",
                new Dictionary<int, string> { { -2, "अस्ति" }, { -1, "हिजो" }, { 0, "आज" }, { 1, "भोलि" }, { 2, "पर्सि" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिन पहिले" }, { PluralRulesValues.Other, "{0} दिन पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिनमा" }, { PluralRulesValues.Other, "{0} दिनमा" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "गत आइतबार" }, { 0, "यो आइतबार" }, { 1, "अर्को आइतबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}आइतबार पहिले" }, { PluralRulesValues.Other, "{0} आइतबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारमा" }, { PluralRulesValues.Other, "{0} आइतबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "गत आइतबार" }, { 0, "यो आइतबार" }, { 1, "अर्को आइतबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारहरू पहिले" }, { PluralRulesValues.Other, "{0} आइतबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारहरूमा" }, { PluralRulesValues.Other, "{0} आइतबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "गत आइतबार" }, { 0, "यो आइतबार" }, { 1, "अर्को आइतबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारहरू पहिले" }, { PluralRulesValues.Other, "{0} आइतबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारहरूमा" }, { PluralRulesValues.Other, "{0} आइतबारहरूमा" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "गत सोमबार" }, { 0, "यो सोमबार" }, { 1, "अर्को सोमबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबार पहिले" }, { PluralRulesValues.Other, "{0} सोमबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबारहरूमा" }, { PluralRulesValues.Other, "{0} सोमबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "गत सोमबार" }, { 0, "यो सोमबार" }, { 1, "अर्को सोमबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबार पहिले" }, { PluralRulesValues.Other, "{0}सोमबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबारहरूमा" }, { PluralRulesValues.Other, "{0} सोमबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "गत सोमबार" }, { 0, "यो सोमबार" }, { 1, "अर्को सोमबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबार पहिले" }, { PluralRulesValues.Other, "{0} सोमबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबारहरूमा" }, { PluralRulesValues.Other, "{0} सोमबारहरूमा" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "गत मंगलबार" }, { 0, "यो मंगलबार" }, { 1, "अर्को मंगलबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबार पहिले" }, { PluralRulesValues.Other, "{0} मंगलबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबारमा" }, { PluralRulesValues.Other, "{0} मंगलबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "गत मंगलबार" }, { 0, "यो मंगलबार" }, { 1, "अर्को मंगलबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबार पहिले" }, { PluralRulesValues.Other, "{0} मंगलबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबारमा" }, { PluralRulesValues.Other, "{0} मंगलबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "गत मंगलबार" }, { 0, "यो मंगलबार" }, { 1, "अर्को मंगलबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबार पहिले" }, { PluralRulesValues.Other, "{0} मंगलबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबारमा" }, { PluralRulesValues.Other, "{0} मंगलबारहरूमा" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "गत बुधबार" }, { 0, "यो बुधबार" }, { 1, "अर्को बुधबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबार पहिले" }, { PluralRulesValues.Other, "{0} बुधबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबारमा" }, { PluralRulesValues.Other, "{0} बुधबारमाहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "गत बुधबार" }, { 0, "यो बुधबार" }, { 1, "अर्को बुधबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबार पहिले" }, { PluralRulesValues.Other, "{0} बुधबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबारमा" }, { PluralRulesValues.Other, "{0} बुधबारमाहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "गत बुधबार" }, { 0, "यो बुधबार" }, { 1, "अर्को बुधबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबार पहिले" }, { PluralRulesValues.Other, "{0} बुधबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबारमा" }, { PluralRulesValues.Other, "{0} बुधबारमाहरूमा" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "गत बिहिबार" }, { 0, "यो बिहिबार" }, { 1, "अर्को बिहिबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबार पहिले" }, { PluralRulesValues.Other, "{0} बिहिबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबारमा" }, { PluralRulesValues.Other, "{0} बिहिबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "गत बिहिबार" }, { 0, "यो बिहिबार" }, { 1, "अर्को बिहिबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबार पहिले" }, { PluralRulesValues.Other, "{0} बिहिबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबारमा" }, { PluralRulesValues.Other, "{0} बिहिबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "गत बिहिबार" }, { 0, "यो बिहिबार" }, { 1, "अर्को बिहिबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबार पहिले" }, { PluralRulesValues.Other, "{0} बिहिबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबारमा" }, { PluralRulesValues.Other, "{0} बिहिबारहरूमा" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "गत शुक्रबार" }, { 0, "यो शुक्रबार" }, { 1, "अर्को शुक्रबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबार पहिले" }, { PluralRulesValues.Other, "{0} शुक्रबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबारमा" }, { PluralRulesValues.Other, "{0} शुक्रबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "गत शुक्रबार" }, { 0, "यो शुक्रबार" }, { 1, "अर्को शुक्रबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबार पहिले" }, { PluralRulesValues.Other, "{0} शुक्रबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबारमा" }, { PluralRulesValues.Other, "{0} शुक्रबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "गत शुक्रबार" }, { 0, "यो शुक्रबार" }, { 1, "अर्को शुक्रबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबार पहिले" }, { PluralRulesValues.Other, "{0} शुक्रबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबारमा" }, { PluralRulesValues.Other, "{0} शुक्रबारहरूमा" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "गत शनिबार" }, { 0, "यो शनिबार" }, { 1, "अर्को शनिबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबार पहिले" }, { PluralRulesValues.Other, "{0} शनिबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबारमा" }, { PluralRulesValues.Other, "{0} शनिबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "गत शनिबार" }, { 0, "यो शनिबार" }, { 1, "अर्को शनिबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबार पहिले" }, { PluralRulesValues.Other, "{0} शनिबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबारमा" }, { PluralRulesValues.Other, "{0} शनिबारहरूमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "गत शनिबार" }, { 0, "यो शनिबार" }, { 1, "अर्को शनिबार" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबार पहिले" }, { PluralRulesValues.Other, "{0} शनिबारहरू पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबारमा" }, { PluralRulesValues.Other, "{0} शनिबारहरूमा" } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "घण्टा",
                new Dictionary<int, string> { { 0, "यस घडीमा" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टा पहिले" }, { PluralRulesValues.Other, "{0} घण्टा पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टामा" }, { PluralRulesValues.Other, "{0} घण्टामा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "घण्टा",
                new Dictionary<int, string> { { 0, "यस घडीमा" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टा पहिले" }, { PluralRulesValues.Other, "{0} घण्टा पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टामा" }, { PluralRulesValues.Other, "{0} घण्टामा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "घण्टा",
                new Dictionary<int, string> { { 0, "यस घडीमा" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टा पहिले" }, { PluralRulesValues.Other, "{0} घण्टा पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टामा" }, { PluralRulesValues.Other, "{0} घण्टामा" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "मिनेट",
                new Dictionary<int, string> { { 0, "यही मिनेटमा" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेट पहिले" }, { PluralRulesValues.Other, "{0} मिनेट पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेटमा" }, { PluralRulesValues.Other, "{0} मिनेटमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "मिनेट",
                new Dictionary<int, string> { { 0, "यही मिनेटमा" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेट पहिले" }, { PluralRulesValues.Other, "{0} मिनेट पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेटमा" }, { PluralRulesValues.Other, "{0} मिनेटमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "मिनेट",
                new Dictionary<int, string> { { 0, "यही मिनेटमा" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेट पहिले" }, { PluralRulesValues.Other, "{0} मिनेट पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेटमा" }, { PluralRulesValues.Other, "{0} मिनेटमा" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Nepali' [ne]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "सेकेन्ड",
                new Dictionary<int, string> { { 0, "अहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्ड पहिले" }, { PluralRulesValues.Other, "{0} सेकेन्ड पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्डमा" }, { PluralRulesValues.Other, "{0} सेकेन्डमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "सेकेन्ड",
                new Dictionary<int, string> { { 0, "अहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्ड पहिले" }, { PluralRulesValues.Other, "{0} सेकेन्ड पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्डमा" }, { PluralRulesValues.Other, "{0} सेकेन्डमा" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "सेकेन्ड",
                new Dictionary<int, string> { { 0, "अहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्ड पहिले" }, { PluralRulesValues.Other, "{0} सेकेन्ड पहिले" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्डमा" }, { PluralRulesValues.Other, "{0} सेकेन्डमा" } }));

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