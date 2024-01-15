# Limbo Video

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md) [![NuGet](https://img.shields.io/nuget/v/Limbo.Umbraco.Video.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Video) [![NuGet](https://img.shields.io/nuget/dt/Limbo.Umbraco.Video.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Video) [![Umbraco Marketplace](https://img.shields.io/badge/umbraco-marketplace-%233544B1)](https://marketplace.umbraco.com/package/limbo.umbraco.video)

This package doesn't really do much on it's own, but provides common functionality for:

- [**Limbo.Umbraco.DreamBroker**](https://github.com/limbo-works/Limbo.Umbraco.DreamBroker)
- [**Limbo.Umbraco.TwentyThree**](https://github.com/limbo-works/Limbo.Umbraco.TwentyThree)
- [**Limbo.Umbraco.Vimeo**](https://github.com/limbo-works/Limbo.Umbraco.Vimeo)
- [**Limbo.Umbraco.YouTube**](https://github.com/limbo-works/Limbo.Umbraco.YouTube)
- [**Limbo.Umbraco.Skyfish**](https://github.com/limbo-works/Limbo.Umbraco.Skyfish)

<table>
  <tr>
    <td><strong>License:</strong></td>
    <td><a href="./LICENSE.md"><strong>MIT License</strong></a></td>
  </tr>
  <tr>
    <td><strong>Umbraco:</strong></td>
    <td>
      Umbraco 10, 11 and 12
      <sub><sup>(and <a href="https://github.com/limbo-works/Limbo.Umbraco.Video/tree/v1/main">Umbraco 9</a>)</sup></sub>
    </td>
  </tr>
  <tr>
    <td><strong>Target Framework:</strong></td>
    <td>
      .NET 6
      <sub><sup>(and <a href="https://github.com/limbo-works/Limbo.Umbraco.Video/tree/v1/main">.NET 5</a>)</sup></sub>
    </td>
  </tr>
</table>




<br /><br />
## Installation

The Umbraco 10+ version of this package is only available via [NuGet](https://github.com/limbo-works/Limbo.Umbraco.Video/releases/tag/v2.0.6). To install the package, you can use either the .NET CLI:

```
dotnet add package Limbo.Umbraco.Video --version 2.0.6
```

or the NuGet Package Manager:

```
Install-Package Limbo.Umbraco.Video -Version 2.0.6
```




<br /><br />
## Documentation

### Angular directives

#### Duration

The package adds for showing a video duration in a user friendly way. It may be used like:

```html
<limbo-video-duration value="video.duration"></limbo-video-duration>
```

The duration may be specified as seconds or formatted as an ISO 8601 duration (eg. `P1DT2H30M`). Since the use case is video durations, the seconds will be split up into hours, minutes and seconds, but not days, months etc. `P1DT2H30M` will be formatted as `26 hours and 30 minutes`.

The values are localized, but for now only with support for English and Danish.
