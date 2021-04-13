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
	/// Relative Time Units resource for 'French (Congo [DRC])' [fr-cd]
	/// </summary>
	public class FrCdRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public FrCdRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "l’année dernière" }, { 0, "cette année" }, { 1, "l’année prochaine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} an" }, { PluralRulesValues.Other, "il y a {0} ans" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} an" }, { PluralRulesValues.Other, "dans {0} ans" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "l’année dernière" }, { 0, "cette année" }, { 1, "l’année prochaine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} a" }, { PluralRulesValues.Other, "il y a {0} a" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} a" }, { PluralRulesValues.Other, "dans {0} a" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "l’année dernière" }, { 0, "cette année" }, { 1, "l’année prochaine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} a" }, { PluralRulesValues.Other, "-{0} a" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} a" }, { PluralRulesValues.Other, "+{0} a" } })
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
									new Dictionary<int, string> { { -1, "le trimestre dernier" }, { 0, "ce trimestre" }, { 1, "le trimestre prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} trimestre" }, { PluralRulesValues.Other, "il y a {0} trimestres" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} trimestre" }, { PluralRulesValues.Other, "dans {0} trimestres" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "le trimestre dernier" }, { 0, "ce trimestre" }, { 1, "le trimestre prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} trim." }, { PluralRulesValues.Other, "il y a {0} trim." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} trim." }, { PluralRulesValues.Other, "dans {0} trim." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "le trimestre dernier" }, { 0, "ce trimestre" }, { 1, "le trimestre prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} trim." }, { PluralRulesValues.Other, "-{0} trim." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} trim." }, { PluralRulesValues.Other, "+{0} trim." } })
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
									new Dictionary<int, string> { { -1, "le mois dernier" }, { 0, "ce mois-ci" }, { 1, "le mois prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mois" }, { PluralRulesValues.Other, "il y a {0} mois" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mois" }, { PluralRulesValues.Other, "dans {0} mois" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "le mois dernier" }, { 0, "ce mois-ci" }, { 1, "le mois prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} m." }, { PluralRulesValues.Other, "il y a {0} m." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} m." }, { PluralRulesValues.Other, "dans {0} m." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "le mois dernier" }, { 0, "ce mois-ci" }, { 1, "le mois prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} m." }, { PluralRulesValues.Other, "-{0} m." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} m." }, { PluralRulesValues.Other, "+{0} m." } })
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
									new Dictionary<int, string> { { -1, "la semaine dernière" }, { 0, "cette semaine" }, { 1, "la semaine prochaine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} semaine" }, { PluralRulesValues.Other, "il y a {0} semaines" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} semaine" }, { PluralRulesValues.Other, "dans {0} semaines" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "la semaine dernière" }, { 0, "cette semaine" }, { 1, "la semaine prochaine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} sem." }, { PluralRulesValues.Other, "il y a {0} sem." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sem." }, { PluralRulesValues.Other, "dans {0} sem." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "la semaine dernière" }, { 0, "cette semaine" }, { 1, "la semaine prochaine" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} sem." }, { PluralRulesValues.Other, "-{0} sem." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} sem." }, { PluralRulesValues.Other, "+{0} sem." } })
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
									new Dictionary<int, string> { { -2, "avant-hier" }, { -1, "hier" }, { 0, "aujourd’hui" }, { 1, "demain" }, { 2, "après-demain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jour" }, { PluralRulesValues.Other, "il y a {0} jours" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jour" }, { PluralRulesValues.Other, "dans {0} jours" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "avant-hier" }, { -1, "hier" }, { 0, "aujourd’hui" }, { 1, "demain" }, { 2, "après-demain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} j" }, { PluralRulesValues.Other, "il y a {0} j" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} j" }, { PluralRulesValues.Other, "dans {0} j" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "avant-hier" }, { -1, "hier" }, { 0, "aujourd’hui" }, { 1, "demain" }, { 2, "après-demain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} j" }, { PluralRulesValues.Other, "-{0} j" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} j" }, { PluralRulesValues.Other, "+{0} j" } })
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
									new Dictionary<int, string> { { -1, "dimanche dernier" }, { 0, "ce dimanche" }, { 1, "dimanche prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} dimanche" }, { PluralRulesValues.Other, "il y a {0} dimanches" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} dimanche" }, { PluralRulesValues.Other, "dans {0} dimanches" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "dim. dernier" }, { 0, "ce dim." }, { 1, "dim. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} dim." }, { PluralRulesValues.Other, "il y a {0} dim." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} dim." }, { PluralRulesValues.Other, "dans {0} dim." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "dim. dernier" }, { 0, "ce dim." }, { 1, "dim. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} dim." }, { PluralRulesValues.Other, "il y a {0} dim." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} dim." }, { PluralRulesValues.Other, "dans {0} dim." } })
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
									new Dictionary<int, string> { { -1, "lundi dernier" }, { 0, "ce lundi" }, { 1, "lundi prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} lundi" }, { PluralRulesValues.Other, "il y a {0} lundis" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} lundi" }, { PluralRulesValues.Other, "dans {0} lundis" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "lun. dernier" }, { 0, "ce lun." }, { 1, "lun. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} lun." }, { PluralRulesValues.Other, "il y a {0} lun." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} lun." }, { PluralRulesValues.Other, "dans {0} lun." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "lun. dernier" }, { 0, "ce lun." }, { 1, "lun. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} lun." }, { PluralRulesValues.Other, "il y a {0} lun." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} lun." }, { PluralRulesValues.Other, "dans {0} lun." } })
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
									new Dictionary<int, string> { { -1, "mardi dernier" }, { 0, "ce mardi" }, { 1, "mardi prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mardi" }, { PluralRulesValues.Other, "il y a {0} mardis" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mardi" }, { PluralRulesValues.Other, "dans {0} mardis" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mar. dernier" }, { 0, "ce mar." }, { 1, "mar. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mar." }, { PluralRulesValues.Other, "il y a {0} mar." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mar." }, { PluralRulesValues.Other, "dans {0} mar." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mar. dernier" }, { 0, "ce mar." }, { 1, "mar. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mar." }, { PluralRulesValues.Other, "il y a {0} mar." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mar." }, { PluralRulesValues.Other, "dans {0} mar." } })
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
									new Dictionary<int, string> { { -1, "mercredi dernier" }, { 0, "ce mercredi" }, { 1, "mercredi prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mercredi" }, { PluralRulesValues.Other, "il y a {0} mercredis" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mercredi" }, { PluralRulesValues.Other, "dans {0} mercredis" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mer. dernier" }, { 0, "ce mer." }, { 1, "mer. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mer." }, { PluralRulesValues.Other, "il y a {0} mer." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mer." }, { PluralRulesValues.Other, "dans {0} mer." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mer. dernier" }, { 0, "ce mer." }, { 1, "mer. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} mer." }, { PluralRulesValues.Other, "il y a {0} mer." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} mer." }, { PluralRulesValues.Other, "dans {0} mer." } })
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
									new Dictionary<int, string> { { -1, "jeudi dernier" }, { 0, "ce jeudi" }, { 1, "jeudi prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jeudi" }, { PluralRulesValues.Other, "il y a {0} jeudis" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jeudi" }, { PluralRulesValues.Other, "dans {0} jeudis" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "jeu. dernier" }, { 0, "ce jeu." }, { 1, "jeu. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jeu." }, { PluralRulesValues.Other, "il y a {0} jeu." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jeu." }, { PluralRulesValues.Other, "dans {0} jeu." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "jeu. dernier" }, { 0, "ce jeu." }, { 1, "jeu. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} jeu." }, { PluralRulesValues.Other, "il y a {0} jeu." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} jeu." }, { PluralRulesValues.Other, "dans {0} jeu." } })
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
									new Dictionary<int, string> { { -1, "vendredi dernier" }, { 0, "ce vendredi" }, { 1, "vendredi prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} vendredi" }, { PluralRulesValues.Other, "il y a {0} vendredis" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} vendredi" }, { PluralRulesValues.Other, "dans {0} vendredis" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ven. dernier" }, { 0, "ce ven." }, { 1, "ven. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} ven." }, { PluralRulesValues.Other, "il y a {0} ven." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} ven." }, { PluralRulesValues.Other, "dans {0} ven." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ven. dernier" }, { 0, "ce ven." }, { 1, "ven. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} ven." }, { PluralRulesValues.Other, "il y a {0} ven." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} ven." }, { PluralRulesValues.Other, "dans {0} ven." } })
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
									new Dictionary<int, string> { { -1, "samedi dernier" }, { 0, "ce samedi" }, { 1, "samedi prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} samedi" }, { PluralRulesValues.Other, "il y a {0} samedis" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} samedi" }, { PluralRulesValues.Other, "dans {0} samedis" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "sam. dernier" }, { 0, "ce sam." }, { 1, "sam. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sam." }, { PluralRulesValues.Other, "dans {0} sam." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sam." }, { PluralRulesValues.Other, "dans {0} sam." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "sam. dernier" }, { 0, "ce sam." }, { 1, "sam. prochain" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} sam." }, { PluralRulesValues.Other, "il y a {0} sam." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} sam." }, { PluralRulesValues.Other, "dans {0} sam." } })
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
									new Dictionary<int, string> { { 0, "cette heure-ci" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} heure" }, { PluralRulesValues.Other, "il y a {0} heures" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} heure" }, { PluralRulesValues.Other, "dans {0} heures" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "cette heure-ci" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} h" }, { PluralRulesValues.Other, "il y a {0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} h" }, { PluralRulesValues.Other, "dans {0} h" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "cette heure-ci" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} h" }, { PluralRulesValues.Other, "-{0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} h" }, { PluralRulesValues.Other, "+{0} h" } })
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
									new Dictionary<int, string> { { 0, "cette minute-ci" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} minute" }, { PluralRulesValues.Other, "il y a {0} minutes" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} minute" }, { PluralRulesValues.Other, "dans {0} minutes" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "cette minute-ci" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} min" }, { PluralRulesValues.Other, "il y a {0} min" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} min" }, { PluralRulesValues.Other, "dans {0} min" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "cette minute-ci" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} min" }, { PluralRulesValues.Other, "-{0} min" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} min" }, { PluralRulesValues.Other, "+{0} min" } })
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
									new Dictionary<int, string> { { 0, "maintenant" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} seconde" }, { PluralRulesValues.Other, "il y a {0} secondes" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} seconde" }, { PluralRulesValues.Other, "dans {0} secondes" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "maintenant" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "il y a {0} s" }, { PluralRulesValues.Other, "il y a {0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dans {0} s" }, { PluralRulesValues.Other, "dans {0} s" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "maintenant" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} s" }, { PluralRulesValues.Other, "-{0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} s" }, { PluralRulesValues.Other, "+{0} s" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("fr-cd");
		}
	}
}