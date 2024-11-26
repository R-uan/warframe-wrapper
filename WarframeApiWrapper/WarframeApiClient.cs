
using System.Text.Json;
using WarframeApiWrapper.Converters;

namespace WarframeApiWrapper
{
    public class WarframeApiClient
    {
        private static string BaseURL = "https://api.warframestat.us/pc";
        private static readonly Dictionary<Endpoints, string> ApiEndpoints = new()
        {
            { Endpoints.CetusStatus, "/cetusCycle" },
            { Endpoints.CambionDriftStatus, "/cambionCycle" },
            { Endpoints.VallisStatus, "/vallisCycle" },
            { Endpoints.Alerts, "/alerts" }
        };

        public static async Task<T?> Get<T>(Endpoints endpoint)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters = { new FactionConverter() }
            }; 
            var target = $"{BaseURL}{ApiEndpoints[endpoint]}";
            using HttpClient client = new HttpClient();
            var request = await client.GetStringAsync(target);
            return JsonSerializer.Deserialize<T>(request, options);
        }
    }
}
