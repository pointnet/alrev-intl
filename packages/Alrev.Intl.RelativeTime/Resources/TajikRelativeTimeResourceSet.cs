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
    public class TajikRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "tg";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "мабдаи таърих",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "мабдаи таърих",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "мабдаи таърих",
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
                "сол",
                "соли гузашта",
                "соли ҷорӣ",
                "соли оянда",
                new RelativeTimeCountResource(null, "{0} сол пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} сол")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "с.",
                "соли г.",
                "соли ҷ.",
                "соли о.",
                new RelativeTimeCountResource(null, "{0} с. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} с.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "с.",
                "соли г.",
                "соли ҷ.",
                "соли о.",
                new RelativeTimeCountResource(null, "{0} с. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} с.")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "чоряк",
                "чоряки гузашта",
                "чоряки ҷорӣ",
                "чоряки оянда",
                new RelativeTimeCountResource(null, "{0} чоряк пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} чоряк")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "чр.",
                "чоряки гузашта",
                "чоряки ҷорӣ",
                "чоряки оянда",
                new RelativeTimeCountResource(null, "{0} чр. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} чр.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "чр.",
                "чоряки гузашта",
                "чоряки ҷорӣ",
                "чоряки оянда",
                new RelativeTimeCountResource(null, "{0} чр. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} чр.")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "моҳ",
                "моҳи гузашта",
                "моҳи ҷорӣ",
                "моҳи оянда",
                new RelativeTimeCountResource(null, "{0} моҳ пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} моҳ")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "м.",
                "моҳи г.",
                "моҳи ҷ.",
                "моҳи о.",
                new RelativeTimeCountResource(null, "{0} м. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} м.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "м.",
                "моҳи г.",
                "моҳи ҷ.",
                "моҳи о.",
                new RelativeTimeCountResource(null, "{0} м. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} м.")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ҳафта",
                "ҳафтаи гузашта",
                "ҳафтаи ҷорӣ",
                "ҳафтаи оянда",
                new RelativeTimeCountResource(null, "{0} ҳафта пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} ҳафта")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ҳ.",
                "ҳафтаи г.",
                "ҳафтаи ҷ.",
                "ҳафтаи о.",
                new RelativeTimeCountResource(null, "{0} ҳ. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} ҳ.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ҳ.",
                "ҳафтаи г.",
                "ҳафтаи ҷ.",
                "ҳафтаи о.",
                new RelativeTimeCountResource(null, "{0} ҳ. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} ҳ.")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ҳафтаи моҳ",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ҳ. м.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ҳ. м.",
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
                "рӯз",
                "дирӯз",
                "имрӯз",
                "фардо",
                new RelativeTimeCountResource(null, "{0} рӯз пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} рӯз")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "рӯз",
                "дирӯз",
                "имрӯз",
                "фардо",
                new RelativeTimeCountResource(null, "{0} рӯз пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} рӯз")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "рӯз",
                "дирӯз",
                "имрӯз",
                "фардо",
                new RelativeTimeCountResource(null, "{0} рӯз пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} рӯз")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "рӯзи сол",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "рӯзи с.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "рӯзи с.",
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
                "рӯзи ҳафта",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "рӯзи ҳ.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "рӯзи ҳ.",
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
                "рӯзи ҳафтаи моҳ",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "рӯзи ҳ. м.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "рӯзи ҳ. м.",
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
                "якшанбеи гузашта",
                "якшанбеи ҷорӣ",
                "якшанбеи оянда",
                new RelativeTimeCountResource(null, "{0} якшанбе пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} якшанбе")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "яшб г.",
                "яшб ҷ.",
                "яшб о.",
                new RelativeTimeCountResource(null, "{0} ябш пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} яшб")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "якшанбеи г.",
                "якшанбеи ҷ.",
                "якшанбеи о.",
                new RelativeTimeCountResource(null, "{0} яшб. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} яшб")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "душанбеи гузашта",
                "душанбеи ҷорӣ",
                "душанбеи оянда",
                new RelativeTimeCountResource(null, "{0} душанбе пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} душанбе")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "дшб г.",
                "дшб ҷ.",
                "дшб о.",
                new RelativeTimeCountResource(null, "{0} дшб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} дшб")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "душанбеи г.",
                "душанбеи ҷ.",
                "душанбеи о.",
                new RelativeTimeCountResource(null, "{0} дшб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} дшб")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "сешанбеи гузашта",
                "сешанбеи ҷорӣ",
                "сешанбеи оянда",
                new RelativeTimeCountResource(null, "{0} сешанбе пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} сешанбе")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "сшб г.",
                "сшб ҷ.",
                "сшб о.",
                new RelativeTimeCountResource(null, "{0} сшб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} сшб")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "сешанбеи г.",
                "сешанбеи ҷ.",
                "сешанбеи о.",
                new RelativeTimeCountResource(null, "{0} сшб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} сшб")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "чоршанбеи гузашта",
                "чоршанбеи ҷорӣ",
                "чоршанбеи оянда",
                new RelativeTimeCountResource(null, "{0} чоршанбе пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} чоршанбе")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "чшб г.",
                "чшб ҷ.",
                "чшб о.",
                new RelativeTimeCountResource(null, "{0} чшб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} чшб")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "чоршанбеи г.",
                "чоршанбеи ҷ.",
                "чоршанбеи о.",
                new RelativeTimeCountResource(null, "{0} чшб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} чшб")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "панҷшанбеи гузашта",
                "панҷшанбеи ҷорӣ",
                "панҷшанбеи оянда",
                new RelativeTimeCountResource(null, "{0} панҷшанбе пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} панҷшанбе")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "пшб г.",
                "пшб ҷ.",
                "пшб о.",
                new RelativeTimeCountResource(null, "{0} пшб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} пшб")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "панҷшанбеи г.",
                "панҷшанбеи ҷ.",
                "панҷшанбеи о.",
                new RelativeTimeCountResource(null, "{0} пшб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} пшб")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "ҷумъаи гузашта",
                "ҷумъаи ҷорӣ",
                "ҷумъаи оянда",
                new RelativeTimeCountResource(null, "{0} ҷумъа пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} ҷумъа")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "ҷмъ г.",
                "ҷмъ ҷ.",
                "ҷмъ о.",
                new RelativeTimeCountResource(null, "{0} ҷмъ пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} ҷмъ")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "ҷумъаи г.",
                "ҷумъаи ҷ.",
                "ҷумъаи о.",
                new RelativeTimeCountResource(null, "{0} ҷмъ пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} ҷмъ")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "шанбеи гузашта",
                "шанбеи ҷорӣ",
                "шанбеи оянда",
                new RelativeTimeCountResource(null, "{0} шанбе пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} шанбе")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "шнб г.",
                "шнб ҷ.",
                "шнб о.",
                new RelativeTimeCountResource(null, "{0} шнб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} шнб")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "шанбеи г.",
                "шанбеи ҷ.",
                "шанбеи о.",
                new RelativeTimeCountResource(null, "{0} шнб пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} шнб")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "AM/PM",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "AM/PM",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "AM/PM",
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
                "соат",
                null,
                "соати ҷорӣ",
                null,
                new RelativeTimeCountResource(null, "{0} соат пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} соат")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ст.",
                null,
                "соати ҷорӣ",
                null,
                new RelativeTimeCountResource(null, "{0} ст. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} ст.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ст.",
                null,
                "соати ҷорӣ",
                null,
                new RelativeTimeCountResource(null, "{0} ст. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} ст.")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "дақиқа",
                null,
                "дақиқаи ҷорӣ",
                null,
                new RelativeTimeCountResource(null, "{0} дақиқа пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} дақиқа")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "дақ.",
                null,
                "дақиқаи ҷорӣ",
                null,
                new RelativeTimeCountResource(null, "{0} дақ. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} дақ.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "дақ.",
                null,
                "дақиқаи ҷорӣ",
                null,
                new RelativeTimeCountResource(null, "{0} дақ. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} дақ.")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "сония",
                null,
                "ҳозир",
                null,
                new RelativeTimeCountResource(null, "{0} сония пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} сония")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "сон.",
                null,
                "ҳозир",
                null,
                new RelativeTimeCountResource(null, "{0} сон. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} сон.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "сон.",
                null,
                "ҳозир",
                null,
                new RelativeTimeCountResource(null, "{0} сон. пеш"),
                new RelativeTimeCountResource(null, "пас аз {0} сон.")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "минтақаи вақт",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "минтақаи вақт",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "минтақаи вақт",
                null,
                null,
                null,
                null,
                null));
    }
}