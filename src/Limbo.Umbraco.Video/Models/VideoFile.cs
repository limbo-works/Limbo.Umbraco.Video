using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Umbraco.Video.Models {
    
    /// <summary>
    /// Class representing a generic video file.
    /// </summary>
    public class VideoFile : IVideoFile {

        #region Properties

        /// <summary>
        /// Gets the width of the video file.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Gets the height of the video file.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Gets the URL of the video file.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the type of the video file.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the file size of the video file.
        /// </summary>
        public long Size { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="width"/>, <paramref name="height"/>, <paramref name="url"/> <paramref name="type"/> and <paramref name="size"/>.
        /// </summary>
        /// <param name="width">The width of the thumbnail.</param>
        /// <param name="height">The height of the thumbnail.</param>
        /// <param name="url">The URL of the thumbnail.</param>
        /// <param name="type"></param>
        /// <param name="size"></param>
        public VideoFile(int width, int height, string url, string type, long size) {
            Width = width;
            Height = height;
            Url = url;
            Type = type;
            Size = size;
        }

        /// <summary>
        /// Initializes a new instanced based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the video file.</param>
        protected VideoFile(JObject json) {
            Width = json.GetInt32("width");
            Height = json.GetInt32("height");
            Url = json.GetString("url");
            Type = json.GetString("type");
            Size = json.GetInt64("size");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Returns a new <see cref="VideoFile"/> parsed from the specified <paramref name="json"/> object, or <c>null</c> if <paramref name="json"/> is <c>null</c>.
        /// </summary>
        /// <param name="json">The JSON object representing the video file.</param>
        /// <returns>An instance of <see cref="VideoFile"/>, or <c>null</c> if <paramref name="json"/> is <c>null</c>.</returns>
        public static VideoFile Parse(JObject json) {
            return json == null ? null : new VideoFile(json);
        }

        #endregion

    }

}