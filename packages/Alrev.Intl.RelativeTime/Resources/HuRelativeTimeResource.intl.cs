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
	/// Relative Time Units resource for 'Hungarian' [hu]
	/// </summary>
	public class HuRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public HuRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "előző év" }, { 0, "ez az év" }, { 1, "következő év" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} évvel ezelőtt" }, { PluralRulesValues.Other, "{0} évvel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} év múlva" }, { PluralRulesValues.Other, "{0} év múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző év" }, { 0, "ez az év" }, { 1, "következő év" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} évvel ezelőtt" }, { PluralRulesValues.Other, "{0} évvel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} év múlva" }, { PluralRulesValues.Other, "{0} év múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző év" }, { 0, "ez az év" }, { 1, "következő év" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} évvel ezelőtt" }, { PluralRulesValues.Other, "{0} évvel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} év múlva" }, { PluralRulesValues.Other, "{0} év múlva" } })
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
									new Dictionary<int, string> { { -1, "előző negyedév" }, { 0, "ez a negyedév" }, { 1, "következő negyedév" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} negyedévvel ezelőtt" }, { PluralRulesValues.Other, "{0} negyedévvel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} negyedév múlva" }, { PluralRulesValues.Other, "{0} negyedév múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző negyedév" }, { 0, "ez a negyedév" }, { 1, "következő negyedév" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} negyedévvel ezelőtt" }, { PluralRulesValues.Other, "{0} negyedévvel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} negyedév múlva" }, { PluralRulesValues.Other, "{0} negyedév múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző negyedév" }, { 0, "ez a negyedév" }, { 1, "következő negyedév" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} negyedévvel ezelőtt" }, { PluralRulesValues.Other, "{0} negyedévvel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} n.év múlva" }, { PluralRulesValues.Other, "{0} n.év múlva" } })
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
									new Dictionary<int, string> { { -1, "előző hónap" }, { 0, "ez a hónap" }, { 1, "következő hónap" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hónappal ezelőtt" }, { PluralRulesValues.Other, "{0} hónappal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hónap múlva" }, { PluralRulesValues.Other, "{0} hónap múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző hónap" }, { 0, "ez a hónap" }, { 1, "következő hónap" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hónappal ezelőtt" }, { PluralRulesValues.Other, "{0} hónappal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hónap múlva" }, { PluralRulesValues.Other, "{0} hónap múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző hónap" }, { 0, "ez a hónap" }, { 1, "következő hónap" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hónappal ezelőtt" }, { PluralRulesValues.Other, "{0} hónappal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hónap múlva" }, { PluralRulesValues.Other, "{0} hónap múlva" } })
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
									new Dictionary<int, string> { { -1, "előző hét" }, { 0, "ez a hét" }, { 1, "következő hét" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} héttel ezelőtt" }, { PluralRulesValues.Other, "{0} héttel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hét múlva" }, { PluralRulesValues.Other, "{0} hét múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző hét" }, { 0, "ez a hét" }, { 1, "következő hét" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} héttel ezelőtt" }, { PluralRulesValues.Other, "{0} héttel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hét múlva" }, { PluralRulesValues.Other, "{0} hét múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző hét" }, { 0, "ez a hét" }, { 1, "következő hét" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} héttel ezelőtt" }, { PluralRulesValues.Other, "{0} héttel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hét múlva" }, { PluralRulesValues.Other, "{0} hét múlva" } })
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
									new Dictionary<int, string> { { -2, "tegnapelőtt" }, { -1, "tegnap" }, { 0, "ma" }, { 1, "holnap" }, { 2, "holnapután" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} nappal ezelőtt" }, { PluralRulesValues.Other, "{0} nappal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} nap múlva" }, { PluralRulesValues.Other, "{0} nap múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "tegnapelőtt" }, { -1, "tegnap" }, { 0, "ma" }, { 1, "holnap" }, { 2, "holnapután" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} napja" }, { PluralRulesValues.Other, "{0} napja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} nap múlva" }, { PluralRulesValues.Other, "{0} nap múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "tegnapelőtt" }, { -1, "tegnap" }, { 0, "ma" }, { 1, "holnap" }, { 2, "holnapután" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} napja" }, { PluralRulesValues.Other, "{0} napja" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} nap múlva" }, { PluralRulesValues.Other, "{0} nap múlva" } })
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
									new Dictionary<int, string> { { -1, "előző vasárnap" }, { 0, "ez a vasárnap" }, { 1, "következő vasárnap" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vasárnappal ezelőtt" }, { PluralRulesValues.Other, "{0} vasárnappal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vasárnap múlva" }, { PluralRulesValues.Other, "{0} vasárnap múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző vasárnap" }, { 0, "ez a vasárnap" }, { 1, "következő vasárnap" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vasárnappal ezelőtt" }, { PluralRulesValues.Other, "{0} vasárnappal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vasárnap múlva" }, { PluralRulesValues.Other, "{0} vasárnap múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző vasárnap" }, { 0, "ez a vasárnap" }, { 1, "következő vasárnap" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vasárnappal ezelőtt" }, { PluralRulesValues.Other, "{0} vasárnappal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} vasárnap múlva" }, { PluralRulesValues.Other, "{0} vasárnap múlva" } })
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
									new Dictionary<int, string> { { -1, "előző hétfő" }, { 0, "ez a hétfő" }, { 1, "következő hétfő" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hétfővel ezelőtt" }, { PluralRulesValues.Other, "{0} hétfővel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hétfő múlva" }, { PluralRulesValues.Other, "{0} hétfő múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző hétfő" }, { 0, "ez a hétfő" }, { 1, "következő hétfő" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hétfővel ezelőtt" }, { PluralRulesValues.Other, "{0} hétfővel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hétfő múlva" }, { PluralRulesValues.Other, "{0} hétfő múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző hétfő" }, { 0, "ez a hétfő" }, { 1, "következő hétfő" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hétfővel ezelőtt" }, { PluralRulesValues.Other, "{0} hétfővel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hétfő múlva" }, { PluralRulesValues.Other, "{0} hétfő múlva" } })
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
									new Dictionary<int, string> { { -1, "előző kedd" }, { 0, "ez a kedd" }, { 1, "következő kedd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} keddel ezelőtt" }, { PluralRulesValues.Other, "{0} keddel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kedd múlva" }, { PluralRulesValues.Other, "{0} kedd múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző kedd" }, { 0, "ez a kedd" }, { 1, "következő kedd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} keddel ezelőtt" }, { PluralRulesValues.Other, "{0} keddel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kedd múlva" }, { PluralRulesValues.Other, "{0} kedd múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző kedd" }, { 0, "ez a kedd" }, { 1, "következő kedd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} keddel ezelőtt" }, { PluralRulesValues.Other, "{0} keddel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kedd múlva" }, { PluralRulesValues.Other, "{0} kedd múlva" } })
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
									new Dictionary<int, string> { { -1, "előző szerda" }, { 0, "ez a szerda" }, { 1, "következő szerda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szerdával ezelőtt" }, { PluralRulesValues.Other, "{0} szerdával ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szerda múlva" }, { PluralRulesValues.Other, "{0} szerda múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző szerda" }, { 0, "ez a szerda" }, { 1, "következő szerda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szerdával ezelőtt" }, { PluralRulesValues.Other, "{0} szerdával ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szerda múlva" }, { PluralRulesValues.Other, "{0} szerda múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző szerda" }, { 0, "ez a szerda" }, { 1, "következő szerda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szerdával ezelőtt" }, { PluralRulesValues.Other, "{0} szerdával ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szerda múlva" }, { PluralRulesValues.Other, "{0} szerda múlva" } })
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
									new Dictionary<int, string> { { -1, "előző csütörtök" }, { 0, "ez a csütörtök" }, { 1, "következő csütörtök" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} csütörtökkel ezelőtt" }, { PluralRulesValues.Other, "{0} csütörtökkel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} csütörtök múlva" }, { PluralRulesValues.Other, "{0} csütörtök múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző csütörtök" }, { 0, "ez a csütörtök" }, { 1, "következő csütörtök" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} csütörtökkel ezelőtt" }, { PluralRulesValues.Other, "{0} csütörtökkel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} csütörtök múlva" }, { PluralRulesValues.Other, "{0} csütörtök múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző csütörtök" }, { 0, "ez a csütörtök" }, { 1, "következő csütörtök" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} csütörtökkel ezelőtt" }, { PluralRulesValues.Other, "{0} csütörtökkel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} csütörtök múlva" }, { PluralRulesValues.Other, "{0} csütörtök múlva" } })
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
									new Dictionary<int, string> { { -1, "előző péntek" }, { 0, "ez a péntek" }, { 1, "következő péntek" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} péntekkel ezelőtt" }, { PluralRulesValues.Other, "{0} péntekkel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} péntek múlva" }, { PluralRulesValues.Other, "{0} péntek múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző péntek" }, { 0, "ez a péntek" }, { 1, "következő péntek" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} péntekkel ezelőtt" }, { PluralRulesValues.Other, "{0} péntekkel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} péntek múlva" }, { PluralRulesValues.Other, "{0} péntek múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző péntek" }, { 0, "ez a péntek" }, { 1, "következő péntek" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} péntekkel ezelőtt" }, { PluralRulesValues.Other, "{0} péntekkel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} péntek múlva" }, { PluralRulesValues.Other, "{0} péntek múlva" } })
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
									new Dictionary<int, string> { { -1, "előző szombat" }, { 0, "ez a szombat" }, { 1, "következő szombat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szombattal ezelőtt" }, { PluralRulesValues.Other, "{0} szombattal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szombat múlva" }, { PluralRulesValues.Other, "{0} szombat múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző szombat" }, { 0, "ez a szombat" }, { 1, "következő szombat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szombattal ezelőtt" }, { PluralRulesValues.Other, "{0} szombattal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szombat múlva" }, { PluralRulesValues.Other, "{0} szombat múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "előző szombat" }, { 0, "ez a szombat" }, { 1, "következő szombat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szombattal ezelőtt" }, { PluralRulesValues.Other, "{0} szombattal ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} szombat múlva" }, { PluralRulesValues.Other, "{0} szombat múlva" } })
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
									new Dictionary<int, string> { { 0, "ebben az órában" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} órával ezelőtt" }, { PluralRulesValues.Other, "{0} órával ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} óra múlva" }, { PluralRulesValues.Other, "{0} óra múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ebben az órában" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} órával ezelőtt" }, { PluralRulesValues.Other, "{0} órával ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} óra múlva" }, { PluralRulesValues.Other, "{0} óra múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ebben az órában" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} órával ezelőtt" }, { PluralRulesValues.Other, "{0} órával ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} óra múlva" }, { PluralRulesValues.Other, "{0} óra múlva" } })
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
									new Dictionary<int, string> { { 0, "ebben a percben" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perccel ezelőtt" }, { PluralRulesValues.Other, "{0} perccel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perc múlva" }, { PluralRulesValues.Other, "{0} perc múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ebben a percben" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perccel ezelőtt" }, { PluralRulesValues.Other, "{0} perccel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perc múlva" }, { PluralRulesValues.Other, "{0} perc múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ebben a percben" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perccel ezelőtt" }, { PluralRulesValues.Other, "{0} perccel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} perc múlva" }, { PluralRulesValues.Other, "{0} perc múlva" } })
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
									new Dictionary<int, string> { { 0, "most" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} másodperccel ezelőtt" }, { PluralRulesValues.Other, "{0} másodperccel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} másodperc múlva" }, { PluralRulesValues.Other, "{0} másodperc múlva" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "most" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} másodperccel ezelőtt" }, { PluralRulesValues.Other, "{0} másodperccel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} másodperc múlva" }, { PluralRulesValues.Other, "{0} másodperc múlva" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "most" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} másodperccel ezelőtt" }, { PluralRulesValues.Other, "{0} másodperccel ezelőtt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} másodperc múlva" }, { PluralRulesValues.Other, "{0} másodperc múlva" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("hu");
		}
	}
}