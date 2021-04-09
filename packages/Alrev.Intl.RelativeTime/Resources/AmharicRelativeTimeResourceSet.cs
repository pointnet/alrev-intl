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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Amharic' [am]
    /// </summary>
    public class AmharicRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "am";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "ዓመት",
                new Dictionary<int, string> { { -1, "ያለፈው ዓመት" }, { 0, "በዚህ ዓመት" }, { 1, "የሚቀጥለው ዓመት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ዓመት በፊት" }, { PluralRulesValues.Other, "ከ{0} ዓመታት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ዓመታት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ዓመታት ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "ዓመት",
                new Dictionary<int, string> { { -1, "ያለፈው ዓመት" }, { 0, "በዚህ ዓመት" }, { 1, "የሚቀጥለው ዓመት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ዓመታት በፊት" }, { PluralRulesValues.Other, "ከ{0} ዓመታት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ዓመታት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ዓመታት ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "ዓመት",
                new Dictionary<int, string> { { -1, "ያለፈው ዓመት" }, { 0, "በዚህ ዓመት" }, { 1, "የሚቀጥለው ዓመት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ዓመታት በፊት" }, { PluralRulesValues.Other, "ከ{0} ዓመታት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ዓመታት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ዓመታት ውስጥ" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "ሩብ",
                new Dictionary<int, string> { { -1, "የመጨረሻው ሩብ" }, { 0, "ይህ ሩብ" }, { 1, "የሚቀጥለው ሩብ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ሩብ በፊት" }, { PluralRulesValues.Other, "{0} ሩብ በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} ሩብ" }, { PluralRulesValues.Other, "+{0} ሩብ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "ሩብ",
                new Dictionary<int, string> { { -1, "የመጨረሻው ሩብ" }, { 0, "ይህ ሩብ" }, { 1, "የሚቀጥለው ሩብ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ሩብ በፊት" }, { PluralRulesValues.Other, "{0} ሩብ በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} ሩብ" }, { PluralRulesValues.Other, "+{0} ሩብ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "ሩብ",
                new Dictionary<int, string> { { -1, "የመጨረሻው ሩብ" }, { 0, "ይህ ሩብ" }, { 1, "የሚቀጥለው ሩብ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ሩብ በፊት" }, { PluralRulesValues.Other, "{0} ሩብ በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} ሩብ" }, { PluralRulesValues.Other, "+{0} ሩብ" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "ወር",
                new Dictionary<int, string> { { -1, "ያለፈው ወር" }, { 0, "በዚህ ወር" }, { 1, "የሚቀጥለው ወር" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ወር በፊት" }, { PluralRulesValues.Other, "ከ{0} ወራት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ወር ውስጥ" }, { PluralRulesValues.Other, "በ{0} ወራት ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "ወር",
                new Dictionary<int, string> { { -1, "ያለፈው ወር" }, { 0, "በዚህ ወር" }, { 1, "የሚቀጥለው ወር" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ወራት በፊት" }, { PluralRulesValues.Other, "ከ{0} ወራት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ወራት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ወራት ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "ወር",
                new Dictionary<int, string> { { -1, "ያለፈው ወር" }, { 0, "በዚህ ወር" }, { 1, "የሚቀጥለው ወር" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ወራት በፊት" }, { PluralRulesValues.Other, "ከ{0} ወራት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ወራት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ወራት ውስጥ" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "ሳምንት",
                new Dictionary<int, string> { { -1, "ያለፈው ሳምንት" }, { 0, "በዚህ ሳምንት" }, { 1, "የሚቀጥለው ሳምንት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሳምንት በፊት" }, { PluralRulesValues.Other, "ከ{0} ሳምንታት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሳምንት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሳምንታት ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "ሳምንት",
                new Dictionary<int, string> { { -1, "ባለፈው ሳምንት" }, { 0, "በዚህ ሣምንት" }, { 1, "የሚቀጥለው ሳምንት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሳምንታት በፊት" }, { PluralRulesValues.Other, "ከ{0} ሳምንታት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሳምንታት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሳምንታት ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "ሳምንት",
                new Dictionary<int, string> { { -1, "ባለፈው ሳምንት" }, { 0, "በዚህ ሣምንት" }, { 1, "የሚቀጥለው ሳምንት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሳምንታት በፊት" }, { PluralRulesValues.Other, "ከ{0} ሳምንታት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሳምንታት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሳምንታት ውስጥ" } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "ቀን",
                new Dictionary<int, string> { { -2, "ከትናንት ወዲያ" }, { -1, "ትናንት" }, { 0, "ዛሬ" }, { 1, "ነገ" }, { 2, "ከነገ ወዲያ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ቀን በፊት" }, { PluralRulesValues.Other, "ከ{0} ቀናት በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ቀን ውስጥ" }, { PluralRulesValues.Other, "በ{0} ቀናት ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "ቀን",
                new Dictionary<int, string> { { -2, "ከትናንት ወዲያ" }, { -1, "ትላንትና" }, { 0, "ዛሬ" }, { 1, "ነገ" }, { 2, "ከነገ ወዲያ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ {0} ቀን በፊት" }, { PluralRulesValues.Other, "ከ{0} ቀኖች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ቀን ውስጥ" }, { PluralRulesValues.Other, "በ{0} ቀኖች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "ቀን",
                new Dictionary<int, string> { { -2, "ከትናንት ወዲያ" }, { -1, "ትላንትና" }, { 0, "ዛሬ" }, { 1, "ነገ" }, { 2, "ከነገ ወዲያ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ {0} ቀን በፊት" }, { PluralRulesValues.Other, "ከ{0} ቀኖች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ቀን ውስጥ" }, { PluralRulesValues.Other, "በ{0} ቀኖች ውስጥ" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው እሑድ" }, { 0, "የአሁኑ እሑድ" }, { 1, "የሚቀጥለው እሑድ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} እሑድ በፊት" }, { PluralRulesValues.Other, "ከ{0} እሑዶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} እሑድ ውስጥ" }, { PluralRulesValues.Other, "በ{0} እሑዶች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው እሑድ" }, { 0, "የአሁኑ እሑድ" }, { 1, "የሚቀጥለው እሑድ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} እሑዶች በፊት" }, { PluralRulesValues.Other, "ከ{0} እሑዶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} እሑዶች ውስጥ" }, { PluralRulesValues.Other, "በ{0} እሑዶች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው እሑድ" }, { 0, "የአሁኑ እሑድ" }, { 1, "የሚቀጥለው እሑድ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} እሑዶች በፊት" }, { PluralRulesValues.Other, "ከ{0} እሑዶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} እሑዶች ውስጥ" }, { PluralRulesValues.Other, "በ{0} እሑዶች ውስጥ" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ሰኞ" }, { 0, "የአሁኑ ሰኞ" }, { 1, "የሚቀጥለው ሰኞ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሰኞ በፊት" }, { PluralRulesValues.Other, "ከ{0} ሰኞዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሰኞ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሰኞዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ሰኞ" }, { 0, "የአሁኑ ሰኞ" }, { 1, "የሚቀጥለው ሰኞ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሰኞዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ሰኞዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሰኞዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሰኞዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ሰኞ" }, { 0, "የአሁኑ ሰኞ" }, { 1, "የሚቀጥለው ሰኞ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሰኞዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ሰኞዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሰኞዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሰኞዎች ውስጥ" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ማክሰኞ" }, { 0, "የአሁኑ ማክሰኞ" }, { 1, "የሚቀጥለው ማክሰኞ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ማክሰኞ በፊት" }, { PluralRulesValues.Other, "ከ{0} ማክሰኞዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ማክሰኞ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ማክሰኞዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ማክሰኞ" }, { 0, "የአሁኑ ማክሰኞ" }, { 1, "የሚቀጥለው ማክሰኞ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ማክሰኞዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ማክሰኞዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ማክሰኞዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ማክሰኞዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ማክሰኞ" }, { 0, "የአሁኑ ማክሰኞ" }, { 1, "የሚቀጥለው ማክሰኞ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ማክሰኞዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ማክሰኞዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ማክሰኞዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ማክሰኞዎች ውስጥ" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ረቡዕ" }, { 0, "የአሁኑ ረቡዕ" }, { 1, "የሚቀጥለው ረቡዕ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ረቡዕ በፊት" }, { PluralRulesValues.Other, "ከ{0} ረቡዕዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ረቡዕ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ረቡዕዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ረቡዕ" }, { 0, "የአሁኑ ረቡዕ" }, { 1, "የሚቀጥለው ረቡዕ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ረቡዕዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ረቡዕዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ረቡዕዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ረቡዕዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ረቡዕ" }, { 0, "የአሁኑ ረቡዕ" }, { 1, "የሚቀጥለው ረቡዕ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ረቡዕዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ረቡዕዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ረቡዕዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ረቡዕዎች ውስጥ" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ሐሙስ" }, { 0, "የአሁኑ ሐሙስ" }, { 1, "የሚቀጥለው ሐሙስ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሐሙስ በፊት" }, { PluralRulesValues.Other, "ከ{0} ሐሙሶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሐሙስ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሐሙሶች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ሐሙስ" }, { 0, "የአሁኑ ሐሙስ" }, { 1, "የሚቀጥለው ሐሙስ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሐሙሶች በፊት" }, { PluralRulesValues.Other, "ከ{0} ሐሙሶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሐሙሶች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሐሙሶች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ሐሙስ" }, { 0, "የአሁኑ ሐሙስ" }, { 1, "የሚቀጥለው ሐሙስ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሐሙሶች በፊት" }, { PluralRulesValues.Other, "ከ{0} ሐሙሶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሐሙሶች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሐሙሶች ውስጥ" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ዓርብ" }, { 0, "የአሁኑ ዓርብ" }, { 1, "የሚቀጥለው ዓርብ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ዓርብ በፊት" }, { PluralRulesValues.Other, "ከ{0} ዓርብዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ዓርብ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ዓርብዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ዓርብ" }, { 0, "የአሁኑ ዓርብ" }, { 1, "የሚቀጥለው ዓርብ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ዓርብዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ዓርብዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ዓርብዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ዓርብዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ዓርብ" }, { 0, "የአሁኑ ዓርብ" }, { 1, "የሚቀጥለው ዓርብ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ዓርብዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ዓርብዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ዓርብዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ዓርብዎች ውስጥ" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ቅዳሜ" }, { 0, "የአሁኑ ቅዳሜ" }, { 1, "የሚቀጥለው ቅዳሜ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ቅዳሜ በፊት" }, { PluralRulesValues.Other, "ከ{0} ቅዳሜዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ቅዳሜ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ቅዳሜዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ቅዳሜ" }, { 0, "የአሁኑ ቅዳሜ" }, { 1, "የሚቀጥለው ቅዳሜ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ቅዳሜዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ቅዳሜዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ቅዳሜዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ቅዳሜዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ያለፈው ቅዳሜ" }, { 0, "የአሁኑ ቅዳሜ" }, { 1, "የሚቀጥለው ቅዳሜ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ቅዳሜዎች በፊት" }, { PluralRulesValues.Other, "ከ{0} ቅዳሜዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ቅዳሜዎች ውስጥ" }, { PluralRulesValues.Other, "በ{0} ቅዳሜዎች ውስጥ" } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "ሰዓት",
                new Dictionary<int, string> { { 0, "ይህ ሰዓት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሰዓት በፊት" }, { PluralRulesValues.Other, "ከ{0} ሰዓቶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሰዓት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሰዓቶች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "ሰዓት",
                new Dictionary<int, string> { { 0, "ይህ ሰዓት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሰዓት በፊት" }, { PluralRulesValues.Other, "ከ{0} ሰዓቶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሰዓት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሰዓቶች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "ሰዓት",
                new Dictionary<int, string> { { 0, "ይህ ሰዓት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሰዓት በፊት" }, { PluralRulesValues.Other, "ከ{0} ሰዓቶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሰዓት ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሰዓቶች ውስጥ" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "ደቂቃ",
                new Dictionary<int, string> { { 0, "ይህ ደቂቃ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ደቂቃ በፊት" }, { PluralRulesValues.Other, "ከ{0} ደቂቃዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ደቂቃ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ደቂቃዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "ደቂቃ",
                new Dictionary<int, string> { { 0, "ይህ ደቂቃ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ደቂቃ በፊት" }, { PluralRulesValues.Other, "ከ{0} ደቂቃዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ደቂቃ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ደቂቃዎች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "ደቂቃ",
                new Dictionary<int, string> { { 0, "ይህ ደቂቃ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ደቂቃ በፊት" }, { PluralRulesValues.Other, "ከ{0} ደቂቃዎች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ደቂቃ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ደቂቃዎች ውስጥ" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Amharic' [am]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "ሰከንድ",
                new Dictionary<int, string> { { 0, "አሁን" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሰከንድ በፊት" }, { PluralRulesValues.Other, "ከ{0} ሰከንዶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሰከንድ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሰከንዶች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "ሰከንድ",
                new Dictionary<int, string> { { 0, "አሁን" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሰከንድ በፊት" }, { PluralRulesValues.Other, "ከ{0} ሰከንዶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሰከንድ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሰከንዶች ውስጥ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "ሰከንድ",
                new Dictionary<int, string> { { 0, "አሁን" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ከ{0} ሰከንድ በፊት" }, { PluralRulesValues.Other, "ከ{0} ሰከንዶች በፊት" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "በ{0} ሰከንድ ውስጥ" }, { PluralRulesValues.Other, "በ{0} ሰከንዶች ውስጥ" } }));

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