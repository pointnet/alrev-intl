namespace Alrev.Intl.Abstractions.RelativeTime
{
    public interface IRelativeTimeResource
    {
        RelativeTimeTypeValues RelativeTimeType { get; init; }
        string DisplayName { get; init; }
        string Previous { get; init; }
        string Current { get; init; }
        string Next { get; init; }
        IRelativeTimeResourceCount Past { get; init; }
        IRelativeTimeResourceCount Future { get; init; }
    }
}
