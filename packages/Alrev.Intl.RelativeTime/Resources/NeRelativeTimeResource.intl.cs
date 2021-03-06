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
	/// Relative Time Units resource for 'Nepali' [ne]
	/// </summary>
	public class NeRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public NeRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "गत वर्ष" }, { 0, "यो वर्ष" }, { 1, "आगामी वर्ष" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्ष अघि" }, { PluralRulesValues.Other, "{0} वर्ष अघि" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षमा" }, { PluralRulesValues.Other, "{0} वर्षमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत वर्ष" }, { 0, "यो वर्ष" }, { 1, "आगामी वर्ष" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्ष अघि" }, { PluralRulesValues.Other, "{0} वर्ष अघि" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षमा" }, { PluralRulesValues.Other, "{0} वर्षमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत वर्ष" }, { 0, "यो वर्ष" }, { 1, "आगामी वर्ष" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्ष अघि" }, { PluralRulesValues.Other, "{0} वर्ष अघि" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षमा" }, { PluralRulesValues.Other, "{0} वर्षमा" } })
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
									new Dictionary<int, string> { { -1, "अघिल्लो सत्र" }, { 0, "यो सत्र" }, { 1, "अर्को सत्र" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्र अघि" }, { PluralRulesValues.Other, "{0}सत्र अघि" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} सत्रमा" }, { PluralRulesValues.Other, "{0}सत्रमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "अघिल्लो सत्र" }, { 0, "यो सत्र" }, { 1, "अर्को सत्र" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्र अघि" }, { PluralRulesValues.Other, "{0}सत्र अघि" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्रमा" }, { PluralRulesValues.Other, "{0}सत्रमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "अघिल्लो सत्र" }, { 0, "यो सत्र" }, { 1, "अर्को सत्र" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्र अघि" }, { PluralRulesValues.Other, "{0}सत्र अघि" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}सत्रमा" }, { PluralRulesValues.Other, "{0}सत्रमा" } })
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
									new Dictionary<int, string> { { -1, "गत महिना" }, { 0, "यो महिना" }, { 1, "अर्को महिना" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिना पहिले" }, { PluralRulesValues.Other, "{0} महिना पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिनामा" }, { PluralRulesValues.Other, "{0} महिनामा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत महिना" }, { 0, "यो महिना" }, { 1, "आगामी महिना" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिना पहिले" }, { PluralRulesValues.Other, "{0} महिना पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिनामा" }, { PluralRulesValues.Other, "{0} महिनामा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत महिना" }, { 0, "यो महिना" }, { 1, "आगामी महिना" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिना पहिले" }, { PluralRulesValues.Other, "{0} महिना पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिनामा" }, { PluralRulesValues.Other, "{0} महिनामा" } })
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
									new Dictionary<int, string> { { -1, "गत हप्ता" }, { 0, "यो हप्ता" }, { 1, "आउने हप्ता" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्ता पहिले" }, { PluralRulesValues.Other, "{0} हप्ता पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्तामा" }, { PluralRulesValues.Other, "{0} हप्तामा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत हप्ता" }, { 0, "यो हप्ता" }, { 1, "आगामी हप्ता" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्ता पहिले" }, { PluralRulesValues.Other, "{0} हप्ता पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्तामा" }, { PluralRulesValues.Other, "{0} हप्तामा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत हप्ता" }, { 0, "यो हप्ता" }, { 1, "आगामी हप्ता" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्ता पहिले" }, { PluralRulesValues.Other, "{0} हप्ता पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} हप्तामा" }, { PluralRulesValues.Other, "{0} हप्तामा" } })
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
									new Dictionary<int, string> { { -2, "अस्ति" }, { -1, "हिजो" }, { 0, "आज" }, { 1, "भोलि" }, { 2, "पर्सि" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिन पहिले" }, { PluralRulesValues.Other, "{0} दिन पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिनमा" }, { PluralRulesValues.Other, "{0} दिनमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "अस्ति" }, { -1, "हिजो" }, { 0, "आज" }, { 1, "भोलि" }, { 2, "पर्सि" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिन पहिले" }, { PluralRulesValues.Other, "{0} दिन पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिनमा" }, { PluralRulesValues.Other, "{0} दिनमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "अस्ति" }, { -1, "हिजो" }, { 0, "आज" }, { 1, "भोलि" }, { 2, "पर्सि" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिन पहिले" }, { PluralRulesValues.Other, "{0} दिन पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिनमा" }, { PluralRulesValues.Other, "{0} दिनमा" } })
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
									new Dictionary<int, string> { { -1, "गत आइतबार" }, { 0, "यो आइतबार" }, { 1, "अर्को आइतबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0}आइतबार पहिले" }, { PluralRulesValues.Other, "{0} आइतबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारमा" }, { PluralRulesValues.Other, "{0} आइतबारहरूमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत आइतबार" }, { 0, "यो आइतबार" }, { 1, "अर्को आइतबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारहरू पहिले" }, { PluralRulesValues.Other, "{0} आइतबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारहरूमा" }, { PluralRulesValues.Other, "{0} आइतबारहरूमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत आइतबार" }, { 0, "यो आइतबार" }, { 1, "अर्को आइतबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारहरू पहिले" }, { PluralRulesValues.Other, "{0} आइतबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आइतबारहरूमा" }, { PluralRulesValues.Other, "{0} आइतबारहरूमा" } })
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
									new Dictionary<int, string> { { -1, "गत सोमबार" }, { 0, "यो सोमबार" }, { 1, "अर्को सोमबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबार पहिले" }, { PluralRulesValues.Other, "{0} सोमबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबारहरूमा" }, { PluralRulesValues.Other, "{0} सोमबारहरूमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत सोमबार" }, { 0, "यो सोमबार" }, { 1, "अर्को सोमबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबार पहिले" }, { PluralRulesValues.Other, "{0} सोमबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबारहरूमा" }, { PluralRulesValues.Other, "{0} सोमबारहरूमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत सोमबार" }, { 0, "यो सोमबार" }, { 1, "अर्को सोमबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबार पहिले" }, { PluralRulesValues.Other, "{0}सोमबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमबारहरूमा" }, { PluralRulesValues.Other, "{0} सोमबारहरूमा" } })
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
									new Dictionary<int, string> { { -1, "गत मंगलबार" }, { 0, "यो मंगलबार" }, { 1, "अर्को मंगलबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबार पहिले" }, { PluralRulesValues.Other, "{0} मंगलबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबारमा" }, { PluralRulesValues.Other, "{0} मंगलबारहरूमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत मंगलबार" }, { 0, "यो मंगलबार" }, { 1, "अर्को मंगलबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबार पहिले" }, { PluralRulesValues.Other, "{0} मंगलबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबारमा" }, { PluralRulesValues.Other, "{0} मंगलबारहरूमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत मंगलबार" }, { 0, "यो मंगलबार" }, { 1, "अर्को मंगलबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबार पहिले" }, { PluralRulesValues.Other, "{0} मंगलबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगलबारमा" }, { PluralRulesValues.Other, "{0} मंगलबारहरूमा" } })
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
									new Dictionary<int, string> { { -1, "गत बुधबार" }, { 0, "यो बुधबार" }, { 1, "अर्को बुधबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबार पहिले" }, { PluralRulesValues.Other, "{0} बुधबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबारमा" }, { PluralRulesValues.Other, "{0} बुधबारमाहरूमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत बुधबार" }, { 0, "यो बुधबार" }, { 1, "अर्को बुधबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबार पहिले" }, { PluralRulesValues.Other, "{0} बुधबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबारमा" }, { PluralRulesValues.Other, "{0} बुधबारमाहरूमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत बुधबार" }, { 0, "यो बुधबार" }, { 1, "अर्को बुधबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबार पहिले" }, { PluralRulesValues.Other, "{0} बुधबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधबारमा" }, { PluralRulesValues.Other, "{0} बुधबारमाहरूमा" } })
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
									new Dictionary<int, string> { { -1, "गत बिहिबार" }, { 0, "यो बिहिबार" }, { 1, "अर्को बिहिबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबार पहिले" }, { PluralRulesValues.Other, "{0} बिहिबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबारमा" }, { PluralRulesValues.Other, "{0} बिहिबारहरूमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत बिहिबार" }, { 0, "यो बिहिबार" }, { 1, "अर्को बिहिबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबार पहिले" }, { PluralRulesValues.Other, "{0} बिहिबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबारमा" }, { PluralRulesValues.Other, "{0} बिहिबारहरूमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत बिहिबार" }, { 0, "यो बिहिबार" }, { 1, "अर्को बिहिबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबार पहिले" }, { PluralRulesValues.Other, "{0} बिहिबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बिहिबारमा" }, { PluralRulesValues.Other, "{0} बिहिबारहरूमा" } })
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
									new Dictionary<int, string> { { -1, "गत शुक्रबार" }, { 0, "यो शुक्रबार" }, { 1, "अर्को शुक्रबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबार पहिले" }, { PluralRulesValues.Other, "{0} शुक्रबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबारमा" }, { PluralRulesValues.Other, "{0} शुक्रबारहरूमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत शुक्रबार" }, { 0, "यो शुक्रबार" }, { 1, "अर्को शुक्रबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबार पहिले" }, { PluralRulesValues.Other, "{0} शुक्रबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबारमा" }, { PluralRulesValues.Other, "{0} शुक्रबारहरूमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत शुक्रबार" }, { 0, "यो शुक्रबार" }, { 1, "अर्को शुक्रबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबार पहिले" }, { PluralRulesValues.Other, "{0} शुक्रबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रबारमा" }, { PluralRulesValues.Other, "{0} शुक्रबारहरूमा" } })
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
									new Dictionary<int, string> { { -1, "गत शनिबार" }, { 0, "यो शनिबार" }, { 1, "अर्को शनिबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबार पहिले" }, { PluralRulesValues.Other, "{0} शनिबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबारमा" }, { PluralRulesValues.Other, "{0} शनिबारहरूमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत शनिबार" }, { 0, "यो शनिबार" }, { 1, "अर्को शनिबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबार पहिले" }, { PluralRulesValues.Other, "{0} शनिबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबारमा" }, { PluralRulesValues.Other, "{0} शनिबारहरूमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "गत शनिबार" }, { 0, "यो शनिबार" }, { 1, "अर्को शनिबार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबार पहिले" }, { PluralRulesValues.Other, "{0} शनिबारहरू पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिबारमा" }, { PluralRulesValues.Other, "{0} शनिबारहरूमा" } })
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
									new Dictionary<int, string> { { 0, "यस घडीमा" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टा पहिले" }, { PluralRulesValues.Other, "{0} घण्टा पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टामा" }, { PluralRulesValues.Other, "{0} घण्टामा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "यस घडीमा" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टा पहिले" }, { PluralRulesValues.Other, "{0} घण्टा पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टामा" }, { PluralRulesValues.Other, "{0} घण्टामा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "यस घडीमा" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टा पहिले" }, { PluralRulesValues.Other, "{0} घण्टा पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} घण्टामा" }, { PluralRulesValues.Other, "{0} घण्टामा" } })
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
									new Dictionary<int, string> { { 0, "यही मिनेटमा" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेट पहिले" }, { PluralRulesValues.Other, "{0} मिनेट पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेटमा" }, { PluralRulesValues.Other, "{0} मिनेटमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "यही मिनेटमा" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेट पहिले" }, { PluralRulesValues.Other, "{0} मिनेट पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेटमा" }, { PluralRulesValues.Other, "{0} मिनेटमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "यही मिनेटमा" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेट पहिले" }, { PluralRulesValues.Other, "{0} मिनेट पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनेटमा" }, { PluralRulesValues.Other, "{0} मिनेटमा" } })
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
									new Dictionary<int, string> { { 0, "अहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्ड पहिले" }, { PluralRulesValues.Other, "{0} सेकेन्ड पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्डमा" }, { PluralRulesValues.Other, "{0} सेकेन्डमा" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "अहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्ड पहिले" }, { PluralRulesValues.Other, "{0} सेकेन्ड पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्डमा" }, { PluralRulesValues.Other, "{0} सेकेन्डमा" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "अहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्ड पहिले" }, { PluralRulesValues.Other, "{0} सेकेन्ड पहिले" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकेन्डमा" }, { PluralRulesValues.Other, "{0} सेकेन्डमा" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("ne");
		}
	}
}