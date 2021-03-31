namespace Alrev.Intl.Abstractions.RelativeTime
{
    public interface IRelativeTimeResource
    {
        RelativeTimeTypeValues RelativeTimeType { get; init; }
        string DisplayName { get; init; }
        string Previous { get; init; }
        string Current { get; init; }
        string Next { get; init; }
        IRelativeTimeCountResource Past { get; init; }
        IRelativeTimeCountResource Future { get; init; }
    }
}
