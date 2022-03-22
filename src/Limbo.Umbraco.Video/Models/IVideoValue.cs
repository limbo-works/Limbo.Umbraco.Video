using Newtonsoft.Json;

namespace Limbo.Umbraco.Video.Models {

    /// <summary>
    /// Interface describing a video value.
    /// </summary>
    public interface IVideoValue {

        /// <summary>
        /// Gets the source (URL or embed code) as entered by the user.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        string Source { get; }

        /// <summary>
        /// Gets the details about the picked video.
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        IVideoDetails Video { get; }

        /// <summary>
        /// Gets embed information for the video.
        /// </summary>
        [JsonProperty("embed", NullValueHandling = NullValueHandling.Ignore)]
        IVideoEmbed Embed { get; }

    }

}