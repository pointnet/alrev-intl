using System.Collections.Generic;

namespace Alrev.Intl.Abstractions.Tests.Fixtures
{
    public class BaseResourceLocalizerFixture : BaseResourceLocalizer<IIntlResource>
    {
        public BaseResourceLocalizerFixture(IDictionary<string, IIntlResource> dictionary) : base(dictionary)
        {
        }
    }
}
