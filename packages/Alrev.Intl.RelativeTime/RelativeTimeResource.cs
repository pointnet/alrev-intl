using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.RelativeTime;

namespace Alrev.Intl.RelativeTime
{
    public record RelativeTimeResource(
        string Locale,
        RelativeTimeTypeValues RelativeTimeType,
        string DisplayName,
        string Previous,
        string Current,
        string Next,
        IRelativeTimeCountResource Past,
        IRelativeTimeCountResource Future) : IRelativeTimeResource, IResource;
}
