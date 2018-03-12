# SonarrSharp
C# Sonarr API wrapper

## Usage
Get all series
```
var sonarrClient = new SonarrClient("127.0.0.1", 8989, "apiKey");
var series = await sonarrClient.Series.GetSeries();
foreach (var serie in series)
{
  Console.WriteLine($"{serie.Title}");
}
```
