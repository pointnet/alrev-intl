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
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "erë",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "erë",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "vit",
                new Dictionary<int, string> { { -1, "vjet" }, { 0, "sivjet" }, { 1, "mot" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vit më parë" }, { PluralRulesValues.Other, "{0} vjet më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} viti" }, { PluralRulesValues.Other, "pas {0} vjetësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "vit",
                new Dictionary<int, string> { { -1, "vitin e kaluar" }, { 0, "këtë vit" }, { 1, "vitin e ardhshëm" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vit më parë" }, { PluralRulesValues.Other, "{0} vjet më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} viti" }, { PluralRulesValues.Other, "pas {0} vjetësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "vit",
                new Dictionary<int, string> { { -1, "vitin e kaluar" }, { 0, "këtë vit" }, { 1, "vitin e ardhshëm" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vit më parë" }, { PluralRulesValues.Other, "{0} vjet më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} viti" }, { PluralRulesValues.Other, "pas {0} vjetësh" } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "tremujor",
                new Dictionary<int, string> { { -1, "tremujorin e kaluar" }, { 0, "këtë tremujor" }, { 1, "tremujorin e ardhshëm" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tremujor më parë" }, { PluralRulesValues.Other, "{0} tremujorë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} tremujori" }, { PluralRulesValues.Other, "pas {0} tremujorësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "tremujor",
                new Dictionary<int, string> { { -1, "tremujorin e kaluar" }, { 0, "këtë tremujor" }, { 1, "tremujorin e ardhshëm" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tremujor më parë" }, { PluralRulesValues.Other, "{0} tremujorë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} tremujori" }, { PluralRulesValues.Other, "pas {0} tremujorësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "tremujor",
                new Dictionary<int, string> { { -1, "tremujorin e kaluar" }, { 0, "këtë tremujor" }, { 1, "tremujorin e ardhshëm" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tremujor më parë" }, { PluralRulesValues.Other, "{0} tremujorë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} tremujori" }, { PluralRulesValues.Other, "pas {0} tremujorësh" } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "muaj",
                new Dictionary<int, string> { { -1, "muajin e kaluar" }, { 0, "këtë muaj" }, { 1, "muajin e ardhshëm" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} muaj më parë" }, { PluralRulesValues.Other, "{0} muaj më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} muaji" }, { PluralRulesValues.Other, "pas {0} muajsh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "muaj",
                new Dictionary<int, string> { { -1, "muajin e kaluar" }, { 0, "këtë muaj" }, { 1, "muajin e ardhshëm" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} muaj më parë" }, { PluralRulesValues.Other, "{0} muaj më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} muaji" }, { PluralRulesValues.Other, "pas {0} muajsh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "muaj",
                new Dictionary<int, string> { { -1, "muajin e kaluar" }, { 0, "këtë muaj" }, { 1, "muajin e ardhshëm" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} muaj më parë" }, { PluralRulesValues.Other, "{0} muaj më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} muaji" }, { PluralRulesValues.Other, "pas {0} muajsh" } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "javë",
                new Dictionary<int, string> { { -1, "javën e kaluar" }, { 0, "këtë javë" }, { 1, "javën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} javë më parë" }, { PluralRulesValues.Other, "{0} javë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} jave" }, { PluralRulesValues.Other, "pas {0} javësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "javë",
                new Dictionary<int, string> { { -1, "javën e kaluar" }, { 0, "këtë javë" }, { 1, "javën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} javë më parë" }, { PluralRulesValues.Other, "{0} javë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} jave" }, { PluralRulesValues.Other, "pas {0} javësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "javë",
                new Dictionary<int, string> { { -1, "javën e kaluar" }, { 0, "këtë javë" }, { 1, "javën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} javë më parë" }, { PluralRulesValues.Other, "{0} javë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} jave" }, { PluralRulesValues.Other, "pas {0} javësh" } }));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "javë e muajit",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "javë e muajit",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "javë e muajit",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ditë",
                new Dictionary<int, string> { { -1, "dje" }, { 0, "sot" }, { 1, "nesër" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ditë më parë" }, { PluralRulesValues.Other, "{0} ditë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} dite" }, { PluralRulesValues.Other, "pas {0} ditësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ditë",
                new Dictionary<int, string> { { -1, "dje" }, { 0, "sot" }, { 1, "nesër" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ditë më parë" }, { PluralRulesValues.Other, "{0} ditë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} dite" }, { PluralRulesValues.Other, "pas {0} ditësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ditë",
                new Dictionary<int, string> { { -1, "dje" }, { 0, "sot" }, { 1, "nesër" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ditë më parë" }, { PluralRulesValues.Other, "{0} ditë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} dite" }, { PluralRulesValues.Other, "pas {0} ditësh" } }));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ditë e vitit",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ditë e vitit",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ditë e vitit",
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
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ditë e javës",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ditë e javës",
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
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ditë pune e muajit",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ditë pune e muajit",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "të dielën e kaluar" }, { 0, "këtë të diel" }, { 1, "të dielën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të dielë më parë" }, { PluralRulesValues.Other, "{0} të diela më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të diele" }, { PluralRulesValues.Other, "pas {0} të dielash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "të dielën e kaluar" }, { 0, "këtë të diel" }, { 1, "të dielën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të dielë më parë" }, { PluralRulesValues.Other, "{0} të diela më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të diele" }, { PluralRulesValues.Other, "pas {0} të dielash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "të dielën e kaluar" }, { 0, "këtë të diel" }, { 1, "të dielën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të dielë më parë" }, { PluralRulesValues.Other, "{0} të diela më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të diele" }, { PluralRulesValues.Other, "pas {0} të dielash" } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "të hënën e kaluar" }, { 0, "këtë të hënë" }, { 1, "të hënën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të hënë më parë" }, { PluralRulesValues.Other, "{0} të hëna më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të hëne" }, { PluralRulesValues.Other, "pas {0} të hënash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "të hënën e kaluar" }, { 0, "këtë të hënë" }, { 1, "të hënën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të hënë më parë" }, { PluralRulesValues.Other, "{0} të hëna më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të hëne" }, { PluralRulesValues.Other, "pas {0} të hënash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "të hënën e kaluar" }, { 0, "këtë të hënë" }, { 1, "të hënën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të hënë më parë" }, { PluralRulesValues.Other, "{0} të hëna më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të hëne" }, { PluralRulesValues.Other, "pas {0} të hënash" } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "të martën e kaluar" }, { 0, "këtë të martë" }, { 1, "të martën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të martë më parë" }, { PluralRulesValues.Other, "{0} të marta më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të marte" }, { PluralRulesValues.Other, "pas {0} të martash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "të martën e kaluar" }, { 0, "këtë të martë" }, { 1, "të martën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të martë më parë" }, { PluralRulesValues.Other, "{0} të marta më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të marte" }, { PluralRulesValues.Other, "pas {0} të martash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "të martën e kaluar" }, { 0, "këtë të martë" }, { 1, "të martën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të martë më parë" }, { PluralRulesValues.Other, "{0} të marta më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të marte" }, { PluralRulesValues.Other, "pas {0} të martash" } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "të mërkurën e kaluar" }, { 0, "këtë të mërkurë" }, { 1, "të mërkurën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të mërkurë më parë" }, { PluralRulesValues.Other, "{0} të mërkura më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të mërkure" }, { PluralRulesValues.Other, "pas {0} të mërkurash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "të mërkurën e kaluar" }, { 0, "këtë të mërkurë" }, { 1, "të mërkurën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të mërkurë më parë" }, { PluralRulesValues.Other, "{0} të mërkura më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të mërkure" }, { PluralRulesValues.Other, "pas {0} të mërkurash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "të mërkurën e kaluar" }, { 0, "këtë të mërkurë" }, { 1, "të mërkurën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të mërkurë më parë" }, { PluralRulesValues.Other, "{0} të mërkura më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të mërkure" }, { PluralRulesValues.Other, "pas {0} të mërkurash" } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "të enjten e kaluar" }, { 0, "këtë të enjte" }, { 1, "të enjten e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të enjte më parë" }, { PluralRulesValues.Other, "{0} të enjte më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të enjteje" }, { PluralRulesValues.Other, "pas {0} të enjtesh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "të enjten e kaluar" }, { 0, "këtë të enjte" }, { 1, "të enjten e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të enjte më parë" }, { PluralRulesValues.Other, "{0} të enjte më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të enjteje" }, { PluralRulesValues.Other, "pas {0} të enjtesh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "të enjten e kaluar" }, { 0, "këtë të enjte" }, { 1, "të enjten e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të enjte më parë" }, { PluralRulesValues.Other, "{0} të enjte më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të enjteje" }, { PluralRulesValues.Other, "pas {0} të enjtesh" } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "të premten e kaluar" }, { 0, "këtë të premte" }, { 1, "të premten e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të premte më parë" }, { PluralRulesValues.Other, "{0} të premte më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të premteje" }, { PluralRulesValues.Other, "pas {0} të premtesh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "të premten e kaluar" }, { 0, "këtë të premte" }, { 1, "të premten e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të premte më parë" }, { PluralRulesValues.Other, "{0} të premte më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të premteje" }, { PluralRulesValues.Other, "pas {0} të premtesh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "të premten e kaluar" }, { 0, "këtë të premte" }, { 1, "të premten e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të premte më parë" }, { PluralRulesValues.Other, "{0} të premte më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të premteje" }, { PluralRulesValues.Other, "pas {0} të premtesh" } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "të shtunën e kaluar" }, { 0, "këtë të shtunë" }, { 1, "të shtunën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të shtunë më parë" }, { PluralRulesValues.Other, "{0} të shtuna më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të shtune" }, { PluralRulesValues.Other, "pas {0} të shtunash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "të shtunën e kaluar" }, { 0, "këtë të shtunë" }, { 1, "të shtunën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të shtunë më parë" }, { PluralRulesValues.Other, "{0} të shtuna më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të shtune" }, { PluralRulesValues.Other, "pas {0} të shtunash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "të shtunën e kaluar" }, { 0, "këtë të shtunë" }, { 1, "të shtunën e ardhshme" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} të shtunë më parë" }, { PluralRulesValues.Other, "{0} të shtuna më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} të shtune" }, { PluralRulesValues.Other, "pas {0} të shtunash" } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "paradite/pasdite",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "paradite/pasdite",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "paradite/pasdite",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "orë",
                new Dictionary<int, string> { { 0, "këtë orë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} orë më parë" }, { PluralRulesValues.Other, "{0} orë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} ore" }, { PluralRulesValues.Other, "pas {0} orësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "orë",
                new Dictionary<int, string> { { 0, "këtë orë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} orë më parë" }, { PluralRulesValues.Other, "{0} orë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} ore" }, { PluralRulesValues.Other, "pas {0} orësh" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "orë",
                new Dictionary<int, string> { { 0, "këtë orë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} orë më parë" }, { PluralRulesValues.Other, "{0} orë më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} ore" }, { PluralRulesValues.Other, "pas {0} orësh" } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minutë",
                new Dictionary<int, string> { { 0, "këtë minutë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minutë më parë" }, { PluralRulesValues.Other, "{0} minuta më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} minute" }, { PluralRulesValues.Other, "pas {0} minutash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                new Dictionary<int, string> { { 0, "këtë minutë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min më parë" }, { PluralRulesValues.Other, "{0} min më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} min" }, { PluralRulesValues.Other, "pas {0} min" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                new Dictionary<int, string> { { 0, "këtë minutë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min më parë" }, { PluralRulesValues.Other, "{0} min më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} min" }, { PluralRulesValues.Other, "pas {0} min" } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "sekondë",
                new Dictionary<int, string> { { 0, "tani" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekondë më parë" }, { PluralRulesValues.Other, "{0} sekonda më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} sekonde" }, { PluralRulesValues.Other, "pas {0} sekondash" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sek",
                new Dictionary<int, string> { { 0, "tani" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek më parë" }, { PluralRulesValues.Other, "{0} sek më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} sek" }, { PluralRulesValues.Other, "pas {0} sek" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sek",
                new Dictionary<int, string> { { 0, "tani" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek më parë" }, { PluralRulesValues.Other, "{0} sek më parë" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pas {0} sek" }, { PluralRulesValues.Other, "pas {0} sek" } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "brezi orar",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "brezi orar",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "brezi orar",
                null,
                null,
                null));
    }
}