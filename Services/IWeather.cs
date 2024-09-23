namespace BlazorWeatherApp.Services;


public interface IGetCurrentLocationWeather
{
    string Longitude { get; set; }
    string Latitude { get; set; }
}