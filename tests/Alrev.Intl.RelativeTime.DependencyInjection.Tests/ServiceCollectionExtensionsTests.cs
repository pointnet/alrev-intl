using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Alrev.Intl.RelativeTime.DependencyInjection.Tests
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void AddIntlRelativeTime_ShouldReturn_IServiceCollectionWithThreeElements()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlRelativeTime();
            Assert.Equal(3, services.Count);
        }

        [Fact]
        public void AddIntlRelativeTimeTwice_ShouldReturn_IServiceCollectionWithThreeElements()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlRelativeTime();
            services.AddIntlRelativeTime();
            Assert.Equal(3, services.Count);
        }

        [Fact]
        public void AddIntlRelativeTime_ShouldInject_RelativeTimeLocalizerSingleton()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlRelativeTime();
            Assert.Equal("Alrev.Intl.RelativeTime.Globalization.RelativeTimeLocalizer", services[1].ImplementationType.FullName);
            Assert.StartsWith("Alrev.Intl.Abstractions.IResourceSetLocalizer`1[[Alrev.Intl.Abstractions.RelativeTime.IRelativeTimeResourceSet", services[1].ServiceType.FullName);
            Assert.Equal(ServiceLifetime.Singleton, services[1].Lifetime);
        }

        [Fact]
        public void AddIntlRelativeTime_ShouldInject_RelativeTimeFormatterSingleton()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddIntlRelativeTime();
            Assert.Equal("Alrev.Intl.RelativeTime.RelativeTimeFormatter", services[2].ImplementationType.FullName);
            Assert.Equal("Alrev.Intl.Abstractions.RelativeTime.IRelativeTimeFormatter", services[2].ServiceType.FullName);
            Assert.Equal(ServiceLifetime.Singleton, services[2].Lifetime);
        }
    }
}
