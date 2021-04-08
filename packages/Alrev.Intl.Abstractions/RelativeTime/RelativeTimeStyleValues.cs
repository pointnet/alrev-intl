namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// Enumeration of Relative Time styles
    /// </summary>
    public enum RelativeTimeStyleValues
    {
        /// <summary>
        /// Unknown style
        /// </summary>
        Unknown,
        /// <summary>
        /// Long style
        /// </summary>
        /// <example>in 1 month</example>
        Long,
        /// <summary>
        /// Narrow style
        /// </summary>
        /// <remarks> The narrow style could be similar to the short style for some locales</remarks>
        /// <example>in 1mo.</example>
        Narrow,
        /// <summary>
        /// Short style
        /// </summary>
        /// <example>in 1mo.</example>
        Short
    }
}
