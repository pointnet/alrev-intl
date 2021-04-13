using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.List;
using Alrev.Intl.List.Globalization;

namespace Alrev.Intl.List.Tests.Fixtures
{
    public class ListFormatterFixture
    {
        public IResourceLocalizer<IListResource> Localizer { get; private set; }

        public IListFormatter Formatter { get; private set; }

        public ListFormatterFixture()
        {
            this.Localizer = new ListResourceLocalizer();
            this.Formatter = new ListFormatter(this.Localizer);
        }
    }
}