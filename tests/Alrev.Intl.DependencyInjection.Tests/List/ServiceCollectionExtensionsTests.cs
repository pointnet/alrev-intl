//using Alrev.Intl.List.DependencyInjection;
//using Microsoft.Extensions.DependencyInjection;
//using Xunit;

//namespace Alrev.Intl.DependencyInjection.Tests.List
//{
//    public class ServiceCollectionExtensionsTests
//    {
//        [Fact]
//        public void AddIntlList_ShouldReturn_IServiceCollectionWithExpectedCount()
//        {
//            IServiceCollection services = new ServiceCollection();
//            services.AddIntlList();
//            Assert.Equal(2, services.Count);
//        }

//        [Fact]
//        public void AddIntlListTwice_ShouldReturn_IServiceCollectionWithExpectedCount()
//        {
//            IServiceCollection services = new ServiceCollection();
//            services.AddIntlList();
//            services.AddIntlList();
//            Assert.Equal(2, services.Count);
//        }

//        [Theory]
//        [InlineData(0, "Alrev.Intl.Abstractions.IResourceLocalizer`1[[Alrev.Intl.Abstractions.List.IListResource", "Alrev.Intl.List.Globalization.ListResourceLocalizer")]
//        [InlineData(1, "Alrev.Intl.Abstractions.List.IListFormatter", "Alrev.Intl.List.ListFormatter")]
//        public void AddIntlList_ShouldInject_ExpectedSingleton(int index, string serviceType, string implementationType)
//        {
//            IServiceCollection services = new ServiceCollection();
//            services.AddIntlList();
//            Assert.Equal(implementationType, services[index].ImplementationType.FullName);
//            Assert.StartsWith(serviceType, services[index].ServiceType.FullName);
//            Assert.Equal(ServiceLifetime.Singleton, services[index].Lifetime);
//        }
//    }
//}
