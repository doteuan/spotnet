namespace Spotnet.Core.Shared
{
    /// <summary>
    /// Class that represents details for an error response from the Spotify API.
    /// </summary>
    public sealed class ApiErrorDetails
    {
        /// <summary>
        /// Gets or sets the HTTP status code (also returned in the response header; see Response Status Codes for more information).
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets a short description of the cause of the error.
        /// </summary>
        public string Message { get; set; } = null!;
    }
}