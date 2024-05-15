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
        public string Url { get; set; } = null!;

        /// <summary>
        /// Gets or sets the image's height in pixels.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the image's width in pixels.
        /// </summary>
        public int Width { get; set; }
    }
}
