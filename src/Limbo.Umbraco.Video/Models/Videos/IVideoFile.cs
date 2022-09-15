using Newtonsoft.Json;

namespace Limbo.Umbraco.Video.Models.Videos {
    
    /// <summary>
    /// Class representing a video file.
    /// </summary>
    public interface IVideoFile {

        /// <summary>
        /// Gets the width of the video file.
        /// </summary>
        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Width { get; }

        /// <summary>
        /// Gets the height of the video file.
        /// </summary>
        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Height { get; }

        /// <summary>
        /// Gets the URL of the video file.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; }

        /// <summary>
        /// Gets the type of the video file.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; }

        /// <summary>
        /// Gets the file size of the video file.
        /// </summary>
        [JsonProperty("size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Size { get; }

    }

}