using Limbo.Umbraco.Video.Manifests;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Limbo.Umbraco.Video.Composers;

/// <inheritdoc />
public class VideoComposer : IComposer {

    /// <inheritdoc />
    public void Compose(IUmbracoBuilder builder) {
        builder.ManifestFilters().Append<VideoManifestFilter>();
    }

}