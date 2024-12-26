using System.Text.Json.Serialization;

namespace WarframeApiWrapper.Objects
{
    public class OrbVallisStatus
    {
        public required string Id { get; set; }
        public DateTime Expiry { get; set; }
        public DateTime Activation { get; set; }

        [JsonPropertyName("state")]
        public required string Active { get; set; }
        public bool IsWarm { get; set; }
    }
}
