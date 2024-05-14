using Newtonsoft.Json;
using System.Text.Json.Serialization;

#if NETSTANDARD2_1

using System.Collections.Generic;

#endif

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
        [JsonPropertyName("external_urls")]
        [JsonProperty("external_urls")]
        public IDictionary<string, string> ExternalUrls { get; set; } = null!;

        /// <summary>
        /// Gets or sets the link to the web API endpoint providing full details of the artist.
        /// </summary>
        [JsonPropertyName("href")]
        [JsonProperty("href")]
        public string Href { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see cref="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Id</see> of the artist.
        /// </summary>
        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the artist.
        /// </summary>
        [JsonPropertyName("name")]
        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify URI</see> of the artist.
        /// </summary>
        [JsonPropertyName("uri")]
        [JsonProperty("uri")]
        public string Uri { get; set; } = null!;
    }
}
