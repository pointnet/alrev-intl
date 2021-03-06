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
	/// Relative Time Units resource for 'Belarusian' [be]
	/// </summary>
	public class BeRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public BeRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "у мінулым годзе" }, { 0, "у гэтым годзе" }, { 1, "у наступным годзе" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} год таму" }, { PluralRulesValues.Few, "{0} гады таму" }, { PluralRulesValues.Many, "{0} гадоў таму" }, { PluralRulesValues.Other, "{0} года таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} год" }, { PluralRulesValues.Few, "праз {0} гады" }, { PluralRulesValues.Many, "праз {0} гадоў" }, { PluralRulesValues.Other, "праз {0} года" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мін. годзе" }, { 0, "у гэтым годзе" }, { 1, "у наст. годзе" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} г. таму" }, { PluralRulesValues.Few, "{0} г. таму" }, { PluralRulesValues.Many, "{0} г. таму" }, { PluralRulesValues.Other, "{0} г. таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} г." }, { PluralRulesValues.Few, "праз {0} г." }, { PluralRulesValues.Many, "праз {0} г." }, { PluralRulesValues.Other, "праз {0} г." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мін. годзе" }, { 0, "у гэтым годзе" }, { 1, "у наст. годзе" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} г. таму" }, { PluralRulesValues.Few, "{0} г. таму" }, { PluralRulesValues.Many, "{0} г. таму" }, { PluralRulesValues.Other, "{0} г. таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} г." }, { PluralRulesValues.Few, "праз {0} г." }, { PluralRulesValues.Many, "праз {0} г." }, { PluralRulesValues.Other, "праз {0} г." } })
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
									new Dictionary<int, string> { { -1, "у мінулым квартале" }, { 0, "у гэтым квартале" }, { 1, "у наступным квартале" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} квартал таму" }, { PluralRulesValues.Few, "{0} кварталы таму" }, { PluralRulesValues.Many, "{0} кварталаў таму" }, { PluralRulesValues.Other, "{0} квартала таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} квартал" }, { PluralRulesValues.Few, "праз {0} кварталы" }, { PluralRulesValues.Many, "праз {0} кварталаў" }, { PluralRulesValues.Other, "праз {0} квартала" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулым квартале" }, { 0, "у гэтым квартале" }, { 1, "у наступным квартале" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} кв. таму" }, { PluralRulesValues.Few, "{0} кв. таму" }, { PluralRulesValues.Many, "{0} кв. таму" }, { PluralRulesValues.Other, "{0} кв. таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} кв." }, { PluralRulesValues.Few, "праз {0} кв." }, { PluralRulesValues.Many, "праз {0} кв." }, { PluralRulesValues.Other, "праз {0} кв." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулым квартале" }, { 0, "у гэтым квартале" }, { 1, "у наступным квартале" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} кв. таму" }, { PluralRulesValues.Few, "{0} кв. таму" }, { PluralRulesValues.Many, "{0} кв. таму" }, { PluralRulesValues.Other, "{0} кв. таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} кв." }, { PluralRulesValues.Few, "праз {0} кв." }, { PluralRulesValues.Many, "праз {0} кв." }, { PluralRulesValues.Other, "праз {0} кв." } })
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
									new Dictionary<int, string> { { -1, "у мінулым месяцы" }, { 0, "у гэтым месяцы" }, { 1, "у наступным месяцы" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} месяц таму" }, { PluralRulesValues.Few, "{0} месяцы таму" }, { PluralRulesValues.Many, "{0} месяцаў таму" }, { PluralRulesValues.Other, "{0} месяца таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} месяц" }, { PluralRulesValues.Few, "праз {0} месяцы" }, { PluralRulesValues.Many, "праз {0} месяцаў" }, { PluralRulesValues.Other, "праз {0} месяца" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мін. мес." }, { 0, "у гэтым мес." }, { 1, "у наст. мес." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мес. таму" }, { PluralRulesValues.Few, "{0} мес. таму" }, { PluralRulesValues.Many, "{0} мес. таму" }, { PluralRulesValues.Other, "{0} мес. таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} мес." }, { PluralRulesValues.Few, "праз {0} мес." }, { PluralRulesValues.Many, "праз {0} мес." }, { PluralRulesValues.Other, "праз {0} мес." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мін. мес." }, { 0, "у гэтым мес." }, { 1, "у наст. мес." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мес. таму" }, { PluralRulesValues.Few, "{0} мес. таму" }, { PluralRulesValues.Many, "{0} мес. таму" }, { PluralRulesValues.Other, "{0} мес. таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} мес." }, { PluralRulesValues.Few, "праз {0} мес." }, { PluralRulesValues.Many, "праз {0} мес." }, { PluralRulesValues.Other, "праз {0} мес." } })
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
									new Dictionary<int, string> { { -1, "на мінулым тыдні" }, { 0, "на гэтым тыдні" }, { 1, "на наступным тыдні" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} тыдзень таму" }, { PluralRulesValues.Few, "{0} тыдні таму" }, { PluralRulesValues.Many, "{0} тыдняў таму" }, { PluralRulesValues.Other, "{0} тыдня таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} тыдзень" }, { PluralRulesValues.Few, "праз {0} тыдні" }, { PluralRulesValues.Many, "праз {0} тыдняў" }, { PluralRulesValues.Other, "праз {0} тыдня" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "на мін. тыд." }, { 0, "на гэтым тыд." }, { 1, "на наст. тыд." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} тыд таму" }, { PluralRulesValues.Few, "{0} тыд таму" }, { PluralRulesValues.Many, "{0} тыд таму" }, { PluralRulesValues.Other, "{0} тыд таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} тыд" }, { PluralRulesValues.Few, "праз {0} тыд" }, { PluralRulesValues.Many, "праз {0} тыд" }, { PluralRulesValues.Other, "праз {0} тыд" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "на мін. тыд." }, { 0, "на гэтым тыд." }, { 1, "на наст. тыд." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} тыд таму" }, { PluralRulesValues.Few, "{0} тыд таму" }, { PluralRulesValues.Many, "{0} тыд таму" }, { PluralRulesValues.Other, "{0} тыд таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} тыд" }, { PluralRulesValues.Few, "праз {0} тыд" }, { PluralRulesValues.Many, "праз {0} тыд" }, { PluralRulesValues.Other, "праз {0} тыд" } })
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
									new Dictionary<int, string> { { -2, "пазаўчора" }, { -1, "учора" }, { 0, "сёння" }, { 1, "заўтра" }, { 2, "паслязаўтра" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дзень таму" }, { PluralRulesValues.Few, "{0} дні таму" }, { PluralRulesValues.Many, "{0} дзён таму" }, { PluralRulesValues.Other, "{0} дня таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} дзень" }, { PluralRulesValues.Few, "праз {0} дні" }, { PluralRulesValues.Many, "праз {0} дзён" }, { PluralRulesValues.Other, "праз {0} дня" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "пазаўчора" }, { -1, "учора" }, { 0, "сёння" }, { 1, "заўтра" }, { 2, "паслязаўтра" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дзень таму" }, { PluralRulesValues.Few, "{0} дні таму" }, { PluralRulesValues.Many, "{0} дзён таму" }, { PluralRulesValues.Other, "{0} дня таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} дзень" }, { PluralRulesValues.Few, "праз {0} дні" }, { PluralRulesValues.Many, "праз {0} дзён" }, { PluralRulesValues.Other, "праз {0} дня" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "пазаўчора" }, { -1, "учора" }, { 0, "сёння" }, { 1, "заўтра" }, { 2, "паслязаўтра" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дзень таму" }, { PluralRulesValues.Few, "{0} дні таму" }, { PluralRulesValues.Many, "{0} дзён таму" }, { PluralRulesValues.Other, "{0} дня таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} дзень" }, { PluralRulesValues.Few, "праз {0} дні" }, { PluralRulesValues.Many, "праз {0} дзён" }, { PluralRulesValues.Other, "праз {0} дня" } })
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
									new Dictionary<int, string> { { -1, "у мінулую нядзелю" }, { 0, "у гэту нядзелю" }, { 1, "у наступную нядзелю" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} нядзелю таму" }, { PluralRulesValues.Few, "{0} нядзелі таму" }, { PluralRulesValues.Many, "{0} нядзель таму" }, { PluralRulesValues.Other, "{0} нядзелі таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} нядзелю" }, { PluralRulesValues.Few, "праз {0} нядзелі" }, { PluralRulesValues.Many, "праз {0} нядзель" }, { PluralRulesValues.Other, "праз {0} нядзелі" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулую нд" }, { 0, "у гэту нд" }, { 1, "у наступную нд" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} нд таму" }, { PluralRulesValues.Few, "{0} нядзелі таму" }, { PluralRulesValues.Many, "{0} нядзель таму" }, { PluralRulesValues.Other, "{0} нд таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} нд" }, { PluralRulesValues.Few, "праз {0} нядзелі" }, { PluralRulesValues.Many, "праз {0} нядзель" }, { PluralRulesValues.Other, "праз {0} нд" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулую нд" }, { 0, "у гэту нд" }, { 1, "у наступную нд" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} нд таму" }, { PluralRulesValues.Few, "{0} нядзелі таму" }, { PluralRulesValues.Many, "{0} нядзель таму" }, { PluralRulesValues.Other, "{0} нд таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} нд" }, { PluralRulesValues.Few, "праз {0} нядзелі" }, { PluralRulesValues.Many, "праз {0} нядзель" }, { PluralRulesValues.Other, "праз {0} нд" } })
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
									new Dictionary<int, string> { { -1, "у мінулы панядзелак" }, { 0, "у гэты панядзелак" }, { 1, "у наступны панядзелак" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} панядзелак таму" }, { PluralRulesValues.Few, "{0} панядзелкі таму" }, { PluralRulesValues.Many, "{0} панядзелкаў таму" }, { PluralRulesValues.Other, "{0} панядзелка таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} панядзелак" }, { PluralRulesValues.Few, "праз {0} панядзелкі" }, { PluralRulesValues.Many, "праз {0} панядзелкаў" }, { PluralRulesValues.Other, "праз {0} панядзелка" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулы пн" }, { 0, "у гэты пн" }, { 1, "у наступны пн" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пн таму" }, { PluralRulesValues.Few, "{0} панядзелкі таму" }, { PluralRulesValues.Many, "{0} панядзелкаў таму" }, { PluralRulesValues.Other, "{0} пн таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} пн" }, { PluralRulesValues.Few, "праз {0} панядзелкі" }, { PluralRulesValues.Many, "праз {0} панядзелкаў" }, { PluralRulesValues.Other, "праз {0} пн" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулы пн" }, { 0, "у гэты пн" }, { 1, "у наступны пн" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пн таму" }, { PluralRulesValues.Few, "{0} панядзелкі таму" }, { PluralRulesValues.Many, "{0} панядзелкаў таму" }, { PluralRulesValues.Other, "{0} пн таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} пн" }, { PluralRulesValues.Few, "праз {0} панядзелкі" }, { PluralRulesValues.Many, "праз {0} панядзелкаў" }, { PluralRulesValues.Other, "праз {0} пн" } })
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
									new Dictionary<int, string> { { -1, "у мінулы аўторак" }, { 0, "у гэты аўторак" }, { 1, "у наступны аўторак" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} аўторак таму" }, { PluralRulesValues.Few, "{0} аўторкі таму" }, { PluralRulesValues.Many, "{0} аўторкаў таму" }, { PluralRulesValues.Other, "{0} аўторка таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} аўторак" }, { PluralRulesValues.Few, "праз {0} аўторкі" }, { PluralRulesValues.Many, "праз {0} аўторкаў" }, { PluralRulesValues.Other, "праз {0} аўторка" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулы аў" }, { 0, "у гэты аў" }, { 1, "у наступны аў" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} аў таму" }, { PluralRulesValues.Few, "{0} аўторкі таму" }, { PluralRulesValues.Many, "{0} аўторкаў таму" }, { PluralRulesValues.Other, "{0} аў таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} аў" }, { PluralRulesValues.Few, "праз {0} аўторкі" }, { PluralRulesValues.Many, "праз {0} аўторкаў" }, { PluralRulesValues.Other, "праз {0} аў" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулы аў" }, { 0, "у гэты аў" }, { 1, "у наступны аў" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} аў таму" }, { PluralRulesValues.Few, "{0} аўторкі таму" }, { PluralRulesValues.Many, "{0} аўторкаў таму" }, { PluralRulesValues.Other, "{0} аў таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} аў" }, { PluralRulesValues.Few, "праз {0} аўторкі" }, { PluralRulesValues.Many, "праз {0} аўторкаў" }, { PluralRulesValues.Other, "праз {0} аў" } })
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
									new Dictionary<int, string> { { -1, "у мінулую сераду" }, { 0, "у гэту сераду" }, { 1, "у наступную сераду" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сераду таму" }, { PluralRulesValues.Few, "{0} серады таму" }, { PluralRulesValues.Many, "{0} серад таму" }, { PluralRulesValues.Other, "{0} серады таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} сераду" }, { PluralRulesValues.Few, "праз {0} серады" }, { PluralRulesValues.Many, "праз {0} серад" }, { PluralRulesValues.Other, "праз {0} серады" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулую ср" }, { 0, "у гэту ср" }, { 1, "у наступную ср" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ср таму" }, { PluralRulesValues.Few, "{0} серады таму" }, { PluralRulesValues.Many, "{0} серад таму" }, { PluralRulesValues.Other, "{0} ср таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} ср" }, { PluralRulesValues.Few, "праз {0} серады" }, { PluralRulesValues.Many, "праз {0} серад" }, { PluralRulesValues.Other, "праз {0} ср" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулую ср" }, { 0, "у гэту ср" }, { 1, "у наступную ср" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ср таму" }, { PluralRulesValues.Few, "{0} серады таму" }, { PluralRulesValues.Many, "{0} серад таму" }, { PluralRulesValues.Other, "{0} ср таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} ср" }, { PluralRulesValues.Few, "праз {0} серады" }, { PluralRulesValues.Many, "праз {0} серад" }, { PluralRulesValues.Other, "праз {0} ср" } })
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
									new Dictionary<int, string> { { -1, "у мінулы чацвер" }, { 0, "у гэты чацвер" }, { 1, "у наступны чацвер" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} чацвер таму" }, { PluralRulesValues.Few, "{0} чацвяргі таму" }, { PluralRulesValues.Many, "{0} чацвяргоў таму" }, { PluralRulesValues.Other, "{0} чацвярга таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} чацвер" }, { PluralRulesValues.Few, "праз {0} чацвяргі" }, { PluralRulesValues.Many, "праз {0} чацвяргоў" }, { PluralRulesValues.Other, "праз {0} чацвярга" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулы чц" }, { 0, "у гэты чц" }, { 1, "у наступны чц" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} чц таму" }, { PluralRulesValues.Few, "{0} чацвяргі таму" }, { PluralRulesValues.Many, "{0} чацвяргоў таму" }, { PluralRulesValues.Other, "{0} чц таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} чц" }, { PluralRulesValues.Few, "праз {0} чацвяргі" }, { PluralRulesValues.Many, "праз {0} чацвяргоў" }, { PluralRulesValues.Other, "праз {0} чц" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулы чц" }, { 0, "у гэты чц" }, { 1, "у наступны чц" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} чц таму" }, { PluralRulesValues.Few, "{0} чацвяргі таму" }, { PluralRulesValues.Many, "{0} чацвяргоў таму" }, { PluralRulesValues.Other, "{0} чц таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} чц" }, { PluralRulesValues.Few, "праз {0} чацвяргі" }, { PluralRulesValues.Many, "праз {0} чацвяргоў" }, { PluralRulesValues.Other, "праз {0} чц" } })
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
									new Dictionary<int, string> { { -1, "у мінулую пятніцу" }, { 0, "у гэту пятніцу" }, { 1, "у наступную пятніцу" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пятніцу таму" }, { PluralRulesValues.Few, "{0} пятніцы таму" }, { PluralRulesValues.Many, "{0} пятніц таму" }, { PluralRulesValues.Other, "{0} пятніцы таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} пятніцу" }, { PluralRulesValues.Few, "праз {0} пятніцы" }, { PluralRulesValues.Many, "праз {0} пятніц" }, { PluralRulesValues.Other, "праз {0} пятніцы" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулую пт" }, { 0, "у гэту пт" }, { 1, "у наступную пт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пт таму" }, { PluralRulesValues.Few, "{0} пятніцы таму" }, { PluralRulesValues.Many, "{0} пятніц таму" }, { PluralRulesValues.Other, "{0} пт таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} пт" }, { PluralRulesValues.Few, "праз {0} пятніцы" }, { PluralRulesValues.Many, "праз {0} пятніц" }, { PluralRulesValues.Other, "праз {0} пт" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулую пт" }, { 0, "у гэту пт" }, { 1, "у наступную пт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пт таму" }, { PluralRulesValues.Few, "{0} пятніцы таму" }, { PluralRulesValues.Many, "{0} пятніц таму" }, { PluralRulesValues.Other, "{0} пт таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} пт" }, { PluralRulesValues.Few, "праз {0} пятніцы" }, { PluralRulesValues.Many, "праз {0} пятніц" }, { PluralRulesValues.Other, "праз {0} пт" } })
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
									new Dictionary<int, string> { { -1, "у мінулую суботу" }, { 0, "у гэту суботу" }, { 1, "у наступную суботу" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} суботу таму" }, { PluralRulesValues.Few, "{0} суботы таму" }, { PluralRulesValues.Many, "{0} субот таму" }, { PluralRulesValues.Other, "{0} суботы таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} суботу" }, { PluralRulesValues.Few, "праз {0} суботы" }, { PluralRulesValues.Many, "праз {0} субот" }, { PluralRulesValues.Other, "праз {0} суботы" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулую сб" }, { 0, "у гэту сб" }, { 1, "у наступную сб" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сб таму" }, { PluralRulesValues.Few, "{0} суботы таму" }, { PluralRulesValues.Many, "{0} субот таму" }, { PluralRulesValues.Other, "{0} сб таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} сб" }, { PluralRulesValues.Few, "праз {0} суботы" }, { PluralRulesValues.Many, "праз {0} субот" }, { PluralRulesValues.Other, "праз {0} сб" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "у мінулую сб" }, { 0, "у гэту сб" }, { 1, "у наступную сб" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сб таму" }, { PluralRulesValues.Few, "{0} суботы таму" }, { PluralRulesValues.Many, "{0} субот таму" }, { PluralRulesValues.Other, "{0} сб таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} сб" }, { PluralRulesValues.Few, "праз {0} суботы" }, { PluralRulesValues.Many, "праз {0} субот" }, { PluralRulesValues.Other, "праз {0} сб" } })
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
									new Dictionary<int, string> { { 0, "у гэту гадзіну" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} гадзіну таму" }, { PluralRulesValues.Few, "{0} гадзіны таму" }, { PluralRulesValues.Many, "{0} гадзін таму" }, { PluralRulesValues.Other, "{0} гадзіны таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} гадзіну" }, { PluralRulesValues.Few, "праз {0} гадзіны" }, { PluralRulesValues.Many, "праз {0} гадзін" }, { PluralRulesValues.Other, "праз {0} гадзіны" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "у гэту гадзіну" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} гадз таму" }, { PluralRulesValues.Few, "{0} гадз таму" }, { PluralRulesValues.Many, "{0} гадз таму" }, { PluralRulesValues.Other, "{0} гадз таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} гадз" }, { PluralRulesValues.Few, "праз {0} гадз" }, { PluralRulesValues.Many, "праз {0} гадз" }, { PluralRulesValues.Other, "праз {0} гадз" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "у гэту гадзіну" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} гадз таму" }, { PluralRulesValues.Few, "{0} гадз таму" }, { PluralRulesValues.Many, "{0} гадз таму" }, { PluralRulesValues.Other, "{0} гадз таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} гадз" }, { PluralRulesValues.Few, "праз {0} гадз" }, { PluralRulesValues.Many, "праз {0} гадз" }, { PluralRulesValues.Other, "праз {0} гадз" } })
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
									new Dictionary<int, string> { { 0, "у гэту хвіліну" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} хвіліну таму" }, { PluralRulesValues.Few, "{0} хвіліны таму" }, { PluralRulesValues.Many, "{0} хвілін таму" }, { PluralRulesValues.Other, "{0} хвіліны таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} хвіліну" }, { PluralRulesValues.Few, "праз {0} хвіліны" }, { PluralRulesValues.Many, "праз {0} хвілін" }, { PluralRulesValues.Other, "праз {0} хвіліны" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "у гэту хвіліну" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} хв таму" }, { PluralRulesValues.Few, "{0} хв таму" }, { PluralRulesValues.Many, "{0} хв таму" }, { PluralRulesValues.Other, "{0} хв таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} хв" }, { PluralRulesValues.Few, "праз {0} хв" }, { PluralRulesValues.Many, "праз {0} хв" }, { PluralRulesValues.Other, "праз {0} хв" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "у гэту хвіліну" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} хв таму" }, { PluralRulesValues.Few, "{0} хв таму" }, { PluralRulesValues.Many, "{0} хв таму" }, { PluralRulesValues.Other, "{0} хв таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} хв" }, { PluralRulesValues.Few, "праз {0} хв" }, { PluralRulesValues.Many, "праз {0} хв" }, { PluralRulesValues.Other, "праз {0} хв" } })
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
									new Dictionary<int, string> { { 0, "цяпер" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} секунду таму" }, { PluralRulesValues.Few, "{0} секунды таму" }, { PluralRulesValues.Many, "{0} секунд таму" }, { PluralRulesValues.Other, "{0} секунды таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} секунду" }, { PluralRulesValues.Few, "праз {0} секунды" }, { PluralRulesValues.Many, "праз {0} секунд" }, { PluralRulesValues.Other, "праз {0} секунды" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "цяпер" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} с таму" }, { PluralRulesValues.Few, "{0} с таму" }, { PluralRulesValues.Many, "{0} с таму" }, { PluralRulesValues.Other, "{0} с таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} с" }, { PluralRulesValues.Few, "праз {0} с" }, { PluralRulesValues.Many, "праз {0} с" }, { PluralRulesValues.Other, "праз {0} с" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "цяпер" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} с таму" }, { PluralRulesValues.Few, "{0} с таму" }, { PluralRulesValues.Many, "{0} с таму" }, { PluralRulesValues.Other, "{0} с таму" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "праз {0} с" }, { PluralRulesValues.Few, "праз {0} с" }, { PluralRulesValues.Many, "праз {0} с" }, { PluralRulesValues.Other, "праз {0} с" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("be");
		}
	}
}