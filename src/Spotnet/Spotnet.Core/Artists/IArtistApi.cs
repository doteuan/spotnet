using Refit;
using Spotnet.Core.Albums;
using Spotnet.Core.Shared;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Spotnet.Core.Artists
{
    /// <summary>
    /// Interface that represents an API for sending requests to Spotify's Artist API.
    /// </summary>
    [Headers("Authorization: Bearer")]
    public interface IArtistApi
    {
        /// <summary>
        /// Get Spotify catalog information for a single artist.
        /// </summary>
        /// <remarks>
        /// Responses:<br/>
        /// <c>200 OK</c> - <see cref="Artist"/><br/>
        /// <c>400 Bad Request</c> - <see cref="ApiError"/><br/>
        /// <c>401 Unauthorized</c> - <see cref="ApiError"/><br/>
        /// <c>403 Forbidden</c> - <see cref="ApiError"/><br/>
        /// <c>429 Too Many Requests</c> - <see cref="ApiError"/><br/>
        /// For full documentation, see <see href="https://developer.spotify.com/documentation/web-api/reference/get-an-artist"/>.
        /// </remarks>
        /// <param name="id">The <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Id</see> of the album.</param>
        /// <param name="cancellationToken">A stopping token used to monitor for cancellation requests.</param>
        /// <returns></returns>
        [Get("/artists/{id}")]
        ValueTask<ApiResponse<Artist>> GetArtistAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Spotify catalog information for various artists.
        /// </summary>
        /// <remarks>
        /// Responses:<br/>
        /// <c>200 OK</c> - <see cref="IReadOnlyList{T}"/> of <see cref="Artist"/><br/>
        /// <c>400 Bad Request</c> - <see cref="ApiError"/><br/>
        /// <c>401 Unauthorized</c> - <see cref="ApiError"/><br/>
        /// <c>403 Forbidden</c> - <see cref="ApiError"/><br/>
        /// <c>429 Too Many Requests</c> - <see cref="ApiError"/><br/>
        /// For full documentation, see <see href="https://developer.spotify.com/documentation/web-api/reference/get-multiple-artists"/>.
        /// </remarks>
        /// <param name="ids">The <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Ids</see> of the albums. Maximum is 20.</param>
        /// <param name="cancellationToken">A stopping token used to monitor for cancellation requests.</param>
        /// <returns></returns>
        [Get("/artists")]
        ValueTask<ApiResponse<IReadOnlyList<Artist>>> GetArtistsAsync([Query(CollectionFormat.Csv)] string[] ids,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Spotify catalog information about an artist's albums.
        /// </summary>
        /// <remarks>
        /// Responses:<br/>
        /// <c>200 OK</c> - <see cref="ApiCollection{T}{T}"/> of <see cref="SimplifiedAlbum"/><br/>
        /// <c>400 Bad Request</c> - <see cref="ApiError"/><br/>
        /// <c>401 Unauthorized</c> - <see cref="ApiError"/><br/>
        /// <c>403 Forbidden</c> - <see cref="ApiError"/><br/>
        /// <c>429 Too Many Requests</c> - <see cref="ApiError"/><br/>
        /// For full documentation, see <see href="https://developer.spotify.com/documentation/web-api/reference/get-multiple-artists"/>.
        /// </remarks>
        /// <param name="id">The <see href="https://developer.spotify.com/documentation/web-api/concepts/spotify-uris-ids">Spotify Id</see> of the album.</param>
        /// <param name="includeGroups">A comma-seperated lsit of keywords that will be used to filter the response.</param>
        /// <param name="market"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Get("/artists/{id}/albums")]
        ValueTask<ApiResponse<ApiCollection<SimplifiedAlbum>>> GetArtistAlbumsAsync(string id,
            [Query(CollectionFormat.Csv)] string? includeGroups, string? market = null, int limit = 20, int offset = 0,
            CancellationToken cancellationToken = default);
    }
}
