# SonarrSharp
C# [Sonarr](https://sonarr.tv/) API wrapper.

## Compatibility
Written as a .NET Standard library, so should be compatible with .NET framework, .NET core and Xamarin.

## Installation
Available as a [NuGet](https://www.nuget.org/packages/SonarrSharp/) package:
```
PM> Install-Package SonarrSharp
```

## Known Issues
- Please tell me! :)

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
    Console.WriteLine($"{item.Title}");
}
```

Get all episodes in a series:
```c#
var episodes = await sonarrClient.Episode.GetEpisodes(123);
foreach (var item in episodes)
{
    Console.WriteLine($"s{item.SeasonNumber}e{item.EpisodeNumber} - {item.Title}");
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
