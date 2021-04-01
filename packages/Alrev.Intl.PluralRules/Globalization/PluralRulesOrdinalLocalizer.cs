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
using Alrev.Intl.PluralRules.Resources.Ordinals;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Alrev.Intl.PluralRules.Globalization
{
    public class PluralRulesOrdinalLocalizer : ReadOnlyDictionary<string, IPluralRulesResource>, IResourceSetLocalizer<IPluralRulesResource>
    {
        private PluralRulesOrdinalLocalizer(IDictionary<string, IPluralRulesResource> dictionary) : base(dictionary) { }

        public PluralRulesOrdinalLocalizer() : this(new Dictionary<string, IPluralRulesResource>
        {
            { "af", new AfrikaansPluralRulesOrdinalResource() },
            { "am", new AmharicPluralRulesOrdinalResource() },
            { "ar", new ArabicPluralRulesOrdinalResource() },
            { "as", new AssamesePluralRulesOrdinalResource() },
            { "az", new AzerbaijaniPluralRulesOrdinalResource() },
            { "be", new BelarusianPluralRulesOrdinalResource() },
            { "bg", new BulgarianPluralRulesOrdinalResource() },
            { "bn", new BanglaPluralRulesOrdinalResource() },
            { "bs", new BosnianPluralRulesOrdinalResource() },
            { "ca", new CatalanPluralRulesOrdinalResource() },
            { "ce", new ChechenPluralRulesOrdinalResource() },
            { "cs", new CzechPluralRulesOrdinalResource() },
            { "cy", new WelshPluralRulesOrdinalResource() },
            { "da", new DanishPluralRulesOrdinalResource() },
            { "de", new GermanPluralRulesOrdinalResource() },
            { "dsb", new LowerSorbianPluralRulesOrdinalResource() },
            { "el", new GreekPluralRulesOrdinalResource() },
            { "en", new EnglishPluralRulesOrdinalResource() },
            { "es", new SpanishPluralRulesOrdinalResource() },
            { "et", new EstonianPluralRulesOrdinalResource() },
            { "eu", new BasquePluralRulesOrdinalResource() },
            { "fa", new PersianPluralRulesOrdinalResource() },
            { "fi", new FinnishPluralRulesOrdinalResource() },
            { "fil", new FilipinoPluralRulesOrdinalResource() },
            { "fr", new FrenchPluralRulesOrdinalResource() },
            { "fy", new WesternFrisianPluralRulesOrdinalResource() },
            { "ga", new IrishPluralRulesOrdinalResource() },
            { "gd", new ScottishGaelicPluralRulesOrdinalResource() },
            { "gl", new GalicianPluralRulesOrdinalResource() },
            { "gsw", new SwissGermanPluralRulesOrdinalResource() },
            { "gu", new GujaratiPluralRulesOrdinalResource() },
            { "he", new HebrewPluralRulesOrdinalResource() },
            { "hi", new HindiPluralRulesOrdinalResource() },
            { "hr", new CroatianPluralRulesOrdinalResource() },
            { "hsb", new UpperSorbianPluralRulesOrdinalResource() },
            { "hu", new HungarianPluralRulesOrdinalResource() },
            { "hy", new ArmenianPluralRulesOrdinalResource() },
            { "ia", new InterlinguaPluralRulesOrdinalResource() },
            { "id", new IndonesianPluralRulesOrdinalResource() },
            { "is", new IcelandicPluralRulesOrdinalResource() },
            { "it", new ItalianPluralRulesOrdinalResource() },
            { "ja", new JapanesePluralRulesOrdinalResource() },
            { "ka", new GeorgianPluralRulesOrdinalResource() },
            { "kk", new KazakhPluralRulesOrdinalResource() },
            { "km", new KhmerPluralRulesOrdinalResource() },
            { "kn", new KannadaPluralRulesOrdinalResource() },
            { "ko", new KoreanPluralRulesOrdinalResource() },
            { "kw", new CornishPluralRulesOrdinalResource() },
            { "ky", new KyrgyzPluralRulesOrdinalResource() },
            { "lo", new LaoPluralRulesOrdinalResource() },
            { "lt", new LithuanianPluralRulesOrdinalResource() },
            { "lv", new LatvianPluralRulesOrdinalResource() },
            { "mk", new MacedonianPluralRulesOrdinalResource() },
            { "ml", new MalayalamPluralRulesOrdinalResource() },
            { "mn", new MongolianPluralRulesOrdinalResource() },
            { "mr", new MarathiPluralRulesOrdinalResource() },
            { "ms", new MalayPluralRulesOrdinalResource() },
            { "my", new BurmesePluralRulesOrdinalResource() },
            { "nb", new NorwegianBokmalPluralRulesOrdinalResource() },
            { "ne", new NepaliPluralRulesOrdinalResource() },
            { "nl", new DutchPluralRulesOrdinalResource() },
            { "or", new OdiaPluralRulesOrdinalResource() },
            { "pa", new PunjabiPluralRulesOrdinalResource() },
            { "pl", new PolishPluralRulesOrdinalResource() },
            { "prg", new PrussianPluralRulesOrdinalResource() },
            { "ps", new PashtoPluralRulesOrdinalResource() },
            { "pt", new PortuguesePluralRulesOrdinalResource() },
            { "ro", new RomanianPluralRulesOrdinalResource() },
            { "ru", new RussianPluralRulesOrdinalResource() },
            { "sd", new SindhiPluralRulesOrdinalResource() },
            { "si", new SinhalaPluralRulesOrdinalResource() },
            { "sk", new SlovakPluralRulesOrdinalResource() },
            { "sl", new SlovenianPluralRulesOrdinalResource() },
            { "sq", new AlbanianPluralRulesOrdinalResource() },
            { "sr", new SerbianPluralRulesOrdinalResource() },
            { "sv", new SwedishPluralRulesOrdinalResource() },
            { "sw", new KiswahiliPluralRulesOrdinalResource() },
            { "ta", new TamilPluralRulesOrdinalResource() },
            { "te", new TeluguPluralRulesOrdinalResource() },
            { "th", new ThaiPluralRulesOrdinalResource() },
            { "tk", new TurkmenPluralRulesOrdinalResource() },
            { "tr", new TurkishPluralRulesOrdinalResource() },
            { "uk", new UkrainianPluralRulesOrdinalResource() },
            { "ur", new UrduPluralRulesOrdinalResource() },
            { "uz", new UzbekPluralRulesOrdinalResource() },
            { "vi", new VietnamesePluralRulesOrdinalResource() },
            { "zh", new ChinesePluralRulesOrdinalResource() },
            { "zu", new IsiZuluPluralRulesOrdinalResource() },
        })
        { }

        public IPluralRulesResource CurrentLocalizer => this.GetLocalizer(CultureInfo.CurrentCulture);

        public IPluralRulesResource CurrentUILocalizer => this.GetLocalizer(CultureInfo.CurrentUICulture);

        public IPluralRulesResource GetLocalizer(CultureInfo culture) => this.GetValueOrDefault(culture.Name, null) ?? this.GetValueOrDefault(culture.Parent?.Name, null);
    }
}