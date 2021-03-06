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
	/// Relative Time Units resource for 'Indonesian' [id]
	/// </summary>
	public class IdRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public IdRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "tahun lalu" }, { 0, "tahun ini" }, { 1, "tahun depan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tahun yang lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} tahun" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "thn lalu" }, { 0, "thn ini" }, { 1, "thn depan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} thn lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} thn" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "thn lalu" }, { 0, "thn ini" }, { 1, "thn depan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} thn lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} thn" } })
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
									new Dictionary<int, string> { { -1, "Kuartal lalu" }, { 0, "kuartal ini" }, { 1, "kuartal berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} kuartal yang lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} kuartal" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Kuartal lalu" }, { 0, "kuartal ini" }, { 1, "kuartal berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} krtl. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} krtl." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Kuartal lalu" }, { 0, "kuartal ini" }, { 1, "kuartal berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} krtl. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} krtl." } })
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
									new Dictionary<int, string> { { -1, "bulan lalu" }, { 0, "bulan ini" }, { 1, "bulan berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} bulan yang lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} bulan" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "bln lalu" }, { 0, "bln ini" }, { 1, "bln berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} bln lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} bln" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "bln lalu" }, { 0, "bln ini" }, { 1, "bln berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} bln lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} bln" } })
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
									new Dictionary<int, string> { { -1, "minggu lalu" }, { 0, "minggu ini" }, { 1, "minggu depan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} minggu yang lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} minggu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mgg lalu" }, { 0, "mgg ini" }, { 1, "mgg depan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mgg lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mgg" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mgg lalu" }, { 0, "mgg ini" }, { 1, "mgg depan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mgg lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mgg" } })
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
									new Dictionary<int, string> { { -2, "kemarin dulu" }, { -1, "kemarin" }, { 0, "hari ini" }, { 1, "besok" }, { 2, "lusa" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} hari yang lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} hari" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "kemarin dulu" }, { -1, "kemarin" }, { 0, "hari ini" }, { 1, "besok" }, { 2, "lusa" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} h lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} h" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "kemarin dulu" }, { -1, "kemarin" }, { 0, "hari ini" }, { 1, "besok" }, { 2, "lusa" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} h lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} h" } })
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
									new Dictionary<int, string> { { -1, "hari Minggu lalu" }, { 0, "hari Minggu ini" }, { 1, "hari Minggu berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} hari Minggu yang lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} hari Minggu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Min. lalu" }, { 0, "Min. ini" }, { 1, "Min. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Min. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Min." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Min. lalu" }, { 0, "Min. ini" }, { 1, "Min. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Min. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Min." } })
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
									new Dictionary<int, string> { { -1, "Senin lalu" }, { 0, "Senin ini" }, { 1, "Senin berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Senin lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Senin" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sen. lalu" }, { 0, "Sen. ini" }, { 1, "Sen. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sen. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sen." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sen. lalu" }, { 0, "Sen. ini" }, { 1, "Sen. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sen. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sen." } })
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
									new Dictionary<int, string> { { -1, "Selasa lalu" }, { 0, "Selasa ini" }, { 1, "Selasa berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Selasa lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Selasa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sel. lalu" }, { 0, "Sel. ini" }, { 1, "Sel. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sel. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sel." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sel. lalu" }, { 0, "Sel. ini" }, { 1, "Sel. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sel. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sel." } })
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
									new Dictionary<int, string> { { -1, "Rabu lalu" }, { 0, "Rabu ini" }, { 1, "Rabu berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Rabu lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Rabu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Rab. lalu" }, { 0, "Rab. ini" }, { 1, "Rab. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Rab. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Rab." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Rab. lalu" }, { 0, "Rab. ini" }, { 1, "Rab. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Rab. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Rab." } })
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
									new Dictionary<int, string> { { -1, "Kamis lalu" }, { 0, "Kamis ini" }, { 1, "Kamis berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Kamis lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Kamis" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Kam. lalu" }, { 0, "Kam. ini" }, { 1, "Kam. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Kam. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Kam." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Kam. lalu" }, { 0, "Kam. ini" }, { 1, "Kam. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Kam. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Kam." } })
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
									new Dictionary<int, string> { { -1, "Jumat lalu" }, { 0, "Jumat ini" }, { 1, "Jumat berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Jumat lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Jumat" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jum. lalu" }, { 0, "Jum. ini" }, { 1, "Jum. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Jum. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Jum." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Jum. lalu" }, { 0, "Jum. ini" }, { 1, "Jum. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Jum. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Jum." } })
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
									new Dictionary<int, string> { { -1, "Sabtu lalu" }, { 0, "Sabtu ini" }, { 1, "Sabtu berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sabtu lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} Sabtu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sab. lalu" }, { 0, "Sab. ini" }, { 1, "Sab. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sab. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sab." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sab. lalu" }, { 0, "Sab. ini" }, { 1, "Sab. berikutnya" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} Sab. lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} Sab." } })
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
									new Dictionary<int, string> { { 0, "jam ini" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} jam yang lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} jam" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "jam ini" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} jam lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} jam" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "jam ini" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} jam lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} jam" } })
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
									new Dictionary<int, string> { { 0, "menit ini" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} menit yang lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} menit" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "menit ini" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mnt lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mnt" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "menit ini" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} mnt lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} mnt" } })
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
									new Dictionary<int, string> { { 0, "sekarang" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} detik yang lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dalam {0} detik" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "sekarang" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dtk lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} dtk" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "sekarang" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dtk lalu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "dlm {0} dtk" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("id");
		}
	}
}