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
	/// Relative Time Units resource for 'Portuguese (S&#227;o Tom&#233; &amp; Pr&#237;ncipe)' [pt-st]
	/// </summary>
	public class PtStRelativeTimeResource : ReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IRelativeTimeUnitsResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public PtStRelativeTimeResource()
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
									new Dictionary<int, string> { { -1, "ano passado" }, { 0, "este ano" }, { 1, "próximo ano" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} ano" }, { PluralRulesValues.Other, "há {0} anos" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} ano" }, { PluralRulesValues.Other, "dentro de {0} anos" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ano passado" }, { 0, "este ano" }, { 1, "próximo ano" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} ano" }, { PluralRulesValues.Other, "há {0} anos" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} ano" }, { PluralRulesValues.Other, "dentro de {0} anos" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ano passado" }, { 0, "este ano" }, { 1, "próximo ano" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} ano" }, { PluralRulesValues.Other, "-{0} anos" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} ano" }, { PluralRulesValues.Other, "+{0} anos" } })
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
									new Dictionary<int, string> { { -1, "trimestre passado" }, { 0, "este trimestre" }, { 1, "próximo trimestre" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} trimestre" }, { PluralRulesValues.Other, "há {0} trimestres" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} trimestre" }, { PluralRulesValues.Other, "dentro de {0} trimestres" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "trim. passado" }, { 0, "este trim." }, { 1, "próximo trim." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} trim." }, { PluralRulesValues.Other, "há {0} trim." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} trim." }, { PluralRulesValues.Other, "dentro de {0} trim." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "trim. passado" }, { 0, "este trim." }, { 1, "próximo trim." } },
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
									new Dictionary<int, string> { { -1, "mês passado" }, { 0, "este mês" }, { 1, "próximo mês" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} mês" }, { PluralRulesValues.Other, "há {0} meses" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} mês" }, { PluralRulesValues.Other, "dentro de {0} meses" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mês passado" }, { 0, "este mês" }, { 1, "próximo mês" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} mês" }, { PluralRulesValues.Other, "há {0} meses" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} mês" }, { PluralRulesValues.Other, "dentro de {0} meses" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "mês passado" }, { 0, "este mês" }, { 1, "próximo mês" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} mês" }, { PluralRulesValues.Other, "-{0} meses" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} mês" }, { PluralRulesValues.Other, "+{0} meses" } })
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
									new Dictionary<int, string> { { -1, "semana passada" }, { 0, "esta semana" }, { 1, "próxima semana" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} semana" }, { PluralRulesValues.Other, "há {0} semanas" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} semana" }, { PluralRulesValues.Other, "dentro de {0} semanas" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "semana passada" }, { 0, "esta semana" }, { 1, "próxima semana" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sem." }, { PluralRulesValues.Other, "há {0} sem." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sem." }, { PluralRulesValues.Other, "dentro de {0} sem." } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "semana passada" }, { 0, "esta semana" }, { 1, "próxima semana" } },
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
									new Dictionary<int, string> { { -2, "anteontem" }, { -1, "ontem" }, { 0, "hoje" }, { 1, "amanhã" }, { 2, "depois de amanhã" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} dia" }, { PluralRulesValues.Other, "há {0} dias" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} dia" }, { PluralRulesValues.Other, "dentro de {0} dias" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "anteontem" }, { -1, "ontem" }, { 0, "hoje" }, { 1, "amanhã" }, { 2, "depois de amanhã" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} dia" }, { PluralRulesValues.Other, "há {0} dias" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} dia" }, { PluralRulesValues.Other, "dentro de {0} dias" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -2, "anteontem" }, { -1, "ontem" }, { 0, "hoje" }, { 1, "amanhã" }, { 2, "depois de amanhã" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} dia" }, { PluralRulesValues.Other, "-{0} dias" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} dia" }, { PluralRulesValues.Other, "+{0} dias" } })
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
									new Dictionary<int, string> { { -1, "domingo passado" }, { 0, "este domingo" }, { 1, "próximo domingo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} domingo" }, { PluralRulesValues.Other, "há {0} domingos" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} domingo" }, { PluralRulesValues.Other, "dentro de {0} domingos" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "domingo passado" }, { 0, "este domingo" }, { 1, "próximo domingo" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} dom." }, { PluralRulesValues.Other, "há {0} dom." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} domingo" }, { PluralRulesValues.Other, "dentro de {0} domingos" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "dom. passado" }, { 0, "este dom." }, { 1, "próximo dom." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} dom." }, { PluralRulesValues.Other, "há {0} dom." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} dom." }, { PluralRulesValues.Other, "dentro de {0} dom." } })
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
									new Dictionary<int, string> { { -1, "segunda-feira passada" }, { 0, "esta segunda-feira" }, { 1, "próxima segunda-feira" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} segunda-feira" }, { PluralRulesValues.Other, "há {0} segundas-feiras" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} segunda-feira" }, { PluralRulesValues.Other, "dentro de {0} segundas-feiras" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "segunda passada" }, { 0, "esta segunda" }, { 1, "próxima segunda" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} segunda" }, { PluralRulesValues.Other, "há {0} segundas" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} segunda" }, { PluralRulesValues.Other, "dentro de {0} segundas" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "seg. passada" }, { 0, "esta seg." }, { 1, "próxima seg." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} seg." }, { PluralRulesValues.Other, "há {0} seg." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} seg." }, { PluralRulesValues.Other, "dentro de {0} seg." } })
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
									new Dictionary<int, string> { { -1, "terça-feira passada" }, { 0, "esta terça-feira" }, { 1, "próxima terça-feira" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} terça-feira" }, { PluralRulesValues.Other, "há {0} terças-feiras" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} terça-feira" }, { PluralRulesValues.Other, "dentro de {0} terças-feiras" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "terça passada" }, { 0, "esta terça" }, { 1, "próxima terça" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} terça" }, { PluralRulesValues.Other, "há {0} terças" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} terça" }, { PluralRulesValues.Other, "dentro de {0} terças" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "ter. passada" }, { 0, "esta ter." }, { 1, "próxima ter." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} ter." }, { PluralRulesValues.Other, "há {0} ter." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} ter." }, { PluralRulesValues.Other, "dentro de {0} ter." } })
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
									new Dictionary<int, string> { { -1, "quarta-feira passada" }, { 0, "esta quarta-feira" }, { 1, "próxima quarta-feira" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} quarta-feira" }, { PluralRulesValues.Other, "há {0} quartas-feiras" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} quarta-feira" }, { PluralRulesValues.Other, "dentro de {0} quartas-feiras" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "quarta passada" }, { 0, "esta quarta" }, { 1, "próxima quarta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} quarta" }, { PluralRulesValues.Other, "há {0} quartas" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} quarta" }, { PluralRulesValues.Other, "dentro de {0} quartas" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "qua. passada" }, { 0, "esta qua." }, { 1, "próxima qua." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} qua." }, { PluralRulesValues.Other, "há {0} qua." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} qua." }, { PluralRulesValues.Other, "dentro de {0} qua." } })
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
									new Dictionary<int, string> { { -1, "quinta-feira passada" }, { 0, "esta quinta-feira" }, { 1, "próxima quinta-feira" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} quinta-feira" }, { PluralRulesValues.Other, "há {0} quintas-feiras" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} quinta-feira" }, { PluralRulesValues.Other, "dentro de {0} quintas-feiras" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "quinta passada" }, { 0, "esta quinta" }, { 1, "próxima quinta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} quinta" }, { PluralRulesValues.Other, "há {0} quintas" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} quinta" }, { PluralRulesValues.Other, "dentro de {0} quintas" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "qui. passada" }, { 0, "esta qui." }, { 1, "próxima qui." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} qui." }, { PluralRulesValues.Other, "há {0} qui." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} qui." }, { PluralRulesValues.Other, "dentro de {0} qui." } })
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
									new Dictionary<int, string> { { -1, "sexta-feira passada" }, { 0, "esta sexta-feira" }, { 1, "próxima sexta-feira" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sexta-feira" }, { PluralRulesValues.Other, "há {0} sextas-feiras" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sexta-feira" }, { PluralRulesValues.Other, "dentro de {0} sextas-feiras" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "sexta passada" }, { 0, "esta sexta" }, { 1, "próxima sexta" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sexta" }, { PluralRulesValues.Other, "há {0} sextas" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sexta" }, { PluralRulesValues.Other, "dentro de {0} sextas" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "sex. passada" }, { 0, "esta sex." }, { 1, "próxima sex." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sex." }, { PluralRulesValues.Other, "há {0} sex." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sex." }, { PluralRulesValues.Other, "dentro de {0} sex." } })
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
									new Dictionary<int, string> { { -1, "sábado passado" }, { 0, "este sábado" }, { 1, "próximo sábado" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sábado" }, { PluralRulesValues.Other, "há {0} sábados" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sábado" }, { PluralRulesValues.Other, "dentro de {0} sábados" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "sábado passado" }, { 0, "este sábado" }, { 1, "próximo sábado" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sábado" }, { PluralRulesValues.Other, "há {0} sábados" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sábado" }, { PluralRulesValues.Other, "dentro de {0} sábados" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { -1, "sáb. passado" }, { 0, "este sáb." }, { 1, "próximo sáb." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} sáb." }, { PluralRulesValues.Other, "há {0} sáb." } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} sáb." }, { PluralRulesValues.Other, "dentro de {0} sáb." } })
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
									new Dictionary<int, string> { { 0, "esta hora" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} hora" }, { PluralRulesValues.Other, "há {0} horas" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} hora" }, { PluralRulesValues.Other, "dentro de {0} horas" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "esta hora" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} h" }, { PluralRulesValues.Other, "há {0} h" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} h" }, { PluralRulesValues.Other, "dentro de {0} h" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "esta hora" } },
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
									new Dictionary<int, string> { { 0, "este minuto" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} minuto" }, { PluralRulesValues.Other, "há {0} minutos" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} minuto" }, { PluralRulesValues.Other, "dentro de {0} minutos" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "este minuto" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} min" }, { PluralRulesValues.Other, "há {0} min" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} min" }, { PluralRulesValues.Other, "dentro de {0} min" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "este minuto" } },
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
									new Dictionary<int, string> { { 0, "agora" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} segundo" }, { PluralRulesValues.Other, "há {0} segundos" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} segundo" }, { PluralRulesValues.Other, "dentro de {0} segundos" } })
							},
							{
								IntlStyleValues.Short,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "agora" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "há {0} s" }, { PluralRulesValues.Other, "há {0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "dentro de {0} s" }, { PluralRulesValues.Other, "dentro de {0} s" } })
							},
							{
								IntlStyleValues.Narrow,
								new RelativeTimeResource(
									new Dictionary<int, string> { { 0, "agora" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "-{0} s" }, { PluralRulesValues.Other, "-{0} s" } },
									new Dictionary<PluralRulesValues, string> { { PluralRulesValues.One, "+{0} s" }, { PluralRulesValues.Other, "+{0} s" } })
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("pt-st");
		}
	}
}