using System.Collections.Generic;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Manifest;
using Umbraco.Cms.Infrastructure.Manifest;

using static Limbo.Umbraco.Video.VideoPackage;

namespace Limbo.Umbraco.Video.Manifests;

#pragma warning disable CS1591

public class VideoPackageManifestReader : IPackageManifestReader {

    public async Task<IEnumerable<PackageManifest>> ReadPackageManifestsAsync() {

        List<PackageManifest> temp = [
            new() {
                Id = Alias,
                Name = Name,
                AllowTelemetry = true,
                Version = InformationalVersion,
                Extensions = [
                    new {
                        type = "localization",
                        alias = $"{Alias}.Localization.En",
                        name = $"{Name}: English",
                        js = $"/App_Plugins/{Alias}/Localization/en-US.js",
                        meta = new {
                            culture = "en"
                        }
                    },
                    new {
                        type = "localization",
                        alias = $"{Alias}.Localization.Da",
                        name = $"{Name}: Danish",
                        js = $"/App_Plugins/{Alias}/Localization/da-DK.js",
                        meta = new {
                            culture = "da"
                        }
                    }
                ],
                Importmap = new PackageManifestImportmap {
                    Imports = new Dictionary<string, string> {
                        {"@limbo/video/elements/duration", $"/App_Plugins/{Alias}/Elements/Duration.js"}
                    }
                }
            }

        ];

        return await Task.FromResult(temp);

    }

}