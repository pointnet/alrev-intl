using System;

namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// Interface of a Relative Time resource set
    /// </summary>
    public interface IRelativeTimeResourceSet
    {
        /// <summary>
        /// Gets Year relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Year { get; }

        /// <summary>
        /// Gets Quarter relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Quarter { get; }

        /// <summary>
        /// Gets Month relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Month { get; }

        /// <summary>
        /// Gets Week relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Week { get; }

        /// <summary>
        /// Gets Day relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Day { get; }

        /// <summary>
        /// Gets Sunday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Sunday { get; }

        /// <summary>
        /// Gets Monday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Monday { get; }

        /// <summary>
        /// Gets Tuesday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Tuesday { get; }

        /// <summary>
        /// Gets Wednesday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Wednesday { get; }

        /// <summary>
        /// Gets Thursday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Thursday { get; }

        /// <summary>
        /// Gets Friday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Friday { get; }

        /// <summary>
        /// Gets Saturday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Saturday { get; }

        /// <summary>
        /// Gets Hour relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Hour { get; }

        /// <summary>
        /// Gets Minute relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Minute { get; }

        /// <summary>
        /// Gets Second relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Second { get; }

        /// <summary>
        /// Gets the Relative Time resource styles based on the unit specified
        /// </summary>
        /// <param name="relativeTimeUnit">The resource unit to get</param>
        /// <returns>An <see cref="IRelativeTimeStylesResource"/></returns>
        /// <exception cref="NotImplementedException"></exception>
        IRelativeTimeStylesResource GetRelativeTimeStylesResource(RelativeTimeUnitValues relativeTimeUnit);
    }
}
