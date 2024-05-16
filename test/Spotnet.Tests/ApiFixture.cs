using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Spotnet.Extensions.DependencyInjection;
using Spotnet.Extensions.DependencyInjection.Authentication;

namespace Spotnet.Tests
{
    public sealed class ApiFixture
    {
        internal const string HttpClientName = "SpotnetHttpClient";

        internal IHttpClientFactory HttpClientFactory { get; init; }

        public ApiFixture()
        {
            var builder = Host.CreateApplicationBuilder();

            builder.Services.AddDistributedMemoryCache()
                .AddTransient<BearerAuthenticationHttpMessageHandler>()
                .AddHttpClient(HttpClientName, httpClient => httpClient.BaseAddress = SpotifyApi.V1.Uri)
                .AddHttpMessageHandler<BearerAuthenticationHttpMessageHandler>();

            var host = builder.Build();

            HttpClientFactory = host.Services.GetRequiredService<IHttpClientFactory>();
        }
    }
}
