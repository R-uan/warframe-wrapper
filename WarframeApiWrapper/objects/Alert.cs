using System.Text.Json.Serialization;
using WarframeApiWrapper.Converters;

namespace WarframeApiWrapper.Objects {
    public class Alert {
        public string? Eta {get;set;}
        public bool Active {get;set;}
        public DateTime Expiry {get;set;}
        public required string Id {get;set;}
        public DateTime Activation {get;set;}
        public required string Tag {get;set;}
        public required Mission Mission {get;set;}
        public required string StartString {get;set;}
    }

    public class Mission {
        public required string Node {get;set;}
        public required string Type {get;set;}
        [JsonConverter(typeof(FactionConverter))]
        public required Faction Faction {get;set;}
        public required string Description {get; set;}
        public required Reward Reward {get;set;}
    }

    public class Reward {
        public List<CountedItem>? CountedItems {get;set;}
        public int Credits {get;set;}
        public bool Nightmare {get;set;}
        public int MinEnemyLevel {get;set;}
        public int MaxEnemyLevel {get;set;}
        public bool ArchwingRequired {get;set;}
        public required string AsString {get;set;}
    }

    public class CountedItem {
        public int Count {get;set;}
        public required string Type {get;set;}
    }
}