using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Limbo.Umbraco.Video.Models {

    /// <summary>
    /// Class representing a generic video thumbnail.
    /// </summary>
    public class VideoThumbnail : IVideoThumbnail {

        #region Properties

        /// <summary>
        /// Gets the width of the thumbnail.
        /// </summary>
        public int Width { get; protected set; }

        /// <summary>
        /// Gets the height of the thumbnail.
        /// </summary>
        public int Height { get; protected set; }

        /// <summary>
        /// Gets the URL of the thumbnail.
        /// </summary>
        public string Url { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public VideoThumbnail() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="width"/>, <paramref name="height"/> and <paramref name="url"/>.
        /// </summary>
        /// <param name="width">The width of the thumbnail.</param>
        /// <param name="height">The height of the thumbnail.</param>
        /// <param name="url">The URL of the thumbnail.</param>
        public VideoThumbnail(int width, int height, string url) {
            Width = width;
            Height = height;
            Url = url;
        }

        /// <summary>
        /// Initializes a new instanced based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the thumbnail.</param>
        protected VideoThumbnail(JObject json) {
            Width = json.GetInt32("width");
            Height = json.GetInt32("height");
            Url = json.GetString("url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Returns a new <see cref="VideoThumbnail"/> parsed from the specified <paramref name="json"/> object, or <c>null</c> if <paramref name="json"/> is <c>null</c>.
        /// </summary>
        /// <param name="json">The JSON object representing the thumbnail.</param>
        /// <returns>An instance of <see cref="VideoThumbnail"/>, or <c>null</c> if <paramref name="json"/> is <c>null</c>.</returns>
        public static VideoThumbnail Parse(JObject json) {
            return json == null ? null : new VideoThumbnail(json);
        }

        #endregion

    }

}