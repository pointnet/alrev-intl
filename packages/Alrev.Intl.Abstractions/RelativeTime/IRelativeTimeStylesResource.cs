using System;

namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// Interface of Relative Time Styles
    /// </summary>
    public interface IRelativeTimeStylesResource
    {
        /// <summary>
        /// Gets the Relative Time styles unit
        /// </summary>
        RelativeTimeUnitValues RelativeTimeUnit { get; }
        /// <summary>
        /// Gets the Relative Time Long style resource
        /// </summary>
        IRelativeTimeResource LongRelativeTimeResource { get; }

        /// <summary>
        /// Gets the Relative Time Narrow style resource
        /// </summary>
        IRelativeTimeResource NarrowRelativeTimeResource { get; }

        /// <summary>
        /// Gets the Relative Time Short style resource
        /// </summary>
        IRelativeTimeResource ShortRelativeTimeResource { get; }

        /// <summary>
        /// Gets the Relative Time resource based on the style specified
        /// </summary>
        /// <param name="relativeTimeStyle">The resource style to get</param>
        /// <returns>An <see cref="IRelativeTimeResource"/></returns>
        /// <exception cref="NotImplementedException"></exception>
        IRelativeTimeResource GetRelativeTimeResource(RelativeTimeStyleValues relativeTimeStyle);
    }
}
