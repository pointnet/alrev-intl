//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Script: ./scripts/cldr-plural-rules.csx
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.PluralRules.Resources.Cardinals;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Alrev.Intl.PluralRules.Globalization
{
    /// <summary>
    /// The Cardinal plural rules localizer
    /// </summary>
    public class PluralRulesCardinalLocalizer : ReadOnlyDictionary<string, IPluralRulesResource>, IResourceSetLocalizer<IPluralRulesResource>
    {
        private PluralRulesCardinalLocalizer(IDictionary<string, IPluralRulesResource> dictionary) : base(dictionary) { }
    
        /// <summary>
        /// The class constructor
        /// </summary>
        public PluralRulesCardinalLocalizer() : this(new Dictionary<string, IPluralRulesResource>
        {
            { "af", new AfrikaansPluralRulesCardinalResource() },
            { "ak", new AkanPluralRulesCardinalResource() },
            { "am", new AmharicPluralRulesCardinalResource() },
            { "ar", new ArabicPluralRulesCardinalResource() },
            { "as", new AssamesePluralRulesCardinalResource() },
            { "asa", new AsuPluralRulesCardinalResource() },
            { "ast", new AsturianPluralRulesCardinalResource() },
            { "az", new AzerbaijaniPluralRulesCardinalResource() },
            { "be", new BelarusianPluralRulesCardinalResource() },
            { "bem", new BembaPluralRulesCardinalResource() },
            { "bez", new BenaPluralRulesCardinalResource() },
            { "bg", new BulgarianPluralRulesCardinalResource() },
            { "bm", new BamanankanPluralRulesCardinalResource() },
            { "bn", new BanglaPluralRulesCardinalResource() },
            { "bo", new TibetanPluralRulesCardinalResource() },
            { "br", new BretonPluralRulesCardinalResource() },
            { "brx", new BodoPluralRulesCardinalResource() },
            { "bs", new BosnianPluralRulesCardinalResource() },
            { "ca", new CatalanPluralRulesCardinalResource() },
            { "ce", new ChechenPluralRulesCardinalResource() },
            { "ceb", new CebuanoPluralRulesCardinalResource() },
            { "cgg", new ChigaPluralRulesCardinalResource() },
            { "chr", new CherokeePluralRulesCardinalResource() },
            { "ku", new KurdishPluralRulesCardinalResource() },
            { "cs", new CzechPluralRulesCardinalResource() },
            { "cy", new WelshPluralRulesCardinalResource() },
            { "da", new DanishPluralRulesCardinalResource() },
            { "de", new GermanPluralRulesCardinalResource() },
            { "dsb", new LowerSorbianPluralRulesCardinalResource() },
            { "dv", new DivehiPluralRulesCardinalResource() },
            { "dz", new DzongkhaPluralRulesCardinalResource() },
            { "ee", new EwePluralRulesCardinalResource() },
            { "el", new GreekPluralRulesCardinalResource() },
            { "en", new EnglishPluralRulesCardinalResource() },
            { "eo", new EsperantoPluralRulesCardinalResource() },
            { "es", new SpanishPluralRulesCardinalResource() },
            { "et", new EstonianPluralRulesCardinalResource() },
            { "eu", new BasquePluralRulesCardinalResource() },
            { "fa", new PersianPluralRulesCardinalResource() },
            { "ff", new FulahPluralRulesCardinalResource() },
            { "fi", new FinnishPluralRulesCardinalResource() },
            { "fil", new FilipinoPluralRulesCardinalResource() },
            { "fo", new FaroesePluralRulesCardinalResource() },
            { "fr", new FrenchPluralRulesCardinalResource() },
            { "fur", new FriulianPluralRulesCardinalResource() },
            { "fy", new WesternFrisianPluralRulesCardinalResource() },
            { "ga", new IrishPluralRulesCardinalResource() },
            { "gd", new ScottishGaelicPluralRulesCardinalResource() },
            { "gl", new GalicianPluralRulesCardinalResource() },
            { "gsw", new SwissGermanPluralRulesCardinalResource() },
            { "gu", new GujaratiPluralRulesCardinalResource() },
            { "gv", new ManxPluralRulesCardinalResource() },
            { "ha", new HausaPluralRulesCardinalResource() },
            { "haw", new HawaiianPluralRulesCardinalResource() },
            { "he", new HebrewPluralRulesCardinalResource() },
            { "hi", new HindiPluralRulesCardinalResource() },
            { "hr", new CroatianPluralRulesCardinalResource() },
            { "hsb", new UpperSorbianPluralRulesCardinalResource() },
            { "hu", new HungarianPluralRulesCardinalResource() },
            { "hy", new ArmenianPluralRulesCardinalResource() },
            { "ia", new InterlinguaPluralRulesCardinalResource() },
            { "id", new IndonesianPluralRulesCardinalResource() },
            { "ig", new IgboPluralRulesCardinalResource() },
            { "ii", new YiPluralRulesCardinalResource() },
            { "is", new IcelandicPluralRulesCardinalResource() },
            { "it", new ItalianPluralRulesCardinalResource() },
            { "iu", new InuktitutPluralRulesCardinalResource() },
            { "ja", new JapanesePluralRulesCardinalResource() },
            { "jgo", new NgombaPluralRulesCardinalResource() },
            { "jmc", new MachamePluralRulesCardinalResource() },
            { "jv", new JavanesePluralRulesCardinalResource() },
            { "ka", new GeorgianPluralRulesCardinalResource() },
            { "kab", new KabylePluralRulesCardinalResource() },
            { "kde", new MakondePluralRulesCardinalResource() },
            { "kea", new KabuverdianuPluralRulesCardinalResource() },
            { "kk", new KazakhPluralRulesCardinalResource() },
            { "kkj", new KakoPluralRulesCardinalResource() },
            { "kl", new KalaallisutPluralRulesCardinalResource() },
            { "km", new KhmerPluralRulesCardinalResource() },
            { "kn", new KannadaPluralRulesCardinalResource() },
            { "ko", new KoreanPluralRulesCardinalResource() },
            { "ks", new KashmiriPluralRulesCardinalResource() },
            { "ksb", new ShambalaPluralRulesCardinalResource() },
            { "ksh", new ColognianPluralRulesCardinalResource() },
            { "kw", new CornishPluralRulesCardinalResource() },
            { "ky", new KyrgyzPluralRulesCardinalResource() },
            { "lag", new LangiPluralRulesCardinalResource() },
            { "lb", new LuxembourgishPluralRulesCardinalResource() },
            { "lg", new GandaPluralRulesCardinalResource() },
            { "lkt", new LakotaPluralRulesCardinalResource() },
            { "ln", new LingalaPluralRulesCardinalResource() },
            { "lo", new LaoPluralRulesCardinalResource() },
            { "lt", new LithuanianPluralRulesCardinalResource() },
            { "lv", new LatvianPluralRulesCardinalResource() },
            { "mas", new MasaiPluralRulesCardinalResource() },
            { "mg", new MalagasyPluralRulesCardinalResource() },
            { "mgo", new MetaPluralRulesCardinalResource() },
            { "mk", new MacedonianPluralRulesCardinalResource() },
            { "ml", new MalayalamPluralRulesCardinalResource() },
            { "mn", new MongolianPluralRulesCardinalResource() },
            { "mr", new MarathiPluralRulesCardinalResource() },
            { "ms", new MalayPluralRulesCardinalResource() },
            { "mt", new MaltesePluralRulesCardinalResource() },
            { "my", new BurmesePluralRulesCardinalResource() },
            { "naq", new NamaPluralRulesCardinalResource() },
            { "nb", new NorwegianBokmalPluralRulesCardinalResource() },
            { "nd", new NorthNdebelePluralRulesCardinalResource() },
            { "ne", new NepaliPluralRulesCardinalResource() },
            { "nl", new DutchPluralRulesCardinalResource() },
            { "nn", new NorwegianNynorskPluralRulesCardinalResource() },
            { "nnh", new NgiemboonPluralRulesCardinalResource() },
            { "nqo", new NKoPluralRulesCardinalResource() },
            { "nr", new SouthNdebelePluralRulesCardinalResource() },
            { "nso", new SesothosaLeboaPluralRulesCardinalResource() },
            { "nyn", new NyankolePluralRulesCardinalResource() },
            { "om", new OromoPluralRulesCardinalResource() },
            { "or", new OdiaPluralRulesCardinalResource() },
            { "os", new OsseticPluralRulesCardinalResource() },
            { "pa", new PunjabiPluralRulesCardinalResource() },
            { "pl", new PolishPluralRulesCardinalResource() },
            { "prg", new PrussianPluralRulesCardinalResource() },
            { "ps", new PashtoPluralRulesCardinalResource() },
            { "pt", new PortuguesePluralRulesCardinalResource() },
            { "pt-PT", new PortuguesePortugalPluralRulesCardinalResource() },
            { "rm", new RomanshPluralRulesCardinalResource() },
            { "ro", new RomanianPluralRulesCardinalResource() },
            { "rof", new RomboPluralRulesCardinalResource() },
            { "ru", new RussianPluralRulesCardinalResource() },
            { "rwk", new RwaPluralRulesCardinalResource() },
            { "sah", new SakhaPluralRulesCardinalResource() },
            { "saq", new SamburuPluralRulesCardinalResource() },
            { "sd", new SindhiPluralRulesCardinalResource() },
            { "se", new NorthernSamiPluralRulesCardinalResource() },
            { "seh", new SenaPluralRulesCardinalResource() },
            { "ses", new KoyraboroSenniPluralRulesCardinalResource() },
            { "sg", new SangoPluralRulesCardinalResource() },
            { "shi", new TachelhitPluralRulesCardinalResource() },
            { "si", new SinhalaPluralRulesCardinalResource() },
            { "sk", new SlovakPluralRulesCardinalResource() },
            { "sl", new SlovenianPluralRulesCardinalResource() },
            { "sma", new SouthernSamiPluralRulesCardinalResource() },
            { "smj", new LuleSamiPluralRulesCardinalResource() },
            { "smn", new InariSamiPluralRulesCardinalResource() },
            { "sms", new SkoltSamiPluralRulesCardinalResource() },
            { "sn", new ShonaPluralRulesCardinalResource() },
            { "so", new SomaliPluralRulesCardinalResource() },
            { "sq", new AlbanianPluralRulesCardinalResource() },
            { "sr", new SerbianPluralRulesCardinalResource() },
            { "ss", new SiSwatiPluralRulesCardinalResource() },
            { "ssy", new SahoPluralRulesCardinalResource() },
            { "st", new SesothoPluralRulesCardinalResource() },
            { "sv", new SwedishPluralRulesCardinalResource() },
            { "sw", new KiswahiliPluralRulesCardinalResource() },
            { "syr", new SyriacPluralRulesCardinalResource() },
            { "ta", new TamilPluralRulesCardinalResource() },
            { "te", new TeluguPluralRulesCardinalResource() },
            { "teo", new TesoPluralRulesCardinalResource() },
            { "th", new ThaiPluralRulesCardinalResource() },
            { "ti", new TigrinyaPluralRulesCardinalResource() },
            { "tig", new TigrePluralRulesCardinalResource() },
            { "tk", new TurkmenPluralRulesCardinalResource() },
            { "tn", new SetswanaPluralRulesCardinalResource() },
            { "to", new TonganPluralRulesCardinalResource() },
            { "tr", new TurkishPluralRulesCardinalResource() },
            { "ts", new XitsongaPluralRulesCardinalResource() },
            { "tzm", new CentralAtlasTamazightPluralRulesCardinalResource() },
            { "ug", new UyghurPluralRulesCardinalResource() },
            { "uk", new UkrainianPluralRulesCardinalResource() },
            { "ur", new UrduPluralRulesCardinalResource() },
            { "uz", new UzbekPluralRulesCardinalResource() },
            { "ve", new VendaPluralRulesCardinalResource() },
            { "vi", new VietnamesePluralRulesCardinalResource() },
            { "vo", new VolapukPluralRulesCardinalResource() },
            { "vun", new VunjoPluralRulesCardinalResource() },
            { "wae", new WalserPluralRulesCardinalResource() },
            { "wo", new WolofPluralRulesCardinalResource() },
            { "xh", new IsiXhosaPluralRulesCardinalResource() },
            { "xog", new SogaPluralRulesCardinalResource() },
            { "yi", new YiddishPluralRulesCardinalResource() },
            { "yo", new YorubaPluralRulesCardinalResource() },
            { "zh", new ChinesePluralRulesCardinalResource() },
            { "zu", new IsiZuluPluralRulesCardinalResource() },
        })
        { }
    
        /// <summary>
        /// Gets the <see cref="IPluralRulesResource"/> for the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/></param>
        /// <returns>An <see cref="IPluralRulesResource"/> for the specified <see cref="CultureInfo"/> or null</returns>
        /// <remarks>
        /// If the specified <see cref="CultureInfo"/> does not exists, it will try to use the parent <see cref="CultureInfo"/> of the specified one.
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public IPluralRulesResource GetLocalizer(CultureInfo culture) => culture switch 
        {
            null => throw new ArgumentNullException("CultureInfo must not be null", nameof(culture)),
            CultureInfo c when string.IsNullOrEmpty(c.Name) => throw new ArgumentException("CultureInfo.InvariantCulture is not supported", nameof(culture)),
            _ => this.GetValueOrDefault(culture.Name, null) ?? this.GetValueOrDefault(culture.Parent.Name, null)
        };
    }
}