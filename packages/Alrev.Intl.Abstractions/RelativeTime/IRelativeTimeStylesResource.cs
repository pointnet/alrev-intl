namespace Alrev.Intl.Abstractions.RelativeTime
{
    public interface IRelativeTimeStylesResource
    {
        IRelativeTimeResource LongRelativeTimeResource { get; }
        IRelativeTimeResource NarrowRelativeTimeResource { get; }
        IRelativeTimeResource ShortRelativeTimeResource { get; }
    }
}
