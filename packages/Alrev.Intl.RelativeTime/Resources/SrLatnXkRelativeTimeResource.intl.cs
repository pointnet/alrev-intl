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
	/// Relative Time Units resource for 'Serbian (Latin, Kosovo)' [sr-latn-xk]
	/// </summary>
	public class SrLatnXkRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public SrLatnXkRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "prošle godine" }, { 0, "ove godine" }, { 1, "sledeće godine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} godine" }, { PluralRulesValues.Few, "pre {0} godine" }, { PluralRulesValues.Other, "pre {0} godina" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} godinu" }, { PluralRulesValues.Few, "za {0} godine" }, { PluralRulesValues.Other, "za {0} godina" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle god." }, { 0, "ove god." }, { 1, "sledeće god." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} god." }, { PluralRulesValues.Few, "pre {0} god." }, { PluralRulesValues.Other, "pre {0} god." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} god." }, { PluralRulesValues.Few, "za {0} god." }, { PluralRulesValues.Other, "za {0} god." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle g." }, { 0, "ove g." }, { 1, "sledeće g." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} g." }, { PluralRulesValues.Few, "pre {0} g." }, { PluralRulesValues.Other, "pre {0} g." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} g." }, { PluralRulesValues.Few, "za {0} g." }, { PluralRulesValues.Other, "za {0} g." } })
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
									new Dictionary<int, string> { { -1, "prošlog kvartala" }, { 0, "ovog kvartala" }, { 1, "sledećeg kvartala" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} kvartala" }, { PluralRulesValues.Few, "pre {0} kvartala" }, { PluralRulesValues.Other, "pre {0} kvartala" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kvartal" }, { PluralRulesValues.Few, "za {0} kvartala" }, { PluralRulesValues.Other, "za {0} kvartala" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog kvartala" }, { 0, "ovog kvartala" }, { 1, "sledećeg kvartala" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} kv." }, { PluralRulesValues.Few, "pre {0} kv." }, { PluralRulesValues.Other, "pre {0} kv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kv." }, { PluralRulesValues.Few, "za {0} kv." }, { PluralRulesValues.Other, "za {0} kv." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog kvartala" }, { 0, "ovog kvartala" }, { 1, "sledećeg kvartala" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} kv." }, { PluralRulesValues.Few, "pre {0} kv." }, { PluralRulesValues.Other, "pre {0} kv." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} kv." }, { PluralRulesValues.Few, "za {0} kv." }, { PluralRulesValues.Other, "za {0} kv." } })
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
									new Dictionary<int, string> { { -1, "prošlog meseca" }, { 0, "ovog meseca" }, { 1, "sledećeg meseca" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} meseca" }, { PluralRulesValues.Few, "pre {0} meseca" }, { PluralRulesValues.Other, "pre {0} meseci" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} mesec" }, { PluralRulesValues.Few, "za {0} meseca" }, { PluralRulesValues.Other, "za {0} meseci" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog mes." }, { 0, "ovog mes." }, { 1, "sledećeg mes." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} mes." }, { PluralRulesValues.Few, "pre {0} mes." }, { PluralRulesValues.Other, "pre {0} mes." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} mes." }, { PluralRulesValues.Few, "za {0} mes." }, { PluralRulesValues.Other, "za {0} mes." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog m." }, { 0, "ovog m." }, { 1, "sledećeg m." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} m." }, { PluralRulesValues.Few, "pre {0} m." }, { PluralRulesValues.Other, "pre {0} m." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} m." }, { PluralRulesValues.Few, "za {0} m." }, { PluralRulesValues.Other, "za {0} m." } })
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
									new Dictionary<int, string> { { -1, "prošle nedelje" }, { 0, "ove nedelje" }, { 1, "sledeće nedelje" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} nedelje" }, { PluralRulesValues.Few, "pre {0} nedelje" }, { PluralRulesValues.Other, "pre {0} nedelja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} nedelju" }, { PluralRulesValues.Few, "za {0} nedelje" }, { PluralRulesValues.Other, "za {0} nedelja" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle ned." }, { 0, "ove ned." }, { 1, "sledeće ned." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} ned." }, { PluralRulesValues.Few, "pre {0} ned." }, { PluralRulesValues.Other, "pre {0} ned." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} ned." }, { PluralRulesValues.Few, "za {0} ned." }, { PluralRulesValues.Other, "za {0} ned." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle n." }, { 0, "ove n." }, { 1, "sledeće n." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} n." }, { PluralRulesValues.Few, "pre {0} n." }, { PluralRulesValues.Other, "pre {0} n." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} n." }, { PluralRulesValues.Few, "za {0} n." }, { PluralRulesValues.Other, "za {0} n." } })
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
									new Dictionary<int, string> { { -2, "prekjuče" }, { -1, "juče" }, { 0, "danas" }, { 1, "sutra" }, { 2, "prekosutra" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} dana" }, { PluralRulesValues.Few, "pre {0} dana" }, { PluralRulesValues.Other, "pre {0} dana" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} dan" }, { PluralRulesValues.Few, "za {0} dana" }, { PluralRulesValues.Other, "za {0} dana" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "prekjuče" }, { -1, "juče" }, { 0, "danas" }, { 1, "sutra" }, { 2, "prekosutra" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} d." }, { PluralRulesValues.Few, "pre {0} d." }, { PluralRulesValues.Other, "pre {0} d." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} d." }, { PluralRulesValues.Few, "za {0} d." }, { PluralRulesValues.Other, "za {0} d." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "prekjuče" }, { -1, "juče" }, { 0, "danas" }, { 1, "sutra" }, { 2, "prekosutra" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} d." }, { PluralRulesValues.Few, "pre {0} d." }, { PluralRulesValues.Other, "pre {0} d." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} d." }, { PluralRulesValues.Few, "za {0} d." }, { PluralRulesValues.Other, "za {0} d." } })
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
									new Dictionary<int, string> { { -1, "prošle nedelje" }, { 0, "u nedelju" }, { 1, "sledeće nedelje" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} nedelje" }, { PluralRulesValues.Few, "pre {0} nedelje" }, { PluralRulesValues.Other, "pre {0} nedelja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} nedelju" }, { PluralRulesValues.Few, "za {0} nedelje" }, { PluralRulesValues.Other, "za {0} nedelja" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "pr. ned." }, { 0, "u ned" }, { 1, "sl. ned." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} nedelje" }, { PluralRulesValues.Few, "pre {0} nedelje" }, { PluralRulesValues.Other, "pre {0} nedelja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} nedelju" }, { PluralRulesValues.Few, "za {0} nedelje" }, { PluralRulesValues.Other, "za {0} nedelja" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "pr. ned." }, { 0, "u ned" }, { 1, "sl. ned." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} nedelje" }, { PluralRulesValues.Few, "pre {0} nedelje" }, { PluralRulesValues.Other, "pre {0} nedelja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} nedelju" }, { PluralRulesValues.Few, "za {0} nedelje" }, { PluralRulesValues.Other, "za {0} nedelja" } })
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
									new Dictionary<int, string> { { -1, "prošlog ponedeljka" }, { 0, "u ponedeljak" }, { 1, "sledećeg ponedeljka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} ponedeljka" }, { PluralRulesValues.Few, "pre {0} ponedeljka" }, { PluralRulesValues.Other, "pre {0} ponedeljaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} ponedeljak" }, { PluralRulesValues.Few, "za {0} ponedeljka" }, { PluralRulesValues.Other, "za {0} ponedeljaka" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog pon" }, { 0, "u pon" }, { 1, "sledećeg pon" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} ponedeljka" }, { PluralRulesValues.Few, "pre {0} ponedeljka" }, { PluralRulesValues.Other, "pre {0} ponedeljaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} ponedeljak" }, { PluralRulesValues.Few, "za {0} ponedeljka" }, { PluralRulesValues.Other, "za {0} ponedeljaka" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog pon" }, { 0, "u pon" }, { 1, "sledećeg pon" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} ponedeljka" }, { PluralRulesValues.Few, "pre {0} ponedeljka" }, { PluralRulesValues.Other, "pre {0} ponedeljaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} ponedeljak" }, { PluralRulesValues.Few, "za {0} ponedeljka" }, { PluralRulesValues.Other, "za {0} ponedeljaka" } })
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
									new Dictionary<int, string> { { -1, "prošlog utorka" }, { 0, "u utorak" }, { 1, "sledećeg utorka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} utorka" }, { PluralRulesValues.Few, "pre {0} utorka" }, { PluralRulesValues.Other, "pre {0} utoraka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} utorak" }, { PluralRulesValues.Few, "za {0} utorka" }, { PluralRulesValues.Other, "za {0} utoraka" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog uto" }, { 0, "u uto" }, { 1, "sledećeg uto" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} utorka" }, { PluralRulesValues.Few, "pre {0} utorka" }, { PluralRulesValues.Other, "pre {0} utoraka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} utorak" }, { PluralRulesValues.Few, "za {0} utorka" }, { PluralRulesValues.Other, "za {0} utoraka" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog uto" }, { 0, "u uto" }, { 1, "sledećeg uto" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} utorka" }, { PluralRulesValues.Few, "pre {0} utorka" }, { PluralRulesValues.Other, "pre {0} utoraka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} utorak" }, { PluralRulesValues.Few, "za {0} utorka" }, { PluralRulesValues.Other, "za {0} utoraka" } })
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
									new Dictionary<int, string> { { -1, "prošle srede" }, { 0, "u sredu" }, { 1, "sledeće srede" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} srede" }, { PluralRulesValues.Few, "pre {0} srede" }, { PluralRulesValues.Other, "pre {0} sreda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sredu" }, { PluralRulesValues.Few, "za {0} srede" }, { PluralRulesValues.Other, "za {0} sreda" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle sre" }, { 0, "u sre" }, { 1, "sledeće sre" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} srede" }, { PluralRulesValues.Few, "pre {0} srede" }, { PluralRulesValues.Other, "pre {0} sreda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sredu" }, { PluralRulesValues.Few, "za {0} srede" }, { PluralRulesValues.Other, "za {0} sreda" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle sre" }, { 0, "u sre" }, { 1, "sledeće sre" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} srede" }, { PluralRulesValues.Few, "pre {0} srede" }, { PluralRulesValues.Other, "pre {0} sreda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sredu" }, { PluralRulesValues.Few, "za {0} srede" }, { PluralRulesValues.Other, "za {0} sreda" } })
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
									new Dictionary<int, string> { { -1, "prošlog četvrtka" }, { 0, "u četvrtak" }, { 1, "sledećeg četvrtka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} četvrtka" }, { PluralRulesValues.Few, "pre {0} četvrtka" }, { PluralRulesValues.Other, "pre {0} četvrtaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} četvrtak" }, { PluralRulesValues.Few, "za {0} četvrtka" }, { PluralRulesValues.Other, "za {0} četvrtaka" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog čet" }, { 0, "u čet" }, { 1, "sledećeg čet" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} četvrtka" }, { PluralRulesValues.Few, "pre {0} četvrtka" }, { PluralRulesValues.Other, "pre {0} četvrtaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} četvrtak" }, { PluralRulesValues.Few, "za {0} četvrtka" }, { PluralRulesValues.Other, "za {0} četvrtaka" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog čet" }, { 0, "u čet" }, { 1, "sledećeg čet" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} četvrtka" }, { PluralRulesValues.Few, "pre {0} četvrtka" }, { PluralRulesValues.Other, "pre {0} četvrtaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} četvrtak" }, { PluralRulesValues.Few, "za {0} četvrtka" }, { PluralRulesValues.Other, "za {0} četvrtaka" } })
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
									new Dictionary<int, string> { { -1, "prošlog petka" }, { 0, "u petak" }, { 1, "sledećeg petka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} petka" }, { PluralRulesValues.Few, "pre {0} petka" }, { PluralRulesValues.Other, "pre {0} petaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} petak" }, { PluralRulesValues.Few, "za {0} petka" }, { PluralRulesValues.Other, "za {0} petaka" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog pet" }, { 0, "u pet" }, { 1, "sledećeg pet" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} petka" }, { PluralRulesValues.Few, "pre {0} petka" }, { PluralRulesValues.Other, "pre {0} petaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} petak" }, { PluralRulesValues.Few, "za {0} petka" }, { PluralRulesValues.Other, "za {0} petaka" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošlog pet" }, { 0, "u pet" }, { 1, "sledećeg pet" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} petka" }, { PluralRulesValues.Few, "pre {0} petka" }, { PluralRulesValues.Other, "pre {0} petaka" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} petak" }, { PluralRulesValues.Few, "za {0} petka" }, { PluralRulesValues.Other, "za {0} petaka" } })
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
									new Dictionary<int, string> { { -1, "prošle subote" }, { 0, "u subotu" }, { 1, "sledeće subote" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} subote" }, { PluralRulesValues.Few, "pre {0} subote" }, { PluralRulesValues.Other, "pre {0} subota" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} subotu" }, { PluralRulesValues.Few, "za {0} subote" }, { PluralRulesValues.Other, "za {0} subota" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle sub" }, { 0, "u sub" }, { 1, "sledeće sub" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} subote" }, { PluralRulesValues.Few, "pre {0} subote" }, { PluralRulesValues.Other, "pre {0} subota" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} subotu" }, { PluralRulesValues.Few, "za {0} subote" }, { PluralRulesValues.Other, "za {0} subota" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "prošle sub" }, { 0, "u sub" }, { 1, "sledeće sub" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} subote" }, { PluralRulesValues.Few, "pre {0} subote" }, { PluralRulesValues.Other, "pre {0} subota" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} subotu" }, { PluralRulesValues.Few, "za {0} subote" }, { PluralRulesValues.Other, "za {0} subota" } })
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
									new Dictionary<int, string> { { 0, "ovog sata" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} sata" }, { PluralRulesValues.Few, "pre {0} sata" }, { PluralRulesValues.Other, "pre {0} sati" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sat" }, { PluralRulesValues.Few, "za {0} sata" }, { PluralRulesValues.Other, "za {0} sati" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ovog sata" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} č." }, { PluralRulesValues.Few, "pre {0} č." }, { PluralRulesValues.Other, "pre {0} č." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} č." }, { PluralRulesValues.Few, "za {0} č." }, { PluralRulesValues.Other, "za {0} č." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ovog sata" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} č." }, { PluralRulesValues.Few, "pre {0} č." }, { PluralRulesValues.Other, "pre {0} č." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} č." }, { PluralRulesValues.Few, "za {0} č." }, { PluralRulesValues.Other, "za {0} č." } })
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
									new Dictionary<int, string> { { 0, "ovog minuta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} minuta" }, { PluralRulesValues.Few, "pre {0} minuta" }, { PluralRulesValues.Other, "pre {0} minuta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} minut" }, { PluralRulesValues.Few, "za {0} minuta" }, { PluralRulesValues.Other, "za {0} minuta" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ovog minuta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} min." }, { PluralRulesValues.Few, "pre {0} min." }, { PluralRulesValues.Other, "pre {0} min." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} min." }, { PluralRulesValues.Few, "za {0} min." }, { PluralRulesValues.Other, "za {0} min." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ovog minuta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} min." }, { PluralRulesValues.Few, "pre {0} min." }, { PluralRulesValues.Other, "pre {0} min." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} min." }, { PluralRulesValues.Few, "za {0} min." }, { PluralRulesValues.Other, "za {0} min." } })
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
									new Dictionary<int, string> { { 0, "sada" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} sekunde" }, { PluralRulesValues.Few, "pre {0} sekunde" }, { PluralRulesValues.Other, "pre {0} sekundi" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sekundu" }, { PluralRulesValues.Few, "za {0} sekunde" }, { PluralRulesValues.Other, "za {0} sekundi" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "sada" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} sek." }, { PluralRulesValues.Few, "pre {0} sek." }, { PluralRulesValues.Other, "pre {0} sek." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} sek." }, { PluralRulesValues.Few, "za {0} sek." }, { PluralRulesValues.Other, "za {0} sek." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "sada" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "pre {0} s." }, { PluralRulesValues.Few, "pre {0} s." }, { PluralRulesValues.Other, "pre {0} s." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "za {0} s." }, { PluralRulesValues.Few, "za {0} s." }, { PluralRulesValues.Other, "za {0} s." } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("sr-latn-xk");
		}
	}
}