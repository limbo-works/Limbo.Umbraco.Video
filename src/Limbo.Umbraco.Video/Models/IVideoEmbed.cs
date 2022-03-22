﻿using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters;

namespace Limbo.Umbraco.Video.Models {

    /// <summary>
    /// Interface describing the embed details of a video.
    /// </summary>
    public interface IVideoEmbed {

        /// <summary>
        /// Gets the HTML embed code.
        /// </summary>
        [JsonProperty("html", Order = 999, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringJsonConverter))]
        HtmlString Html { get; }

    }

}