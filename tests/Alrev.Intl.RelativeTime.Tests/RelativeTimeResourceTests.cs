using Xunit;

namespace Alrev.Intl.RelativeTime.Tests
{
    public class RelativeTimeResourceTests
    {
        [Fact]
        public void CtorWithNullDictionaries_ShouldReturn_ValidInstanceWithEmptyDictionaries()
        {
            RelativeTimeResource rtr = new RelativeTimeResource(null, null, null);
            Assert.Empty(rtr);
            Assert.Empty(rtr.Past);
            Assert.Empty(rtr.Future);
        }
    }
}
