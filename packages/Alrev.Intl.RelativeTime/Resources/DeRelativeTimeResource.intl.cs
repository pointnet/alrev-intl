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
	/// Relative Time Units resource for 'German' [de]
	/// </summary>
	public class DeRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public DeRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "letztes Jahr" }, { 0, "dieses Jahr" }, { 1, "nächstes Jahr" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Jahr" }, { PluralRulesValues.Other, "vor {0} Jahren" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Jahr" }, { PluralRulesValues.Other, "in {0} Jahren" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letztes Jahr" }, { 0, "dieses Jahr" }, { 1, "nächstes Jahr" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Jahr" }, { PluralRulesValues.Other, "vor {0} Jahren" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Jahr" }, { PluralRulesValues.Other, "in {0} Jahren" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letztes Jahr" }, { 0, "dieses Jahr" }, { 1, "nächstes Jahr" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Jahr" }, { PluralRulesValues.Other, "vor {0} Jahren" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Jahr" }, { PluralRulesValues.Other, "in {0} Jahren" } })
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
									new Dictionary<int, string> { { -1, "letztes Quartal" }, { 0, "dieses Quartal" }, { 1, "nächstes Quartal" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Quartal" }, { PluralRulesValues.Other, "vor {0} Quartalen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Quartal" }, { PluralRulesValues.Other, "in {0} Quartalen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letztes Quartal" }, { 0, "dieses Quartal" }, { 1, "nächstes Quartal" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Quart." }, { PluralRulesValues.Other, "vor {0} Quart." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Quart." }, { PluralRulesValues.Other, "in {0} Quart." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letztes Quartal" }, { 0, "dieses Quartal" }, { 1, "nächstes Quartal" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Q" }, { PluralRulesValues.Other, "vor {0} Q" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Q" }, { PluralRulesValues.Other, "in {0} Q" } })
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
									new Dictionary<int, string> { { -1, "letzten Monat" }, { 0, "diesen Monat" }, { 1, "nächsten Monat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Monat" }, { PluralRulesValues.Other, "vor {0} Monaten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Monat" }, { PluralRulesValues.Other, "in {0} Monaten" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Monat" }, { 0, "diesen Monat" }, { 1, "nächsten Monat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Monat" }, { PluralRulesValues.Other, "vor {0} Monaten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Monat" }, { PluralRulesValues.Other, "in {0} Monaten" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Monat" }, { 0, "diesen Monat" }, { 1, "nächsten Monat" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Monat" }, { PluralRulesValues.Other, "vor {0} Monaten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Monat" }, { PluralRulesValues.Other, "in {0} Monaten" } })
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
									new Dictionary<int, string> { { -1, "letzte Woche" }, { 0, "diese Woche" }, { 1, "nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Woche" }, { PluralRulesValues.Other, "vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Woche" }, { PluralRulesValues.Other, "in {0} Wochen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzte Woche" }, { 0, "diese Woche" }, { 1, "nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Woche" }, { PluralRulesValues.Other, "vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Woche" }, { PluralRulesValues.Other, "in {0} Wochen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzte Woche" }, { 0, "diese Woche" }, { 1, "nächste Woche" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Wo." }, { PluralRulesValues.Other, "vor {0} Wo." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Wo." }, { PluralRulesValues.Other, "in {0} Wo." } })
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
									new Dictionary<int, string> { { -2, "vorgestern" }, { -1, "gestern" }, { 0, "heute" }, { 1, "morgen" }, { 2, "übermorgen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Tag" }, { PluralRulesValues.Other, "vor {0} Tagen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Tag" }, { PluralRulesValues.Other, "in {0} Tagen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "vorgestern" }, { -1, "gestern" }, { 0, "heute" }, { 1, "morgen" }, { 2, "übermorgen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Tag" }, { PluralRulesValues.Other, "vor {0} Tagen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Tag" }, { PluralRulesValues.Other, "in {0} Tagen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "vorgestern" }, { -1, "gestern" }, { 0, "heute" }, { 1, "morgen" }, { 2, "übermorgen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Tag" }, { PluralRulesValues.Other, "vor {0} Tagen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Tag" }, { PluralRulesValues.Other, "in {0} Tagen" } })
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
									new Dictionary<int, string> { { -1, "letzten Sonntag" }, { 0, "diesen Sonntag" }, { 1, "nächsten Sonntag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Sonntag vor {0} Woche" }, { PluralRulesValues.Other, "Sonntag vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Sonntag in {0} Woche" }, { PluralRulesValues.Other, "Sonntag in {0} Wochen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten So." }, { 0, "diesen So." }, { 1, "nächsten So." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "So. vor {0} Woche" }, { PluralRulesValues.Other, "So. vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "So. in {0} Woche" }, { PluralRulesValues.Other, "So. in {0} Wochen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten So." }, { 0, "diesen So." }, { 1, "nächsten So." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "So. vor {0} W." }, { PluralRulesValues.Other, "So. vor {0} W." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "So. in {0} W." }, { PluralRulesValues.Other, "So. in {0} W." } })
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
									new Dictionary<int, string> { { -1, "letzten Montag" }, { 0, "diesen Montag" }, { 1, "nächsten Montag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Montag vor {0} Woche" }, { PluralRulesValues.Other, "Montag vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Montag in {0} Woche" }, { PluralRulesValues.Other, "Montag in {0} Wochen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Mo." }, { 0, "diesen Mo." }, { 1, "nächsten Mo." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mo. vor {0} Woche" }, { PluralRulesValues.Other, "Mo. vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mo. in {0} Woche" }, { PluralRulesValues.Other, "Mo. in {0} Wochen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Mo." }, { 0, "diesen Mo." }, { 1, "nächsten Mo." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mo. vor {0} W." }, { PluralRulesValues.Other, "Mo. vor {0} W." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mo. in {0} W." }, { PluralRulesValues.Other, "Mo. in {0} W." } })
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
									new Dictionary<int, string> { { -1, "letzten Dienstag" }, { 0, "diesen Dienstag" }, { 1, "nächsten Dienstag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Dienstag vor {0} Woche" }, { PluralRulesValues.Other, "Dienstag vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Dienstag in {0} Woche" }, { PluralRulesValues.Other, "Dienstag in {0} Wochen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Di." }, { 0, "diesen Di." }, { 1, "nächsten Di." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Di. vor {0} Woche" }, { PluralRulesValues.Other, "Di. vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Di. in {0} Woche" }, { PluralRulesValues.Other, "Di. in {0} Wochen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Di." }, { 0, "diesen Di." }, { 1, "nächsten Di." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Di. vor {0} W." }, { PluralRulesValues.Other, "Di. vor {0} W." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Di. in {0} W." }, { PluralRulesValues.Other, "Di. in {0} W." } })
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
									new Dictionary<int, string> { { -1, "letzten Mittwoch" }, { 0, "diesen Mittwoch" }, { 1, "nächsten Mittwoch" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mittwoch vor {0} Woche" }, { PluralRulesValues.Other, "Mittwoch vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mittwoch in {0} Woche" }, { PluralRulesValues.Other, "Mittwoch in {0} Wochen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Mi." }, { 0, "diesen Mi." }, { 1, "nächsten Mi." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mi. vor {0} Woche" }, { PluralRulesValues.Other, "Mi. vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mi. in {0} Woche" }, { PluralRulesValues.Other, "Mi. in {0} Wochen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Mi." }, { 0, "diesen Mi." }, { 1, "nächsten Mi." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mi. vor {0} W." }, { PluralRulesValues.Other, "Mi. vor {0} W." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Mi. in {0} W." }, { PluralRulesValues.Other, "Mi. in {0} W." } })
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
									new Dictionary<int, string> { { -1, "letzten Donnerstag" }, { 0, "diesen Donnerstag" }, { 1, "nächsten Donnerstag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Donnerstag vor {0} Woche" }, { PluralRulesValues.Other, "Donnerstag vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Donnerstag in {0} Woche" }, { PluralRulesValues.Other, "Donnerstag in {0} Wochen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Do." }, { 0, "diesen Do." }, { 1, "nächsten Do." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Do. vor {0} Woche" }, { PluralRulesValues.Other, "Do. vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Do. in {0} Woche" }, { PluralRulesValues.Other, "Do. in {0} Wochen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Do." }, { 0, "diesen Do." }, { 1, "nächsten Do." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Do. vor {0} W." }, { PluralRulesValues.Other, "Do. vor {0} W." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Do. in {0} W." }, { PluralRulesValues.Other, "Do. in {0} W." } })
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
									new Dictionary<int, string> { { -1, "letzten Freitag" }, { 0, "diesen Freitag" }, { 1, "nächsten Freitag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Freitag vor {0} Woche" }, { PluralRulesValues.Other, "Freitag vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Freitag in {0} Woche" }, { PluralRulesValues.Other, "Freitag in {0} Wochen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Fr." }, { 0, "diesen Fr." }, { 1, "nächsten Fr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Fr. vor {0} Woche" }, { PluralRulesValues.Other, "Fr. vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Fr. in {0} Woche" }, { PluralRulesValues.Other, "Fr. in {0} Wochen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Fr." }, { 0, "diesen Fr." }, { 1, "nächsten Fr." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Fr. vor {0} W." }, { PluralRulesValues.Other, "Fr. vor {0} W." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Fr. in {0} W." }, { PluralRulesValues.Other, "Fr. in {0} W." } })
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
									new Dictionary<int, string> { { -1, "letzten Samstag" }, { 0, "diesen Samstag" }, { 1, "nächsten Samstag" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Samstag vor {0} Woche" }, { PluralRulesValues.Other, "Samstag vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Samstag in {0} Woche" }, { PluralRulesValues.Other, "Samstag in {0} Wochen" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Sa." }, { 0, "diesen Sa." }, { 1, "nächsten Sa." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Sa. vor {0} Woche" }, { PluralRulesValues.Other, "Sa. vor {0} Wochen" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Sa. in {0} Woche" }, { PluralRulesValues.Other, "Sa. in {0} Wochen" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "letzten Sa." }, { 0, "diesen Sa." }, { 1, "nächsten Sa." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Sa. vor {0} W." }, { PluralRulesValues.Other, "Sa. vor {0} W." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "Sa. in {0} W." }, { PluralRulesValues.Other, "Sa. in {0} W." } })
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
									new Dictionary<int, string> { { 0, "in dieser Stunde" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Stunde" }, { PluralRulesValues.Other, "vor {0} Stunden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Stunde" }, { PluralRulesValues.Other, "in {0} Stunden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "in dieser Stunde" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Std." }, { PluralRulesValues.Other, "vor {0} Std." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Std." }, { PluralRulesValues.Other, "in {0} Std." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "in dieser Stunde" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Std." }, { PluralRulesValues.Other, "vor {0} Std." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Std." }, { PluralRulesValues.Other, "in {0} Std." } })
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
									new Dictionary<int, string> { { 0, "in dieser Minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Minute" }, { PluralRulesValues.Other, "vor {0} Minuten" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Minute" }, { PluralRulesValues.Other, "in {0} Minuten" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "in dieser Minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Min." }, { PluralRulesValues.Other, "vor {0} Min." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Min." }, { PluralRulesValues.Other, "in {0} Min." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "in dieser Minute" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} m" }, { PluralRulesValues.Other, "vor {0} m" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} m" }, { PluralRulesValues.Other, "in {0} m" } })
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
									new Dictionary<int, string> { { 0, "jetzt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Sekunde" }, { PluralRulesValues.Other, "vor {0} Sekunden" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sekunde" }, { PluralRulesValues.Other, "in {0} Sekunden" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "jetzt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} Sek." }, { PluralRulesValues.Other, "vor {0} Sek." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} Sek." }, { PluralRulesValues.Other, "in {0} Sek." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "jetzt" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "vor {0} s" }, { PluralRulesValues.Other, "vor {0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "in {0} s" }, { PluralRulesValues.Other, "in {0} s" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("de");
		}
	}
}