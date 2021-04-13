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
	/// Relative Time Units resource for 'Kiswahili' [sw]
	/// </summary>
	public class SwRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public SwRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "mwaka uliopita" }, { 0, "mwaka huu" }, { 1, "mwaka ujao" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mwaka {0} uliopita" }, { PluralRulesValues.Other, "miaka {0} iliyopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya mwaka {0}" }, { PluralRulesValues.Other, "baada ya miaka {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mwaka uliopita" }, { 0, "mwaka huu" }, { 1, "mwaka ujao" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mwaka {0} uliopita" }, { PluralRulesValues.Other, "miaka {0} iliyopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya mwaka {0}" }, { PluralRulesValues.Other, "baada ya miaka {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mwaka uliopita" }, { 0, "mwaka huu" }, { 1, "mwaka ujao" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mwaka {0} uliopita" }, { PluralRulesValues.Other, "miaka {0} iliyopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya mwaka {0}" }, { PluralRulesValues.Other, "baada ya miaka {0}" } })
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
									new Dictionary<int, string> { { -1, "robo ya mwaka iliyopita" }, { 0, "robo hii ya mwaka" }, { 1, "robo ya mwaka inayofuata" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "robo {0} iliyopita" }, { PluralRulesValues.Other, "robo {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya robo {0}" }, { PluralRulesValues.Other, "baada ya robo {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "robo ya mwaka iliyopita" }, { 0, "robo hii ya mwaka" }, { 1, "robo ya mwaka inayofuata" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "robo {0} iliyopita" }, { PluralRulesValues.Other, "robo {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya robo {0}" }, { PluralRulesValues.Other, "baada ya robo {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "robo ya mwaka iliyopita" }, { 0, "robo hii ya mwaka" }, { 1, "robo ya mwaka inayofuata" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "robo {0} iliyopita" }, { PluralRulesValues.Other, "robo {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya robo {0}" }, { PluralRulesValues.Other, "baada ya robo {0}" } })
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
									new Dictionary<int, string> { { -1, "mwezi uliopita" }, { 0, "mwezi huu" }, { 1, "mwezi ujao" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mwezi {0} uliopita" }, { PluralRulesValues.Other, "miezi {0} iliyopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya mwezi {0}" }, { PluralRulesValues.Other, "baada ya miezi {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mwezi uliopita" }, { 0, "mwezi huu" }, { 1, "mwezi ujao" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mwezi {0} uliopita" }, { PluralRulesValues.Other, "miezi {0} iliyopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya mwezi {0}" }, { PluralRulesValues.Other, "baada ya miezi {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mwezi uliopita" }, { 0, "mwezi huu" }, { 1, "mwezi ujao" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mwezi {0} uliopita" }, { PluralRulesValues.Other, "miezi {0} iliyopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya mwezi {0}" }, { PluralRulesValues.Other, "baada ya miezi {0}" } })
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
									new Dictionary<int, string> { { -1, "wiki iliyopita" }, { 0, "wiki hii" }, { 1, "wiki ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "wiki {0} iliyopita" }, { PluralRulesValues.Other, "wiki {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya wiki {0}" }, { PluralRulesValues.Other, "baada ya wiki {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "wiki iliyopita" }, { 0, "wiki hii" }, { 1, "wiki ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "wiki {0} iliyopita" }, { PluralRulesValues.Other, "wiki {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya wiki {0}" }, { PluralRulesValues.Other, "baada ya wiki {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "wiki iliyopita" }, { 0, "wiki hii" }, { 1, "wiki ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "wiki {0} iliyopita" }, { PluralRulesValues.Other, "wiki {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya wiki {0}" }, { PluralRulesValues.Other, "baada ya wiki {0}" } })
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
									new Dictionary<int, string> { { -2, "juzi" }, { -1, "jana" }, { 0, "leo" }, { 1, "kesho" }, { 2, "kesho kutwa" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "siku {0} iliyopita" }, { PluralRulesValues.Other, "siku {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya siku {0}" }, { PluralRulesValues.Other, "baada ya siku {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "juzi" }, { -1, "jana" }, { 0, "leo" }, { 1, "kesho" }, { 2, "kesho kutwa" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "siku {0} iliyopita" }, { PluralRulesValues.Other, "siku {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya siku {0}" }, { PluralRulesValues.Other, "baada ya siku {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "juzi" }, { -1, "jana" }, { 0, "leo" }, { 1, "kesho" }, { 2, "kesho kutwa" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "siku {0} iliyopita" }, { PluralRulesValues.Other, "siku {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya siku {0}" }, { PluralRulesValues.Other, "baada ya siku {0}" } })
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
									new Dictionary<int, string> { { -1, "Jumapili iliyopita" }, { 0, "Jumapili hii" }, { 1, "Jumapili ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumapili {0} iliyopita" }, { PluralRulesValues.Other, "Jumapili {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumapili {0}" }, { PluralRulesValues.Other, "baada ya Jumapili {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumapili iliyopita" }, { 0, "Jumapili hii" }, { 1, "Jumapili ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumapili {0} iliyopita" }, { PluralRulesValues.Other, "Jumapili {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumapili {0}" }, { PluralRulesValues.Other, "baada ya Jumapili {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumapili iliyopita" }, { 0, "Jumapili hii" }, { 1, "Jumapili ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumapili {0} iliyopita" }, { PluralRulesValues.Other, "Jumapili {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumapili {0}" }, { PluralRulesValues.Other, "baada ya Jumapili {0}" } })
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
									new Dictionary<int, string> { { -1, "Jumatatu iliyopita" }, { 0, "Jumatatu hii" }, { 1, "Jumatatu ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumatatu {0} iliyopita" }, { PluralRulesValues.Other, "Jumatatu {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumatatu {0}" }, { PluralRulesValues.Other, "baada ya Jumatatu {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumatatu iliyopita" }, { 0, "Jumatatu hii" }, { 1, "Jumatatu ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumatatu {0} iliyopita" }, { PluralRulesValues.Other, "Jumatatu {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumatatu {0}" }, { PluralRulesValues.Other, "baada ya Jumatatu {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumatatu iliyopita" }, { 0, "Jumatatu hii" }, { 1, "Jumatatu ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumatatu {0} iliyopita" }, { PluralRulesValues.Other, "Jumatatu {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumatatu {0}" }, { PluralRulesValues.Other, "baada ya Jumatatu {0}" } })
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
									new Dictionary<int, string> { { -1, "Jumanne iliyopita" }, { 0, "Jumanne hii" }, { 1, "Jumanne ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumanne {0} iliyopita" }, { PluralRulesValues.Other, "Jumanne {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumanne {0}" }, { PluralRulesValues.Other, "baada ya Jumanne {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumanne iliyopita" }, { 0, "Jumanne hii" }, { 1, "Jumanne ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumanne {0} iliyopita" }, { PluralRulesValues.Other, "Jumanne {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumanne {0}" }, { PluralRulesValues.Other, "baada ya Jumanne {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumanne iliyopita" }, { 0, "Jumanne hii" }, { 1, "Jumanne ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumanne {0} iliyopita" }, { PluralRulesValues.Other, "Jumanne {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumanne {0}" }, { PluralRulesValues.Other, "baada ya Jumanne {0}" } })
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
									new Dictionary<int, string> { { -1, "Jumatano iliyopita" }, { 0, "Jumatano hii" }, { 1, "Jumatano ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumatano {0} iliyopita" }, { PluralRulesValues.Other, "Jumatano {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumatano {0}" }, { PluralRulesValues.Other, "baada ya Jumatano {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumatano iliyopita" }, { 0, "Jumatano hii" }, { 1, "Jumatano ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumatano {0} iliyopita" }, { PluralRulesValues.Other, "Jumatano {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumatano {0}" }, { PluralRulesValues.Other, "baada ya Jumatano {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumatano iliyopita" }, { 0, "Jumatano hii" }, { 1, "Jumatano ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumatano {0} iliyopita" }, { PluralRulesValues.Other, "Jumatano {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumatano {0}" }, { PluralRulesValues.Other, "baada ya Jumatano {0}" } })
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
									new Dictionary<int, string> { { -1, "Alhamisi iliyopita" }, { 0, "Alhamisi hii" }, { 1, "Alhamisi ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Alhamisi {0} iliyopita" }, { PluralRulesValues.Other, "Alhamisi {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Alhamisi {0}" }, { PluralRulesValues.Other, "baada ya Alhamisi {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Alhamisi iliyopita" }, { 0, "Alhamisi hii" }, { 1, "Alhamisi ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Alhamisi {0} iliyopita" }, { PluralRulesValues.Other, "Alhamisi {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Alhamisi {0}" }, { PluralRulesValues.Other, "baada ya Alhamisi {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Alhamisi iliyopita" }, { 0, "Alhamisi hii" }, { 1, "Alhamisi ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Alhamisi {0} iliyopita" }, { PluralRulesValues.Other, "Alhamisi {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Alhamisi {0}" }, { PluralRulesValues.Other, "baada ya Alhamisi {0}" } })
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
									new Dictionary<int, string> { { -1, "Ijumaa iliyopita" }, { 0, "Ijumaa hii" }, { 1, "Ijumaa ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Ijumaa {0} iliyopita" }, { PluralRulesValues.Other, "Ijumaa {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Ijumaa {0}" }, { PluralRulesValues.Other, "baada ya Ijumaa {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Ijumaa iliyopita" }, { 0, "Ijumaa hii" }, { 1, "Ijumaa ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Ijumaa {0} iliyopita" }, { PluralRulesValues.Other, "Ijumaa {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Ijumaa {0}" }, { PluralRulesValues.Other, "baada ya Ijumaa {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Ijumaa iliyopita" }, { 0, "Ijumaa hii" }, { 1, "Ijumaa ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Ijumaa {0} iliyopita" }, { PluralRulesValues.Other, "Ijumaa {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Ijumaa {0}" }, { PluralRulesValues.Other, "baada ya Ijumaa {0}" } })
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
									new Dictionary<int, string> { { -1, "Jumamosi iliyopita" }, { 0, "Jumamosi hii" }, { 1, "Jumamosi ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumamosi {0} iliyopita" }, { PluralRulesValues.Other, "Jumamosi {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumamosi {0}" }, { PluralRulesValues.Other, "baada ya Jumamosi {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumamosi iliyopita" }, { 0, "Jumamosi hii" }, { 1, "Jumamosi ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumamosi {0} iliyopita" }, { PluralRulesValues.Other, "Jumamosi {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumamosi {0}" }, { PluralRulesValues.Other, "baada ya Jumamosi {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jumamosi iliyopita" }, { 0, "Jumamosi hii" }, { 1, "Jumamosi ijayo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Jumamosi {0} iliyopita" }, { PluralRulesValues.Other, "Jumamosi {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya Jumamosi {0}" }, { PluralRulesValues.Other, "baada ya Jumamosi {0}" } })
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
									new Dictionary<int, string> { { 0, "saa hii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "saa {0} iliyopita" }, { PluralRulesValues.Other, "saa {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya saa {0}" }, { PluralRulesValues.Other, "baada ya saa {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "saa hii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "saa {0} iliyopita" }, { PluralRulesValues.Other, "saa {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya saa {0}" }, { PluralRulesValues.Other, "baada ya saa {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "saa hii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Saa {0} iliyopita" }, { PluralRulesValues.Other, "Saa {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya saa {0}" }, { PluralRulesValues.Other, "baada ya saa {0}" } })
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
									new Dictionary<int, string> { { 0, "dakika hii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dakika {0} iliyopita" }, { PluralRulesValues.Other, "dakika {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya dakika {0}" }, { PluralRulesValues.Other, "baada ya dakika {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "dakika hii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dakika {0} iliyopita" }, { PluralRulesValues.Other, "dakika {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya dakika {0}" }, { PluralRulesValues.Other, "baada ya dakika {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "dakika hii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dakika {0} iliyopita" }, { PluralRulesValues.Other, "dakika {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya dakika {0}" }, { PluralRulesValues.Other, "baada ya dakika {0}" } })
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
									new Dictionary<int, string> { { 0, "sasa hivi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Sekunde {0} iliyopita" }, { PluralRulesValues.Other, "Sekunde {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya sekunde {0}" }, { PluralRulesValues.Other, "baada ya sekunde {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "sasa hivi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "sekunde {0} iliyopita" }, { PluralRulesValues.Other, "sekunde {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya sekunde {0}" }, { PluralRulesValues.Other, "baada ya sekunde {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "sasa hivi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "sekunde {0} iliyopita" }, { PluralRulesValues.Other, "sekunde {0} zilizopita" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "baada ya sekunde {0}" }, { PluralRulesValues.Other, "baada ya sekunde {0}" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("sw");
		}
	}
}