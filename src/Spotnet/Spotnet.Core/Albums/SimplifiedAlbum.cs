using Newtonsoft.Json;
using Spotnet.Core.Artists;
using Spotnet.Core.Media;
using System.Text.Json.Serialization;

#if NETSTANDARD2_1

using System.Collections.Generic;

#endif

namespace Spotnet.Core.Albums
{
    /// <summary>
    /// Class that represents an simplified Album provided by the Spotify API.
    /// </summary>
    public sealed class SimplifiedAlbum
    {
        /// <summary>
        /// Gets or sets the type of the album.
        /// </summary>
        [JsonPropertyName("album_type")]
        [JsonProperty("album_type")]
        public string AlbumType { get; set; } = null!;

        /// <summary>
        /// Gets or sets the number of tracks in the album.
        /// </summary>
        [JsonPropertyName("total_tracks")]
        [JsonProperty("total_tracks")]
        public int TotalTracks { get; set; }

        /// <summary>
        /// Gets or sets the markets in which the album is available.
        /// </summary>
        /// <remarks>
        /// Markets are denoted by their <see href="http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2 country codes</see>.<br/>
        /// Example: <c>["CA", "BR", "IT"]</c>
        /// </remarks>
        [JsonPropertyName("available_markets")]
        [JsonProperty("available_markets")]
        public string[] AvailableMarkets { get; set; } = null!;

        /// <summary>
        /// Gets or sets known external URLs for the album.
        /// </summary>
        [JsonPropertyName("external_urls")]
        [JsonProperty("external_urls")]
        public IDictionary<string, string> ExternalUrls { get; set; } = null!;

        /// <summary>
        /// Gets or sets a link to the web API endpoint providing full details of the album.
        /// </summary>
        [JsonPropertyName("href")]
        [JsonProperty("href")]
        public string Href { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Id</see> for the album.
        /// </summary>
        /// <remarks>
        /// Example: <c>"2up3OPMp9Tb4dAKM2erWXQ"</c>
        /// </remarks>
        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the covert art for the album in various sizes, widest first.
        /// </summary>
        [JsonPropertyName("images")]
        [JsonProperty("images")]
        public Image[] Images { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the album.
        /// </summary>
        /// <remarks>
        /// In case of an album takedown, the value may be an empty string.
        /// </remarks>
        [JsonPropertyName("name")]
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date the album was first released.
        /// </summary>
        /// <remarks>
        /// Example: <c>"1981-12"</c>
        /// </remarks>
        [JsonPropertyName("release_date")]
        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; } = null!;

        /// <summary>
        /// Gets or sets the precision with which <see cref="ReleaseDate"/> is known.
        /// </summary>
        /// <remarks>
        /// Allowed values: <c>"year"</c>, <c>"month"</c>, <c>"day"</c><br/>
        /// Example: <c>"year"</c>
        /// </remarks>
        [JsonPropertyName("release_date_precision")]
        [JsonProperty("release_date_precision")]
        public string ReleaseDatePrecision { get; set; } = null!;

        /// <summary>
        /// Gets or sets the restrictions on the album (if applicable).
        /// </summary>
        [JsonPropertyName("restrictions")]
        [JsonProperty("restrictions")]
        public IDictionary<string, string> Restrictions { get; set; } = null!;

        /// <summary>
        /// Gets or sets the object type.
        /// </summary>
        /// <remarks>
        /// Allowed values: <c>"album"</c>
        /// </remarks>
        [JsonPropertyName("type")]
        [JsonProperty("type")]
        public string Type { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see cref="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify URI</see> for the album.
        /// </summary>
        [JsonPropertyName("uri")]
        [JsonProperty("uri")]
        public string Uri { get; set; } = null!;

        /// <summary>
        /// Gets or sets the artists of the album.
        /// </summary>
        /// <remarks>
        /// Each <see cref="SimplifiedArtist"/> includes a link to more detailed information about the artist.
        /// </remarks>
        [JsonPropertyName("artists")]
        [JsonProperty("artists")]
        public SimplifiedArtist[] Artists { get; set; } = null!;
    }
}
