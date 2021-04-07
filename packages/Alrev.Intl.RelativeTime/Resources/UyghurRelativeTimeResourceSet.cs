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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Uyghur' [ug]
    /// </summary>
    public class UyghurRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ug";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Era,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Long,
                "مىلادىيە",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Narrow,
                "مىلادىيە",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Short,
                "مىلادىيە",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "يىل",
                new Dictionary<int, string> { { -1, "ئۆتكەن يىل" }, { 0, "بۇ يىل" }, { 1, "كېلەر يىل" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} يىل ئىلگىرى" }, { PluralRulesValues.Other, "{0} يىل ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} يىلدىن كېيىن" }, { PluralRulesValues.Other, "{0} يىلدىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "يىل",
                new Dictionary<int, string> { { -1, "ئۆتكەن يىل" }, { 0, "بۇ يىل" }, { 1, "كېلەر يىل" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} يىل ئىلگىرى" }, { PluralRulesValues.Other, "{0} يىل ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} يىلدىن كېيىن" }, { PluralRulesValues.Other, "{0} يىلدىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "يىل",
                new Dictionary<int, string> { { -1, "ئۆتكەن يىل" }, { 0, "بۇ يىل" }, { 1, "كېلەر يىل" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} يىل ئىلگىرى" }, { PluralRulesValues.Other, "{0} يىل ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} يىلدىن كېيىن" }, { PluralRulesValues.Other, "{0} يىلدىن كېيىن" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "Quarter",
                new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "ئاي",
                new Dictionary<int, string> { { -1, "ئۆتكەن ئاي" }, { 0, "بۇ ئاي" }, { 1, "كېلەر ئاي" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ئاي ئىلگىرى" }, { PluralRulesValues.Other, "{0} ئاي ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ئايدىن كېيىن" }, { PluralRulesValues.Other, "{0} ئايدىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "ئاي",
                new Dictionary<int, string> { { -1, "ئۆتكەن ئاي" }, { 0, "بۇ ئاي" }, { 1, "كېلەر ئاي" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ئاي ئىلگىرى" }, { PluralRulesValues.Other, "{0} ئاي ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ئايدىن كېيىن" }, { PluralRulesValues.Other, "{0} ئايدىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "ئاي",
                new Dictionary<int, string> { { -1, "ئۆتكەن ئاي" }, { 0, "بۇ ئاي" }, { 1, "كېلەر ئاي" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ئاي ئىلگىرى" }, { PluralRulesValues.Other, "{0} ئاي ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ئايدىن كېيىن" }, { PluralRulesValues.Other, "{0} ئايدىن كېيىن" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "ھەپتە",
                new Dictionary<int, string> { { -1, "ئۆتكەن ھەپتە" }, { 0, "بۇ ھەپتە" }, { 1, "كېلەر ھەپتە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ھەپتە ئىلگىرى" }, { PluralRulesValues.Other, "{0} ھەپتە ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ھەپتىدىن كېيىن" }, { PluralRulesValues.Other, "{0} ھەپتىدىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "ھەپتە",
                new Dictionary<int, string> { { -1, "ئۆتكەن ھەپتە" }, { 0, "بۇ ھەپتە" }, { 1, "كېلەر ھەپتە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ھەپتە ئىلگىرى" }, { PluralRulesValues.Other, "{0} ھەپتە ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ھەپتىدىن كېيىن" }, { PluralRulesValues.Other, "{0} ھەپتىدىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "ھەپتە",
                new Dictionary<int, string> { { -1, "ئۆتكەن ھەپتە" }, { 0, "بۇ ھەپتە" }, { 1, "كېلەر ھەپتە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ھەپتە ئىلگىرى" }, { PluralRulesValues.Other, "{0} ھەپتە ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ھەپتىدىن كېيىن" }, { PluralRulesValues.Other, "{0} ھەپتىدىن كېيىن" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Long,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Narrow,
                "Week Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Short,
                "Week Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "كۈن",
                new Dictionary<int, string> { { -1, "تۈنۈگۈن" }, { 0, "بۈگۈن" }, { 1, "ئەتە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} كۈن ئىلگىرى" }, { PluralRulesValues.Other, "{0} كۈن ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} كۈندىن كېيىن" }, { PluralRulesValues.Other, "{0} كۈندىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "كۈن",
                new Dictionary<int, string> { { -1, "تۈنۈگۈن" }, { 0, "بۈگۈن" }, { 1, "ئەتە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} كۈن ئىلگىرى" }, { PluralRulesValues.Other, "{0} كۈن ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} كۈندىن كېيىن" }, { PluralRulesValues.Other, "{0} كۈندىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "كۈن",
                new Dictionary<int, string> { { -1, "تۈنۈگۈن" }, { 0, "بۈگۈن" }, { 1, "ئەتە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} كۈن ئىلگىرى" }, { PluralRulesValues.Other, "{0} كۈن ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} كۈندىن كېيىن" }, { PluralRulesValues.Other, "{0} كۈندىن كېيىن" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayOfYear,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Long,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Narrow,
                "Day Of Year",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Short,
                "Day Of Year",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Weekday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Long,
                "ھەپتە كۈنلىرى",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Narrow,
                "ھەپتە كۈنلىرى",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Short,
                "ھەپتە كۈنلىرى",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekdayOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Long,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Narrow,
                "Weekday Of Month",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Short,
                "Weekday Of Month",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن يەكشەنبە" }, { 0, "بۇ يەكشەنبە" }, { 1, "كېلەر يەكشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن يەكشەنبە" }, { 0, "بۇ يەكشەنبە" }, { 1, "كېلەر يەكشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن يەكشەنبە" }, { 0, "بۇ يەكشەنبە" }, { 1, "كېلەر يەكشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن دۈشەنبە" }, { 0, "بۇ دۈشەنبە" }, { 1, "كېلەر دۈشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن دۈشەنبە" }, { 0, "بۇ دۈشەنبە" }, { 1, "كېلەر دۈشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن دۈشەنبە" }, { 0, "بۇ دۈشەنبە" }, { 1, "كېلەر دۈشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن سەيشەنبە" }, { 0, "بۇ سەيشەنبە" }, { 1, "كېلەر سەيشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن سەيشەنبە" }, { 0, "بۇ سەيشەنبە" }, { 1, "كېلەر سەيشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن سەيشەنبە" }, { 0, "بۇ سەيشەنبە" }, { 1, "كېلەر سەيشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن چارشەنبە" }, { 0, "بۇ چارشەنبە" }, { 1, "كېلەر چارشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن چارشەنبە" }, { 0, "بۇ چارشەنبە" }, { 1, "كېلەر چارشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن چارشەنبە" }, { 0, "بۇ چارشەنبە" }, { 1, "كېلەر چارشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن پەيشەنبە" }, { 0, "بۇ پەيشەنبە" }, { 1, "كېلەر پەيشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن پەيشەنبە" }, { 0, "بۇ پەيشەنبە" }, { 1, "كېلەر پەيشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن پەيشەنبە" }, { 0, "بۇ پەيشەنبە" }, { 1, "كېلەر پەيشەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن جۈمە" }, { 0, "بۇ جۈمە" }, { 1, "كېلەر جۈمە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن جۈمە" }, { 0, "بۇ جۈمە" }, { 1, "كېلەر جۈمە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن جۈمە" }, { 0, "بۇ جۈمە" }, { 1, "كېلەر جۈمە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن شەنبە" }, { 0, "بۇ شەنبە" }, { 1, "كېلەر شەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن شەنبە" }, { 0, "بۇ شەنبە" }, { 1, "كېلەر شەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ئۆتكەن شەنبە" }, { 0, "بۇ شەنبە" }, { 1, "كېلەر شەنبە" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayPeriod,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Long,
                "چۈشتىن بۇرۇن/چۈشتىن كېيىن",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Narrow,
                "چۈشتىن بۇرۇن/چۈشتىن كېيىن",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Short,
                "چۈشتىن بۇرۇن/چۈشتىن كېيىن",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "سائەت",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سائەت ئىلگىرى" }, { PluralRulesValues.Other, "{0} سائەت ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سائەتتىن كېيىن" }, { PluralRulesValues.Other, "{0} سائەتتىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "سائەت",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سائەت ئىلگىرى" }, { PluralRulesValues.Other, "{0} سائەت ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سائەتتىن كېيىن" }, { PluralRulesValues.Other, "{0} سائەتتىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "سائەت",
                new Dictionary<int, string> { { 0, "this hour" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سائەت ئىلگىرى" }, { PluralRulesValues.Other, "{0} سائەت ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سائەتتىن كېيىن" }, { PluralRulesValues.Other, "{0} سائەتتىن كېيىن" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "مىنۇت",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مىنۇت ئىلگىرى" }, { PluralRulesValues.Other, "{0} مىنۇت ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مىنۇتتىن كېيىن" }, { PluralRulesValues.Other, "{0} مىنۇتتىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "مىنۇت",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مىنۇت ئىلگىرى" }, { PluralRulesValues.Other, "{0} مىنۇت ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مىنۇتتىن كېيىن" }, { PluralRulesValues.Other, "{0} مىنۇتتىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "مىنۇت",
                new Dictionary<int, string> { { 0, "this minute" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مىنۇت ئىلگىرى" }, { PluralRulesValues.Other, "{0} مىنۇت ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مىنۇتتىن كېيىن" }, { PluralRulesValues.Other, "{0} مىنۇتتىن كېيىن" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "سېكۇنت",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سېكۇنت ئىلگىرى" }, { PluralRulesValues.Other, "{0} سېكۇنت ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سېكۇنتتىن كېيىن" }, { PluralRulesValues.Other, "{0} سېكۇنتتىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "سېكۇنت",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سېكۇنت ئىلگىرى" }, { PluralRulesValues.Other, "{0} سېكۇنت ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سېكۇنتتىن كېيىن" }, { PluralRulesValues.Other, "{0} سېكۇنتتىن كېيىن" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "سېكۇنت",
                new Dictionary<int, string> { { 0, "now" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سېكۇنت ئىلگىرى" }, { PluralRulesValues.Other, "{0} سېكۇنت ئىلگىرى" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سېكۇنتتىن كېيىن" }, { PluralRulesValues.Other, "{0} سېكۇنتتىن كېيىن" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Uyghur' [ug]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Zone,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Long,
                "ۋاقىت رايونى",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Narrow,
                "ۋاقىت رايونى",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Short,
                "ۋاقىت رايونى",
                null,
                null,
                null));

        /// <summary>
        /// Gets the Relative Time resource styles based on the unit specified
        /// </summary>
        /// <param name="relativeTimeUnit">The resource unit to get</param>
        /// <returns>An <see cref="IRelativeTimeStylesResource"/></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IRelativeTimeStylesResource GetRelativeTimeStylesResource(RelativeTimeUnitValues relativeTimeUnit) => relativeTimeUnit switch
        {
            RelativeTimeUnitValues.Era => this.Era,
            RelativeTimeUnitValues.Year => this.Year,
            RelativeTimeUnitValues.Quarter => this.Quarter,
            RelativeTimeUnitValues.Month => this.Month,
            RelativeTimeUnitValues.Week => this.Week,
            RelativeTimeUnitValues.WeekOfMonth => this.WeekOfMonth,
            RelativeTimeUnitValues.Day => this.Day,
            RelativeTimeUnitValues.DayOfYear => this.DayOfYear,
            RelativeTimeUnitValues.Weekday => this.Weekday,
            RelativeTimeUnitValues.WeekdayOfMonth => this.WeekdayOfMonth,
            RelativeTimeUnitValues.Sunday => this.Sunday,
            RelativeTimeUnitValues.Monday => this.Monday,
            RelativeTimeUnitValues.Tuesday => this.Tuesday,
            RelativeTimeUnitValues.Wednesday => this.Wednesday,
            RelativeTimeUnitValues.Thursday => this.Thursday,
            RelativeTimeUnitValues.Friday => this.Friday,
            RelativeTimeUnitValues.Saturday => this.Saturday,
            RelativeTimeUnitValues.DayPeriod => this.DayPeriod,
            RelativeTimeUnitValues.Hour => this.Hour,
            RelativeTimeUnitValues.Minute => this.Minute,
            RelativeTimeUnitValues.Second => this.Second,
            RelativeTimeUnitValues.Zone => this.Zone,
            _ => throw new NotImplementedException($"Relative time unit '{relativeTimeUnit}' is not supported")
        };
    }
}