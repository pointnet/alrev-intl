using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Alrev.Intl.PluralRules.DependencyInjection.Tests
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void AddIntlPluralRules_ShouldReturn_IServiceCollectionWithOneElement()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlPluralRules();
            Assert.Equal(1, services.Count);
        }

        [Fact]
        public void AddIntlPluralRulesTwice_ShouldReturn_IServiceCollectionWithOneElement()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlPluralRules();
            services.AddIntlPluralRules();
            Assert.Equal(1, services.Count);
        }

        [Fact]
        public void AddIntlPluralRules_ShouldInject_PluralRulesEvaluator()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlPluralRules();
            Assert.IsType<PluralRulesEvaluator>(services[0].ImplementationInstance);
            Assert.Equal("Alrev.Intl.Abstractions.PluralRules.IPluralRulesEvaluator", services[0].ServiceType.FullName);
            Assert.Equal(ServiceLifetime.Singleton, services[0].Lifetime);
        }
    }
}
