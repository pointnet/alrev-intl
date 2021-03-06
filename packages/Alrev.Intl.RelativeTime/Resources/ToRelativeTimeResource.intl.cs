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
	/// Relative Time Units resource for 'Tongan' [to]
	/// </summary>
	public class ToRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public ToRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "taʻu kuoʻosi" }, { 0, "taʻú ni" }, { 1, "taʻu kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "taʻu ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he taʻu ʻe {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "taʻu kuoʻosi" }, { 0, "taʻú ni" }, { 1, "taʻu kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "taʻu ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he taʻu ʻe {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "taʻu kuoʻosi" }, { 0, "taʻú ni" }, { 1, "taʻu kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "taʻu ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he taʻu ʻe {0}" } })
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
									new Dictionary<int, string> { { -1, "kuata kuoʻosi" }, { 0, "kuata koʻeni" }, { 1, "kuata hoko" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "kuata ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he kuata ʻe {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "kuata kuoʻosi" }, { 0, "kuata koʻeni" }, { 1, "kuata hoko" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "kuata ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he kuata ʻe {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "kuata kuoʻosi" }, { 0, "kuata koʻeni" }, { 1, "kuata hoko" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "kuata ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he kuata ʻe {0}" } })
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
									new Dictionary<int, string> { { -1, "māhina kuoʻosi" }, { 0, "māhiná ni" }, { 1, "māhina kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "māhina ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he māhina ʻe {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "māhina kuoʻosi" }, { 0, "māhiná ni" }, { 1, "māhina kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "māhina ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he māhina ʻe {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "māhina kuoʻosi" }, { 0, "māhiná ni" }, { 1, "māhina kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "māhina ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he māhina ʻe {0}" } })
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
									new Dictionary<int, string> { { -1, "uike kuoʻosi" }, { 0, "uiké ni" }, { 1, "uike kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "uike ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he uike ʻe {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "uike kuoʻosi" }, { 0, "uiké ni" }, { 1, "uike kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "uike ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he uike ʻe {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "uike kuoʻosi" }, { 0, "uiké ni" }, { 1, "uike kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "uike ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he uike ʻe {0}" } })
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
									new Dictionary<int, string> { { -2, "ʻaneheafi" }, { -1, "ʻaneafi" }, { 0, "ʻahó ni" }, { 1, "ʻapongipongi" }, { 2, "ʻahepongipongi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻaho ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he ʻaho ʻe {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "ʻaneheafi" }, { -1, "ʻaneafi" }, { 0, "ʻahó ni" }, { 1, "ʻapongipongi" }, { 2, "ʻahepongipongi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻaho ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he ʻaho ʻe {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "ʻaneheafi" }, { -1, "ʻaneafi" }, { 0, "ʻahó ni" }, { 1, "ʻapongipongi" }, { 2, "ʻahepongipongi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻaho ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he ʻaho ʻe {0}" } })
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
									new Dictionary<int, string> { { -1, "Sāpate kuoʻosi" }, { 0, "Sāpaté ni" }, { 1, "Sāpate kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Sāpate ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Sāpate ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sāpate kuoʻosi" }, { 0, "Sāpaté ni" }, { 1, "Sāpate kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Sāpate ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Sāpate ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Sāpate kuoʻosi" }, { 0, "Sāpaté ni" }, { 1, "Sāpate kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Sāpate ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Sāpate ʻe {0} ʻi he kahaʻu" } })
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
									new Dictionary<int, string> { { -1, "Mōnite kuoʻosi" }, { 0, "Mōnité ni" }, { 1, "Mōnite kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Mōnite ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Mōnite ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Mōnite kuoʻosi" }, { 0, "Mōnité ni" }, { 1, "Mōnite kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Mōnite ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Mōnite ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Mōnite kuoʻosi" }, { 0, "Mōnité ni" }, { 1, "Mōnite kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Mōnite ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Mōnite ʻe {0} ʻi he kahaʻu" } })
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
									new Dictionary<int, string> { { -1, "Tūsite kuoʻosi" }, { 0, "Tūsité ni" }, { 1, "Tūsite kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Tūsite ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Tūsite ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Tūsite kuoʻosi" }, { 0, "Tūsité ni" }, { 1, "Tūsite kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tūsite ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tūsite ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Tūsite kuoʻosi" }, { 0, "Tūsité ni" }, { 1, "Tūsite kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tūsite ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tūsite ʻe {0} ʻi he kahaʻu" } })
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
									new Dictionary<int, string> { { -1, "Pulelulu kuoʻosi" }, { 0, "Pulelulú ni" }, { 1, "Pulelulu kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Pulelulu ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Pulelulu ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Pulelulu kuoʻosi" }, { 0, "Pulelulú ni" }, { 1, "Pulelulu kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Pulelulu ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Pulelulu ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Pulelulu kuoʻosi" }, { 0, "Pulelulú ni" }, { 1, "Pulelulu kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Pulelulu ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Pulelulu ʻe {0} ʻi he kahaʻu" } })
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
									new Dictionary<int, string> { { -1, "Tuʻapulelulu kuoʻosi" }, { 0, "Tuʻapulelulú ni" }, { 1, "Tuʻapulelulu kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Tuʻapulelulu ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Tuʻapulelulu ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Tuʻapulelulu kuoʻosi" }, { 0, "Tuʻapulelulú ni" }, { 1, "Tuʻapulelulu kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tuʻapulelulu ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tuʻapulelulu ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Tuʻapulelulu kuoʻosi" }, { 0, "Tuʻapulelulú ni" }, { 1, "Tuʻapulelulu kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tuʻapulelulu ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tuʻapulelulu ʻe {0} ʻi he kahaʻu" } })
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
									new Dictionary<int, string> { { -1, "Falaite kuoʻosi" }, { 0, "Falaité ni" }, { 1, "Falaite kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Falaite ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Falaite ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Falaite kuoʻosi" }, { 0, "Falaité ni" }, { 1, "Falaite kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Falaite ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Falaite ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Falaite kuoʻosi" }, { 0, "Falaité ni" }, { 1, "Falaite kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Falaite ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Falaite ʻe {0} ʻi he kahaʻu" } })
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
									new Dictionary<int, string> { { -1, "Tokonaki kuoʻosi" }, { 0, "Tokonakí ni" }, { 1, "Tokonaki kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Tokonaki ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Ngaahi Tokonaki ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Tokonaki kuoʻosi" }, { 0, "Tokonakí ni" }, { 1, "Tokonaki kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tokonaki ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tokonaki ʻe {0} ʻi he kahaʻu" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Tokonaki kuoʻosi" }, { 0, "Tokonakí ni" }, { 1, "Tokonaki kahaʻu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tokonaki ʻe {0} ʻi he kuohili" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "Tokonaki ʻe {0} ʻi he kahaʻu" } })
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
									new Dictionary<int, string> { { 0, "ko e houa ʻeni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "houa ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he houa ʻe {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ko e houa ʻeni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "houa ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he houa ʻe {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ko e houa ʻeni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "houa ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he houa ʻe {0}" } })
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
									new Dictionary<int, string> { { 0, "ko e miniti ʻeni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "miniti ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he miniti ʻe {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ko e miniti ʻeni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "miniti ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he miniti ʻe {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ko e miniti ʻeni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "miniti ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he miniti ʻe {0}" } })
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
									new Dictionary<int, string> { { 0, "taimí ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sekoni ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he sekoni ʻe {0}" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "taimí ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sekoni ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he sekoni ʻe {0}" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "taimí ni" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "sekoni ʻe {0} kuoʻosi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.Other, "ʻi he sekoni ʻe {0}" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("to");
		}
	}
}