using Newtonsoft.Json;

namespace Limbo.Umbraco.Video.Models.Videos {

    /// <summary>
    /// Class representing a video thumbnail.
    /// </summary>
    public interface IVideoThumbnail {

        /// <summary>
        /// Gets the width of the thumbnail.
        /// </summary>
        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        int Width { get; }

        /// <summary>
        /// Gets the height of the thumbnail.
        /// </summary>
        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        int Height { get; }

        /// <summary>
        /// Gets the URL of the thumbnail.
        /// </summary>
        [JsonProperty("url")]
        string Url { get; }

    }

}