using Alrev.Intl.RelativeTime.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Alrev.Intl.DependencyInjection.Tests.RelativeTime
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void AddIntlRelativeTime_ShouldReturn_IServiceCollectionWithExpectedCount()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlRelativeTime();
            Assert.Equal(5, services.Count);
        }

        [Fact]
        public void AddIntlRelativeTimeTwice_ShouldReturn_IServiceCollectionWithExpectedCount()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlRelativeTime();
            services.AddIntlRelativeTime();
            Assert.Equal(5, services.Count);
        }

        [Theory]
        [InlineData(0, "Alrev.Intl.Abstractions.IResourceLocalizer`1[[Alrev.Intl.Abstractions.PluralRules.IPluralRulesCardinalResource", "Alrev.Intl.PluralRules.Globalization.Cardinals.PluralRulesCardinalResourceLocalizer")]
        [InlineData(1, "Alrev.Intl.Abstractions.IResourceLocalizer`1[[Alrev.Intl.Abstractions.PluralRules.IPluralRulesOrdinalResource", "Alrev.Intl.PluralRules.Globalization.Ordinals.PluralRulesOrdinalResourceLocalizer")]
        [InlineData(2, "Alrev.Intl.Abstractions.PluralRules.IPluralRulesEvaluator", "Alrev.Intl.PluralRules.PluralRulesEvaluator")]
        [InlineData(3, "Alrev.Intl.Abstractions.IResourceLocalizer`1[[Alrev.Intl.Abstractions.RelativeTime.IRelativeTimeUnitsResource", "Alrev.Intl.RelativeTime.Globalization.RelativeTimeResourceLocalizer")]
        [InlineData(4, "Alrev.Intl.Abstractions.RelativeTime.IRelativeTime", "Alrev.Intl.RelativeTime.RelativeTimeFormatter")]
        public void AddIntlRelativeTime_ShouldInject_ExpectedSingleton(int index, string serviceType, string implementationType)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlRelativeTime();
            Assert.Equal(implementationType, services[index].ImplementationType.FullName);
            Assert.StartsWith(serviceType, services[index].ServiceType.FullName);
            Assert.Equal(ServiceLifetime.Singleton, services[index].Lifetime);
        }
    }
}
