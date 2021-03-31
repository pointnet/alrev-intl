namespace Alrev.Intl.Abstractions.RelativeTime
{
    public interface IRelativeTimeStylesResource
    {
        IRelativeTimeResource LongStyle { get; }
        IRelativeTimeResource NarrowStyle { get; }
        IRelativeTimeResource ShortStyle { get; }
    }
}
