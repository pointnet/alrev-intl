using System.Collections.Generic;

namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    ///   Defines a Relative Time Units resource.
    /// </summary>
    public interface IRelativeTimeUnitsResource : IReadOnlyDictionary<RelativeTimeUnitValues, IReadOnlyDictionary<IntlStyleValues, IRelativeTimeResource>>, IIntlResource
    {
    }
}