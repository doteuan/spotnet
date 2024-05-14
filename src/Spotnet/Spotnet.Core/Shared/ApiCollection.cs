using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Spotnet.Core.Shared
{
    /// <summary>
    /// Class that represents a collection provided by the Spotify API.
    /// </summary>
    /// <typeparam name="T">The type of item to construct a paged set of.</typeparam>
    public sealed class ApiCollection<T> where T : class
    {
        /// <summary>
        /// Gets or sets a link to the web API endpoint returning the full details of the track.
        /// </summary>
        [JsonPropertyName("href")]
        [JsonProperty("href")]
        public string Href { get; set; } = null!;

        /// <summary>
        /// Gets or sets the maximum number of items in the response (as set in the query or by default).
        /// </summary>
        [JsonPropertyName("limit")]
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the URL to the next page of items.
        /// </summary>
        /// <remarks>
        /// Value will be <see langword="null"/> if there are none.
        /// </remarks>
        [JsonPropertyName("next")]
        [JsonProperty("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Gets or sets the offset of the items returned (as set in the query or by default).
        /// </summary>
        [JsonPropertyName("offset")]
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the URL to the previous page of items.
        /// </summary>
        /// <remarks>
        /// Value will be <see langword="null"/> if there are none.
        /// </remarks>
        [JsonPropertyName("previous")]
        [JsonProperty("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// Gets or sets the total number of items available to return.
        /// </summary>
        [JsonPropertyName("total")]
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets the items in the page.
        /// </summary>
        [JsonPropertyName("items")]
        [JsonProperty("items")]
        public T[] Items { get; set; } = null!;
    }
}
