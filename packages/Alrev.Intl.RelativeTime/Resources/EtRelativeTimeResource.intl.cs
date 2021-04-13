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
	/// Relative Time Units resource for 'Estonian' [et]
	/// </summary>
	public class EtRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public EtRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "eelmine aasta" }, { 0, "käesolev aasta" }, { 1, "järgmine aasta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} aasta eest" }, { PluralRulesValues.Other, "{0} aasta eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} aasta pärast" }, { PluralRulesValues.Other, "{0} aasta pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine a" }, { 0, "käesolev a" }, { 1, "järgmine a" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} a eest" }, { PluralRulesValues.Other, "{0} a eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} a pärast" }, { PluralRulesValues.Other, "{0} a pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelm. a" }, { 0, "see a" }, { 1, "järgm. a" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} a eest" }, { PluralRulesValues.Other, "{0} a eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} a pärast" }, { PluralRulesValues.Other, "{0} a pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine kvartal" }, { 0, "käesolev kvartal" }, { 1, "järgmine kvartal" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kvartali eest" }, { PluralRulesValues.Other, "{0} kvartali eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kvartali pärast" }, { PluralRulesValues.Other, "{0} kvartali pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine kv" }, { 0, "käesolev kv" }, { 1, "järgmine kv" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kv eest" }, { PluralRulesValues.Other, "{0} kv eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kv pärast" }, { PluralRulesValues.Other, "{0} kv pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine kv" }, { 0, "käesolev kv" }, { 1, "järgmine kv" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kv eest" }, { PluralRulesValues.Other, "{0} kv eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kv pärast" }, { PluralRulesValues.Other, "{0} kv pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine kuu" }, { 0, "käesolev kuu" }, { 1, "järgmine kuu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kuu eest" }, { PluralRulesValues.Other, "{0} kuu eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kuu pärast" }, { PluralRulesValues.Other, "{0} kuu pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelm. kuu" }, { 0, "see kuu" }, { 1, "järgm. kuu" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kuu eest" }, { PluralRulesValues.Other, "{0} kuu eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kuu pärast" }, { PluralRulesValues.Other, "{0} kuu pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelm. k" }, { 0, "see k" }, { 1, "järgm. k" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} k eest" }, { PluralRulesValues.Other, "{0} k eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} k pärast" }, { PluralRulesValues.Other, "{0} k pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine nädal" }, { 0, "käesolev nädal" }, { 1, "järgmine nädal" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} nädala eest" }, { PluralRulesValues.Other, "{0} nädala eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} nädala pärast" }, { PluralRulesValues.Other, "{0} nädala pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelm. näd" }, { 0, "see näd" }, { 1, "järgm. näd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} näd eest" }, { PluralRulesValues.Other, "{0} näd eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} näd pärast" }, { PluralRulesValues.Other, "{0} näd pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelm. n" }, { 0, "see n" }, { 1, "järgm. n" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} näd eest" }, { PluralRulesValues.Other, "{0} näd eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} näd pärast" }, { PluralRulesValues.Other, "{0} näd pärast" } })
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
									new Dictionary<int, string> { { -2, "üleeile" }, { -1, "eile" }, { 0, "täna" }, { 1, "homme" }, { 2, "ülehomme" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} päeva eest" }, { PluralRulesValues.Other, "{0} päeva eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} päeva pärast" }, { PluralRulesValues.Other, "{0} päeva pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "üleeile" }, { -1, "eile" }, { 0, "täna" }, { 1, "homme" }, { 2, "ülehomme" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} p eest" }, { PluralRulesValues.Other, "{0} p eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} p pärast" }, { PluralRulesValues.Other, "{0} p pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "üleeile" }, { -1, "eile" }, { 0, "täna" }, { 1, "homme" }, { 2, "ülehomme" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} p eest" }, { PluralRulesValues.Other, "{0} p eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} p pärast" }, { PluralRulesValues.Other, "{0} p pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine pühapäev" }, { 0, "käesolev pühapäev" }, { 1, "järgmine pühapäev" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pühapäeva eest" }, { PluralRulesValues.Other, "{0} pühapäeva eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pühapäeva pärast" }, { PluralRulesValues.Other, "{0} pühapäeva pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine pühap" }, { 0, "käesolev pühap" }, { 1, "järgmine pühap" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pühap eest" }, { PluralRulesValues.Other, "{0} pühap pärast" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} pühap pärast" }, { PluralRulesValues.Other, "{0} pühap pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine P" }, { 0, "käesolev P" }, { 1, "järgmine P" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} P eest" }, { PluralRulesValues.Other, "{0} P eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} P pärast" }, { PluralRulesValues.Other, "{0} P pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine esmaspäev" }, { 0, "käesolev esmaspäev" }, { 1, "järgmine esmaspäev" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} esmaspäeva eest" }, { PluralRulesValues.Other, "{0} esmaspäeva eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} esmaspäeva pärast" }, { PluralRulesValues.Other, "{0} esmaspäeva pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine esmasp" }, { 0, "käesolev esmasp" }, { 1, "järgmine esmasp" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} esmasp eest" }, { PluralRulesValues.Other, "{0} esmasp eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} esmasp pärast" }, { PluralRulesValues.Other, "{0} esmasp pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine E" }, { 0, "käesolev E" }, { 1, "järgmine E" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} E eest" }, { PluralRulesValues.Other, "{0} E eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} E pärast" }, { PluralRulesValues.Other, "{0} E pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine teisipäev" }, { 0, "käesolev teisipäev" }, { 1, "järgmine teisipäev" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} teisipäeva eest" }, { PluralRulesValues.Other, "{0} teisipäeva eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} teisipäeva pärast" }, { PluralRulesValues.Other, "{0} teisipäeva pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine teisip" }, { 0, "käesolev teisip" }, { 1, "järgmine teisip" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} teisip eest" }, { PluralRulesValues.Other, "{0} teisip eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} teisip pärast" }, { PluralRulesValues.Other, "{0} teisip pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine T" }, { 0, "käesolev T" }, { 1, "järgmine T" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} T eest" }, { PluralRulesValues.Other, "{0} T eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} T pärast" }, { PluralRulesValues.Other, "{0} T pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine kolmapäev" }, { 0, "käesolev kolmapäev" }, { 1, "järgmine kolmapäev" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kolmapäeva eest" }, { PluralRulesValues.Other, "{0} kolmapäeva eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kolmapäeva pärast" }, { PluralRulesValues.Other, "{0} kolmapäeva pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine kolmap" }, { 0, "käesolev kolmap" }, { 1, "järgmine kolmap" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kolmap eest" }, { PluralRulesValues.Other, "{0} kolmap eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} kolmap pärast" }, { PluralRulesValues.Other, "{0} kolmap pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine K" }, { 0, "käesolev K" }, { 1, "järgmine K" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} K eest" }, { PluralRulesValues.Other, "{0} K eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} K pärast" }, { PluralRulesValues.Other, "{0} K pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine neljapäev" }, { 0, "käesolev neljapäev" }, { 1, "järgmine neljapäev" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} neljapäeva eest" }, { PluralRulesValues.Other, "{0} neljapäeva eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} neljapäeva pärast" }, { PluralRulesValues.Other, "{0} neljapäeva pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine neljap" }, { 0, "käesolev neljap" }, { 1, "järgmine neljap" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} neljap eest" }, { PluralRulesValues.Other, "{0} neljap eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} neljap pärast" }, { PluralRulesValues.Other, "{0} neljap pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine N" }, { 0, "käesolev N" }, { 1, "järgmine N" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} N eest" }, { PluralRulesValues.Other, "{0} N eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} N pärast" }, { PluralRulesValues.Other, "{0} N pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine reede" }, { 0, "käesolev reede" }, { 1, "järgmine reede" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} reede eest" }, { PluralRulesValues.Other, "{0} reede eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} reede pärast" }, { PluralRulesValues.Other, "{0} reede pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine reede" }, { 0, "käesolev reede" }, { 1, "järgmine reede" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} reede eest" }, { PluralRulesValues.Other, "{0} reede eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} reede pärast" }, { PluralRulesValues.Other, "{0} reede pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine R" }, { 0, "käesolev R" }, { 1, "järgmine R" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} R eest" }, { PluralRulesValues.Other, "{0} R eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} R pärast" }, { PluralRulesValues.Other, "{0} R pärast" } })
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
									new Dictionary<int, string> { { -1, "eelmine laupäev" }, { 0, "käesolev laupäev" }, { 1, "järgmine laupäev" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} laupäeva eest" }, { PluralRulesValues.Other, "{0} laupäeva eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} laupäeva pärast" }, { PluralRulesValues.Other, "{0} laupäeva pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine laup" }, { 0, "käesolev laup" }, { 1, "järgmine laup" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} laup eest" }, { PluralRulesValues.Other, "{0} laup eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} laup pärast" }, { PluralRulesValues.Other, "{0} laup pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "eelmine L" }, { 0, "käesolev L" }, { 1, "järgmine L" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} L eest" }, { PluralRulesValues.Other, "{0} L eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} L pärast" }, { PluralRulesValues.Other, "{0} L pärast" } })
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
									new Dictionary<int, string> { { 0, "praegusel tunnil" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tunni eest" }, { PluralRulesValues.Other, "{0} tunni eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} tunni pärast" }, { PluralRulesValues.Other, "{0} tunni pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "praegusel tunnil" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t eest" }, { PluralRulesValues.Other, "{0} t eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t pärast" }, { PluralRulesValues.Other, "{0} t pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "praegusel tunnil" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t eest" }, { PluralRulesValues.Other, "{0} t eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} t pärast" }, { PluralRulesValues.Other, "{0} t pärast" } })
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
									new Dictionary<int, string> { { 0, "praegusel minutil" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuti eest" }, { PluralRulesValues.Other, "{0} minuti eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} minuti pärast" }, { PluralRulesValues.Other, "{0} minuti pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "praegusel minutil" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min eest" }, { PluralRulesValues.Other, "{0} min eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min pärast" }, { PluralRulesValues.Other, "{0} min pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "praegusel minutil" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min eest" }, { PluralRulesValues.Other, "{0} min eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} min pärast" }, { PluralRulesValues.Other, "{0} min pärast" } })
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
									new Dictionary<int, string> { { 0, "nüüd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekundi eest" }, { PluralRulesValues.Other, "{0} sekundi eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sekundi pärast" }, { PluralRulesValues.Other, "{0} sekundi pärast" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "nüüd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek eest" }, { PluralRulesValues.Other, "{0} sek eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} sek pärast" }, { PluralRulesValues.Other, "{0} sek pärast" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "nüüd" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} s eest" }, { PluralRulesValues.Other, "{0} s eest" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} s pärast" }, { PluralRulesValues.Other, "{0} s pärast" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("et");
		}
	}
}