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
	/// Relative Time Units resource for 'Gujarati' [gu]
	/// </summary>
	public class GuRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public GuRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "ગયા વર્ષે" }, { 0, "આ વર્ષે" }, { 1, "આવતા વર્ષે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} વર્ષ પહેલાં" }, { PluralRulesValues.Other, "{0} વર્ષ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} વર્ષમાં" }, { PluralRulesValues.Other, "{0} વર્ષમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા વર્ષે" }, { 0, "આ વર્ષે" }, { 1, "આવતા વર્ષે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} વર્ષ પહેલાં" }, { PluralRulesValues.Other, "{0} વર્ષ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} વર્ષમાં" }, { PluralRulesValues.Other, "{0} વર્ષમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા વર્ષે" }, { 0, "આ વર્ષે" }, { 1, "આવતા વર્ષે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} વર્ષ પહેલાં" }, { PluralRulesValues.Other, "{0} વર્ષ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} વર્ષમાં" }, { PluralRulesValues.Other, "{0} વર્ષમાં" } })
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
									new Dictionary<int, string> { { -1, "છેલ્લું ત્રિમાસિક" }, { 0, "આ ત્રિમાસિક" }, { 1, "પછીનું ત્રિમાસિક" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ત્રિમાસિક પહેલાં" }, { PluralRulesValues.Other, "{0} ત્રિમાસિક પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ત્રિમાસિકમાં" }, { PluralRulesValues.Other, "{0} ત્રિમાસિકમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "છેલ્લું ત્રિમાસિક" }, { 0, "આ ત્રિમાસિક" }, { 1, "પછીનું ત્રિમાસિક" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ત્રિમાસિક પહેલાં" }, { PluralRulesValues.Other, "{0} ત્રિમાસિક પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ત્રિમાસિકમાં" }, { PluralRulesValues.Other, "{0} ત્રિમાસિકમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "છેલ્લું ત્રિમાસિક" }, { 0, "આ ત્રિમાસિક" }, { 1, "પછીનું ત્રિમાસિક" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ત્રિમાસિક પહેલાં" }, { PluralRulesValues.Other, "{0} ત્રિમાસિક પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ત્રિમાસિકમાં" }, { PluralRulesValues.Other, "{0} ત્રિમાસિકમાં" } })
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
									new Dictionary<int, string> { { -1, "ગયા મહિને" }, { 0, "આ મહિને" }, { 1, "આવતા મહિને" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મહિના પહેલાં" }, { PluralRulesValues.Other, "{0} મહિના પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મહિનામાં" }, { PluralRulesValues.Other, "{0} મહિનામાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા મહિને" }, { 0, "આ મહિને" }, { 1, "આવતા મહિને" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મહિના પહેલાં" }, { PluralRulesValues.Other, "{0} મહિના પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મહિનામાં" }, { PluralRulesValues.Other, "{0} મહિનામાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા મહિને" }, { 0, "આ મહિને" }, { 1, "આવતા મહિને" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મહિના પહેલાં" }, { PluralRulesValues.Other, "{0} મહિના પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મહિનામાં" }, { PluralRulesValues.Other, "{0} મહિનામાં" } })
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
									new Dictionary<int, string> { { -1, "ગયા અઠવાડિયે" }, { 0, "આ અઠવાડિયે" }, { 1, "આવતા અઠવાડિયે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} અઠવાડિયા પહેલાં" }, { PluralRulesValues.Other, "{0} અઠવાડિયા પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} અઠવાડિયામાં" }, { PluralRulesValues.Other, "{0} અઠવાડિયામાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા અઠવાડિયે" }, { 0, "આ અઠવાડિયે" }, { 1, "આવતા અઠવાડિયે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} અઠ. પહેલાં" }, { PluralRulesValues.Other, "{0} અઠ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} અઠ. માં" }, { PluralRulesValues.Other, "{0} અઠ. માં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા અઠવાડિયે" }, { 0, "આ અઠવાડિયે" }, { 1, "આવતા અઠવાડિયે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} અઠ. પહેલાં" }, { PluralRulesValues.Other, "{0} અઠ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} અઠ. માં" }, { PluralRulesValues.Other, "{0} અઠ. માં" } })
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
									new Dictionary<int, string> { { -2, "ગયા પરમદિવસે" }, { -1, "ગઈકાલે" }, { 0, "આજે" }, { 1, "આવતીકાલે" }, { 2, "પરમદિવસે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} દિવસ પહેલાં" }, { PluralRulesValues.Other, "{0} દિવસ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} દિવસમાં" }, { PluralRulesValues.Other, "{0} દિવસમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "ગયા પરમદિવસે" }, { -1, "ગઈકાલે" }, { 0, "આજે" }, { 1, "આવતીકાલે" }, { 2, "પરમદિવસે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} દિવસ પહેલાં" }, { PluralRulesValues.Other, "{0} દિવસ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} દિવસમાં" }, { PluralRulesValues.Other, "{0} દિવસમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "ગયા પરમદિવસે" }, { -1, "ગઈકાલે" }, { 0, "આજે" }, { 1, "આવતીકાલે" }, { 2, "પરમદિવસે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} દિવસ પહેલાં" }, { PluralRulesValues.Other, "{0} દિવસ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} દિવસમાં" }, { PluralRulesValues.Other, "{0} દિવસમાં" } })
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
									new Dictionary<int, string> { { -1, "ગયા રવિવારે" }, { 0, "આ રવિવારે" }, { 1, "આવતા રવિવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} રવિવાર પહેલાં" }, { PluralRulesValues.Other, "{0} રવિવાર પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} રવિવારમાં" }, { PluralRulesValues.Other, "{0} રવિવારમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા રવિવારે" }, { 0, "આ રવિવારે" }, { 1, "આવતા રવિવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} રવિ. પહેલાં" }, { PluralRulesValues.Other, "{0} રવિ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} રવિવારમાં" }, { PluralRulesValues.Other, "{0} રવિવારમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા રવિ." }, { 0, "આ રવિ" }, { 1, "આવતા રવિ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} રવિ. પહેલાં" }, { PluralRulesValues.Other, "{0} રવિ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} રવિવારમાં" }, { PluralRulesValues.Other, "{0} રવિવારમાં" } })
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
									new Dictionary<int, string> { { -1, "ગયા સોમવારે" }, { 0, "આ સોમવારે" }, { 1, "આવતા સોમવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સોમવાર પહેલાં" }, { PluralRulesValues.Other, "{0} સોમવાર પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સોમવારમાં" }, { PluralRulesValues.Other, "{0} સોમવારમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા સોમવારે" }, { 0, "આ સોમવારે" }, { 1, "આવતા સોમવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સોમ. પહેલાં" }, { PluralRulesValues.Other, "{0} સોમ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સોમવારમાં" }, { PluralRulesValues.Other, "{0} સોમવારમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા સોમવારે" }, { 0, "આ સોમવારે" }, { 1, "આવતા સોમવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સોમ. પહેલાં" }, { PluralRulesValues.Other, "{0} સોમ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સોમવારમાં" }, { PluralRulesValues.Other, "{0} સોમવારમાં" } })
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
									new Dictionary<int, string> { { -1, "ગયા મંગળવારે" }, { 0, "આ મંગળવારે" }, { 1, "આવતા મંગળવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મંગળવાર પહેલાં" }, { PluralRulesValues.Other, "{0} મંગળવાર પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મંગળવારમાં" }, { PluralRulesValues.Other, "{0} મંગળવારમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા મંગળવારે" }, { 0, "આ મંગળવારે" }, { 1, "આવતા મંગળવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મંગળ. પહેલાં" }, { PluralRulesValues.Other, "{0} મંગળ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મંગળવારમાં" }, { PluralRulesValues.Other, "{0} મંગળવારમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા મંગળવારે" }, { 0, "આ મંગળવારે" }, { 1, "આવતા મંગળવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મંગળ. પહેલાં" }, { PluralRulesValues.Other, "{0} મંગળ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મંગળવારમાં" }, { PluralRulesValues.Other, "{0} મંગળવારમાં" } })
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
									new Dictionary<int, string> { { -1, "ગયા બુધવારે" }, { 0, "આ બુધવારે" }, { 1, "આવતા બુધવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} બુધવાર પહેલાં" }, { PluralRulesValues.Other, "{0} બુધવાર પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} બુધવારમાં" }, { PluralRulesValues.Other, "{0} બુધવારમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા બુધવારે" }, { 0, "આ બુધવારે" }, { 1, "આવતા બુધવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} બુધ. પહેલાં" }, { PluralRulesValues.Other, "{0} બુધ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} બુધવારમાં" }, { PluralRulesValues.Other, "{0} બુધવારમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા બુધવારે" }, { 0, "આ બુધવારે" }, { 1, "આવતા બુધવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} બુધ. પહેલાં" }, { PluralRulesValues.Other, "{0} બુધ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} બુધવારમાં" }, { PluralRulesValues.Other, "{0} બુધવારમાં" } })
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
									new Dictionary<int, string> { { -1, "ગયા ગુરુવારે" }, { 0, "આ ગુરુવારે" }, { 1, "આવતા ગુરુવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ગુરુવાર પહેલાં" }, { PluralRulesValues.Other, "{0} ગુરુવાર પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ગુરુવારમાં" }, { PluralRulesValues.Other, "{0} ગુરુવારમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા ગુરુવારે" }, { 0, "આ ગુરુવારે" }, { 1, "આવતા ગુરુવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ગુરુ. પહેલાં" }, { PluralRulesValues.Other, "{0} ગુરુ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ગુરુવારમાં" }, { PluralRulesValues.Other, "{0} ગુરુવારમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા ગુરુવારે" }, { 0, "આ ગુરુવારે" }, { 1, "આવતા ગુરુવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ગુરુ. પહેલાં" }, { PluralRulesValues.Other, "{0} ગુરુ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ગુરુવારમાં" }, { PluralRulesValues.Other, "{0} ગુરુવારમાં" } })
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
									new Dictionary<int, string> { { -1, "ગયા શુક્રવારે" }, { 0, "આ શુક્રવારે" }, { 1, "આવતા શુક્રવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શુક્રવાર પહેલાં" }, { PluralRulesValues.Other, "{0} શુક્રવાર પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શુક્રવારમાં" }, { PluralRulesValues.Other, "{0} શુક્રવારમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા શુક્રવારે" }, { 0, "આ શુક્રવારે" }, { 1, "આવતા શુક્રવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શુક્ર. પહેલાં" }, { PluralRulesValues.Other, "{0} શુક્ર. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શુક્રવારમાં" }, { PluralRulesValues.Other, "{0} શુક્રવારમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા શુક્રવારે" }, { 0, "આ શુક્રવારે" }, { 1, "આવતા શુક્રવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શુક્ર. પહેલાં" }, { PluralRulesValues.Other, "{0} શુક્ર. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શુક્રવારમાં" }, { PluralRulesValues.Other, "{0} શુક્રવારમાં" } })
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
									new Dictionary<int, string> { { -1, "ગયા શનિવારે" }, { 0, "આ શનિવારે" }, { 1, "આવતા શનિવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શનિવાર પહેલાં" }, { PluralRulesValues.Other, "{0} શનિવાર પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શનિવારમાં" }, { PluralRulesValues.Other, "{0} શનિવારમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા શનિવારે" }, { 0, "આ શનિવારે" }, { 1, "આવતા શનિવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શનિ. પહેલાં" }, { PluralRulesValues.Other, "{0} શનિ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શનિવારમાં" }, { PluralRulesValues.Other, "{0} શનિવારમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ગયા શનિવારે" }, { 0, "આ શનિવારે" }, { 1, "આવતા શનિવારે" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શનિ. પહેલાં" }, { PluralRulesValues.Other, "{0} શનિ. પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} શનિવારમાં" }, { PluralRulesValues.Other, "{0} શનિવારમાં" } })
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
									new Dictionary<int, string> { { 0, "આ કલાક" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} કલાક પહેલાં" }, { PluralRulesValues.Other, "{0} કલાક પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} કલાકમાં" }, { PluralRulesValues.Other, "{0} કલાકમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "આ કલાક" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} કલાક પહેલાં" }, { PluralRulesValues.Other, "{0} કલાક પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} કલાકમાં" }, { PluralRulesValues.Other, "{0} કલાકમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "આ કલાક" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} કલાક પહેલાં" }, { PluralRulesValues.Other, "{0} કલાક પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} કલાકમાં" }, { PluralRulesValues.Other, "{0} કલાકમાં" } })
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
									new Dictionary<int, string> { { 0, "આ મિનિટ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મિનિટ પહેલાં" }, { PluralRulesValues.Other, "{0} મિનિટ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મિનિટમાં" }, { PluralRulesValues.Other, "{0} મિનિટમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "આ મિનિટ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મિનિટ પહેલાં" }, { PluralRulesValues.Other, "{0} મિનિટ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મિનિટમાં" }, { PluralRulesValues.Other, "{0} મિનિટમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "આ મિનિટ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મિનિટ પહેલાં" }, { PluralRulesValues.Other, "{0} મિનિટ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} મિનિટમાં" }, { PluralRulesValues.Other, "{0} મિનિટમાં" } })
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
									new Dictionary<int, string> { { 0, "હમણાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સેકંડ પહેલાં" }, { PluralRulesValues.Other, "{0} સેકંડ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સેકંડમાં" }, { PluralRulesValues.Other, "{0} સેકંડમાં" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "હમણાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સેકંડ પહેલાં" }, { PluralRulesValues.Other, "{0} સેકંડ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સેકંડમાં" }, { PluralRulesValues.Other, "{0} સેકંડમાં" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "હમણાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સેકંડ પહેલાં" }, { PluralRulesValues.Other, "{0} સેકંડ પહેલાં" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} સેકંડમાં" }, { PluralRulesValues.Other, "{0} સેકંડમાં" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("gu");
		}
	}
}