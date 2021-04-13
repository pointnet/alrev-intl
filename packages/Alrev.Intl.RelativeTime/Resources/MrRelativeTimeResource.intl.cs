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
	/// Relative Time Units resource for 'Marathi' [mr]
	/// </summary>
	public class MrRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public MrRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "मागील वर्ष" }, { 0, "हे वर्ष" }, { 1, "पुढील वर्ष" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षापूर्वी" }, { PluralRulesValues.Other, "{0} वर्षांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} वर्षामध्ये" }, { PluralRulesValues.Other, "येत्या {0} वर्षांमध्ये" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील वर्ष" }, { 0, "हे वर्ष" }, { 1, "पुढील वर्ष" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षापूर्वी" }, { PluralRulesValues.Other, "{0} वर्षांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षामध्ये" }, { PluralRulesValues.Other, "{0} वर्षांमध्ये" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील वर्ष" }, { 0, "हे वर्ष" }, { 1, "पुढील वर्ष" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} वर्षापूर्वी" }, { PluralRulesValues.Other, "{0} वर्षांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} वर्षामध्ये" }, { PluralRulesValues.Other, "येत्या {0} वर्षांमध्ये" } })
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
									new Dictionary<int, string> { { -1, "मागील तिमाही" }, { 0, "ही तिमाही" }, { 1, "पुढील तिमाही" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तिमाहीपूर्वी" }, { PluralRulesValues.Other, "{0} तिमाहींपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तिमाहीमध्ये" }, { PluralRulesValues.Other, "{0} तिमाहींमध्ये" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील तिमाही" }, { 0, "ही तिमाही" }, { 1, "पुढील तिमाही" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तिमाहीपूर्वी" }, { PluralRulesValues.Other, "{0} तिमाहींपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} तिमाहीमध्ये" }, { PluralRulesValues.Other, "येत्या {0} तिमाहींमध्ये" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील तिमाही" }, { 0, "ही तिमाही" }, { 1, "पुढील तिमाही" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तिमाहीपूर्वी" }, { PluralRulesValues.Other, "{0} तिमाहींपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तिमाहीमध्ये" }, { PluralRulesValues.Other, "{0} तिमाहींमध्ये" } })
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
									new Dictionary<int, string> { { -1, "मागील महिना" }, { 0, "हा महिना" }, { 1, "पुढील महिना" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिन्यापूर्वी" }, { PluralRulesValues.Other, "{0} महिन्यांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} महिन्यामध्ये" }, { PluralRulesValues.Other, "येत्या {0} महिन्यांमध्ये" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील महिना" }, { 0, "हा महिना" }, { 1, "पुढील महिना" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिन्यापूर्वी" }, { PluralRulesValues.Other, "{0} महिन्यांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिन्यामध्ये" }, { PluralRulesValues.Other, "{0} महिन्यामध्ये" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील महिना" }, { 0, "हा महिना" }, { 1, "पुढील महिना" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिन्यापूर्वी" }, { PluralRulesValues.Other, "{0} महिन्यांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} महिन्यामध्ये" }, { PluralRulesValues.Other, "{0} महिन्यांमध्ये" } })
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
									new Dictionary<int, string> { { -1, "मागील आठवडा" }, { 0, "हा आठवडा" }, { 1, "पुढील आठवडा" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आठवड्यापूर्वी" }, { PluralRulesValues.Other, "{0} आठवड्यांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आठवड्यामध्ये" }, { PluralRulesValues.Other, "{0} आठवड्यांमध्ये" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील आठवडा" }, { 0, "हा आठवडा" }, { 1, "पुढील आठवडा" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आठवड्यापूर्वी" }, { PluralRulesValues.Other, "{0} आठवड्यांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} आठवड्यामध्ये" }, { PluralRulesValues.Other, "येत्या {0} आठवड्यांमध्ये" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील आठवडा" }, { 0, "हा आठवडा" }, { 1, "पुढील आठवडा" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} आठवड्यापूर्वी" }, { PluralRulesValues.Other, "{0} आठवड्यांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} आठवड्यामध्ये" }, { PluralRulesValues.Other, "येत्या {0} आठवड्यांमध्ये" } })
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
									new Dictionary<int, string> { { -1, "काल" }, { 0, "आज" }, { 1, "उद्या" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिवसापूर्वी" }, { PluralRulesValues.Other, "{0} दिवसांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} दिवसामध्ये" }, { PluralRulesValues.Other, "येत्या {0} दिवसांमध्ये" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "काल" }, { 0, "आज" }, { 1, "उद्या" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिवसापूर्वी" }, { PluralRulesValues.Other, "{0} दिवसांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिवसामध्ये" }, { PluralRulesValues.Other, "येत्या {0} दिवसांमध्ये" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "काल" }, { 0, "आज" }, { 1, "उद्या" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिवसापूर्वी" }, { PluralRulesValues.Other, "{0} दिवसांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} दिवसामध्ये" }, { PluralRulesValues.Other, "{0} दिवसांमध्ये" } })
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
									new Dictionary<int, string> { { -1, "मागील रविवार" }, { 0, "हा रविवार" }, { 1, "पुढील रविवार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} रविवारपूर्वी" }, { PluralRulesValues.Other, "{0} रविवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} रविवारी" }, { PluralRulesValues.Other, "येत्या {0} रविवारी" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील रवि." }, { 0, "हा रवि." }, { 1, "पुढील रवि." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} रविवारपूर्वी" }, { PluralRulesValues.Other, "{0} रविवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} रविवारी" }, { PluralRulesValues.Other, "येत्या {0} रविवारी" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील र" }, { 0, "हा र" }, { 1, "पुढील र" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} रविवारपूर्वी" }, { PluralRulesValues.Other, "{0} रविवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} रविवारी" }, { PluralRulesValues.Other, "येत्या {0} रविवारी" } })
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
									new Dictionary<int, string> { { -1, "मागील सोमवार" }, { 0, "हा सोमवार" }, { 1, "पुढील सोमवार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमवारपूर्वी" }, { PluralRulesValues.Other, "{0} सोमवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} सोमवारी" }, { PluralRulesValues.Other, "येत्या {0} सोमवारी" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील सोम." }, { 0, "हा सोम." }, { 1, "पुढील सोम." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमवारापूर्वी" }, { PluralRulesValues.Other, "{0} सोमवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} सोमवारी" }, { PluralRulesValues.Other, "येत्या {0} सोमवारी" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील सो" }, { 0, "हा सो" }, { 1, "पुढील सो" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सोमवारापूर्वी" }, { PluralRulesValues.Other, "{0} सोमवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} सोमवारी" }, { PluralRulesValues.Other, "येत्या {0} सोमवारी" } })
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
									new Dictionary<int, string> { { -1, "मागील मंगळवार" }, { 0, "हा मंगळवार" }, { 1, "पुढील मंगळवार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगळवारपूर्वी" }, { PluralRulesValues.Other, "{0} मंगळवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} मंगळवारी" }, { PluralRulesValues.Other, "येत्या {0} मंगळवारी" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील मंगळ." }, { 0, "हा मंगळ." }, { 1, "पुढील मंगळ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगळवारापूर्वी" }, { PluralRulesValues.Other, "{0} मंगळवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} मंगळवारी" }, { PluralRulesValues.Other, "येत्या {0} मंगळवारी" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील मं" }, { 0, "हा मं" }, { 1, "पुढील मं" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मंगळवारपूर्वी" }, { PluralRulesValues.Other, "{0} मंगळवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} मंगळवारी" }, { PluralRulesValues.Other, "येत्या {0} मंगळवारी" } })
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
									new Dictionary<int, string> { { -1, "मागील बुधवार" }, { 0, "हा बुधवार" }, { 1, "पुढील बुधवार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधवारपूर्वी" }, { PluralRulesValues.Other, "{0} बुधवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} बुधवारी" }, { PluralRulesValues.Other, "येत्या {0} बुधवारी" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील बुध." }, { 0, "हा बुध." }, { 1, "पुढील बुध." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधवारपूर्वी" }, { PluralRulesValues.Other, "{0} बुधवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} बुधवार" }, { PluralRulesValues.Other, "येत्या {0} बुधवार" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील बु" }, { 0, "हा बु" }, { 1, "पुढील बु" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} बुधवारपूर्वी" }, { PluralRulesValues.Other, "{0} बुधवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} बुधवारी" }, { PluralRulesValues.Other, "येत्या {0} बुधवारी" } })
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
									new Dictionary<int, string> { { -1, "मागील गुरुवार" }, { 0, "हा गुरुवार" }, { 1, "पुढील गुरुवार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} गुरूवारपूर्वी" }, { PluralRulesValues.Other, "{0} गुरूवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} गुरूवारी" }, { PluralRulesValues.Other, "येत्या {0} गुरूवारी" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील गुरू." }, { 0, "हा गुरू." }, { 1, "पुढील गुरू." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} गुरूवारपूर्वी" }, { PluralRulesValues.Other, "{0} गुरूवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} गुरूवारी" }, { PluralRulesValues.Other, "येत्या {0} गुरूवारी" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील गु" }, { 0, "हा गु" }, { 1, "पुढील गु" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} गुरूवारपूर्वी" }, { PluralRulesValues.Other, "{0} गुरूवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} गुरूवारी" }, { PluralRulesValues.Other, "येत्या {0} गुरूवारी" } })
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
									new Dictionary<int, string> { { -1, "मागील शुक्रवार" }, { 0, "हा शुक्रवार" }, { 1, "पुढील शुक्रवार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रवारपूर्वी" }, { PluralRulesValues.Other, "{0} शुक्रवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} शुक्रवारी" }, { PluralRulesValues.Other, "येत्या {0} शुक्रवारी" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील शुक्र." }, { 0, "हा शुक्र." }, { 1, "पुढील शुक्र." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रवारपूर्वी" }, { PluralRulesValues.Other, "{0} शुक्रवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} शुक्रवारी" }, { PluralRulesValues.Other, "येत्या {0} शुक्रवारी" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील शुक्र." }, { 0, "हा शुक्र." }, { 1, "पुढील शुक्र." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शुक्रवारपूर्वी" }, { PluralRulesValues.Other, "{0} शुक्रवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} शुक्रवारी" }, { PluralRulesValues.Other, "येत्या {0} शुक्रवारी" } })
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
									new Dictionary<int, string> { { -1, "मागील शनिवार" }, { 0, "हा शनिवार" }, { 1, "पुढील शनिवार" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिवारपूर्वी" }, { PluralRulesValues.Other, "{0} शनिवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} शनिवारी" }, { PluralRulesValues.Other, "येत्या {0} शनिवारी" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील शनि." }, { 0, "हा शनि." }, { 1, "पुढील शनि." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिवारपूर्वी" }, { PluralRulesValues.Other, "{0} शनिवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} शनिवारी" }, { PluralRulesValues.Other, "येत्या {0} शनिवारी" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "मागील शनि." }, { 0, "हा शनि." }, { 1, "पुढील शनि." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} शनिवारपूर्वी" }, { PluralRulesValues.Other, "{0} शनिवारांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} शनिवारी" }, { PluralRulesValues.Other, "येत्या {0} शनिवारी" } })
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
									new Dictionary<int, string> { { 0, "तासात" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तासापूर्वी" }, { PluralRulesValues.Other, "{0} तासांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तासामध्ये" }, { PluralRulesValues.Other, "{0} तासांमध्ये" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "तासात" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तासापूर्वी" }, { PluralRulesValues.Other, "{0} तासांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तासामध्ये" }, { PluralRulesValues.Other, "{0} तासांमध्ये" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "तासात" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} तासापूर्वी" }, { PluralRulesValues.Other, "{0} तासांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "येत्या {0} तासामध्ये" }, { PluralRulesValues.Other, "येत्या {0} तासांमध्ये" } })
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
									new Dictionary<int, string> { { 0, "या मिनिटात" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनिटापूर्वी" }, { PluralRulesValues.Other, "{0} मिनिटांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनिटामध्ये" }, { PluralRulesValues.Other, "{0} मिनिटांमध्ये" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "या मिनिटात" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनि. पूर्वी" }, { PluralRulesValues.Other, "{0} मिनि. पूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनि. मध्ये" }, { PluralRulesValues.Other, "{0} मिनि. मध्ये" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "या मिनिटात" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनि. पूर्वी" }, { PluralRulesValues.Other, "{0} मिनि. पूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} मिनि. मध्ये" }, { PluralRulesValues.Other, "{0} मिनि. मध्ये" } })
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
									new Dictionary<int, string> { { 0, "आत्ता" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकंदापूर्वी" }, { PluralRulesValues.Other, "{0} सेकंदांपूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} सेकंदामध्ये" }, { PluralRulesValues.Other, "{0} सेकंदांमध्ये" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "आत्ता" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} से. पूर्वी" }, { PluralRulesValues.Other, "{0} से. पूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} से. मध्ये" }, { PluralRulesValues.Other, "{0} से. मध्ये" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "आत्ता" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} से. पूर्वी" }, { PluralRulesValues.Other, "{0} से. पूर्वी" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} से. मध्ये" }, { PluralRulesValues.Other, "येत्या {0} से. मध्ये" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("mr");
		}
	}
}