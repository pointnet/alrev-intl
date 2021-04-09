using Alrev.Intl.Abstractions.RelativeTime;

namespace Alrev.Intl.RelativeTime.Tests
{
    public class RelativeTimeFormatterFixture
    {
        public IRelativeTimeFormatter Formatter { get; private set; }

        public RelativeTimeFormatterFixture()
        {
            this.Formatter = new RelativeTimeFormatter();
        }
    }
}
