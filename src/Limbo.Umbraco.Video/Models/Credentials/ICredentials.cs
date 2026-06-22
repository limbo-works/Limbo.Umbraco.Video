using System;
using Newtonsoft.Json;

namespace Limbo.Umbraco.Video.Models.Credentials;

/// <summary>
/// Interface describing a set of credentials.
/// </summary>
public interface ICredentials {

    /// <summary>
    /// Gets the unique key (GUID) of the credentials.
    /// </summary>
    [JsonProperty("key")]
    public Guid Key { get; }

    /// <summary>
    /// Gets the friendly name of the credentials.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; }

    /// <summary>
    /// Gets the description of the credentials.
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; }

}