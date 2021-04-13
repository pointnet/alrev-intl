using System.Collections.Generic;
using System.Globalization;

namespace Alrev.Intl.Abstractions
{
    public interface IResourceLocalizer<T> : IReadOnlyDictionary<string, T> where T : IIntlResource
    {
        bool IsSupported(CultureInfo culture);
        T ResolveResource(CultureInfo culture);
    }
}
