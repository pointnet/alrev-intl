using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.RelativeTime;
using System;

namespace Alrev.Intl.RelativeTime
{
    /// <summary>
    /// Relative Time styles resource
    /// </summary>
    public record RelativeTimeStylesResource(
        string Locale,
        RelativeTimeUnitValues RelativeTimeUnit,
        IRelativeTimeResource LongRelativeTimeResource,
        IRelativeTimeResource NarrowRelativeTimeResource,
        IRelativeTimeResource ShortRelativeTimeResource) : IRelativeTimeStylesResource, IResource
    {
        /// <summary>
        /// Gets the Relative Time resource based on the style specified
        /// </summary>
        /// <param name="relativeTimeStyle">The resource style to get</param>
        /// <returns>An <see cref="IRelativeTimeResource"/></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IRelativeTimeResource GetRelativeTimeResource(RelativeTimeStyleValues relativeTimeStyle) => relativeTimeStyle switch
        {
            RelativeTimeStyleValues.Long => this.LongRelativeTimeResource,
            RelativeTimeStyleValues.Narrow => this.NarrowRelativeTimeResource,
            RelativeTimeStyleValues.Short => this.ShortRelativeTimeResource,
            _ => throw new NotImplementedException($"Relative time style '{relativeTimeStyle}' is not supported")
        };
    }
}