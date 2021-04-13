namespace Alrev.Intl.Abstractions.List
{
    /// <summary>
    /// Enumeration of List anchors values
    /// </summary>
    public enum ListTypeValues
    {
        /// <summary>
        /// Unknown type
        /// </summary>
        Unknown,
        /// <summary>
        /// Conjunction type that stands for "and"-based lists (default, e.g., "A, B, and C")
        /// </summary>
        Conjunction,
        /// <summary>
        /// Disjunction type that stands for "or"-based lists (e.g., "A, B, or C")
        /// </summary>
        Disjunction,
        /// <summary>
        /// Unit type that stands for lists of values with units (e.g., "5 pounds, 12 ounces")
        /// </summary>
        Unit
    }
}
