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
	/// Relative Time Units resource for 'Sindhi' [sd]
	/// </summary>
	public class SdRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public SdRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "پويون سال" }, { 0, "پويون سال" }, { 1, "پويون سال" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال پهرين" }, { PluralRulesValues.Other, "{0} سال پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سالن ۾" }, { PluralRulesValues.Other, "{0} سالن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين سال" }, { 0, "هن سال" }, { 1, "اڳين سال" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال پهرين" }, { PluralRulesValues.Other, "{0} سال پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سالن ۾" }, { PluralRulesValues.Other, "{0} سالن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين سال" }, { 0, "هن سال" }, { 1, "اڳيئن سال" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سال پهرين" }, { PluralRulesValues.Other, "{0} سال پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سالن ۾" }, { PluralRulesValues.Other, "{0} سالن ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين ٽي ماهي" }, { 0, "هن ٽي ماهي" }, { 1, "اڳين ٽي ماهي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ٽي ماهي پهرين" }, { PluralRulesValues.Other, "{0} ٽي ماهي پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ٽي ماهي ۾" }, { PluralRulesValues.Other, "{0} ٽي ماهي ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين ٽي ماهي" }, { 0, "هن ٽي ماهي" }, { 1, "اڳين ٽي ماهي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ٽي ماهي پهرين" }, { PluralRulesValues.Other, "{0} ٽي ماهي پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ٽي ماهي ۾" }, { PluralRulesValues.Other, "{0} ٽي ماهي ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين ٽي ماهي" }, { 0, "هن ٽي ماهي" }, { 1, "اڳين ٽي ماهي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ٽي ماهي پهرين" }, { PluralRulesValues.Other, "{0} ٽي ماهي پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ٽي ماهي ۾" }, { PluralRulesValues.Other, "{0} ٽي ماهي ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين مهيني" }, { 0, "هن مهيني" }, { 1, "اڳين مهيني" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مهينا پهرين" }, { PluralRulesValues.Other, "{0} مهينا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مهينن ۾" }, { PluralRulesValues.Other, "{0} مهينن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين مهيني" }, { 0, "هن مهيني" }, { 1, "اڳين مهيني" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مهينا پهرين" }, { PluralRulesValues.Other, "{0} مهينا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مهينن ۾" }, { PluralRulesValues.Other, "{0} مهينن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين مهيني" }, { 0, "هن مهيني" }, { 1, "اڳين مهيني" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مهينا پهرين" }, { PluralRulesValues.Other, "{0} مهينا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} مهينن ۾" }, { PluralRulesValues.Other, "{0} مهينن ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين هفتي" }, { 0, "هن هفتي" }, { 1, "اڳين هفتي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفتا پهرين" }, { PluralRulesValues.Other, "{0} هفتا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفتن ۾" }, { PluralRulesValues.Other, "{0} هفتن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين هفتي" }, { 0, "هن هفتي" }, { 1, "اڳين هفتي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفتا پهرين" }, { PluralRulesValues.Other, "{0} هفتا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفتن ۾" }, { PluralRulesValues.Other, "{0} هفتن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين هفتي" }, { 0, "هن هفتي" }, { 1, "اڳين هفتي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفتا پهرين" }, { PluralRulesValues.Other, "{0} هفتا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} هفتن ۾" }, { PluralRulesValues.Other, "{0} هفتن ۾" } })
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
									new Dictionary<int, string> { { -1, "ڪل" }, { 0, "اڄ" }, { 1, "سڀاڻي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڏينهن پهرين" }, { PluralRulesValues.Other, "{0} ڏينهن پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڏينهن ۾" }, { PluralRulesValues.Other, "{0} ڏينهن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ڪل" }, { 0, "اڄ" }, { 1, "سڀاڻي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڏينهن پهرين" }, { PluralRulesValues.Other, "{0} ڏينهن پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڏينهن ۾" }, { PluralRulesValues.Other, "{0} ڏينهن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ڪل" }, { 0, "اڄ" }, { 1, "سڀاڻي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڏينهن پهرين" }, { PluralRulesValues.Other, "{0} ڏينهن پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڏينهن ۾" }, { PluralRulesValues.Other, "{0} ڏينهن ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين آچر" }, { 0, "هن آچر" }, { 1, "اڳين آچر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} آچر پهرين" }, { PluralRulesValues.Other, "{0} آچر پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} آچرن ۾" }, { PluralRulesValues.Other, "{0} آچرن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين آچر" }, { 0, "هن آچر" }, { 1, "اڳين آچر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} آچر پهرين" }, { PluralRulesValues.Other, "{0} آچر پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} آچرن ۾" }, { PluralRulesValues.Other, "{0} آچرن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين آچر" }, { 0, "هن آچر" }, { 1, "اڳين آچر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} آچر پهرين" }, { PluralRulesValues.Other, "{0} آچر پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} آچرن ۾" }, { PluralRulesValues.Other, "{0} آچرن ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين سومر" }, { 0, "هن سومر" }, { 1, "اڳين سومر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سومر پهرين" }, { PluralRulesValues.Other, "{0} سومر پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سومرن ۾" }, { PluralRulesValues.Other, "{0} سومرن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين سومر" }, { 0, "هن سومر" }, { 1, "اڳين سومر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سومر پهرين" }, { PluralRulesValues.Other, "{0} سومر پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سومرن ۾" }, { PluralRulesValues.Other, "{0} سومرن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين سومر" }, { 0, "هن سومر" }, { 1, "اڳين سومر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سومر پهرين" }, { PluralRulesValues.Other, "{0} سومر پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سومرن ۾" }, { PluralRulesValues.Other, "{0} سومرن ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين اڱاري" }, { 0, "هن اڱاري" }, { 1, "اڳين اڱاري" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اڱارا پهرين" }, { PluralRulesValues.Other, "{0} اڱارا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اڱارن ۾" }, { PluralRulesValues.Other, "{0} اڱارن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين اڱاري" }, { 0, "هن اڱاري" }, { 1, "اڳين اڱاري" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اڱارا پهرين" }, { PluralRulesValues.Other, "{0} اڱارا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اڱارن ۾" }, { PluralRulesValues.Other, "{0} اڱارن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين اڱاري" }, { 0, "هن اڱاري" }, { 1, "اڳين اڱاري" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اڱارا پهرين" }, { PluralRulesValues.Other, "{0} اڱارا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اڱارن ۾" }, { PluralRulesValues.Other, "{0} اڱارن ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين اربع" }, { 0, "هن اربع" }, { 1, "اڳين اربع" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اربعا پهرين" }, { PluralRulesValues.Other, "{0} اربعا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اربعن ۾" }, { PluralRulesValues.Other, "{0} اربعن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين اربع" }, { 0, "هن اربع" }, { 1, "اڳين اربع" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اربعا پهرين" }, { PluralRulesValues.Other, "{0} اربعا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اربعن ۾" }, { PluralRulesValues.Other, "{0} اربعن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين اربع" }, { 0, "هن اربع" }, { 1, "اڳين اربع" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اربعا پهرين" }, { PluralRulesValues.Other, "{0} اربعا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} اربعن ۾" }, { PluralRulesValues.Other, "{0} اربعن ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين خميس" }, { 0, "هن خميس" }, { 1, "اڳين خميس" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} خميس پهرين" }, { PluralRulesValues.Other, "{0} خميس پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} خميسن ۾" }, { PluralRulesValues.Other, "{0} خميسن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين خميس" }, { 0, "هن خميس" }, { 1, "اڳين خميس" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} خميس پهرين" }, { PluralRulesValues.Other, "{0} خميس پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} خميسن ۾" }, { PluralRulesValues.Other, "{0} خميسن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين خميس" }, { 0, "هن خميس" }, { 1, "اڳين خميس" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} خميس پهرين" }, { PluralRulesValues.Other, "{0} خميس پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} خميسن ۾" }, { PluralRulesValues.Other, "{0} خميسن ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين جمعي" }, { 0, "هن جمعي" }, { 1, "اڳين جمعي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعا پهرين" }, { PluralRulesValues.Other, "{0} جمعا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعن ۾" }, { PluralRulesValues.Other, "{0} جمعن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين جمعي" }, { 0, "هن جمعي" }, { 1, "اڳين جمعي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعا پهرين" }, { PluralRulesValues.Other, "{0} جمعا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعن ۾" }, { PluralRulesValues.Other, "{0} جمعن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين جمعي" }, { 0, "هن جمعي" }, { 1, "اڳين جمعي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعا پهرين" }, { PluralRulesValues.Other, "{0} جمعا پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} جمعن ۾" }, { PluralRulesValues.Other, "{0} جمعن ۾" } })
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
									new Dictionary<int, string> { { -1, "پوئين ڇنڇر" }, { 0, "هن ڇنڇر" }, { 1, "اڳين ڇنڇر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڇنڇر پهرين" }, { PluralRulesValues.Other, "{0} ڇنڇر پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڇنڇرن ۾" }, { PluralRulesValues.Other, "{0} ڇنڇرن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين ڇنڇر" }, { 0, "هن ڇنڇر" }, { 1, "اڳين ڇنڇر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڇنڇر پهرين" }, { PluralRulesValues.Other, "{0} ڇنڇر پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڇنڇرن ۾" }, { PluralRulesValues.Other, "{0} ڇنڇرن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "پوئين ڇنڇر" }, { 0, "هن ڇنڇر" }, { 1, "اڳين ڇنڇر" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڇنڇر پهرين" }, { PluralRulesValues.Other, "{0} ڇنڇر پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڇنڇرن ۾" }, { PluralRulesValues.Other, "{0} ڇنڇرن ۾" } })
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
									new Dictionary<int, string> { { 0, "هن ڪلڪ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڪلاڪ پهرين" }, { PluralRulesValues.Other, "{0} ڪلاڪ پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڪلاڪ ۾" }, { PluralRulesValues.Other, "{0} ڪلاڪ ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "هن ڪلڪ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڪلاڪ پهرين" }, { PluralRulesValues.Other, "{0} ڪلاڪ پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڪلاڪ ۾" }, { PluralRulesValues.Other, "{0} ڪلاڪ ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "هن ڪلڪ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڪلاڪ پهرين" }, { PluralRulesValues.Other, "{0} ڪلاڪ پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ڪلاڪ ۾" }, { PluralRulesValues.Other, "{0} ڪلاڪ ۾" } })
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
									new Dictionary<int, string> { { 0, "هن منٽ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٽ پهرين" }, { PluralRulesValues.Other, "{0} منٽ پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٽن ۾" }, { PluralRulesValues.Other, "+{0} min" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "هن منٽ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٽ پهرين" }, { PluralRulesValues.Other, "{0} منٽ پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٽن ۾" }, { PluralRulesValues.Other, "{0} منٽن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "هن منٽ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٽ پهرين" }, { PluralRulesValues.Other, "{0} منٽ پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} منٽن ۾" }, { PluralRulesValues.Other, "{0} منٽن ۾" } })
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
									new Dictionary<int, string> { { 0, "هاڻي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سيڪنڊ پهرين" }, { PluralRulesValues.Other, "{0} سيڪنڊ پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سيڪنڊن ۾" }, { PluralRulesValues.Other, "{0} سيڪنڊن ۾" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "هاڻي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سيڪنڊ پهرين" }, { PluralRulesValues.Other, "{0} سيڪنڊ پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سيڪنڊن ۾" }, { PluralRulesValues.Other, "{0} سيڪنڊن ۾" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "هاڻي" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سيڪنڊ پهرين" }, { PluralRulesValues.Other, "{0} سيڪنڊ پهرين" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} سيڪنڊن ۾" }, { PluralRulesValues.Other, "{0} سيڪنڊن ۾" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("sd");
		}
	}
}