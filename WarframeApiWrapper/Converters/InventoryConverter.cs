using System.Text.Json;
using System.Text.Json.Serialization;
using WarframeApiWrapper.Objects;

namespace WarframeApiWrapper.Converters
{
    public class InventoryConverter : JsonConverter<List<VoidItem>?>
    {
        public override List<VoidItem>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                using (var doc = JsonDocument.ParseValue(ref reader))
                {
                    var arrayElements = doc.RootElement.EnumerateArray();
                    if (!arrayElements.Any()) return null;

                    var items = new List<VoidItem>();
                    foreach (var element in arrayElements)
                    {
                        var item = JsonSerializer.Deserialize<VoidItem>(element.GetRawText(), options);
                        if (item != null)
                            items.Add(item);
                    }
                    return items;
                }
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, List<VoidItem>? value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}