using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.RelativeTime;

namespace Alrev.Intl.RelativeTime
{
    public record RelativeTimeStylesResource(
        string Locale,
        IRelativeTimeResource LongRelativeTimeResource,
        IRelativeTimeResource NarrowRelativeTimeResource,
        IRelativeTimeResource ShortRelativeTimeResource) : IRelativeTimeStylesResource, IResource;
}
