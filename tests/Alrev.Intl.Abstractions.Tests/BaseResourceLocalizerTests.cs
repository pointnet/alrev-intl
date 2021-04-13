using Alrev.Intl.Abstractions.Tests.Fixtures;
using Xunit;

namespace Alrev.Intl.Abstractions.Tests
{
    public class BaseResourceLocalizerTests
    {
        [Fact]
        public void CtorWithNullDictionary_ShouldReturn_ValidInstanceWithEmptyDictionary()
        {
            BaseResourceLocalizerFixture brl = new(null);
            Assert.Empty(brl);
        }
    }
}
