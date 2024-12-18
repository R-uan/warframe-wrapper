using System.Text.Json.Serialization;
using WarframeApiWrapper.Converters;

namespace WarframeApiWrapper.Objects 
{
    public class Invasion {
        public required string Id { get; set; }
        public DateTime Activation { get; set; }
        public bool Completed { get; set; }
        public string? Eta { get; set; }

        [JsonPropertyName("vsInfestation")]
        public bool Infested { get; set; }

        [JsonPropertyName("nodeKey")]
        public required string Node { get; set; }
        
        public required Attacker Attacker { get; set; }
        public required Defender Defender { get; set; }
    }

    public class Attacker {
        [JsonPropertyName("factionKey")]
        [JsonConverter(typeof(FactionConverter))]
        public Faction Faction { get; set; }
        public InvasionReward? Reward { get; set; }
    }

    public class Defender {
        [JsonPropertyName("factionKey")]
        [JsonConverter(typeof(FactionConverter))]
        public Faction Faction { get; set; }
        public required InvasionReward Reward { get; set; }
    }

    public class InvasionReward {
        public required string ItemString { get; set; }
        public string? Thumbnail { get; set; }
        public required List<CountedItem> CountedItems { get; set; }
    }
}