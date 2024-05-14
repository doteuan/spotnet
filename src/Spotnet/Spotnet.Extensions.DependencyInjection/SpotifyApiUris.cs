#if NETSTANDARD2_1

using System;

#endif

namespace Spotnet.Extensions.DependencyInjection
{
    /// <summary>
    /// Class that holds URIs for the Spotify API.
    /// </summary>
    internal sealed class SpotifyApiUris
    {
        /// <summary>
        /// Gets the URI for v1 of the Spotify API.
        /// </summary>
        internal static Uri V1 => new Uri("https://api.spotify.com/v1");
    }
}
