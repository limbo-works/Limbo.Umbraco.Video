using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters.Time;

namespace Limbo.Umbraco.Video.Models.Videos {
    
    /// <summary>
    /// Interface representing the details about a picked video.
    /// </summary>
    public interface IVideoDetails {

        /// <summary>
        /// Gets the title of the video.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        string Title { get; }

        /// <summary>
        /// Gets the duration of the video.
        /// </summary>
        [JsonProperty("duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(TimeSpanSecondsConverter))]
        TimeSpan Duration { get; }

        /// <summary>
        /// Gets a list of thumbnails of the video.
        /// </summary>
        [JsonProperty("thumbnails", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<IVideoThumbnail> Thumbnails { get; }

        /// <summary>
        /// Gets a list of video files of the video.
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<IVideoFile> Files { get; }

    }

}