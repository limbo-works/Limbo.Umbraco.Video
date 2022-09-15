using System.Collections.Generic;
using Skybrud.Essentials.Strings.Extensions;
using Umbraco.Cms.Core.Manifest;

namespace Limbo.Umbraco.Video.Manifests {

    /// <inheritdoc />
    public class VideoManifestFilter : IManifestFilter {

        /// <inheritdoc />
        public void Filter(List<PackageManifest> manifests) {
            manifests.Add(new PackageManifest {
                PackageName = VideoPackage.Alias.ToKebabCase(),
                BundleOptions = BundleOptions.Independent,
                Scripts = new[] {
                    $"/App_Plugins/{VideoPackage.Alias}/Scripts/Services/LimboVideoService.js",
                    $"/App_Plugins/{VideoPackage.Alias}/Scripts/Directives/Duration.js"
                }
            });
        }

    }

}