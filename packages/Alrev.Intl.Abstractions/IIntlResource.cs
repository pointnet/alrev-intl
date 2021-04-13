using System.Globalization;

namespace Alrev.Intl.Abstractions
{
    /// <summary>
    /// Defines an Intl resource
    /// </summary>
    public interface IIntlResource
    {
        /// <summary>
        /// Gets the <see cref="CultureInfo"/> of the current <see cref="IIntlResource"/>
        /// </summary>
        CultureInfo Culture { get; }
    }
}
