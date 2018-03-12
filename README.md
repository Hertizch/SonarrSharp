# SonarrSharp
C# Sonarr API wrapper

## Usage
These are some examples on how to use the API. All methods are async/awaitable.

Create the client
```
var sonarrClient = new SonarrClient("127.0.0.1", 8989, "apiKey");
```

Get all series
```
var series = await sonarrClient.Series.GetSeries();
foreach (var serie in series)
{
    Console.WriteLine($"{serie.Title}");
}
```

Search for all episodes in a series
```
var command = await.sonarrClient.SeriesSearch(123);

// Get status of command
Console.WriteLine($"{command.Name}: {command.State}");
```
