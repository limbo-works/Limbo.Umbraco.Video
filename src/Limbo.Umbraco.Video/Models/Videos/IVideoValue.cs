using Limbo.Umbraco.Video.Models.Providers;
using Newtonsoft.Json;

namespace Limbo.Umbraco.Video.Models.Videos {

    /// <summary>
    /// Interface describing a video value.
    /// </summary>
    public interface IVideoValue {

        /// <summary>
        /// Gets the source (URL or embed code) as entered by the user. If the user picked the video instead, this
        /// property may be <see langword="null"/>.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        string? Source { get; }

        /// <summary>
        /// Gets information about the video provider.
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        IVideoProvider? Provider { get; }

        /// <summary>
        /// Gets the details about the picked video.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        IVideoDetails Details { get; }

        /// <summary>
        /// Gets embed information for the video. Depending on the video provider, embed information may not be
        /// available, in which case this property will be <see langword="null"/>.
        /// </summary>
        [JsonProperty("embed", NullValueHandling = NullValueHandling.Ignore)]
        IVideoEmbed? Embed { get; }

    }

}