using dotenv.net;




namespace BlazorWeatherApp.Services;


public class WeatherService
{
    private readonly HttpClient httpClient;
    private readonly string apiKey;


    public WeatherService(HttpClient httpClient)
    {
        DotEnv.Load();
        this.httpClient = httpClient;
        apiKey = Environment.GetEnvironmentVariable("OPEN_WEATHER_API_KEY") ?? throw new Exception("API KEY not set");

    }
    public async Task<HttpContent> GetCurrentLocationWeather(IGetCurrentLocationWeather data)
    {
        try
        {
            var response = await httpClient.GetAsync($"/data/2.5/weather?lat={data.Latitude}&lon={data.Longitude}&appid={apiKey}&units=metric");

            return response.Content;
        }
        catch (Exception)
        {
            throw new Exception("An error occured while making that request");
        }
    }

    public async Task<HttpContent> GetSeachedLocationWeather(String location)
    {
        try
        {
            var response = await httpClient.GetAsync($"/data/2.5/weather?q={location}&appid={apiKey}&units=metric");

            return response.Content;
        }
        catch (Exception)
        {

            throw new Exception("An error occured while making that request");
        }
    }
}