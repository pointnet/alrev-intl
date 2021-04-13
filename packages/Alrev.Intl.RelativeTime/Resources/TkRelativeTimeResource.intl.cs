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
	/// Relative Time Units resource for 'Turkmen' [tk]
	/// </summary>
	public class TkRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public TkRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "geçen ýyl" }, { 0, "şu ýyl" }, { 1, "indiki ýyl" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ýyl öň" }, { PluralRulesValues.Other, "{0} ýyl öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ýyldan" }, { PluralRulesValues.Other, "{0} ýyldan" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen ýyl" }, { 0, "şu ýyl" }, { 1, "indiki ýyl" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ý. öň" }, { PluralRulesValues.Other, "{0} ý. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ý-dan" }, { PluralRulesValues.Other, "{0} ý-dan" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen ýyl" }, { 0, "şu ýyl" }, { 1, "indiki ýyl" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ý. öň" }, { PluralRulesValues.Other, "{0} ý. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ý-dan" }, { PluralRulesValues.Other, "{0} ý-dan" } })
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
									new Dictionary<int, string> { { -1, "geçen çärýek" }, { 0, "şu çärýek" }, { 1, "indiki çärýek" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çärýek öň" }, { PluralRulesValues.Other, "{0} çärýek öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çärýekden" }, { PluralRulesValues.Other, "{0} çärýekden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen çärýek" }, { 0, "şu çärýek" }, { 1, "indiki çärýek" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çär. öň" }, { PluralRulesValues.Other, "{0} çär. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çär-den" }, { PluralRulesValues.Other, "{0} çär-den" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen çärýek" }, { 0, "şu çärýek" }, { 1, "indiki çärýek" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ç. öň" }, { PluralRulesValues.Other, "{0} ç. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ç-den" }, { PluralRulesValues.Other, "{0} ç-den" } })
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
									new Dictionary<int, string> { { -1, "geçen aý" }, { 0, "şu aý" }, { 1, "indiki aý" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} aý öň" }, { PluralRulesValues.Other, "{0} aý öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} aýdan" }, { PluralRulesValues.Other, "{0} aýdan" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen aý" }, { 0, "şu aý" }, { 1, "indiki aý" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} aý öň" }, { PluralRulesValues.Other, "{0} aý öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} aýdan" }, { PluralRulesValues.Other, "{0} aýdan" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen aý" }, { 0, "şu aý" }, { 1, "indiki aý" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} aý öň" }, { PluralRulesValues.Other, "{0} aý öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} aýdan" }, { PluralRulesValues.Other, "{0} aýdan" } })
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
									new Dictionary<int, string> { { -1, "geçen hepde" }, { 0, "şu hepde" }, { 1, "indiki hepde" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hepde öň" }, { PluralRulesValues.Other, "{0} hepde öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hepdeden" }, { PluralRulesValues.Other, "{0} hepdeden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen hepde" }, { 0, "şu hepde" }, { 1, "indiki hepde" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hep. öň" }, { PluralRulesValues.Other, "{0} hep. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} hep-den" }, { PluralRulesValues.Other, "{0} hep-den" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen hepde" }, { 0, "şu hepde" }, { 1, "indiki hepde" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} h. öň" }, { PluralRulesValues.Other, "{0} h. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} h-den" }, { PluralRulesValues.Other, "{0} h-den" } })
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
									new Dictionary<int, string> { { -1, "düýn" }, { 0, "şu gün" }, { 1, "ertir" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} gün öň" }, { PluralRulesValues.Other, "{0} gün öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} günden" }, { PluralRulesValues.Other, "{0} günden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "düýn" }, { 0, "şu gün" }, { 1, "ertir" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} g. öň" }, { PluralRulesValues.Other, "{0} g. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} g-den" }, { PluralRulesValues.Other, "{0} g-den" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "düýn" }, { 0, "şu gün" }, { 1, "ertir" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} g. öň" }, { PluralRulesValues.Other, "{0} g. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} g-den" }, { PluralRulesValues.Other, "{0} g-den" } })
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
									new Dictionary<int, string> { { -1, "geçen ýekşenbe" }, { 0, "şu ýekşenbe" }, { 1, "indiki ýekşenbe" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ýekşenbe öň" }, { PluralRulesValues.Other, "{0} ýekşenbe öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ýekşenbeden" }, { PluralRulesValues.Other, "{0} ýekşenbe" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen ýek." }, { 0, "şu ýek." }, { 1, "indiki ýek." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ýek. öň" }, { PluralRulesValues.Other, "{0} ýek. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ýek-den" }, { PluralRulesValues.Other, "{0} ýek-den" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen ýb" }, { 0, "şu ýb" }, { 1, "indiki ýb" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ýb öň" }, { PluralRulesValues.Other, "{0} ýb öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ýb.-den" }, { PluralRulesValues.Other, "{0} ýb.-den" } })
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
									new Dictionary<int, string> { { -1, "geçen duşenbe" }, { 0, "şu duşenbe" }, { 1, "indiki duşenbe" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} duşenbe öň" }, { PluralRulesValues.Other, "{0} duşenbe öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} duşenbeden" }, { PluralRulesValues.Other, "{0} duşenbeden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen duş." }, { 0, "şu duş." }, { 1, "indiki duş." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} duş. öň" }, { PluralRulesValues.Other, "{0} duş. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} duş-den" }, { PluralRulesValues.Other, "{0} duş-den" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen db" }, { 0, "şu db" }, { 1, "indiki db" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} db öň" }, { PluralRulesValues.Other, "{0} db öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} db-den" }, { PluralRulesValues.Other, "{0} db-den" } })
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
									new Dictionary<int, string> { { -1, "geçen sişenbe" }, { 0, "şu sişenbe" }, { 1, "indiki sişenbe" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sişenbe öň" }, { PluralRulesValues.Other, "{0} sişenbe öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sişenbeden" }, { PluralRulesValues.Other, "{0} sişenbeden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen siş." }, { 0, "şu siş." }, { 1, "indiki siş." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} siş. öň" }, { PluralRulesValues.Other, "{0} siş. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} siş-den" }, { PluralRulesValues.Other, "{0} siş-den" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen sb" }, { 0, "şu sb" }, { 1, "indiki sb" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sb öň" }, { PluralRulesValues.Other, "{0} sb öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sb-den" }, { PluralRulesValues.Other, "{0} sb-den" } })
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
									new Dictionary<int, string> { { -1, "geçen çarşenbe" }, { 0, "şu çarşenbe" }, { 1, "indiki çarşenbe" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çarşenbe öň" }, { PluralRulesValues.Other, "{0} çarşenbe öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çarşenbeden" }, { PluralRulesValues.Other, "{0} çarşenbeden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen çar." }, { 0, "şu çar." }, { 1, "indiki çar." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çar. öň" }, { PluralRulesValues.Other, "{0} çar. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çar-den" }, { PluralRulesValues.Other, "{0} çar-den" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen çb" }, { 0, "şu çb" }, { 1, "indiki çb" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çb öň" }, { PluralRulesValues.Other, "{0} çb öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} çb-den" }, { PluralRulesValues.Other, "{0} çb-den" } })
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
									new Dictionary<int, string> { { -1, "geçen penşenbe" }, { 0, "şu penşenbe" }, { 1, "indiki penşenbe" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} penşenbe öň" }, { PluralRulesValues.Other, "{0} penşenbe öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} penşenbeden" }, { PluralRulesValues.Other, "{0} penşenbeden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen pen." }, { 0, "şu pen." }, { 1, "indiki pen." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pen. öň" }, { PluralRulesValues.Other, "{0} pen. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pen-den" }, { PluralRulesValues.Other, "{0} pen-den" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen pb" }, { 0, "şu pb" }, { 1, "indiki pb" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pb öň" }, { PluralRulesValues.Other, "{0} pb öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pb-den" }, { PluralRulesValues.Other, "{0} pb-den" } })
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
									new Dictionary<int, string> { { -1, "geçen anna" }, { 0, "şu anna" }, { 1, "indiki anna" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} anna öň" }, { PluralRulesValues.Other, "{0} anna öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} annadan" }, { PluralRulesValues.Other, "{0} annadan" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen an." }, { 0, "şu an." }, { 1, "indiki an." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} an. öň" }, { PluralRulesValues.Other, "{0} an. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} an-dan" }, { PluralRulesValues.Other, "{0} an-dan" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen an" }, { 0, "şu an" }, { 1, "indiki an" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} an öň" }, { PluralRulesValues.Other, "{0} an öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} an-dan" }, { PluralRulesValues.Other, "{0} an-dan" } })
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
									new Dictionary<int, string> { { -1, "geçen şenbe" }, { 0, "şu şenbe" }, { 1, "indiki şenbe" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} şenbe öň" }, { PluralRulesValues.Other, "{0} şenbe öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} şenbeden" }, { PluralRulesValues.Other, "{0} şenbeden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen şen." }, { 0, "şu şen." }, { 1, "indiki şen." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} şen. öň" }, { PluralRulesValues.Other, "{0} şen. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} şen-den" }, { PluralRulesValues.Other, "{0} şen-den" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "geçen şb" }, { 0, "şu şb" }, { 1, "indiki şb" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} şb öň" }, { PluralRulesValues.Other, "{0} şb öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} şb-den" }, { PluralRulesValues.Other, "{0} şb-den" } })
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
									new Dictionary<int, string> { { 0, "şu sagat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sagat öň" }, { PluralRulesValues.Other, "{0} sagat öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sagatdan" }, { PluralRulesValues.Other, "{0} sagatdan" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "şu sagat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sag. öň" }, { PluralRulesValues.Other, "{0} sag. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sag-dan" }, { PluralRulesValues.Other, "{0} sag-dan" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "şu sagat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sag. öň" }, { PluralRulesValues.Other, "{0} sag. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sag-dan" }, { PluralRulesValues.Other, "{0} sag-dan" } })
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
									new Dictionary<int, string> { { 0, "şu minut" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minut öň" }, { PluralRulesValues.Other, "{0} minut öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minutdan" }, { PluralRulesValues.Other, "{0} minutdan" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "şu minut" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. öň" }, { PluralRulesValues.Other, "{0} min. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min-dan" }, { PluralRulesValues.Other, "{0} min-dan" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "şu minut" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min. öň" }, { PluralRulesValues.Other, "{0} min. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min-dan" }, { PluralRulesValues.Other, "{0} min-dan" } })
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
									new Dictionary<int, string> { { 0, "häzir" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekunt öň" }, { PluralRulesValues.Other, "{0} sekunt öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekuntdan" }, { PluralRulesValues.Other, "{0} sekuntdan" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "häzir" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek. öň" }, { PluralRulesValues.Other, "{0} sek. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek-dan" }, { PluralRulesValues.Other, "{0} sek-dan" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "häzir" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek. öň" }, { PluralRulesValues.Other, "{0} sek. öň" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek-dan" }, { PluralRulesValues.Other, "{0} sek-dan" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("tk");
		}
	}
}