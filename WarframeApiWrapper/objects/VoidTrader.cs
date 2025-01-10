using System.Text.Json.Serialization;
using WarframeApiWrapper.Converters;

namespace WarframeApiWrapper.Objects
{
    public class VoidTrader
    {
        public required string Id { get; set; }

        public Boolean Active { get; set; }
        public required string Location { get; set; }

        public DateTime Activation { get; set; }
        public DateTime Expiry { get; set; }

        [JsonConverter(typeof(InventoryConverter))]
        public List<VoidItem>? Inventory { get; set; }
    }

    public class VoidItem
    {
        public required string Item { get; set; }
        public int Ducats { get; set; }
        public int Credits { get; set; }
    }
}