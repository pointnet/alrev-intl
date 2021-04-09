namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// Enumeration of Relative Time numeric format
    /// </summary>
    public enum RelativeTimeNumericValues
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown,
        /// <summary>
        /// Auto
        /// </summary>
        /// <remarks>
        ///  The "auto" value allows to not always have to use numeric values in the output
        /// </remarks>
        /// <example>yesterday</example>
        Auto,
        /// <summary>
        /// Always
        /// </summary>
        /// <example>1 day ago</example>
        Always
    }
}
