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
	/// Relative Time Units resource for 'Burmese' [my]
	/// </summary>
	public class MyRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public MyRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "ယမန်နှစ်" }, { 0, "ယခုနှစ်" }, { 1, "လာမည့်နှစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နှစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နှစ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ယမန်နှစ်" }, { 0, "ယခုနှစ်" }, { 1, "လာမည့်နှစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နှစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နှစ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ယမန်နှစ်" }, { 0, "ယခုနှစ်" }, { 1, "လာမည့်နှစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နှစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နှစ်အတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သုံးလပတ်" }, { 0, "ယခု သုံးလပတ်" }, { 1, "လာမည့် သုံးလပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သုံးလပတ်ကာလ {0} ခုအတွင်း" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သုံးလပတ်ကာလ {0} အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သောသုံးလပတ်" }, { 0, "ယခုသုံးလပတ်" }, { 1, "နောက်လာမည့်သုံးလပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သုံးလပတ်ကာလ {0} ခုအတွင်း" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သုံးလပတ်ကာလ {0} ခုအတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သောသုံးလပတ်" }, { 0, "ယခုသုံးလပတ်" }, { 1, "နောက်လာမည့်သုံးလပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သုံးလပတ်ကာလ {0} ခုအတွင်း" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သုံးလပတ်ကာလ {0} ခုအတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့်လ" }, { 0, "ယခုလ" }, { 1, "လာမည့်လ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} လ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} လအတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့်လ" }, { 0, "ယခုလ" }, { 1, "လာမည့်လ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} လ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} လအတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့်လ" }, { 0, "ယခုလ" }, { 1, "လာမည့်လ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} လ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} လအတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သီတင်းပတ်" }, { 0, "ယခု သီတင်းပတ်" }, { 1, "လာမည့် သီတင်းပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သီတင်းပတ်" }, { 0, "ယခု သီတင်းပတ်" }, { 1, "လာမည့် သီတင်းပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သီတင်းပတ်" }, { 0, "ယခု သီတင်းပတ်" }, { 1, "လာမည့် သီတင်းပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ပတ်အတွင်း" } })
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
									new Dictionary<int, string> { { -2, "တစ်နေ့က" }, { -1, "မနေ့က" }, { 0, "ယနေ့" }, { 1, "မနက်ဖြန်" }, { 2, "သန်ဘက်ခါ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ရက်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ရက်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "တစ်နေ့က" }, { -1, "မနေ့က" }, { 0, "ယနေ့" }, { 1, "မနက်ဖြန်" }, { 2, "သန်ဘက်ခါ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ရက်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ရက်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "တစ်နေ့က" }, { -1, "မနေ့က" }, { 0, "ယနေ့" }, { 1, "မနက်ဖြန်" }, { 2, "သန်ဘက်ခါ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} ရက်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ရက်အတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္ဂနွေနေ့" }, { 0, "ဤတနင်္ဂနွေနေ့" }, { 1, "လာမည့် တနင်္ဂနွေနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္ဂနွေ {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္ဂနွေ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္ဂနွေနေ့" }, { 0, "ဤတနင်္ဂနွေနေ့" }, { 1, "လာမည့် တနင်္ဂနွေနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္ဂနွေ {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္ဂနွေ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္ဂနွေနေ့" }, { 0, "ဤတနင်္ဂနွေနေ့" }, { 1, "လာမည့် တနင်္ဂနွေနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္ဂနွေ {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္ဂနွေ {0} ပတ်အတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္လာနေ့" }, { 0, "ဤတနင်္လာနေ့" }, { 1, "လာမည့် တနင်္လာနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္လာ {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္လာ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္လာနေ့" }, { 0, "ဤတနင်္လာနေ့" }, { 1, "လာမည့် တနင်္လာနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္လာ {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္လာ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် တနင်္လာနေ့" }, { 0, "ဤတနင်္လာနေ့" }, { 1, "လာမည့် တနင်္လာနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် တနင်္လာ {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "တနင်္လာ {0} ပတ်အတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် အင်္ဂါနေ့" }, { 0, "ဤအင်္ဂါနေ့" }, { 1, "လာမည့် အင်္ဂါနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် အင်္ဂါ {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "အင်္ဂါ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် အင်္ဂါနေ့" }, { 0, "ဤအင်္ဂါနေ့" }, { 1, "လာမည့် အင်္ဂါနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် အင်္ဂါ {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "အင်္ဂါ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် အင်္ဂါနေ့" }, { 0, "ဤအင်္ဂါနေ့" }, { 1, "လာမည့် အင်္ဂါနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် အင်္ဂါ {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "အင်္ဂါ {0} ပတ်အတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူးနေ့" }, { 0, "ဤဗုဒ္ဓဟူးနေ့" }, { 1, "လာမည့် ဗုဒ္ဓဟူးနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူး {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ဗုဒ္ဓဟူး {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူးနေ့" }, { 0, "ဤဗုဒ္ဓဟူးနေ့" }, { 1, "လာမည့် ဗုဒ္ဓဟူးနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူး {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ဗုဒ္ဓဟူး {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူးနေ့" }, { 0, "ဤဗုဒ္ဓဟူးနေ့" }, { 1, "လာမည့် ဗုဒ္ဓဟူးနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ဗုဒ္ဓဟူး {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ဗုဒ္ဓဟူး {0} ပတ်အတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ကြာသပတေးနေ့" }, { 0, "ဤကြာသပတေးနေ့" }, { 1, "လာမည့် ကြာသပတေးနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ကြာသပတေး {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ကြာသပတေး {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ကြာသပတေးနေ့" }, { 0, "ဤကြာသပတေးနေ့" }, { 1, "လာမည့် ကြာသပတေးနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ကြာသပတေး {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ကြာသပတေး {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် ကြာသပတေးနေ့" }, { 0, "ဤကြာသပတေးနေ့" }, { 1, "လာမည့် ကြာသပတေးနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် ကြာသပတေး {0} ပတ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ကြာသပတေး {0} ပတ်အတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သောကြာနေ့" }, { 0, "ဤသောကြာနေ့" }, { 1, "လာမည့် သောကြာနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သောကြာ {0} ပတ်အတွင်း" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သောကြာ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သောကြာနေ့" }, { 0, "ဤသောကြာနေ့" }, { 1, "လာမည့် သောကြာနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သောကြာ {0} ပတ်အတွင်း" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သောကြာ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် သောကြာနေ့" }, { 0, "ဤသောကြာနေ့" }, { 1, "လာမည့် သောကြာနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် သောကြာ {0} ပတ်အတွင်း" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "သောကြာ {0} ပတ်အတွင်း" } })
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
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် စနေနေ့" }, { 0, "ဤစနေနေ့" }, { 1, "လာမည့် စနေနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် စနေ {0} ပတ်အတွင်း" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "စနေ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် စနေနေ့" }, { 0, "ဤစနေနေ့" }, { 1, "လာမည့် စနေနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် စနေ {0} ပတ်အတွင်း" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "စနေ {0} ပတ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ပြီးခဲ့သည့် စနေနေ့" }, { 0, "ဤစနေနေ့" }, { 1, "လာမည့် စနေနေ့" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် စနေ {0} ပတ်အတွင်း" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "စနေ {0} ပတ်အတွင်း" } })
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
									new Dictionary<int, string> { { 0, "ဤအချိန်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နာရီ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နာရီအတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ဤအချိန်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နာရီ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နာရီအတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ဤအချိန်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} နာရီ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} နာရီအတွင်း" } })
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
									new Dictionary<int, string> { { 0, "ဤမိနစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} မိနစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} မိနစ်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ဤမိနစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} မိနစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} မိနစ်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ဤမိနစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} မိနစ်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} မိနစ်အတွင်း" } })
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
									new Dictionary<int, string> { { 0, "ယခု" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} စက္ကန့်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} စက္ကန့်အတွင်း" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ယခု" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} စက္ကန့်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} စက္ကန့်အတွင်း" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ယခု" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ပြီးခဲ့သည့် {0} စက္ကန့်" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} စက္ကန့်အတွင်း" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("my");
		}
	}
}