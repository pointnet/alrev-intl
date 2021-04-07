using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.RelativeTime;

namespace Alrev.Intl.RelativeTime
{
    /// <summary>
    /// Relative Time styles resource
    /// </summary>
    public record RelativeTimeStylesResource(
        string Locale,
        IRelativeTimeResource LongRelativeTimeResource,
        IRelativeTimeResource NarrowRelativeTimeResource,
        IRelativeTimeResource ShortRelativeTimeResource) : IRelativeTimeStylesResource, IResource;
}