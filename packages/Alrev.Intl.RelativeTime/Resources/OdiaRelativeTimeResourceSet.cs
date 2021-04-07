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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Odia' [or]
    /// </summary>
    public class OdiaRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "or";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Era <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ଯୁଗ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ଯୁଗ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ଯୁଗ",
                null,
                null,
                null));

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ବର୍ଷ",
                new Dictionary<int, string> { { -1, "ଗତ ବର୍ଷ" }, { 0, "ଏହି ବର୍ଷ" }, { 1, "ଆଗାମୀ ବର୍ଷ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବର୍ଷ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବର୍ଷ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବର୍ଷରେ" }, { PluralRulesValues.Other, "{0} ବର୍ଷରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ବ.",
                new Dictionary<int, string> { { -1, "ଗତ ବର୍ଷ" }, { 0, "ଏହି ବର୍ଷ" }, { 1, "ଆଗାମୀ ବର୍ଷ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବ. ରେ" }, { PluralRulesValues.Other, "{0} ବ. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ବ.",
                new Dictionary<int, string> { { -1, "ଗତ ବର୍ଷ" }, { 0, "ଏହି ବର୍ଷ" }, { 1, "ଆଗାମୀ ବର୍ଷ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବ. ରେ" }, { PluralRulesValues.Other, "{0} ବ. ରେ" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ତ୍ରୟମାସ",
                new Dictionary<int, string> { { -1, "ଗତ ତ୍ରୟମାସ" }, { 0, "ଗତ ତ୍ରୟମାସ" }, { 1, "ଆଗାମୀ ତ୍ରୟମାସ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟମାସ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟମାସ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟମାସରେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟମାସରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ତ୍ରୟ.",
                new Dictionary<int, string> { { -1, "ଗତ ତିନିମାସ" }, { 0, "ଏହି ତିନିମାସ" }, { 1, "ଆଗାମୀ ତିନିମାସ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟ. ରେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟ. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ତ୍ରୟ.",
                new Dictionary<int, string> { { -1, "ଗତ ତିନିମାସ" }, { 0, "ଏହି ତ୍ରୟମାସ" }, { 1, "ଆଗାମୀ ତ୍ରୟମାସ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟ. ରେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟ. ରେ" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ମାସ",
                new Dictionary<int, string> { { -1, "ଗତ ମାସ" }, { 0, "ଏହି ମାସ" }, { 1, "ଆଗାମୀ ମାସ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମାସ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମାସ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମାସରେ" }, { PluralRulesValues.Other, "{0} ମାସରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ମା.",
                new Dictionary<int, string> { { -1, "ଗତ ମାସ" }, { 0, "ଏହି ମାସ" }, { 1, "ଆଗାମୀ ମାସ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମା. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମା. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମା. ରେ" }, { PluralRulesValues.Other, "{0} ମା. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ମା.",
                new Dictionary<int, string> { { -1, "ଗତ ମାସ" }, { 0, "ଏହି ମାସ" }, { 1, "ଆଗାମୀ ମାସ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମା. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମା. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମା. ରେ" }, { PluralRulesValues.Other, "{0} ମା. ରେ" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ସପ୍ତାହ",
                new Dictionary<int, string> { { -1, "ଗତ ସପ୍ତାହ" }, { 0, "ଏହି ସପ୍ତାହ" }, { 1, "ଆଗାମୀ ସପ୍ତାହ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତାହରେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତାହ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତାହରେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତାହରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ସ.",
                new Dictionary<int, string> { { -1, "ଗତ ସପ୍ତାହ" }, { 0, "ଏହି ସପ୍ତାହ" }, { 1, "ଆଗାମୀ ସପ୍ତାହ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତା. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତା. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତା. ରେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତା. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ସ.",
                new Dictionary<int, string> { { -1, "ଗତ ସପ୍ତାହ" }, { 0, "ଏହି ସପ୍ତାହ" }, { 1, "ଆଗାମୀ ସପ୍ତାହ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତା. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତା. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତା. ରେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତା. ରେ" } }));

        /// <summary>
        /// Gets WeekOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ମାସର ସପ୍ତାହ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ମା. ର ସ.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ମା. ର ସ.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ଦିନ",
                new Dictionary<int, string> { { -1, "ଗତକାଲି" }, { 0, "ଆଜି" }, { 1, "ଆସନ୍ତାକାଲି" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଦିନ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନରେ" }, { PluralRulesValues.Other, "{0} ଦିନରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ଦିନ",
                new Dictionary<int, string> { { -1, "ଗତକାଲି" }, { 0, "ଆଜି" }, { 1, "ଆସନ୍ତାକାଲି" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଦିନ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନରେ" }, { PluralRulesValues.Other, "{0} ଦିନରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ଦିନ",
                new Dictionary<int, string> { { -1, "ଗତକାଲି" }, { 0, "ଆଜି" }, { 1, "ଆସନ୍ତାକାଲି" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଦିନ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନରେ" }, { PluralRulesValues.Other, "{0} ଦିନରେ" } }));

        /// <summary>
        /// Gets DayOfYear <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ବର୍ଷର ଦିନ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ବ. ର ଦିନ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ବ. ର ଦିନ",
                null,
                null,
                null));

        /// <summary>
        /// Gets Weekday <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ସ. ର ଦିନ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ସ. ର ଦିନ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ସ. ର ଦିନ",
                null,
                null,
                null));

        /// <summary>
        /// Gets WeekdayOfMonth <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ସାପ୍ତାହିକ ଦିନର ମାସ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ସା. ଦିନର ମା.",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ସା. ଦିନର ମା.",
                null,
                null,
                null));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ରବିବାର" }, { 0, "ଏହି ରବିବାର" }, { 1, "ଆଗାମୀ ରବିବାର" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବିବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ରବିବାର ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବିବାରରେ" }, { PluralRulesValues.Other, "{0} ରବିବାରରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ରବି." }, { 0, "ଏହି ରବି." }, { 1, "ଆଗାମୀ ରବି." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ରବି. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବି. ରେ" }, { PluralRulesValues.Other, "{0} ରବି. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ରବି." }, { 0, "ଏହି ରବି." }, { 1, "ଆଗାମୀ ରବି." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ରବି. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବି. ରେ" }, { PluralRulesValues.Other, "{0} ରବି. ରେ" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ସୋମବାର" }, { 0, "ଏହି ସୋମବାର" }, { 1, "ଆସନ୍ତା ସୋମବାର" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋମବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସୋମବାର ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋମବାରରେ" }, { PluralRulesValues.Other, "{0} ସୋମବାରରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ସୋ" }, { 0, "ଏହି ସୋ" }, { 1, "ଆସନ୍ତା ସୋ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସୋ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋ ରେ" }, { PluralRulesValues.Other, "{0} ସୋ ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ସୋମ." }, { 0, "ଏହି ସୋମ." }, { 1, "ଆସନ୍ତା ସୋମ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋମ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସୋମ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋମ. ରେ" }, { PluralRulesValues.Other, "{0} ସୋମ. ରେ" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ମଙ୍ଗଳବାର" }, { 0, "ଏହି ମଙ୍ଗଳବାର" }, { 1, "ଆଗାମୀ ମଙ୍ଗଳବାର" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳବାର ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳବାରରେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳବାରରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ମଙ୍ଗଳ." }, { 0, "ଏହି ମଙ୍ଗଳ." }, { 1, "ଆଗାମୀ ମଙ୍ଗଳ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳ. ରେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳ. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ମଙ୍ଗଳ." }, { 0, "ଏହି ମଙ୍ଗଳ." }, { 1, "ଆଗାମୀ ମଙ୍ଗଳ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳ. ରେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳ. ରେ" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ବୁଧବାର" }, { 0, "ଏହି ବୁଧବାର" }, { 1, "ଆସନ୍ତା ବୁଧବାର" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବୁଧବାର ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧବାରରେ" }, { PluralRulesValues.Other, "{0} ବୁଧବାରରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ବୁଧ" }, { 0, "ଏହି ବୁଧ" }, { 1, "ଆସନ୍ତା ବୁଧ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବୁଧ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧ. ରେ" }, { PluralRulesValues.Other, "{0} ବୁଧ. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ବୁଧ." }, { 0, "ଏହି ବୁଧ." }, { 1, "ଆସନ୍ତା ବୁଧ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବୁଧ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧ. ରେ" }, { PluralRulesValues.Other, "{0} ବୁଧ. ରେ" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ଗୁରୁବାର" }, { 0, "ଏହି ଗୁରୁବାର" }, { 1, "ଆଗାମୀ ଗୁରୁବାର" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁବାର ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁବାରରେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁବାରରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ଗୁରୁ." }, { 0, "ଏହି ଗୁରୁ." }, { 1, "ଆଗାମୀ ଗୁରୁ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁ. ରେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁ. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ଗୁରୁ." }, { 0, "ଏହି ଗୁରୁ." }, { 1, "ଆଗାମୀ ଗୁରୁ." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁ. ରେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁ. ରେ" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ଶୁକ୍ରବାର" }, { 0, "ଏହି ଶୁକ୍ରବାର" }, { 1, "ଆଗାମୀ ଶୁକ୍ରବାର" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ରବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ରବାର ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ରବାରରେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ରବାରରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ଶୁକ୍ର." }, { 0, "ଏହି ଶୁକ୍ର." }, { 1, "ଆଗାମୀ ଶୁକ୍ର." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶୁ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ର. ରେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ର. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ଶୁକ୍ର." }, { 0, "ଏହି ଶୁକ୍ର." }, { 1, "ଆଗାମୀ ଶୁକ୍ର." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ର. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ର. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ର. ରେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ର. ରେ" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ଶନିବାର" }, { 0, "ଏହି ଶନିବାର" }, { 1, "ଆଗାମୀ ଶନିବାର" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନିବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶନିବାର ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନିବାରରେ" }, { PluralRulesValues.Other, "{0} ଶନିବାରରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ଶନି." }, { 0, "ଏହି ଶନି." }, { 1, "ଆଗାମୀ ଶନି." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶନି. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନି. ରେ" }, { PluralRulesValues.Other, "{0} ଶନି. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                null,
                new Dictionary<int, string> { { -1, "ଗତ ଶନି." }, { 0, "ଏହି ଶନି." }, { 1, "ଆଗାମୀ ଶନି." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶନି. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନି. ରେ" }, { PluralRulesValues.Other, "{0} ଶନି. ରେ" } }));

        /// <summary>
        /// Gets DayPeriod <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ପୂର୍ବାହ୍ନ/ଅପରାହ୍ନ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ପୂର୍ବାହ୍ନ/ଅପରାହ୍ନ",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ପୂର୍ବାହ୍ନ/ଅପରାହ୍ନ",
                null,
                null,
                null));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ଘଣ୍ଟା",
                new Dictionary<int, string> { { 0, "ଏହି ଘଣ୍ଟା" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘଣ୍ଟା ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଘଣ୍ଟା ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘଣ୍ଟାରେ" }, { PluralRulesValues.Other, "{0} ଘଣ୍ଟାରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ଘ.",
                new Dictionary<int, string> { { 0, "ଏହି ଘଣ୍ଟା" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଘ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘ. ରେ" }, { PluralRulesValues.Other, "{0} ଘ. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ଘ.",
                new Dictionary<int, string> { { 0, "ଏହି ଘଣ୍ଟା" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଘ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘ. ରେ" }, { PluralRulesValues.Other, "{0} ଘ. ରେ" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ମିନିଟ୍",
                new Dictionary<int, string> { { 0, "ଏହି ମିନିଟ୍" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମିନିଟ୍ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମିନିଟ୍ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମିନିଟ୍‌‌ରେ" }, { PluralRulesValues.Other, "{0} ମିନିଟ୍‌‌ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ମି.",
                new Dictionary<int, string> { { 0, "ଏହି ମିନିଟ୍" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମି. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମି. ରେ" }, { PluralRulesValues.Other, "{0} ମି. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ମି.",
                new Dictionary<int, string> { { 0, "ଏହି ମିନିଟ୍" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମି. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମି. ରେ" }, { PluralRulesValues.Other, "{0} ମି. ରେ" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ସେକେଣ୍ଡ୍",
                new Dictionary<int, string> { { 0, "ବର୍ତ୍ତମାନ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେକେଣ୍ଡ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସେକେଣ୍ଡ ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେକେଣ୍ଡରେ" }, { PluralRulesValues.Other, "{0} ସେକେଣ୍ଡରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "ସେ.",
                new Dictionary<int, string> { { 0, "ବର୍ତ୍ତମାନ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସେ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେ. ରେ" }, { PluralRulesValues.Other, "{0} ସେ. ରେ" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "ସେକେଣ୍ଡ୍",
                new Dictionary<int, string> { { 0, "ବର୍ତ୍ତମାନ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସେ. ପୂର୍ବେ" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେ. ରେ" }, { PluralRulesValues.Other, "{0} ସେ. ରେ" } }));

        /// <summary>
        /// Gets Zone <see cref="IRelativeTimeStylesResource"/> for 'Odia' [or]
        /// </summary>
        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Long,
                "ସମୟ କ୍ଷେତ୍ର",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Narrow,
                "କ୍ଷେତ୍ର",
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeStylesValues.Short,
                "କ୍ଷେତ୍ର",
                null,
                null,
                null));
    }
}