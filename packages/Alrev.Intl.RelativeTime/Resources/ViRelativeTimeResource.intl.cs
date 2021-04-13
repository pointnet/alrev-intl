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
	/// Relative Time Units resource for 'Vietnamese' [vi]
	/// </summary>
	public class ViRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public ViRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "năm ngoái" }, { 0, "năm nay" }, { 1, "năm sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} năm trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} năm nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "năm ngoái" }, { 0, "năm nay" }, { 1, "năm sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} năm trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} năm nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "năm ngoái" }, { 0, "năm nay" }, { 1, "năm sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} năm trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} năm nữa" } })
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
									new Dictionary<int, string> { { -1, "quý trước" }, { 0, "quý này" }, { 1, "quý sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} quý trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} quý nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "quý trước" }, { 0, "quý này" }, { 1, "quý sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} quý trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} quý nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "quý trước" }, { 0, "quý này" }, { 1, "quý sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} quý trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} quý nữa" } })
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
									new Dictionary<int, string> { { -1, "tháng trước" }, { 0, "tháng này" }, { 1, "tháng sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tháng trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tháng nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "tháng trước" }, { 0, "tháng này" }, { 1, "tháng sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tháng trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tháng nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "tháng trước" }, { 0, "tháng này" }, { 1, "tháng sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tháng trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tháng nữa" } })
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
									new Dictionary<int, string> { { -1, "tuần trước" }, { 0, "tuần này" }, { 1, "tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tuần trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tuần nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "tuần trước" }, { 0, "tuần này" }, { 1, "tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tuần trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tuần nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "tuần trước" }, { 0, "tuần này" }, { 1, "tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tuần trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} tuần nữa" } })
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
									new Dictionary<int, string> { { -2, "Hôm kia" }, { -1, "Hôm qua" }, { 0, "Hôm nay" }, { 1, "Ngày mai" }, { 2, "Ngày kia" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ngày trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} ngày nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "Hôm kia" }, { -1, "hôm qua" }, { 0, "hôm nay" }, { 1, "ngày mai" }, { 2, "Ngày kia" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ngày trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} ngày nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "Hôm kia" }, { -1, "hôm qua" }, { 0, "hôm nay" }, { 1, "ngày mai" }, { 2, "Ngày kia" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ngày trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} ngày nữa" } })
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
									new Dictionary<int, string> { { -1, "Chủ Nhật tuần trước" }, { 0, "Chủ Nhật tuần này" }, { 1, "Chủ Nhật tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Chủ Nhật trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Chủ Nhật nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Chủ Nhật tuần trước" }, { 0, "Chủ Nhật tuần này" }, { 1, "Chủ Nhật tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Chủ Nhật trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Chủ Nhật nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Chủ Nhật tuần trước" }, { 0, "Chủ Nhật tuần này" }, { 1, "Chủ Nhật tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Chủ Nhật trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Chủ Nhật nữa" } })
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
									new Dictionary<int, string> { { -1, "Thứ Hai tuần trước" }, { 0, "Thứ Hai tuần này" }, { 1, "Thứ Hai tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Hai trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Hai nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Hai tuần trước" }, { 0, "Thứ Hai tuần này" }, { 1, "Thứ Hai tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Hai trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Hai nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Hai tuần trước" }, { 0, "Thứ Hai tuần này" }, { 1, "Thứ Hai tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Hai trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Hai nữa" } })
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
									new Dictionary<int, string> { { -1, "Thứ Ba tuần trước" }, { 0, "Thứ Ba tuần này" }, { 1, "Thứ Ba tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Ba trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Ba nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Ba tuần trước" }, { 0, "Thứ Ba tuần này" }, { 1, "Thứ Ba tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Ba trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Ba nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Ba tuần trước" }, { 0, "Thứ Ba tuần này" }, { 1, "Thứ Ba tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Ba trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Ba nữa" } })
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
									new Dictionary<int, string> { { -1, "Thứ Tư tuần trước" }, { 0, "Thứ Tư tuần này" }, { 1, "Thứ Tư tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Tư trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Tư nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Tư tuần trước" }, { 0, "Thứ Tư tuần này" }, { 1, "Thứ Tư tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Tư trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Tư nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Tư tuần trước" }, { 0, "Thứ Tư tuần này" }, { 1, "Thứ Tư tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Tư trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Tư nữa" } })
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
									new Dictionary<int, string> { { -1, "Thứ Năm tuần trước" }, { 0, "Thứ Năm tuần này" }, { 1, "Thứ Năm tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Năm trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Năm nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Năm tuần trước" }, { 0, "Thứ Năm tuần này" }, { 1, "Thứ Năm tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Năm trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Năm nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Năm tuần trước" }, { 0, "Thứ Năm tuần này" }, { 1, "Thứ Năm tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Năm trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Năm nữa" } })
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
									new Dictionary<int, string> { { -1, "Thứ Sáu tuần trước" }, { 0, "Thứ Sáu tuần này" }, { 1, "Thứ Sáu tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Sáu trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Sáu nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Sáu tuần trước" }, { 0, "Thứ Sáu tuần này" }, { 1, "Thứ Sáu tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Sáu trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Sáu nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Sáu tuần trước" }, { 0, "Thứ Sáu tuần này" }, { 1, "Thứ Sáu tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Sáu trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Sáu nữa" } })
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
									new Dictionary<int, string> { { -1, "Thứ Bảy tuần trước" }, { 0, "Thứ Bảy tuần này" }, { 1, "Thứ Bảy tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Bảy trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Bảy nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Bảy tuần trước" }, { 0, "Thứ Bảy tuần này" }, { 1, "Thứ Bảy tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Bảy trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Bảy nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Thứ Bảy tuần trước" }, { 0, "Thứ Bảy tuần này" }, { 1, "Thứ Bảy tuần sau" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Thứ Bảy trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} Thứ Bảy nữa" } })
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
									new Dictionary<int, string> { { 0, "giờ này" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giờ trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giờ nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "giờ này" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giờ trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giờ nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "giờ này" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giờ trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giờ nữa" } })
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
									new Dictionary<int, string> { { 0, "phút này" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} phút trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} phút nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "phút này" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} phút trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} phút nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "phút này" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} phút trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} phút nữa" } })
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
									new Dictionary<int, string> { { 0, "bây giờ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giây trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giây nữa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "bây giờ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giây trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giây nữa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "bây giờ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} giây trước" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sau {0} giây nữa" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("vi");
		}
	}
}