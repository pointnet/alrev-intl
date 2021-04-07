namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// Interface of Relative Time Styles
    /// </summary>
    public interface IRelativeTimeStylesResource
    {
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
    }
}
