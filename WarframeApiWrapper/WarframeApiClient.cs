using System.Text.Json;
using WarframeApiWrapper.Converters;

namespace WarframeApiWrapper
{
    public class WarframeApiClient
    {
        private static readonly string BaseURL = "https://api.warframestat.us/pc";
        private static readonly Dictionary<Endpoints, string> ApiEndpoints = new()
        {
            { Endpoints.Alerts, "/alerts" },
            { Endpoints.Fissure, "/fissures" },
            { Endpoints.Invasions, "/invasions" },
            { Endpoints.ArchonHunt, "/archonHunt" },
            { Endpoints.CetusStatus, "/cetusCycle" },
            { Endpoints.VallisStatus, "/vallisCycle" },
            { Endpoints.CambionDriftStatus, "/cambionCycle" },
        };

        public static async Task<T?> Get<T>(Endpoints endpoint)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters = {
                    new FactionConverter(),
                    new FissureTierConverter(),
                    new MissionTypeConverter()
                }
            };

            var target = $"{BaseURL}{ApiEndpoints[endpoint]}";
            using HttpClient client = new HttpClient();
            var request = await client.GetStringAsync(target);
            return JsonSerializer.Deserialize<T>(request, options);
        }
    }
}
