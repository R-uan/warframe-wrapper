using System.Text.Json.Serialization;
using WarframeApiWrapper.Converters;

namespace WarframeApiWrapper.Objects
{
    public class Fissure
    {
        public bool Active { get; set; }
        public bool Expired { get; set; }
        public bool IsStorm { get; set; }
        [JsonConverter(typeof(FactionConverter))]
        public Faction Enemy { get; set; }
        public DateTime Expiry { get; set; }
        [JsonConverter(typeof(FissureTierConverter))]
        public FissureTier Tier { get; set; }
        public required string Id { get; set; }
        public required string Eta { get; set; }
        public DateTime Activation { get; set; }
        [JsonConverter(typeof(MissionTypeConverter))]
        public MissionType MissionType { get; set; }
        public required string StartString { get; set; }
    }
}
