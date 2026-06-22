using Limbo.Umbraco.Video.Manifests;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Infrastructure.Manifest;

namespace Limbo.Umbraco.Video.Composers;

/// <inheritdoc />
public class VideoComposer : IComposer {

    /// <inheritdoc />
    public void Compose(IUmbracoBuilder builder) {
        builder.Services.AddSingleton<IPackageManifestReader, VideoPackageManifestReader>();
    }

}