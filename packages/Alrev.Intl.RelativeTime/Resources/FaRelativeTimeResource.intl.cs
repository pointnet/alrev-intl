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
	/// Relative Time Units resource for 'Persian' [fa]
	/// </summary>
	public class FaRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public FaRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "سال گذشته" }, { 0, "امسال" }, { 1, "سال آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال پیش" }, { PluralRulesValues.Other, "{0} سال پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال بعد" }, { PluralRulesValues.Other, "{0} سال بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "سال گذشته" }, { 0, "امسال" }, { 1, "سال آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال پیش" }, { PluralRulesValues.Other, "{0} سال پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال بعد" }, { PluralRulesValues.Other, "{0} سال بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "سال گذشته" }, { 0, "امسال" }, { 1, "سال آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال پیش" }, { PluralRulesValues.Other, "{0} سال پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال بعد" }, { PluralRulesValues.Other, "{0} سال بعد" } })
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
									new Dictionary<int, string> { { -1, "سه‌ماههٔ گذشته" }, { 0, "سه‌ماههٔ کنونی" }, { 1, "سه‌ماههٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌ماههٔ پیش" }, { PluralRulesValues.Other, "{0} سه‌ماههٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌ماههٔ بعد" }, { PluralRulesValues.Other, "{0} سه‌ماههٔ بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "سه‌ماههٔ گذشته" }, { 0, "سه‌ماههٔ کنونی" }, { 1, "سه‌ماههٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌ماههٔ پیش" }, { PluralRulesValues.Other, "{0} سه‌ماههٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌ماههٔ بعد" }, { PluralRulesValues.Other, "{0} سه‌ماههٔ بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "سه‌ماههٔ گذشته" }, { 0, "سه‌ماههٔ کنونی" }, { 1, "سه‌ماههٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌ماههٔ پیش" }, { PluralRulesValues.Other, "{0} سه‌ماههٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌ماههٔ بعد" }, { PluralRulesValues.Other, "{0} سه‌ماههٔ بعد" } })
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
									new Dictionary<int, string> { { -1, "ماه گذشته" }, { 0, "این ماه" }, { 1, "ماه آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماه پیش" }, { PluralRulesValues.Other, "{0} ماه پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماه بعد" }, { PluralRulesValues.Other, "{0} ماه بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ماه گذشته" }, { 0, "این ماه" }, { 1, "ماه آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماه پیش" }, { PluralRulesValues.Other, "{0} ماه پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماه بعد" }, { PluralRulesValues.Other, "{0} ماه بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ماه گذشته" }, { 0, "این ماه" }, { 1, "ماه آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماه پیش" }, { PluralRulesValues.Other, "{0} ماه پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماه بعد" }, { PluralRulesValues.Other, "{0} ماه بعد" } })
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
									new Dictionary<int, string> { { -1, "هفتهٔ گذشته" }, { 0, "این هفته" }, { 1, "هفتهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفته پیش" }, { PluralRulesValues.Other, "{0} هفته پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفته بعد" }, { PluralRulesValues.Other, "{0} هفته بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "هفتهٔ گذشته" }, { 0, "این هفته" }, { 1, "هفتهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفته پیش" }, { PluralRulesValues.Other, "{0} هفته پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفته بعد" }, { PluralRulesValues.Other, "{0} هفته بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "هفتهٔ گذشته" }, { 0, "این هفته" }, { 1, "هفتهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفته پیش" }, { PluralRulesValues.Other, "{0} هفته پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفته بعد" }, { PluralRulesValues.Other, "{0} هفته بعد" } })
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
									new Dictionary<int, string> { { -2, "پریروز" }, { -1, "دیروز" }, { 0, "امروز" }, { 1, "فردا" }, { 2, "پس‌فردا" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} روز پیش" }, { PluralRulesValues.Other, "{0} روز پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} روز بعد" }, { PluralRulesValues.Other, "{0} روز بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "پریروز" }, { -1, "دیروز" }, { 0, "امروز" }, { 1, "فردا" }, { 2, "پس‌فردا" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} روز پیش" }, { PluralRulesValues.Other, "{0} روز پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} روز بعد" }, { PluralRulesValues.Other, "{0} روز بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "پریروز" }, { -1, "دیروز" }, { 0, "امروز" }, { 1, "فردا" }, { 2, "پس‌فردا" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} روز پیش" }, { PluralRulesValues.Other, "{0} روز پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} روز بعد" }, { PluralRulesValues.Other, "{0} روز بعد" } })
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
									new Dictionary<int, string> { { -1, "یکشنبهٔ گذشته" }, { 0, "این یکشنبه" }, { 1, "یکشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} یکشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} یکشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} یکشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} یکشنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "یکشنبهٔ گذشته" }, { 0, "این یکشنبه" }, { 1, "یکشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} یکشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} یکشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} یکشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} یکشنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "یکشنبهٔ گذشته" }, { 0, "این یکشنبه" }, { 1, "یکشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} یکشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} یکشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} یکشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} یکشنبهٔ بعد" } })
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
									new Dictionary<int, string> { { -1, "دوشنبهٔ گذشته" }, { 0, "این دوشنبه" }, { 1, "دوشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دوشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} دوشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دوشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} دوشنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "دوشنبهٔ گذشته" }, { 0, "این دوشنبه" }, { 1, "دوشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دوشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} دوشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دوشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} دوشنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "دوشنبهٔ گذشته" }, { 0, "این دوشنبه" }, { 1, "دوشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دوشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} دوشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دوشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} دوشنبهٔ بعد" } })
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
									new Dictionary<int, string> { { -1, "سه‌شنبهٔ گذشته" }, { 0, "این سه‌شنبه" }, { 1, "سه‌شنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌شنبهٔ پیش" }, { PluralRulesValues.Other, "{0} سه‌شنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌شنبهٔ بعد" }, { PluralRulesValues.Other, "{0} سه‌شنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "سه‌شنبهٔ گذشته" }, { 0, "این سه‌شنبه" }, { 1, "سه‌شنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌شنبهٔ پیش" }, { PluralRulesValues.Other, "{0} سه‌شنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌شنبهٔ بعد" }, { PluralRulesValues.Other, "{0} سه‌شنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "سه‌شنبهٔ گذشته" }, { 0, "این سه‌شنبه" }, { 1, "سه‌شنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌شنبهٔ پیش" }, { PluralRulesValues.Other, "{0} سه‌شنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سه‌شنبهٔ بعد" }, { PluralRulesValues.Other, "{0} سه‌شنبهٔ بعد" } })
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
									new Dictionary<int, string> { { -1, "چهارشنبهٔ گذشته" }, { 0, "این چهارشنبه" }, { 1, "چهارشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} چهارشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} چهارشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} چهارشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} چهارشنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "چهارشنبهٔ گذشته" }, { 0, "این چهارشنبه" }, { 1, "چهارشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} چهارشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} چهارشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} چهارشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} چهارشنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "چهارشنبهٔ گذشته" }, { 0, "این چهارشنبه" }, { 1, "چهارشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} چهارشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} چهارشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} چهارشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} چهارشنبهٔ بعد" } })
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
									new Dictionary<int, string> { { -1, "پنجشنبهٔ گذشته" }, { 0, "این پنجشنبه" }, { 1, "پنجشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پنجشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} پنجشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پنجشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} پنجشنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پنجشنبهٔ گذشته" }, { 0, "این پنجشنبه" }, { 1, "پنجشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پنجشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} پنجشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پنجشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} پنجشنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پنجشنبهٔ گذشته" }, { 0, "این پنجشنبه" }, { 1, "پنجشنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پنجشنبهٔ پیش" }, { PluralRulesValues.Other, "{0} پنجشنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پنجشنبهٔ بعد" }, { PluralRulesValues.Other, "{0} پنجشنبهٔ بعد" } })
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
									new Dictionary<int, string> { { -1, "جمعهٔ گذشته" }, { 0, "این جمعه" }, { 1, "جمعهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعهٔ پیش" }, { PluralRulesValues.Other, "{0} جمعهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعهٔ بعد" }, { PluralRulesValues.Other, "{0} جمعهٔ بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "جمعهٔ گذشته" }, { 0, "این جمعه" }, { 1, "جمعهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعهٔ پیش" }, { PluralRulesValues.Other, "{0} جمعهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعهٔ بعد" }, { PluralRulesValues.Other, "{0} جمعهٔ بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "جمعهٔ گذشته" }, { 0, "این جمعه" }, { 1, "جمعهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعهٔ پیش" }, { PluralRulesValues.Other, "{0} جمعهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعهٔ بعد" }, { PluralRulesValues.Other, "{0} جمعهٔ بعد" } })
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
									new Dictionary<int, string> { { -1, "شنبهٔ گذشته" }, { 0, "این شنبه" }, { 1, "شنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} شنبهٔ پیش" }, { PluralRulesValues.Other, "{0} شنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} شنبهٔ بعد" }, { PluralRulesValues.Other, "{0} شنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "شنبهٔ گذشته" }, { 0, "این شنبه" }, { 1, "شنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} شنبهٔ پیش" }, { PluralRulesValues.Other, "{0} شنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} شنبهٔ بعد" }, { PluralRulesValues.Other, "{0} شنبهٔ بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "شنبهٔ گذشته" }, { 0, "این شنبه" }, { 1, "شنبهٔ آینده" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} شنبهٔ پیش" }, { PluralRulesValues.Other, "{0} شنبهٔ پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} شنبهٔ بعد" }, { PluralRulesValues.Other, "{0} شنبهٔ بعد" } })
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
									new Dictionary<int, string> { { 0, "همین ساعت" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ساعت پیش" }, { PluralRulesValues.Other, "{0} ساعت پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ساعت بعد" }, { PluralRulesValues.Other, "{0} ساعت بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "همین ساعت" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ساعت پیش" }, { PluralRulesValues.Other, "{0} ساعت پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ساعت بعد" }, { PluralRulesValues.Other, "{0} ساعت بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "همین ساعت" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ساعت پیش" }, { PluralRulesValues.Other, "{0} ساعت پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ساعت بعد" }, { PluralRulesValues.Other, "{0} ساعت بعد" } })
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
									new Dictionary<int, string> { { 0, "همین دقیقه" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دقیقه پیش" }, { PluralRulesValues.Other, "{0} دقیقه پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دقیقه بعد" }, { PluralRulesValues.Other, "{0} دقیقه بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "همین دقیقه" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دقیقه پیش" }, { PluralRulesValues.Other, "{0} دقیقه پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دقیقه بعد" }, { PluralRulesValues.Other, "{0} دقیقه بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "همین دقیقه" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دقیقه پیش" }, { PluralRulesValues.Other, "{0} دقیقه پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دقیقه بعد" }, { PluralRulesValues.Other, "{0} دقیقه بعد" } })
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
									new Dictionary<int, string> { { 0, "اکنون" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ثانیه پیش" }, { PluralRulesValues.Other, "{0} ثانیه پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ثانیه بعد" }, { PluralRulesValues.Other, "{0} ثانیه بعد" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "اکنون" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ثانیه پیش" }, { PluralRulesValues.Other, "{0} ثانیه پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ثانیه بعد" }, { PluralRulesValues.Other, "{0} ثانیه بعد" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "اکنون" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ثانیه پیش" }, { PluralRulesValues.Other, "{0} ثانیه پیش" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ثانیه بعد" }, { PluralRulesValues.Other, "{0} ثانیه بعد" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("fa");
		}
	}
}