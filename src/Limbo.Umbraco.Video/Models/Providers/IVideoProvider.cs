using Newtonsoft.Json;

namespace Limbo.Umbraco.Video.Models.Providers {

    /// <summary>
    /// Interface with limited information about a video provider.
    /// </summary>
    public interface IVideoProvider {

        /// <summary>
        /// Gets the alias of the provider - eg. <c>youtube</c>.
        /// </summary>
        [JsonProperty("alias")]
        string Alias { get; }

        /// <summary>
        /// Gets the alias of the provider - eg. <c>youtube</c>.
        /// </summary>
        [JsonIgnore]
        string Name { get; }

    }

}