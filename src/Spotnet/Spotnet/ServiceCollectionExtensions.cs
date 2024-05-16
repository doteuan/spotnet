using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using Spotnet.Core.Albums;
using Spotnet.Extensions.DependencyInjection.Authentication;
using Spotnet.Extensions.DependencyInjection.Configuration;

namespace Spotnet.Extensions.DependencyInjection
{
    /// <summary>
    /// Extensions class responsible for providing extensions to a <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Spotnet to a service collection with default settings.
        /// </summary>
        /// <remarks>
        /// See <see cref="RefitSettings()"/> for default Refit settings.
        /// </remarks>
        /// <param name="services">The service collection to add dependencies to.</param>
        /// <returns>An <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection AddSpotnet(this IServiceCollection services)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            var contentSerializerOpts = new JsonSerializerOptions()
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                DictionaryKeyPolicy = JsonNamingPolicy.SnakeCaseLower,
                ReadCommentHandling = JsonCommentHandling.Skip
            };

            var contentSerializer = new SystemTextJsonContentSerializer(contentSerializerOpts);
            var refitSettings = new RefitSettings(contentSerializer);

            services.AddRefitClient<IAlbumApi>(refitSettings)
                .ConfigureHttpClient(httpClient =>
                {
                    httpClient.BaseAddress = SpotifyApi.V1.Uri;
                })
                .AddHttpMessageHandler<BearerAuthenticationHttpMessageHandler>();

            return services;
        }

        /// <summary>
        /// Adds Spotnet to the service collection, invoking the <paramref name="configure"/> callback to allow for
        /// customization of Spotnet services.
        /// </summary>
        /// <param name="services">The service collection to add dependencies to.</param>
        /// <param name="configure">Configuration callback that is used to configure Spotnet.</param>
        /// <returns>An <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection AddSpotnet(this IServiceCollection services, Func<SpotnetConfigurator, SpotnetConfigurator> configure)
        {
            if (services is null)
                throw new ArgumentException(nameof(services));

            if (configure is null)
                throw new ArgumentNullException(nameof(configure));

            // Implementation...

            return services;
        }

        /// <summary>
        /// Adds Spotnet to the service collection, with a desired <see cref="SpotifyApi"/> version. Additionally
        /// invoking the <paramref name="configure"/> callback to allow for customization of Spotnet services.
        /// </summary>
        /// <param name="services">The service collection to add dependencies to.</param>
        /// <param name="targetApi">The desired Spotify API to be used by all services.</param>
        /// <param name="configure">Configuration callback that is used to configure Spotnet.</param>
        /// <returns></returns>
        public static IServiceCollection AddSpotnet(this IServiceCollection services, SpotifyApi targetApi, Func<SpotnetConfigurator, SpotnetConfigurator> configure)
        {
            if (services is null)
                throw new ArgumentException(nameof(services));

            if (configure is null)
                throw new ArgumentNullException(nameof(configure));

            // Implementation...

            return services;
        }
    }
}
