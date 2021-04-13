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
	/// Relative Time Units resource for 'Chinese (Simplified, Macao SAR)' [zh-hans-mo]
	/// </summary>
	public class ZhHansMoRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public ZhHansMoRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "去年" }, { 0, "今年" }, { 1, "明年" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "去年" }, { 0, "今年" }, { 1, "明年" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "去年" }, { 0, "今年" }, { 1, "明年" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}年后" } })
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
									new Dictionary<int, string> { { -1, "上季度" }, { 0, "本季度" }, { 1, "下季度" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上季度" }, { 0, "本季度" }, { 1, "下季度" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上季度" }, { 0, "本季度" }, { 1, "下季度" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个季度后" } })
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
									new Dictionary<int, string> { { -1, "上个月" }, { 0, "本月" }, { 1, "下个月" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上个月" }, { 0, "本月" }, { 1, "下个月" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上个月" }, { 0, "本月" }, { 1, "下个月" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个月后" } })
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
									new Dictionary<int, string> { { -1, "上周" }, { 0, "本周" }, { 1, "下周" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周" }, { 0, "本周" }, { 1, "下周" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周" }, { 0, "本周" }, { 1, "下周" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}周后" } })
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
									new Dictionary<int, string> { { -2, "前天" }, { -1, "昨天" }, { 0, "今天" }, { 1, "明天" }, { 2, "后天" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "前天" }, { -1, "昨天" }, { 0, "今天" }, { 1, "明天" }, { 2, "后天" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "前天" }, { -1, "昨天" }, { 0, "今天" }, { 1, "明天" }, { 2, "后天" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}天后" } })
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
									new Dictionary<int, string> { { -1, "上周日" }, { 0, "本周日" }, { 1, "下周日" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周日" }, { 0, "本周日" }, { 1, "下周日" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周日" }, { 0, "本周日" }, { 1, "下周日" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周日后" } })
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
									new Dictionary<int, string> { { -1, "上周一" }, { 0, "本周一" }, { 1, "下周一" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周一" }, { 0, "本周一" }, { 1, "下周一" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周一" }, { 0, "本周一" }, { 1, "下周一" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周一后" } })
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
									new Dictionary<int, string> { { -1, "上周二" }, { 0, "本周二" }, { 1, "下周二" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周二" }, { 0, "本周二" }, { 1, "下周二" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周二" }, { 0, "本周二" }, { 1, "下周二" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周二后" } })
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
									new Dictionary<int, string> { { -1, "上周三" }, { 0, "本周三" }, { 1, "下周三" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周三" }, { 0, "本周三" }, { 1, "下周三" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周三" }, { 0, "本周三" }, { 1, "下周三" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周三后" } })
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
									new Dictionary<int, string> { { -1, "上周四" }, { 0, "本周四" }, { 1, "下周四" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周四" }, { 0, "本周四" }, { 1, "下周四" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周四" }, { 0, "本周四" }, { 1, "下周四" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周四后" } })
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
									new Dictionary<int, string> { { -1, "上周五" }, { 0, "本周五" }, { 1, "下周五" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周五" }, { 0, "本周五" }, { 1, "下周五" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周五" }, { 0, "本周五" }, { 1, "下周五" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周五后" } })
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
									new Dictionary<int, string> { { -1, "上周六" }, { 0, "本周六" }, { 1, "下周六" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周六" }, { 0, "本周六" }, { 1, "下周六" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "上周六" }, { 0, "本周六" }, { 1, "下周六" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}个周六后" } })
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
									new Dictionary<int, string> { { 0, "这一时间 / 此时" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "这一时间 / 此时" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "这一时间 / 此时" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}小时后" } })
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
									new Dictionary<int, string> { { 0, "此刻" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "此刻" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "此刻" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}分钟后" } })
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
									new Dictionary<int, string> { { 0, "现在" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒后" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "现在" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒后" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "现在" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒前" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0}秒后" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("zh-hans-mo");
		}
	}
}