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
    public class TamilSingaporeRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "ta-SG";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "காலம்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "காலம்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "காலம்",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "ஆண்டு",
                new Dictionary<int, string> { { -1, "கடந்த ஆண்டு" }, { 0, "இந்த ஆண்டு" }, { 1, "அடுத்த ஆண்டு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஆண்டிற்கு முன்" }, { PluralRulesValues.Other, "{0} ஆண்டுகளுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஆண்டில்" }, { PluralRulesValues.Other, "{0} ஆண்டுகளில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ஆ.",
                new Dictionary<int, string> { { -1, "கடந்த ஆண்டு" }, { 0, "இந்த ஆண்டு" }, { 1, "அடுத்த ஆண்டு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஆ. முன்" }, { PluralRulesValues.Other, "{0} ஆ. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஆ." }, { PluralRulesValues.Other, "{0} ஆ." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "ஆண்டு",
                new Dictionary<int, string> { { -1, "கடந்த ஆண்டு" }, { 0, "இந்த ஆண்டு" }, { 1, "அடுத்த ஆண்டு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஆண்டிற்கு முன்" }, { PluralRulesValues.Other, "{0} ஆண்டுகளுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஆண்டில்" }, { PluralRulesValues.Other, "{0} ஆண்டுகளில்" } }));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "காலாண்டு",
                new Dictionary<int, string> { { -1, "கடந்த காலாண்டு" }, { 0, "இந்த காலாண்டு" }, { 1, "அடுத்த காலாண்டு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} காலாண்டுக்கு முன்" }, { PluralRulesValues.Other, "{0} காலாண்டுகளுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} காலாண்டில்" }, { PluralRulesValues.Other, "{0} காலாண்டுகளில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "கா.",
                new Dictionary<int, string> { { -1, "இறுதி காலாண்டு" }, { 0, "இந்த காலாண்டு" }, { 1, "அடுத்த காலாண்டு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} கா. முன்" }, { PluralRulesValues.Other, "{0} கா. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} கா." }, { PluralRulesValues.Other, "{0} கா." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "காலா.",
                new Dictionary<int, string> { { -1, "இறுதி காலாண்டு" }, { 0, "இந்த காலாண்டு" }, { 1, "அடுத்த காலாண்டு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} காலா. முன்" }, { PluralRulesValues.Other, "{0} காலா. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} காலா." }, { PluralRulesValues.Other, "{0} காலா." } }));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "மாதம்",
                new Dictionary<int, string> { { -1, "கடந்த மாதம்" }, { 0, "இந்த மாதம்" }, { 1, "அடுத்த மாதம்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மாதத்துக்கு முன்" }, { PluralRulesValues.Other, "{0} மாதங்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மாதத்தில்" }, { PluralRulesValues.Other, "{0} மாதங்களில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "மா.",
                new Dictionary<int, string> { { -1, "கடந்த மாதம்" }, { 0, "இந்த மாதம்" }, { 1, "அடுத்த மாதம்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மா. முன்" }, { PluralRulesValues.Other, "{0} மா. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மா." }, { PluralRulesValues.Other, "{0} மா." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "மாத.",
                new Dictionary<int, string> { { -1, "கடந்த மாதம்" }, { 0, "இந்த மாதம்" }, { 1, "அடுத்த மாதம்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மாத. முன்" }, { PluralRulesValues.Other, "{0} மாத. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மாத." }, { PluralRulesValues.Other, "{0} மாத." } }));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "வாரம்",
                new Dictionary<int, string> { { -1, "கடந்த வாரம்" }, { 0, "இந்த வாரம்" }, { 1, "அடுத்த வாரம்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வாரத்திற்கு முன்" }, { PluralRulesValues.Other, "{0} வாரங்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வாரத்தில்" }, { PluralRulesValues.Other, "{0} வாரங்களில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "வா.",
                new Dictionary<int, string> { { -1, "கடந்த வாரம்" }, { 0, "இந்த வாரம்" }, { 1, "அடுத்த வாரம்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வா. முன்" }, { PluralRulesValues.Other, "{0} வா. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வா." }, { PluralRulesValues.Other, "{0} வா." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "வாரம்",
                new Dictionary<int, string> { { -1, "கடந்த வாரம்" }, { 0, "இந்த வாரம்" }, { 1, "அடுத்த வாரம்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வார. முன்" }, { PluralRulesValues.Other, "{0} வார. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வார." }, { PluralRulesValues.Other, "{0} வார." } }));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "மாதத்தின் வாரம்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "மாத. வாரம்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "மாத. வாரம்",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "நாள்",
                new Dictionary<int, string> { { -2, "நேற்று முன் தினம்" }, { -1, "நேற்று" }, { 0, "இன்று" }, { 1, "நாளை" }, { 2, "நாளை மறுநாள்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நாளுக்கு முன்" }, { PluralRulesValues.Other, "{0} நாட்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நாளில்" }, { PluralRulesValues.Other, "{0} நாட்களில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "நா.",
                new Dictionary<int, string> { { -2, "நேற்று முன் தினம்" }, { -1, "நேற்று" }, { 0, "இன்று" }, { 1, "நாளை" }, { 2, "நாளை மறுநாள்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நா. முன்" }, { PluralRulesValues.Other, "{0} நா. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நா." }, { PluralRulesValues.Other, "{0} நா." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "நாள்",
                new Dictionary<int, string> { { -2, "நேற்று முன் தினம்" }, { -1, "நேற்று" }, { 0, "இன்று" }, { 1, "நாளை" }, { 2, "நாளை மறுநாள்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நாளுக்கு முன்" }, { PluralRulesValues.Other, "{0} நாட்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நாளில்" }, { PluralRulesValues.Other, "{0} நாட்களில்" } }));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "வருடத்தின் நாள்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "வருட. நாள்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "வருட. நாள்",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "வாரத்தின் நாள்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "வார. நாள்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "வார. நாள்",
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "மாதத்தின் வாரநாள்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "மாத. வாரநாள்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "மாத. வாரநாள்",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "கடந்த ஞாயிறு" }, { 0, "இந்த ஞாயிறு" }, { 1, "அடுத்த ஞாயிறு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஞாயிறுக்கு முன்பு" }, { PluralRulesValues.Other, "{0} ஞாயிறுகளுக்கு முன்பு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஞாயிறில்" }, { PluralRulesValues.Other, "{0} ஞாயிறுகளில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "கடந்த ஞா." }, { 0, "இந்த ஞா." }, { 1, "அடுத்த ஞா." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஞா. முன்" }, { PluralRulesValues.Other, "{0} ஞா. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஞா." }, { PluralRulesValues.Other, "{0} ஞா." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "கடந்த ஞாயி." }, { 0, "இந்த ஞாயி." }, { 1, "அடுத்த ஞாயி." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஞாயி. முன்" }, { PluralRulesValues.Other, "{0} ஞாயி. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ஞாயி." }, { PluralRulesValues.Other, "{0} ஞாயி." } }));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "கடந்த திங்கள்" }, { 0, "இந்த திங்கள்" }, { 1, "அடுத்த திங்கள்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} திங்களுக்கு முன்" }, { PluralRulesValues.Other, "{0} திங்கள்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} திங்களில்" }, { PluralRulesValues.Other, "{0} திங்கள்களில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "கடந்த திங்." }, { 0, "இந்த திங்." }, { 1, "அடுத்த திங்." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} திங். முன்" }, { PluralRulesValues.Other, "{0} திங். முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} திங்." }, { PluralRulesValues.Other, "{0} திங்." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "கடந்த திங்." }, { 0, "இந்த திங்." }, { 1, "அடுத்த திங்." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} திங். முன்" }, { PluralRulesValues.Other, "{0} திங். முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} திங்." }, { PluralRulesValues.Other, "{0} திங்." } }));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "கடந்த செவ்வாய்" }, { 0, "இந்த செவ்வாய்" }, { 1, "அடுத்த செவ்வாய்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} செவ்வாய் முன்பு" }, { PluralRulesValues.Other, "{0} செவ்வாய்கள் முன்பு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} செவ்வாயில்" }, { PluralRulesValues.Other, "{0} செவ்வாய்களில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "கடந்த செவ்." }, { 0, "இந்த செவ்." }, { 1, "அடுத்த செவ்." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} செவ்வாய்களுக்கு முன்" }, { PluralRulesValues.Other, "{0} செவ். முன்பு" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} செவ்." }, { PluralRulesValues.Other, "{0} செவ்வாய்களில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "கடந்த செவ்." }, { 0, "இந்த செவ்." }, { 1, "அடுத்த செவ்." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} செவ்வாய்களுக்கு முன்" }, { PluralRulesValues.Other, "{0} செவ்வாய்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} செவ்." }, { PluralRulesValues.Other, "{0} செவ்." } }));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "கடந்த புதன்" }, { 0, "இந்த புதன்" }, { 1, "அடுத்த புதன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} புதனுக்கு முன்" }, { PluralRulesValues.Other, "{0} புதன்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} புதனில்" }, { PluralRulesValues.Other, "{0} புதன்களில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "கடந்த புத." }, { 0, "இந்த புத." }, { 1, "அடுத்த புத." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} புத. முன்" }, { PluralRulesValues.Other, "{0} புத. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} புத." }, { PluralRulesValues.Other, "{0} புத." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "கடந்த புத." }, { 0, "இந்த புத." }, { 1, "அடுத்த புத." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} புதன்களுக்கு முன்" }, { PluralRulesValues.Other, "{0} புதன்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} புத." }, { PluralRulesValues.Other, "{0} புத." } }));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "கடந்த வியாழன்" }, { 0, "இந்த வியாழன்" }, { 1, "அடுத்த வியாழன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வியாழனுக்கு முன்" }, { PluralRulesValues.Other, "{0} வியாழன்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வியாழனில்" }, { PluralRulesValues.Other, "{0} வியாழன்களில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "கடந்த வியா." }, { 0, "இந்த வியா." }, { 1, "அடுத்த வியா." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வியா. முன்" }, { PluralRulesValues.Other, "{0} வியா. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வியா." }, { PluralRulesValues.Other, "{0} வியா." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "கடந்த வியா." }, { 0, "இந்த வியா." }, { 1, "அடுத்த வியா." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வியா. முன்" }, { PluralRulesValues.Other, "{0} வியா. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வியா." }, { PluralRulesValues.Other, "{0} வியா." } }));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "கடந்த வெள்ளி" }, { 0, "இந்த வெள்ளி" }, { 1, "அடுத்த வெள்ளி" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வெள்ளிக்கு முன்" }, { PluralRulesValues.Other, "{0} வெள்ளிகளுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வெள்ளியில்" }, { PluralRulesValues.Other, "{0} வெள்ளிகளில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "கடந்த வெள்." }, { 0, "இந்த வெள்." }, { 1, "அடுத்த வெள்." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வெள். முன்" }, { PluralRulesValues.Other, "{0} வெள். முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வெள்." }, { PluralRulesValues.Other, "{0} வெள்." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "கடந்த வெள்." }, { 0, "இந்த வெள்." }, { 1, "அடுத்த வெள்." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வெள். முன்" }, { PluralRulesValues.Other, "{0} வெள். முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வெள்." }, { PluralRulesValues.Other, "{0} வெள்." } }));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                new Dictionary<int, string> { { -1, "கடந்த சனி" }, { 0, "இந்த சனி" }, { 1, "அடுத்த சனி" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} சனிக்கு முன்" }, { PluralRulesValues.Other, "{0} சனிகளுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} சனியில்" }, { PluralRulesValues.Other, "{0} சனிகளில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "கடந்த சனி" }, { 0, "இந்த சனி" }, { 1, "அடுத்த சனி" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} சனி. முன்" }, { PluralRulesValues.Other, "{0} சனி. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} சனி." }, { PluralRulesValues.Other, "{0} சனி." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                new Dictionary<int, string> { { -1, "கடந்த சனி" }, { 0, "இந்த சனி" }, { 1, "அடுத்த சனி" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} சனி. முன்" }, { PluralRulesValues.Other, "{0} சனி. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} சனி." }, { PluralRulesValues.Other, "{0} சனி." } }));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "முற்பகல்/பிற்பகல்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "முற்./பிற்.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "முற்./பிற்.",
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "மணி",
                new Dictionary<int, string> { { 0, "இந்த ஒரு மணிநேரத்தில்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மணிநேரம் முன்" }, { PluralRulesValues.Other, "{0} மணிநேரம் முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மணிநேரத்தில்" }, { PluralRulesValues.Other, "{0} மணிநேரத்தில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "ம.",
                new Dictionary<int, string> { { 0, "இந்த ஒரு மணிநேரத்தில்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ம. முன்" }, { PluralRulesValues.Other, "{0} ம. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ம." }, { PluralRulesValues.Other, "{0} ம." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "மணி.",
                new Dictionary<int, string> { { 0, "இந்த ஒரு மணிநேரத்தில்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மணி. முன்" }, { PluralRulesValues.Other, "{0} மணி. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} மணி." }, { PluralRulesValues.Other, "{0} மணி." } }));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "நிமிடம்",
                new Dictionary<int, string> { { 0, "இந்த ஒரு நிமிடத்தில்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நிமிடத்திற்கு முன்" }, { PluralRulesValues.Other, "{0} நிமிடங்களுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நிமிடத்தில்" }, { PluralRulesValues.Other, "{0} நிமிடங்களில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "நிமி.",
                new Dictionary<int, string> { { 0, "இந்த ஒரு நிமிடத்தில்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நி. முன்" }, { PluralRulesValues.Other, "{0} நி. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நி." }, { PluralRulesValues.Other, "{0} நி." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "நிமி.",
                new Dictionary<int, string> { { 0, "இந்த ஒரு நிமிடத்தில்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நிமி. முன்" }, { PluralRulesValues.Other, "{0} நிமி. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} நிமி." }, { PluralRulesValues.Other, "{0} நிமி." } }));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "விநாடி",
                new Dictionary<int, string> { { 0, "இப்போது" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} விநாடிக்கு முன்" }, { PluralRulesValues.Other, "{0} விநாடிகளுக்கு முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} விநாடியில்" }, { PluralRulesValues.Other, "{0} விநாடிகளில்" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "வி.",
                new Dictionary<int, string> { { 0, "இப்போது" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வி. முன்" }, { PluralRulesValues.Other, "{0} வி. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} வி." }, { PluralRulesValues.Other, "{0} வி." } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "விநா.",
                new Dictionary<int, string> { { 0, "இப்போது" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} விநா. முன்" }, { PluralRulesValues.Other, "{0} விநா. முன்" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} விநா." }, { PluralRulesValues.Other, "{0} விநா." } }));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "நேர மண்டலம்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "மண்டலம்",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "மண்டலம்",
                null,
                null,
                null));
    }
}