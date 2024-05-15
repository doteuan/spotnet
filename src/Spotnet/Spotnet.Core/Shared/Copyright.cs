namespace Spotnet.Core.Shared
{
    /// <summary>
    /// Class that represents copyright statements provided by the Spotify API.
    /// </summary>
    public sealed class Copyright
    {
        /// <summary>
        /// Gets or sets the copyright text for this content.
        /// </summary>
        public string Text { get; set; } = null!;

        /// <summary>
        /// Gets or sets the type of copyright for this content.
        /// </summary>
        /// <remarks>
        /// If value is <c>'C'</c> it refers to the copyright, if <c>'P'</c> it refers to the sound recording (performance) copyright.
        /// </remarks>
        public string Type { get; set; } = null!;
    }
}
