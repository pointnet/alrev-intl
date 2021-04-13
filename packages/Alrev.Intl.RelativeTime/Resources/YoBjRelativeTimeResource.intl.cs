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
	/// Relative Time Units resource for 'Yoruba (Benin)' [yo-bj]
	/// </summary>
	public class YoBjRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public YoBjRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "Èshín" }, { 0, "Ɔdúnǹí" }, { 1, "Àmɔ́dún" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} y" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} y" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Ɔdún tó kɔjá" }, { 0, "Ɔdún yìí" }, { 1, "Ɔdún tó ńbɔ̀" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} y" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} y" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Ɔdún tó kɔjá" }, { 0, "Ɔdún yìí" }, { 1, "Ɔdún tó ńbɔ̀" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} y" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} y" } })
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
									new Dictionary<int, string> { { -1, "óshù tó kɔjá" }, { 0, "oshù yìí" }, { 1, "óshù tó ń bɔ̀," } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "óshù tó kɔjá" }, { 0, "oshù yìí" }, { 1, "óshù tó ń bɔ̀," } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} m" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} m" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "óshù tó kɔjá" }, { 0, "oshù yìí" }, { 1, "óshù tó ń bɔ̀," } },
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
									new Dictionary<int, string> { { -1, "ɔ̀sɛ̀ tó kɔjá" }, { 0, "ɔ̀sɛ̀ yìí" }, { 1, "ɔ́sɛ̀ tó ń bɔ̀" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ɔ̀sɛ̀ tó kɔjá" }, { 0, "ɔ̀sɛ̀ yìí" }, { 1, "ɔ́sɛ̀ tó ń bɔ̀" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} w" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} w" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ɔ̀sɛ̀ tó kɔjá" }, { 0, "ɔ̀sɛ̀ yìí" }, { 1, "ɔ́sɛ̀ tó ń bɔ̀" } },
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
									new Dictionary<int, string> { { -2, "íjɛta" }, { -1, "Àná" }, { 0, "Òní" }, { 1, "Ɔ̀la" }, { 2, "òtúùnla" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "íjɛta" }, { -1, "Àná" }, { 0, "Òní" }, { 1, "Ɔ̀la" }, { 2, "òtúùnla" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} d" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} d" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "íjɛta" }, { -1, "Àná" }, { 0, "Òní" }, { 1, "Ɔ̀la" }, { 2, "òtúùnla" } },
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
									new Dictionary<int, string> { { -1, "Ɔjɔ́ Àìkú tó kɔjá" }, { 0, "Ɔjɔ́ Àìkú yìí" }, { 1, "Ɔjɔ́ Àìkú tó ń bɔ̀" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Ɔjɔ́ Àìkú tó kɔjá" }, { 0, "Ɔjɔ́ Àìkú yìí" }, { 1, "Ɔjɔ́ Àìkú tó ń bɔ̀" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Ɔjɔ́ Àìkú tó kɔjá" }, { 0, "Ɔjɔ́ Àìkú yìí" }, { 1, "Ɔjɔ́ Àìkú tó ń bɔ̀" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ɔjɔ́ Àíkú +{0}" } })
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
									new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Monday" }, { 0, "this Monday" }, { 1, "next Monday" } },
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
									new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Tuesday" }, { 0, "this Tuesday" }, { 1, "next Tuesday" } },
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
									new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Wednesday" }, { 0, "this Wednesday" }, { 1, "next Wednesday" } },
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
									new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Thursday" }, { 0, "this Thursday" }, { 1, "next Thursday" } },
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
									new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Friday" }, { 0, "this Friday" }, { 1, "next Friday" } },
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
									new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Saturday" }, { 0, "this Saturday" }, { 1, "next Saturday" } },
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
			this.Culture = new CultureInfo("yo-bj");
		}
	}
}