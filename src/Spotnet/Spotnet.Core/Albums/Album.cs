using Spotnet.Core.Artists;
using Spotnet.Core.Media;
using Spotnet.Core.Shared;
using System.Collections.Generic;

namespace Spotnet.Core.Albums
{
    /// <summary>
    /// Class that represents an Album provided by the Spotify API.
    /// </summary>
    public sealed class Album
    {
        /// <summary>
        /// Gets or sets the type of the album.
        /// </summary>
        public string AlbumType { get; set; } = null!;

        /// <summary>
        /// Gets or sets the number of tracks in the album.
        /// </summary>
        public int TotalTracks { get; set; }

        /// <summary>
        /// Gets or sets the markets in which the album is available.
        /// </summary>
        /// <remarks>
        /// Markets are denoted by their <see href="http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2 country codes</see>.<br/>
        /// Example: <c>["CA", "BR", "IT"]</c>
        /// </remarks>
        public string[] AvailableMarkets { get; set; } = null!;

        /// <summary>
        /// Gets or sets the known external URLs for this album.
        /// </summary>
        public IDictionary<string, string> ExternalUrls { get; set; } = null!;

        /// <summary>
        /// Gets or sets the link to the web API endpoint providing full details of the album.
        /// </summary>
        public string Href { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify ID</see> for the album.
        /// </summary>
        /// <remarks>
        /// Example: <c>"2up3OPMp9Tb4dAKM2erWXQ"</c>
        /// </remarks>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the covert art for the album in various sizes, widest first.
        /// </summary>
        public Image[] Images { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the album.
        /// </summary>
        /// <remarks>
        /// In case of an album takedown, the value may be an empty string.
        /// </remarks>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date the album was first released.
        /// </summary>
        /// <remarks>
        /// Example: <c>"1981-12"</c>
        /// </remarks>
        public string ReleaseDate { get; set; } = null!;

        /// <summary>
        /// Gets or sets the precision with which <see cref="ReleaseDate"/> is known.
        /// </summary>
        /// <remarks>
        /// Allowed values: <c>"year"</c>, <c>"month"</c>, <c>"day"</c><br/>
        /// Example: <c>"year"</c>
        /// </remarks>
        public string ReleaseDatePrecision { get; set; } = null!;

        /// <summary>
        /// Gets or sets the restrictions on the album (if applicable).
        /// </summary>
        public IDictionary<string, string> Restrictions { get; set; } = null!;

        /// <summary>
        /// Gets or sets the object type.
        /// </summary>
        /// <remarks>
        /// Allowed values: <c>"album"</c>
        /// </remarks>
        public string Type { get; set; } = null!;

        /// <summary>
        /// Gets or sets the <see cref="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify URI</see> for the album.
        /// </summary>
        public string Uri { get; set; } = null!;

        /// <summary>
        /// Gets or sets the artists of the album.
        /// </summary>
        /// <remarks>
        /// Each <see cref="SimplifiedArtist"/> includes a link to more detailed information about the artist.
        /// </remarks>
        public SimplifiedArtist[] Artists { get; set; } = null!;

        /// <summary>
        /// Gets or sets the copyright statements for the album.
        /// </summary>
        public Copyright[] Copyrights { get; set; } = null!;

        /// <summary>
        /// Gets or sets the known external IDs for the album.
        /// </summary>
        /// <remarks>
        /// May contain the following keys:<br/>
        /// <c>'isrc'</c> - <see href="http://en.wikipedia.org/wiki/International_Standard_Recording_Code">International Standard Recording Code</see><br/>
        /// <c>'ean'</c> - <see href="http://en.wikipedia.org/wiki/International_Article_Number_%28EAN%29">International Article Number</see><br/>
        /// <c>'upc'</c> - <see href="http://en.wikipedia.org/wiki/Universal_Product_Code">Universal Product Code</see>
        /// </remarks>
        public IDictionary<string, string> ExternalIds { get; set; } = null!;

        /// <summary>
        /// Gets or sets the list of genres the album is associated with.
        /// </summary>
        /// <remarks>
        /// If the album is yet to be classified, the array will be empty.<br/>
        /// Example: <c>["Egg punk", "Noise rock"]</c>
        /// </remarks>
        public string[] Genres { get; set; } = null!;

        /// <summary>
        /// Gets or sets the label associated with the album.
        /// </summary>
        public string Label { get; set; } = null!;

        /// <summary>
        /// Gets or sets the popularity of the album.
        /// </summary>
        /// <remarks>
        /// The value will be between 0 and 100, with 100 being the most popular.
        /// </remarks>
        public int Popularity { get; set; }
    }
}
