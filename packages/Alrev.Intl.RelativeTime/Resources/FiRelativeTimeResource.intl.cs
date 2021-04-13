// --------------------------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//   Script: ./scripts/cldr-relative-time.csx
//
//   Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------------------------
using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.Abstractions.RelativeTime;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Alrev.Intl.RelativeTime.Resources
{
	/// <summary>
	/// Relative Time Units resource for 'Finnish' [fi]
	/// </summary>
	public class FiRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public FiRelativeTimeResource()
			: base(new Dictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>()
			{
				{
					RelativeTimeUnitValues.Year,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime vuonna" }, { 0, "tänä vuonna" }, { 1, "ensi vuonna" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vuosi sitten" }, { PluralRulesValues.Other, "{0} vuotta sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vuoden päästä" }, { PluralRulesValues.Other, "{0} vuoden päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime v" }, { 0, "tänä v" }, { 1, "ensi v" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} v sitten" }, { PluralRulesValues.Other, "{0} v sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} v päästä" }, { PluralRulesValues.Other, "{0} v päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime v" }, { 0, "tänä v" }, { 1, "ensi v" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} v sitten" }, { PluralRulesValues.Other, "{0} v sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} v päästä" }, { PluralRulesValues.Other, "{0} v päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Quarter,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime neljännesvuonna" }, { 0, "tänä neljännesvuonna" }, { 1, "ensi neljännesvuonna" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} neljännesvuosi sitten" }, { PluralRulesValues.Other, "{0} neljännesvuotta sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} neljännesvuoden päästä" }, { PluralRulesValues.Other, "{0} neljännesvuoden päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime neljänneksenä" }, { 0, "tänä neljänneksenä" }, { 1, "ensi neljänneksenä" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} neljännes sitten" }, { PluralRulesValues.Other, "{0} neljännestä sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} neljänneksen päästä" }, { PluralRulesValues.Other, "{0} neljänneksen päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime nelj." }, { 0, "tänä nelj." }, { 1, "ensi nelj." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} nelj. sitten" }, { PluralRulesValues.Other, "{0} nelj. sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} nelj. päästä" }, { PluralRulesValues.Other, "{0} nelj. päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Month,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime kuussa" }, { 0, "tässä kuussa" }, { 1, "ensi kuussa" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kuukausi sitten" }, { PluralRulesValues.Other, "{0} kuukautta sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kuukauden päästä" }, { PluralRulesValues.Other, "{0} kuukauden päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime kk" }, { 0, "tässä kk" }, { 1, "ensi kk" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kk sitten" }, { PluralRulesValues.Other, "{0} kk sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kk päästä" }, { PluralRulesValues.Other, "{0} kk päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime kk" }, { 0, "tässä kk" }, { 1, "ensi kk" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kk sitten" }, { PluralRulesValues.Other, "{0} kk sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kk päästä" }, { PluralRulesValues.Other, "{0} kk päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Week,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime viikolla" }, { 0, "tällä viikolla" }, { 1, "ensi viikolla" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} viikko sitten" }, { PluralRulesValues.Other, "{0} viikkoa sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} viikon päästä" }, { PluralRulesValues.Other, "{0} viikon päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime vk" }, { 0, "tällä vk" }, { 1, "ensi vk" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vk sitten" }, { PluralRulesValues.Other, "{0} vk sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vk päästä" }, { PluralRulesValues.Other, "{0} vk päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime vk" }, { 0, "tällä vk" }, { 1, "ensi vk" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vk sitten" }, { PluralRulesValues.Other, "{0} vk sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vk päästä" }, { PluralRulesValues.Other, "{0} vk päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Day,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "toissa päivänä" }, { -1, "eilen" }, { 0, "tänään" }, { 1, "huomenna" }, { 2, "ylihuomenna" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} päivä sitten" }, { PluralRulesValues.Other, "{0} päivää sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} päivän päästä" }, { PluralRulesValues.Other, "{0} päivän päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "toissap." }, { -1, "eilen" }, { 0, "tänään" }, { 1, "huom." }, { 2, "ylihuom." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pv sitten" }, { PluralRulesValues.Other, "{0} pv sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pv päästä" }, { PluralRulesValues.Other, "{0} pv päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "toissap." }, { -1, "eilen" }, { 0, "tänään" }, { 1, "huom." }, { 2, "ylihuom." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pv sitten" }, { PluralRulesValues.Other, "{0} pv sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pv päästä" }, { PluralRulesValues.Other, "{0} pv päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Sunday,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime sunnuntaina" }, { 0, "tänä sunnuntaina" }, { 1, "ensi sunnuntaina" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sunnuntai sitten" }, { PluralRulesValues.Other, "{0} sunnuntaita sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sunnuntain päästä" }, { PluralRulesValues.Other, "{0} sunnuntain päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime su" }, { 0, "tänä su" }, { 1, "ensi su" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} su sitten" }, { PluralRulesValues.Other, "{0} su sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} su päästä" }, { PluralRulesValues.Other, "{0} su päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime su" }, { 0, "tänä su" }, { 1, "ensi su" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} su sitten" }, { PluralRulesValues.Other, "{0} su sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} su päästä" }, { PluralRulesValues.Other, "{0} su päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Monday,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime maanantaina" }, { 0, "tänä maanantaina" }, { 1, "ensi maanantaina" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maanantai sitten" }, { PluralRulesValues.Other, "{0} maanantaita sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maanantain päästä" }, { PluralRulesValues.Other, "{0} maanantain päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime ma" }, { 0, "tänä ma" }, { 1, "ensi ma" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ma sitten" }, { PluralRulesValues.Other, "{0} ma sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ma päästä" }, { PluralRulesValues.Other, "{0} ma päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime ma" }, { 0, "tänä ma" }, { 1, "ensi ma" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ma sitten" }, { PluralRulesValues.Other, "{0} ma sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ma päästä" }, { PluralRulesValues.Other, "{0} ma päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Tuesday,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime tiistaina" }, { 0, "tänä tiistaina" }, { 1, "ensi tiistaina" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tiistai sitten" }, { PluralRulesValues.Other, "{0} tiistaita sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tiistain päästä" }, { PluralRulesValues.Other, "{0} tiistain päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime ti" }, { 0, "tänä ti" }, { 1, "ensi ti" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ti sitten" }, { PluralRulesValues.Other, "{0} ti sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ti päästä" }, { PluralRulesValues.Other, "{0} ti päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime ti" }, { 0, "tänä ti" }, { 1, "ensi ti" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ti sitten" }, { PluralRulesValues.Other, "{0} ti sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ti päästä" }, { PluralRulesValues.Other, "{0} ti päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Wednesday,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime keskiviikkona" }, { 0, "tänä keskiviikkona" }, { 1, "ensi keskiviikkona" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} keskiviikko sitten" }, { PluralRulesValues.Other, "{0} keskiviikkoa sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} keskiviikon päästä" }, { PluralRulesValues.Other, "{0} keskiviikon päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime ke" }, { 0, "tänä ke" }, { 1, "ensi ke" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ke sitten" }, { PluralRulesValues.Other, "{0} ke sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ke päästä" }, { PluralRulesValues.Other, "{0} ke päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime ke" }, { 0, "tänä ke" }, { 1, "ensi ke" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ke sitten" }, { PluralRulesValues.Other, "{0} ke sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ke päästä" }, { PluralRulesValues.Other, "{0} ke päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Thursday,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime torstaina" }, { 0, "tänä torstaina" }, { 1, "ensi torstaina" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} torstai sitten" }, { PluralRulesValues.Other, "{0} torstaita sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} torstain päästä" }, { PluralRulesValues.Other, "{0} torstain päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime to" }, { 0, "tänä to" }, { 1, "ensi to" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} to sitten" }, { PluralRulesValues.Other, "{0} to sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} to päästä" }, { PluralRulesValues.Other, "{0} to päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime to" }, { 0, "tänä to" }, { 1, "ensi to" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} to sitten" }, { PluralRulesValues.Other, "{0} to sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} to päästä" }, { PluralRulesValues.Other, "{0} to päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Friday,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime perjantaina" }, { 0, "tänä perjantaina" }, { 1, "ensi perjantaina" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perjantai sitten" }, { PluralRulesValues.Other, "{0} perjantaita sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perjantain päästä" }, { PluralRulesValues.Other, "{0} perjantain päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime pe" }, { 0, "tänä pe" }, { 1, "ensi pe" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pe sitten" }, { PluralRulesValues.Other, "{0} pe sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pe päästä" }, { PluralRulesValues.Other, "{0} pe päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime pe" }, { 0, "tänä pe" }, { 1, "ensi pe" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pe sitten" }, { PluralRulesValues.Other, "{0} pe sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pe päästä" }, { PluralRulesValues.Other, "{0} pe päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Saturday,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime lauantaina" }, { 0, "tänä lauantaina" }, { 1, "ensi lauantaina" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} lauantai sitten" }, { PluralRulesValues.Other, "{0} lauantaita sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} lauantain päästä" }, { PluralRulesValues.Other, "{0} lauantain päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime la" }, { 0, "tänä la" }, { 1, "ensi la" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} la sitten" }, { PluralRulesValues.Other, "{0} la sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} la päästä" }, { PluralRulesValues.Other, "{0} la päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "viime la" }, { 0, "tänä la" }, { 1, "ensi la" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} la sitten" }, { PluralRulesValues.Other, "{0} la sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} la päästä" }, { PluralRulesValues.Other, "{0} la päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Hour,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "tämän tunnin aikana" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tunti sitten" }, { PluralRulesValues.Other, "{0} tuntia sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tunnin päästä" }, { PluralRulesValues.Other, "{0} tunnin päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "tunnin sisällä" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t sitten" }, { PluralRulesValues.Other, "{0} t sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t päästä" }, { PluralRulesValues.Other, "{0} t päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "tunnin sisällä" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t sitten" }, { PluralRulesValues.Other, "{0} t sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t päästä" }, { PluralRulesValues.Other, "{0} t päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Minute,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "tämän minuutin aikana" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuutti sitten" }, { PluralRulesValues.Other, "{0} minuuttia sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuutin päästä" }, { PluralRulesValues.Other, "{0} minuutin päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "minuutin sisällä" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min sitten" }, { PluralRulesValues.Other, "{0} min sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min päästä" }, { PluralRulesValues.Other, "{0} min päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "minuutin sisällä" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min sitten" }, { PluralRulesValues.Other, "{0} min sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min päästä" }, { PluralRulesValues.Other, "{0} min päästä" } })
							}
						})
				},
				{
					RelativeTimeUnitValues.Second,
					new ReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>(
						new Dictionary<IntlStyleValues, IRelativeTimeResource>()
						{
							{
								IntlStyleValues.Long,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "nyt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekunti sitten" }, { PluralRulesValues.Other, "{0} sekuntia sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekunnin päästä" }, { PluralRulesValues.Other, "{0} sekunnin päästä" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "nyt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} s sitten" }, { PluralRulesValues.Other, "{0} s sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} s päästä" }, { PluralRulesValues.Other, "{0} s päästä" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "nyt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} s sitten" }, { PluralRulesValues.Other, "{0} s sitten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} s päästä" }, { PluralRulesValues.Other, "{0} s päästä" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("fi");
		}
	}
}