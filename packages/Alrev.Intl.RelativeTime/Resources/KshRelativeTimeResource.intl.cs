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
	/// Relative Time Units resource for 'Colognian' [ksh]
	/// </summary>
	public class KshRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public KshRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "läz Johr" }, { 0, "diß Johr" }, { 1, "näx Johr" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Zero, "vör keijnem Johr" }, { PluralRulesValues.One, "vör {0} Johr" }, { PluralRulesValues.Other, "vör {0} Johre" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Zero, "en keinem Johr" }, { PluralRulesValues.One, "en {0} Johr" }, { PluralRulesValues.Other, "en {0} Johre" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "läz Johr" }, { 0, "diß Johr" }, { 1, "näx Johr" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Zero, "vör keijnem Johr" }, { PluralRulesValues.One, "vör {0} Johr" }, { PluralRulesValues.Other, "vör {0} Johre" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Zero, "en keinem Johr" }, { PluralRulesValues.One, "en {0} Johr" }, { PluralRulesValues.Other, "en {0} Johre" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "läz Johr" }, { 0, "diß Johr" }, { 1, "näx Johr" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Zero, "vör keijnem Johr" }, { PluralRulesValues.One, "vör {0} Johr" }, { PluralRulesValues.Other, "vör {0} Johre" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Zero, "en keinem Johr" }, { PluralRulesValues.One, "en {0} Johr" }, { PluralRulesValues.Other, "en {0} Johre" } })
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
									new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last quarter" }, { 0, "this quarter" }, { 1, "next quarter" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Q" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Q" } })
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
									new Dictionary<int, string> { { -1, "lätzde Mohnd" }, { 0, "diese Mohnd" }, { 1, "nächste Mohnd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "lätzde Mohnd" }, { 0, "diese Mohnd" }, { 1, "nächste Mohnd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "lätzde Mohnd" }, { 0, "diese Mohnd" }, { 1, "nächste Mohnd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } })
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
									new Dictionary<int, string> { { -1, "läz Woch" }, { 0, "di Woch" }, { 1, "nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "läz Woch" }, { 0, "di Woch" }, { 1, "nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "läz Woch" }, { 0, "di Woch" }, { 1, "nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } })
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
									new Dictionary<int, string> { { -2, "vörjestere" }, { -1, "jestere" }, { 0, "hück" }, { 1, "morje" }, { 2, "övvermorje" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "vörjestere" }, { -1, "jestere" }, { 0, "hück" }, { 1, "morje" }, { 2, "övvermorje" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "vörjestere" }, { -1, "jestere" }, { 0, "hück" }, { 1, "morje" }, { 2, "övvermorje" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } })
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
									new Dictionary<int, string> { { -1, "Sunndaach letzte Woche" }, { 0, "Sunndaach diese Woche" }, { 1, "Sunndaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sunndaach letzte Woche" }, { 0, "Sunndaach diese Woche" }, { 1, "Sunndaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sunndaach letzte Woche" }, { 0, "Sunndaach diese Woche" }, { 1, "Sunndaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } })
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
									new Dictionary<int, string> { { -1, "Moondaach letzte Woche" }, { 0, "Moondaach diese Woche" }, { 1, "Moondaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Moondaach letzte Woche" }, { 0, "Moondaach diese Woche" }, { 1, "Moondaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Moondaach letzte Woche" }, { 0, "Moondaach diese Woche" }, { 1, "Moondaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } })
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
									new Dictionary<int, string> { { -1, "Dinnsdaach letzte Woche" }, { 0, "Dinnsdaach diese Woche" }, { 1, "Dinnsdaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Dinnsdaach letzte Woche" }, { 0, "Dinnsdaach diese Woche" }, { 1, "Dinnsdaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Dinnsdaach letzte Woche" }, { 0, "Dinnsdaach diese Woche" }, { 1, "Dinnsdaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } })
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
									new Dictionary<int, string> { { -1, "Metwoch letzte Woche" }, { 0, "Metwoch diese Woche" }, { 1, "Metwoch nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Metwoch letzte Woche" }, { 0, "Metwoch diese Woche" }, { 1, "Metwoch nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Metwoch letzte Woche" }, { 0, "Metwoch diese Woche" }, { 1, "Metwoch nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } })
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
									new Dictionary<int, string> { { -1, "Dunnersdaach letzte Woche" }, { 0, "Dunnersdaach diese Woche" }, { 1, "Dunnersdaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Dunnersdaach letzte Woche" }, { 0, "Dunnersdaach diese Woche" }, { 1, "Dunnersdaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Dunnersdaach letzte Woche" }, { 0, "Dunnersdaach diese Woche" }, { 1, "Dunnersdaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } })
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
									new Dictionary<int, string> { { -1, "Friidaach letzte Woche" }, { 0, "Friidaach diese Woche" }, { 1, "Friidaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Friidaach letzte Woche" }, { 0, "Friidaach diese Woche" }, { 1, "Friidaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Friidaach letzte Woche" }, { 0, "Friidaach diese Woche" }, { 1, "Friidaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } })
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
									new Dictionary<int, string> { { -1, "Samsdaach letzte Woche" }, { 0, "Samsdaach diese Woche" }, { 1, "Samsdaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Samsdaach letzte Woche" }, { 0, "Samsdaach diese Woche" }, { 1, "Samsdaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Samsdaach letzte Woche" }, { 0, "Samsdaach diese Woche" }, { 1, "Samsdaach nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } })
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
									new Dictionary<int, string> { { 0, "this hour" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} h" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this hour" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} h" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this hour" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} h" } })
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
									new Dictionary<int, string> { { 0, "this minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} min" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} min" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} min" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} min" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} min" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} min" } })
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
									new Dictionary<int, string> { { 0, "now" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} s" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "now" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} s" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "now" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} s" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("ksh");
		}
	}
}