using System.Collections.Generic;
using System.Threading.Tasks;
using Skybrud.Essentials.Security.Extensions;
using Umbraco.Cms.Core.Manifest;
using Umbraco.Cms.Infrastructure.Manifest;

namespace Limbo.Umbraco.Video.Manifests;

#pragma warning disable CS1591

public class VideoPackageManifestReader : IPackageManifestReader {

    public const string Alias = VideoPackage.Alias;

    public const string Name = VideoPackage.Name;

    public async Task<IEnumerable<PackageManifest>> ReadPackageManifestsAsync() {

        string cacheBuster = VideoPackage.InformationalVersion.ToMd5Hash();

        List<PackageManifest> temp = [
            new() {
                Id = Alias,
                Name = Name,
                AllowTelemetry = true,
                Version = VideoPackage.InformationalVersion,
                Extensions = [
                    new {
                        type = "localization",
                        alias = $"{Alias}.Localization.En",
                        name = $"{Name}: English",
                        js = $"/App_Plugins/{Alias}/Localization/en-US.js?v={cacheBuster}",
                        meta = new {
                            culture = "en"
                        }
                    },
                    new {
                        type = "localization",
                        alias = $"{Alias}.Localization.Da",
                        name = $"{Name}: Danish",
                        js = $"/App_Plugins/{Alias}/Localization/da-DK.js?v={cacheBuster}",
                        meta = new {
                            culture = "da"
                        }
                    }
                ],
                Importmap = new PackageManifestImportmap {
                    Imports = new Dictionary<string, string> {
                        {"@limbo/video/elements/duration", $"/App_Plugins/{Alias}/Elements/Duration.js?v={cacheBuster}"}
                    }
                }
            }

        ];

        return await Task.FromResult(temp);

    }

}