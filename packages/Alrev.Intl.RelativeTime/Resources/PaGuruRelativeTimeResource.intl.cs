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
	/// Relative Time Units resource for 'Punjabi' [pa-guru]
	/// </summary>
	public class PaGuruRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public PaGuruRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸਾਲ" }, { 0, "ਇਹ ਸਾਲ" }, { 1, "ਅਗਲਾ ਸਾਲ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਾਲ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸਾਲ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਾਲ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸਾਲਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸਾਲ" }, { 0, "ਇਹ ਸਾਲ" }, { 1, "ਅਗਲਾ ਸਾਲ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਾਲ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸਾਲ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਾਲ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸਾਲਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸਾਲ" }, { 0, "ਇਹ ਸਾਲ" }, { 1, "ਅਗਲਾ ਸਾਲ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਾਲ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸਾਲ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਾਲ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸਾਲਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲੀ ਤਿਮਾਹੀ" }, { 0, "ਇਸ ਤਿਮਾਹੀ" }, { 1, "ਅਗਲੀ ਤਿਮਾਹੀ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਤਿਮਾਹੀ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਤਿਮਾਹੀਆਂ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਤਿਮਾਹੀ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਤਿਮਾਹੀਆਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲੀ ਤਿਮਾਹੀ" }, { 0, "ਇਹ ਤਿਮਾਹੀ" }, { 1, "ਅਗਲੀ ਤਿਮਾਹੀ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਤਿਮਾਹੀ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਤਿਮਾਹੀਆਂ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਤਿਮਾਹੀ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਤਿਮਾਹੀਆਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲੀ ਤਿਮਾਹੀ" }, { 0, "ਇਹ ਤਿਮਾਹੀ" }, { 1, "ਅਗਲੀ ਤਿਮਾਹੀ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਤਿਮਾਹੀ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਤਿਮਾਹੀਆਂ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਤਿਮਾਹੀ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਤਿਮਾਹੀਆਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਮਹੀਨਾ" }, { 0, "ਇਹ ਮਹੀਨਾ" }, { 1, "ਅਗਲਾ ਮਹੀਨਾ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਹੀਨਾ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਮਹੀਨੇ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਹੀਨੇ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਮਹੀਨਿਆਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਮਹੀਨਾ" }, { 0, "ਇਹ ਮਹੀਨਾ" }, { 1, "ਅਗਲਾ ਮਹੀਨਾ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਹੀਨਾ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਮਹੀਨੇ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਹੀਨੇ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਮਹੀਨਿਆਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਮਹੀਨਾ" }, { 0, "ਇਹ ਮਹੀਨਾ" }, { 1, "ਅਗਲਾ ਮਹੀਨਾ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਹੀਨਾ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਮਹੀਨੇ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਹੀਨੇ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਮਹੀਨਿਆਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਹਫ਼ਤਾ" }, { 0, "ਇਹ ਹਫ਼ਤਾ" }, { 1, "ਅਗਲਾ ਹਫ਼ਤਾ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਹਫ਼ਤਾ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਹਫ਼ਤੇ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਹਫ਼ਤੇ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਹਫ਼ਤਿਆਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਹਫ਼ਤਾ" }, { 0, "ਇਹ ਹਫ਼ਤਾ" }, { 1, "ਅਗਲਾ ਹਫ਼ਤਾ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਹਫ਼ਤਾ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਹਫ਼ਤੇ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਹਫ਼ਤੇ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਹਫ਼ਤਿਆਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਹਫ਼ਤਾ" }, { 0, "ਇਹ ਹਫ਼ਤਾ" }, { 1, "ਅਗਲਾ ਹਫ਼ਤਾ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਹਫ਼ਤਾ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਹਫ਼ਤੇ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਹਫ਼ਤੇ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਹਫ਼ਤਿਆਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਬੀਤਿਆ ਕੱਲ੍ਹ" }, { 0, "ਅੱਜ" }, { 1, "ਭਲਕੇ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਦਿਨ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਦਿਨ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਦਿਨ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਦਿਨਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਬੀਤਿਆ ਕੱਲ੍ਹ" }, { 0, "ਅੱਜ" }, { 1, "ਭਲਕੇ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਦਿਨ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਦਿਨ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਦਿਨ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਦਿਨਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਬੀਤਿਆ ਕੱਲ੍ਹ" }, { 0, "ਅੱਜ" }, { 1, "ਭਲਕੇ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਦਿਨ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਦਿਨ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਦਿਨ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਦਿਨਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਐਤਵਾਰ" }, { 0, "ਇਸ ਐਤਵਾਰ" }, { 1, "ਅਗਲਾ ਐਤਵਾਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਐਤਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਐਤਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਐਤਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਐਤਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਐਤ" }, { 0, "ਇਹ ਐਤ" }, { 1, "ਅਗਲਾ ਐਤ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਐਤਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਐਤਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਐਤਵਾਰਾਂ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਐਤਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਐਤ" }, { 0, "ਇਹ ਐਤ" }, { 1, "ਅਗਲਾ ਐਤ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਐਤਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਐਤਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਐਤਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਐਤਵਾਰਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸੋਮਵਾਰ" }, { 0, "ਇਸ ਸੋਮਵਾਰ" }, { 1, "ਅਗਲਾ ਸੋਮਵਾਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸੋਮਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸੋਮਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸੋਮਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸੋਮਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸੋਮ" }, { 0, "ਇਸ ਸੋਮ" }, { 1, "ਅਗਲਾ ਸੋਮ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸੋਮਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸੋਮਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸੋਮਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸੋਮਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸੋਮ" }, { 0, "ਇਸ ਸੋਮ" }, { 1, "ਅਗਲਾ ਸੋਮ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸੋਮਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸੋਮਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸੋਮਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸੋਮਵਾਰਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਮੰਗਲਵਾਰ" }, { 0, "ਇਹ ਮੰਗਲਵਾਰ" }, { 1, "ਅਗਲਾ ਮੰਗਲਵਾਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮੰਗਲਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਮੰਗਲਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮੰਗਲਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਮੰਗਲਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਮੰਗਲ" }, { 0, "ਇਹ ਮੰਗਲ" }, { 1, "ਅਗਲਾ ਮੰਗਲ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮੰਗਲਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਮੰਗਲਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮੰਗਲਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਮੰਗਲਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਮੰਗਲ" }, { 0, "ਇਹ ਮੰਗਲ" }, { 1, "ਅਗਲਾ ਮੰਗਲ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮੰਗਲਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਮੰਗਲਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮੰਗਲਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਮੰਗਲਵਾਰਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਬੁੱਧਵਾਰ" }, { 0, "ਇਹ ਬੁੱਧਵਾਰ" }, { 1, "ਅਗਲਾ ਬੁੱਧਵਾਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਬੁੱਧਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਬੁੱਧਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਬੁੱਧਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਬੁੱਧਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਬੁੱਧ" }, { 0, "ਇਹ ਬੁੱਧ" }, { 1, "ਅਗਲਾ ਬੁੱਧ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਬੁੱਧਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਬੁੱਧਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਬੁੱਧਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਬੁੱਧਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਬੁੱਧ" }, { 0, "ਇਹ ਬੁੱਧ" }, { 1, "ਅਗਲਾ ਬੁੱਧ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਬੁੱਧਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਬੁੱਧਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਬੁੱਧਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਬੁੱਧਵਾਰਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਵੀਰਵਾਰ" }, { 0, "ਇਹ ਵੀਰਵਾਰ" }, { 1, "ਅਗਲਾ ਵੀਰਵਾਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਵੀਰਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਵੀਰਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਵੀਰਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਵੀਰਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਵੀਰ" }, { 0, "ਇਹ ਵੀਰ" }, { 1, "ਅਗਲਾ ਵੀਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਵੀਰਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਵੀਰਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਵੀਰਵਾਰਾਂ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਵੀਰਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਵੀਰ" }, { 0, "ਇਹ ਵੀਰ" }, { 1, "ਅਗਲਾ ਵੀਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਵੀਰਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਵੀਰਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਵੀਰਵਾਰਾਂ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਵੀਰਵਾਰਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸ਼ੁੱਕਰਵਾਰ" }, { 0, "ਇਹ ਸ਼ੁੱਕਰਵਾਰ" }, { 1, "ਅਗਲਾ ਸ਼ੁੱਕਰਵਾਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ੁੱਕਰਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸ਼ੁੱਕਰਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ੁੱਕਰਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸ਼ੁੱਕਰਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸ਼ੁੱਕਰ" }, { 0, "ਇਹ ਸ਼ੁੱਕਰ" }, { 1, "ਅਗਲਾ ਸ਼ੁੱਕਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ੁੱਕਰਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸ਼ੁੱਕਰਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ੁੱਕਰਵਾਰਾਂ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸ਼ੁੱਕਰਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸ਼ੁੱ" }, { 0, "ਇਹ ਸ਼ੁੱ" }, { 1, "ਅਗਲਾ ਸ਼ੁੱ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ੁੱਕਰਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸ਼ੁੱਕਰਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ੁੱਕਰਵਾਰਾਂ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸ਼ੁੱਕਰਵਾਰਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸ਼ਨਿੱਚਰਵਾਰ" }, { 0, "ਇਹ ਸ਼ਨਿੱਚਰਵਾਰ" }, { 1, "ਅਗਲਾ ਸ਼ਨਿੱਚਰਵਾਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ਨਿੱਚਰਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸ਼ਨਿੱਚਰਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ਨਿੱਚਰਵਾਰ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸ਼ਨਿੱਚਰਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸ਼ਨਿੱਚਰ" }, { 0, "ਇਹ ਸ਼ਨਿੱਚਰ" }, { 1, "ਅਗਲਾ ਸ਼ਨਿੱਚਰ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ਨਿੱਚਰਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸ਼ਨਿੱਚਰਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ਨਿੱਚਰਵਾਰਾਂ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸ਼ਨਿੱਚਰਵਾਰਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ਪਿਛਲਾ ਸ਼ਨਿੱ" }, { 0, "ਇਹ ਸ਼ਨਿੱ" }, { 1, "ਅਗਲਾ ਸ਼ਨਿੱ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ਨਿੱਚਰਵਾਰ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸ਼ਨਿੱਚਰਵਾਰ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸ਼ਨਿੱਚਰਵਾਰਾਂ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸ਼ਨਿੱਚਰਵਾਰਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { 0, "ਇਸ ਘੰਟੇ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਘੰਟਾ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਘੰਟੇ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਘੰਟੇ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਘੰਟਿਆਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ਇਸ ਘੰਟੇ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਘੰਟਾ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਘੰਟੇ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਘੰਟੇ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਘੰਟਿਆਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ਇਸ ਘੰਟੇ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਘੰਟਾ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਘੰਟੇ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਘੰਟੇ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਘੰਟਿਆਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { 0, "ਇਸ ਮਿੰਟ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਿੰਟ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਮਿੰਟ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਿੰਟ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਮਿੰਟਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ਇਸ ਮਿੰਟ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਿੰਟ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਮਿੰਟ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਿੰਟ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਮਿੰਟਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ਇਸ ਮਿੰਟ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਿੰਟ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਮਿੰਟ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਮਿੰਟ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਮਿੰਟਾਂ ਵਿੱਚ" } })
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
									new Dictionary<int, string> { { 0, "ਹੁਣ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਕਿੰਟ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸਕਿੰਟ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਕਿੰਟ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸਕਿੰਟਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ਹੁਣ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਕਿੰਟ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸਕਿੰਟ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਕਿੰਟ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸਕਿੰਟਾਂ ਵਿੱਚ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ਹੁਣ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਕਿੰਟ ਪਹਿਲਾਂ" }, { PluralRulesValues.Other, "{0} ਸਕਿੰਟ ਪਹਿਲਾਂ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ਸਕਿੰਟ ਵਿੱਚ" }, { PluralRulesValues.Other, "{0} ਸਕਿੰਟਾਂ ਵਿੱਚ" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("pa-guru");
		}
	}
}