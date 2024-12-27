using System.Text.Json.Serialization;
using WarframeApiWrapper.Converters;

namespace WarframeApiWrapper.Objects
{
    public class Fissure
    {
        public required string Id { get; set; }
        public bool Active { get; set; }

        public DateTime Activation { get; set; }
        public DateTime Expiry { get; set; }
        public required string StartString { get; set; }
        public required string Eta { get; set; }

        public bool IsStorm { get; set; }

        [JsonPropertyName("isHard")]
        public bool IsSteelPath { get; set; }

        [JsonPropertyName("factionKey")]
        [JsonConverter(typeof(FactionConverter))]
        public Faction Enemy { get; set; }

        [JsonPropertyName("typeKey")]
        [JsonConverter(typeof(MissionTypeConverter))]
        public MissionType MissionType { get; set; }

        [JsonPropertyName("nodeKey")]
        public required string Node { get; set; }

        [JsonPropertyName("tierNum")]
        [JsonConverter(typeof(FissureTierConverter))]
        public FissureTier Tier { get; set; }
    }
}
