using System.Collections.Generic;

namespace Alrev.Intl.Abstractions.List
{
    public interface IListResource : IReadOnlyDictionary<ListTypeValues, IReadOnlyDictionary<IntlStyleValues, IReadOnlyDictionary<ListPartValues, string>>>, IIntlResource
    {
    }
}
