using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Alrev.Intl.Abstractions
{
    /// <summary>
    /// Represents a strongly typed dictionary of objects that can be accessed by string
    /// </summary>
    /// <typeparam name="T">The type of elements in the localizer</typeparam>
    public abstract class BaseResourceLocalizer<T> : ReadOnlyDictionary<string, T>, IResourceLocalizer<T> where T : class, IIntlResource
    {
        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="dictionary">The dictionary whose elements are copied to the new BaseResourceLocalizer.</param>
        protected BaseResourceLocalizer(IDictionary<string, T> dictionary)
            : base(dictionary ?? new Dictionary<string, T>()) { }

        /// <summary>
        /// Gets a value indicating whether the <see cref="CultureInfo"/> is supported
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/></param>
        /// <returns>true if the <see cref="CultureInfo"/> is supported; otherwise, false</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool IsSupported(CultureInfo culture) => culture switch
        {
            null => throw new ArgumentNullException(nameof(culture), "CultureInfo is null"),
            _ => this.ContainsKey(culture.Name.ToLowerInvariant())
                || this.ContainsKey(culture.Parent.Name.ToLowerInvariant())
        };

        /// <summary>
        /// Returns an <see cref="IIntlResource"/> from the current localizer matching the given <see cref="CultureInfo"/>
        /// </summary>
        /// <param name="culture">The <see cref="CultureInfo"/></param>
        /// <returns>An <see cref="IIntlResource"/></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public T ResolveResource(CultureInfo culture) => culture switch
        {
            null => throw new ArgumentNullException(nameof(culture), "CultureInfo is null"),
            _ => this.GetValueOrDefault(culture.Name.ToLowerInvariant(), null)
                ?? this.GetValueOrDefault(culture.Parent.Name.ToLowerInvariant(), null)
        };
    }
}
