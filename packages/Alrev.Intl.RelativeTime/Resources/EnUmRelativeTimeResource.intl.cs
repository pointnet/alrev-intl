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
	/// Relative Time Units resource for 'English (U.S. Outlying Islands)' [en-um]
	/// </summary>
	public class EnUmRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public EnUmRelativeTimeResource()
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} year ago" }, { PluralRulesValues.Other, "{0} years ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} year" }, { PluralRulesValues.Other, "in {0} years" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last yr." }, { 0, "this yr." }, { 1, "next yr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yr. ago" }, { PluralRulesValues.Other, "{0} yr. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} yr." }, { PluralRulesValues.Other, "in {0} yr." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last yr." }, { 0, "this yr." }, { 1, "next yr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} yr. ago" }, { PluralRulesValues.Other, "{0} yr. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} yr." }, { PluralRulesValues.Other, "in {0} yr." } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} quarter ago" }, { PluralRulesValues.Other, "{0} quarters ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} quarter" }, { PluralRulesValues.Other, "in {0} quarters" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last qtr." }, { 0, "this qtr." }, { 1, "next qtr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} qtr. ago" }, { PluralRulesValues.Other, "{0} qtrs. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} qtr." }, { PluralRulesValues.Other, "in {0} qtrs." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last qtr." }, { 0, "this qtr." }, { 1, "next qtr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} qtr. ago" }, { PluralRulesValues.Other, "{0} qtrs. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} qtr." }, { PluralRulesValues.Other, "in {0} qtrs." } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} month ago" }, { PluralRulesValues.Other, "{0} months ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} month" }, { PluralRulesValues.Other, "in {0} months" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last mo." }, { 0, "this mo." }, { 1, "next mo." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mo. ago" }, { PluralRulesValues.Other, "{0} mo. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} mo." }, { PluralRulesValues.Other, "in {0} mo." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last mo." }, { 0, "this mo." }, { 1, "next mo." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mo. ago" }, { PluralRulesValues.Other, "{0} mo. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} mo." }, { PluralRulesValues.Other, "in {0} mo." } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} week ago" }, { PluralRulesValues.Other, "{0} weeks ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} week" }, { PluralRulesValues.Other, "in {0} weeks" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last wk." }, { 0, "this wk." }, { 1, "next wk." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} wk. ago" }, { PluralRulesValues.Other, "{0} wk. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} wk." }, { PluralRulesValues.Other, "in {0} wk." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last wk." }, { 0, "this wk." }, { 1, "next wk." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} wk. ago" }, { PluralRulesValues.Other, "{0} wk. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} wk." }, { PluralRulesValues.Other, "in {0} wk." } })
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
									new Dictionary<int, string> { { -1, "yesterday" }, { 0, "today" }, { 1, "tomorrow" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} day ago" }, { PluralRulesValues.Other, "{0} days ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} day" }, { PluralRulesValues.Other, "in {0} days" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "yesterday" }, { 0, "today" }, { 1, "tomorrow" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} day ago" }, { PluralRulesValues.Other, "{0} days ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} day" }, { PluralRulesValues.Other, "in {0} days" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "yesterday" }, { 0, "today" }, { 1, "tomorrow" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} day ago" }, { PluralRulesValues.Other, "{0} days ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} day" }, { PluralRulesValues.Other, "in {0} days" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sunday ago" }, { PluralRulesValues.Other, "{0} Sundays ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sunday" }, { PluralRulesValues.Other, "in {0} Sundays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Sun." }, { 0, "this Sun." }, { 1, "next Sun." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sun. ago" }, { PluralRulesValues.Other, "{0} Sun. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sun." }, { PluralRulesValues.Other, "in {0} Sun." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Su" }, { 0, "this Su" }, { 1, "next Su" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Su ago" }, { PluralRulesValues.Other, "{0} Su ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Su" }, { PluralRulesValues.Other, "in {0} Su" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Monday ago" }, { PluralRulesValues.Other, "{0} Mondays ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Monday" }, { PluralRulesValues.Other, "in {0} Mondays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Mon." }, { 0, "this Mon." }, { 1, "next Mon." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Mon. ago" }, { PluralRulesValues.Other, "{0} Mon. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Mon." }, { PluralRulesValues.Other, "in {0} Mon." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last M" }, { 0, "this M" }, { 1, "next M" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} M ago" }, { PluralRulesValues.Other, "{0} M ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} M" }, { PluralRulesValues.Other, "in {0} M" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tuesday ago" }, { PluralRulesValues.Other, "{0} Tuesdays ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Tuesday" }, { PluralRulesValues.Other, "in {0} Tuesdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Tue." }, { 0, "this Tue." }, { 1, "next Tue." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tue. ago" }, { PluralRulesValues.Other, "{0} Tue. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Tue." }, { PluralRulesValues.Other, "in {0} Tue." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Tu" }, { 0, "this Tu" }, { 1, "next Tu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Tu ago" }, { PluralRulesValues.Other, "{0} Tu ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Tu" }, { PluralRulesValues.Other, "in {0} Tu" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Wednesday ago" }, { PluralRulesValues.Other, "{0} Wednesdays ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Wednesday" }, { PluralRulesValues.Other, "in {0} Wednesdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Wed." }, { 0, "this Wed." }, { 1, "next Wed." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Wed. ago" }, { PluralRulesValues.Other, "{0} Wed. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Wed." }, { PluralRulesValues.Other, "in {0} Wed." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last W" }, { 0, "this W" }, { 1, "next W" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} W ago" }, { PluralRulesValues.Other, "{0} W ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} W" }, { PluralRulesValues.Other, "in {0} W" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Thursday ago" }, { PluralRulesValues.Other, "{0} Thursdays ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Thursday" }, { PluralRulesValues.Other, "in {0} Thursdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Thu." }, { 0, "this Thu." }, { 1, "next Thu." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Thu. ago" }, { PluralRulesValues.Other, "{0} Thu. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Thu." }, { PluralRulesValues.Other, "in {0} Thu." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Th" }, { 0, "this Th" }, { 1, "next Th" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Th ago" }, { PluralRulesValues.Other, "{0} Th ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Th" }, { PluralRulesValues.Other, "in {0} Th" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Friday ago" }, { PluralRulesValues.Other, "{0} Fridays ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Friday" }, { PluralRulesValues.Other, "in {0} Fridays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Fri." }, { 0, "this Fri." }, { 1, "next Fri." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Fri. ago" }, { PluralRulesValues.Other, "{0} Fri. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Fri." }, { PluralRulesValues.Other, "in {0} Fri." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last F" }, { 0, "this F" }, { 1, "next F" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} F ago" }, { PluralRulesValues.Other, "{0} F ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} F" }, { PluralRulesValues.Other, "in {0} F" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Saturday ago" }, { PluralRulesValues.Other, "{0} Saturdays ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Saturday" }, { PluralRulesValues.Other, "in {0} Saturdays" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Sat." }, { 0, "this Sat." }, { 1, "next Sat." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sat. ago" }, { PluralRulesValues.Other, "{0} Sat. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sat." }, { PluralRulesValues.Other, "in {0} Sat." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "last Sa" }, { 0, "this Sa" }, { 1, "next Sa" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Sa ago" }, { PluralRulesValues.Other, "{0} Sa ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sa" }, { PluralRulesValues.Other, "in {0} Sa" } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hour ago" }, { PluralRulesValues.Other, "{0} hours ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} hour" }, { PluralRulesValues.Other, "in {0} hours" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this hour" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hr. ago" }, { PluralRulesValues.Other, "{0} hr. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} hr." }, { PluralRulesValues.Other, "in {0} hr." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this hour" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hr. ago" }, { PluralRulesValues.Other, "{0} hr. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} hr." }, { PluralRulesValues.Other, "in {0} hr." } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minute ago" }, { PluralRulesValues.Other, "{0} minutes ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} minute" }, { PluralRulesValues.Other, "in {0} minutes" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. ago" }, { PluralRulesValues.Other, "{0} min. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} min." }, { PluralRulesValues.Other, "in {0} min." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "this minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. ago" }, { PluralRulesValues.Other, "{0} min. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} min." }, { PluralRulesValues.Other, "in {0} min." } })
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
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} second ago" }, { PluralRulesValues.Other, "{0} seconds ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} second" }, { PluralRulesValues.Other, "in {0} seconds" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "now" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sec. ago" }, { PluralRulesValues.Other, "{0} sec. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} sec." }, { PluralRulesValues.Other, "in {0} sec." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "now" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sec. ago" }, { PluralRulesValues.Other, "{0} sec. ago" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} sec." }, { PluralRulesValues.Other, "in {0} sec." } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("en-um");
		}
	}
}