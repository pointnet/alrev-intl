using Alrev.Intl.PluralRules.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Alrev.Intl.DependencyInjection.Tests.PluralRules
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void AddIntlPluralRules_ShouldReturn_IServiceCollectionWithExpectedCount()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlPluralRules();
            Assert.Equal(3, services.Count);
        }

        [Fact]
        public void AddIntlPluralRulesTwice_ShouldReturn_IServiceCollectionWithExpectedCount()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlPluralRules();
            services.AddIntlPluralRules();
            Assert.Equal(3, services.Count);
        }

        [Theory]
        [InlineData(0, "Alrev.Intl.Abstractions.IResourceLocalizer`1[[Alrev.Intl.Abstractions.PluralRules.IPluralRulesCardinalResource", "Alrev.Intl.PluralRules.Globalization.Cardinals.PluralRulesCardinalResourceLocalizer")]
        [InlineData(1, "Alrev.Intl.Abstractions.IResourceLocalizer`1[[Alrev.Intl.Abstractions.PluralRules.IPluralRulesOrdinalResource", "Alrev.Intl.PluralRules.Globalization.Ordinals.PluralRulesOrdinalResourceLocalizer")]
        [InlineData(2, "Alrev.Intl.Abstractions.PluralRules.IPluralRulesEvaluator", "Alrev.Intl.PluralRules.PluralRulesEvaluator")]
        public void AddIntlPluralRules_ShouldInject_ExpectedSingleton(int index, string serviceType, string implementationType)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlPluralRules();
            Assert.Equal(implementationType, services[index].ImplementationType.FullName);
            Assert.StartsWith(serviceType, services[index].ServiceType.FullName);
            Assert.Equal(ServiceLifetime.Singleton, services[index].Lifetime);
        }
    }
}
