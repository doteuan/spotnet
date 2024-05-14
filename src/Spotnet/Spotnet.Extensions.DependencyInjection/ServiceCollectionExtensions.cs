using Microsoft.Extensions.DependencyInjection;
using Refit;
using Spotnet.Core.Albums;
using Spotnet.Extensions.DependencyInjection.Authentication;

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
            var refitSettings = new RefitSettings();

            services.AddRefitClient<IAlbumApi>(refitSettings)
                .ConfigureHttpClient(httpClient =>
                {
                    httpClient.BaseAddress = SpotifyApiUris.V1;
                })
                .AddHttpMessageHandler<BearerAuthenticationHttpMessageHandler>();

            return services;
        }
    }
}
