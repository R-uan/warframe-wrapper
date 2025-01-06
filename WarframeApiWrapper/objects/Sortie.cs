using System.Text.Json.Serialization;
using WarframeApiWrapper.Converters;

namespace WarframeApiWrapper.Objects
{
    public class Sortie
    {
        public required string Id { get; set; }
        public required string Boss { get; set; }
        public required Boolean Active { get; set; }
        public required DateTime Activation { get; set; }
        public required DateTime Expiry { get; set; }

        [JsonPropertyName("factionKey")]
        [JsonConverter(typeof(FactionConverter))]
        public required Faction Faction { get; set; }

        [JsonPropertyName("variants")]
        public required List<SortieMission> Missions { get; set; }
    }

    public class SortieMission
    {
        [JsonPropertyName("missionTypeKey")]
        [JsonConverter(typeof(MissionTypeConverter))]
        public MissionType MissionType { get; set; }

        [JsonPropertyName("nodeKey")]
        public required string Node { get; set; }

        public required string Modifier { get; set; }
        public required string ModifierDescription { get; set; }
    }
}