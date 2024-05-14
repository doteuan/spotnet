using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Spotnet.Core.Media
{
    /// <summary>
    /// Class that represents an image provided by the Spotify API.
    /// </summary>
    public sealed class Image
    {
        /// <summary>
        /// Gets or sets the source URL of the image.
        /// </summary>
        [JsonPropertyName("url")]
        [JsonProperty("url")]
        public string Url { get; set; } = null!;

        /// <summary>
        /// Gets or sets the image's height in pixels.
        /// </summary>
        [JsonPropertyName("height")]
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the image's width in pixels.
        /// </summary>
        [JsonPropertyName("width")]
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}
