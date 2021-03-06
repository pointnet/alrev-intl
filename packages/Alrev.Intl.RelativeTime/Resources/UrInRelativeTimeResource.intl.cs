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
	/// Relative Time Units resource for 'Urdu (India)' [ur-in]
	/// </summary>
	public class UrInRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public UrInRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "گزشتہ سال" }, { 0, "اس سال" }, { 1, "اگلے سال" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال پہلے" }, { PluralRulesValues.Other, "{0} سال پہلے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال میں" }, { PluralRulesValues.Other, "{0} سالوں میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ سال" }, { 0, "اس سال" }, { 1, "اگلے سال" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال پہلے" }, { PluralRulesValues.Other, "{0} سالوں پہلے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال میں" }, { PluralRulesValues.Other, "{0} سالوں میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ سال" }, { 0, "اس سال" }, { 1, "اگلے سال" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال پہلے" }, { PluralRulesValues.Other, "{0} سال پہلے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال میں" }, { PluralRulesValues.Other, "{0} سال میں" } })
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
									new Dictionary<int, string> { { -1, "گزشتہ سہ ماہی" }, { 0, "اس سہ ماہی" }, { 1, "اگلے سہ ماہی" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سہ ماہی پہلے" }, { PluralRulesValues.Other, "{0} سہ ماہی پہلے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سہ ماہی میں" }, { PluralRulesValues.Other, "{0} سہ ماہی میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ سہ ماہی" }, { 0, "اس سہ ماہی" }, { 1, "اگلے سہ ماہی" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سہ ماہی قبل" }, { PluralRulesValues.Other, "{0} سہ ماہی قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سہ ماہی میں" }, { PluralRulesValues.Other, "{0} سہ ماہی میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ سہ ماہی" }, { 0, "اس سہ ماہی" }, { 1, "اگلے سہ ماہی" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سہ ماہی پہلے" }, { PluralRulesValues.Other, "{0} سہ ماہی پہلے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سہ ماہی میں" }, { PluralRulesValues.Other, "{0} سہ ماہی میں" } })
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
									new Dictionary<int, string> { { -1, "گزشتہ ماہ" }, { 0, "اس ماہ" }, { 1, "اگلے ماہ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماہ قبل" }, { PluralRulesValues.Other, "{0} ماہ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماہ میں" }, { PluralRulesValues.Other, "{0} ماہ میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پچھلے مہینہ" }, { 0, "اس مہینہ" }, { 1, "اگلے مہینہ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماہ قبل" }, { PluralRulesValues.Other, "{0} ماہ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماہ میں" }, { PluralRulesValues.Other, "{0} ماہ میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ ماہ" }, { 0, "اس ماہ" }, { 1, "اگلے ماہ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماہ قبل" }, { PluralRulesValues.Other, "{0} ماہ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ماہ میں" }, { PluralRulesValues.Other, "{0} ماہ میں" } })
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
									new Dictionary<int, string> { { -1, "گزشتہ ہفتہ" }, { 0, "اس ہفتہ" }, { 1, "اگلے ہفتہ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ہفتہ قبل" }, { PluralRulesValues.Other, "{0} ہفتے قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ہفتہ میں" }, { PluralRulesValues.Other, "{0} ہفتوں میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پچھلے ہفتہ" }, { 0, "اس ہفتہ" }, { 1, "اگلے ہفتہ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ہفتے قبل" }, { PluralRulesValues.Other, "{0} ہفتے قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ہفتے میں" }, { PluralRulesValues.Other, "{0} ہفتے میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پچھلے ہفتہ" }, { 0, "اس ہفتہ" }, { 1, "اگلے ہفتہ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ہفتہ قبل" }, { PluralRulesValues.Other, "{0} ہفتے قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ہفتہ میں" }, { PluralRulesValues.Other, "{0} ہفتے میں" } })
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
									new Dictionary<int, string> { { -2, "گزشتہ پرسوں" }, { -1, "گزشتہ کل" }, { 0, "آج" }, { 1, "آئندہ کل" }, { 2, "آنے والا پرسوں" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دن پہلے" }, { PluralRulesValues.Other, "{0} دنوں پہلے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دن میں" }, { PluralRulesValues.Other, "{0} دنوں میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "گزشتہ پرسوں" }, { -1, "گزشتہ کل" }, { 0, "آج" }, { 1, "آئندہ کل" }, { 2, "آنے والا پرسوں" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دن پہلے" }, { PluralRulesValues.Other, "{0} دن پہلے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دنوں میں" }, { PluralRulesValues.Other, "{0} دنوں میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "گزشتہ پرسوں" }, { -1, "گزشتہ کل" }, { 0, "آج" }, { 1, "آئندہ کل" }, { 2, "آنے والا پرسوں" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دن قبل" }, { PluralRulesValues.Other, "{0} دن قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} دن میں" }, { PluralRulesValues.Other, "{0} دنوں میں" } })
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
									new Dictionary<int, string> { { -1, "گزشتہ اتوار" }, { 0, "اس اتوار" }, { 1, "اگلے اتوار" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اتوار قبل" }, { PluralRulesValues.Other, "{0} اتوار قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اتوار میں" }, { PluralRulesValues.Other, "{0} اتوار میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ اتوار" }, { 0, "اس اتوار" }, { 1, "اگلے اتوار" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اتوار قبل" }, { PluralRulesValues.Other, "{0} اتوار قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اتوار میں" }, { PluralRulesValues.Other, "{0} اتوار میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ اتوار" }, { 0, "اس اتوار" }, { 1, "اگلے اتوار" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اتوار قبل" }, { PluralRulesValues.Other, "{0} اتوار قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اتوار میں" }, { PluralRulesValues.Other, "{0} اتوار میں" } })
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
									new Dictionary<int, string> { { -1, "پچھلے سوموار" }, { 0, "اس سوموار" }, { 1, "اگلے سوموار" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پیر قبل" }, { PluralRulesValues.Other, "{0} پیر قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پیر میں" }, { PluralRulesValues.Other, "{0} پیر میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ پیر" }, { 0, "اس پیر" }, { 1, "اگلے پیر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پیر قبل" }, { PluralRulesValues.Other, "{0} پیر قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پیر میں" }, { PluralRulesValues.Other, "{0} پیر میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ پیر" }, { 0, "اس پیر" }, { 1, "اگلے پیر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پیر قبل" }, { PluralRulesValues.Other, "{0} پیر قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} پیر میں" }, { PluralRulesValues.Other, "{0} پیر میں" } })
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
									new Dictionary<int, string> { { -1, "پچھلے منگل" }, { 0, "اس منگل" }, { 1, "اگلے منگل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منگل قبل" }, { PluralRulesValues.Other, "{0} منگل قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منگل میں" }, { PluralRulesValues.Other, "{0} منگل میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ منگل" }, { 0, "اس منگل" }, { 1, "اگلے منگل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منگل قبل" }, { PluralRulesValues.Other, "{0} منگل قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منگل میں" }, { PluralRulesValues.Other, "{0} منگل میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ منگل" }, { 0, "اس منگل" }, { 1, "اگلے منگل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منگل قبل" }, { PluralRulesValues.Other, "{0} منگل قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منگل میں" }, { PluralRulesValues.Other, "{0} منگل میں" } })
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
									new Dictionary<int, string> { { -1, "پچھلے بدھ" }, { 0, "اس بدھ" }, { 1, "اگلے بدھ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} بدھ قبل" }, { PluralRulesValues.Other, "{0} بدھ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} بدھ میں" }, { PluralRulesValues.Other, "{0} بدھ میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ بدھ" }, { 0, "اس بدھ" }, { 1, "اگلے بدھ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} بدھ قبل" }, { PluralRulesValues.Other, "{0} بدھ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} بدھ میں" }, { PluralRulesValues.Other, "{0} بدھ میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ بدھ" }, { 0, "اس بدھ" }, { 1, "اگلے بدھ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} بدھ قبل" }, { PluralRulesValues.Other, "{0} بدھ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} بدھ میں" }, { PluralRulesValues.Other, "{0} بدھ میں" } })
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
									new Dictionary<int, string> { { -1, "پچھلے جمعرات" }, { 0, "اس جمعرات" }, { 1, "اگلے جمعرات" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعرات قبل" }, { PluralRulesValues.Other, "{0} جمعرات قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعرات میں" }, { PluralRulesValues.Other, "{0} جمعرات میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ جمعرات" }, { 0, "اس جمعرات" }, { 1, "اگلے جمعرات" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعرات قبل" }, { PluralRulesValues.Other, "{0} جمعرات قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعرات میں" }, { PluralRulesValues.Other, "{0} جمعرات میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ جمعرات" }, { 0, "اس جمعرات" }, { 1, "اگلی جمعرات" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعرات قبل" }, { PluralRulesValues.Other, "{0} جمعرات قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعرات میں" }, { PluralRulesValues.Other, "{0} جمعرات میں" } })
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
									new Dictionary<int, string> { { -1, "پچھلے جمعہ" }, { 0, "اس جمعہ" }, { 1, "اگلے جمعہ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعہ قبل" }, { PluralRulesValues.Other, "{0} جمعہ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعہ میں" }, { PluralRulesValues.Other, "{0} جمعہ میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ جمعہ" }, { 0, "اس جمعہ" }, { 1, "اگلے جمعہ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعہ قبل" }, { PluralRulesValues.Other, "{0} جمعہ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعہ میں" }, { PluralRulesValues.Other, "{0} جمعہ میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ جمعہ" }, { 0, "اس جمعہ" }, { 1, "اگلے جمعہ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعہ قبل" }, { PluralRulesValues.Other, "{0} جمعہ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعہ میں" }, { PluralRulesValues.Other, "{0} جمعہ میں" } })
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
									new Dictionary<int, string> { { -1, "گزشتہ سنیچر" }, { 0, "اس سنیچر" }, { 1, "اگلے سنیچر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سنیچر قبل" }, { PluralRulesValues.Other, "{0} سنیچر قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سنیچر میں" }, { PluralRulesValues.Other, "{0} سنیچر میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ سنیچر" }, { 0, "اس سنیچر" }, { 1, "اگلے سنیچر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سنیچر قبل" }, { PluralRulesValues.Other, "{0} سنیچر قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سنیچر میں" }, { PluralRulesValues.Other, "{0} سنیچر میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "گزشتہ سنیچر" }, { 0, "اس سنیچر" }, { 1, "اگلے سنیچر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سنیچر قبل" }, { PluralRulesValues.Other, "{0} سنیچر قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سنیچر میں" }, { PluralRulesValues.Other, "{0} سنیچر میں" } })
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
									new Dictionary<int, string> { { 0, "اس گھنٹے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} گھنٹہ پہلے" }, { PluralRulesValues.Other, "{0} گھنٹے پہلے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} گھنٹے میں" }, { PluralRulesValues.Other, "{0} گھنٹے میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "اس گھنٹے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} گھنٹے قبل" }, { PluralRulesValues.Other, "{0} گھنٹے قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} گھنٹے میں" }, { PluralRulesValues.Other, "{0} گھنٹے میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "اس گھنٹے" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} گھنٹہ قبل" }, { PluralRulesValues.Other, "{0} گھنٹے قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} گھنٹے میں" }, { PluralRulesValues.Other, "{0} گھنٹوں میں" } })
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
									new Dictionary<int, string> { { 0, "اس منٹ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٹ قبل" }, { PluralRulesValues.Other, "{0} منٹ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٹ میں" }, { PluralRulesValues.Other, "{0} منٹ میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "اس منٹ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٹ قبل" }, { PluralRulesValues.Other, "{0} منٹ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٹ میں" }, { PluralRulesValues.Other, "{0} منٹ میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "اس منٹ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٹ قبل" }, { PluralRulesValues.Other, "{0} منٹ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٹ میں" }, { PluralRulesValues.Other, "{0} منٹ میں" } })
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
									new Dictionary<int, string> { { 0, "اب" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سیکنڈ قبل" }, { PluralRulesValues.Other, "{0} سیکنڈ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سیکنڈ میں" }, { PluralRulesValues.Other, "{0} سیکنڈ میں" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "اب" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سیکنڈ قبل" }, { PluralRulesValues.Other, "{0} سیکنڈ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سیکنڈ میں" }, { PluralRulesValues.Other, "{0} سیکنڈ میں" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "اب" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سیکنڈ قبل" }, { PluralRulesValues.Other, "{0} سیکنڈ قبل" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سیکنڈ میں" }, { PluralRulesValues.Other, "{0} سیکنڈ میں" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("ur-in");
		}
	}
}