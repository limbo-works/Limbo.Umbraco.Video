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
        /// <remarks>While most video providers expose the duration of a video, some may not. If a duration isn't
        /// provided, the value of this property will be <see langword="null"/>.</remarks>
        [JsonProperty("duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(TimeSpanSecondsConverter))]
        TimeSpan? Duration { get; }

        /// <summary>
        /// Gets a list of thumbnails of the video.
        /// </summary>
        /// <remarks>The value of this property will be <see langword="null"/> if the video provider doesn't expose any thumbnails.</remarks>
        [JsonProperty("thumbnails", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<IVideoThumbnail>? Thumbnails { get; }

        /// <summary>
        /// Gets a list of video files of the video.
        /// </summary>
        /// <remarks>The value of this property will be <see langword="null"/> if the video provider doesn't expose any video files.</remarks>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<IVideoFile>? Files { get; }

    }

}