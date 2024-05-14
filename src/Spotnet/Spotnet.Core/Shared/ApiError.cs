using Newtonsoft.Json;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("error")]
        [JsonProperty("error")]
        public ApiErrorDetails Error { get; set; } = null!;
    }

    /// <summary>
    /// Class that represents details for an error response from the Spotify API.
    /// </summary>
    public sealed class ApiErrorDetails
    {
        /// <summary>
        /// Gets or sets the HTTP status code (also returned in the response header; see Response Status Codes for more information).
        /// </summary>
        [JsonPropertyName("status")]
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets a short description of the cause of the error.
        /// </summary>
        [JsonPropertyName("message")]
        [JsonProperty("message")]
        public string Message { get; set; } = null!;
    }
}
