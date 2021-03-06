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
	/// Relative Time Units resource for 'Romanian' [ro]
	/// </summary>
	public class RoRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public RoRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "anul trecut" }, { 0, "anul acesta" }, { 1, "anul viitor" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} an" }, { PluralRulesValues.Few, "acum {0} ani" }, { PluralRulesValues.Other, "acum {0} de ani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} an" }, { PluralRulesValues.Few, "peste {0} ani" }, { PluralRulesValues.Other, "peste {0} de ani" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "anul trecut" }, { 0, "anul acesta" }, { 1, "anul viitor" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} an" }, { PluralRulesValues.Few, "acum {0} ani" }, { PluralRulesValues.Other, "acum {0} de ani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} an" }, { PluralRulesValues.Few, "peste {0} ani" }, { PluralRulesValues.Other, "peste {0} de ani" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "anul trecut" }, { 0, "anul acesta" }, { 1, "anul viitor" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} an" }, { PluralRulesValues.Few, "-{0} ani" }, { PluralRulesValues.Other, "-{0} ani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} an" }, { PluralRulesValues.Few, "+{0} ani" }, { PluralRulesValues.Other, "+{0} ani" } })
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
									new Dictionary<int, string> { { -1, "trimestrul trecut" }, { 0, "trimestrul acesta" }, { 1, "trimestrul viitor" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} trimestru" }, { PluralRulesValues.Few, "acum {0} trimestre" }, { PluralRulesValues.Other, "acum {0} de trimestre" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} trimestru" }, { PluralRulesValues.Few, "peste {0} trimestre" }, { PluralRulesValues.Other, "peste {0} de trimestre" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "trim. trecut" }, { 0, "trim. acesta" }, { 1, "trim. viitor" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} trim." }, { PluralRulesValues.Few, "acum {0} trim." }, { PluralRulesValues.Other, "acum {0} trim." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} trim." }, { PluralRulesValues.Few, "peste {0} trim." }, { PluralRulesValues.Other, "peste {0} trim." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "trim. trecut" }, { 0, "trim. acesta" }, { 1, "trim. viitor" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} trim." }, { PluralRulesValues.Few, "-{0} trim." }, { PluralRulesValues.Other, "-{0} trim." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} trim." }, { PluralRulesValues.Few, "+{0} trim." }, { PluralRulesValues.Other, "+{0} trim." } })
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
									new Dictionary<int, string> { { -1, "luna trecut??" }, { 0, "luna aceasta" }, { 1, "luna viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} lun??" }, { PluralRulesValues.Few, "acum {0} luni" }, { PluralRulesValues.Other, "acum {0} de luni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} lun??" }, { PluralRulesValues.Few, "peste {0} luni" }, { PluralRulesValues.Other, "peste {0} de luni" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "luna trecut??" }, { 0, "luna aceasta" }, { 1, "luna viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} lun??" }, { PluralRulesValues.Few, "acum {0} luni" }, { PluralRulesValues.Other, "acum {0} luni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} lun??" }, { PluralRulesValues.Few, "peste {0} luni" }, { PluralRulesValues.Other, "peste {0} luni" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "luna trecut??" }, { 0, "luna aceasta" }, { 1, "luna viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} lun??" }, { PluralRulesValues.Few, "-{0} luni" }, { PluralRulesValues.Other, "-{0} luni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} lun??" }, { PluralRulesValues.Few, "+{0} luni" }, { PluralRulesValues.Other, "+{0} luni" } })
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
									new Dictionary<int, string> { { -1, "s??pt??m??na trecut??" }, { 0, "s??pt??m??na aceasta" }, { 1, "s??pt??m??na viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} s??pt??m??n??" }, { PluralRulesValues.Few, "acum {0} s??pt??m??ni" }, { PluralRulesValues.Other, "acum {0} de s??pt??m??ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} s??pt??m??n??" }, { PluralRulesValues.Few, "peste {0} s??pt??m??ni" }, { PluralRulesValues.Other, "peste {0} de s??pt??m??ni" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "s??pt. trecut??" }, { 0, "s??pt. aceasta" }, { 1, "s??pt. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} s??pt." }, { PluralRulesValues.Few, "acum {0} s??pt." }, { PluralRulesValues.Other, "acum {0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} s??pt." }, { PluralRulesValues.Few, "peste {0} s??pt." }, { PluralRulesValues.Other, "peste {0} s??pt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "s??pt. trecut??" }, { 0, "s??pt. aceasta" }, { 1, "s??pt. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} s??pt." }, { PluralRulesValues.Few, "-{0} s??pt." }, { PluralRulesValues.Other, "-{0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} s??pt." }, { PluralRulesValues.Few, "+{0} s??pt." }, { PluralRulesValues.Other, "+{0} s??pt." } })
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
									new Dictionary<int, string> { { -2, "alalt??ieri" }, { -1, "ieri" }, { 0, "azi" }, { 1, "m??ine" }, { 2, "poim??ine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} zi" }, { PluralRulesValues.Few, "acum {0} zile" }, { PluralRulesValues.Other, "acum {0} de zile" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} zi" }, { PluralRulesValues.Few, "peste {0} zile" }, { PluralRulesValues.Other, "peste {0} de zile" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "alalt??ieri" }, { -1, "ieri" }, { 0, "azi" }, { 1, "m??ine" }, { 2, "poim??ine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} zi" }, { PluralRulesValues.Few, "acum {0} zile" }, { PluralRulesValues.Other, "acum {0} de zile" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} zi" }, { PluralRulesValues.Few, "peste {0} zile" }, { PluralRulesValues.Other, "peste {0} de zile" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "alalt??ieri" }, { -1, "ieri" }, { 0, "azi" }, { 1, "m??ine" }, { 2, "poim??ine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} zi" }, { PluralRulesValues.Few, "-{0} zile" }, { PluralRulesValues.Other, "-{0} zile" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} zi" }, { PluralRulesValues.Few, "+{0} zile" }, { PluralRulesValues.Other, "+{0} zile" } })
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
									new Dictionary<int, string> { { -1, "duminica trecut??" }, { 0, "duminica aceasta" }, { 1, "duminica viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "duminic??, acum {0} s??pt??m??n??" }, { PluralRulesValues.Few, "duminic??, acum {0} s??pt??m??ni" }, { PluralRulesValues.Other, "duminic??, acum {0} de s??pt??m??ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "duminic??, peste {0} s??pt??m??n??" }, { PluralRulesValues.Few, "duminic??, peste {0} s??pt??m??ni" }, { PluralRulesValues.Other, "duminic??, peste {0} de s??pt??m??ni" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "dum. trecut??" }, { 0, "dum. aceasta" }, { 1, "dum. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "duminic??, acum {0} s??pt." }, { PluralRulesValues.Few, "duminic??, acum {0} s??pt." }, { PluralRulesValues.Other, "duminic??, acum {0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "duminic??, peste {0} s??pt." }, { PluralRulesValues.Few, "duminic??, peste {0} s??pt." }, { PluralRulesValues.Other, "duminic??, peste {0} s??pt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "du. trecut??" }, { 0, "du. aceasta" }, { 1, "du. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "du. -{0} s??pt." }, { PluralRulesValues.Few, "du. -{0} s??pt." }, { PluralRulesValues.Other, "du. -{0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "du. +{0} s??pt." }, { PluralRulesValues.Few, "du. +{0} s??pt." }, { PluralRulesValues.Other, "du. +{0} s??pt." } })
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
									new Dictionary<int, string> { { -1, "lunea trecut??" }, { 0, "lunea aceasta" }, { 1, "lunea viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "luni, acum {0} s??pt??m??n??" }, { PluralRulesValues.Few, "luni, acum {0} s??pt??m??ni" }, { PluralRulesValues.Other, "luni, acum {0} de s??pt??m??ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "luni, peste {0} s??pt??m??n??" }, { PluralRulesValues.Few, "luni, peste {0} s??pt??m??ni" }, { PluralRulesValues.Other, "luni, peste {0} de s??pt??m??ni" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "lun. trecut??" }, { 0, "lun. aceasta" }, { 1, "lun. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "luni, acum {0} s??pt." }, { PluralRulesValues.Few, "luni, acum {0} s??pt." }, { PluralRulesValues.Other, "luni, acum {0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "luni, peste {0} s??pt." }, { PluralRulesValues.Few, "luni, peste {0} s??pt." }, { PluralRulesValues.Other, "luni, peste {0} s??pt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "lu. trecut??" }, { 0, "lu. aceasta" }, { 1, "lu. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "lu. -{0} s??pt." }, { PluralRulesValues.Few, "lu. -{0} s??pt." }, { PluralRulesValues.Other, "lu. -{0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "lu. +{0} s??pt." }, { PluralRulesValues.Few, "lu. +{0} s??pt." }, { PluralRulesValues.Other, "lu. +{0} s??pt." } })
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
									new Dictionary<int, string> { { -1, "mar??ea trecut??" }, { 0, "mar??ea aceasta" }, { 1, "mar??ea viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mar??i, acum {0} s??pt??m??n??" }, { PluralRulesValues.Few, "mar??i, acum {0} s??pt??m??ni" }, { PluralRulesValues.Other, "mar??i, acum {0} de s??pt??m??ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mar??i, peste {0} s??pt??m??n??" }, { PluralRulesValues.Few, "mar??i, peste {0} s??pt??m??ni" }, { PluralRulesValues.Other, "mar??i, peste {0} de s??pt??m??ni" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mar. trecut??" }, { 0, "mar. aceasta" }, { 1, "mar. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mar??i, acum {0} s??pt." }, { PluralRulesValues.Few, "mar??i, acum {0} s??pt." }, { PluralRulesValues.Other, "mar??i, acum {0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mar??i, peste {0} s??pt." }, { PluralRulesValues.Few, "mar??i, peste {0} s??pt." }, { PluralRulesValues.Other, "mar??i, peste {0} s??pt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ma. trecut??" }, { 0, "ma. aceasta" }, { 1, "ma. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ma. -{0} s??pt." }, { PluralRulesValues.Few, "ma. -{0} s??pt." }, { PluralRulesValues.Other, "ma. -{0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ma. +{0} s??pt." }, { PluralRulesValues.Few, "ma. +{0} s??pt." }, { PluralRulesValues.Other, "ma. +{0} s??pt." } })
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
									new Dictionary<int, string> { { -1, "miercurea trecut??" }, { 0, "miercurea aceasta" }, { 1, "miercurea viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "miercuri, acum {0} s??pt??m??n??" }, { PluralRulesValues.Few, "miercuri, acum {0} s??pt??m??ni" }, { PluralRulesValues.Other, "miercuri, acum {0} de s??pt??m??ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "miercuri, peste {0} s??pt??m??n??" }, { PluralRulesValues.Few, "miercuri, peste {0} s??pt??m??ni" }, { PluralRulesValues.Other, "miercuri, peste {0} de s??pt??m??ni" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mie. trecut??" }, { 0, "mie. aceasta" }, { 1, "mie. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "miercuri, acum {0} s??pt." }, { PluralRulesValues.Few, "miercuri, acum {0} s??pt." }, { PluralRulesValues.Other, "miercuri, acum {0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "miercuri, peste {0} s??pt." }, { PluralRulesValues.Few, "miercuri, peste {0} s??pt." }, { PluralRulesValues.Other, "miercuri, peste {0} s??pt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mi. trecut??" }, { 0, "mi. aceasta" }, { 1, "mi. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mi. -{0} s??pt." }, { PluralRulesValues.Few, "mi. -{0} s??pt." }, { PluralRulesValues.Other, "mi. -{0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "mi. +{0} s??pt." }, { PluralRulesValues.Few, "mi. +{0} s??pt." }, { PluralRulesValues.Other, "mi. +{0} s??pt." } })
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
									new Dictionary<int, string> { { -1, "joia trecut??" }, { 0, "joia aceasta" }, { 1, "joia viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "joi, acum {0} s??pt??m??n??" }, { PluralRulesValues.Few, "joi, acum {0} s??pt??m??ni" }, { PluralRulesValues.Other, "joi, acum {0} de s??pt??m??ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "joi, peste {0} s??pt??m??n??" }, { PluralRulesValues.Few, "joi, peste {0} s??pt??m??ni" }, { PluralRulesValues.Other, "joi, peste {0} de s??pt??m??ni" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "joia trecut??" }, { 0, "joia aceasta" }, { 1, "joia viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "joi, acum {0} s??pt." }, { PluralRulesValues.Few, "joi, acum {0} s??pt." }, { PluralRulesValues.Other, "joi, acum {0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "joi, peste {0} s??pt." }, { PluralRulesValues.Few, "joi, peste {0} s??pt." }, { PluralRulesValues.Other, "joi, peste {0} s??pt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "jo. trecut??" }, { 0, "jo. aceasta" }, { 1, "jo. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "jo. -{0} s??pt." }, { PluralRulesValues.Few, "jo. -{0} s??pt." }, { PluralRulesValues.Other, "jo. -{0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "jo. +{0} s??pt." }, { PluralRulesValues.Few, "jo. +{0} s??pt." }, { PluralRulesValues.Other, "jo. +{0} s??pt." } })
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
									new Dictionary<int, string> { { -1, "vinerea trecut??" }, { 0, "vinerea aceasta" }, { 1, "vinerea viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vineri, acum {0} s??pt??m??n??" }, { PluralRulesValues.Few, "vineri, acum {0} s??pt??m??ni" }, { PluralRulesValues.Other, "vineri, acum {0} de s??pt??m??ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vineri, peste {0} s??pt??m??n??" }, { PluralRulesValues.Few, "vineri, peste {0} s??pt??m??ni" }, { PluralRulesValues.Other, "vineri, peste {0} de s??pt??m??ni" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vin. trecut??" }, { 0, "vin. aceasta" }, { 1, "vin. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vineri, acum {0} s??pt." }, { PluralRulesValues.Few, "vineri, acum {0} s??pt." }, { PluralRulesValues.Other, "vineri, acum {0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vineri, peste {0} s??pt." }, { PluralRulesValues.Few, "vineri, peste {0} s??pt." }, { PluralRulesValues.Other, "vineri, peste {0} s??pt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vi. trecut??" }, { 0, "vi. aceasta" }, { 1, "vi. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vi. -{0} s??pt." }, { PluralRulesValues.Few, "vi. -{0} s??pt." }, { PluralRulesValues.Other, "vi. -{0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vi. +{0} s??pt." }, { PluralRulesValues.Few, "vi. +{0} s??pt." }, { PluralRulesValues.Other, "vi. +{0} s??pt." } })
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
									new Dictionary<int, string> { { -1, "s??mb??ta trecut??" }, { 0, "s??mb??ta aceasta" }, { 1, "s??mb??ta viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "s??mb??t??, acum {0} s??pt??m??n??" }, { PluralRulesValues.Few, "s??mb??t??, acum {0} s??pt??m??ni" }, { PluralRulesValues.Other, "s??mb??t??, acum {0} de s??pt??m??ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "s??mb??t??, peste {0} s??pt??m??n??" }, { PluralRulesValues.Few, "s??mb??t??, peste {0} s??pt??m??ni" }, { PluralRulesValues.Other, "s??mb??t??, peste {0} de s??pt??m??ni" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "s??m. trecut??" }, { 0, "s??m. aceasta" }, { 1, "s??m. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "s??mb??t??, acum {0} s??pt." }, { PluralRulesValues.Few, "s??mb??t??, acum {0} s??pt." }, { PluralRulesValues.Other, "s??mb??t??, acum {0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "s??mb??t??, peste {0} s??pt." }, { PluralRulesValues.Few, "s??mb??t??, peste {0} s??pt." }, { PluralRulesValues.Other, "s??mb??t??, peste {0} s??pt." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "s??. trecut??" }, { 0, "s??. aceasta" }, { 1, "s??. viitoare" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "s??. -{0} s??pt." }, { PluralRulesValues.Few, "s??. -{0} s??pt." }, { PluralRulesValues.Other, "s??. -{0} s??pt." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "s??. +{0} s??pt." }, { PluralRulesValues.Few, "s??. +{0} s??pt." }, { PluralRulesValues.Other, "s??. +{0} s??pt." } })
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
									new Dictionary<int, string> { { 0, "ora aceasta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} or??" }, { PluralRulesValues.Few, "acum {0} ore" }, { PluralRulesValues.Other, "acum {0} de ore" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} or??" }, { PluralRulesValues.Few, "peste {0} ore" }, { PluralRulesValues.Other, "peste {0} de ore" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ora aceasta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} h" }, { PluralRulesValues.Few, "acum {0} h" }, { PluralRulesValues.Other, "acum {0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} h" }, { PluralRulesValues.Few, "peste {0} h" }, { PluralRulesValues.Other, "peste {0} h" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ora aceasta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} h" }, { PluralRulesValues.Few, "-{0} h" }, { PluralRulesValues.Other, "-{0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} h" }, { PluralRulesValues.Few, "+{0} h" }, { PluralRulesValues.Other, "+{0} h" } })
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
									new Dictionary<int, string> { { 0, "minutul acesta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} minut" }, { PluralRulesValues.Few, "acum {0} minute" }, { PluralRulesValues.Other, "acum {0} de minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} minut" }, { PluralRulesValues.Few, "peste {0} minute" }, { PluralRulesValues.Other, "peste {0} de minute" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "minutul acesta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} min." }, { PluralRulesValues.Few, "acum {0} min." }, { PluralRulesValues.Other, "acum {0} min." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} min." }, { PluralRulesValues.Few, "peste {0} min." }, { PluralRulesValues.Other, "peste {0} min." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "minutul acesta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} m" }, { PluralRulesValues.Few, "-{0} m" }, { PluralRulesValues.Other, "-{0} m" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} m" }, { PluralRulesValues.Few, "+{0} m" }, { PluralRulesValues.Other, "+{0} m" } })
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
									new Dictionary<int, string> { { 0, "acum" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} secund??" }, { PluralRulesValues.Few, "acum {0} secunde" }, { PluralRulesValues.Other, "acum {0} de secunde" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} secund??" }, { PluralRulesValues.Few, "peste {0} secunde" }, { PluralRulesValues.Other, "peste {0} de secunde" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "acum" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "acum {0} sec." }, { PluralRulesValues.Few, "acum {0} sec." }, { PluralRulesValues.Other, "acum {0} sec." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "peste {0} sec." }, { PluralRulesValues.Few, "peste {0} sec." }, { PluralRulesValues.Other, "peste {0} sec." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "acum" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} s" }, { PluralRulesValues.Few, "-{0} s" }, { PluralRulesValues.Other, "-{0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} s" }, { PluralRulesValues.Few, "+{0} s" }, { PluralRulesValues.Other, "+{0} s" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("ro");
		}
	}
}