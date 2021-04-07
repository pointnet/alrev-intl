using Alrev.Intl.RelativeTime.Globalization;

namespace Alrev.Intl.RelativeTime.Tests
{
    public class RelativeTimeLocalizerFixture
    {
        public RelativeTimeLocalizer Localizer { get; private set; }

        public RelativeTimeLocalizerFixture()
        {
            this.Localizer = new RelativeTimeLocalizer();
        }
    }
}
