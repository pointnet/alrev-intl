// --------------------------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//   Script: ./scripts/cldr-list.csx
//
//   Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------------------------
using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.List;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Alrev.Intl.List.Resources
{
	/// <summary>
	/// List resources for 'Konkani' [kok]
	/// </summary>
	/// <seealso href="https://unicode-org.github.io/cldr-staging/charts/39/by_type/miscellaneous.displaying_lists.html"/>
	public class KokListResource : ReadOnlyDictionary<ListTypeValues, IReadOnlyDictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>>, IListResource
	{
		/// <summary>
		/// The <see cref="IIntlResource"/> culture
		/// </summary>
		public CultureInfo Culture { get; }

		/// <summary>
		/// The class constructor
		/// </summary>
		public KokListResource()
			: base(new Dictionary<ListTypeValues, IReadOnlyDictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>>()
			{
				{
					ListTypeValues.Conjunction,
					new ReadOnlyDictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>(
						new Dictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>()
						{
							{
								IntlStyleValues.Long,
								new ReadOnlyDictionary<ListPartValues, string>(
									new Dictionary<ListPartValues, string>()
									{
										{ ListPartValues.Start, "{0}, {1}" },
										{ ListPartValues.Middle, "{0}, {1}" },
										{ ListPartValues.End, "{0}, {1}" },
										{ ListPartValues.Pair, "{0}, {1}" }
									})
							},
							{
								IntlStyleValues.Short,
								new ReadOnlyDictionary<ListPartValues, string>(
									new Dictionary<ListPartValues, string>()
									{
										{ ListPartValues.Start, "{0}, {1}" },
										{ ListPartValues.Middle, "{0}, {1}" },
										{ ListPartValues.End, "{0}, & {1}" },
										{ ListPartValues.Pair, "{0} & {1}" }
									})
							},
							{
								IntlStyleValues.Narrow,
								new ReadOnlyDictionary<ListPartValues, string>(
									new Dictionary<ListPartValues, string>()
									{
										{ ListPartValues.Start, "{0}, {1}" },
										{ ListPartValues.Middle, "{0}, {1}" },
										{ ListPartValues.End, "{0}, {1}" },
										{ ListPartValues.Pair, "{0}, {1}" }
									})
							}
						})
				},
				{
					ListTypeValues.Disjunction,
					new ReadOnlyDictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>(
						new Dictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>()
						{
							{
								IntlStyleValues.Long,
								new ReadOnlyDictionary<ListPartValues, string>(
									new Dictionary<ListPartValues, string>()
									{
										{ ListPartValues.Start, "{0}, {1}" },
										{ ListPartValues.Middle, "{0}, {1}" },
										{ ListPartValues.End, "{0}, वा {1}" },
										{ ListPartValues.Pair, "{0} वा {1}" }
									})
							},
							{
								IntlStyleValues.Short,
								new ReadOnlyDictionary<ListPartValues, string>(
									new Dictionary<ListPartValues, string>()
									{
										{ ListPartValues.Start, "{0}, {1}" },
										{ ListPartValues.Middle, "{0}, {1}" },
										{ ListPartValues.End, "{0}, वा {1}" },
										{ ListPartValues.Pair, "{0} वा {1}" }
									})
							},
							{
								IntlStyleValues.Narrow,
								new ReadOnlyDictionary<ListPartValues, string>(
									new Dictionary<ListPartValues, string>()
									{
										{ ListPartValues.Start, "{0}, {1}" },
										{ ListPartValues.Middle, "{0}, {1}" },
										{ ListPartValues.End, "{0}, वा {1}" },
										{ ListPartValues.Pair, "{0} वा {1}" }
									})
							}
						})
				},
				{
					ListTypeValues.Unit,
					new ReadOnlyDictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>(
						new Dictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>()
						{
							{
								IntlStyleValues.Long,
								new ReadOnlyDictionary<ListPartValues, string>(
									new Dictionary<ListPartValues, string>()
									{
										{ ListPartValues.Start, "{0}, {1}" },
										{ ListPartValues.Middle, "{0}, {1}" },
										{ ListPartValues.End, "{0}, {1}" },
										{ ListPartValues.Pair, "{0}, {1}" }
									})
							},
							{
								IntlStyleValues.Short,
								new ReadOnlyDictionary<ListPartValues, string>(
									new Dictionary<ListPartValues, string>()
									{
										{ ListPartValues.Start, "{0}, {1}" },
										{ ListPartValues.Middle, "{0}, {1}" },
										{ ListPartValues.End, "{0}, {1}" },
										{ ListPartValues.Pair, "{0}, {1}" }
									})
							},
							{
								IntlStyleValues.Narrow,
								new ReadOnlyDictionary<ListPartValues, string>(
									new Dictionary<ListPartValues, string>()
									{
										{ ListPartValues.Start, "{0} {1}" },
										{ ListPartValues.Middle, "{0} {1}" },
										{ ListPartValues.End, "{0} {1}" },
										{ ListPartValues.Pair, "{0} {1}" }
									})
							}
						})
				}
			})
		{
			this.Culture = new CultureInfo("kok");
		}
	}
}