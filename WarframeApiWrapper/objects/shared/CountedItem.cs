using System.Text.Json.Serialization;

namespace WarframeApiWrapper.Objects 
{
    public class CountedItem 
    {
        [JsonPropertyName("key")]
        public required string Type { get; set; }
        public int Count { get; set; }
    }
}