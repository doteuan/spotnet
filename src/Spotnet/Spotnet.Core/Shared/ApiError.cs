namespace Spotnet.Core.Shared
{
    /// <summary>
    /// Class that represents an error response from the Spotify API.
    /// </summary>
    public sealed class ApiError
    {
        /// <summary>
        /// Gets or sets the error that was provided by the Spotify API.
        /// </summary>
        public ApiErrorDetails Error { get; set; } = null!;
    }
}