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
	/// Relative Time Units resource for 'Mongolian' [mn]
	/// </summary>
	public class MnRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public MnRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "өнгөрсөн жил" }, { 0, "энэ жил" }, { 1, "ирэх жил" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жилийн өмнө" }, { PluralRulesValues.Other, "{0} жилийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жилийн дараа" }, { PluralRulesValues.Other, "{0} жилийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн жил" }, { 0, "энэ жил" }, { 1, "ирэх жил" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жилийн өмнө" }, { PluralRulesValues.Other, "{0} жилийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жилийн дараа" }, { PluralRulesValues.Other, "{0} жилийн дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн жил" }, { 0, "энэ жил" }, { 1, "ирэх жил" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жилийн өмнө" }, { PluralRulesValues.Other, "{0} жилийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} жилийн дараа" }, { PluralRulesValues.Other, "{0} жилийн дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн улирал" }, { 0, "энэ улирал" }, { 1, "дараагийн улирал" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} улирлын өмнө" }, { PluralRulesValues.Other, "{0} улирлын өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} улирлын дараа" }, { PluralRulesValues.Other, "{0} улирлын дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн улирал" }, { 0, "энэ улирал" }, { 1, "дараагийн улирал" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} улирлын өмнө" }, { PluralRulesValues.Other, "{0} улирлын өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} улирлын дараа" }, { PluralRulesValues.Other, "{0} улирлын дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн улирал" }, { 0, "энэ улирал" }, { 1, "дараагийн улирал" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} улирлын өмнө" }, { PluralRulesValues.Other, "{0} улирлын өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} улирлын дараа" }, { PluralRulesValues.Other, "{0} улирлын дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн сар" }, { 0, "энэ сар" }, { 1, "ирэх сар" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сарын өмнө" }, { PluralRulesValues.Other, "{0} сарын өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сарын дараа" }, { PluralRulesValues.Other, "{0} сарын дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн сар" }, { 0, "энэ сар" }, { 1, "ирэх сар" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сарын өмнө" }, { PluralRulesValues.Other, "{0} сарын өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сарын дараа" }, { PluralRulesValues.Other, "{0} сарын дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн сар" }, { 0, "энэ сар" }, { 1, "ирэх сар" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сарын өмнө" }, { PluralRulesValues.Other, "{0} сарын өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сарын дараа" }, { PluralRulesValues.Other, "{0} сарын дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн долоо хоног" }, { 0, "энэ долоо хоног" }, { 1, "ирэх долоо хоног" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} долоо хоногийн өмнө" }, { PluralRulesValues.Other, "{0} долоо хоногийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} долоо хоногийн дараа" }, { PluralRulesValues.Other, "{0} долоо хоногийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн 7 хоног" }, { 0, "энэ 7 хоног" }, { 1, "ирэх 7 хоног" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} 7 хоногийн өмнө" }, { PluralRulesValues.Other, "{0} 7 хоногийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} 7 хоногийн дараа" }, { PluralRulesValues.Other, "{0} 7 хоногийн дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн 7 хоног" }, { 0, "энэ 7 хоног" }, { 1, "ирэх 7 хоног" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} 7 хоногийн өмнө" }, { PluralRulesValues.Other, "{0} 7 хоногийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} 7 хоногийн дараа" }, { PluralRulesValues.Other, "{0} 7 хоногийн дараа" } })
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
									new Dictionary<int, string> { { -2, "уржигдар" }, { -1, "өчигдөр" }, { 0, "өнөөдөр" }, { 1, "маргааш" }, { 2, "нөгөөдөр" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} өдрийн өмнө" }, { PluralRulesValues.Other, "{0} өдрийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} өдрийн дараа" }, { PluralRulesValues.Other, "{0} өдрийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "уржигдар" }, { -1, "өчигдөр" }, { 0, "өнөөдөр" }, { 1, "маргааш" }, { 2, "нөгөөдөр" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} өдрийн өмнө" }, { PluralRulesValues.Other, "{0} өдрийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} өдрийн дараа" }, { PluralRulesValues.Other, "{0} өдрийн дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "уржигдар" }, { -1, "өчигдөр" }, { 0, "өнөөдөр" }, { 1, "маргааш" }, { 2, "нөгөөдөр" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} өдрийн өмнө" }, { PluralRulesValues.Other, "{0} өдрийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} өдрийн дараа" }, { PluralRulesValues.Other, "{0} өдрийн дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн ням гараг" }, { 0, "энэ ням гараг" }, { 1, "ирэх ням гараг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ням гарагийн өмнө" }, { PluralRulesValues.Other, "{0} ням гарагийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ням гарагийн дараа" }, { PluralRulesValues.Other, "{0} ням гарагийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Ня" }, { 0, "энэ Ня" }, { 1, "ирэх Ня" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ня өмнө" }, { PluralRulesValues.Other, "{0} Ня өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ня дараа" }, { PluralRulesValues.Other, "{0} Ня дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Ня" }, { 0, "энэ Ня" }, { 1, "ирэх Ня" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ня өмнө" }, { PluralRulesValues.Other, "{0} Ня өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ня дараа" }, { PluralRulesValues.Other, "{0} Ня дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн даваа гараг" }, { 0, "энэ даваа гараг" }, { 1, "ирэх даваа гараг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} даваа гарагийн өмнө" }, { PluralRulesValues.Other, "{0} даваа гарагийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} даваа гарагийн дараа" }, { PluralRulesValues.Other, "{0} даваа гарагийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Да" }, { 0, "энэ Да" }, { 1, "ирэх Да" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Да өмнө" }, { PluralRulesValues.Other, "{0} Да өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Да дараа" }, { PluralRulesValues.Other, "{0} Да дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Да" }, { 0, "энэ Да" }, { 1, "ирэх Да" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Да өмнө" }, { PluralRulesValues.Other, "{0} Да өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Да дараа" }, { PluralRulesValues.Other, "{0} Да дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн мягмар гараг" }, { 0, "энэ мягмар гараг" }, { 1, "ирэх мягмар гараг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мягмар гарагийн өмнө" }, { PluralRulesValues.Other, "{0} мягмар гарагийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мягмар гарагийн дараа" }, { PluralRulesValues.Other, "{0} мягмар гарагийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Мя" }, { 0, "энэ Мя" }, { 1, "ирэх Мя" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Мя өмнө" }, { PluralRulesValues.Other, "{0} Мя өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Мя дараа" }, { PluralRulesValues.Other, "{0} Мя дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Мя" }, { 0, "энэ Мя" }, { 1, "ирэх Мя" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Мя өмнө" }, { PluralRulesValues.Other, "{0} Мя өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Мя дараа" }, { PluralRulesValues.Other, "{0} Мя дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн лхагва гараг" }, { 0, "энэ лхагва гараг" }, { 1, "ирэх лхагва гараг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} лхагва гарагийн өмнө" }, { PluralRulesValues.Other, "{0} лхагва гарагийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} лхагва гарагийн дараа" }, { PluralRulesValues.Other, "{0} лхагва гарагийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Лха" }, { 0, "энэ Лха" }, { 1, "ирэх Лха" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Лха өмнө" }, { PluralRulesValues.Other, "{0} Лха өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Лха дараа" }, { PluralRulesValues.Other, "{0} Лха дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Лха" }, { 0, "энэ Лха" }, { 1, "ирэх Лха" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Лха өмнө" }, { PluralRulesValues.Other, "{0} Лха өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Лха дараа" }, { PluralRulesValues.Other, "{0} Лха дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн пүрэв гараг" }, { 0, "энэ пүрэв гараг" }, { 1, "ирэх пүрэв гараг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пүрэв гарагийн өмнө" }, { PluralRulesValues.Other, "{0} пүрэв гарагийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пүрэв гарагийн дараа" }, { PluralRulesValues.Other, "{0} пүрэв гарагийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Пү" }, { 0, "энэ Пү" }, { 1, "ирэх Пү" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Пү өмнө" }, { PluralRulesValues.Other, "{0} Пү өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Пү дараа" }, { PluralRulesValues.Other, "{0} Пү дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Пү" }, { 0, "энэ Пү" }, { 1, "ирэх Пү" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Пү өмнө" }, { PluralRulesValues.Other, "{0} Пү өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Пү дараа" }, { PluralRulesValues.Other, "{0} Пү дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн баасан гараг" }, { 0, "энэ баасан гараг" }, { 1, "ирэх баасан гараг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} баасан гарагийн өмнө" }, { PluralRulesValues.Other, "{0} баасан гарагийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} баасан гарагийн дараа" }, { PluralRulesValues.Other, "{0} баасан гарагийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Ба" }, { 0, "энэ Ба" }, { 1, "ирэх Ба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ба өмнө" }, { PluralRulesValues.Other, "{0} Ба өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ба дараа" }, { PluralRulesValues.Other, "{0} Ба дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Ба" }, { 0, "энэ Ба" }, { 1, "ирэх Ба" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ба өмнө" }, { PluralRulesValues.Other, "{0} Ба өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ба дараа" }, { PluralRulesValues.Other, "{0} Ба дараа" } })
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
									new Dictionary<int, string> { { -1, "өнгөрсөн бямба гараг" }, { 0, "энэ бямба гараг" }, { 1, "ирэх бямба гараг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} бямба гарагийн өмнө" }, { PluralRulesValues.Other, "{0} бямба гарагийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} бямба гарагийн дараа" }, { PluralRulesValues.Other, "{0} бямба гарагийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Бя" }, { 0, "энэ Бя" }, { 1, "ирэх Бя" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Бя өмнө" }, { PluralRulesValues.Other, "{0} Бя өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Бя дараа" }, { PluralRulesValues.Other, "{0} Бя дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "өнгөрсөн Бя" }, { 0, "энэ Бя" }, { 1, "ирэх Бя" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Бя өмнө" }, { PluralRulesValues.Other, "{0} Бя өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Бя дараа" }, { PluralRulesValues.Other, "{0} Бя дараа" } })
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
									new Dictionary<int, string> { { 0, "энэ цаг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} цагийн өмнө" }, { PluralRulesValues.Other, "{0} цагийн өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} цагийн дараа" }, { PluralRulesValues.Other, "{0} цагийн дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "энэ цаг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ц өмнө" }, { PluralRulesValues.Other, "{0} ц өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ц дараа" }, { PluralRulesValues.Other, "{0} ц дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "энэ цаг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ц өмнө" }, { PluralRulesValues.Other, "{0} ц өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ц дараа" }, { PluralRulesValues.Other, "{0} ц дараа" } })
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
									new Dictionary<int, string> { { 0, "энэ минут" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} минутын өмнө" }, { PluralRulesValues.Other, "{0} минутын өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} минутын дараа" }, { PluralRulesValues.Other, "{0} минутын дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "энэ минут" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мин өмнө" }, { PluralRulesValues.Other, "{0} мин өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мин дараа" }, { PluralRulesValues.Other, "{0} мин дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "энэ минут" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мин өмнө" }, { PluralRulesValues.Other, "{0} мин өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мин дараа" }, { PluralRulesValues.Other, "{0} мин дараа" } })
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
									new Dictionary<int, string> { { 0, "одоо" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} секундын өмнө" }, { PluralRulesValues.Other, "{0} секундын өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} секундын дараа" }, { PluralRulesValues.Other, "{0} секундын дараа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "одоо" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сек өмнө" }, { PluralRulesValues.Other, "{0} сек өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сек дараа" }, { PluralRulesValues.Other, "{0} сек дараа" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "одоо" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сек өмнө" }, { PluralRulesValues.Other, "{0} сек өмнө" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сек дараа" }, { PluralRulesValues.Other, "{0} сек дараа" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("mn");
		}
	}
}