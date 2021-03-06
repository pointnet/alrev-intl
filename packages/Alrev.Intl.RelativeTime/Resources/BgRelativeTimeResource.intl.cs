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
	/// Relative Time Units resource for 'Bulgarian' [bg]
	/// </summary>
	public class BgRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public BgRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "миналата година" }, { 0, "тази година" }, { 1, "следващата година" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} година" }, { PluralRulesValues.Other, "преди {0} години" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} година" }, { PluralRulesValues.Other, "след {0} години" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "мин. г." }, { 0, "т. г." }, { 1, "следв. г." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} г." }, { PluralRulesValues.Other, "преди {0} г." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} г." }, { PluralRulesValues.Other, "след {0} г." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "мин. г." }, { 0, "т. г." }, { 1, "сл. г." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} г." }, { PluralRulesValues.Other, "пр. {0} г." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} г." }, { PluralRulesValues.Other, "сл. {0} г." } })
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
									new Dictionary<int, string> { { -1, "предходно тримесечие" }, { 0, "това тримесечие" }, { 1, "следващо тримесечие" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} тримесечие" }, { PluralRulesValues.Other, "преди {0} тримесечия" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} тримесечие" }, { PluralRulesValues.Other, "след {0} тримесечия" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "мин. трим." }, { 0, "това трим." }, { 1, "следв. трим." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} трим." }, { PluralRulesValues.Other, "преди {0} трим." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} трим." }, { PluralRulesValues.Other, "след {0} трим." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "мин. трим." }, { 0, "това трим." }, { 1, "следв. трим." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} трим." }, { PluralRulesValues.Other, "пр. {0} трим." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} трим." }, { PluralRulesValues.Other, "сл. {0} трим." } })
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
									new Dictionary<int, string> { { -1, "предходен месец" }, { 0, "този месец" }, { 1, "следващ месец" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} месец" }, { PluralRulesValues.Other, "преди {0} месеца" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} месец" }, { PluralRulesValues.Other, "след {0} месеца" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "мин. мес." }, { 0, "този мес." }, { 1, "следв. мес." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} м." }, { PluralRulesValues.Other, "преди {0} м." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} м." }, { PluralRulesValues.Other, "след {0} м." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "мин. м." }, { 0, "т. м." }, { 1, "сл. м." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} м." }, { PluralRulesValues.Other, "пр. {0} м." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} м." }, { PluralRulesValues.Other, "сл. {0} м." } })
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
									new Dictionary<int, string> { { -1, "предходната седмица" }, { 0, "тази седмица" }, { 1, "следващата седмица" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} седмица" }, { PluralRulesValues.Other, "преди {0} седмици" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} седмица" }, { PluralRulesValues.Other, "след {0} седмици" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "мин. седм." }, { 0, "тази седм." }, { 1, "следв. седм." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} седм." }, { PluralRulesValues.Other, "преди {0} седм." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} седм." }, { PluralRulesValues.Other, "след {0} седм." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "мин. седм." }, { 0, "тази седм." }, { 1, "сл. седм." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} седм." }, { PluralRulesValues.Other, "пр. {0} седм." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} седм." }, { PluralRulesValues.Other, "сл. {0} седм." } })
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
									new Dictionary<int, string> { { -2, "онзи ден" }, { -1, "вчера" }, { 0, "днес" }, { 1, "утре" }, { 2, "вдругиден" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} ден" }, { PluralRulesValues.Other, "преди {0} дни" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} ден" }, { PluralRulesValues.Other, "след {0} дни" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "онзи ден" }, { -1, "вчера" }, { 0, "днес" }, { 1, "утре" }, { 2, "вдругиден" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} ден" }, { PluralRulesValues.Other, "преди {0} дни" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} ден" }, { PluralRulesValues.Other, "след {0} дни" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "онзи ден" }, { -1, "вчера" }, { 0, "днес" }, { 1, "утре" }, { 2, "вдругиден" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} д" }, { PluralRulesValues.Other, "пр. {0} д" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} д" }, { PluralRulesValues.Other, "сл. {0} д" } })
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
									new Dictionary<int, string> { { -1, "предходната неделя" }, { 0, "тази неделя" }, { 1, "следващата неделя" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} неделя" }, { PluralRulesValues.Other, "преди {0} недели" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} неделя" }, { PluralRulesValues.Other, "след {0} недели" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предходната нд" }, { 0, "тази нд" }, { 1, "следващата нд" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} нд" }, { PluralRulesValues.Other, "преди {0} нд" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} нд" }, { PluralRulesValues.Other, "след {0} нд" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предх. нд" }, { 0, "тази нд" }, { 1, "следв. нд" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} нд" }, { PluralRulesValues.Other, "пр. {0} нд" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} нд" }, { PluralRulesValues.Other, "сл. {0} нд" } })
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
									new Dictionary<int, string> { { -1, "предходният понеделник" }, { 0, "този понеделник" }, { 1, "следващият понеделник" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} понеделник" }, { PluralRulesValues.Other, "преди {0} понеделника" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} понеделник" }, { PluralRulesValues.Other, "след {0} понеделника" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предходният пн" }, { 0, "този пн" }, { 1, "следващият пн" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} пн" }, { PluralRulesValues.Other, "преди {0} пн" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} пн" }, { PluralRulesValues.Other, "след {0} пн" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предх. пн" }, { 0, "този пн" }, { 1, "следв. пн" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} пн" }, { PluralRulesValues.Other, "пр. {0} пн" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} пн" }, { PluralRulesValues.Other, "сл. {0} пн" } })
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
									new Dictionary<int, string> { { -1, "предходният вторник" }, { 0, "този вторник" }, { 1, "следващият вторник" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} вторник" }, { PluralRulesValues.Other, "преди {0} вторника" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} вторник" }, { PluralRulesValues.Other, "след {0} вторника" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предходният вт" }, { 0, "този вт" }, { 1, "следващият вт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} вт" }, { PluralRulesValues.Other, "преди {0} вт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} вт" }, { PluralRulesValues.Other, "след {0} вт" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предх. вт" }, { 0, "този вт" }, { 1, "следв. вт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} вт" }, { PluralRulesValues.Other, "пр. {0} вт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} вт" }, { PluralRulesValues.Other, "сл. {0} вт" } })
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
									new Dictionary<int, string> { { -1, "предходната сряда" }, { 0, "тази сряда" }, { 1, "следващата сряда" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} сряда" }, { PluralRulesValues.Other, "преди {0} среди" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} сряда" }, { PluralRulesValues.Other, "след {0} среди" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предходната ср" }, { 0, "тази ср" }, { 1, "следващата ср" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} ср" }, { PluralRulesValues.Other, "преди {0} ср" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} ср" }, { PluralRulesValues.Other, "след {0} ср" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предх. ср" }, { 0, "тази ср" }, { 1, "следв. ср" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} ср" }, { PluralRulesValues.Other, "пр. {0} ср" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} ср" }, { PluralRulesValues.Other, "сл. {0} ср" } })
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
									new Dictionary<int, string> { { -1, "предходният четвъртък" }, { 0, "този четвъртък" }, { 1, "следващият четвъртък" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} четвъртък" }, { PluralRulesValues.Other, "преди {0} четвъртъка" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} четвъртък" }, { PluralRulesValues.Other, "след {0} четвъртъка" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предходният чт" }, { 0, "този чт" }, { 1, "следващият чт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} чт" }, { PluralRulesValues.Other, "преди {0} чт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} чт" }, { PluralRulesValues.Other, "след {0} чт" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предх. чт" }, { 0, "този чт" }, { 1, "следв. чт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} чт" }, { PluralRulesValues.Other, "пр. {0} чт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} четвъртък" }, { PluralRulesValues.Other, "след {0} четвъртъка" } })
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
									new Dictionary<int, string> { { -1, "предходният петък" }, { 0, "този петък" }, { 1, "следващият петък" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} петък" }, { PluralRulesValues.Other, "преди {0} петъка" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} петък" }, { PluralRulesValues.Other, "след {0} петъка" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предходният пт" }, { 0, "този пт" }, { 1, "следващият пт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} пт" }, { PluralRulesValues.Other, "преди {0} пт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} пт" }, { PluralRulesValues.Other, "след {0} пт" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предх. пт" }, { 0, "този пт" }, { 1, "следв. пт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} пт" }, { PluralRulesValues.Other, "пр. {0} пт" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} пт" }, { PluralRulesValues.Other, "сл. {0} пт" } })
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
									new Dictionary<int, string> { { -1, "предходната събота" }, { 0, "тази събота" }, { 1, "следващата събота" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} събота" }, { PluralRulesValues.Other, "преди {0} съботи" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} събота" }, { PluralRulesValues.Other, "след {0} съботи" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предходната сб" }, { 0, "тази сб" }, { 1, "следващата сб" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} сб" }, { PluralRulesValues.Other, "преди {0} сб" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} сб" }, { PluralRulesValues.Other, "след {0} сб" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "предх. сб" }, { 0, "тази сб" }, { 1, "следв. сб" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} сб" }, { PluralRulesValues.Other, "пр. {0} сб" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} сб" }, { PluralRulesValues.Other, "сл. {0} сб" } })
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
									new Dictionary<int, string> { { 0, "в този час" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} час" }, { PluralRulesValues.Other, "преди {0} часа" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} час" }, { PluralRulesValues.Other, "след {0} часа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "в този час" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} ч" }, { PluralRulesValues.Other, "преди {0} ч" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} ч" }, { PluralRulesValues.Other, "след {0} ч" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "в този час" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} ч" }, { PluralRulesValues.Other, "пр. {0} ч" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} ч" }, { PluralRulesValues.Other, "сл. {0} ч" } })
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
									new Dictionary<int, string> { { 0, "в тази минута" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} минута" }, { PluralRulesValues.Other, "преди {0} минути" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} минута" }, { PluralRulesValues.Other, "след {0} минути" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "в тази минута" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} мин" }, { PluralRulesValues.Other, "преди {0} мин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} мин" }, { PluralRulesValues.Other, "след {0} мин" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "в тази минута" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} мин" }, { PluralRulesValues.Other, "пр. {0} мин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} мин" }, { PluralRulesValues.Other, "сл. {0} мин" } })
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
									new Dictionary<int, string> { { 0, "сега" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} секунда" }, { PluralRulesValues.Other, "преди {0} секунди" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} секунда" }, { PluralRulesValues.Other, "след {0} секунди" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "сега" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "преди {0} сек" }, { PluralRulesValues.Other, "преди {0} сек" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "след {0} сек" }, { PluralRulesValues.Other, "след {0} сек" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "сега" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "пр. {0} сек" }, { PluralRulesValues.Other, "пр. {0} сек" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "сл. {0} сек" }, { PluralRulesValues.Other, "сл. {0} сек" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("bg");
		}
	}
}