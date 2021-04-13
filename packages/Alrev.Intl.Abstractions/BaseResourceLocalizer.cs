using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Alrev.Intl.Abstractions
{
    public abstract class BaseResourceLocalizer<T> : ReadOnlyDictionary<string, T>, IResourceLocalizer<T> where T : class, IIntlResource
    {
        protected BaseResourceLocalizer(IDictionary<string, T> dictionary)
            : base(dictionary ?? new Dictionary<string, T>()) { }

        public bool IsSupported(CultureInfo culture) => culture switch
        {
            null => throw new ArgumentNullException(nameof(culture), "CultureInfo is null"),
            _ => this.ContainsKey(culture.Name.ToLowerInvariant())
                || this.ContainsKey(culture.Parent.Name.ToLowerInvariant())
        };

        public T ResolveResource(CultureInfo culture) => culture switch
        {
            null => throw new ArgumentNullException(nameof(culture), "CultureInfo is null"),
            _ => this.GetValueOrDefault(culture.Name.ToLowerInvariant(), null)
                ?? this.GetValueOrDefault(culture.Parent.Name.ToLowerInvariant(), null)
        };
    }
}
