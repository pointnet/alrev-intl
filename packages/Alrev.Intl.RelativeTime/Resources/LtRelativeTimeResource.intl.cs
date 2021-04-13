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
	/// Relative Time Units resource for 'Lithuanian' [lt]
	/// </summary>
	public class LtRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public LtRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "praėjusiais metais" }, { 0, "šiais metais" }, { 1, "kitais metais" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} metus" }, { PluralRulesValues.Few, "prieš {0} metus" }, { PluralRulesValues.Many, "prieš {0} metų" }, { PluralRulesValues.Other, "prieš {0} metų" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} metų" }, { PluralRulesValues.Few, "po {0} metų" }, { PluralRulesValues.Many, "po {0} metų" }, { PluralRulesValues.Other, "po {0} metų" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusiais metais" }, { 0, "šiais metais" }, { 1, "kitais metais" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} m." }, { PluralRulesValues.Few, "prieš {0} m." }, { PluralRulesValues.Many, "prieš {0} m." }, { PluralRulesValues.Other, "prieš {0} m." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} m." }, { PluralRulesValues.Few, "po {0} m." }, { PluralRulesValues.Many, "po {0} m." }, { PluralRulesValues.Other, "po {0} m." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusiais metais" }, { 0, "šiais metais" }, { 1, "kitais metais" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} m." }, { PluralRulesValues.Few, "prieš {0} m." }, { PluralRulesValues.Many, "prieš {0} m." }, { PluralRulesValues.Other, "prieš {0} m." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} m." }, { PluralRulesValues.Few, "po {0} m." }, { PluralRulesValues.Many, "po {0} m." }, { PluralRulesValues.Other, "po {0} m." } })
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
									new Dictionary<int, string> { { -1, "praėjęs ketvirtis" }, { 0, "šis ketvirtis" }, { 1, "kitas ketvirtis" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} ketvirtį" }, { PluralRulesValues.Few, "prieš {0} ketvirčius" }, { PluralRulesValues.Many, "prieš {0} ketvirčio" }, { PluralRulesValues.Other, "prieš {0} ketvirčių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} ketvirčio" }, { PluralRulesValues.Few, "po {0} ketvirčių" }, { PluralRulesValues.Many, "po {0} ketvirčio" }, { PluralRulesValues.Other, "po {0} ketvirčių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjęs ketvirtis" }, { 0, "šis ketvirtis" }, { 1, "kitas ketvirtis" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} ketv." }, { PluralRulesValues.Few, "prieš {0} ketv." }, { PluralRulesValues.Many, "prieš {0} ketv." }, { PluralRulesValues.Other, "prieš {0} ketv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} ketv." }, { PluralRulesValues.Few, "po {0} ketv." }, { PluralRulesValues.Many, "po {0} ketv." }, { PluralRulesValues.Other, "po {0} ketv." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjęs ketvirtis" }, { 0, "šis ketvirtis" }, { 1, "kitas ketvirtis" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} ketv." }, { PluralRulesValues.Few, "prieš {0} ketv." }, { PluralRulesValues.Many, "prieš {0} ketv." }, { PluralRulesValues.Other, "prieš {0} ketv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} ketv." }, { PluralRulesValues.Few, "po {0} ketv." }, { PluralRulesValues.Many, "po {0} ketv." }, { PluralRulesValues.Other, "po {0} ketv." } })
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
									new Dictionary<int, string> { { -1, "praėjusį mėnesį" }, { 0, "šį mėnesį" }, { 1, "kitą mėnesį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} mėnesį" }, { PluralRulesValues.Few, "prieš {0} mėnesius" }, { PluralRulesValues.Many, "prieš {0} mėnesio" }, { PluralRulesValues.Other, "prieš {0} mėnesių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} mėnesio" }, { PluralRulesValues.Few, "po {0} mėnesių" }, { PluralRulesValues.Many, "po {0} mėnesio" }, { PluralRulesValues.Other, "po {0} mėnesių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį mėnesį" }, { 0, "šį mėnesį" }, { 1, "kitą mėnesį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} mėn." }, { PluralRulesValues.Few, "prieš {0} mėn." }, { PluralRulesValues.Many, "prieš {0} mėn." }, { PluralRulesValues.Other, "prieš {0} mėn." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} mėn." }, { PluralRulesValues.Few, "po {0} mėn." }, { PluralRulesValues.Many, "po {0} mėn." }, { PluralRulesValues.Other, "po {0} mėn." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį mėnesį" }, { 0, "šį mėnesį" }, { 1, "kitą mėnesį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} mėn." }, { PluralRulesValues.Few, "prieš {0} mėn." }, { PluralRulesValues.Many, "prieš {0} mėn." }, { PluralRulesValues.Other, "prieš {0} mėn." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} mėn." }, { PluralRulesValues.Few, "po {0} mėn." }, { PluralRulesValues.Many, "po {0} mėn." }, { PluralRulesValues.Other, "po {0} mėn." } })
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
									new Dictionary<int, string> { { -1, "praėjusią savaitę" }, { 0, "šią savaitę" }, { 1, "kitą savaitę" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} savaitę" }, { PluralRulesValues.Few, "prieš {0} savaites" }, { PluralRulesValues.Many, "prieš {0} savaitės" }, { PluralRulesValues.Other, "prieš {0} savaičių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} savaitės" }, { PluralRulesValues.Few, "po {0} savaičių" }, { PluralRulesValues.Many, "po {0} savaitės" }, { PluralRulesValues.Other, "po {0} savaičių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusią savaitę" }, { 0, "šią savaitę" }, { 1, "kitą savaitę" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} sav." }, { PluralRulesValues.Few, "prieš {0} sav." }, { PluralRulesValues.Many, "prieš {0} sav." }, { PluralRulesValues.Other, "prieš {0} sav." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} sav." }, { PluralRulesValues.Few, "po {0} sav." }, { PluralRulesValues.Many, "po {0} sav." }, { PluralRulesValues.Other, "po {0} sav." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusią savaitę" }, { 0, "šią savaitę" }, { 1, "kitą savaitę" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} sav." }, { PluralRulesValues.Few, "prieš {0} sav." }, { PluralRulesValues.Many, "prieš {0} sav." }, { PluralRulesValues.Other, "prieš {0} sav." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} sav." }, { PluralRulesValues.Few, "po {0} sav." }, { PluralRulesValues.Many, "po {0} sav." }, { PluralRulesValues.Other, "po {0} sav." } })
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
									new Dictionary<int, string> { { -2, "užvakar" }, { -1, "vakar" }, { 0, "šiandien" }, { 1, "rytoj" }, { 2, "poryt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} dieną" }, { PluralRulesValues.Few, "prieš {0} dienas" }, { PluralRulesValues.Many, "prieš {0} dienos" }, { PluralRulesValues.Other, "prieš {0} dienų" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} dienos" }, { PluralRulesValues.Few, "po {0} dienų" }, { PluralRulesValues.Many, "po {0} dienos" }, { PluralRulesValues.Other, "po {0} dienų" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "užvakar" }, { -1, "vakar" }, { 0, "šiandien" }, { 1, "rytoj" }, { 2, "poryt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} d." }, { PluralRulesValues.Few, "prieš {0} d." }, { PluralRulesValues.Many, "prieš {0} d." }, { PluralRulesValues.Other, "prieš {0} d." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} d." }, { PluralRulesValues.Few, "po {0} d." }, { PluralRulesValues.Many, "po {0} d." }, { PluralRulesValues.Other, "po {0} d." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "užvakar" }, { -1, "vakar" }, { 0, "šiandien" }, { 1, "rytoj" }, { 2, "poryt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} d." }, { PluralRulesValues.Few, "prieš {0} d." }, { PluralRulesValues.Many, "prieš {0} d." }, { PluralRulesValues.Other, "prieš {0} d." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} d." }, { PluralRulesValues.Few, "po {0} d." }, { PluralRulesValues.Many, "po {0} d." }, { PluralRulesValues.Other, "po {0} d." } })
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
									new Dictionary<int, string> { { -1, "praėjusį sekmadienį" }, { 0, "šį sekmadienį" }, { 1, "kitą sekmadienį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} sekmadienį" }, { PluralRulesValues.Few, "prieš {0} sekmadienius" }, { PluralRulesValues.Many, "prieš {0} sekmadienio" }, { PluralRulesValues.Other, "prieš {0} sekmadienių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} sekmadienio" }, { PluralRulesValues.Few, "po {0} sekmadienių" }, { PluralRulesValues.Many, "po {0} sekmadienio" }, { PluralRulesValues.Other, "po {0} sekmadienių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį sekm." }, { 0, "šį sekm." }, { 1, "kitą sekm." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} sekm." }, { PluralRulesValues.Few, "prieš {0} sekm." }, { PluralRulesValues.Many, "prieš {0} sekm." }, { PluralRulesValues.Other, "prieš {0} sekm." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} sekm." }, { PluralRulesValues.Few, "po {0} sekm." }, { PluralRulesValues.Many, "po {0} sekm." }, { PluralRulesValues.Other, "po {0} sekm." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį sekm." }, { 0, "šį sekm." }, { 1, "kitą sekm." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} sekm." }, { PluralRulesValues.Few, "prieš {0} sekm." }, { PluralRulesValues.Many, "prieš {0} sekm." }, { PluralRulesValues.Other, "prieš {0} sekm." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} sekm." }, { PluralRulesValues.Few, "po {0} sekm." }, { PluralRulesValues.Many, "po {0} sekm." }, { PluralRulesValues.Other, "po {0} sekm." } })
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
									new Dictionary<int, string> { { -1, "praėjusį pirmadienį" }, { 0, "šį pirmadienį" }, { 1, "kitą pirmadienį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} pirmadienį" }, { PluralRulesValues.Few, "prieš {0} pirmadienius" }, { PluralRulesValues.Many, "prieš {0} pirmadienio" }, { PluralRulesValues.Other, "prieš {0} pirmadienių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} pirmadienio" }, { PluralRulesValues.Few, "po {0} pirmadienių" }, { PluralRulesValues.Many, "po {0} pirmadienio" }, { PluralRulesValues.Other, "po {0} pirmadienių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį pirm." }, { 0, "šį pirm." }, { 1, "kitą pirm." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} pirm." }, { PluralRulesValues.Few, "prieš {0} pirm." }, { PluralRulesValues.Many, "prieš {0} pirm." }, { PluralRulesValues.Other, "prieš {0} pirm." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} pirm." }, { PluralRulesValues.Few, "po {0} pirm." }, { PluralRulesValues.Many, "po {0} pirm." }, { PluralRulesValues.Other, "po {0} pirm." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį pirm." }, { 0, "šį pirm." }, { 1, "kitą pirm." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} pirm." }, { PluralRulesValues.Few, "prieš {0} pirm." }, { PluralRulesValues.Many, "prieš {0} pirm." }, { PluralRulesValues.Other, "prieš {0} pirm." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} pirm." }, { PluralRulesValues.Few, "po {0} pirm." }, { PluralRulesValues.Many, "po {0} pirm." }, { PluralRulesValues.Other, "po {0} pirm." } })
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
									new Dictionary<int, string> { { -1, "praėjusį antradienį" }, { 0, "šį antradienį" }, { 1, "kitą antradienį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} antradienį" }, { PluralRulesValues.Few, "prieš {0} antradienius" }, { PluralRulesValues.Many, "prieš {0} antradienio" }, { PluralRulesValues.Other, "prieš {0} antradienių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} antradienio" }, { PluralRulesValues.Few, "po {0} antradienių" }, { PluralRulesValues.Many, "po {0} antradienio" }, { PluralRulesValues.Other, "po {0} antradienių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį antr." }, { 0, "šį antr." }, { 1, "kitą antr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} antr." }, { PluralRulesValues.Few, "prieš {0} antr." }, { PluralRulesValues.Many, "prieš {0} antr." }, { PluralRulesValues.Other, "prieš {0} antr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} antr." }, { PluralRulesValues.Few, "po {0} antr." }, { PluralRulesValues.Many, "po {0} antr." }, { PluralRulesValues.Other, "po {0} antr." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį antr." }, { 0, "šį antr." }, { 1, "kitą antr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} antr." }, { PluralRulesValues.Few, "prieš {0} antr." }, { PluralRulesValues.Many, "prieš {0} antr." }, { PluralRulesValues.Other, "prieš {0} antr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} antr." }, { PluralRulesValues.Few, "po {0} antr." }, { PluralRulesValues.Many, "po {0} antr." }, { PluralRulesValues.Other, "po {0} antr." } })
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
									new Dictionary<int, string> { { -1, "praėjusį trečiadienį" }, { 0, "šį trečiadienį" }, { 1, "kitą trečiadienį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} trečiadienį" }, { PluralRulesValues.Few, "prieš {0} trečiadienius" }, { PluralRulesValues.Many, "prieš {0} trečiadienio" }, { PluralRulesValues.Other, "prieš {0} trečiadienių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} trečiadienio" }, { PluralRulesValues.Few, "po {0} trečiadienių" }, { PluralRulesValues.Many, "po {0} trečiadienio" }, { PluralRulesValues.Other, "po {0} trečiadienių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį treč." }, { 0, "šį treč." }, { 1, "kitą treč." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} treč." }, { PluralRulesValues.Few, "prieš {0} treč." }, { PluralRulesValues.Many, "prieš {0} treč." }, { PluralRulesValues.Other, "prieš {0} treč." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} treč." }, { PluralRulesValues.Few, "po {0} treč." }, { PluralRulesValues.Many, "po {0} treč." }, { PluralRulesValues.Other, "po {0} treč." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį treč." }, { 0, "šį treč." }, { 1, "kitą treč." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} treč." }, { PluralRulesValues.Few, "prieš {0} treč." }, { PluralRulesValues.Many, "prieš {0} treč." }, { PluralRulesValues.Other, "prieš {0} treč." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} treč." }, { PluralRulesValues.Few, "po {0} treč." }, { PluralRulesValues.Many, "po {0} treč." }, { PluralRulesValues.Other, "po {0} treč." } })
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
									new Dictionary<int, string> { { -1, "praėjusį ketvirtadienį" }, { 0, "šį ketvirtadienį" }, { 1, "kitą ketvirtadienį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} ketvirtadienį" }, { PluralRulesValues.Few, "prieš {0} ketvirtadienius" }, { PluralRulesValues.Many, "prieš {0} ketvirtadienio" }, { PluralRulesValues.Other, "prieš {0} ketvirtadienių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} ketvirtadienio" }, { PluralRulesValues.Few, "po {0} ketvirtadienių" }, { PluralRulesValues.Many, "po {0} ketvirtadienio" }, { PluralRulesValues.Other, "po {0} ketvirtadienių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį ketv." }, { 0, "šį ketv." }, { 1, "kitą ketv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} ketv." }, { PluralRulesValues.Few, "prieš {0} ketv." }, { PluralRulesValues.Many, "prieš {0} ketv." }, { PluralRulesValues.Other, "prieš {0} ketv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} ketv." }, { PluralRulesValues.Few, "po {0} ketv." }, { PluralRulesValues.Many, "po {0} ketv." }, { PluralRulesValues.Other, "po {0} ketv." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį ketv." }, { 0, "šį ketv." }, { 1, "kitą ketv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} ketv." }, { PluralRulesValues.Few, "prieš {0} ketv." }, { PluralRulesValues.Many, "prieš {0} ketv." }, { PluralRulesValues.Other, "prieš {0} ketv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} ketv." }, { PluralRulesValues.Few, "po {0} ketv." }, { PluralRulesValues.Many, "po {0} ketv." }, { PluralRulesValues.Other, "po {0} ketv." } })
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
									new Dictionary<int, string> { { -1, "praėjusį penktadienį" }, { 0, "šį penktadienį" }, { 1, "kitą penktadienį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} penktadienį" }, { PluralRulesValues.Few, "prieš {0} penktadienius" }, { PluralRulesValues.Many, "prieš {0} penktadienio" }, { PluralRulesValues.Other, "prieš {0} penktadienių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} penktadienio" }, { PluralRulesValues.Few, "po {0} penktadienių" }, { PluralRulesValues.Many, "po {0} penktadienio" }, { PluralRulesValues.Other, "po {0} penktadienių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį penkt." }, { 0, "šį penkt." }, { 1, "kitą penkt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} penkt." }, { PluralRulesValues.Few, "prieš {0} penkt." }, { PluralRulesValues.Many, "prieš {0} penkt." }, { PluralRulesValues.Other, "prieš {0} penkt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} penkt." }, { PluralRulesValues.Few, "po {0} penkt." }, { PluralRulesValues.Many, "po {0} penkt." }, { PluralRulesValues.Other, "po {0} penkt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį penkt." }, { 0, "šį penkt." }, { 1, "kitą penkt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} penkt." }, { PluralRulesValues.Few, "prieš {0} penkt." }, { PluralRulesValues.Many, "prieš {0} penkt." }, { PluralRulesValues.Other, "prieš {0} penkt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} penkt." }, { PluralRulesValues.Few, "po {0} penkt." }, { PluralRulesValues.Many, "po {0} penkt." }, { PluralRulesValues.Other, "po {0} penkt." } })
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
									new Dictionary<int, string> { { -1, "praėjusį šeštadienį" }, { 0, "šį šeštadienį" }, { 1, "kitą šeštadienį" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} šeštadienį" }, { PluralRulesValues.Few, "prieš {0} šeštadienius" }, { PluralRulesValues.Many, "prieš {0} šeštadienio" }, { PluralRulesValues.Other, "prieš {0} šeštadienių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} šeštadienio" }, { PluralRulesValues.Few, "po {0} šeštadienių" }, { PluralRulesValues.Many, "po {0} šeštadienio" }, { PluralRulesValues.Other, "po {0} šeštadienių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį šešt." }, { 0, "šį šešt." }, { 1, "kitą šešt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} šešt." }, { PluralRulesValues.Few, "prieš {0} šešt." }, { PluralRulesValues.Many, "prieš {0} šešt." }, { PluralRulesValues.Other, "prieš {0} šešt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} šešt." }, { PluralRulesValues.Few, "po {0} šešt." }, { PluralRulesValues.Many, "po {0} šešt." }, { PluralRulesValues.Other, "po {0} šešt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "praėjusį šešt." }, { 0, "šį šešt." }, { 1, "kitą šešt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} šešt." }, { PluralRulesValues.Few, "prieš {0} šešt." }, { PluralRulesValues.Many, "prieš {0} šešt." }, { PluralRulesValues.Other, "prieš {0} šešt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} šeštadienio" }, { PluralRulesValues.Few, "po {0} šešt." }, { PluralRulesValues.Many, "po {0} šešt." }, { PluralRulesValues.Other, "po {0} šešt." } })
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
									new Dictionary<int, string> { { 0, "šią valandą" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} valandą" }, { PluralRulesValues.Few, "prieš {0} valandas" }, { PluralRulesValues.Many, "prieš {0} valandos" }, { PluralRulesValues.Other, "prieš {0} valandų" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} valandos" }, { PluralRulesValues.Few, "po {0} valandų" }, { PluralRulesValues.Many, "po {0} valandos" }, { PluralRulesValues.Other, "po {0} valandų" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "šią valandą" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} val." }, { PluralRulesValues.Few, "prieš {0} val." }, { PluralRulesValues.Many, "prieš {0} val." }, { PluralRulesValues.Other, "prieš {0} val." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} val." }, { PluralRulesValues.Few, "po {0} val." }, { PluralRulesValues.Many, "po {0} val." }, { PluralRulesValues.Other, "po {0} val." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "šią valandą" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} val." }, { PluralRulesValues.Few, "prieš {0} val." }, { PluralRulesValues.Many, "prieš {0} val." }, { PluralRulesValues.Other, "prieš {0} val." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} val." }, { PluralRulesValues.Few, "po {0} val." }, { PluralRulesValues.Many, "po {0} val." }, { PluralRulesValues.Other, "po {0} val." } })
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
									new Dictionary<int, string> { { 0, "šią minutę" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} minutę" }, { PluralRulesValues.Few, "prieš {0} minutes" }, { PluralRulesValues.Many, "prieš {0} minutės" }, { PluralRulesValues.Other, "prieš {0} minučių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} minutės" }, { PluralRulesValues.Few, "po {0} minučių" }, { PluralRulesValues.Many, "po {0} minutės" }, { PluralRulesValues.Other, "po {0} minučių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "šią minutę" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} min." }, { PluralRulesValues.Few, "prieš {0} min." }, { PluralRulesValues.Many, "prieš {0} min." }, { PluralRulesValues.Other, "prieš {0} min." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} min." }, { PluralRulesValues.Few, "po {0} min." }, { PluralRulesValues.Many, "po {0} min." }, { PluralRulesValues.Other, "po {0} min." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "šią minutę" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} min." }, { PluralRulesValues.Few, "prieš {0} min." }, { PluralRulesValues.Many, "prieš {0} min." }, { PluralRulesValues.Other, "prieš {0} min." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} min." }, { PluralRulesValues.Few, "po {0} min." }, { PluralRulesValues.Many, "po {0} min." }, { PluralRulesValues.Other, "po {0} min." } })
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
									new Dictionary<int, string> { { 0, "dabar" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} sekundę" }, { PluralRulesValues.Few, "prieš {0} sekundes" }, { PluralRulesValues.Many, "prieš {0} sekundės" }, { PluralRulesValues.Other, "prieš {0} sekundžių" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} sekundės" }, { PluralRulesValues.Few, "po {0} sekundžių" }, { PluralRulesValues.Many, "po {0} sekundės" }, { PluralRulesValues.Other, "po {0} sekundžių" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "dabar" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} sek." }, { PluralRulesValues.Few, "prieš {0} sek." }, { PluralRulesValues.Many, "prieš {0} sek." }, { PluralRulesValues.Other, "prieš {0} sek." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} sek." }, { PluralRulesValues.Few, "po {0} sek." }, { PluralRulesValues.Many, "po {0} sek." }, { PluralRulesValues.Other, "po {0} sek." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "dabar" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "prieš {0} s" }, { PluralRulesValues.Few, "prieš {0} s" }, { PluralRulesValues.Many, "prieš {0} s" }, { PluralRulesValues.Other, "prieš {0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "po {0} s" }, { PluralRulesValues.Few, "po {0} s" }, { PluralRulesValues.Many, "po {0} s" }, { PluralRulesValues.Other, "po {0} s" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("lt");
		}
	}
}