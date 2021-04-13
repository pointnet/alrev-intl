using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.List;
using Alrev.Intl.List.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Alrev.Intl.List.DependencyInjection
{
    /// <summary>
    /// Extension methods for setting up Alrev.Intl.List in an <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Alrev.Intl.List to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services"></param>
        /// <returns>The <see cref="IServiceCollection"/> to add services to.</returns>
        public static IServiceCollection AddIntlList(this IServiceCollection services)
        {
            services.TryAddSingleton<IResourceLocalizer<IListResource>, ListResourceLocalizer>();
            services.TryAddSingleton<IListFormatter, ListFormatter>();
            return services;
        }
    }
}
