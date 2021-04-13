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
	/// Relative Time Units resource for 'Greek' [el]
	/// </summary>
	public class ElRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public ElRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "πέρσι" }, { 0, "φέτος" }, { 1, "επόμενο έτος" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} έτος" }, { PluralRulesValues.Other, "πριν από {0} έτη" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} έτος" }, { PluralRulesValues.Other, "σε {0} έτη" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "πέρσι" }, { 0, "φέτος" }, { 1, "επόμενο έτος" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} έτος" }, { PluralRulesValues.Other, "πριν από {0} έτη" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} έτος" }, { PluralRulesValues.Other, "σε {0} έτη" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "πέρσι" }, { 0, "φέτος" }, { 1, "επόμενο έτος" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} έτος πριν" }, { PluralRulesValues.Other, "{0} έτη πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} έτος" }, { PluralRulesValues.Other, "σε {0} έτη" } })
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
									new Dictionary<int, string> { { -1, "προηγούμενο τρίμηνο" }, { 0, "τρέχον τρίμηνο" }, { 1, "επόμενο τρίμηνο" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} τρίμηνο" }, { PluralRulesValues.Other, "πριν από {0} τρίμηνα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} τρίμηνο" }, { PluralRulesValues.Other, "σε {0} τρίμηνα" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. τρίμ." }, { 0, "τρέχον τρίμ." }, { 1, "επόμ. τρίμ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} τρίμ." }, { PluralRulesValues.Other, "πριν από {0} τρίμ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} τρίμ." }, { PluralRulesValues.Other, "σε {0} τρίμ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. τρίμ." }, { 0, "τρέχον τρίμ." }, { 1, "επόμ. τρίμ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} τρίμ. πριν" }, { PluralRulesValues.Other, "{0} τρίμ. πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} τρίμ." }, { PluralRulesValues.Other, "σε {0} τρίμ." } })
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
									new Dictionary<int, string> { { -1, "προηγούμενος μήνας" }, { 0, "τρέχων μήνας" }, { 1, "επόμενος μήνας" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} μήνα" }, { PluralRulesValues.Other, "πριν από {0} μήνες" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} μήνα" }, { PluralRulesValues.Other, "σε {0} μήνες" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγούμενος μήνας" }, { 0, "τρέχων μήνας" }, { 1, "επόμενος μήνας" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} μήνα" }, { PluralRulesValues.Other, "πριν από {0} μήνες" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} μήνα" }, { PluralRulesValues.Other, "σε {0} μήνες" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. μήνας" }, { 0, "τρέχ. μήνας" }, { 1, "επόμ. μήνας" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} μ. πριν" }, { PluralRulesValues.Other, "{0} μ. πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} μ." }, { PluralRulesValues.Other, "σε {0} μ." } })
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
									new Dictionary<int, string> { { -1, "προηγούμενη εβδομάδα" }, { 0, "τρέχουσα εβδομάδα" }, { 1, "επόμενη εβδομάδα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} εβδομάδα" }, { PluralRulesValues.Other, "πριν από {0} εβδομάδες" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} εβδομάδα" }, { PluralRulesValues.Other, "σε {0} εβδομάδες" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. εβδομάδα" }, { 0, "τρέχ. εβδομάδα" }, { 1, "επόμ. εβδομάδα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} εβδ." }, { PluralRulesValues.Other, "πριν από {0} εβδ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} εβδ." }, { PluralRulesValues.Other, "σε {0} εβδ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. εβδ." }, { 0, "τρέχ. εβδ." }, { 1, "επόμ. εβδ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} εβδ. πριν" }, { PluralRulesValues.Other, "{0} εβδ. πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} εβδ." }, { PluralRulesValues.Other, "σε {0} εβδ." } })
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
									new Dictionary<int, string> { { -2, "προχθές" }, { -1, "χθες" }, { 0, "σήμερα" }, { 1, "αύριο" }, { 2, "μεθαύριο" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} ημέρα" }, { PluralRulesValues.Other, "πριν από {0} ημέρες" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} ημέρα" }, { PluralRulesValues.Other, "σε {0} ημέρες" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "προχθές" }, { -1, "χθες" }, { 0, "σήμερα" }, { 1, "αύριο" }, { 2, "μεθαύριο" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} ημ." }, { PluralRulesValues.Other, "πριν από {0} ημ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} ημ." }, { PluralRulesValues.Other, "σε {0} ημ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "προχθές" }, { -1, "χθες" }, { 0, "σήμερα" }, { 1, "αύριο" }, { 2, "μεθαύριο" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ημ. πριν" }, { PluralRulesValues.Other, "{0} ημ. πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} ημ." }, { PluralRulesValues.Other, "σε {0} ημ." } })
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
									new Dictionary<int, string> { { -1, "προηγούμενη Κυριακή" }, { 0, "αυτήν την Κυριακή" }, { 1, "επόμενη Κυριακή" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Κυριακή" }, { PluralRulesValues.Other, "πριν από {0} Κυριακές" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Κυριακή" }, { PluralRulesValues.Other, "σε {0} Κυριακές" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Κυρ." }, { 0, "αυτήν την Κυρ." }, { 1, "επόμ. Κυρ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Κυρ." }, { PluralRulesValues.Other, "πριν από {0} Κυρ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Κυρ." }, { PluralRulesValues.Other, "σε {0} Κυρ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Κυ" }, { 0, "αυτήν την Κυ" }, { 1, "επόμ. Κυ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Κυ πριν" }, { PluralRulesValues.Other, "{0} Κυ πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Κυ" }, { PluralRulesValues.Other, "σε {0} Κυ" } })
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
									new Dictionary<int, string> { { -1, "προηγούμενη Δευτέρα" }, { 0, "αυτήν τη Δευτέρα" }, { 1, "επόμενη Δευτέρα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Δευτέρα" }, { PluralRulesValues.Other, "πριν από {0} Δευτέρες" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Δευτέρα" }, { PluralRulesValues.Other, "σε {0} Δευτέρες" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Δευτ." }, { 0, "αυτήν τη Δευτ." }, { 1, "επόμ. Δευτ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Δευτ." }, { PluralRulesValues.Other, "πριν από {0} Δευτ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Δευτ." }, { PluralRulesValues.Other, "σε {0} Δευτ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Δε" }, { 0, "αυτήν τη Δε" }, { 1, "επόμ. Δε" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Δε πριν" }, { PluralRulesValues.Other, "{0} Δε πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Δε" }, { PluralRulesValues.Other, "σε {0} Δε" } })
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
									new Dictionary<int, string> { { -1, "προηγούμενη Τρίτη" }, { 0, "αυτήν την Τρίτη" }, { 1, "επόμενη Τρίτη" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Τρίτη" }, { PluralRulesValues.Other, "πριν από {0} Τρίτες" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Τρίτη" }, { PluralRulesValues.Other, "σε {0} Τρίτες" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Τρ." }, { 0, "αυτήν την Τρ." }, { 1, "επόμ. Τρ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Τρ." }, { PluralRulesValues.Other, "πριν από {0} Τρ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Τρ." }, { PluralRulesValues.Other, "σε {0} Τρ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Τρ" }, { 0, "αυτήν την Τρ" }, { 1, "επόμ. Τρ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Τρ πριν" }, { PluralRulesValues.Other, "{0} Τρ πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Τρ" }, { PluralRulesValues.Other, "σε {0} Τρ" } })
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
									new Dictionary<int, string> { { -1, "προηγούμενη Τετάρτη" }, { 0, "αυτήν την Τετάρτη" }, { 1, "επόμενη Τετάρτη" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Τετάρτη" }, { PluralRulesValues.Other, "πριν από {0} Τετάρτες" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Τετάρτη" }, { PluralRulesValues.Other, "σε {0} Τετάρτες" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Τετ." }, { 0, "αυτήν την Τετ." }, { 1, "επόμ. Τετ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Τετ." }, { PluralRulesValues.Other, "πριν από {0} Τετ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Τετ." }, { PluralRulesValues.Other, "σε {0} Τετ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Τε" }, { 0, "αυτήν την Τε" }, { 1, "επόμ. Τε" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Τε πριν" }, { PluralRulesValues.Other, "{0} Τε πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Τε" }, { PluralRulesValues.Other, "σε {0} Τε" } })
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
									new Dictionary<int, string> { { -1, "προηγούμενη Πέμπτη" }, { 0, "αυτήν την Πέμπτη" }, { 1, "επόμενη Πέμπτη" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Πέμπτη" }, { PluralRulesValues.Other, "πριν από {0} Πέμπτες" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Πέμπτη" }, { PluralRulesValues.Other, "σε {0} Πέμπτες" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Πέμ." }, { 0, "αυτήν την Πέμ." }, { 1, "επόμ. Πέμ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Πέμ." }, { PluralRulesValues.Other, "πριν από {0} Πέμ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Πέμ." }, { PluralRulesValues.Other, "σε {0} Πέμ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Πέ" }, { 0, "αυτήν την Πέ" }, { 1, "επόμ. Πέ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Πέ πριν" }, { PluralRulesValues.Other, "{0} Πέ πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Πέ" }, { PluralRulesValues.Other, "σε {0} Πέ" } })
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
									new Dictionary<int, string> { { -1, "προηγούμενη Παρασκευή" }, { 0, "αυτήν την Παρασκευή" }, { 1, "επόμενη Παρασκευή" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Παρασκευή" }, { PluralRulesValues.Other, "πριν από {0} Παρασκευές" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Παρασκευή" }, { PluralRulesValues.Other, "σε {0} Παρασκευές" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Παρ." }, { 0, "αυτήν την Παρ." }, { 1, "επόμ. Παρ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Παρ." }, { PluralRulesValues.Other, "πριν από {0} Παρ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Παρ." }, { PluralRulesValues.Other, "σε {0} Παρ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Πα" }, { 0, "αυτήν την Πα" }, { 1, "επόμ. Πα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Πα πριν" }, { PluralRulesValues.Other, "{0} Πα πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Πα" }, { PluralRulesValues.Other, "σε {0} Πα" } })
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
									new Dictionary<int, string> { { -1, "προηγούμενο Σάββατο" }, { 0, "αυτό το Σάββατο" }, { 1, "επόμενο Σάββατο" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Σάββατο" }, { PluralRulesValues.Other, "πριν από {0} Σάββατα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Σάββατο" }, { PluralRulesValues.Other, "σε {0} Σάββατα" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Σάβ." }, { 0, "αυτό το Σάβ." }, { 1, "επόμ. Σάβ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} Σάβ." }, { PluralRulesValues.Other, "πριν από {0} Σάβ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Σάβ." }, { PluralRulesValues.Other, "σε {0} Σάβ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "προηγ. Σά" }, { 0, "αυτό το Σά" }, { 1, "επόμ. Σά" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Σά πριν" }, { PluralRulesValues.Other, "{0} Σά πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} Σά" }, { PluralRulesValues.Other, "σε {0} Σά" } })
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
									new Dictionary<int, string> { { 0, "τρέχουσα ώρα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} ώρα" }, { PluralRulesValues.Other, "πριν από {0} ώρες" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} ώρα" }, { PluralRulesValues.Other, "σε {0} ώρες" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "τρέχουσα ώρα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} ώ." }, { PluralRulesValues.Other, "πριν από {0} ώ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} ώ." }, { PluralRulesValues.Other, "σε {0} ώ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "τρέχουσα ώρα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ώ. πριν" }, { PluralRulesValues.Other, "{0} ώ. πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} ώ." }, { PluralRulesValues.Other, "σε {0} ώ." } })
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
									new Dictionary<int, string> { { 0, "τρέχον λεπτό" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} λεπτό" }, { PluralRulesValues.Other, "πριν από {0} λεπτά" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} λεπτό" }, { PluralRulesValues.Other, "σε {0} λεπτά" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "τρέχον λεπτό" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} λεπ." }, { PluralRulesValues.Other, "πριν από {0} λεπ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} λεπ." }, { PluralRulesValues.Other, "σε {0} λεπ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "τρέχον λεπτό" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} λ. πριν" }, { PluralRulesValues.Other, "{0} λ. πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} λ." }, { PluralRulesValues.Other, "σε {0} λ." } })
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
									new Dictionary<int, string> { { 0, "τώρα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} δευτερόλεπτο" }, { PluralRulesValues.Other, "πριν από {0} δευτερόλεπτα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} δευτερόλεπτο" }, { PluralRulesValues.Other, "σε {0} δευτερόλεπτα" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "τώρα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "πριν από {0} δευτ." }, { PluralRulesValues.Other, "πριν από {0} δευτ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} δευτ." }, { PluralRulesValues.Other, "σε {0} δευτ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "τώρα" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} δ. πριν" }, { PluralRulesValues.Other, "{0} δ. πριν" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "σε {0} δ." }, { PluralRulesValues.Other, "σε {0} δ." } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("el");
		}
	}
}