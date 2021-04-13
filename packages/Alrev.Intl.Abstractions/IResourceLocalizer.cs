using System;
using System.Collections.Generic;
using System.Globalization;

namespace Alrev.Intl.Abstractions
{
    /// <summary>
    /// Defines a strongly typed dictionary of objects that can be accessed by string
    /// </summary>
    /// <typeparam name="T">The type of elements in the localizer</typeparam>
    public interface IResourceLocalizer<T> : IReadOnlyDictionary<string, T> where T : IIntlResource
    {
        /// <summary>
        /// Gets a value indicating whether the <see cref="CultureInfo"/> is supported
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/></param>
        /// <returns>true if the <see cref="CultureInfo"/> is supported; otherwise, false</returns>
        /// <exception cref="ArgumentNullException"></exception>
        bool IsSupported(CultureInfo culture);

        /// <summary>
        /// Returns an <see cref="IIntlResource"/> from the current localizer matching the given <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/></param>
        /// <returns>An <see cref="IIntlResource"/></returns>
        /// <exception cref="ArgumentNullException"></exception>
        T ResolveResource(CultureInfo culture);
    }
}
