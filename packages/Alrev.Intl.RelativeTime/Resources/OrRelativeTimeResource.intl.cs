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
	/// Relative Time Units resource for 'Odia' [or]
	/// </summary>
	public class OrRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public OrRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "ଗତ ବର୍ଷ" }, { 0, "ଏହି ବର୍ଷ" }, { 1, "ଆଗାମୀ ବର୍ଷ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବର୍ଷ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବର୍ଷ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବର୍ଷରେ" }, { PluralRulesValues.Other, "{0} ବର୍ଷରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ବର୍ଷ" }, { 0, "ଏହି ବର୍ଷ" }, { 1, "ଆଗାମୀ ବର୍ଷ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବ. ରେ" }, { PluralRulesValues.Other, "{0} ବ. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ବର୍ଷ" }, { 0, "ଏହି ବର୍ଷ" }, { 1, "ଆଗାମୀ ବର୍ଷ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବ. ରେ" }, { PluralRulesValues.Other, "{0} ବ. ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ତ୍ରୟମାସ" }, { 0, "ଗତ ତ୍ରୟମାସ" }, { 1, "ଆଗାମୀ ତ୍ରୟମାସ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟମାସ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟମାସ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟମାସରେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟମାସରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ତିନିମାସ" }, { 0, "ଏହି ତ୍ରୟମାସ" }, { 1, "ଆଗାମୀ ତ୍ରୟମାସ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟ. ରେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟ. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ତିନିମାସ" }, { 0, "ଏହି ତିନିମାସ" }, { 1, "ଆଗାମୀ ତିନିମାସ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ତ୍ରୟ. ରେ" }, { PluralRulesValues.Other, "{0} ତ୍ରୟ. ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ମାସ" }, { 0, "ଏହି ମାସ" }, { 1, "ଆଗାମୀ ମାସ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମାସ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମାସ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମାସରେ" }, { PluralRulesValues.Other, "{0} ମାସରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ମାସ" }, { 0, "ଏହି ମାସ" }, { 1, "ଆଗାମୀ ମାସ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମା. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମା. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମା. ରେ" }, { PluralRulesValues.Other, "{0} ମା. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ମାସ" }, { 0, "ଏହି ମାସ" }, { 1, "ଆଗାମୀ ମାସ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମା. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମା. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମା. ରେ" }, { PluralRulesValues.Other, "{0} ମା. ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ସପ୍ତାହ" }, { 0, "ଏହି ସପ୍ତାହ" }, { 1, "ଆଗାମୀ ସପ୍ତାହ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତାହରେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତାହ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତାହରେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତାହରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ସପ୍ତାହ" }, { 0, "ଏହି ସପ୍ତାହ" }, { 1, "ଆଗାମୀ ସପ୍ତାହ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତା. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତା. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତା. ରେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତା. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ସପ୍ତାହ" }, { 0, "ଏହି ସପ୍ତାହ" }, { 1, "ଆଗାମୀ ସପ୍ତାହ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତା. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତା. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସପ୍ତା. ରେ" }, { PluralRulesValues.Other, "{0} ସପ୍ତା. ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତକାଲି" }, { 0, "ଆଜି" }, { 1, "ଆସନ୍ତାକାଲି" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଦିନ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନରେ" }, { PluralRulesValues.Other, "{0} ଦିନରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତକାଲି" }, { 0, "ଆଜି" }, { 1, "ଆସନ୍ତାକାଲି" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଦିନ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନରେ" }, { PluralRulesValues.Other, "{0} ଦିନରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତକାଲି" }, { 0, "ଆଜି" }, { 1, "ଆସନ୍ତାକାଲି" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଦିନ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଦିନରେ" }, { PluralRulesValues.Other, "{0} ଦିନରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ରବିବାର" }, { 0, "ଏହି ରବିବାର" }, { 1, "ଆଗାମୀ ରବିବାର" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବିବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ରବିବାର ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବିବାରରେ" }, { PluralRulesValues.Other, "{0} ରବିବାରରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ରବି." }, { 0, "ଏହି ରବି." }, { 1, "ଆଗାମୀ ରବି." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ରବି. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବି. ରେ" }, { PluralRulesValues.Other, "{0} ରବି. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ରବି." }, { 0, "ଏହି ରବି." }, { 1, "ଆଗାମୀ ରବି." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ରବି. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ରବି. ରେ" }, { PluralRulesValues.Other, "{0} ରବି. ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ସୋମବାର" }, { 0, "ଏହି ସୋମବାର" }, { 1, "ଆସନ୍ତା ସୋମବାର" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋମବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସୋମବାର ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋମବାରରେ" }, { PluralRulesValues.Other, "{0} ସୋମବାରରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ସୋମ." }, { 0, "ଏହି ସୋମ." }, { 1, "ଆସନ୍ତା ସୋମ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋମ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସୋମ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋମ. ରେ" }, { PluralRulesValues.Other, "{0} ସୋମ. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ସୋ" }, { 0, "ଏହି ସୋ" }, { 1, "ଆସନ୍ତା ସୋ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସୋ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସୋ ରେ" }, { PluralRulesValues.Other, "{0} ସୋ ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ମଙ୍ଗଳବାର" }, { 0, "ଏହି ମଙ୍ଗଳବାର" }, { 1, "ଆଗାମୀ ମଙ୍ଗଳବାର" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳବାର ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳବାରରେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳବାରରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ମଙ୍ଗଳ." }, { 0, "ଏହି ମଙ୍ଗଳ." }, { 1, "ଆଗାମୀ ମଙ୍ଗଳ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳ. ରେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳ. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ମଙ୍ଗଳ." }, { 0, "ଏହି ମଙ୍ଗଳ." }, { 1, "ଆଗାମୀ ମଙ୍ଗଳ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମଙ୍ଗଳ. ରେ" }, { PluralRulesValues.Other, "{0} ମଙ୍ଗଳ. ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ବୁଧବାର" }, { 0, "ଏହି ବୁଧବାର" }, { 1, "ଆସନ୍ତା ବୁଧବାର" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବୁଧବାର ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧବାରରେ" }, { PluralRulesValues.Other, "{0} ବୁଧବାରରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ବୁଧ." }, { 0, "ଏହି ବୁଧ." }, { 1, "ଆସନ୍ତା ବୁଧ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବୁଧ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧ. ରେ" }, { PluralRulesValues.Other, "{0} ବୁଧ. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ବୁଧ" }, { 0, "ଏହି ବୁଧ" }, { 1, "ଆସନ୍ତା ବୁଧ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ବୁଧ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ବୁଧ. ରେ" }, { PluralRulesValues.Other, "{0} ବୁଧ. ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ଗୁରୁବାର" }, { 0, "ଏହି ଗୁରୁବାର" }, { 1, "ଆଗାମୀ ଗୁରୁବାର" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁବାର ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁବାରରେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁବାରରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ଗୁରୁ." }, { 0, "ଏହି ଗୁରୁ." }, { 1, "ଆଗାମୀ ଗୁରୁ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁ. ରେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁ. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ଗୁରୁ." }, { 0, "ଏହି ଗୁରୁ." }, { 1, "ଆଗାମୀ ଗୁରୁ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଗୁରୁ. ରେ" }, { PluralRulesValues.Other, "{0} ଗୁରୁ. ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ଶୁକ୍ରବାର" }, { 0, "ଏହି ଶୁକ୍ରବାର" }, { 1, "ଆଗାମୀ ଶୁକ୍ରବାର" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ରବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ରବାର ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ରବାରରେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ରବାରରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ଶୁକ୍ର." }, { 0, "ଏହି ଶୁକ୍ର." }, { 1, "ଆଗାମୀ ଶୁକ୍ର." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ର. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ର. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ର. ରେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ର. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ଶୁକ୍ର." }, { 0, "ଏହି ଶୁକ୍ର." }, { 1, "ଆଗାମୀ ଶୁକ୍ର." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶୁ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶୁକ୍ର. ରେ" }, { PluralRulesValues.Other, "{0} ଶୁକ୍ର. ରେ" } })
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
									new Dictionary<int, string> { { -1, "ଗତ ଶନିବାର" }, { 0, "ଏହି ଶନିବାର" }, { 1, "ଆଗାମୀ ଶନିବାର" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନିବାର ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶନିବାର ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନିବାରରେ" }, { PluralRulesValues.Other, "{0} ଶନିବାରରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ଶନି." }, { 0, "ଏହି ଶନି." }, { 1, "ଆଗାମୀ ଶନି." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶନି. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନି. ରେ" }, { PluralRulesValues.Other, "{0} ଶନି. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ଗତ ଶନି." }, { 0, "ଏହି ଶନି." }, { 1, "ଆଗାମୀ ଶନି." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଶନି. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଶନି. ରେ" }, { PluralRulesValues.Other, "{0} ଶନି. ରେ" } })
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
									new Dictionary<int, string> { { 0, "ଏହି ଘଣ୍ଟା" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘଣ୍ଟା ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଘଣ୍ଟା ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘଣ୍ଟାରେ" }, { PluralRulesValues.Other, "{0} ଘଣ୍ଟାରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ଏହି ଘଣ୍ଟା" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଘ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘ. ରେ" }, { PluralRulesValues.Other, "{0} ଘ. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ଏହି ଘଣ୍ଟା" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ଘ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ଘ. ରେ" }, { PluralRulesValues.Other, "{0} ଘ. ରେ" } })
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
									new Dictionary<int, string> { { 0, "ଏହି ମିନିଟ୍" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମିନିଟ୍ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମିନିଟ୍ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମିନିଟ୍‌‌ରେ" }, { PluralRulesValues.Other, "{0} ମିନିଟ୍‌‌ରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ଏହି ମିନିଟ୍" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମି. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମି. ରେ" }, { PluralRulesValues.Other, "{0} ମି. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ଏହି ମିନିଟ୍" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମି. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ମି. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ମି. ରେ" }, { PluralRulesValues.Other, "{0} ମି. ରେ" } })
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
									new Dictionary<int, string> { { 0, "ବର୍ତ୍ତମାନ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେକେଣ୍ଡ ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସେକେଣ୍ଡ ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେକେଣ୍ଡରେ" }, { PluralRulesValues.Other, "{0} ସେକେଣ୍ଡରେ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ବର୍ତ୍ତମାନ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସେ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେ. ରେ" }, { PluralRulesValues.Other, "{0} ସେ. ରେ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ବର୍ତ୍ତମାନ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେ. ପୂର୍ବେ" }, { PluralRulesValues.Other, "{0} ସେ. ପୂର୍ବେ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ସେ. ରେ" }, { PluralRulesValues.Other, "{0} ସେ. ରେ" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("or");
		}
	}
}