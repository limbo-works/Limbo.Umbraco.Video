# Limbo Video

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/limbo-works/Limbo.Umbraco.Video/blob/v17/main/LICENSE.md)
[![NuGet](https://img.shields.io/nuget/v/Limbo.Umbraco.Video.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Video)
[![NuGet](https://img.shields.io/nuget/dt/Limbo.Umbraco.Video.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Video)
[![Umbraco Marketplace](https://img.shields.io/badge/umbraco-marketplace-%233544B1)](https://marketplace.umbraco.com/package/limbo.umbraco.video)
[![Limbo.Umbraco.Video at packages.limbo.works](https://img.shields.io/badge/limbo-packages-blue)](https://packages.limbo.works/limbo.umbraco.video/)

This package doesn't really do much on it's own, but provides common functionality for:

- [**Limbo.Umbraco.DreamBroker**](https://github.com/limbo-works/Limbo.Umbraco.DreamBroker)
- [**Limbo.Umbraco.Skyfish**](https://github.com/limbo-works/Limbo.Umbraco.Skyfish)
- [**Limbo.Umbraco.TwentyThree**](https://github.com/limbo-works/Limbo.Umbraco.TwentyThree)
- [**Limbo.Umbraco.Vimeo**](https://github.com/limbo-works/Limbo.Umbraco.Vimeo)
- [**Limbo.Umbraco.YouTube**](https://github.com/limbo-works/Limbo.Umbraco.YouTube)

<table>
  <tr>
    <td><strong>License:</strong></td>
    <td><a href="https://github.com/limbo-works/Limbo.Umbraco.Video/blob/v17/main/LICENSE.md"><strong>MIT License</strong></a></td>
  </tr>
  <tr>
    <td><strong>Umbraco:</strong></td>
    <td>
      Umbraco 17
    </td>
  </tr>
  <tr>
    <td><strong>Target Framework:</strong></td>
    <td>
      .NET 10
    </td>
  </tr>
</table>




<br /><br />
## Installation

### Umbraco 17

The package is only available via [**NuGet**](https://www.nuget.org/packages/Limbo.Umbraco.Video). To install the package, you can use either the .NET CLI:

```
dotnet add package Limbo.Umbraco.Video --version 17.0.0-alpha001
```

or the NuGet Package Manager:

```
Install-Package Limbo.Umbraco.Video -Version 17.0.0-alpha001
```

### Other versions of Umbraco

- [**`v13/main`**](https://github.com/limbo-works/Limbo.Umbraco.Video/tree/v13/main) Umbraco 13
- ~~[**`v2/main`**](https://github.com/limbo-works/Limbo.Umbraco.Video/tree/v2/main) Umbraco 10, 11 and 12~~ <sub title="Umbraco 10, 11 and 12 have reached end-of-life"><sup>(EOL)</sup></sub>
- ~~[**`v1/main`**](https://github.com/limbo-works/Limbo.Umbraco.Video/tree/v1/main) Umbraco 9~~ <sub title="Umbraco 9 have reached end-of-life"><sup>(EOL)</sup></sub>


<br /><br />
## Documentation

### Elements

#### Duration

The package adds a Lit element for showing a video duration in a user friendly way. It may be used like:

```html
<limbo-video-duration value="video.duration"></limbo-video-duration>
```

The duration may be specified as seconds or formatted as an ISO 8601 duration (eg. `P1DT2H30M`). Since the use case is video durations, the seconds will be split up into hours, minutes and seconds, but not days, months etc. `P1DT2H30M` will be formatted as `26 hours and 30 minutes`.

The values are localized, but for now only with support for English and Danish.
