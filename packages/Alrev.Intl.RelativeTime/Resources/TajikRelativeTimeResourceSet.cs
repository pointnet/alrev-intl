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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Tajik' [tg]
    /// </summary>
    public class TajikRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "tg";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "мабдаи таърих",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "мабдаи таърих",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "мабдаи таърих",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "сол",
                new Dictionary<int, string> { { -1, "соли гузашта" }, { 0, "соли ҷорӣ" }, { 1, "соли оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сол пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} сол" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "с.",
                new Dictionary<int, string> { { -1, "соли г." }, { 0, "соли ҷ." }, { 1, "соли о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} с. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} с." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "с.",
                new Dictionary<int, string> { { -1, "соли г." }, { 0, "соли ҷ." }, { 1, "соли о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} с. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} с." } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "чоряк",
                new Dictionary<int, string> { { -1, "чоряки гузашта" }, { 0, "чоряки ҷорӣ" }, { 1, "чоряки оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чоряк пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} чоряк" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "чр.",
                new Dictionary<int, string> { { -1, "чоряки гузашта" }, { 0, "чоряки ҷорӣ" }, { 1, "чоряки оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чр. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} чр." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "чр.",
                new Dictionary<int, string> { { -1, "чоряки гузашта" }, { 0, "чоряки ҷорӣ" }, { 1, "чоряки оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чр. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} чр." } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "моҳ",
                new Dictionary<int, string> { { -1, "моҳи гузашта" }, { 0, "моҳи ҷорӣ" }, { 1, "моҳи оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} моҳ пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} моҳ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "м.",
                new Dictionary<int, string> { { -1, "моҳи г." }, { 0, "моҳи ҷ." }, { 1, "моҳи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} м. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} м." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "м.",
                new Dictionary<int, string> { { -1, "моҳи г." }, { 0, "моҳи ҷ." }, { 1, "моҳи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} м. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} м." } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ҳафта",
                new Dictionary<int, string> { { -1, "ҳафтаи гузашта" }, { 0, "ҳафтаи ҷорӣ" }, { 1, "ҳафтаи оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ҳафта пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} ҳафта" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ҳ.",
                new Dictionary<int, string> { { -1, "ҳафтаи г." }, { 0, "ҳафтаи ҷ." }, { 1, "ҳафтаи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ҳ. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} ҳ." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ҳ.",
                new Dictionary<int, string> { { -1, "ҳафтаи г." }, { 0, "ҳафтаи ҷ." }, { 1, "ҳафтаи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ҳ. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} ҳ." } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ҳафтаи моҳ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ҳ. м.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ҳ. м.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "рӯз",
                new Dictionary<int, string> { { -1, "дирӯз" }, { 0, "имрӯз" }, { 1, "фардо" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} рӯз пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} рӯз" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "рӯз",
                new Dictionary<int, string> { { -1, "дирӯз" }, { 0, "имрӯз" }, { 1, "фардо" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} рӯз пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} рӯз" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "рӯз",
                new Dictionary<int, string> { { -1, "дирӯз" }, { 0, "имрӯз" }, { 1, "фардо" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} рӯз пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} рӯз" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "рӯзи сол",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "рӯзи с.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "рӯзи с.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "рӯзи ҳафта",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "рӯзи ҳ.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "рӯзи ҳ.",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "рӯзи ҳафтаи моҳ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "рӯзи ҳ. м.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "рӯзи ҳ. м.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "якшанбеи гузашта" }, { 0, "якшанбеи ҷорӣ" }, { 1, "якшанбеи оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} якшанбе пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} якшанбе" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "яшб г." }, { 0, "яшб ҷ." }, { 1, "яшб о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ябш пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} яшб" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "якшанбеи г." }, { 0, "якшанбеи ҷ." }, { 1, "якшанбеи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} яшб. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} яшб" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "душанбеи гузашта" }, { 0, "душанбеи ҷорӣ" }, { 1, "душанбеи оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} душанбе пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} душанбе" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "дшб г." }, { 0, "дшб ҷ." }, { 1, "дшб о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дшб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} дшб" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "душанбеи г." }, { 0, "душанбеи ҷ." }, { 1, "душанбеи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дшб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} дшб" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "сешанбеи гузашта" }, { 0, "сешанбеи ҷорӣ" }, { 1, "сешанбеи оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сешанбе пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} сешанбе" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "сшб г." }, { 0, "сшб ҷ." }, { 1, "сшб о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сшб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} сшб" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "сешанбеи г." }, { 0, "сешанбеи ҷ." }, { 1, "сешанбеи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сшб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} сшб" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "чоршанбеи гузашта" }, { 0, "чоршанбеи ҷорӣ" }, { 1, "чоршанбеи оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чоршанбе пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} чоршанбе" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "чшб г." }, { 0, "чшб ҷ." }, { 1, "чшб о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чшб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} чшб" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "чоршанбеи г." }, { 0, "чоршанбеи ҷ." }, { 1, "чоршанбеи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} чшб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} чшб" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "панҷшанбеи гузашта" }, { 0, "панҷшанбеи ҷорӣ" }, { 1, "панҷшанбеи оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} панҷшанбе пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} панҷшанбе" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "пшб г." }, { 0, "пшб ҷ." }, { 1, "пшб о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} пшб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} пшб" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "панҷшанбеи г." }, { 0, "панҷшанбеи ҷ." }, { 1, "панҷшанбеи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} пшб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} пшб" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ҷумъаи гузашта" }, { 0, "ҷумъаи ҷорӣ" }, { 1, "ҷумъаи оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ҷумъа пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} ҷумъа" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ҷмъ г." }, { 0, "ҷмъ ҷ." }, { 1, "ҷмъ о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ҷмъ пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} ҷмъ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ҷумъаи г." }, { 0, "ҷумъаи ҷ." }, { 1, "ҷумъаи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ҷмъ пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} ҷмъ" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "шанбеи гузашта" }, { 0, "шанбеи ҷорӣ" }, { 1, "шанбеи оянда" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} шанбе пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} шанбе" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "шнб г." }, { 0, "шнб ҷ." }, { 1, "шнб о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} шнб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} шнб" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "шанбеи г." }, { 0, "шанбеи ҷ." }, { 1, "шанбеи о." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} шнб пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} шнб" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "AM/PM",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "AM/PM",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "AM/PM",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "соат",
                new Dictionary<int, string> { { 0, "соати ҷорӣ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} соат пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} соат" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ст.",
                new Dictionary<int, string> { { 0, "соати ҷорӣ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ст. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} ст." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ст.",
                new Dictionary<int, string> { { 0, "соати ҷорӣ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ст. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} ст." } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "дақиқа",
                new Dictionary<int, string> { { 0, "дақиқаи ҷорӣ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дақиқа пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} дақиқа" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "дақ.",
                new Dictionary<int, string> { { 0, "дақиқаи ҷорӣ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дақ. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} дақ." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "дақ.",
                new Dictionary<int, string> { { 0, "дақиқаи ҷорӣ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} дақ. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} дақ." } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "сония",
                new Dictionary<int, string> { { 0, "ҳозир" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сония пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} сония" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "сон.",
                new Dictionary<int, string> { { 0, "ҳозир" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сон. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} сон." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "сон.",
                new Dictionary<int, string> { { 0, "ҳозир" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} сон. пеш" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "пас аз {0} сон." } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Tajik' [tg]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "минтақаи вақт",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "минтақаи вақт",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "минтақаи вақт",
                null,
                null,
                null));
    }
}