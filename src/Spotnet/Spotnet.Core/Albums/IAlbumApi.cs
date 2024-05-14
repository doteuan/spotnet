using Refit;
using Spotnet.Core.Shared;
using Spotnet.Core.Tracks;

#if NETSTANDARD2_1

using System.Threading;
using System.Threading.Tasks;

#endif

namespace Spotnet.Core.Albums
{
    /// <summary>
    /// Interface that represents an API for sending requests to Spotify's Album API.
    /// </summary>
    [Headers("Authorization: Bearer")]
    public interface IAlbumApi
    {
        /// <summary>
        /// Get Spotify catalog information for a single album.
        /// </summary>
        /// <remarks>
        /// Responses:<br/>
        /// <c>200 OK</c> - <see cref="Album"/><br/>
        /// <c>400 Bad Request</c> - <see cref="ApiError"/><br/>
        /// <c>401 Unauthorized</c> - <see cref="ApiError"/><br/>
        /// <c>403 Forbidden</c> - <see cref="ApiError"/><br/>
        /// <c>429 Too Many Requests</c> - <see cref="ApiError"/><br/>
        /// For full documentation, see <see href="https://developer.spotify.com/documentation/web-api/reference/get-an-album"/>.
        /// </remarks>
        /// <param name="id">The <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Id</see> of the album.</param>
        /// <param name="market">An <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2 country code</see>.</param>
        /// <param name="cancellationToken">A stopping token used to monitor for cancellation requests.</param>
        /// <returns></returns>
        [Get("/albums/{id}")]
        ValueTask<ApiResponse<Album>> GetAlbumAsync(string id,
            string? market = null,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Spotify catalog information for various albums.
        /// </summary>
        /// <param name="ids">The <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Ids</see> of the albums. Maximum is 20.</param>
        /// <param name="market">An <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2 country code</see>.</param>
        /// <param name="cancellationToken">A stopping token used to monitor for cancellation requests.</param>
        /// <returns>
        /// <para>An <see cref="ApiResponse{T}"/> of <see cref="Array"/> of <see cref="Album"/> if successful.</para>
        /// <para>Consult <see cref="ApiResponse{T}.Error"/> for error information.</para>
        /// </returns>
        [Get("/albums")]
        ValueTask<ApiResponse<Album[]>> GetAlbumsAsync([Query(CollectionFormat.Csv)] string[] ids,
            string? market = null,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Spotify catalog information for an album's tracks. Optional parameters can be used to limit the number of tracks returned.
        /// </summary>
        /// <remarks>
        ///     The API will return one of the following responses:
        ///     <para>
        ///         <c>200 OK</c> - <see cref="ApiCollection{T}"/> of <see cref="SimplifiedTrack"/>    
        ///     </para>
        ///     <para>
        ///         <c>400 Bad Request</c> - <see cref="ApiError"/>
        ///     </para>
        ///     <para>
        ///         <c>401 Unauthorized</c> - <see cref="ApiError"/>
        ///     </para>
        ///     <para>
        ///         <c>403 Forbidden</c> - <see cref="ApiError"/>
        ///     </para>
        ///     <para>
        ///         <c>429 Too Many Requests</c> - <see cref="ApiError"/>
        ///     </para>
        /// </remarks>
        /// <param name="id">The <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Id</see> of the album.</param>
        /// <param name="market">An <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2 country code</see>.</param>
        /// <param name="limit">The maximum number of items to return. Defaults to 20, must be between 1 and 50 (inclusive).</param>
        /// <param name="offset">The index of the first item to return. Defaults to 0 (the first item). Use with <paramref name="limit"/> to get the next set of items.</param>
        /// <param name="cancellationToken">A stopping token used to monitor for cancellation requests.</param>
        /// <returns></returns>
        [Get("/albums/{id}/tracks")]
        ValueTask<ApiResponse<ApiCollection<SimplifiedTrack>>> GetAlbumTracksAsync(
            string id,
            string? market = null,
            int limit = 20,
            int offset = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of new album releases featured in Spotify (shown, for example, on a Spotify player's "Browse" tab).
        /// </summary>
        /// <remarks>
        ///     The API will return one of the following responses:
        ///     <para>
        ///         <c>200 OK</c> - <see cref="ApiCollection{T}"/> of <see cref="SimplifiedAlbum"/>    
        ///     </para>
        ///     <para>
        ///         <c>400 Bad Request</c> - <see cref="ApiError"/>
        ///     </para>
        ///     <para>
        ///         <c>401 Unauthorized</c> - <see cref="ApiError"/>
        ///     </para>
        ///     <para>
        ///         <c>403 Forbidden</c> - <see cref="ApiError"/>
        ///     </para>
        ///     <para>
        ///         <c>429 Too Many Requests</c> - <see cref="ApiError"/>
        ///     </para>
        /// </remarks>
        /// <param name="limit">The maximum number of items to return. Defaults to 20, must be between 1 and 50 (inclusive).</param>
        /// <param name="offset">The index of the first item to return. Defaults to 0 (the first item). Use with <paramref name="limit"/> to get the next set of items.</param>
        /// <returns></returns>
        [Get("/browse/new-releases")]
        ValueTask<ApiResponse<ApiCollection<SimplifiedAlbum>>> GetNewReleasesAsync(int limit = 20, int offset = 0, CancellationToken cancellationToken = default);
    }
}
