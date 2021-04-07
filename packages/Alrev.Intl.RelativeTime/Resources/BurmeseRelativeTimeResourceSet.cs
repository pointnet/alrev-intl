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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Burmese' [my]
    /// </summary>
    public class BurmeseRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "my";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Era,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Long,
                "ခေတ်",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Narrow,
                "ခေတ်",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Era,
                RelativeTimeStyleValues.Short,
                "ခေတ်",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "နှစ်",
                new Dictionary<int, string> { { -1, "ယမန်နှစ်" }, { 0, "ယခုနှစ်" }, { 1, "လာမည့်နှစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နှစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နှစ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "နှစ်",
                new Dictionary<int, string> { { -1, "ယမန်နှစ်" }, { 0, "ယခုနှစ်" }, { 1, "လာမည့်နှစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နှစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နှစ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "နှစ်",
                new Dictionary<int, string> { { -1, "ယမန်နှစ်" }, { 0, "ယခုနှစ်" }, { 1, "လာမည့်နှစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နှစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နှစ်အတွင်း" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "သုံးလပတ်",
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သုံးလပတ်" }, { 0, "ယခု သုံးလပတ်" }, { 1, "လာမည့် သုံးလပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သုံးလပတ်ကာလ {0} ခုအတွင်း" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သုံးလပတ်ကာလ {0} အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "သုံးလပတ်",
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သောသုံးလပတ်" }, { 0, "ယခုသုံးလပတ်" }, { 1, "နောက်လာမည့်သုံးလပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သုံးလပတ်ကာလ {0} ခုအတွင်း" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သုံးလပတ်ကာလ {0} ခုအတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "သုံးလပတ်",
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သောသုံးလပတ်" }, { 0, "ယခုသုံးလပတ်" }, { 1, "နောက်လာမည့်သုံးလပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သုံးလပတ်ကာလ {0} ခုအတွင်း" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သုံးလပတ်ကာလ {0} ခုအတွင်း" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "လ",
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့်လ" }, { 0, "ယခုလ" }, { 1, "လာမည့်လ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} လ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} လအတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "လ",
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့်လ" }, { 0, "ယခုလ" }, { 1, "လာမည့်လ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} လ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} လအတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "လ",
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့်လ" }, { 0, "ယခုလ" }, { 1, "လာမည့်လ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} လ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} လအတွင်း" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "ပတ်",
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သီတင်းပတ်" }, { 0, "ယခု သီတင်းပတ်" }, { 1, "လာမည့် သီတင်းပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "ပတ်",
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သီတင်းပတ်" }, { 0, "ယခု သီတင်းပတ်" }, { 1, "လာမည့် သီတင်းပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "ပတ်",
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သီတင်းပတ်" }, { 0, "ယခု သီတင်းပတ်" }, { 1, "လာမည့် သီတင်းပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ပတ်အတွင်း" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Long,
                "တစ်လအတွင်းရှိသီတင်းပတ်",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Narrow,
                "တစ်လအတွင်းရှိသီတင်းပတ်",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekOfMonth,
                RelativeTimeStyleValues.Short,
                "တစ်လအတွင်းရှိသီတင်းပတ်",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "ရက်",
                new Dictionary<int, string> { { -2, "တစ်နေ့က" }, { -1, "မနေ့က" }, { 0, "ယနေ့" }, { 1, "မနက်ဖြန်" }, { 2, "သန်ဘက်ခါ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ရက်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ရက်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "ရက်",
                new Dictionary<int, string> { { -2, "တစ်နေ့က" }, { -1, "မနေ့က" }, { 0, "ယနေ့" }, { 1, "မနက်ဖြန်" }, { 2, "သန်ဘက်ခါ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ရက်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ရက်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "ရက်",
                new Dictionary<int, string> { { -2, "တစ်နေ့က" }, { -1, "မနေ့က" }, { 0, "ယနေ့" }, { 1, "မနက်ဖြန်" }, { 2, "သန်ဘက်ခါ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ရက်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ရက်အတွင်း" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayOfYear,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Long,
                "တစ်နှစ်အတွင်း ရက်ရေတွက်ပုံ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Narrow,
                "တစ်နှစ်အတွင်း ရက်ရေတွက်ပုံ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayOfYear,
                RelativeTimeStyleValues.Short,
                "တစ်နှစ်အတွင်း ရက်ရေတွက်ပုံ",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Weekday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Long,
                "နေ့",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Narrow,
                "နေ့",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Weekday,
                RelativeTimeStyleValues.Short,
                "နေ့",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.WeekdayOfMonth,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Long,
                "တစ်လအတွင်းရှိအလုပ်ရက်",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Narrow,
                "တစ်လအတွင်းရှိအလုပ်ရက်",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.WeekdayOfMonth,
                RelativeTimeStyleValues.Short,
                "တစ်လအတွင်းရှိအလုပ်ရက်",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္ဂနွေနေ့" }, { 0, "ဤတနင်္ဂနွေနေ့" }, { 1, "လာမည့် တနင်္ဂနွေနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္ဂနွေ {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္ဂနွေ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္ဂနွေနေ့" }, { 0, "ဤတနင်္ဂနွေနေ့" }, { 1, "လာမည့် တနင်္ဂနွေနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္ဂနွေ {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္ဂနွေ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္ဂနွေနေ့" }, { 0, "ဤတနင်္ဂနွေနေ့" }, { 1, "လာမည့် တနင်္ဂနွေနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္ဂနွေ {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္ဂနွေ {0} ပတ်အတွင်း" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္လာနေ့" }, { 0, "ဤတနင်္လာနေ့" }, { 1, "လာမည့် တနင်္လာနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္လာ {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္လာ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္လာနေ့" }, { 0, "ဤတနင်္လာနေ့" }, { 1, "လာမည့် တနင်္လာနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္လာ {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္လာ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္လာနေ့" }, { 0, "ဤတနင်္လာနေ့" }, { 1, "လာမည့် တနင်္လာနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္လာ {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္လာ {0} ပတ်အတွင်း" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် အင်္ဂါနေ့" }, { 0, "ဤအင်္ဂါနေ့" }, { 1, "လာမည့် အင်္ဂါနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် အင်္ဂါ {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "အင်္ဂါ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် အင်္ဂါနေ့" }, { 0, "ဤအင်္ဂါနေ့" }, { 1, "လာမည့် အင်္ဂါနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် အင်္ဂါ {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "အင်္ဂါ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် အင်္ဂါနေ့" }, { 0, "ဤအင်္ဂါနေ့" }, { 1, "လာမည့် အင်္ဂါနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် အင်္ဂါ {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "အင်္ဂါ {0} ပတ်အတွင်း" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူးနေ့" }, { 0, "ဤဗုဒ္ဓဟူးနေ့" }, { 1, "လာမည့် ဗုဒ္ဓဟူးနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူး {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ဗုဒ္ဓဟူး {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူးနေ့" }, { 0, "ဤဗုဒ္ဓဟူးနေ့" }, { 1, "လာမည့် ဗုဒ္ဓဟူးနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူး {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ဗုဒ္ဓဟူး {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူးနေ့" }, { 0, "ဤဗုဒ္ဓဟူးနေ့" }, { 1, "လာမည့် ဗုဒ္ဓဟူးနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူး {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ဗုဒ္ဓဟူး {0} ပတ်အတွင်း" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ကြာသပတေးနေ့" }, { 0, "ဤကြာသပတေးနေ့" }, { 1, "လာမည့် ကြာသပတေးနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ကြာသပတေး {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ကြာသပတေး {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ကြာသပတေးနေ့" }, { 0, "ဤကြာသပတေးနေ့" }, { 1, "လာမည့် ကြာသပတေးနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ကြာသပတေး {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ကြာသပတေး {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ကြာသပတေးနေ့" }, { 0, "ဤကြာသပတေးနေ့" }, { 1, "လာမည့် ကြာသပတေးနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ကြာသပတေး {0} ပတ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ကြာသပတေး {0} ပတ်အတွင်း" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သောကြာနေ့" }, { 0, "ဤသောကြာနေ့" }, { 1, "လာမည့် သောကြာနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သောကြာ {0} ပတ်အတွင်း" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သောကြာ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သောကြာနေ့" }, { 0, "ဤသောကြာနေ့" }, { 1, "လာမည့် သောကြာနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သောကြာ {0} ပတ်အတွင်း" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သောကြာ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သောကြာနေ့" }, { 0, "ဤသောကြာနေ့" }, { 1, "လာမည့် သောကြာနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သောကြာ {0} ပတ်အတွင်း" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သောကြာ {0} ပတ်အတွင်း" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် စနေနေ့" }, { 0, "ဤစနေနေ့" }, { 1, "လာမည့် စနေနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် စနေ {0} ပတ်အတွင်း" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "စနေ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် စနေနေ့" }, { 0, "ဤစနေနေ့" }, { 1, "လာမည့် စနေနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် စနေ {0} ပတ်အတွင်း" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "စနေ {0} ပတ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် စနေနေ့" }, { 0, "ဤစနေနေ့" }, { 1, "လာမည့် စနေနေ့" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် စနေ {0} ပတ်အတွင်း" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "စနေ {0} ပတ်အတွင်း" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.DayPeriod,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Long,
                "နံနက်/ညနေ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Narrow,
                "နံနက်/ညနေ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.DayPeriod,
                RelativeTimeStyleValues.Short,
                "နံနက်/ညနေ",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "နာရီ",
                new Dictionary<int, string> { { 0, "ဤအချိန်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နာရီ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နာရီအတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "နာရီ",
                new Dictionary<int, string> { { 0, "ဤအချိန်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နာရီ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နာရီအတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "နာရီ",
                new Dictionary<int, string> { { 0, "ဤအချိန်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နာရီ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နာရီအတွင်း" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "မိနစ်",
                new Dictionary<int, string> { { 0, "ဤမိနစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} မိနစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} မိနစ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "မိနစ်",
                new Dictionary<int, string> { { 0, "ဤမိနစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} မိနစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} မိနစ်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "မိနစ်",
                new Dictionary<int, string> { { 0, "ဤမိနစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} မိနစ်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} မိနစ်အတွင်း" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "စက္ကန့်",
                new Dictionary<int, string> { { 0, "ယခု" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} စက္ကန့်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} စက္ကန့်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "စက္ကန့်",
                new Dictionary<int, string> { { 0, "ယခု" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} စက္ကန့်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} စက္ကန့်အတွင်း" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "စက္ကန့်",
                new Dictionary<int, string> { { 0, "ယခု" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} စက္ကန့်" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} စက္ကန့်အတွင်း" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Burmese' [my]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Zone,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Long,
                "ဇုန်",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Narrow,
                "ဇုန်",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Zone,
                RelativeTimeStyleValues.Short,
                "ဇုန်",
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