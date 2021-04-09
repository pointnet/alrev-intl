using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.RelativeTime;
using Alrev.Intl.RelativeTime.Globalization;

namespace Alrev.Intl.RelativeTime.Tests
{
    public class RelativeTimeLocalizerFixture
    {
        public IResourceSetLocalizer<IRelativeTimeResourceSet> Localizer { get; private set; }

        public RelativeTimeLocalizerFixture()
        {
            this.Localizer = new RelativeTimeLocalizer();
        }
    }
}
