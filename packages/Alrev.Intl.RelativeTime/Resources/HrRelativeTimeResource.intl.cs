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
	/// Relative Time Units resource for 'Croatian' [hr]
	/// </summary>
	public class HrRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public HrRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "prošle godine" }, { 0, "ove godine" }, { 1, "sljedeće godine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} godinu" }, { PluralRulesValues.Few, "prije {0} godine" }, { PluralRulesValues.Other, "prije {0} godina" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} godinu" }, { PluralRulesValues.Few, "za {0} godine" }, { PluralRulesValues.Other, "za {0} godina" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle god." }, { 0, "ove god." }, { 1, "sljedeće god." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} g." }, { PluralRulesValues.Few, "prije {0} g." }, { PluralRulesValues.Other, "prije {0} g." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} g." }, { PluralRulesValues.Few, "za {0} g." }, { PluralRulesValues.Other, "za {0} g." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle g." }, { 0, "ove g." }, { 1, "sljedeće g." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} g." }, { PluralRulesValues.Few, "prije {0} g." }, { PluralRulesValues.Other, "prije {0} g." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} g." }, { PluralRulesValues.Few, "za {0} g." }, { PluralRulesValues.Other, "za {0} g." } })
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
									new Dictionary<int, string> { { -1, "prošli kvartal" }, { 0, "ovaj kvartal" }, { 1, "sljedeći kvartal" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} kvartal" }, { PluralRulesValues.Few, "prije {0} kvartala" }, { PluralRulesValues.Other, "prije {0} kvartala" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kvartal" }, { PluralRulesValues.Few, "za {0} kvartala" }, { PluralRulesValues.Other, "za {0} kvartala" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli kv." }, { 0, "ovaj kv." }, { 1, "sljedeći kv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} kv." }, { PluralRulesValues.Few, "prije {0} kv." }, { PluralRulesValues.Other, "prije {0} kv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kv." }, { PluralRulesValues.Few, "za {0} kv." }, { PluralRulesValues.Other, "za {0} kv." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli kv." }, { 0, "ovaj kv." }, { 1, "sljedeći kv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} kv." }, { PluralRulesValues.Few, "prije {0} kv." }, { PluralRulesValues.Other, "prije {0} kv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kv." }, { PluralRulesValues.Few, "za {0} kv." }, { PluralRulesValues.Other, "za {0} kv." } })
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
									new Dictionary<int, string> { { -1, "prošli mjesec" }, { 0, "ovaj mjesec" }, { 1, "sljedeći mjesec" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} mjesec" }, { PluralRulesValues.Few, "prije {0} mjeseca" }, { PluralRulesValues.Other, "prije {0} mjeseci" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} mjesec" }, { PluralRulesValues.Few, "za {0} mjeseca" }, { PluralRulesValues.Other, "za {0} mjeseci" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli mj." }, { 0, "ovaj mj." }, { 1, "sljedeći mj." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} mj." }, { PluralRulesValues.Few, "prije {0} mj." }, { PluralRulesValues.Other, "prije {0} mj." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} mj." }, { PluralRulesValues.Few, "za {0} mj." }, { PluralRulesValues.Other, "za {0} mj." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli mj." }, { 0, "ovaj mj." }, { 1, "sljedeći mj." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} mj." }, { PluralRulesValues.Few, "prije {0} mj." }, { PluralRulesValues.Other, "prije {0} mj." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} mj." }, { PluralRulesValues.Few, "za {0} mj." }, { PluralRulesValues.Other, "za {0} mj." } })
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
									new Dictionary<int, string> { { -1, "prošli tjedan" }, { 0, "ovaj tjedan" }, { 1, "sljedeći tjedan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} tjedan" }, { PluralRulesValues.Few, "prije {0} tjedna" }, { PluralRulesValues.Other, "prije {0} tjedana" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} tjedan" }, { PluralRulesValues.Few, "za {0} tjedna" }, { PluralRulesValues.Other, "za {0} tjedana" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli tj." }, { 0, "ovaj tj." }, { 1, "sljedeći tj." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} tj." }, { PluralRulesValues.Few, "prije {0} tj." }, { PluralRulesValues.Other, "prije {0} tj." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} tj." }, { PluralRulesValues.Few, "za {0} tj." }, { PluralRulesValues.Other, "za {0} tj." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli tj." }, { 0, "ovaj tj." }, { 1, "sljedeći tj." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} tj." }, { PluralRulesValues.Few, "prije {0} tj." }, { PluralRulesValues.Other, "prije {0} tj." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} tj." }, { PluralRulesValues.Few, "za {0} tj." }, { PluralRulesValues.Other, "za {0} tj." } })
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
									new Dictionary<int, string> { { -2, "prekjučer" }, { -1, "jučer" }, { 0, "danas" }, { 1, "sutra" }, { 2, "prekosutra" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} dan" }, { PluralRulesValues.Few, "prije {0} dana" }, { PluralRulesValues.Other, "prije {0} dana" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} dan" }, { PluralRulesValues.Few, "za {0} dana" }, { PluralRulesValues.Other, "za {0} dana" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "prekjučer" }, { -1, "jučer" }, { 0, "danas" }, { 1, "sutra" }, { 2, "prekosutra" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} dan" }, { PluralRulesValues.Few, "prije {0} dana" }, { PluralRulesValues.Other, "prije {0} dana" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} dan" }, { PluralRulesValues.Few, "za {0} dana" }, { PluralRulesValues.Other, "za {0} dana" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "prekjučer" }, { -1, "jučer" }, { 0, "danas" }, { 1, "sutra" }, { 2, "prekosutra" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} d" }, { PluralRulesValues.Few, "prije {0} d" }, { PluralRulesValues.Other, "prije {0} d" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} d" }, { PluralRulesValues.Few, "za {0} d" }, { PluralRulesValues.Other, "za {0} d" } })
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
									new Dictionary<int, string> { { -1, "prošla nedjelja" }, { 0, "ova nedjelja" }, { 1, "sljedeća nedjelja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} nedjelju" }, { PluralRulesValues.Few, "prije {0} nedjelje" }, { PluralRulesValues.Other, "prije {0} nedjelja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} nedjelju" }, { PluralRulesValues.Few, "za {0} nedjelje" }, { PluralRulesValues.Other, "za {0} nedjelja" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošla ned." }, { 0, "ova ned." }, { 1, "sljedeća ned." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} nedjelju" }, { PluralRulesValues.Few, "prije {0} nedjelje" }, { PluralRulesValues.Other, "prije {0} nedjelja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} nedjelju" }, { PluralRulesValues.Few, "za {0} nedjelje" }, { PluralRulesValues.Other, "za {0} nedjelja" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošla ned." }, { 0, "ova ned." }, { 1, "sljedeća ned." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} nedjelju" }, { PluralRulesValues.Few, "prije {0} nedjelje" }, { PluralRulesValues.Other, "prije {0} nedjelja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} nedjelju" }, { PluralRulesValues.Few, "za {0} nedjelje" }, { PluralRulesValues.Other, "za {0} nedjelja" } })
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
									new Dictionary<int, string> { { -1, "prošli ponedjeljak" }, { 0, "ovaj ponedjeljak" }, { 1, "sljedeći ponedjeljak" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} ponedjeljak" }, { PluralRulesValues.Few, "prije {0} ponedjeljka" }, { PluralRulesValues.Other, "prije {0} ponedjeljaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} ponedjeljak" }, { PluralRulesValues.Few, "za {0} ponedjeljka" }, { PluralRulesValues.Other, "za {0} ponedjeljaka" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli pon." }, { 0, "ovaj pon." }, { 1, "sljedeći pon." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} ponedjeljak" }, { PluralRulesValues.Few, "prije {0} ponedjeljka" }, { PluralRulesValues.Other, "prije {0} ponedjeljaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} ponedjeljak" }, { PluralRulesValues.Few, "za {0} ponedjeljka" }, { PluralRulesValues.Other, "za {0} ponedjeljaka" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli pon." }, { 0, "ovaj pon." }, { 1, "sljedeći pon." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} ponedjeljak" }, { PluralRulesValues.Few, "prije {0} ponedjeljka" }, { PluralRulesValues.Other, "prije {0} ponedjeljaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} ponedjeljak" }, { PluralRulesValues.Few, "za {0} ponedjeljka" }, { PluralRulesValues.Other, "za {0} ponedjeljaka" } })
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
									new Dictionary<int, string> { { -1, "prošli utorak" }, { 0, "ovaj utorak" }, { 1, "sljedeći utorak" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} utorak" }, { PluralRulesValues.Few, "prije {0} utorka" }, { PluralRulesValues.Other, "prije {0} utoraka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} utorak" }, { PluralRulesValues.Few, "za {0} utorka" }, { PluralRulesValues.Other, "za {0} utoraka" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli uto." }, { 0, "ovaj uto." }, { 1, "sljedeći uto." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} utorak" }, { PluralRulesValues.Few, "prije {0} utorka" }, { PluralRulesValues.Other, "prije {0} utoraka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} utorak" }, { PluralRulesValues.Few, "za {0} utorka" }, { PluralRulesValues.Other, "za {0} utoraka" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli uto." }, { 0, "ovaj uto." }, { 1, "sljedeći uto." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} utorak" }, { PluralRulesValues.Few, "prije {0} utorka" }, { PluralRulesValues.Other, "prije {0} utoraka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} utorak" }, { PluralRulesValues.Few, "za {0} utorka" }, { PluralRulesValues.Other, "za {0} utoraka" } })
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
									new Dictionary<int, string> { { -1, "prošla srijeda" }, { 0, "ova srijeda" }, { 1, "sljedeća srijeda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} srijedu" }, { PluralRulesValues.Few, "prije {0} srijede" }, { PluralRulesValues.Other, "prije {0} srijeda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} srijedu" }, { PluralRulesValues.Few, "za {0} srijede" }, { PluralRulesValues.Other, "za {0} srijeda" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošla sri." }, { 0, "ova sri." }, { 1, "sljedeća sri." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} srijedu" }, { PluralRulesValues.Few, "prije {0} srijede" }, { PluralRulesValues.Other, "prije {0} srijeda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} srijedu" }, { PluralRulesValues.Few, "za {0} srijede" }, { PluralRulesValues.Other, "za {0} srijeda" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošla sri." }, { 0, "ova sri." }, { 1, "sljedeća sri." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} srijedu" }, { PluralRulesValues.Few, "prije {0} srijede" }, { PluralRulesValues.Other, "prije {0} srijeda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} srijedu" }, { PluralRulesValues.Few, "za {0} srijede" }, { PluralRulesValues.Other, "za {0} srijeda" } })
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
									new Dictionary<int, string> { { -1, "prošli četvrtak" }, { 0, "ovaj četvrtak" }, { 1, "sljedeći četvrtak" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} četvrtak" }, { PluralRulesValues.Few, "prije {0} četvrtka" }, { PluralRulesValues.Other, "prije {0} četvrtaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} četvrtak" }, { PluralRulesValues.Few, "za {0} četvrtka" }, { PluralRulesValues.Other, "za {0} četvrtaka" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli čet." }, { 0, "ovaj čet." }, { 1, "sljedeći čet." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} četvrtak" }, { PluralRulesValues.Few, "prije {0} četvrtka" }, { PluralRulesValues.Other, "prije {0} četvrtaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} četvrtak" }, { PluralRulesValues.Few, "za {0} četvrtka" }, { PluralRulesValues.Other, "za {0} četvrtaka" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli čet." }, { 0, "ovaj čet." }, { 1, "sljedeći čet." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} četvrtak" }, { PluralRulesValues.Few, "prije {0} četvrtka" }, { PluralRulesValues.Other, "prije {0} četvrtaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} četvrtak" }, { PluralRulesValues.Few, "za {0} četvrtka" }, { PluralRulesValues.Other, "za {0} četvrtaka" } })
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
									new Dictionary<int, string> { { -1, "prošli petak" }, { 0, "ovaj petak" }, { 1, "sljedeći petak" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} petak" }, { PluralRulesValues.Few, "prije {0} petka" }, { PluralRulesValues.Other, "prije {0} petaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} petak" }, { PluralRulesValues.Few, "za {0} petka" }, { PluralRulesValues.Other, "za {0} petaka" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli pet." }, { 0, "ovaj pet." }, { 1, "sljedeći pet." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} petak" }, { PluralRulesValues.Few, "prije {0} petka" }, { PluralRulesValues.Other, "prije {0} petaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} petak" }, { PluralRulesValues.Few, "za {0} petka" }, { PluralRulesValues.Other, "za {0} petaka" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošli pet." }, { 0, "ovaj pet." }, { 1, "sljedeći pet." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} petak" }, { PluralRulesValues.Few, "prije {0} petka" }, { PluralRulesValues.Other, "prije {0} petaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} petak" }, { PluralRulesValues.Few, "za {0} petka" }, { PluralRulesValues.Other, "za {0} petaka" } })
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
									new Dictionary<int, string> { { -1, "prošla subota" }, { 0, "ova subota" }, { 1, "sljedeća subota" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} subotu" }, { PluralRulesValues.Few, "prije {0} subote" }, { PluralRulesValues.Other, "prije {0} subota" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} subotu" }, { PluralRulesValues.Few, "za {0} subote" }, { PluralRulesValues.Other, "za {0} subota" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošla sub." }, { 0, "ova sub." }, { 1, "sljedeća sub." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} subotu" }, { PluralRulesValues.Few, "prije {0} subote" }, { PluralRulesValues.Other, "prije {0} subota" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} subotu" }, { PluralRulesValues.Few, "za {0} subote" }, { PluralRulesValues.Other, "za {0} subota" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošla sub." }, { 0, "ova sub." }, { 1, "sljedeća sub." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} subotu" }, { PluralRulesValues.Few, "prije {0} subote" }, { PluralRulesValues.Other, "prije {0} subota" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} subotu" }, { PluralRulesValues.Few, "za {0} subote" }, { PluralRulesValues.Other, "za {0} subota" } })
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
									new Dictionary<int, string> { { 0, "ovaj sat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} sat" }, { PluralRulesValues.Few, "prije {0} sata" }, { PluralRulesValues.Other, "prije {0} sati" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sat" }, { PluralRulesValues.Few, "za {0} sata" }, { PluralRulesValues.Other, "za {0} sati" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ovaj sat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} h" }, { PluralRulesValues.Few, "prije {0} h" }, { PluralRulesValues.Other, "prije {0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} h" }, { PluralRulesValues.Few, "za {0} h" }, { PluralRulesValues.Other, "za {0} h" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ovaj sat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} h" }, { PluralRulesValues.Few, "prije {0} h" }, { PluralRulesValues.Other, "prije {0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} h" }, { PluralRulesValues.Few, "za {0} h" }, { PluralRulesValues.Other, "za {0} h" } })
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
									new Dictionary<int, string> { { 0, "ova minuta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} minutu" }, { PluralRulesValues.Few, "prije {0} minute" }, { PluralRulesValues.Other, "prije {0} minuta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} minutu" }, { PluralRulesValues.Few, "za {0} minute" }, { PluralRulesValues.Other, "za {0} minuta" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ova minuta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} min" }, { PluralRulesValues.Few, "prije {0} min" }, { PluralRulesValues.Other, "prije {0} min" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} min" }, { PluralRulesValues.Few, "za {0} min" }, { PluralRulesValues.Other, "za {0} min" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ova minuta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} min" }, { PluralRulesValues.Few, "prije {0} min" }, { PluralRulesValues.Other, "prije {0} min" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} min" }, { PluralRulesValues.Few, "za {0} min" }, { PluralRulesValues.Other, "za {0} min" } })
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
									new Dictionary<int, string> { { 0, "sad" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} sekundu" }, { PluralRulesValues.Few, "prije {0} sekunde" }, { PluralRulesValues.Other, "prije {0} sekundi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sekundu" }, { PluralRulesValues.Few, "za {0} sekunde" }, { PluralRulesValues.Other, "za {0} sekundi" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "sad" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} s" }, { PluralRulesValues.Few, "prije {0} s" }, { PluralRulesValues.Other, "prije {0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} s" }, { PluralRulesValues.Few, "za {0} s" }, { PluralRulesValues.Other, "za {0} s" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "sad" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prije {0} s" }, { PluralRulesValues.Few, "prije {0} s" }, { PluralRulesValues.Other, "prije {0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} s" }, { PluralRulesValues.Few, "za {0} s" }, { PluralRulesValues.Other, "za {0} s" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("hr");
		}
	}
}