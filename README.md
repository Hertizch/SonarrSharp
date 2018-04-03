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
foreach (var item in series)
{
    Console.WriteLine($"{serie.Title}");
}
```

Get all episodes airing in the next 30 days:
```c#
var calendar = await sonarrClient.Calendar.GetCalendar(DateTime.Now, DateTime.Now.AddDays(30));
foreach (var item in calendar)
{
    Console.WriteLine($"{item.AirDate}: {item.Series.Title} - s{item.SeasonNumber}e{item.EpisodeNumber} - {item.Title}");
}
```

Search for all episodes in a series:
```c#
var command = await.sonarrClient.Command.SeriesSearch(123);

// Get status of this started command
Console.WriteLine($"{command.Name}: {command.State}");
```
