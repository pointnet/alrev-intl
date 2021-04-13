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
	/// Relative Time Units resource for 'Faroese (Denmark)' [fo-dk]
	/// </summary>
	public class FoDkRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public FoDkRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "í fjør" }, { 0, "í ár" }, { 1, "næsta ár" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ár síðan" }, { PluralRulesValues.Other, "{0} ár síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} ár" }, { PluralRulesValues.Other, "um {0} ár" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "í fjør" }, { 0, "í ár" }, { 1, "næsta ár" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ár síðan" }, { PluralRulesValues.Other, "{0} ár síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} ár" }, { PluralRulesValues.Other, "um {0} ár" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "í fjør" }, { 0, "í ár" }, { 1, "næsta ár" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ár síðan" }, { PluralRulesValues.Other, "{0} ár síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} ár" }, { PluralRulesValues.Other, "um {0} ár" } })
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
									new Dictionary<int, string> { { -1, "seinasta ársfjórðing" }, { 0, "hendan ársfjórðingin" }, { 1, "næsta ársfjórðing" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ársfjórðing síðan" }, { PluralRulesValues.Other, "{0} ársfjórðingar síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} ársfjórðing" }, { PluralRulesValues.Other, "um {0} ársfjórðingar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta ársfjórðing" }, { 0, "hendan ársfjórðingin" }, { 1, "næsta ársfjórðing" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ársfj. síðan" }, { PluralRulesValues.Other, "{0} ársfj. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} ársfj." }, { PluralRulesValues.Other, "um {0} ársfj." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta ársfjórðing" }, { 0, "hendan ársfjórðingin" }, { 1, "næsta ársfjórðing" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ársfj. síðan" }, { PluralRulesValues.Other, "{0} ársfj. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} ársfj." }, { PluralRulesValues.Other, "um {0} ársfj." } })
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
									new Dictionary<int, string> { { -1, "seinasta mánað" }, { 0, "henda mánaðin" }, { 1, "næsta mánað" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mánað síðan" }, { PluralRulesValues.Other, "{0} mánaðir síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} mánað" }, { PluralRulesValues.Other, "um {0} mánaðir" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta mnð." }, { 0, "henda mnð." }, { 1, "næsta mnð." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mnð. síðan" }, { PluralRulesValues.Other, "{0} mnð. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} mnð." }, { PluralRulesValues.Other, "um {0} mnð." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta mnð." }, { 0, "henda mnð." }, { 1, "næsta mnð." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mnð. síðan" }, { PluralRulesValues.Other, "{0} mnð. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} mnð." }, { PluralRulesValues.Other, "um {0} mnð." } })
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
									new Dictionary<int, string> { { -1, "seinastu viku" }, { 0, "hesu viku" }, { 1, "næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vika síðan" }, { PluralRulesValues.Other, "{0} vikur síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} viku" }, { PluralRulesValues.Other, "um {0} vikur" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinastu vi." }, { 0, "hesu vi." }, { 1, "næstu vi." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vi. síðan" }, { PluralRulesValues.Other, "{0} vi. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} vi." }, { PluralRulesValues.Other, "um {0} vi." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinastu v." }, { 0, "hesu v." }, { 1, "næstu v." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} v. síðan" }, { PluralRulesValues.Other, "{0} v. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} v." }, { PluralRulesValues.Other, "um {0} v." } })
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
									new Dictionary<int, string> { { -2, "fyrradagin" }, { -1, "í gjár" }, { 0, "í dag" }, { 1, "í morgin" }, { 2, "í ovurmorgin" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dagur síðan" }, { PluralRulesValues.Other, "{0} dagar síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} dag" }, { PluralRulesValues.Other, "um {0} dagar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "fyrradagin" }, { -1, "í gjár" }, { 0, "í dag" }, { 1, "í morgin" }, { 2, "í ovurmorgin" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} da. síðan" }, { PluralRulesValues.Other, "{0} da. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} da." }, { PluralRulesValues.Other, "um {0} da." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "fyrradagin" }, { -1, "í gjár" }, { 0, "í dag" }, { 1, "í morgin" }, { 2, "í ovurmorgin" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} d. síðan" }, { PluralRulesValues.Other, "{0} d. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} d." }, { PluralRulesValues.Other, "um {0} d." } })
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
									new Dictionary<int, string> { { -1, "seinasta sunnudag" }, { 0, "næsta sunnudag" }, { 1, "sunnudagin í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sunnudag síðani" }, { PluralRulesValues.Other, "{0} sunnudagar síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} sunnudag" }, { PluralRulesValues.Other, "um {0} sunnudagar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta sun." }, { 0, "næsta sun." }, { 1, "sun. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sun. síðani" }, { PluralRulesValues.Other, "{0} sun. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} sun." }, { PluralRulesValues.Other, "um {0} sun." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta su." }, { 0, "næsta su." }, { 1, "su. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} su. síðani" }, { PluralRulesValues.Other, "{0} su. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} su." }, { PluralRulesValues.Other, "um {0} su." } })
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
									new Dictionary<int, string> { { -1, "seinasta mánadag" }, { 0, "næsta mánadag" }, { 1, "mánadagin í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mánadag síðani" }, { PluralRulesValues.Other, "{0} mánadagar síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} mánadag" }, { PluralRulesValues.Other, "um {0} mánadagar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta mán." }, { 0, "næsta mán." }, { 1, "mán. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mán. síðani" }, { PluralRulesValues.Other, "{0} mán. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} mán." }, { PluralRulesValues.Other, "um {0} mán." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta má." }, { 0, "næsta má." }, { 1, "má. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} má. síðani" }, { PluralRulesValues.Other, "{0} má. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} má." }, { PluralRulesValues.Other, "um {0} má." } })
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
									new Dictionary<int, string> { { -1, "seinasta týsdag" }, { 0, "næsta týsdag" }, { 1, "týsdagin í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} týsdag síðani" }, { PluralRulesValues.Other, "{0} týsdagar síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} týsdag" }, { PluralRulesValues.Other, "um {0} týsdagar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta týs." }, { 0, "næsta týs." }, { 1, "týs. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} týs. síðani" }, { PluralRulesValues.Other, "{0} týs. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} týs." }, { PluralRulesValues.Other, "um {0} týs." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta tý." }, { 0, "næsta tý." }, { 1, "tý. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tý. síðani" }, { PluralRulesValues.Other, "{0} tý. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} tý." }, { PluralRulesValues.Other, "um {0} tý." } })
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
									new Dictionary<int, string> { { -1, "seinasta mikudag" }, { 0, "næsta mikudag" }, { 1, "mikudagin í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mikudag síðani" }, { PluralRulesValues.Other, "{0} mikudagar síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} mikudag" }, { PluralRulesValues.Other, "um {0} mikudagar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta mik." }, { 0, "næsta mik." }, { 1, "mik. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mik. síðani" }, { PluralRulesValues.Other, "{0} mik. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} mik." }, { PluralRulesValues.Other, "um {0} mik." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta mi." }, { 0, "næsta mi." }, { 1, "mi. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} mi. síðani" }, { PluralRulesValues.Other, "{0} mi. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} mi." }, { PluralRulesValues.Other, "um {0} mi." } })
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
									new Dictionary<int, string> { { -1, "seinasta hósdag" }, { 0, "næsta hósdag" }, { 1, "hósdagin í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hósdag síðani" }, { PluralRulesValues.Other, "{0} hósdagar síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} hósdag" }, { PluralRulesValues.Other, "um {0} hósdagar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta hós." }, { 0, "næsta hós." }, { 1, "hós. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hós. síðani" }, { PluralRulesValues.Other, "{0} hós. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} hós." }, { PluralRulesValues.Other, "um {0} hós." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta hó." }, { 0, "næsta hó." }, { 1, "hó. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hó. síðani" }, { PluralRulesValues.Other, "{0} hó. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} hó." }, { PluralRulesValues.Other, "um {0} hó." } })
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
									new Dictionary<int, string> { { -1, "seinasta fríggjadag" }, { 0, "næsta fríggjadag" }, { 1, "fríggjadagin í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} fríggjadag síðani" }, { PluralRulesValues.Other, "{0} fríggjadagar síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} fríggjadag" }, { PluralRulesValues.Other, "um {0} fríggjadagar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta frí." }, { 0, "næsta frí." }, { 1, "frí. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} frí. síðani" }, { PluralRulesValues.Other, "{0} frí. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} frí." }, { PluralRulesValues.Other, "um {0} frí." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta fr." }, { 0, "næsta fr." }, { 1, "fr. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} fr. síðani" }, { PluralRulesValues.Other, "{0} fr. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} fr." }, { PluralRulesValues.Other, "um {0} fr." } })
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
									new Dictionary<int, string> { { -1, "seinasta leygardag" }, { 0, "næsta leygardag" }, { 1, "leygardagin í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} leygardag síðani" }, { PluralRulesValues.Other, "{0} leygardagar síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} leygardag" }, { PluralRulesValues.Other, "um {0} leygardagar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta ley." }, { 0, "næsta ley." }, { 1, "ley. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ley. síðani" }, { PluralRulesValues.Other, "{0} ley. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} ley." }, { PluralRulesValues.Other, "um {0} ley." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seinasta le." }, { 0, "næsta le." }, { 1, "le. í næstu viku" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} le. síðani" }, { PluralRulesValues.Other, "{0} le. síðani" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} le." }, { PluralRulesValues.Other, "um {0} le." } })
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
									new Dictionary<int, string> { { 0, "hendan tíman" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tími síðan" }, { PluralRulesValues.Other, "{0} tímar síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} tíma" }, { PluralRulesValues.Other, "um {0} tímar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "hendan tíman" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t. síðan" }, { PluralRulesValues.Other, "{0} t. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} t." }, { PluralRulesValues.Other, "um {0} t." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "hendan tíman" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t. síðan" }, { PluralRulesValues.Other, "{0} t. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} t." }, { PluralRulesValues.Other, "um {0} t." } })
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
									new Dictionary<int, string> { { 0, "hendan minuttin" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minutt síðan" }, { PluralRulesValues.Other, "{0} minuttir síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} minutt" }, { PluralRulesValues.Other, "um {0} minuttir" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "hendan minuttin" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. síðan" }, { PluralRulesValues.Other, "{0} min. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} min." }, { PluralRulesValues.Other, "um {0} min." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "hendan minuttin" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} m. síðan" }, { PluralRulesValues.Other, "{0} m. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} m." }, { PluralRulesValues.Other, "um {0} m." } })
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
									new Dictionary<int, string> { { 0, "nú" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekund síðan" }, { PluralRulesValues.Other, "{0} sekund síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} sekund" }, { PluralRulesValues.Other, "um {0} sekund" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "nú" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek. síðan" }, { PluralRulesValues.Other, "{0} sek. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} sek." }, { PluralRulesValues.Other, "um {0} sek." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "nú" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} s. síðan" }, { PluralRulesValues.Other, "{0} s. síðan" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "um {0} s." }, { PluralRulesValues.Other, "um {0} s." } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("fo-dk");
		}
	}
}