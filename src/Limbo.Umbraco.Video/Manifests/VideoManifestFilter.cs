using System.Collections.Generic;
using Umbraco.Cms.Core.Manifest;

namespace Limbo.Umbraco.Video.Manifests {

    /// <inheritdoc />
    public class VideoManifestFilter : IManifestFilter {

        /// <inheritdoc />
        public void Filter(List<PackageManifest> manifests) {
            manifests.Add(new PackageManifest {
                AllowPackageTelemetry = true,
                PackageName = VideoPackage.Name,
                Version = VideoPackage.InformationalVersion,
                BundleOptions = BundleOptions.Independent,
                Scripts = new[] {
                    $"/App_Plugins/{VideoPackage.Alias}/Scripts/Services/LimboVideoService.js",
                    $"/App_Plugins/{VideoPackage.Alias}/Scripts/Directives/Duration.js"
                }
            });
        }

    }

}