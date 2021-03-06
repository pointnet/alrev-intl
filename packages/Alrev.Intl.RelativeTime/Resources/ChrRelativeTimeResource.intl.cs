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
	/// Relative Time Units resource for 'Cherokee' [chr]
	/// </summary>
	public class ChrRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public ChrRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "ᎡᏘ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏧᏕᏘᏴᏒᏘ" }, { 1, "ᎡᏘᏴᎢ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎤᏕᏘᏴᏌᏗᏒᎢ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎢᏧᏕᏘᏴᏌᏗᏒᎢ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎤᏕᏘᏴᏌᏗᏒᎢ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎢᏧᏕᏘᏴᏌᏗᏒᎢ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᎡᏘ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏧᏕᏘᏴᏒᏘ." }, { 1, "ᎡᏘᏴᎢ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎤᏕ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎤᏕ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎤᏕ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎤᏕ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᎡᏘ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏧᏕᏘᏴᏒᏘ." }, { 1, "ᎡᏘᏴᎢ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎤᏕ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎤᏕ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎤᏕ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎤᏕ." } })
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
									new Dictionary<int, string> { { -1, "ᎩᏄᏙᏗ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᎩᏄᏙᏗ" }, { 1, "ᏔᎵᏁ ᎩᏄᏙᏗ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎩᏄᏙᏗ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎩᏄᏙᏗ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎩᏄᏙᏗ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎩᏄᏙᏗ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᎩᏄᏙᏗ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᎩᏄᏙᏗ" }, { 1, "ᏔᎵᏁ ᎩᏄᏙᏗ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎩᏄᏘ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎩᏄᏘ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎩᏄᏘ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎩᏄᏘ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᎩᏄᏙᏗ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᎩᏄᏙᏗ" }, { 1, "ᏔᎵᏁ ᎩᏄᏙᏗ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎩᏄᏘ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎩᏄᏘ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎩᏄᏘ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎩᏄᏘ." } })
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
									new Dictionary<int, string> { { -1, "ᎧᎸᎢ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᎧᎸᎢ" }, { 1, "ᏔᎵᏁ ᎧᎸᎢ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎧᎸᎢ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏗᎧᎸᎢ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎧᎸᎢ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏗᎧᎸᎢ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᎧᎸ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᎧᎸ." }, { 1, "ᎯᎠ ᎧᎸ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎧᎸ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎧᎸ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎧᎸ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎧᎸ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᎧᎸ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᎧᎸ." }, { 1, "ᏔᎵᏁ ᎧᎸ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎧᎸ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎧᎸ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎧᎸ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎧᎸ." } })
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
									new Dictionary<int, string> { { -1, "ᏥᏛᎵᏱᎵᏒᎢ" }, { 0, "ᎯᎠ ᎠᎵᎵᏌ" }, { 1, "ᏐᏆᎴᏅᎲ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏒᎾᏙᏓᏆᏍᏗ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎢᏳᎾᏙᏓᏆᏍᏗ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏒᎾᏙᏓᏆᏍᏗ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎢᏳᎾᏙᏓᏆᏍᏗ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏥᏛᎵᏱᎵᏒᎢ." }, { 0, "ᎯᎠ ᎠᎵᎵᏌ." }, { 1, "ᏐᏆᎴᏅᎲ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏒᎾ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏒᎾ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏒᎾ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏒᎾ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏥᏛᎵᏱᎵᏒᎢ." }, { 0, "ᎯᎠ ᎠᎵᎵᏌ." }, { 1, "ᏐᏆᎴᏅᎲ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏒᎾ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏒᎾ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏒᎾ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏒᎾ." } })
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
									new Dictionary<int, string> { { -1, "ᏒᎯ" }, { 0, "ᎪᎯ ᎢᎦ" }, { 1, "ᏌᎾᎴᎢ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎢᎦ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎯᎸᏍᎩ ᏧᏒᎯᏛ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎢᎦ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎯᎸᏍᎩ ᏧᏒᎯᏛ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏒᎯ" }, { 0, "ᎪᎯ ᎢᎦ" }, { 1, "ᏌᎾᎴᎢ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎢᎦ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎯᎸᏍᎩ ᏧᏒᎯᏛ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎢᎦ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎯᎸᏍᎩ ᏧᏒᎯᏛ" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏒᎯ" }, { 0, "ᎪᎯ ᎢᎦ" }, { 1, "ᏌᎾᎴᎢ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎢᎦ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎯᎸᏍᎩ ᏧᏒᎯᏛ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎢᎦ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎯᎸᏍᎩ ᏧᏒᎯᏛ" } })
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
									new Dictionary<int, string> { { -1, "ᎤᎾᏙᏓᏆᏍᎬ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᎤᎾᏙᏓᏆᏍᎬ" }, { 1, "ᏔᎵᏁ ᎤᎾᏙᏓᏆᏍᎬ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎤᎾᏙᏓᏆᏍᎬ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎤᎾᏙᏓᏆᏍᎬ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎤᎾᏙᏓᏆᏍᎬ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎤᎾᏙᏓᏆᏍᎬ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏆᏍᎬ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏆᏍᎬ." }, { 1, "ᏔᎵᏁ ᏆᏍᎬ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏆᏍᎬ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏆᏍᎬ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏆᏍᎬ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏆᏍᎬ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏍᎬ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏍᎬ" }, { 1, "ᏔᎵᏁ ᏍᎬ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏍᎬ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏍᎬ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏍᎬ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏍᎬ" } })
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
									new Dictionary<int, string> { { -1, "ᎤᎾᏙᏓᏉᏅᎯ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᎤᎾᏙᏓᏉᏅᎯ" }, { 1, "ᏔᎵᏁ ᎤᎾᏙᏓᏉᏅᎯ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎤᎾᏙᏓᏉᏅᎯ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎤᎾᏙᏓᏉᏅᎯ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎤᎾᏙᏓᏉᏅᎯ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎤᎾᏙᏓᏉᏅᎯ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏉᏅᎯ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏉᏅᎯ." }, { 1, "ᏔᎵᏁ ᏉᏅᎯ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏉᏅᎯ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏉᏅᎯ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏉᏅᎯ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏉᏅᎯ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Ꮙ ᏥᎨᏒ" }, { 0, "ᎯᎠ Ꮙ" }, { 1, "ᏔᎵᏁ Ꮙ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ꮙ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} Ꮙ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} Ꮙ" }, { PluralRulesValues.Other, "ᎾᎿ {0} Ꮙ" } })
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
									new Dictionary<int, string> { { -1, "ᏔᎵᏁ ᎢᎦ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏔᎵᏁ ᎢᎦ" }, { 1, "ᏔᎵᏁ ᏔᎵᏁ ᎢᎦ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏔᎵᏁ ᎢᎦ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏔᎵᏁ ᎢᎦ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏔᎵᏁ ᎢᎦ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏔᎵᏁ ᎢᎦ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏔᎵᏁ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏔᎵᏁ." }, { 1, "ᏔᎵᏁ ᏔᎵᏁ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏔᎵᏁ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏔᎵᏁ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏔᎵᏁ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏔᎵᏁ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏔᎵ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏔᎵ" }, { 1, "ᏔᎵᏁ ᏔᎵ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏔᎵ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏔᎵ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏔᎵ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏔᎵ" } })
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
									new Dictionary<int, string> { { -1, "ᏦᎢᏁ ᎢᎦ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏦᎢᏁ ᎢᎦ" }, { 1, "ᏔᎵᏁ ᏦᎢᏁ ᎢᎦ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏦᎢᏁ ᎢᎦ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏦᎢᏁ ᎢᎦ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏦᎢᏁ ᎢᎦ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏦᎢᏁ ᎢᎦ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏦᎢᏁ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏦᎢᏁ." }, { 1, "ᏔᎵᏁ ᏦᎢᏁ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏦᎢᏁ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏦᎢᏁ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏦᎢᏁ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏦᎢᏁ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Ꮶ ᏥᎨᏒ" }, { 0, "ᎯᎠ Ꮶ" }, { 1, "ᏔᎵᏁ Ꮶ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ꮶ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} Ꮶ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} Ꮶ" }, { PluralRulesValues.Other, "ᎾᎿ {0} Ꮶ" } })
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
									new Dictionary<int, string> { { -1, "ᏅᎩᏁ ᎢᎦ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏅᎩᏁ ᎢᎦ" }, { 1, "ᏔᎵᏁ ᏅᎩᏁ ᎢᎦ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏅᎩᏁ ᎢᎦ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏅᎩᏁ ᎢᎦ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏅᎩᏁ ᎢᎦ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏅᎩᏁ ᎢᎦ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏅᎩᏁ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏅᎩᏁ." }, { 1, "ᏔᎵᏁ ᏅᎩᏁ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏅᎩᏁ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏅᎩᏁ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏅᎩᏁ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏅᎩᏁ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏅᎩ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏅᎩ" }, { 1, "ᏔᎵᏁ ᏅᎩ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏅᎩ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏅᎩ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏅᎩ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏅᎩ" } })
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
									new Dictionary<int, string> { { -1, "ᏧᎾᎩᎶᏍᏗ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏧᎾᎩᎶᏍᏗ" }, { 1, "ᏔᎵᏁ ᏧᎾᎩᎶᏍᏗ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏧᎾᎩᎶᏍᏗ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏧᎾᎩᎶᏍᏗ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏧᎾᎩᎶᏍᏗ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏧᎾᎩᎶᏍᏗ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏧᎾᎩ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏧᎾᎩ." }, { 1, "ᏔᎵᏁ ᏧᎾᎩ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏧᎾᎩ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏧᎾᎩ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏧᎾᎩ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏧᎾᎩ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "Ꮷ ᏥᎨᏒ" }, { 0, "ᎯᎠ Ꮷ" }, { 1, "ᏔᎵᏁ Ꮷ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} Ꮷ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} Ꮷ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} Ꮷ" }, { PluralRulesValues.Other, "ᎾᎿ {0} Ꮷ" } })
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
									new Dictionary<int, string> { { -1, "ᎤᎾᏙᏓᏈᏕᎾ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᎤᎾᏙᏓᏈᏕᎾ" }, { 1, "ᏔᎵᏁ ᎤᎾᏙᏓᏈᏕᎾ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎤᎾᏙᏓᏈᏕᎾ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎤᎾᏙᏓᏈᏕᎾ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎤᎾᏙᏓᏈᏕᎾ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎤᎾᏙᏓᏈᏕᎾ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏈᏕᎾ. ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏈᏕᎾ." }, { 1, "ᏔᎵᏁ ᏈᏕᎾ." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏈᏕᎾ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏈᏕᎾ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏈᏕᎾ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏈᏕᎾ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ᏕᎾ ᏥᎨᏒ" }, { 0, "ᎯᎠ ᏕᎾ" }, { 1, "ᏔᎵᏁ ᏕᎾ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏕᎾ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏕᎾ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏕᎾ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏕᎾ" } })
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
									new Dictionary<int, string> { { 0, "ᎯᎠ ᏑᏟᎶᏓ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏑᏟᎶᏓ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎢᏳᏟᎶᏓ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏑᏟᎶᏓ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎢᏳᏟᎶᏓ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ᎯᎠ ᏑᏟᎶᏓ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏑᏟ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏑᏟ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏑᏟ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏑᏟ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ᎯᎠ ᏑᏟᎶᏓ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᏑᏟ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏑᏟ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᏑᏟ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏑᏟ." } })
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
									new Dictionary<int, string> { { 0, "ᎯᎠ ᎢᏯᏔᏬᏍᏔᏅ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎢᏯᏔᏬᏍᏔᏅ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎢᏯᏔᏬᏍᏔᏅ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎢᏯᏔᏬᏍᏔᏅ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎢᏯᏔᏬᏍᏔᏅ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ᎯᎠ ᎢᏯᏔᏬᏍᏔᏅ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎢᏯᏔ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎢᏯᏔ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎢᏯᏔ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎢᏯᏔ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ᎯᎠ ᎢᏯᏔᏬᏍᏔᏅ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎢᏯᏔ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎢᏯᏔ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎢᏯᏔ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎢᏯᏔ." } })
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
									new Dictionary<int, string> { { 0, "ᏃᏊ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎠᏎᏢ ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᏓᏓᎾᏩᏍᎬ ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎠᏎᏢ" }, { PluralRulesValues.Other, "ᎾᎿ {0} ᏓᏓᎾᏩᏍᎬ ᏥᎨᏒ" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ᏃᏊ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎠᏎ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎠᏎ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎠᏎ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎠᏎ." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "ᏃᏊ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "{0} ᎠᏎ. ᏥᎨᏒ" }, { PluralRulesValues.Other, "{0} ᎠᏎ. ᏥᎨᏒ" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "ᎾᎿ {0} ᎠᏎ." }, { PluralRulesValues.Other, "ᎾᎿ {0} ᎠᏎ." } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("chr");
		}
	}
}