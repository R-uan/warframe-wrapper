using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using WarframeApiWrapper.Converters;

namespace WarframeApiWrapper {
    public class ArchonHunt {
        public required string Id { get; set; }
        public DateTime Activation { get;set; }
        public DateTime Expiry { get; set; }
        public bool Active { get; set; }
        public required List<ArchonMission> Missions { get; set; }
        public required string Boss {get;set;}

        [JsonPropertyName("factionKey")]
        [JsonConverter(typeof(FactionConverter))]
        public required Faction Faction {get;set;}
    }

    public class ArchonMission {

        [JsonPropertyName("nodeKey")]
        public required string Node { get; set; }
        public bool Nightmare { get; set; }
        public bool Archwing { get; set; }
        public bool IsSharkwing { get; set; }
        
        [JsonPropertyName("typeKey")]
        [JsonConverter(typeof(MissionTypeConverter))]
        public required MissionType Type { get; set; }
    }
}
