# Limbo Video

This package doesn't really do much on it's own, but provides common functionality for:

- [**Limbo.Umbraco.DreamBroker**](https://github.com/limbo-works/Limbo.Umbraco.DreamBroker)
- [**Limbo.Umbraco.Vimeo**](https://github.com/limbo-works/Limbo.Umbraco.Vimeo)
- [**Limbo.Umbraco.YouTube**](https://github.com/limbo-works/Limbo.Umbraco.YouTube)

## Installation

The Umbraco 10 version of this package is only available via [NuGet](https://github.com/limbo-works/Limbo.Umbraco.Video/releases/tag/v2.0.0). To install the package, you can use either the .NET CLI:

```
dotnet add package Limbo.Umbraco.Video
```

or the older NuGet Package Manager:

```
Install-Package Limbo.Umbraco.Video
```


## Documentation

### Angular directives

#### Duration

The package adds for showing a video duration in a user friendly way. It may be used like:

```html
<limbo-video-duration value="video.duration"></limbo-video-duration>
```

The duration may be specified as seconds or formatted as an ISO 8601 duration (eg. `P1DT2H30M`). Since the use case is video durations, the seconds will be split up into hours, minutes and seconds. `P1DT2H30M` will be formatted as `26 hours and 30 minutes`.

The values are localized, but for now only with support for English and Danish.
