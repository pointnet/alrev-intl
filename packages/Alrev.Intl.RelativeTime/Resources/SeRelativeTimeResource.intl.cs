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
	/// Relative Time Units resource for 'Northern Sami' [se]
	/// </summary>
	public class SeRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public SeRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jahki árat" }, { PluralRulesValues.Two, "{0} jahkki árat" }, { PluralRulesValues.Other, "{0} jahkki árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jahki maŋŋilit" }, { PluralRulesValues.Two, "{0} jahkki maŋŋilit" }, { PluralRulesValues.Other, "{0} jahkki maŋŋilit" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jahki árat" }, { PluralRulesValues.Two, "{0} jahkki árat" }, { PluralRulesValues.Other, "{0} jahkki árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jahki maŋŋilit" }, { PluralRulesValues.Two, "{0} jahkki maŋŋilit" }, { PluralRulesValues.Other, "{0} jahkki maŋŋilit" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last year" }, { 0, "this year" }, { 1, "next year" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jahki árat" }, { PluralRulesValues.Two, "{0} jahkki árat" }, { PluralRulesValues.Other, "{0} jahkki árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jahki maŋŋilit" }, { PluralRulesValues.Two, "{0} jahkki maŋŋilit" }, { PluralRulesValues.Other, "{0} jahkki maŋŋilit" } })
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
									new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mánotbadji árat" }, { PluralRulesValues.Two, "{0} mánotbadji árat" }, { PluralRulesValues.Other, "{0} mánotbadji árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mánotbadji maŋŋilit" }, { PluralRulesValues.Two, "{0} mánotbadji maŋŋilit" }, { PluralRulesValues.Other, "{0} mánotbadji maŋŋilit" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mánotbadji árat" }, { PluralRulesValues.Two, "{0} mánotbadji árat" }, { PluralRulesValues.Other, "{0} mánotbadji árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mánotbadji maŋŋilit" }, { PluralRulesValues.Two, "{0} mánotbadji maŋŋilit" }, { PluralRulesValues.Other, "{0} mánotbadji maŋŋilit" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last month" }, { 0, "this month" }, { 1, "next month" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mánotbadji árat" }, { PluralRulesValues.Two, "{0} mánotbadji árat" }, { PluralRulesValues.Other, "{0} mánotbadji árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mánotbadji maŋŋilit" }, { PluralRulesValues.Two, "{0} mánotbadji maŋŋilit" }, { PluralRulesValues.Other, "{0} mánotbadji maŋŋilit" } })
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
									new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vahku árat" }, { PluralRulesValues.Two, "{0} vahkku árat" }, { PluralRulesValues.Other, "{0} vahkku árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vahku maŋŋilit" }, { PluralRulesValues.Two, "{0} vahkku maŋŋilit" }, { PluralRulesValues.Other, "{0} vahkku maŋŋilit" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vahku árat" }, { PluralRulesValues.Two, "{0} vahkku árat" }, { PluralRulesValues.Other, "{0} vahkku árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vahku maŋŋilit" }, { PluralRulesValues.Two, "{0} vahkku maŋŋilit" }, { PluralRulesValues.Other, "{0} vahkku maŋŋilit" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last week" }, { 0, "this week" }, { 1, "next week" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vahku árat" }, { PluralRulesValues.Two, "{0} vahkku árat" }, { PluralRulesValues.Other, "{0} vahkku árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vahku maŋŋilit" }, { PluralRulesValues.Two, "{0} vahkku maŋŋilit" }, { PluralRulesValues.Other, "{0} vahkku maŋŋilit" } })
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
									new Dictionary<int, string> { { -2, "oovdebpeivvi" }, { -1, "ikte" }, { 0, "odne" }, { 1, "ihttin" }, { 2, "paijeelittáá" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jándor árat" }, { PluralRulesValues.Two, "{0} jándora árat" }, { PluralRulesValues.Other, "{0} jándora árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jándor maŋŋilit" }, { PluralRulesValues.Two, "{0} jándor amaŋŋilit" }, { PluralRulesValues.Other, "{0} jándora maŋŋilit" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "oovdebpeivvi" }, { -1, "ikte" }, { 0, "odne" }, { 1, "ihttin" }, { 2, "paijeelittáá" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jándor árat" }, { PluralRulesValues.Two, "{0} jándora árat" }, { PluralRulesValues.Other, "{0} jándora árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jándor maŋŋilit" }, { PluralRulesValues.Two, "{0} jándor amaŋŋilit" }, { PluralRulesValues.Other, "{0} jándora maŋŋilit" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "oovdebpeivvi" }, { -1, "ikte" }, { 0, "odne" }, { 1, "ihttin" }, { 2, "paijeelittáá" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jándor árat" }, { PluralRulesValues.Two, "{0} jándora árat" }, { PluralRulesValues.Other, "{0} jándora árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jándor maŋŋilit" }, { PluralRulesValues.Two, "{0} jándor amaŋŋilit" }, { PluralRulesValues.Other, "{0} jándora maŋŋilit" } })
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
									new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "-{0} Sundays" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "+{0} Sundays" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Sunday" }, { 0, "this Sunday" }, { 1, "next Sunday" } },
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} diibmu árat" }, { PluralRulesValues.Two, "{0} diibmur árat" }, { PluralRulesValues.Other, "{0} diibmur árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} diibmu maŋŋilit" }, { PluralRulesValues.Two, "{0} diibmur maŋŋilit" }, { PluralRulesValues.Other, "{0} diibmur maŋŋilit" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this hour" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} diibmu árat" }, { PluralRulesValues.Two, "{0} diibmur árat" }, { PluralRulesValues.Other, "{0} diibmur árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} diibmu maŋŋilit" }, { PluralRulesValues.Two, "{0} diibmur maŋŋilit" }, { PluralRulesValues.Other, "{0} diibmur maŋŋilit" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this hour" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} diibmu árat" }, { PluralRulesValues.Two, "{0} diibmur árat" }, { PluralRulesValues.Other, "{0} diibmur árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} diibmu maŋŋilit" }, { PluralRulesValues.Two, "{0} diibmur maŋŋilit" }, { PluralRulesValues.Other, "{0} diibmur maŋŋilit" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuhta árat" }, { PluralRulesValues.Two, "{0} minuhtta árat" }, { PluralRulesValues.Other, "{0} minuhtta árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuhta maŋŋilit" }, { PluralRulesValues.Two, "{0} minuhtta maŋŋilit" }, { PluralRulesValues.Other, "{0} minuhtta maŋŋilit" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuhta árat" }, { PluralRulesValues.Two, "{0} minuhtta árat" }, { PluralRulesValues.Other, "{0} minuhtta árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuhta maŋŋilit" }, { PluralRulesValues.Two, "{0} minuhtta maŋŋilit" }, { PluralRulesValues.Other, "{0} minuhtta maŋŋilit" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuhta árat" }, { PluralRulesValues.Two, "{0} minuhtta árat" }, { PluralRulesValues.Other, "{0} minuhtta árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuhta maŋŋilit" }, { PluralRulesValues.Two, "{0} minuhtta maŋŋilit" }, { PluralRulesValues.Other, "{0} minuhtta maŋŋilit" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekunda árat" }, { PluralRulesValues.Two, "{0} sekundda árat" }, { PluralRulesValues.Other, "{0} sekundda árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekunda maŋŋilit" }, { PluralRulesValues.Two, "{0} sekundda maŋŋilit" }, { PluralRulesValues.Other, "{0} sekundda maŋŋilit" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "now" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekunda árat" }, { PluralRulesValues.Two, "{0} sekundda árat" }, { PluralRulesValues.Other, "{0} sekundda árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekunda maŋŋilit" }, { PluralRulesValues.Two, "{0} sekundda maŋŋilit" }, { PluralRulesValues.Other, "{0} sekundda maŋŋilit" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "now" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekunda árat" }, { PluralRulesValues.Two, "{0} sekundda árat" }, { PluralRulesValues.Other, "{0} sekundda árat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekunda maŋŋilit" }, { PluralRulesValues.Two, "{0} sekundda maŋŋilit" }, { PluralRulesValues.Other, "{0} sekundda maŋŋilit" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("se");
		}
	}
}