using Spotnet.Core.Media;
using System.Collections.Generic;

namespace Spotnet.Core.Artists
{
    /// <summary>
    /// Class that represents an Artist provided by the Spotify API.
    /// </summary>
    public sealed class Artist
    {
        /// <summary>
        /// Gets or sets the known external URLs for this album.
        /// </summary>
        public IDictionary<string, string> ExternalUrls { get; set; } = null!;

        /// <summary>
        /// Gets or sets the artist's followers.
        /// </summary>
        public Followers Followers { get; set; } = null!;

        /// <summary>
        /// Gets or sets the list of genres the artist is associated with.
        /// </summary>
        /// <remarks>
        /// If the artist's genres are not yet classified, the array will be empty.
        /// </remarks>
        public string[] Genres { get; set; } = null!;

        /// <summary>
        /// Gets or sets a link to the Spotify Web API endpoint providing full details of the artist.
        /// </summary>
        public string Href { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify ID</see> for the album.
        /// </summary>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the covert art for the album in various sizes, widest first.
        /// </summary>
        public Image[] Images { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the artist.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the artist's popularity.
        /// </summary>
        /// <remarks>
        /// Value will be between 0 and 100, with 100 being the most popular.
        /// The artist's popularity is calculated from the popularity of all artist's tracks.
        /// </remarks>
        public int Popularity { get; set; }

        /// <summary>
        /// Gets or sets the object type.
        /// </summary>
        /// <remarks>
        /// Allowed values: <c>"artist"</c>
        /// </remarks>
        public string Type { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see cref="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify URI</see> for the artist.
        /// </summary>
        public string Uri { get; set; } = null!;
    }
}
