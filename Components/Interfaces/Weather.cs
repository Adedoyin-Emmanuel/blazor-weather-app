namespace BlazorWeatherApp.Interfaces;



public interface IWeatherResponse
{
    MainWeatherData main { get; }
    List<Weather> weather { get; }
    WindData wind { get; }
    string name { get; }
}

public interface MainWeatherData
{
    double temp { get; }
    double feels_like { get; }
    int humidity { get; }
}

public interface Weather
{
    string main { get; }
    string description { get; }
}

public interface WindData
{
    double speed { get; }
}
