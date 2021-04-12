using System;
using System.Globalization;

namespace Alrev.Intl.Abstractions
{
    /// <summary>
    /// Interface of Resource Set Localizer
    /// </summary>
    /// <typeparam name="T">An <see cref="IResource"/></typeparam>
    public interface IResourceSetLocalizer<T>
    {
        /// <summary>
        /// Gets the resource for the specified <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/></param>
        /// <returns>A resource for the specified <see cref="CultureInfo"/> or null</returns>
        /// <remarks>
        /// If the specified <see cref="CultureInfo"/> does not exists, it will try to use the parent <see cref="CultureInfo"/> of the specified one.
        /// If none exists, it will return null.
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        T GetLocalizer(CultureInfo culture);

        /// <summary>
        /// Indicates whether the specified <see cref="CultureInfo"/> is supported
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/> to test</param>
        /// <returns>true if the <see cref="CultureInfo"/> is supported, otherwise false</returns>
        /// <remarks>
        /// If the specified <see cref="CultureInfo"/> does not exists, it will try to use the parent <see cref="CultureInfo"/> of the specified one.
        /// </remarks>
        /// <exception cref="ArgumentNullException"></exception>
        bool IsSupported(CultureInfo culture);
    }
}
