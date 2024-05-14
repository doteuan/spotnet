using Microsoft.Extensions.Caching.Distributed;

#if NETSTANDARD2_1

using System;
using System.Net.Http;
using System.Net.Http.Headers;

#endif

namespace Spotnet.Extensions.DependencyInjection.Authentication
{
    /// <summary>
    /// Class that represents a HTTP message handler responsible for authentication.
    /// </summary>
    internal sealed class BearerAuthenticationHttpMessageHandler : DelegatingHandler
    {
        private const string BearerAuthorizationHeaderName = "Bearer";

        private readonly IDistributedCache _distributedCache;

        /// <summary>
        /// Initializes a new instance of the <see cref="BearerAuthenticationHttpMessageHandler"/> class.
        /// </summary>
        /// <param name="distributedCache">A distributed cache for caching authentication tokens.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public BearerAuthenticationHttpMessageHandler(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache ?? throw new ArgumentNullException(nameof(distributedCache));
        }

        //protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
        //{
        //    return base.Send(request, cancellationToken);
        //}

        //protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        //{
        //    var authToken = await _distributedCache.GetStringAsync("", cancellationToken)
        //        .ConfigureAwait(false);

        //    if (!string.IsNullOrEmpty(authToken))
        //    {
        //        request.Headers.Authorization = new AuthenticationHeaderValue(BearerAuthorizationHeaderName, authToken);
        //        return await base.SendAsync(request, cancellationToken)
        //            .ConfigureAwait(false);
        //    }


        //}
    }
}
