using Newtonsoft.Json;

namespace Limbo.Umbraco.Video.Models.Providers {

    /// <summary>
    /// Class with limited information about a video provider.
    /// </summary>
    public class VideoProvider : IVideoProvider {

        /// <summary>
        /// Gets the alias of the provider - eg. <c>youtube</c>.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; }

        /// <summary>
        /// Gets the alias of the provider - eg. <c>YouTube</c>.
        /// </summary>
        [JsonIgnore]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="alias"/> and <paramref name="name"/>.
        /// </summary>
        /// <param name="alias">The alias of the video provider.</param>
        /// <param name="name">The name of the video provider.</param>
        public VideoProvider(string alias, string name) {
            Alias = alias;
            Name = name;
        }

    }

}