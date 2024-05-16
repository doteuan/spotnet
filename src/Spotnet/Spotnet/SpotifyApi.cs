using System;

namespace Spotnet.Extensions.DependencyInjection
{
    /// <summary>
    /// Struct that represents an instance of the Spotify API, broken down by versions.
    /// </summary>
    public readonly struct SpotifyApi
    {
        /// <summary>
        /// Gets the API reference for v1 of the Spotify API.
        /// </summary>
        public static SpotifyApi V1 => new SpotifyApi(1);

        /// <summary>
        /// Gets the URI of the Spotify API instance.
        /// </summary>
        public Uri Uri { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyApi"/> struct.
        /// </summary>
        /// <param name="versionNumber">The version number required to build the API URI.</param>
        private SpotifyApi(int versionNumber)
        {
            Uri = new Uri($"https://api.spotify.com/v{versionNumber}");
        }
    }
}
