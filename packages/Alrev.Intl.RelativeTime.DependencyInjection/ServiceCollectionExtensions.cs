using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.RelativeTime;
using Alrev.Intl.PluralRules.DependencyInjection;
using Alrev.Intl.RelativeTime.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Alrev.Intl.RelativeTime.DependencyInjection
{
    /// <summary>
    /// Extension methods for setting up Relative Time in an <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Relative Time to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services"></param>
        /// <returns>The <see cref="IServiceCollection"/> to add services to.</returns>
        public static IServiceCollection AddIntlRelativeTime(this IServiceCollection services)
        {
            services.AddIntlPluralRules();
            services.TryAddSingleton<IResourceLocalizer<IRelativeTimeUnitsResource>, RelativeTimeResourceLocalizer>();
            services.TryAddSingleton<IRelativeTimeFormatter, RelativeTimeFormatter>();
            return services;
        }
    }
}
