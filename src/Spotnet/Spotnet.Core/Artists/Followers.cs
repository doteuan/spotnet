namespace Spotnet.Core.Artists
{
    /// <summary>
    /// Class that represents a Follower provided by the Spotify API.
    /// </summary>
    public sealed class Followers
    {
        /// <summary>
        /// Gets or sets the follower's URL.
        /// </summary>
        /// <remarks>
        /// This will always be <see langword="null"/>, as the Spotify Web API does not support this currently.
        /// </remarks>
        public string? Href { get; set; } = null;

        /// <summary>
        /// Gets or sets the total number of followers.
        /// </summary>
        public int Total { get; set; }
    }
}
