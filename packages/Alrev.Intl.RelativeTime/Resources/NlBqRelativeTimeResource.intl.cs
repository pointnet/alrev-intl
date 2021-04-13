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
	/// Relative Time Units resource for 'Dutch (Bonaire, Sint Eustatius and Saba)' [nl-bq]
	/// </summary>
	public class NlBqRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public NlBqRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "vorig jaar" }, { 0, "dit jaar" }, { 1, "volgend jaar" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jaar geleden" }, { PluralRulesValues.Other, "{0} jaar geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} jaar" }, { PluralRulesValues.Other, "over {0} jaar" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vorig jaar" }, { 0, "dit jaar" }, { 1, "volgend jaar" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jaar geleden" }, { PluralRulesValues.Other, "{0} jaar geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} jaar" }, { PluralRulesValues.Other, "over {0} jaar" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vorig jaar" }, { 0, "dit jaar" }, { 1, "volgend jaar" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} jaar geleden" }, { PluralRulesValues.Other, "{0} jaar geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} jaar" }, { PluralRulesValues.Other, "over {0} jaar" } })
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
									new Dictionary<int, string> { { -1, "vorig kwartaal" }, { 0, "dit kwartaal" }, { 1, "volgend kwartaal" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kwartaal geleden" }, { PluralRulesValues.Other, "{0} kwartalen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} kwartaal" }, { PluralRulesValues.Other, "over {0} kwartalen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vorig kwartaal" }, { 0, "dit kwartaal" }, { 1, "volgend kwartaal" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kwartaal geleden" }, { PluralRulesValues.Other, "{0} kwartalen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} kwartaal" }, { PluralRulesValues.Other, "over {0} kwartalen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vorig kwartaal" }, { 0, "dit kwartaal" }, { 1, "volgend kwartaal" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kwartaal geleden" }, { PluralRulesValues.Other, "{0} kwartalen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} kw." }, { PluralRulesValues.Other, "over {0} kwartalen" } })
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
									new Dictionary<int, string> { { -1, "vorige maand" }, { 0, "deze maand" }, { 1, "volgende maand" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maand geleden" }, { PluralRulesValues.Other, "{0} maanden geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maand" }, { PluralRulesValues.Other, "over {0} maanden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vorige maand" }, { 0, "deze maand" }, { 1, "volgende maand" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maand geleden" }, { PluralRulesValues.Other, "{0} maanden geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maand" }, { PluralRulesValues.Other, "over {0} maanden" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vorige maand" }, { 0, "deze maand" }, { 1, "volgende maand" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maand geleden" }, { PluralRulesValues.Other, "{0} maanden geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maand" }, { PluralRulesValues.Other, "over {0} maanden" } })
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
									new Dictionary<int, string> { { -1, "vorige week" }, { 0, "deze week" }, { 1, "volgende week" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} week geleden" }, { PluralRulesValues.Other, "{0} weken geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} week" }, { PluralRulesValues.Other, "over {0} weken" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vorige week" }, { 0, "deze week" }, { 1, "volgende week" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} week geleden" }, { PluralRulesValues.Other, "{0} weken geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} week" }, { PluralRulesValues.Other, "over {0} weken" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "vorige week" }, { 0, "deze week" }, { 1, "volgende week" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} week geleden" }, { PluralRulesValues.Other, "{0} weken geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} week" }, { PluralRulesValues.Other, "over {0} weken" } })
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
									new Dictionary<int, string> { { -2, "eergisteren" }, { -1, "gisteren" }, { 0, "vandaag" }, { 1, "morgen" }, { 2, "overmorgen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag geleden" }, { PluralRulesValues.Other, "{0} dagen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dag" }, { PluralRulesValues.Other, "over {0} dagen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "eergisteren" }, { -1, "gisteren" }, { 0, "vandaag" }, { 1, "morgen" }, { 2, "overmorgen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag geleden" }, { PluralRulesValues.Other, "{0} dgn geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dag" }, { PluralRulesValues.Other, "over {0} dgn" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "eergisteren" }, { -1, "gisteren" }, { 0, "vandaag" }, { 1, "morgen" }, { 2, "overmorgen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dag geleden" }, { PluralRulesValues.Other, "{0} dgn geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dag" }, { PluralRulesValues.Other, "over {0} dgn" } })
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
									new Dictionary<int, string> { { -1, "afgelopen zondag" }, { 0, "deze zondag" }, { 1, "volgende week zondag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zondag geleden" }, { PluralRulesValues.Other, "{0} zondagen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zondag" }, { PluralRulesValues.Other, "over {0} zondagen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen zon." }, { 0, "deze zon." }, { 1, "volgende week zon." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zon. geleden" }, { PluralRulesValues.Other, "{0} zon. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zon." }, { PluralRulesValues.Other, "over {0} zon." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen zo" }, { 0, "deze zo" }, { 1, "volgende week zo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zo geleden" }, { PluralRulesValues.Other, "{0} zo geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zo" }, { PluralRulesValues.Other, "over {0} zo" } })
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
									new Dictionary<int, string> { { -1, "afgelopen maandag" }, { 0, "deze maandag" }, { 1, "volgende week maandag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maandag geleden" }, { PluralRulesValues.Other, "{0} maandagen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maandag" }, { PluralRulesValues.Other, "over {0} maandagen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen maan." }, { 0, "deze maan." }, { 1, "volgende week maan." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} maan. geleden" }, { PluralRulesValues.Other, "{0} maan. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} maan." }, { PluralRulesValues.Other, "over {0} maan." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen ma" }, { 0, "deze ma" }, { 1, "volgende week ma" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ma geleden" }, { PluralRulesValues.Other, "{0} ma geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} ma" }, { PluralRulesValues.Other, "over {0} ma" } })
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
									new Dictionary<int, string> { { -1, "afgelopen dinsdag" }, { 0, "deze dinsdag" }, { 1, "volgende week dinsdag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dinsdag geleden" }, { PluralRulesValues.Other, "{0} dinsdagen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dinsdag" }, { PluralRulesValues.Other, "over {0} dinsdagen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen dins." }, { 0, "deze dins." }, { 1, "volgende week dins." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} dins. geleden" }, { PluralRulesValues.Other, "{0} dins. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} dins." }, { PluralRulesValues.Other, "over {0} dins." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen di" }, { 0, "deze di" }, { 1, "volgende week di" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} di geleden" }, { PluralRulesValues.Other, "{0} di geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} di" }, { PluralRulesValues.Other, "over {0} di" } })
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
									new Dictionary<int, string> { { -1, "afgelopen woensdag" }, { 0, "deze woensdag" }, { 1, "volgende week woensdag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} woensdag geleden" }, { PluralRulesValues.Other, "{0} woensdagen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} woensdag" }, { PluralRulesValues.Other, "over {0} woensdagen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen woens." }, { 0, "deze woens." }, { 1, "volgende week woens." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} woens. geleden" }, { PluralRulesValues.Other, "{0} woens. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} woens." }, { PluralRulesValues.Other, "over {0} woens." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen wo" }, { 0, "deze wo" }, { 1, "volgende week wo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} wo geleden" }, { PluralRulesValues.Other, "{0} wo geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} wo" }, { PluralRulesValues.Other, "over {0} wo" } })
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
									new Dictionary<int, string> { { -1, "afgelopen donderdag" }, { 0, "deze donderdag" }, { 1, "volgende week donderdag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} donderdag geleden" }, { PluralRulesValues.Other, "{0} donderdagen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} donderdag" }, { PluralRulesValues.Other, "over {0} donderdagen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen donder." }, { 0, "deze donder." }, { 1, "volgende week donder." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} donder. geleden" }, { PluralRulesValues.Other, "{0} donder. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} donder." }, { PluralRulesValues.Other, "over {0} donder." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen do" }, { 0, "deze do" }, { 1, "volgende week do" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} do geleden" }, { PluralRulesValues.Other, "{0} do geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} do" }, { PluralRulesValues.Other, "over {0} do" } })
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
									new Dictionary<int, string> { { -1, "afgelopen vrijdag" }, { 0, "deze vrijdag" }, { 1, "volgende week vrijdag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vrijdag geleden" }, { PluralRulesValues.Other, "{0} vrijdagen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} vrijdag" }, { PluralRulesValues.Other, "over {0} vrijdagen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen vrij." }, { 0, "deze vrij." }, { 1, "volgende week vrij." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vrij. geleden" }, { PluralRulesValues.Other, "{0} vrij. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} vrij." }, { PluralRulesValues.Other, "over {0} vrij." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen vr" }, { 0, "deze vr" }, { 1, "volgende week vr" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vr geleden" }, { PluralRulesValues.Other, "{0} vr geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} vr" }, { PluralRulesValues.Other, "over {0} vr" } })
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
									new Dictionary<int, string> { { -1, "afgelopen zaterdag" }, { 0, "deze zaterdag" }, { 1, "volgende week zaterdag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zaterdag geleden" }, { PluralRulesValues.Other, "{0} zaterdagen geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zaterdag" }, { PluralRulesValues.Other, "over {0} zaterdagen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen zater." }, { 0, "deze zater." }, { 1, "volgende week zater." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} zater. geleden" }, { PluralRulesValues.Other, "{0} zater. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} zater." }, { PluralRulesValues.Other, "over {0} zater." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "afgelopen za" }, { 0, "deze za" }, { 1, "volgende week za" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} za geleden" }, { PluralRulesValues.Other, "{0} za geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} za" }, { PluralRulesValues.Other, "over {0} za" } })
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
									new Dictionary<int, string> { { 0, "binnen een uur" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} uur geleden" }, { PluralRulesValues.Other, "{0} uur geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} uur" }, { PluralRulesValues.Other, "over {0} uur" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "binnen een uur" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} uur geleden" }, { PluralRulesValues.Other, "{0} uur geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} uur" }, { PluralRulesValues.Other, "over {0} uur" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "binnen een uur" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} uur geleden" }, { PluralRulesValues.Other, "{0} uur geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} uur" }, { PluralRulesValues.Other, "over {0} uur" } })
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
									new Dictionary<int, string> { { 0, "binnen een minuut" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuut geleden" }, { PluralRulesValues.Other, "{0} minuten geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} minuut" }, { PluralRulesValues.Other, "over {0} minuten" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "binnen een minuut" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. geleden" }, { PluralRulesValues.Other, "{0} min. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} min." }, { PluralRulesValues.Other, "over {0} min." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "binnen een minuut" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. geleden" }, { PluralRulesValues.Other, "{0} min. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} min." }, { PluralRulesValues.Other, "over {0} min." } })
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
									new Dictionary<int, string> { { 0, "nu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} seconde geleden" }, { PluralRulesValues.Other, "{0} seconden geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} seconde" }, { PluralRulesValues.Other, "over {0} seconden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "nu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sec. geleden" }, { PluralRulesValues.Other, "{0} sec. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} sec." }, { PluralRulesValues.Other, "over {0} sec." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "nu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sec. geleden" }, { PluralRulesValues.Other, "{0} sec. geleden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "over {0} sec." }, { PluralRulesValues.Other, "over {0} sec." } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("nl-bq");
		}
	}
}