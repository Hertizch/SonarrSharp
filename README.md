# SonarrSharp
C# Sonarr API wrapper. Still in a beta phase, all methods and properties are subject to change.

## Compatibility
.NET framework, .NET core and Xamarin

## Installation
Available as a NuGet package:
```
PM> Install-Package SonarrSharp
```

## Usage
These are some examples on how to use the API. All methods are async/awaitable. Most methods includes help text on what they do. If you need more information on how the various endpoints works, visit https://github.com/Sonarr/Sonarr/wiki/API.

Create the client:
```c#
var sonarrClient = new SonarrClient("127.0.0.1", 8989, "apiKey");
```

Get all series:
```c#
var series = await sonarrClient.Series.GetSeries();
foreach (var serie in series)
{
    Console.WriteLine($"{serie.Title}");
}
```

Search for all episodes in a series:
```c#
var command = await.sonarrClient.Command.SeriesSearch(123);

// Get status of command
Console.WriteLine($"{command.Name}: {command.State}");
```
