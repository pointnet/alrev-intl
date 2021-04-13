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
	/// Relative Time Units resource for 'Russian (Kyrgyzstan)' [ru-kg]
	/// </summary>
	public class RuKgRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public RuKgRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "в прошлом году" }, { 0, "в этом году" }, { 1, "в следующем году" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} год назад" }, { PluralRulesValues.Few, "{0} года назад" }, { PluralRulesValues.Many, "{0} лет назад" }, { PluralRulesValues.Other, "{0} года назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} год" }, { PluralRulesValues.Few, "через {0} года" }, { PluralRulesValues.Many, "через {0} лет" }, { PluralRulesValues.Other, "через {0} года" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прошлом г." }, { 0, "в этом г." }, { 1, "в след. г." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} г. назад" }, { PluralRulesValues.Few, "{0} г. назад" }, { PluralRulesValues.Many, "{0} л. назад" }, { PluralRulesValues.Other, "{0} г. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} г." }, { PluralRulesValues.Few, "через {0} г." }, { PluralRulesValues.Many, "через {0} л." }, { PluralRulesValues.Other, "через {0} г." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в пр. г." }, { 0, "в эт. г." }, { 1, "в сл. г." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} г." }, { PluralRulesValues.Few, "-{0} г." }, { PluralRulesValues.Many, "-{0} л." }, { PluralRulesValues.Other, "-{0} г." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} г." }, { PluralRulesValues.Few, "+{0} г." }, { PluralRulesValues.Many, "+{0} л." }, { PluralRulesValues.Other, "+{0} г." } })
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
									new Dictionary<int, string> { { -1, "в прошлом квартале" }, { 0, "в текущем квартале" }, { 1, "в следующем квартале" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} квартал назад" }, { PluralRulesValues.Few, "{0} квартала назад" }, { PluralRulesValues.Many, "{0} кварталов назад" }, { PluralRulesValues.Other, "{0} квартала назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} квартал" }, { PluralRulesValues.Few, "через {0} квартала" }, { PluralRulesValues.Many, "через {0} кварталов" }, { PluralRulesValues.Other, "через {0} квартала" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "последний кв." }, { 0, "текущий кв." }, { 1, "следующий кв." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} кв. назад" }, { PluralRulesValues.Few, "{0} кв. назад" }, { PluralRulesValues.Many, "{0} кв. назад" }, { PluralRulesValues.Other, "{0} кв. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} кв." }, { PluralRulesValues.Few, "через {0} кв." }, { PluralRulesValues.Many, "через {0} кв." }, { PluralRulesValues.Other, "через {0} кв." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "посл. кв." }, { 0, "тек. кв." }, { 1, "след. кв." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} кв." }, { PluralRulesValues.Few, "-{0} кв." }, { PluralRulesValues.Many, "-{0} кв." }, { PluralRulesValues.Other, "-{0} кв." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} кв." }, { PluralRulesValues.Few, "+{0} кв." }, { PluralRulesValues.Many, "+{0} кв." }, { PluralRulesValues.Other, "+{0} кв." } })
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
									new Dictionary<int, string> { { -1, "в прошлом месяце" }, { 0, "в этом месяце" }, { 1, "в следующем месяце" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} месяц назад" }, { PluralRulesValues.Few, "{0} месяца назад" }, { PluralRulesValues.Many, "{0} месяцев назад" }, { PluralRulesValues.Other, "{0} месяца назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} месяц" }, { PluralRulesValues.Few, "через {0} месяца" }, { PluralRulesValues.Many, "через {0} месяцев" }, { PluralRulesValues.Other, "через {0} месяца" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прошлом мес." }, { 0, "в этом мес." }, { 1, "в следующем мес." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мес. назад" }, { PluralRulesValues.Few, "{0} мес. назад" }, { PluralRulesValues.Many, "{0} мес. назад" }, { PluralRulesValues.Other, "{0} мес. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} мес." }, { PluralRulesValues.Few, "через {0} мес." }, { PluralRulesValues.Many, "через {0} мес." }, { PluralRulesValues.Other, "через {0} мес." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в пр. мес." }, { 0, "в эт. мес." }, { 1, "в след. мес." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} мес." }, { PluralRulesValues.Few, "-{0} мес." }, { PluralRulesValues.Many, "-{0} мес." }, { PluralRulesValues.Other, "-{0} мес." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} мес." }, { PluralRulesValues.Few, "+{0} мес." }, { PluralRulesValues.Many, "+{0} мес." }, { PluralRulesValues.Other, "+{0} мес." } })
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
									new Dictionary<int, string> { { -1, "на прошлой неделе" }, { 0, "на этой неделе" }, { 1, "на следующей неделе" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} неделю назад" }, { PluralRulesValues.Few, "{0} недели назад" }, { PluralRulesValues.Many, "{0} недель назад" }, { PluralRulesValues.Other, "{0} недели назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} неделю" }, { PluralRulesValues.Few, "через {0} недели" }, { PluralRulesValues.Many, "через {0} недель" }, { PluralRulesValues.Other, "через {0} недели" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "на прошлой нед." }, { 0, "на этой нед." }, { 1, "на следующей нед." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} нед. назад" }, { PluralRulesValues.Few, "{0} нед. назад" }, { PluralRulesValues.Many, "{0} нед. назад" }, { PluralRulesValues.Other, "{0} нед. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} нед." }, { PluralRulesValues.Few, "через {0} нед." }, { PluralRulesValues.Many, "через {0} нед." }, { PluralRulesValues.Other, "через {0} нед." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "на пр. нед." }, { 0, "на эт. нед." }, { 1, "на след. нед." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} нед." }, { PluralRulesValues.Few, "-{0} нед." }, { PluralRulesValues.Many, "-{0} нед." }, { PluralRulesValues.Other, "-{0} нед." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} нед." }, { PluralRulesValues.Few, "+{0} нед." }, { PluralRulesValues.Many, "+{0} нед." }, { PluralRulesValues.Other, "+{0} нед." } })
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
									new Dictionary<int, string> { { -2, "позавчера" }, { -1, "вчера" }, { 0, "сегодня" }, { 1, "завтра" }, { 2, "послезавтра" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} день назад" }, { PluralRulesValues.Few, "{0} дня назад" }, { PluralRulesValues.Many, "{0} дней назад" }, { PluralRulesValues.Other, "{0} дня назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} день" }, { PluralRulesValues.Few, "через {0} дня" }, { PluralRulesValues.Many, "через {0} дней" }, { PluralRulesValues.Other, "через {0} дня" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "позавчера" }, { -1, "вчера" }, { 0, "сегодня" }, { 1, "завтра" }, { 2, "послезавтра" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} дн. назад" }, { PluralRulesValues.Few, "{0} дн. назад" }, { PluralRulesValues.Many, "{0} дн. назад" }, { PluralRulesValues.Other, "{0} дн. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} дн." }, { PluralRulesValues.Few, "через {0} дн." }, { PluralRulesValues.Many, "через {0} дн." }, { PluralRulesValues.Other, "через {0} дн." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "позавчера" }, { -1, "вчера" }, { 0, "сегодня" }, { 1, "завтра" }, { 2, "послезавтра" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} дн." }, { PluralRulesValues.Few, "-{0} дн." }, { PluralRulesValues.Many, "-{0} дн." }, { PluralRulesValues.Other, "-{0} дн." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} дн." }, { PluralRulesValues.Few, "+{0} дн." }, { PluralRulesValues.Many, "+{0} дн." }, { PluralRulesValues.Other, "+{0} дн." } })
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
									new Dictionary<int, string> { { -1, "в прошлое воскресенье" }, { 0, "в это воскресенье" }, { 1, "в следующее воскресенье" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} воскресенье назад" }, { PluralRulesValues.Few, "{0} воскресенья назад" }, { PluralRulesValues.Many, "{0} воскресений назад" }, { PluralRulesValues.Other, "{0} воскресенья назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} воскресенье" }, { PluralRulesValues.Few, "через {0} воскресенья" }, { PluralRulesValues.Many, "через {0} воскресений" }, { PluralRulesValues.Other, "через {0} воскресенья" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. вс." }, { 0, "в это вс." }, { 1, "в след. вс." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} вс. назад" }, { PluralRulesValues.Few, "{0} вс. назад" }, { PluralRulesValues.Many, "{0} вс. назад" }, { PluralRulesValues.Other, "{0} вс. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} вс." }, { PluralRulesValues.Few, "через {0} вс." }, { PluralRulesValues.Many, "через {0} вс." }, { PluralRulesValues.Other, "через {0} вс." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. вс." }, { 0, "в это вс." }, { 1, "в след. вс." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} вс." }, { PluralRulesValues.Few, "-{0} вс." }, { PluralRulesValues.Many, "-{0} вс." }, { PluralRulesValues.Other, "-{0} вс." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} вс." }, { PluralRulesValues.Few, "+{0} вс." }, { PluralRulesValues.Many, "+{0} вс." }, { PluralRulesValues.Other, "+{0} вс." } })
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
									new Dictionary<int, string> { { -1, "в прошлый понедельник" }, { 0, "в этот понедельник" }, { 1, "в следующий понедельник" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} понедельник назад" }, { PluralRulesValues.Few, "{0} понедельника назад" }, { PluralRulesValues.Many, "{0} понедельников назад" }, { PluralRulesValues.Other, "{0} понедельника назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} понедельник" }, { PluralRulesValues.Few, "через {0} понедельника" }, { PluralRulesValues.Many, "через {0} понедельников" }, { PluralRulesValues.Other, "через {0} понедельника" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. пн." }, { 0, "в этот пн." }, { 1, "в след. пн." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пн. назад" }, { PluralRulesValues.Few, "{0} пн. назад" }, { PluralRulesValues.Many, "{0} пн. назад" }, { PluralRulesValues.Other, "{0} пн. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} пн." }, { PluralRulesValues.Few, "через {0} пн." }, { PluralRulesValues.Many, "через {0} пн." }, { PluralRulesValues.Other, "через {0} пн." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. пн." }, { 0, "в этот пн." }, { 1, "в след. пн." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} пн." }, { PluralRulesValues.Few, "-{0} пн." }, { PluralRulesValues.Many, "-{0} пн." }, { PluralRulesValues.Other, "-{0} пн." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} пн." }, { PluralRulesValues.Few, "+{0} пн." }, { PluralRulesValues.Many, "+{0} пн." }, { PluralRulesValues.Other, "+{0} пн." } })
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
									new Dictionary<int, string> { { -1, "в прошлый вторник" }, { 0, "в этот вторник" }, { 1, "в следующий вторник" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} вторник назад" }, { PluralRulesValues.Few, "{0} вторника назад" }, { PluralRulesValues.Many, "{0} вторников назад" }, { PluralRulesValues.Other, "{0} вторника назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} вторник" }, { PluralRulesValues.Few, "через {0} вторника" }, { PluralRulesValues.Many, "через {0} вторников" }, { PluralRulesValues.Other, "через {0} вторника" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. вт." }, { 0, "в этот вт." }, { 1, "в след. вт." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} вт. назад" }, { PluralRulesValues.Few, "{0} вт. назад" }, { PluralRulesValues.Many, "{0} вт. назад" }, { PluralRulesValues.Other, "{0} вт. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} вт." }, { PluralRulesValues.Few, "через {0} вт." }, { PluralRulesValues.Many, "через {0} вт." }, { PluralRulesValues.Other, "через {0} вт." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. вт." }, { 0, "в этот вт." }, { 1, "в след. вт." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} вт." }, { PluralRulesValues.Few, "-{0} вт." }, { PluralRulesValues.Many, "-{0} вт." }, { PluralRulesValues.Other, "-{0} вт." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} вт." }, { PluralRulesValues.Few, "+{0} вт." }, { PluralRulesValues.Many, "+{0} вт." }, { PluralRulesValues.Other, "+{0} вт." } })
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
									new Dictionary<int, string> { { -1, "в прошлую среду" }, { 0, "в эту среду" }, { 1, "в следующую среду" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} среду назад" }, { PluralRulesValues.Few, "{0} среды назад" }, { PluralRulesValues.Many, "{0} сред назад" }, { PluralRulesValues.Other, "{0} среды назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} среду" }, { PluralRulesValues.Few, "через {0} среды" }, { PluralRulesValues.Many, "через {0} сред" }, { PluralRulesValues.Other, "через {0} среды" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. ср." }, { 0, "в эту ср." }, { 1, "в след. ср." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ср. назад" }, { PluralRulesValues.Few, "{0} ср. назад" }, { PluralRulesValues.Many, "{0} ср. назад" }, { PluralRulesValues.Other, "{0} ср. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} ср." }, { PluralRulesValues.Few, "через {0} ср." }, { PluralRulesValues.Many, "через {0} ср." }, { PluralRulesValues.Other, "через {0} ср." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. ср." }, { 0, "в эту ср." }, { 1, "в след. ср." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} ср." }, { PluralRulesValues.Few, "-{0} ср." }, { PluralRulesValues.Many, "-{0} ср." }, { PluralRulesValues.Other, "-{0} ср." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} ср." }, { PluralRulesValues.Few, "+{0} ср." }, { PluralRulesValues.Many, "+{0} ср." }, { PluralRulesValues.Other, "+{0} ср." } })
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
									new Dictionary<int, string> { { -1, "в прошлый четверг" }, { 0, "в этот четверг" }, { 1, "в следующий четверг" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} четверг назад" }, { PluralRulesValues.Few, "{0} четверга назад" }, { PluralRulesValues.Many, "{0} четвергов назад" }, { PluralRulesValues.Other, "{0} четверга назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} четверг" }, { PluralRulesValues.Few, "через {0} четверга" }, { PluralRulesValues.Many, "через {0} четвергов" }, { PluralRulesValues.Other, "через {0} четверга" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. чт." }, { 0, "в этот чт." }, { 1, "в след. чт." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} чт. назад" }, { PluralRulesValues.Few, "{0} чт. назад" }, { PluralRulesValues.Many, "{0} чт. назад" }, { PluralRulesValues.Other, "{0} чт. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} чт." }, { PluralRulesValues.Few, "через {0} чт." }, { PluralRulesValues.Many, "через {0} чт." }, { PluralRulesValues.Other, "через {0} чт." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. чт." }, { 0, "в этот чт." }, { 1, "в след. чт." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} чт." }, { PluralRulesValues.Few, "-{0} чт." }, { PluralRulesValues.Many, "-{0} чт." }, { PluralRulesValues.Other, "-{0} чт." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} чт." }, { PluralRulesValues.Few, "+{0} чт." }, { PluralRulesValues.Many, "+{0} чт." }, { PluralRulesValues.Other, "+{0} чт." } })
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
									new Dictionary<int, string> { { -1, "в прошлую пятницу" }, { 0, "в эту пятницу" }, { 1, "в следующую пятницу" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пятницу назад" }, { PluralRulesValues.Few, "{0} пятницы назад" }, { PluralRulesValues.Many, "{0} пятниц назад" }, { PluralRulesValues.Other, "{0} пятницы назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} пятницу" }, { PluralRulesValues.Few, "через {0} пятницы" }, { PluralRulesValues.Many, "через {0} пятниц" }, { PluralRulesValues.Other, "через {0} пятницы" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. пт." }, { 0, "в эту пт." }, { 1, "в след. пт." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} пт. назад" }, { PluralRulesValues.Few, "{0} пт. назад" }, { PluralRulesValues.Many, "{0} пт. назад" }, { PluralRulesValues.Other, "{0} пт. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} пт." }, { PluralRulesValues.Few, "через {0} пт." }, { PluralRulesValues.Many, "через {0} пт." }, { PluralRulesValues.Other, "через {0} пт." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. пт." }, { 0, "в эту пт." }, { 1, "в след. пт." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} пт." }, { PluralRulesValues.Few, "-{0} пт." }, { PluralRulesValues.Many, "-{0} пт." }, { PluralRulesValues.Other, "-{0} пт." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} пт." }, { PluralRulesValues.Few, "+{0} пт." }, { PluralRulesValues.Many, "+{0} пт." }, { PluralRulesValues.Other, "+{0} пт." } })
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
									new Dictionary<int, string> { { -1, "в прошлую субботу" }, { 0, "в эту субботу" }, { 1, "в следующую субботу" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} субботу назад" }, { PluralRulesValues.Few, "{0} субботы назад" }, { PluralRulesValues.Many, "{0} суббот назад" }, { PluralRulesValues.Other, "{0} субботы назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} субботу" }, { PluralRulesValues.Few, "через {0} субботы" }, { PluralRulesValues.Many, "через {0} суббот" }, { PluralRulesValues.Other, "через {0} субботы" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. сб." }, { 0, "в эту сб." }, { 1, "в след. сб." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сб. назад" }, { PluralRulesValues.Few, "{0} сб. назад" }, { PluralRulesValues.Many, "{0} сб. назад" }, { PluralRulesValues.Other, "{0} сб. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} сб." }, { PluralRulesValues.Few, "через {0} сб." }, { PluralRulesValues.Many, "через {0} сб." }, { PluralRulesValues.Other, "через {0} сб." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "в прош. сб." }, { 0, "в эту сб." }, { 1, "в след. сб." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} сб." }, { PluralRulesValues.Few, "-{0} сб." }, { PluralRulesValues.Many, "-{0} сб." }, { PluralRulesValues.Other, "-{0} сб." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} сб." }, { PluralRulesValues.Few, "+{0} сб." }, { PluralRulesValues.Many, "+{0} сб." }, { PluralRulesValues.Other, "+{0} сб." } })
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
									new Dictionary<int, string> { { 0, "в этот час" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} час назад" }, { PluralRulesValues.Few, "{0} часа назад" }, { PluralRulesValues.Many, "{0} часов назад" }, { PluralRulesValues.Other, "{0} часа назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} час" }, { PluralRulesValues.Few, "через {0} часа" }, { PluralRulesValues.Many, "через {0} часов" }, { PluralRulesValues.Other, "через {0} часа" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "в этот час" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ч назад" }, { PluralRulesValues.Few, "{0} ч назад" }, { PluralRulesValues.Many, "{0} ч назад" }, { PluralRulesValues.Other, "{0} ч назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} ч" }, { PluralRulesValues.Few, "через {0} ч" }, { PluralRulesValues.Many, "через {0} ч" }, { PluralRulesValues.Other, "через {0} ч" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "в этот час" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} ч" }, { PluralRulesValues.Few, "-{0} ч" }, { PluralRulesValues.Many, "-{0} ч" }, { PluralRulesValues.Other, "-{0} ч" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} ч" }, { PluralRulesValues.Few, "+{0} ч" }, { PluralRulesValues.Many, "+{0} ч" }, { PluralRulesValues.Other, "+{0} ч" } })
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
									new Dictionary<int, string> { { 0, "в эту минуту" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} минуту назад" }, { PluralRulesValues.Few, "{0} минуты назад" }, { PluralRulesValues.Many, "{0} минут назад" }, { PluralRulesValues.Other, "{0} минуты назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} минуту" }, { PluralRulesValues.Few, "через {0} минуты" }, { PluralRulesValues.Many, "через {0} минут" }, { PluralRulesValues.Other, "через {0} минуты" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "в эту минуту" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} мин. назад" }, { PluralRulesValues.Few, "{0} мин. назад" }, { PluralRulesValues.Many, "{0} мин. назад" }, { PluralRulesValues.Other, "{0} мин. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} мин." }, { PluralRulesValues.Few, "через {0} мин." }, { PluralRulesValues.Many, "через {0} мин." }, { PluralRulesValues.Other, "через {0} мин." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "в эту минуту" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} мин" }, { PluralRulesValues.Few, "-{0} мин" }, { PluralRulesValues.Many, "-{0} мин" }, { PluralRulesValues.Other, "-{0} мин" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} мин" }, { PluralRulesValues.Few, "+{0} мин" }, { PluralRulesValues.Many, "+{0} мин" }, { PluralRulesValues.Other, "+{0} мин" } })
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
									new Dictionary<int, string> { { 0, "сейчас" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} секунду назад" }, { PluralRulesValues.Few, "{0} секунды назад" }, { PluralRulesValues.Many, "{0} секунд назад" }, { PluralRulesValues.Other, "{0} секунды назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} секунду" }, { PluralRulesValues.Few, "через {0} секунды" }, { PluralRulesValues.Many, "через {0} секунд" }, { PluralRulesValues.Other, "через {0} секунды" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "сейчас" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} сек. назад" }, { PluralRulesValues.Few, "{0} сек. назад" }, { PluralRulesValues.Many, "{0} сек. назад" }, { PluralRulesValues.Other, "{0} сек. назад" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "через {0} сек." }, { PluralRulesValues.Few, "через {0} сек." }, { PluralRulesValues.Many, "через {0} сек." }, { PluralRulesValues.Other, "через {0} сек." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "сейчас" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} с" }, { PluralRulesValues.Few, "-{0} с" }, { PluralRulesValues.Many, "-{0} с" }, { PluralRulesValues.Other, "-{0} с" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} с" }, { PluralRulesValues.Few, "+{0} с" }, { PluralRulesValues.Many, "+{0} с" }, { PluralRulesValues.Other, "+{0} с" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("ru-kg");
		}
	}
}