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
using Alrev.Intl.RelativeTime.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Alrev.Intl.RelativeTime.Globalization
{
    /// <summary>
    /// The Relative Time resource set localizer
    /// </summary>
    public class RelativeTimeLocalizer : ReadOnlyDictionary<string, IRelativeTimeResourceSet>, IResourceSetLocalizer<IRelativeTimeResourceSet>
    {
        private RelativeTimeLocalizer(IDictionary<string, IRelativeTimeResourceSet> dictionary) : base(dictionary) { }

        /// <summary>
        /// The class constructor
        /// </summary>
        public RelativeTimeLocalizer() : this(new Dictionary<string, IRelativeTimeResourceSet>
        {
            { "af", new AfrikaansRelativeTimeResourceSet() },
            { "af-na", new AfrikaansNamibiaRelativeTimeResourceSet() },
            { "agq", new AghemRelativeTimeResourceSet() },
            { "ak", new AkanRelativeTimeResourceSet() },
            { "am", new AmharicRelativeTimeResourceSet() },
            { "ar", new ArabicRelativeTimeResourceSet() },
            { "ar-ae", new ArabicUnitedArabEmiratesRelativeTimeResourceSet() },
            { "ar-bh", new ArabicBahrainRelativeTimeResourceSet() },
            { "ar-dj", new ArabicDjiboutiRelativeTimeResourceSet() },
            { "ar-dz", new ArabicAlgeriaRelativeTimeResourceSet() },
            { "ar-eg", new ArabicEgyptRelativeTimeResourceSet() },
            { "ar-er", new ArabicEritreaRelativeTimeResourceSet() },
            { "ar-il", new ArabicIsraelRelativeTimeResourceSet() },
            { "ar-iq", new ArabicIraqRelativeTimeResourceSet() },
            { "ar-jo", new ArabicJordanRelativeTimeResourceSet() },
            { "ar-km", new ArabicComorosRelativeTimeResourceSet() },
            { "ar-kw", new ArabicKuwaitRelativeTimeResourceSet() },
            { "ar-lb", new ArabicLebanonRelativeTimeResourceSet() },
            { "ar-ly", new ArabicLibyaRelativeTimeResourceSet() },
            { "ar-ma", new ArabicMoroccoRelativeTimeResourceSet() },
            { "ar-mr", new ArabicMauritaniaRelativeTimeResourceSet() },
            { "ar-om", new ArabicOmanRelativeTimeResourceSet() },
            { "ar-ps", new ArabicPalestinianAuthorityRelativeTimeResourceSet() },
            { "ar-qa", new ArabicQatarRelativeTimeResourceSet() },
            { "ar-sa", new ArabicSaudiArabiaRelativeTimeResourceSet() },
            { "ar-sd", new ArabicSudanRelativeTimeResourceSet() },
            { "ar-so", new ArabicSomaliaRelativeTimeResourceSet() },
            { "ar-ss", new ArabicSouthSudanRelativeTimeResourceSet() },
            { "ar-sy", new ArabicSyriaRelativeTimeResourceSet() },
            { "ar-td", new ArabicChadRelativeTimeResourceSet() },
            { "ar-tn", new ArabicTunisiaRelativeTimeResourceSet() },
            { "ar-ye", new ArabicYemenRelativeTimeResourceSet() },
            { "as", new AssameseRelativeTimeResourceSet() },
            { "asa", new AsuRelativeTimeResourceSet() },
            { "ast", new AsturianRelativeTimeResourceSet() },
            { "az", new AzerbaijaniRelativeTimeResourceSet() },
            { "az-cyrl", new AzerbaijaniRelativeTimeResourceSet() },
            { "az-latn", new AzerbaijaniRelativeTimeResourceSet() },
            { "bas", new BasaaRelativeTimeResourceSet() },
            { "be", new BelarusianRelativeTimeResourceSet() },
            { "bem", new BembaRelativeTimeResourceSet() },
            { "bez", new BenaRelativeTimeResourceSet() },
            { "bg", new BulgarianRelativeTimeResourceSet() },
            { "bm", new BamanankanRelativeTimeResourceSet() },
            { "bn", new BanglaRelativeTimeResourceSet() },
            { "bn-in", new BanglaIndiaRelativeTimeResourceSet() },
            { "bo", new TibetanRelativeTimeResourceSet() },
            { "bo-in", new TibetanIndiaRelativeTimeResourceSet() },
            { "br", new BretonRelativeTimeResourceSet() },
            { "brx", new BodoRelativeTimeResourceSet() },
            { "bs", new BosnianRelativeTimeResourceSet() },
            { "bs-cyrl", new BosnianRelativeTimeResourceSet() },
            { "bs-latn", new BosnianRelativeTimeResourceSet() },
            { "ca", new CatalanRelativeTimeResourceSet() },
            { "ca-ad", new CatalanAndorraRelativeTimeResourceSet() },
            { "ca-es-valencia", new CatalanSpainValencianRelativeTimeResourceSet() },
            { "ca-fr", new CatalanFranceRelativeTimeResourceSet() },
            { "ca-it", new CatalanItalyRelativeTimeResourceSet() },
            { "ccp", new ChakmaRelativeTimeResourceSet() },
            { "ce", new ChechenRelativeTimeResourceSet() },
            { "ceb", new CebuanoRelativeTimeResourceSet() },
            { "cgg", new ChigaRelativeTimeResourceSet() },
            { "chr", new CherokeeRelativeTimeResourceSet() },
            { "ku", new KurdishRelativeTimeResourceSet() },
            { "cs", new CzechRelativeTimeResourceSet() },
            { "cy", new WelshRelativeTimeResourceSet() },
            { "da", new DanishRelativeTimeResourceSet() },
            { "da-gl", new DanishGreenlandRelativeTimeResourceSet() },
            { "dav", new TaitaRelativeTimeResourceSet() },
            { "de", new GermanRelativeTimeResourceSet() },
            { "de-at", new GermanAustriaRelativeTimeResourceSet() },
            { "de-be", new GermanBelgiumRelativeTimeResourceSet() },
            { "de-ch", new GermanSwitzerlandRelativeTimeResourceSet() },
            { "de-it", new GermanItalyRelativeTimeResourceSet() },
            { "de-li", new GermanLiechtensteinRelativeTimeResourceSet() },
            { "de-lu", new GermanLuxembourgRelativeTimeResourceSet() },
            { "dje", new ZarmaRelativeTimeResourceSet() },
            { "dsb", new LowerSorbianRelativeTimeResourceSet() },
            { "dua", new DualaRelativeTimeResourceSet() },
            { "dyo", new JolaFonyiRelativeTimeResourceSet() },
            { "dz", new DzongkhaRelativeTimeResourceSet() },
            { "ebu", new EmbuRelativeTimeResourceSet() },
            { "ee", new EweRelativeTimeResourceSet() },
            { "ee-tg", new EweTogoRelativeTimeResourceSet() },
            { "el", new GreekRelativeTimeResourceSet() },
            { "el-cy", new GreekCyprusRelativeTimeResourceSet() },
            { "en", new EnglishRelativeTimeResourceSet() },
            { "en-001", new EnglishWorldRelativeTimeResourceSet() },
            { "en-150", new EnglishEuropeRelativeTimeResourceSet() },
            { "en-ae", new EnglishUnitedArabEmiratesRelativeTimeResourceSet() },
            { "en-ag", new EnglishAntiguaBarbudaRelativeTimeResourceSet() },
            { "en-ai", new EnglishAnguillaRelativeTimeResourceSet() },
            { "en-as", new EnglishAmericanSamoaRelativeTimeResourceSet() },
            { "en-at", new EnglishAustriaRelativeTimeResourceSet() },
            { "en-au", new EnglishAustraliaRelativeTimeResourceSet() },
            { "en-bb", new EnglishBarbadosRelativeTimeResourceSet() },
            { "en-be", new EnglishBelgiumRelativeTimeResourceSet() },
            { "en-bi", new EnglishBurundiRelativeTimeResourceSet() },
            { "en-bm", new EnglishBermudaRelativeTimeResourceSet() },
            { "en-bs", new EnglishBahamasRelativeTimeResourceSet() },
            { "en-bw", new EnglishBotswanaRelativeTimeResourceSet() },
            { "en-bz", new EnglishBelizeRelativeTimeResourceSet() },
            { "en-ca", new EnglishCanadaRelativeTimeResourceSet() },
            { "en-cc", new EnglishCocosKeelingIslandsRelativeTimeResourceSet() },
            { "en-ch", new EnglishSwitzerlandRelativeTimeResourceSet() },
            { "en-ck", new EnglishCookIslandsRelativeTimeResourceSet() },
            { "en-cm", new EnglishCameroonRelativeTimeResourceSet() },
            { "en-cx", new EnglishChristmasIslandRelativeTimeResourceSet() },
            { "en-cy", new EnglishCyprusRelativeTimeResourceSet() },
            { "en-de", new EnglishGermanyRelativeTimeResourceSet() },
            { "en-dk", new EnglishDenmarkRelativeTimeResourceSet() },
            { "en-dm", new EnglishDominicaRelativeTimeResourceSet() },
            { "en-er", new EnglishEritreaRelativeTimeResourceSet() },
            { "en-fi", new EnglishFinlandRelativeTimeResourceSet() },
            { "en-fj", new EnglishFijiRelativeTimeResourceSet() },
            { "en-fk", new EnglishFalklandIslandsRelativeTimeResourceSet() },
            { "en-fm", new EnglishMicronesiaRelativeTimeResourceSet() },
            { "en-gb", new EnglishUnitedKingdomRelativeTimeResourceSet() },
            { "en-gd", new EnglishGrenadaRelativeTimeResourceSet() },
            { "en-gg", new EnglishGuernseyRelativeTimeResourceSet() },
            { "en-gh", new EnglishGhanaRelativeTimeResourceSet() },
            { "en-gi", new EnglishGibraltarRelativeTimeResourceSet() },
            { "en-gm", new EnglishGambiaRelativeTimeResourceSet() },
            { "en-gu", new EnglishGuamRelativeTimeResourceSet() },
            { "en-gy", new EnglishGuyanaRelativeTimeResourceSet() },
            { "en-hk", new EnglishHongKongSARRelativeTimeResourceSet() },
            { "en-ie", new EnglishIrelandRelativeTimeResourceSet() },
            { "en-il", new EnglishIsraelRelativeTimeResourceSet() },
            { "en-im", new EnglishIsleofManRelativeTimeResourceSet() },
            { "en-in", new EnglishIndiaRelativeTimeResourceSet() },
            { "en-io", new EnglishBritishIndianOceanTerritoryRelativeTimeResourceSet() },
            { "en-je", new EnglishJerseyRelativeTimeResourceSet() },
            { "en-jm", new EnglishJamaicaRelativeTimeResourceSet() },
            { "en-ke", new EnglishKenyaRelativeTimeResourceSet() },
            { "en-ki", new EnglishKiribatiRelativeTimeResourceSet() },
            { "en-kn", new EnglishStKittsNevisRelativeTimeResourceSet() },
            { "en-ky", new EnglishCaymanIslandsRelativeTimeResourceSet() },
            { "en-lc", new EnglishStLuciaRelativeTimeResourceSet() },
            { "en-lr", new EnglishLiberiaRelativeTimeResourceSet() },
            { "en-ls", new EnglishLesothoRelativeTimeResourceSet() },
            { "en-mg", new EnglishMadagascarRelativeTimeResourceSet() },
            { "en-mh", new EnglishMarshallIslandsRelativeTimeResourceSet() },
            { "en-mo", new EnglishMacaoSARRelativeTimeResourceSet() },
            { "en-mp", new EnglishNorthernMarianaIslandsRelativeTimeResourceSet() },
            { "en-ms", new EnglishMontserratRelativeTimeResourceSet() },
            { "en-mt", new EnglishMaltaRelativeTimeResourceSet() },
            { "en-mu", new EnglishMauritiusRelativeTimeResourceSet() },
            { "en-mw", new EnglishMalawiRelativeTimeResourceSet() },
            { "en-my", new EnglishMalaysiaRelativeTimeResourceSet() },
            { "en-na", new EnglishNamibiaRelativeTimeResourceSet() },
            { "en-nf", new EnglishNorfolkIslandRelativeTimeResourceSet() },
            { "en-ng", new EnglishNigeriaRelativeTimeResourceSet() },
            { "en-nl", new EnglishNetherlandsRelativeTimeResourceSet() },
            { "en-nr", new EnglishNauruRelativeTimeResourceSet() },
            { "en-nu", new EnglishNiueRelativeTimeResourceSet() },
            { "en-nz", new EnglishNewZealandRelativeTimeResourceSet() },
            { "en-pg", new EnglishPapuaNewGuineaRelativeTimeResourceSet() },
            { "en-ph", new EnglishPhilippinesRelativeTimeResourceSet() },
            { "en-pk", new EnglishPakistanRelativeTimeResourceSet() },
            { "en-pn", new EnglishPitcairnIslandsRelativeTimeResourceSet() },
            { "en-pr", new EnglishPuertoRicoRelativeTimeResourceSet() },
            { "en-pw", new EnglishPalauRelativeTimeResourceSet() },
            { "en-rw", new EnglishRwandaRelativeTimeResourceSet() },
            { "en-sb", new EnglishSolomonIslandsRelativeTimeResourceSet() },
            { "en-sc", new EnglishSeychellesRelativeTimeResourceSet() },
            { "en-sd", new EnglishSudanRelativeTimeResourceSet() },
            { "en-se", new EnglishSwedenRelativeTimeResourceSet() },
            { "en-sg", new EnglishSingaporeRelativeTimeResourceSet() },
            { "en-sh", new EnglishStHelenaAscensionTristandaCunhaRelativeTimeResourceSet() },
            { "en-si", new EnglishSloveniaRelativeTimeResourceSet() },
            { "en-sl", new EnglishSierraLeoneRelativeTimeResourceSet() },
            { "en-ss", new EnglishSouthSudanRelativeTimeResourceSet() },
            { "en-sx", new EnglishSintMaartenRelativeTimeResourceSet() },
            { "en-sz", new EnglishEswatiniRelativeTimeResourceSet() },
            { "en-tc", new EnglishTurksCaicosIslandsRelativeTimeResourceSet() },
            { "en-tk", new EnglishTokelauRelativeTimeResourceSet() },
            { "en-to", new EnglishTongaRelativeTimeResourceSet() },
            { "en-tt", new EnglishTrinidadTobagoRelativeTimeResourceSet() },
            { "en-tv", new EnglishTuvaluRelativeTimeResourceSet() },
            { "en-tz", new EnglishTanzaniaRelativeTimeResourceSet() },
            { "en-ug", new EnglishUgandaRelativeTimeResourceSet() },
            { "en-um", new EnglishUSOutlyingIslandsRelativeTimeResourceSet() },
            { "en-us-posix", new EnglishUnitedStatesComputerRelativeTimeResourceSet() },
            { "en-vc", new EnglishStVincentGrenadinesRelativeTimeResourceSet() },
            { "en-vg", new EnglishBritishVirginIslandsRelativeTimeResourceSet() },
            { "en-vi", new EnglishUSVirginIslandsRelativeTimeResourceSet() },
            { "en-vu", new EnglishVanuatuRelativeTimeResourceSet() },
            { "en-ws", new EnglishSamoaRelativeTimeResourceSet() },
            { "en-za", new EnglishSouthAfricaRelativeTimeResourceSet() },
            { "en-zm", new EnglishZambiaRelativeTimeResourceSet() },
            { "en-zw", new EnglishZimbabweRelativeTimeResourceSet() },
            { "eo", new EsperantoRelativeTimeResourceSet() },
            { "es", new SpanishRelativeTimeResourceSet() },
            { "es-419", new SpanishLatinAmericaRelativeTimeResourceSet() },
            { "es-ar", new SpanishArgentinaRelativeTimeResourceSet() },
            { "es-bo", new SpanishBoliviaRelativeTimeResourceSet() },
            { "es-br", new SpanishBrazilRelativeTimeResourceSet() },
            { "es-bz", new SpanishBelizeRelativeTimeResourceSet() },
            { "es-cl", new SpanishChileRelativeTimeResourceSet() },
            { "es-co", new SpanishColombiaRelativeTimeResourceSet() },
            { "es-cr", new SpanishCostaRicaRelativeTimeResourceSet() },
            { "es-cu", new SpanishCubaRelativeTimeResourceSet() },
            { "es-do", new SpanishDominicanRepublicRelativeTimeResourceSet() },
            { "es-ec", new SpanishEcuadorRelativeTimeResourceSet() },
            { "es-gq", new SpanishEquatorialGuineaRelativeTimeResourceSet() },
            { "es-gt", new SpanishGuatemalaRelativeTimeResourceSet() },
            { "es-hn", new SpanishHondurasRelativeTimeResourceSet() },
            { "es-mx", new SpanishMexicoRelativeTimeResourceSet() },
            { "es-ni", new SpanishNicaraguaRelativeTimeResourceSet() },
            { "es-pa", new SpanishPanamaRelativeTimeResourceSet() },
            { "es-pe", new SpanishPeruRelativeTimeResourceSet() },
            { "es-ph", new SpanishPhilippinesRelativeTimeResourceSet() },
            { "es-pr", new SpanishPuertoRicoRelativeTimeResourceSet() },
            { "es-py", new SpanishParaguayRelativeTimeResourceSet() },
            { "es-sv", new SpanishElSalvadorRelativeTimeResourceSet() },
            { "es-us", new SpanishUnitedStatesRelativeTimeResourceSet() },
            { "es-uy", new SpanishUruguayRelativeTimeResourceSet() },
            { "es-ve", new SpanishVenezuelaRelativeTimeResourceSet() },
            { "et", new EstonianRelativeTimeResourceSet() },
            { "eu", new BasqueRelativeTimeResourceSet() },
            { "ewo", new EwondoRelativeTimeResourceSet() },
            { "fa", new PersianRelativeTimeResourceSet() },
            { "ff", new FulahRelativeTimeResourceSet() },
            { "ff-latn", new FulahRelativeTimeResourceSet() },
            { "ff-latn-bf", new FulahLatinBurkinaFasoRelativeTimeResourceSet() },
            { "ff-latn-cm", new FulahLatinCameroonRelativeTimeResourceSet() },
            { "ff-latn-gh", new FulahLatinGhanaRelativeTimeResourceSet() },
            { "ff-latn-gm", new FulahLatinGambiaRelativeTimeResourceSet() },
            { "ff-latn-gn", new FulahLatinGuineaRelativeTimeResourceSet() },
            { "ff-latn-gw", new FulahLatinGuineaBissauRelativeTimeResourceSet() },
            { "ff-latn-lr", new FulahLatinLiberiaRelativeTimeResourceSet() },
            { "ff-latn-mr", new FulahLatinMauritaniaRelativeTimeResourceSet() },
            { "ff-latn-ne", new FulahLatinNigerRelativeTimeResourceSet() },
            { "ff-latn-ng", new FulahLatinNigeriaRelativeTimeResourceSet() },
            { "ff-latn-sl", new FulahLatinSierraLeoneRelativeTimeResourceSet() },
            { "fi", new FinnishRelativeTimeResourceSet() },
            { "fil", new FilipinoRelativeTimeResourceSet() },
            { "fo", new FaroeseRelativeTimeResourceSet() },
            { "fo-dk", new FaroeseDenmarkRelativeTimeResourceSet() },
            { "fr", new FrenchRelativeTimeResourceSet() },
            { "fr-be", new FrenchBelgiumRelativeTimeResourceSet() },
            { "fr-bf", new FrenchBurkinaFasoRelativeTimeResourceSet() },
            { "fr-bi", new FrenchBurundiRelativeTimeResourceSet() },
            { "fr-bj", new FrenchBeninRelativeTimeResourceSet() },
            { "fr-bl", new FrenchStBarthelemyRelativeTimeResourceSet() },
            { "fr-ca", new FrenchCanadaRelativeTimeResourceSet() },
            { "fr-cd", new FrenchCongoDRCRelativeTimeResourceSet() },
            { "fr-cf", new FrenchCentralAfricanRepublicRelativeTimeResourceSet() },
            { "fr-cg", new FrenchCongoRelativeTimeResourceSet() },
            { "fr-ch", new FrenchSwitzerlandRelativeTimeResourceSet() },
            { "fr-ci", new FrenchCotedIvoireRelativeTimeResourceSet() },
            { "fr-cm", new FrenchCameroonRelativeTimeResourceSet() },
            { "fr-dj", new FrenchDjiboutiRelativeTimeResourceSet() },
            { "fr-dz", new FrenchAlgeriaRelativeTimeResourceSet() },
            { "fr-ga", new FrenchGabonRelativeTimeResourceSet() },
            { "fr-gf", new FrenchFrenchGuianaRelativeTimeResourceSet() },
            { "fr-gn", new FrenchGuineaRelativeTimeResourceSet() },
            { "fr-gp", new FrenchGuadeloupeRelativeTimeResourceSet() },
            { "fr-gq", new FrenchEquatorialGuineaRelativeTimeResourceSet() },
            { "fr-ht", new FrenchHaitiRelativeTimeResourceSet() },
            { "fr-km", new FrenchComorosRelativeTimeResourceSet() },
            { "fr-lu", new FrenchLuxembourgRelativeTimeResourceSet() },
            { "fr-ma", new FrenchMoroccoRelativeTimeResourceSet() },
            { "fr-mc", new FrenchMonacoRelativeTimeResourceSet() },
            { "fr-mf", new FrenchStMartinRelativeTimeResourceSet() },
            { "fr-mg", new FrenchMadagascarRelativeTimeResourceSet() },
            { "fr-ml", new FrenchMaliRelativeTimeResourceSet() },
            { "fr-mq", new FrenchMartiniqueRelativeTimeResourceSet() },
            { "fr-mr", new FrenchMauritaniaRelativeTimeResourceSet() },
            { "fr-mu", new FrenchMauritiusRelativeTimeResourceSet() },
            { "fr-nc", new FrenchNewCaledoniaRelativeTimeResourceSet() },
            { "fr-ne", new FrenchNigerRelativeTimeResourceSet() },
            { "fr-pf", new FrenchFrenchPolynesiaRelativeTimeResourceSet() },
            { "fr-pm", new FrenchStPierreMiquelonRelativeTimeResourceSet() },
            { "fr-re", new FrenchReunionRelativeTimeResourceSet() },
            { "fr-rw", new FrenchRwandaRelativeTimeResourceSet() },
            { "fr-sc", new FrenchSeychellesRelativeTimeResourceSet() },
            { "fr-sn", new FrenchSenegalRelativeTimeResourceSet() },
            { "fr-sy", new FrenchSyriaRelativeTimeResourceSet() },
            { "fr-td", new FrenchChadRelativeTimeResourceSet() },
            { "fr-tg", new FrenchTogoRelativeTimeResourceSet() },
            { "fr-tn", new FrenchTunisiaRelativeTimeResourceSet() },
            { "fr-vu", new FrenchVanuatuRelativeTimeResourceSet() },
            { "fr-wf", new FrenchWallisFutunaRelativeTimeResourceSet() },
            { "fr-yt", new FrenchMayotteRelativeTimeResourceSet() },
            { "fur", new FriulianRelativeTimeResourceSet() },
            { "fy", new WesternFrisianRelativeTimeResourceSet() },
            { "ga", new IrishRelativeTimeResourceSet() },
            { "gd", new ScottishGaelicRelativeTimeResourceSet() },
            { "gl", new GalicianRelativeTimeResourceSet() },
            { "gsw", new SwissGermanRelativeTimeResourceSet() },
            { "gsw-fr", new SwissGermanFranceRelativeTimeResourceSet() },
            { "gsw-li", new SwissGermanLiechtensteinRelativeTimeResourceSet() },
            { "gu", new GujaratiRelativeTimeResourceSet() },
            { "guz", new GusiiRelativeTimeResourceSet() },
            { "gv", new ManxRelativeTimeResourceSet() },
            { "ha", new HausaRelativeTimeResourceSet() },
            { "haw", new HawaiianRelativeTimeResourceSet() },
            { "he", new HebrewRelativeTimeResourceSet() },
            { "hi", new HindiRelativeTimeResourceSet() },
            { "hr", new CroatianRelativeTimeResourceSet() },
            { "hr-ba", new CroatianBosniaHerzegovinaRelativeTimeResourceSet() },
            { "hsb", new UpperSorbianRelativeTimeResourceSet() },
            { "hu", new HungarianRelativeTimeResourceSet() },
            { "hy", new ArmenianRelativeTimeResourceSet() },
            { "ia", new InterlinguaRelativeTimeResourceSet() },
            { "id", new IndonesianRelativeTimeResourceSet() },
            { "ig", new IgboRelativeTimeResourceSet() },
            { "ii", new YiRelativeTimeResourceSet() },
            { "is", new IcelandicRelativeTimeResourceSet() },
            { "it", new ItalianRelativeTimeResourceSet() },
            { "it-ch", new ItalianSwitzerlandRelativeTimeResourceSet() },
            { "it-sm", new ItalianSanMarinoRelativeTimeResourceSet() },
            { "it-va", new ItalianVaticanCityRelativeTimeResourceSet() },
            { "ja", new JapaneseRelativeTimeResourceSet() },
            { "jgo", new NgombaRelativeTimeResourceSet() },
            { "jmc", new MachameRelativeTimeResourceSet() },
            { "jv", new JavaneseRelativeTimeResourceSet() },
            { "ka", new GeorgianRelativeTimeResourceSet() },
            { "kab", new KabyleRelativeTimeResourceSet() },
            { "kam", new KambaRelativeTimeResourceSet() },
            { "kde", new MakondeRelativeTimeResourceSet() },
            { "kea", new KabuverdianuRelativeTimeResourceSet() },
            { "khq", new KoyraChiiniRelativeTimeResourceSet() },
            { "ki", new KikuyuRelativeTimeResourceSet() },
            { "kk", new KazakhRelativeTimeResourceSet() },
            { "kkj", new KakoRelativeTimeResourceSet() },
            { "kl", new KalaallisutRelativeTimeResourceSet() },
            { "kln", new KalenjinRelativeTimeResourceSet() },
            { "km", new KhmerRelativeTimeResourceSet() },
            { "kn", new KannadaRelativeTimeResourceSet() },
            { "ko", new KoreanRelativeTimeResourceSet() },
            { "ko-kp", new KoreanNorthKoreaRelativeTimeResourceSet() },
            { "kok", new KonkaniRelativeTimeResourceSet() },
            { "ks", new KashmiriRelativeTimeResourceSet() },
            { "ksb", new ShambalaRelativeTimeResourceSet() },
            { "ksf", new BafiaRelativeTimeResourceSet() },
            { "ksh", new ColognianRelativeTimeResourceSet() },
            { "kw", new CornishRelativeTimeResourceSet() },
            { "ky", new KyrgyzRelativeTimeResourceSet() },
            { "lag", new LangiRelativeTimeResourceSet() },
            { "lb", new LuxembourgishRelativeTimeResourceSet() },
            { "lg", new GandaRelativeTimeResourceSet() },
            { "lkt", new LakotaRelativeTimeResourceSet() },
            { "ln", new LingalaRelativeTimeResourceSet() },
            { "ln-ao", new LingalaAngolaRelativeTimeResourceSet() },
            { "ln-cf", new LingalaCentralAfricanRepublicRelativeTimeResourceSet() },
            { "ln-cg", new LingalaCongoRelativeTimeResourceSet() },
            { "lo", new LaoRelativeTimeResourceSet() },
            { "lrc", new NorthernLuriRelativeTimeResourceSet() },
            { "lrc-iq", new NorthernLuriIraqRelativeTimeResourceSet() },
            { "lt", new LithuanianRelativeTimeResourceSet() },
            { "lu", new LubaKatangaRelativeTimeResourceSet() },
            { "luo", new LuoRelativeTimeResourceSet() },
            { "luy", new LuyiaRelativeTimeResourceSet() },
            { "lv", new LatvianRelativeTimeResourceSet() },
            { "mas", new MasaiRelativeTimeResourceSet() },
            { "mas-tz", new MasaiTanzaniaRelativeTimeResourceSet() },
            { "mer", new MeruRelativeTimeResourceSet() },
            { "mfe", new MorisyenRelativeTimeResourceSet() },
            { "mg", new MalagasyRelativeTimeResourceSet() },
            { "mgh", new MakhuwaMeettoRelativeTimeResourceSet() },
            { "mgo", new MetaRelativeTimeResourceSet() },
            { "mi", new MaoriRelativeTimeResourceSet() },
            { "mk", new MacedonianRelativeTimeResourceSet() },
            { "ml", new MalayalamRelativeTimeResourceSet() },
            { "mn", new MongolianRelativeTimeResourceSet() },
            { "mr", new MarathiRelativeTimeResourceSet() },
            { "ms", new MalayRelativeTimeResourceSet() },
            { "ms-bn", new MalayBruneiRelativeTimeResourceSet() },
            { "ms-sg", new MalaySingaporeRelativeTimeResourceSet() },
            { "mt", new MalteseRelativeTimeResourceSet() },
            { "mua", new MundangRelativeTimeResourceSet() },
            { "my", new BurmeseRelativeTimeResourceSet() },
            { "mzn", new MazanderaniRelativeTimeResourceSet() },
            { "naq", new NamaRelativeTimeResourceSet() },
            { "nb", new NorwegianBokmalRelativeTimeResourceSet() },
            { "nb-sj", new NorwegianBokmalSvalbardJanMayenRelativeTimeResourceSet() },
            { "nd", new NorthNdebeleRelativeTimeResourceSet() },
            { "nds", new LowGermanRelativeTimeResourceSet() },
            { "nds-nl", new LowGermanNetherlandsRelativeTimeResourceSet() },
            { "ne", new NepaliRelativeTimeResourceSet() },
            { "ne-in", new NepaliIndiaRelativeTimeResourceSet() },
            { "nl", new DutchRelativeTimeResourceSet() },
            { "nl-aw", new DutchArubaRelativeTimeResourceSet() },
            { "nl-be", new DutchBelgiumRelativeTimeResourceSet() },
            { "nl-bq", new DutchBonaireSintEustatiusandSabaRelativeTimeResourceSet() },
            { "nl-cw", new DutchCuracaoRelativeTimeResourceSet() },
            { "nl-sr", new DutchSurinameRelativeTimeResourceSet() },
            { "nl-sx", new DutchSintMaartenRelativeTimeResourceSet() },
            { "nmg", new KwasioRelativeTimeResourceSet() },
            { "nn", new NorwegianNynorskRelativeTimeResourceSet() },
            { "nnh", new NgiemboonRelativeTimeResourceSet() },
            { "nus", new NuerRelativeTimeResourceSet() },
            { "nyn", new NyankoleRelativeTimeResourceSet() },
            { "om", new OromoRelativeTimeResourceSet() },
            { "om-ke", new OromoKenyaRelativeTimeResourceSet() },
            { "or", new OdiaRelativeTimeResourceSet() },
            { "os", new OsseticRelativeTimeResourceSet() },
            { "os-ru", new OsseticRussiaRelativeTimeResourceSet() },
            { "pa", new PunjabiRelativeTimeResourceSet() },
            { "pa-arab", new PunjabiRelativeTimeResourceSet() },
            { "pa-guru", new PunjabiRelativeTimeResourceSet() },
            { "pl", new PolishRelativeTimeResourceSet() },
            { "ps", new PashtoRelativeTimeResourceSet() },
            { "ps-pk", new PashtoPakistanRelativeTimeResourceSet() },
            { "pt", new PortugueseRelativeTimeResourceSet() },
            { "pt-ao", new PortugueseAngolaRelativeTimeResourceSet() },
            { "pt-ch", new PortugueseSwitzerlandRelativeTimeResourceSet() },
            { "pt-cv", new PortugueseCaboVerdeRelativeTimeResourceSet() },
            { "pt-gq", new PortugueseEquatorialGuineaRelativeTimeResourceSet() },
            { "pt-gw", new PortugueseGuineaBissauRelativeTimeResourceSet() },
            { "pt-lu", new PortugueseLuxembourgRelativeTimeResourceSet() },
            { "pt-mo", new PortugueseMacaoSARRelativeTimeResourceSet() },
            { "pt-mz", new PortugueseMozambiqueRelativeTimeResourceSet() },
            { "pt-pt", new PortuguesePortugalRelativeTimeResourceSet() },
            { "pt-st", new PortugueseSaoTomePrincipeRelativeTimeResourceSet() },
            { "pt-tl", new PortugueseTimorLesteRelativeTimeResourceSet() },
            { "rm", new RomanshRelativeTimeResourceSet() },
            { "rn", new RundiRelativeTimeResourceSet() },
            { "ro", new RomanianRelativeTimeResourceSet() },
            { "ro-md", new RomanianMoldovaRelativeTimeResourceSet() },
            { "rof", new RomboRelativeTimeResourceSet() },
            { "ru", new RussianRelativeTimeResourceSet() },
            { "ru-by", new RussianBelarusRelativeTimeResourceSet() },
            { "ru-kg", new RussianKyrgyzstanRelativeTimeResourceSet() },
            { "ru-kz", new RussianKazakhstanRelativeTimeResourceSet() },
            { "ru-md", new RussianMoldovaRelativeTimeResourceSet() },
            { "ru-ua", new RussianUkraineRelativeTimeResourceSet() },
            { "rw", new KinyarwandaRelativeTimeResourceSet() },
            { "rwk", new RwaRelativeTimeResourceSet() },
            { "sa", new SanskritRelativeTimeResourceSet() },
            { "sah", new SakhaRelativeTimeResourceSet() },
            { "saq", new SamburuRelativeTimeResourceSet() },
            { "sbp", new SanguRelativeTimeResourceSet() },
            { "sd", new SindhiRelativeTimeResourceSet() },
            { "se", new NorthernSamiRelativeTimeResourceSet() },
            { "se-fi", new NorthernSamiFinlandRelativeTimeResourceSet() },
            { "se-se", new NorthernSamiSwedenRelativeTimeResourceSet() },
            { "seh", new SenaRelativeTimeResourceSet() },
            { "ses", new KoyraboroSenniRelativeTimeResourceSet() },
            { "sg", new SangoRelativeTimeResourceSet() },
            { "shi", new TachelhitRelativeTimeResourceSet() },
            { "shi-latn", new TachelhitRelativeTimeResourceSet() },
            { "shi-tfng", new TachelhitRelativeTimeResourceSet() },
            { "si", new SinhalaRelativeTimeResourceSet() },
            { "sk", new SlovakRelativeTimeResourceSet() },
            { "sl", new SlovenianRelativeTimeResourceSet() },
            { "smn", new InariSamiRelativeTimeResourceSet() },
            { "sn", new ShonaRelativeTimeResourceSet() },
            { "so", new SomaliRelativeTimeResourceSet() },
            { "so-dj", new SomaliDjiboutiRelativeTimeResourceSet() },
            { "so-et", new SomaliEthiopiaRelativeTimeResourceSet() },
            { "so-ke", new SomaliKenyaRelativeTimeResourceSet() },
            { "sq", new AlbanianRelativeTimeResourceSet() },
            { "sq-mk", new AlbanianNorthMacedoniaRelativeTimeResourceSet() },
            { "sq-xk", new AlbanianKosovoRelativeTimeResourceSet() },
            { "sr", new SerbianRelativeTimeResourceSet() },
            { "sr-cyrl", new SerbianRelativeTimeResourceSet() },
            { "sr-cyrl-ba", new SerbianCyrillicBosniaHerzegovinaRelativeTimeResourceSet() },
            { "sr-cyrl-me", new SerbianCyrillicMontenegroRelativeTimeResourceSet() },
            { "sr-cyrl-xk", new SerbianCyrillicKosovoRelativeTimeResourceSet() },
            { "sr-latn", new SerbianRelativeTimeResourceSet() },
            { "sr-latn-ba", new SerbianLatinBosniaHerzegovinaRelativeTimeResourceSet() },
            { "sr-latn-me", new SerbianLatinMontenegroRelativeTimeResourceSet() },
            { "sr-latn-xk", new SerbianLatinKosovoRelativeTimeResourceSet() },
            { "sv", new SwedishRelativeTimeResourceSet() },
            { "sv-ax", new SwedishAlandIslandsRelativeTimeResourceSet() },
            { "sv-fi", new SwedishFinlandRelativeTimeResourceSet() },
            { "sw", new KiswahiliRelativeTimeResourceSet() },
            { "sw-cd", new KiswahiliCongoDRCRelativeTimeResourceSet() },
            { "sw-ke", new KiswahiliKenyaRelativeTimeResourceSet() },
            { "sw-ug", new KiswahiliUgandaRelativeTimeResourceSet() },
            { "ta", new TamilRelativeTimeResourceSet() },
            { "ta-lk", new TamilSriLankaRelativeTimeResourceSet() },
            { "ta-my", new TamilMalaysiaRelativeTimeResourceSet() },
            { "ta-sg", new TamilSingaporeRelativeTimeResourceSet() },
            { "te", new TeluguRelativeTimeResourceSet() },
            { "teo", new TesoRelativeTimeResourceSet() },
            { "teo-ke", new TesoKenyaRelativeTimeResourceSet() },
            { "tg", new TajikRelativeTimeResourceSet() },
            { "th", new ThaiRelativeTimeResourceSet() },
            { "ti", new TigrinyaRelativeTimeResourceSet() },
            { "ti-er", new TigrinyaEritreaRelativeTimeResourceSet() },
            { "tk", new TurkmenRelativeTimeResourceSet() },
            { "to", new TonganRelativeTimeResourceSet() },
            { "tr", new TurkishRelativeTimeResourceSet() },
            { "tr-cy", new TurkishCyprusRelativeTimeResourceSet() },
            { "tt", new TatarRelativeTimeResourceSet() },
            { "twq", new TasawaqRelativeTimeResourceSet() },
            { "tzm", new CentralAtlasTamazightRelativeTimeResourceSet() },
            { "ug", new UyghurRelativeTimeResourceSet() },
            { "uk", new UkrainianRelativeTimeResourceSet() },
            { "ur", new UrduRelativeTimeResourceSet() },
            { "ur-in", new UrduIndiaRelativeTimeResourceSet() },
            { "uz", new UzbekRelativeTimeResourceSet() },
            { "uz-arab", new UzbekRelativeTimeResourceSet() },
            { "uz-cyrl", new UzbekRelativeTimeResourceSet() },
            { "uz-latn", new UzbekRelativeTimeResourceSet() },
            { "vai", new VaiRelativeTimeResourceSet() },
            { "vai-latn", new VaiRelativeTimeResourceSet() },
            { "vai-vaii", new VaiRelativeTimeResourceSet() },
            { "vi", new VietnameseRelativeTimeResourceSet() },
            { "vun", new VunjoRelativeTimeResourceSet() },
            { "wae", new WalserRelativeTimeResourceSet() },
            { "wo", new WolofRelativeTimeResourceSet() },
            { "xh", new IsiXhosaRelativeTimeResourceSet() },
            { "xog", new SogaRelativeTimeResourceSet() },
            { "yav", new YangbenRelativeTimeResourceSet() },
            { "yi", new YiddishRelativeTimeResourceSet() },
            { "yo", new YorubaRelativeTimeResourceSet() },
            { "yo-bj", new YorubaBeninRelativeTimeResourceSet() },
            { "zgh", new StandardMoroccanTamazightRelativeTimeResourceSet() },
            { "zh", new ChineseRelativeTimeResourceSet() },
            { "zh-hans", new ChineseRelativeTimeResourceSet() },
            { "zh-hans-hk", new ChineseSimplifiedHongKongSARRelativeTimeResourceSet() },
            { "zh-hans-mo", new ChineseSimplifiedMacaoSARRelativeTimeResourceSet() },
            { "zh-hant", new ChineseRelativeTimeResourceSet() },
            { "zu", new IsiZuluRelativeTimeResourceSet() },
        })
        { }

        /// <summary>
        /// Gets the <see cref="IRelativeTimeResourceSet"/> for the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/></param>
        /// <returns>An <see cref="IRelativeTimeResourceSet"/> for the specified <see cref="CultureInfo"/> or null</returns>
        /// <remarks>
        /// If the specified <see cref="CultureInfo"/> does not exists, it will try to use the parent <see cref="CultureInfo"/> of the specified one.
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public IRelativeTimeResourceSet GetLocalizer(CultureInfo culture) => culture switch 
        {
            null => throw new ArgumentNullException(nameof(culture), "CultureInfo must not be null"),
            CultureInfo c when string.IsNullOrEmpty(c.Name) => throw new ArgumentException("CultureInfo.InvariantCulture is not supported", nameof(culture)),
            _ => this.GetValueOrDefault(culture.Name.ToLowerInvariant(), null) ?? this.GetValueOrDefault(culture.Parent?.Name?.ToLowerInvariant(), null)
        };
    }
}