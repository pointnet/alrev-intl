using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.PluralRules.Globalization.Cardinals;
using Alrev.Intl.PluralRules.Globalization.Ordinals;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Alrev.Intl.PluralRules.DependencyInjection
{
    /// <summary>
    /// Extension methods for setting up Plural Rules in an <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Plural Rules to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services"></param>
        /// <returns>The <see cref="IServiceCollection"/> to add services to.</returns>
        public static IServiceCollection AddIntlPluralRules(this IServiceCollection services)
        {
            services.TryAddSingleton<IResourceLocalizer<IPluralRulesCardinalResource>, PluralRulesCardinalResourceLocalizer>();
            services.TryAddSingleton<IResourceLocalizer<IPluralRulesOrdinalResource>, PluralRulesOrdinalResourceLocalizer>();
            services.TryAddSingleton<IPluralRulesEvaluator, PluralRulesEvaluator>();
            return services;
        }
    }
}
