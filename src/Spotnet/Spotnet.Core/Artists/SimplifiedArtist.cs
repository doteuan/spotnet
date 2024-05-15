using System.Collections.Generic;

namespace Spotnet.Core.Artists
{
    /// <summary>
    /// Class that represents a simplified artist provided by the Spotify API.
    /// </summary>
    public sealed class SimplifiedArtist
    {
        /// <summary>
        /// Gets or sets the known external URLs for the artist.
        /// </summary>
        public IDictionary<string, string> ExternalUrls { get; set; } = null!;

        /// <summary>
        /// Gets or sets the link to the web API endpoint providing full details of the artist.
        /// </summary>
        public string Href { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see cref="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Id</see> of the artist.
        /// </summary>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the artist.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify URI</see> of the artist.
        /// </summary>
        public string Uri { get; set; } = null!;
    }
}
