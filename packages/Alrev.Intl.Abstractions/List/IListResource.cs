using System.Collections.Generic;

namespace Alrev.Intl.Abstractions.List
{
    /// <summary>
    /// Defines a List resource
    /// </summary>
    public interface IListResource : IReadOnlyDictionary<ListTypeValues, IReadOnlyDictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>>, IIntlResource
    {
    }
}
