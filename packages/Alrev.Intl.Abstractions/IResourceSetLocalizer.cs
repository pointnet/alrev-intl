using System.Globalization;

namespace Alrev.Intl.Abstractions
{
    public interface IResourceSetLocalizer<T>
    {
        T CurrentLocalizer { get; }
        T CurrentUILocalizer { get; }
        T GetLocalizer(CultureInfo culture);
    }
}
