using Libraries.Providers.DateTime.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Libraries.Providers.DateTime.Extensions
{
    /// <summary>
    /// The <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register UTC Date Time Provider.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> when <see cref="IServiceCollection"/> is null.</exception>
        public static IServiceCollection AddUtcDateTimeProvider(this IServiceCollection services)
        {
            _ = services ?? throw new ArgumentNullException(nameof(services));
            services.TryAddSingleton<IDateTimeProvider, UtcDateTimeProvider>();

            return services;
        }

        /// <summary>
        /// Register Locale Date Time Provider.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> when <see cref="IServiceCollection"/> is null.</exception>
        public static IServiceCollection AddLocaleTimeProvider(this IServiceCollection services)
        {
            _ = services ?? throw new ArgumentNullException(nameof(services));
            services.TryAddSingleton<IDateTimeProvider, LocaleDateTimeProvider>();

            return services;
        }
    }
}
