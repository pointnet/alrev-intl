namespace Alrev.Intl.Abstractions.RelativeTime
{
    public interface IRelativeTimeResourceSet
    {
        IRelativeTimeStylesResource Era { get; }
        IRelativeTimeStylesResource Year { get; }
        IRelativeTimeStylesResource Quarter { get; }
        IRelativeTimeStylesResource Month { get; }
        IRelativeTimeStylesResource Week { get; }
        IRelativeTimeStylesResource WeekOfMonth { get; }
        IRelativeTimeStylesResource Day { get; }
        IRelativeTimeStylesResource DayOfYear { get; }
        IRelativeTimeStylesResource Weekday { get; }
        IRelativeTimeStylesResource WeekdayOfMonth { get; }
        IRelativeTimeStylesResource Sunday { get; }
        IRelativeTimeStylesResource Monday { get; }
        IRelativeTimeStylesResource Tuesday { get; }
        IRelativeTimeStylesResource Wednesday { get; }
        IRelativeTimeStylesResource Thursday { get; }
        IRelativeTimeStylesResource Friday { get; }
        IRelativeTimeStylesResource Saturday { get; }
        IRelativeTimeStylesResource DayPeriod { get; }
        IRelativeTimeStylesResource Hour { get; }
        IRelativeTimeStylesResource Minute { get; }
        IRelativeTimeStylesResource Second { get; }
        IRelativeTimeStylesResource Zone { get; }
    }
}
