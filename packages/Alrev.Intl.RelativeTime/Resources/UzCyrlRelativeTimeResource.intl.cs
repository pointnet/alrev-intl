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
	/// Relative Time Units resource for 'Uzbek' [uz-cyrl]
	/// </summary>
	public class UzCyrlRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public UzCyrlRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "ўтган йил" }, { 0, "бу йил" }, { 1, "кейинги йил" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} йил аввал" }, { PluralRulesValues.Other, "{0} йил аввал" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} йилдан сўнг" }, { PluralRulesValues.Other, "{0} йилдан сўнг" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган йил" }, { 0, "бу йил" }, { 1, "кейинги йил" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} йил аввал" }, { PluralRulesValues.Other, "{0} йил аввал" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} йилдан сўнг" }, { PluralRulesValues.Other, "{0} йилдан сўнг" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган йил" }, { 0, "бу йил" }, { 1, "кейинги йил" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} йил аввал" }, { PluralRulesValues.Other, "{0} йил аввал" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} йилдан сўнг" }, { PluralRulesValues.Other, "{0} йилдан сўнг" } })
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
									new Dictionary<int, string> { { -1, "ўтган ой" }, { 0, "бу ой" }, { 1, "кейинги ой" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ой аввал" }, { PluralRulesValues.Other, "{0} ой аввал" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ойдан сўнг" }, { PluralRulesValues.Other, "{0} ойдан сўнг" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган ой" }, { 0, "бу ой" }, { 1, "кейинги ой" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ой аввал" }, { PluralRulesValues.Other, "{0} ой аввал" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ойдан сўнг" }, { PluralRulesValues.Other, "{0} ойдан сўнг" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган ой" }, { 0, "бу ой" }, { 1, "кейинги ой" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ой аввал" }, { PluralRulesValues.Other, "{0} ой аввал" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ойдан сўнг" }, { PluralRulesValues.Other, "{0} ойдан сўнг" } })
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
									new Dictionary<int, string> { { -1, "ўтган ҳафта" }, { 0, "бу ҳафта" }, { 1, "кейинги ҳафта" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ҳафта олдин" }, { PluralRulesValues.Other, "{0} ҳафта олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ҳафтадан сўнг" }, { PluralRulesValues.Other, "{0} ҳафтадан сўнг" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган ҳафта" }, { 0, "бу ҳафта" }, { 1, "кейинги ҳафта" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ҳафта олдин" }, { PluralRulesValues.Other, "{0} ҳафта олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ҳафтадан сўнг" }, { PluralRulesValues.Other, "{0} ҳафтадан сўнг" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган ҳафта" }, { 0, "бу ҳафта" }, { 1, "кейинги ҳафта" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ҳафта олдин" }, { PluralRulesValues.Other, "{0} ҳафта олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ҳафтадан сўнг" }, { PluralRulesValues.Other, "{0} ҳафтадан сўнг" } })
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
									new Dictionary<int, string> { { -1, "кеча" }, { 0, "бугун" }, { 1, "эртага" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} кун олдин" }, { PluralRulesValues.Other, "{0} кун олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} кундан сўнг" }, { PluralRulesValues.Other, "{0} кундан сўнг" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "кеча" }, { 0, "бугун" }, { 1, "эртага" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} кун олдин" }, { PluralRulesValues.Other, "{0} кун олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} кундан сўнг" }, { PluralRulesValues.Other, "{0} кундан сўнг" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "кеча" }, { 0, "бугун" }, { 1, "эртага" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} кун олдин" }, { PluralRulesValues.Other, "{0} кун олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} кундан сўнг" }, { PluralRulesValues.Other, "{0} кундан сўнг" } })
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
									new Dictionary<int, string> { { -1, "ўтган якшанба" }, { 0, "бу якшанба" }, { 1, "кейинги якшанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган якшанба" }, { 0, "бу якшанба" }, { 1, "кейинги якшанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган якшанба" }, { 0, "бу якшанба" }, { 1, "кейинги якшанба" } },
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
									new Dictionary<int, string> { { -1, "ўтган душанба" }, { 0, "бу душанба" }, { 1, "кейинги душанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган душанба" }, { 0, "бу душанба" }, { 1, "кейинги душанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Mondays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Mondays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган душанба" }, { 0, "бу душанба" }, { 1, "кейинги душанба" } },
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
									new Dictionary<int, string> { { -1, "ўтган сешанба" }, { 0, "бу сешанба" }, { 1, "кейинги сешанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган сешанба" }, { 0, "бу сешанба" }, { 1, "кейинги сешанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Tuesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Tuesdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган сешанба" }, { 0, "бу сешанба" }, { 1, "кейинги сешанба" } },
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
									new Dictionary<int, string> { { -1, "ўтган чоршанба" }, { 0, "this Wednesday" }, { 1, "кейинги чоршанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган чоршанба" }, { 0, "this Wednesday" }, { 1, "кейинги чоршанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Wednesdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Wednesdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган чоршанба" }, { 0, "this Wednesday" }, { 1, "кейинги чоршанба" } },
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
									new Dictionary<int, string> { { -1, "ўтган пайшанба" }, { 0, "бу пайшанба" }, { 1, "кейинги пайшанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган пайшанба" }, { 0, "бу пайшанба" }, { 1, "кейинги пайшанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Thursdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Thursdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган пайшанба" }, { 0, "бу пайшанба" }, { 1, "кейинги пайшанба" } },
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
									new Dictionary<int, string> { { -1, "ўтган жума" }, { 0, "бу жума" }, { 1, "кейинги жума" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган жума" }, { 0, "бу жума" }, { 1, "кейинги жума" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Fridays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Fridays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган жума" }, { 0, "бу жума" }, { 1, "кейинги жума" } },
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
									new Dictionary<int, string> { { -1, "ўтган шанба" }, { 0, "бу шанба" }, { 1, "кейинги шанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган шанба" }, { 0, "бу шанба" }, { 1, "кейинги шанба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Saturdays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Saturdays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ўтган шанба" }, { 0, "бу шанба" }, { 1, "кейинги шанба" } },
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} соат олдин" }, { PluralRulesValues.Other, "{0} соат олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} соатдан сўнг" }, { PluralRulesValues.Other, "{0} соатдан сўнг" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this hour" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} соат олдин" }, { PluralRulesValues.Other, "{0} соат олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} соатдан сўнг" }, { PluralRulesValues.Other, "{0} соатдан сўнг" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this hour" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} соат олдин" }, { PluralRulesValues.Other, "{0} соат олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} соатдан сўнг" }, { PluralRulesValues.Other, "{0} соатдан сўнг" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дақиқа олдин" }, { PluralRulesValues.Other, "{0} дақиқа олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дақиқадан сўнг" }, { PluralRulesValues.Other, "{0} дақиқадан сўнг" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дақиқа олдин" }, { PluralRulesValues.Other, "{0} дақиқа олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дақиқадан сўнг" }, { PluralRulesValues.Other, "{0} дақиқадан сўнг" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дақиқа олдин" }, { PluralRulesValues.Other, "{0} дақиқа олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дақиқадан сўнг" }, { PluralRulesValues.Other, "{0} дақиқадан сўнг" } })
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
									new Dictionary<int, string> { { 0, "ҳозир" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сония олдин" }, { PluralRulesValues.Other, "{0} сония олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сониядан сўнг" }, { PluralRulesValues.Other, "{0} сониядан сўнг" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ҳозир" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сония олдин" }, { PluralRulesValues.Other, "{0} сония олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сониядан сўнг" }, { PluralRulesValues.Other, "{0} сониядан сўнг" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ҳозир" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сония олдин" }, { PluralRulesValues.Other, "{0} сония олдин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сониядан сўнг" }, { PluralRulesValues.Other, "{0} сониядан сўнг" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("uz-cyrl");
		}
	}
}