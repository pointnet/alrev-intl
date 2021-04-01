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
    public class AlbanianRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "sq";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "erë",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "erë",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "erë",
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
                "vit",
                "vjet",
                "sivjet",
                "mot",
                new RelativeTimeCountResource("{0} vit më parë", "{0} vjet më parë"),
                new RelativeTimeCountResource("pas {0} viti", "pas {0} vjetësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "vit",
                "vitin e kaluar",
                "këtë vit",
                "vitin e ardhshëm",
                new RelativeTimeCountResource("{0} vit më parë", "{0} vjet më parë"),
                new RelativeTimeCountResource("pas {0} viti", "pas {0} vjetësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "vit",
                "vitin e kaluar",
                "këtë vit",
                "vitin e ardhshëm",
                new RelativeTimeCountResource("{0} vit më parë", "{0} vjet më parë"),
                new RelativeTimeCountResource("pas {0} viti", "pas {0} vjetësh")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "tremujor",
                "tremujorin e kaluar",
                "këtë tremujor",
                "tremujorin e ardhshëm",
                new RelativeTimeCountResource("{0} tremujor më parë", "{0} tremujorë më parë"),
                new RelativeTimeCountResource("pas {0} tremujori", "pas {0} tremujorësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "tremujor",
                "tremujorin e kaluar",
                "këtë tremujor",
                "tremujorin e ardhshëm",
                new RelativeTimeCountResource("{0} tremujor më parë", "{0} tremujorë më parë"),
                new RelativeTimeCountResource("pas {0} tremujori", "pas {0} tremujorësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "tremujor",
                "tremujorin e kaluar",
                "këtë tremujor",
                "tremujorin e ardhshëm",
                new RelativeTimeCountResource("{0} tremujor më parë", "{0} tremujorë më parë"),
                new RelativeTimeCountResource("pas {0} tremujori", "pas {0} tremujorësh")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "muaj",
                "muajin e kaluar",
                "këtë muaj",
                "muajin e ardhshëm",
                new RelativeTimeCountResource("{0} muaj më parë", "{0} muaj më parë"),
                new RelativeTimeCountResource("pas {0} muaji", "pas {0} muajsh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "muaj",
                "muajin e kaluar",
                "këtë muaj",
                "muajin e ardhshëm",
                new RelativeTimeCountResource("{0} muaj më parë", "{0} muaj më parë"),
                new RelativeTimeCountResource("pas {0} muaji", "pas {0} muajsh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "muaj",
                "muajin e kaluar",
                "këtë muaj",
                "muajin e ardhshëm",
                new RelativeTimeCountResource("{0} muaj më parë", "{0} muaj më parë"),
                new RelativeTimeCountResource("pas {0} muaji", "pas {0} muajsh")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "javë",
                "javën e kaluar",
                "këtë javë",
                "javën e ardhshme",
                new RelativeTimeCountResource("{0} javë më parë", "{0} javë më parë"),
                new RelativeTimeCountResource("pas {0} jave", "pas {0} javësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "javë",
                "javën e kaluar",
                "këtë javë",
                "javën e ardhshme",
                new RelativeTimeCountResource("{0} javë më parë", "{0} javë më parë"),
                new RelativeTimeCountResource("pas {0} jave", "pas {0} javësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "javë",
                "javën e kaluar",
                "këtë javë",
                "javën e ardhshme",
                new RelativeTimeCountResource("{0} javë më parë", "{0} javë më parë"),
                new RelativeTimeCountResource("pas {0} jave", "pas {0} javësh")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "javë e muajit",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "javë e muajit",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "javë e muajit",
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
                "ditë",
                "dje",
                "sot",
                "nesër",
                new RelativeTimeCountResource("{0} ditë më parë", "{0} ditë më parë"),
                new RelativeTimeCountResource("pas {0} dite", "pas {0} ditësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ditë",
                "dje",
                "sot",
                "nesër",
                new RelativeTimeCountResource("{0} ditë më parë", "{0} ditë më parë"),
                new RelativeTimeCountResource("pas {0} dite", "pas {0} ditësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ditë",
                "dje",
                "sot",
                "nesër",
                new RelativeTimeCountResource("{0} ditë më parë", "{0} ditë më parë"),
                new RelativeTimeCountResource("pas {0} dite", "pas {0} ditësh")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ditë e vitit",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ditë e vitit",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ditë e vitit",
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
                "ditë e javës",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ditë e javës",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ditë e javës",
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
                "ditë pune e muajit",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ditë pune e muajit",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ditë pune e muajit",
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
                "të dielën e kaluar",
                "këtë të diel",
                "të dielën e ardhshme",
                new RelativeTimeCountResource("{0} të dielë më parë", "{0} të diela më parë"),
                new RelativeTimeCountResource("pas {0} të diele", "pas {0} të dielash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "të dielën e kaluar",
                "këtë të diel",
                "të dielën e ardhshme",
                new RelativeTimeCountResource("{0} të dielë më parë", "{0} të diela më parë"),
                new RelativeTimeCountResource("pas {0} të diele", "pas {0} të dielash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "të dielën e kaluar",
                "këtë të diel",
                "të dielën e ardhshme",
                new RelativeTimeCountResource("{0} të dielë më parë", "{0} të diela më parë"),
                new RelativeTimeCountResource("pas {0} të diele", "pas {0} të dielash")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "të hënën e kaluar",
                "këtë të hënë",
                "të hënën e ardhshme",
                new RelativeTimeCountResource("{0} të hënë më parë", "{0} të hëna më parë"),
                new RelativeTimeCountResource("pas {0} të hëne", "pas {0} të hënash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "të hënën e kaluar",
                "këtë të hënë",
                "të hënën e ardhshme",
                new RelativeTimeCountResource("{0} të hënë më parë", "{0} të hëna më parë"),
                new RelativeTimeCountResource("pas {0} të hëne", "pas {0} të hënash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "të hënën e kaluar",
                "këtë të hënë",
                "të hënën e ardhshme",
                new RelativeTimeCountResource("{0} të hënë më parë", "{0} të hëna më parë"),
                new RelativeTimeCountResource("pas {0} të hëne", "pas {0} të hënash")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "të martën e kaluar",
                "këtë të martë",
                "të martën e ardhshme",
                new RelativeTimeCountResource("{0} të martë më parë", "{0} të marta më parë"),
                new RelativeTimeCountResource("pas {0} të marte", "pas {0} të martash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "të martën e kaluar",
                "këtë të martë",
                "të martën e ardhshme",
                new RelativeTimeCountResource("{0} të martë më parë", "{0} të marta më parë"),
                new RelativeTimeCountResource("pas {0} të marte", "pas {0} të martash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "të martën e kaluar",
                "këtë të martë",
                "të martën e ardhshme",
                new RelativeTimeCountResource("{0} të martë më parë", "{0} të marta më parë"),
                new RelativeTimeCountResource("pas {0} të marte", "pas {0} të martash")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "të mërkurën e kaluar",
                "këtë të mërkurë",
                "të mërkurën e ardhshme",
                new RelativeTimeCountResource("{0} të mërkurë më parë", "{0} të mërkura më parë"),
                new RelativeTimeCountResource("pas {0} të mërkure", "pas {0} të mërkurash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "të mërkurën e kaluar",
                "këtë të mërkurë",
                "të mërkurën e ardhshme",
                new RelativeTimeCountResource("{0} të mërkurë më parë", "{0} të mërkura më parë"),
                new RelativeTimeCountResource("pas {0} të mërkure", "pas {0} të mërkurash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "të mërkurën e kaluar",
                "këtë të mërkurë",
                "të mërkurën e ardhshme",
                new RelativeTimeCountResource("{0} të mërkurë më parë", "{0} të mërkura më parë"),
                new RelativeTimeCountResource("pas {0} të mërkure", "pas {0} të mërkurash")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "të enjten e kaluar",
                "këtë të enjte",
                "të enjten e ardhshme",
                new RelativeTimeCountResource("{0} të enjte më parë", "{0} të enjte më parë"),
                new RelativeTimeCountResource("pas {0} të enjteje", "pas {0} të enjtesh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "të enjten e kaluar",
                "këtë të enjte",
                "të enjten e ardhshme",
                new RelativeTimeCountResource("{0} të enjte më parë", "{0} të enjte më parë"),
                new RelativeTimeCountResource("pas {0} të enjteje", "pas {0} të enjtesh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "të enjten e kaluar",
                "këtë të enjte",
                "të enjten e ardhshme",
                new RelativeTimeCountResource("{0} të enjte më parë", "{0} të enjte më parë"),
                new RelativeTimeCountResource("pas {0} të enjteje", "pas {0} të enjtesh")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "të premten e kaluar",
                "këtë të premte",
                "të premten e ardhshme",
                new RelativeTimeCountResource("{0} të premte më parë", "{0} të premte më parë"),
                new RelativeTimeCountResource("pas {0} të premteje", "pas {0} të premtesh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "të premten e kaluar",
                "këtë të premte",
                "të premten e ardhshme",
                new RelativeTimeCountResource("{0} të premte më parë", "{0} të premte më parë"),
                new RelativeTimeCountResource("pas {0} të premteje", "pas {0} të premtesh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "të premten e kaluar",
                "këtë të premte",
                "të premten e ardhshme",
                new RelativeTimeCountResource("{0} të premte më parë", "{0} të premte më parë"),
                new RelativeTimeCountResource("pas {0} të premteje", "pas {0} të premtesh")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "të shtunën e kaluar",
                "këtë të shtunë",
                "të shtunën e ardhshme",
                new RelativeTimeCountResource("{0} të shtunë më parë", "{0} të shtuna më parë"),
                new RelativeTimeCountResource("pas {0} të shtune", "pas {0} të shtunash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "të shtunën e kaluar",
                "këtë të shtunë",
                "të shtunën e ardhshme",
                new RelativeTimeCountResource("{0} të shtunë më parë", "{0} të shtuna më parë"),
                new RelativeTimeCountResource("pas {0} të shtune", "pas {0} të shtunash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "të shtunën e kaluar",
                "këtë të shtunë",
                "të shtunën e ardhshme",
                new RelativeTimeCountResource("{0} të shtunë më parë", "{0} të shtuna më parë"),
                new RelativeTimeCountResource("pas {0} të shtune", "pas {0} të shtunash")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "paradite/pasdite",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "paradite/pasdite",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "paradite/pasdite",
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
                "orë",
                null,
                "këtë orë",
                null,
                new RelativeTimeCountResource("{0} orë më parë", "{0} orë më parë"),
                new RelativeTimeCountResource("pas {0} ore", "pas {0} orësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "orë",
                null,
                "këtë orë",
                null,
                new RelativeTimeCountResource("{0} orë më parë", "{0} orë më parë"),
                new RelativeTimeCountResource("pas {0} ore", "pas {0} orësh")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "orë",
                null,
                "këtë orë",
                null,
                new RelativeTimeCountResource("{0} orë më parë", "{0} orë më parë"),
                new RelativeTimeCountResource("pas {0} ore", "pas {0} orësh")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minutë",
                null,
                "këtë minutë",
                null,
                new RelativeTimeCountResource("{0} minutë më parë", "{0} minuta më parë"),
                new RelativeTimeCountResource("pas {0} minute", "pas {0} minutash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                null,
                "këtë minutë",
                null,
                new RelativeTimeCountResource("{0} min më parë", "{0} min më parë"),
                new RelativeTimeCountResource("pas {0} min", "pas {0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                null,
                "këtë minutë",
                null,
                new RelativeTimeCountResource("{0} min më parë", "{0} min më parë"),
                new RelativeTimeCountResource("pas {0} min", "pas {0} min")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "sekondë",
                null,
                "tani",
                null,
                new RelativeTimeCountResource("{0} sekondë më parë", "{0} sekonda më parë"),
                new RelativeTimeCountResource("pas {0} sekonde", "pas {0} sekondash")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sek",
                null,
                "tani",
                null,
                new RelativeTimeCountResource("{0} sek më parë", "{0} sek më parë"),
                new RelativeTimeCountResource("pas {0} sek", "pas {0} sek")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sek",
                null,
                "tani",
                null,
                new RelativeTimeCountResource("{0} sek më parë", "{0} sek më parë"),
                new RelativeTimeCountResource("pas {0} sek", "pas {0} sek")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "brezi orar",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "brezi orar",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "brezi orar",
                null,
                null,
                null,
                null,
                null));
    }
}