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
    /// <see cref="IRelativeTimeResourceSet"/> for 'Turkish (Cyprus)' [tr-cy]
    /// </summary>
    public class TurkishCyprusRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "tr-cy";

        /// <summary>
        /// The <see cref="IRelativeTimeResourceSet"/> locale
        /// </summary>
        public string Locale { get; } = LOCALE;

        /// <summary>
        /// Gets Year <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Year,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Long,
                "yıl",
                new Dictionary<int, string> { { -1, "geçen yıl" }, { 0, "bu yıl" }, { 1, "gelecek yıl" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yıl önce" }, { PluralRulesValues.Other, "{0} yıl önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yıl sonra" }, { PluralRulesValues.Other, "{0} yıl sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Narrow,
                "yıl",
                new Dictionary<int, string> { { -1, "geçen yıl" }, { 0, "bu yıl" }, { 1, "gelecek yıl" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yıl önce" }, { PluralRulesValues.Other, "{0} yıl önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yıl sonra" }, { PluralRulesValues.Other, "{0} yıl sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Year,
                RelativeTimeStyleValues.Short,
                "yıl",
                new Dictionary<int, string> { { -1, "geçen yıl" }, { 0, "bu yıl" }, { 1, "gelecek yıl" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yıl önce" }, { PluralRulesValues.Other, "{0} yıl önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yıl sonra" }, { PluralRulesValues.Other, "{0} yıl sonra" } }));

        /// <summary>
        /// Gets Quarter <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Quarter,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Long,
                "çeyrek",
                new Dictionary<int, string> { { -1, "geçen çeyrek" }, { 0, "bu çeyrek" }, { 1, "gelecek çeyrek" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çeyrek önce" }, { PluralRulesValues.Other, "{0} çeyrek önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çeyrek sonra" }, { PluralRulesValues.Other, "{0} çeyrek sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Narrow,
                "çyr.",
                new Dictionary<int, string> { { -1, "geçen çyr." }, { 0, "bu çyr." }, { 1, "gelecek çyr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çyr. önce" }, { PluralRulesValues.Other, "{0} çyr. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çyr. sonra" }, { PluralRulesValues.Other, "{0} çyr. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Quarter,
                RelativeTimeStyleValues.Short,
                "çyr.",
                new Dictionary<int, string> { { -1, "geçen çyr." }, { 0, "bu çyr." }, { 1, "gelecek çyr." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çyr. önce" }, { PluralRulesValues.Other, "{0} çyr. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çyr. sonra" }, { PluralRulesValues.Other, "{0} çyr. sonra" } }));

        /// <summary>
        /// Gets Month <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Month,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Long,
                "ay",
                new Dictionary<int, string> { { -1, "geçen ay" }, { 0, "bu ay" }, { 1, "gelecek ay" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ay önce" }, { PluralRulesValues.Other, "{0} ay önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ay sonra" }, { PluralRulesValues.Other, "{0} ay sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Narrow,
                "ay",
                new Dictionary<int, string> { { -1, "geçen ay" }, { 0, "bu ay" }, { 1, "gelecek ay" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ay önce" }, { PluralRulesValues.Other, "{0} ay önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ay sonra" }, { PluralRulesValues.Other, "{0} ay sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Month,
                RelativeTimeStyleValues.Short,
                "ay",
                new Dictionary<int, string> { { -1, "geçen ay" }, { 0, "bu ay" }, { 1, "gelecek ay" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ay önce" }, { PluralRulesValues.Other, "{0} ay önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ay sonra" }, { PluralRulesValues.Other, "{0} ay sonra" } }));

        /// <summary>
        /// Gets Week <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Week,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Long,
                "hafta",
                new Dictionary<int, string> { { -1, "geçen hafta" }, { 0, "bu hafta" }, { 1, "gelecek hafta" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hafta önce" }, { PluralRulesValues.Other, "{0} hafta önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hafta sonra" }, { PluralRulesValues.Other, "{0} hafta sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Narrow,
                "hf.",
                new Dictionary<int, string> { { -1, "geçen hf." }, { 0, "bu hf." }, { 1, "gelecek hf." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hf. önce" }, { PluralRulesValues.Other, "{0} hf. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hf. sonra" }, { PluralRulesValues.Other, "{0} hf. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Week,
                RelativeTimeStyleValues.Short,
                "hf.",
                new Dictionary<int, string> { { -1, "geçen hf." }, { 0, "bu hf." }, { 1, "gelecek hf." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hf. önce" }, { PluralRulesValues.Other, "{0} hf. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hf. sonra" }, { PluralRulesValues.Other, "{0} hf. sonra" } }));

        /// <summary>
        /// Gets Day <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Day,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Long,
                "gün",
                new Dictionary<int, string> { { -2, "evvelsi gün" }, { -1, "dün" }, { 0, "bugün" }, { 1, "yarın" }, { 2, "öbür gün" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} gün önce" }, { PluralRulesValues.Other, "{0} gün önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} gün sonra" }, { PluralRulesValues.Other, "{0} gün sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Narrow,
                "gün",
                new Dictionary<int, string> { { -2, "evvelsi gün" }, { -1, "dün" }, { 0, "bugün" }, { 1, "yarın" }, { 2, "öbür gün" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} gün önce" }, { PluralRulesValues.Other, "{0} gün önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} gün sonra" }, { PluralRulesValues.Other, "{0} gün sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Day,
                RelativeTimeStyleValues.Short,
                "gün",
                new Dictionary<int, string> { { -2, "evvelsi gün" }, { -1, "dün" }, { 0, "bugün" }, { 1, "yarın" }, { 2, "öbür gün" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} gün önce" }, { PluralRulesValues.Other, "{0} gün önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} gün sonra" }, { PluralRulesValues.Other, "{0} gün sonra" } }));

        /// <summary>
        /// Gets Sunday <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Sunday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "geçen pazar" }, { 0, "bu pazar" }, { 1, "gelecek pazar" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pazar önce" }, { PluralRulesValues.Other, "{0} pazar önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pazar sonra" }, { PluralRulesValues.Other, "{0} pazar sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "geçen paz." }, { 0, "bu paz." }, { 1, "gelecek paz." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} paz. önce" }, { PluralRulesValues.Other, "{0} paz. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} paz. sonra" }, { PluralRulesValues.Other, "{0} paz. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Sunday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "geçen paz." }, { 0, "bu paz." }, { 1, "gelecek paz." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} paz. önce" }, { PluralRulesValues.Other, "{0} paz. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} paz. sonra" }, { PluralRulesValues.Other, "{0} paz. sonra" } }));

        /// <summary>
        /// Gets Monday <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Monday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "geçen pazartesi" }, { 0, "bu pazartesi" }, { 1, "gelecek pazartesi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pazartesi önce" }, { PluralRulesValues.Other, "{0} pazartesi önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pazartesi sonra" }, { PluralRulesValues.Other, "{0} pazartesi sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "geçen pzt." }, { 0, "bu pzt." }, { 1, "gelecek pzt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pzt. önce" }, { PluralRulesValues.Other, "{0} pzt. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pzt. sonra" }, { PluralRulesValues.Other, "{0} pzt. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Monday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "geçen pzt." }, { 0, "bu pzt." }, { 1, "gelecek pzt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pzt. önce" }, { PluralRulesValues.Other, "{0} pzt. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pzt. sonra" }, { PluralRulesValues.Other, "{0} pzt. sonra" } }));

        /// <summary>
        /// Gets Tuesday <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Tuesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "geçen salı" }, { 0, "bu salı" }, { 1, "gelecek salı" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} salı önce" }, { PluralRulesValues.Other, "{0} salı önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} salı sonra" }, { PluralRulesValues.Other, "{0} salı sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "geçen salı" }, { 0, "bu salı" }, { 1, "gelecek salı" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} salı önce" }, { PluralRulesValues.Other, "{0} salı önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} salı sonra" }, { PluralRulesValues.Other, "{0} salı sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Tuesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "geçen salı" }, { 0, "bu salı" }, { 1, "gelecek salı" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} salı önce" }, { PluralRulesValues.Other, "{0} salı önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} salı sonra" }, { PluralRulesValues.Other, "{0} salı sonra" } }));

        /// <summary>
        /// Gets Wednesday <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Wednesday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "geçen çarşamba" }, { 0, "bu çarşamba" }, { 1, "gelecek çarşamba" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çarşamba önce" }, { PluralRulesValues.Other, "{0} çarşamba önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çarşamba sonra" }, { PluralRulesValues.Other, "{0} çarşamba sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "geçen çar." }, { 0, "bu çar." }, { 1, "gelecek çar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çar. önce" }, { PluralRulesValues.Other, "{0} çar. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çar. sonra" }, { PluralRulesValues.Other, "{0} çar. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Wednesday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "geçen çar." }, { 0, "bu çar." }, { 1, "gelecek çar." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çar. önce" }, { PluralRulesValues.Other, "{0} çar. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çar. sonra" }, { PluralRulesValues.Other, "{0} çar. sonra" } }));

        /// <summary>
        /// Gets Thursday <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Thursday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "geçen perşembe" }, { 0, "bu perşembe" }, { 1, "gelecek perşembe" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perşembe önce" }, { PluralRulesValues.Other, "{0} perşembe önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perşembe sonra" }, { PluralRulesValues.Other, "{0} perşembe sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "geçen per." }, { 0, "bu per." }, { 1, "gelecek per." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} per. önce" }, { PluralRulesValues.Other, "{0} per. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} per. sonra" }, { PluralRulesValues.Other, "{0} per. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Thursday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "geçen per." }, { 0, "bu per." }, { 1, "gelecek per." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} per. önce" }, { PluralRulesValues.Other, "{0} per. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} per. sonra" }, { PluralRulesValues.Other, "{0} per. sonra" } }));

        /// <summary>
        /// Gets Friday <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Friday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "geçen cuma" }, { 0, "bu cuma" }, { 1, "gelecek cuma" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cuma önce" }, { PluralRulesValues.Other, "{0} cuma önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cuma sonra" }, { PluralRulesValues.Other, "{0} cuma sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "geçen cuma" }, { 0, "bu cuma" }, { 1, "gelecek cuma" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cuma önce" }, { PluralRulesValues.Other, "{0} cuma önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cuma sonra" }, { PluralRulesValues.Other, "{0} cuma sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Friday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "geçen cuma" }, { 0, "bu cuma" }, { 1, "gelecek cuma" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cuma önce" }, { PluralRulesValues.Other, "{0} cuma önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cuma sonra" }, { PluralRulesValues.Other, "{0} cuma sonra" } }));

        /// <summary>
        /// Gets Saturday <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Saturday,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Long,
                null,
                new Dictionary<int, string> { { -1, "geçen cumartesi" }, { 0, "bu cumartesi" }, { 1, "gelecek cumartesi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cumartesi önce" }, { PluralRulesValues.Other, "{0} cumartesi önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cumartesi sonra" }, { PluralRulesValues.Other, "{0} cumartesi sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Narrow,
                null,
                new Dictionary<int, string> { { -1, "geçen cmt." }, { 0, "bu cmt." }, { 1, "gelecek cmt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cmt. önce" }, { PluralRulesValues.Other, "{0} cmt. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cmt. sonra" }, { PluralRulesValues.Other, "{0} cmt. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Saturday,
                RelativeTimeStyleValues.Short,
                null,
                new Dictionary<int, string> { { -1, "geçen cmt." }, { 0, "bu cmt." }, { 1, "gelecek cmt." } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cmt. önce" }, { PluralRulesValues.Other, "{0} cmt. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} cmt. sonra" }, { PluralRulesValues.Other, "{0} cmt. sonra" } }));

        /// <summary>
        /// Gets Hour <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Hour,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Long,
                "saat",
                new Dictionary<int, string> { { 0, "bu saat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} saat önce" }, { PluralRulesValues.Other, "{0} saat önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} saat sonra" }, { PluralRulesValues.Other, "{0} saat sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Narrow,
                "sa.",
                new Dictionary<int, string> { { 0, "bu saat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sa. önce" }, { PluralRulesValues.Other, "{0} sa. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sa. sonra" }, { PluralRulesValues.Other, "{0} sa. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Hour,
                RelativeTimeStyleValues.Short,
                "sa.",
                new Dictionary<int, string> { { 0, "bu saat" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sa. önce" }, { PluralRulesValues.Other, "{0} sa. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sa. sonra" }, { PluralRulesValues.Other, "{0} sa. sonra" } }));

        /// <summary>
        /// Gets Minute <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Minute,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Long,
                "dakika",
                new Dictionary<int, string> { { 0, "bu dakika" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dakika önce" }, { PluralRulesValues.Other, "{0} dakika önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dakika sonra" }, { PluralRulesValues.Other, "{0} dakika sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Narrow,
                "dk.",
                new Dictionary<int, string> { { 0, "bu dakika" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dk. önce" }, { PluralRulesValues.Other, "{0} dk. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dk. sonra" }, { PluralRulesValues.Other, "{0} dk. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Minute,
                RelativeTimeStyleValues.Short,
                "dk.",
                new Dictionary<int, string> { { 0, "bu dakika" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dk. önce" }, { PluralRulesValues.Other, "{0} dk. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dk. sonra" }, { PluralRulesValues.Other, "{0} dk. sonra" } }));

        /// <summary>
        /// Gets Second <see cref="IRelativeTimeStylesResource"/> for 'Turkish (Cyprus)' [tr-cy]
        /// </summary>
        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            RelativeTimeUnitValues.Second,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Long,
                "saniye",
                new Dictionary<int, string> { { 0, "şimdi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} saniye önce" }, { PluralRulesValues.Other, "{0} saniye önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} saniye sonra" }, { PluralRulesValues.Other, "{0} saniye sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Narrow,
                "sn.",
                new Dictionary<int, string> { { 0, "şimdi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sn. önce" }, { PluralRulesValues.Other, "{0} sn. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sn. sonra" }, { PluralRulesValues.Other, "{0} sn. sonra" } }),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeUnitValues.Second,
                RelativeTimeStyleValues.Short,
                "sn.",
                new Dictionary<int, string> { { 0, "şimdi" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sn. önce" }, { PluralRulesValues.Other, "{0} sn. önce" } },
                new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sn. sonra" }, { PluralRulesValues.Other, "{0} sn. sonra" } }));

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