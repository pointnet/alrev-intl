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
    public class SerbianCyrillicKosovoRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "sr-Cyrl-XK";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ера",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ера",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ера",
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
                "година",
                "прошле године",
                "ове године",
                "следеће године",
                new RelativeTimeCountResource("пре {0} године", "пре {0} година"),
                new RelativeTimeCountResource("за {0} годину", "за {0} година")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "г.",
                "прошле г.",
                "ове г.",
                "следеће г.",
                new RelativeTimeCountResource("пре {0} г.", "пре {0} г."),
                new RelativeTimeCountResource("за {0} г.", "за {0} г.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "год.",
                "прошле год.",
                "ове год.",
                "следеће год.",
                new RelativeTimeCountResource("пре {0} год.", "пре {0} год."),
                new RelativeTimeCountResource("за {0} год.", "за {0} год.")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "квартал",
                "прошлог квартала",
                "овог квартала",
                "следећег квартала",
                new RelativeTimeCountResource("пре {0} квартала", "пре {0} квартала"),
                new RelativeTimeCountResource("за {0} квартал", "за {0} квартала")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "кв.",
                "прошлог квартала",
                "овог квартала",
                "следећег квартала",
                new RelativeTimeCountResource("пре {0} кв.", "пре {0} кв."),
                new RelativeTimeCountResource("за {0} кв.", "за {0} кв.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "кв.",
                "прошлог квартала",
                "овог квартала",
                "следећег квартала",
                new RelativeTimeCountResource("пре {0} кв.", "пре {0} кв."),
                new RelativeTimeCountResource("за {0} кв.", "за {0} кв.")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "месец",
                "прошлог месеца",
                "овог месеца",
                "следећег месеца",
                new RelativeTimeCountResource("пре {0} месеца", "пре {0} месеци"),
                new RelativeTimeCountResource("за {0} месец", "за {0} месеци")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "м.",
                "прошлог м.",
                "овог м.",
                "следећег м.",
                new RelativeTimeCountResource("пре {0} м.", "пре {0} м."),
                new RelativeTimeCountResource("за {0} м.", "за {0} м.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "мес.",
                "прошлог мес.",
                "овог мес.",
                "следећег мес.",
                new RelativeTimeCountResource("пре {0} мес.", "пре {0} мес."),
                new RelativeTimeCountResource("за {0} мес.", "за {0} мес.")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "недеља",
                "прошле недеље",
                "ове недеље",
                "следеће недеље",
                new RelativeTimeCountResource("пре {0} недеље", "пре {0} недеља"),
                new RelativeTimeCountResource("за {0} недељу", "за {0} недеља")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "н.",
                "прошле н.",
                "ове н.",
                "следеће н.",
                new RelativeTimeCountResource("пре {0} н.", "пре {0} н."),
                new RelativeTimeCountResource("за {0} н.", "за {0} н.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "нед.",
                "прошле нед.",
                "ове нед.",
                "следеће нед.",
                new RelativeTimeCountResource("пре {0} нед.", "пре {0} нед."),
                new RelativeTimeCountResource("за {0} нед.", "за {0} нед.")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "недеља у месецу",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "нед. у мес.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "нед. у мес.",
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
                "дан",
                "јуче",
                "данас",
                "сутра",
                new RelativeTimeCountResource("пре {0} дана", "пре {0} дана"),
                new RelativeTimeCountResource("за {0} дан", "за {0} дана")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "д.",
                "јуче",
                "данас",
                "сутра",
                new RelativeTimeCountResource("пре {0} д.", "пре {0} д."),
                new RelativeTimeCountResource("за {0} д.", "за {0} д.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "д.",
                "јуче",
                "данас",
                "сутра",
                new RelativeTimeCountResource("пре {0} д.", "пре {0} д."),
                new RelativeTimeCountResource("за {0} д.", "за {0} д.")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "дан у години",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "дан у год.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "дан у год.",
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
                "дан у недељи",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "дан у недељи",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "дан у недељи",
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
                "дан у месецу",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "дан у месецу",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "дан у месецу",
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
                "прошле недеље",
                "у недељу",
                "следеће недеље",
                new RelativeTimeCountResource("пре {0} недеље", "пре {0} недеља"),
                new RelativeTimeCountResource("за {0} недељу", "за {0} недеља")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "пр. нед.",
                "у нед",
                "сл. нед.",
                new RelativeTimeCountResource("пре {0} недеље", "пре {0} недеља"),
                new RelativeTimeCountResource("за {0} недељу", "за {0} недеља")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "пр. нед.",
                "у нед",
                "сл. нед.",
                new RelativeTimeCountResource("пре {0} недеље", "пре {0} недеља"),
                new RelativeTimeCountResource("за {0} недељу", "за {0} недеља")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "прошлог понедељка",
                "у понедељак",
                "следећег понедељка",
                new RelativeTimeCountResource("пре {0} понедељка", "пре {0} понедељака"),
                new RelativeTimeCountResource("за {0} понедељак", "за {0} понедељака")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "прошлог пон",
                "у пон",
                "следећег пон",
                new RelativeTimeCountResource("пре {0} понедељка", "пре {0} понедељака"),
                new RelativeTimeCountResource("за {0} понедељак", "за {0} понедељака")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "прошлог пон",
                "у пон",
                "следећег пон",
                new RelativeTimeCountResource("пре {0} понедељка", "пре {0} понедељака"),
                new RelativeTimeCountResource("за {0} понедељак", "за {0} понедељака")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "прошлог уторка",
                "у уторак",
                "следећег уторка",
                new RelativeTimeCountResource("пре {0} уторка", "пре {0} уторака"),
                new RelativeTimeCountResource("за {0} уторак", "за {0} уторака")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "прошлог уто",
                "у уто",
                "следећег уто",
                new RelativeTimeCountResource("пре {0} уторка", "пре {0} уторака"),
                new RelativeTimeCountResource("за {0} уторак", "за {0} уторака")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "прошлог уто",
                "у уто",
                "следећег уто",
                new RelativeTimeCountResource("пре {0} уторка", "пре {0} уторака"),
                new RelativeTimeCountResource("за {0} уторак", "за {0} уторака")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "прошле среде",
                "у среду",
                "следеће среде",
                new RelativeTimeCountResource("пре {0} среде", "пре {0} среда"),
                new RelativeTimeCountResource("за {0} среду", "за {0} среда")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "прошле сре",
                "у сре",
                "следеће сре",
                new RelativeTimeCountResource("пре {0} среде", "пре {0} среда"),
                new RelativeTimeCountResource("за {0} среду", "за {0} среда")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "прошле сре",
                "у сре",
                "следеће сре",
                new RelativeTimeCountResource("пре {0} среде", "пре {0} среда"),
                new RelativeTimeCountResource("за {0} среду", "за {0} среда")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "прошлог четвртка",
                "у четвртак",
                "следећег четвртка",
                new RelativeTimeCountResource("пре {0} четвртка", "пре {0} четвртака"),
                new RelativeTimeCountResource("за {0} четвртак", "за {0} четвртака")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "прошлог чет",
                "у чет",
                "следећег чет",
                new RelativeTimeCountResource("пре {0} четвртка", "пре {0} четвртака"),
                new RelativeTimeCountResource("за {0} четвртак", "за {0} четвртака")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "прошлог чет",
                "у чет",
                "следећег чет",
                new RelativeTimeCountResource("пре {0} четвртка", "пре {0} четвртака"),
                new RelativeTimeCountResource("за {0} четвртак", "за {0} четвртака")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "прошлог петка",
                "у петак",
                "следећег петка",
                new RelativeTimeCountResource("пре {0} петка", "пре {0} петака"),
                new RelativeTimeCountResource("за {0} петак", "за {0} петака")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "прошлог пет",
                "у пет",
                "следећег пет",
                new RelativeTimeCountResource("пре {0} петка", "пре {0} петака"),
                new RelativeTimeCountResource("за {0} петак", "за {0} петака")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "прошлог пет",
                "у пет",
                "следећег пет",
                new RelativeTimeCountResource("пре {0} петка", "пре {0} петака"),
                new RelativeTimeCountResource("за {0} петак", "за {0} петака")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "прошле суботе",
                "у суботу",
                "следеће суботе",
                new RelativeTimeCountResource("пре {0} суботе", "пре {0} субота"),
                new RelativeTimeCountResource("за {0} суботу", "за {0} субота")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "прошле суб",
                "у суб",
                "следеће суб",
                new RelativeTimeCountResource("пре {0} суботе", "пре {0} субота"),
                new RelativeTimeCountResource("за {0} суботу", "за {0} субота")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "прошле суб",
                "у суб",
                "следеће суб",
                new RelativeTimeCountResource("пре {0} суботе", "пре {0} субота"),
                new RelativeTimeCountResource("за {0} суботу", "за {0} субота")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "пре подне/по подне",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "пре подне/по подне",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "пре подне/по подне",
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
                "сат",
                null,
                "овог сата",
                null,
                new RelativeTimeCountResource("пре {0} сата", "пре {0} сати"),
                new RelativeTimeCountResource("за {0} сат", "за {0} сати")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ч.",
                null,
                "овог сата",
                null,
                new RelativeTimeCountResource("пре {0} ч.", "пре {0} ч."),
                new RelativeTimeCountResource("за {0} ч.", "за {0} ч.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ч.",
                null,
                "овог сата",
                null,
                new RelativeTimeCountResource("пре {0} ч.", "пре {0} ч."),
                new RelativeTimeCountResource("за {0} ч.", "за {0} ч.")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "минут",
                null,
                "овог минута",
                null,
                new RelativeTimeCountResource("пре {0} минута", "пре {0} минута"),
                new RelativeTimeCountResource("за {0} минут", "за {0} минута")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "мин.",
                null,
                "овог минута",
                null,
                new RelativeTimeCountResource("пре {0} мин.", "пре {0} мин."),
                new RelativeTimeCountResource("за {0} мин.", "за {0} мин.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "мин.",
                null,
                "овог минута",
                null,
                new RelativeTimeCountResource("пре {0} мин.", "пре {0} мин."),
                new RelativeTimeCountResource("за {0} мин.", "за {0} мин.")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "секунд",
                null,
                "сада",
                null,
                new RelativeTimeCountResource("пре {0} секунде", "пре {0} секунди"),
                new RelativeTimeCountResource("за {0} секунду", "за {0} секунди")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "с.",
                null,
                "сада",
                null,
                new RelativeTimeCountResource("пре {0} с.", "пре {0} с."),
                new RelativeTimeCountResource("за {0} с.", "за {0} с.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "сек.",
                null,
                "сада",
                null,
                new RelativeTimeCountResource("пре {0} сек.", "пре {0} сек."),
                new RelativeTimeCountResource("за {0} сек.", "за {0} сек.")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "временска зона",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "временска зона",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "временска зона",
                null,
                null,
                null,
                null,
                null));
    }
}