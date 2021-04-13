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
	/// Relative Time Units resource for 'Wolof' [wo]
	/// </summary>
	public class WoRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public WoRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "daaw" }, { 0, "ren" }, { 1, "dewen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} at ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} at" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "daaw" }, { 0, "ren" }, { 1, "dewen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} at ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} at" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "daaw" }, { 0, "ren" }, { 1, "dewen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} at ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} at" } })
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
									new Dictionary<int, string> { { -1, "trimestre bi weesu" }, { 0, "trimestre bii" }, { 1, "trimestre biy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} trimestre ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} trimestre" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "trimestre bi weesu" }, { 0, "trimestre bii" }, { 1, "trimestre biy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} trim. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} trim." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "trimestre bi weesu" }, { 0, "trimestre bii" }, { 1, "trimestre biy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} trim. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} trim." } })
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
									new Dictionary<int, string> { { -1, "weer wi weesu" }, { 0, "weer wii" }, { 1, "weer wiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} weer ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} weer" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "we. wi wees" }, { 0, "we. wii" }, { 1, "we. wiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} we. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} we." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "we. wi wees" }, { 0, "we. wii" }, { 1, "we. wiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} we. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} we." } })
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
									new Dictionary<int, string> { { -1, "ayu-bis bi weesu" }, { 0, "ayu-bis bii" }, { 1, "ayu-bis biy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ayi-bis ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} ayi-bis" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ayu-b bi wees" }, { 0, "ayu-b bii" }, { 1, "ayu-b. ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ayi-b. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} ayi-b." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ayu-b bi wees" }, { 0, "ayu-b bii" }, { 1, "ayu-b. ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ayi-b. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} ayi-b." } })
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
									new Dictionary<int, string> { { -1, "démb" }, { 0, "tay" }, { 1, "suba" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} fan ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} fan" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "démb" }, { 0, "tay" }, { 1, "suba" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} fan ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} fan" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "démb" }, { 0, "tay" }, { 1, "suba" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} fan ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} fan" } })
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
									new Dictionary<int, string> { { -1, "dibéer bi weesu" }, { 0, "tay ci dibéer bi" }, { 1, "dibéer biy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dibéer ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} dibéer" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "dib. bi weesu" }, { 0, "tay ci dib. bi" }, { 1, "dib. biy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dib. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} dib." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "dib. bi weesu" }, { 0, "tay ci dib. bi" }, { 1, "dib. biy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} dib. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} dib." } })
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
									new Dictionary<int, string> { { -1, "altine ji weesu" }, { 0, "tay ci altine ji" }, { 1, "altine jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} altine ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} altine" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "alti. ji weesu" }, { 0, "tay ci alti. ji" }, { 1, "alti. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alti. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alti." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "alt. ji weesu" }, { 0, "tay ci alt. ji" }, { 1, "alt. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alt. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alt." } })
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
									new Dictionary<int, string> { { -1, "talaata ji weesu" }, { 0, "tay ci talaata ji" }, { 1, "talaata jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} talaata ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} talaata" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "tal. ji weesu" }, { 0, "tay ci tal. ji" }, { 1, "tal. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} tal. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} tal." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ta. ji weesu" }, { 0, "tay ci ta. ji" }, { 1, "ta. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} ta. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} ta." } })
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
									new Dictionary<int, string> { { -1, "àllarba ji weesu" }, { 0, "tay ci àllarba ji" }, { 1, "àllarba jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àllarba ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àllarba" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "àlla. ji weesu" }, { 0, "tay ci àlla. ji" }, { 1, "àlla. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àlla. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àlla." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "àla. ji weesu" }, { 0, "tay ci àla. ji" }, { 1, "àla. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àla. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àla." } })
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
									new Dictionary<int, string> { { -1, "alxamis ji weesu" }, { 0, "tay ci alxamis ji" }, { 1, "alxamis jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alxamis ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alxamis" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "alxa. ji weesu" }, { 0, "tay ci alxa. ji" }, { 1, "alxa. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alxa. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alxa." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "alx. ji weesu" }, { 0, "tay ci alx. ji" }, { 1, "alx. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} alx. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} alx." } })
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
									new Dictionary<int, string> { { -1, "àjjuma ji weesu" }, { 0, "tay ci àjjuma ji" }, { 1, "àjjuma jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àjjuma ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àjjuma" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "àjj. ji weesu" }, { 0, "tay ci àjj. ji" }, { 1, "àjj. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àjj. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àjj." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "àj. ji weesu" }, { 0, "tay ci àj. ji" }, { 1, "àj. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} àj. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} àj." } })
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
									new Dictionary<int, string> { { -1, "gàwwu ji weesu" }, { 0, "tay ci gàwwu ji" }, { 1, "gàwwu jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} gàwwu ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} gàwwu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "gàw. ji weesu" }, { 0, "tay ci gàw. ji" }, { 1, "gàw. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} gàw. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} gàw." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "gà. ji weesu" }, { 0, "tay ci gà. ji" }, { 1, "gà. jiy ñëw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} gà. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} gà." } })
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
									new Dictionary<int, string> { { 0, "ci waxtu wii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} waxtu ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} waxtu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ci waxtu wii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} wax. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} wax." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ci waxtu wii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} wax. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} wax." } })
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
									new Dictionary<int, string> { { 0, "ci simili bii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} simili ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} simili" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ci simili bii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} sim. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} sim." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ci simili bii" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} sim. ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} sim." } })
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
									new Dictionary<int, string> { { 0, "leegi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} saa ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} saa" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "leegi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} saa ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} saa" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "leegi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "{0} saa ci ginaaw" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "fileek {0} saa" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("wo");
		}
	}
}