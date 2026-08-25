using System.Collections.Generic;
using System.Threading.Tasks;
using Skybrud.Essentials.Security.Extensions;
using Umbraco.Cms.Core.Manifest;
using Umbraco.Cms.Infrastructure.Manifest;

namespace Limbo.Umbraco.Video.Manifests;

#pragma warning disable CS1591

public class VideoPackageManifestReader : IPackageManifestReader {

    public async Task<IEnumerable<PackageManifest>> ReadPackageManifestsAsync() {

        const string alias = VideoPackage.Alias;
        string cacheBuster = VideoPackage.InformationalVersion.ToMd5Hash();

        List<PackageManifest> temp = [
            new() {
                Id = VideoPackage.Alias,
                Name = VideoPackage.Name,
                AllowTelemetry = true,
                Version = VideoPackage.InformationalVersion,
                Extensions = [
                    new {
                        type = "localization",
                        alias = $"{alias}.Localization.En",
                        name = "English",
                        js = $"/App_Plugins/{alias}/Localization/en-US.js?v={cacheBuster}",
                        meta = new {
                            culture = "en"
                        }
                    },
                    new {
                        type = "localization",
                        alias = $"{alias}.Localization.Da",
                        name = "Danish",
                        js = $"/App_Plugins/{alias}/Localization/da-DK.js?v={cacheBuster}",
                        meta = new {
                            culture = "da"
                        }
                    }
                ],
                Importmap = new PackageManifestImportmap {
                    Imports = new Dictionary<string, string> {
                        {"@limbo/video/elements/duration", $"/App_Plugins/{alias}/Elements/Duration.js?v={cacheBuster}"}
                    }
                }
            }

        ];

        return await Task.FromResult(temp);

    }

}