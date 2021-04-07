namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// Interface of a Relative Time resource set
    /// </summary>
    public interface IRelativeTimeResourceSet
    {
        /// <summary>
        /// Gets Era relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Era { get; }

        /// <summary>
        /// Gets Year relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Year { get; }

        /// <summary>
        /// Gets Quarter relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Quarter { get; }

        /// <summary>
        /// Gets Month relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Month { get; }

        /// <summary>
        /// Gets Week relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Week { get; }

        /// <summary>
        /// Gets WeekOfMonth relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource WeekOfMonth { get; }

        /// <summary>
        /// Gets Day relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Day { get; }

        /// <summary>
        /// Gets DayOfYear relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource DayOfYear { get; }

        /// <summary>
        /// Gets Weekday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Weekday { get; }

        /// <summary>
        /// Gets WeekdayOfMonth relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource WeekdayOfMonth { get; }

        /// <summary>
        /// Gets Sunday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Sunday { get; }

        /// <summary>
        /// Gets Monday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Monday { get; }

        /// <summary>
        /// Gets Tuesday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Tuesday { get; }

        /// <summary>
        /// Gets Wednesday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Wednesday { get; }

        /// <summary>
        /// Gets Thursday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Thursday { get; }

        /// <summary>
        /// Gets Friday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Friday { get; }

        /// <summary>
        /// Gets Saturday relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Saturday { get; }

        /// <summary>
        /// Gets DayPeriod relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource DayPeriod { get; }

        /// <summary>
        /// Gets Hour relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Hour { get; }

        /// <summary>
        /// Gets Minute relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Minute { get; }

        /// <summary>
        /// Gets Second relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Second { get; }

        /// <summary>
        /// Gets Zone relative time styles resource
        /// </summary>
        IRelativeTimeStylesResource Zone { get; }
    }
}
