#if NETSTANDARD2_1

using System.Collections.Generic;

#endif

using Spotnet.Core.Artists;

namespace Spotnet.Core.Tracks
{
    /// <summary>
    /// Class that represents a simplified track provided by the Spotify API.
    /// </summary>
    public sealed class SimplifiedTrack
    {
        /// <summary>
        /// Gets or sets the artists who performed the track.
        /// </summary>
        /// <remarks>
        /// Each <see cref="SimplifiedArtist"/> includes a link to more detailed information about the artist.
        /// </remarks>
        public SimplifiedArtist[] Artists { get; set; } = null!;

        /// <summary>
        /// Gets or sets a list of countries in which the tracked can be played.
        /// </summary>
        /// <remarks>
        /// Each country is identified by their <see href="http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code.
        /// </remarks>
        public string[] AvailableMarkets { get; set; } = null!;

        /// <summary>
        /// Gets or sets the disc number (usually 1 unless the album consists of more than one disc).
        /// </summary>
        public int DiscNumber { get; set; }

        /// <summary>
        /// Gets or sets the track's length (in milliseconds).
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets whether the track has explicit lyrics.
        /// </summary>
        /// <remarks>
        /// Value will be <see langword="true"/> if track contains explicit lyrics.
        /// Value will be <see langword="false"/> if track does not contain explicit lyrics or explicit status is unknown.
        /// </remarks>
        public bool Explicit { get; set; }

        /// <summary>
        /// Gets or sets the track's external URLs.
        /// </summary>
        public IDictionary<string, string> ExternalUrls { get; set; } = null!;

        /// <summary>
        /// Gets or sets a link to the web API endpoint providing full details of the track.
        /// </summary>
        public string Href { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Id</see> of the track.
        /// </summary>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets whether the track is playable in the given market.
        /// </summary>
        /// <remarks>
        /// Part of the response when <see href="https://developer.spotify.com/documentation/web-api/concepts/track-relinking">Track Relinking</see> is applied.
        /// </remarks>
        public bool IsPlayable { get; set; }

        /// <summary>
        /// Gets or sets the content restrictions to the track.
        /// </summary>
        public IDictionary<string, string> Restrictions { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the track.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the URL to a thirty second preview (MP3 format) of the track.
        /// </summary>
        /// <remarks>
        /// Spotify audio preview clips can not be a standalone service. Audio preview clips
        /// may not be offered as a standalone service or product. <see cref="https://developer.spotify.com/policy/#ii-respect-content-and-creators">More information</see>.
        /// </remarks>
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Gets or sets the number of the track. If an album has several discs, the track number is the number on the specified disc.
        /// </summary>
        public int TrackNumber { get; set; }

        /// <summary>
        /// Gets or sets the object type.
        /// </summary>
        /// <remarks>
        /// Allowed values: <c>"track"</c>
        /// </remarks>
        public string Type { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see cref="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify URI</see> of the track.
        /// </summary>
        public string Uri { get; set; } = null!;

        /// <summary>
        /// Gets or sets whether the track is from a local file.
        /// </summary>
        public bool IsLocal { get; set; }
    }
}
