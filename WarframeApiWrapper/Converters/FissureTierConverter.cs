using System.Text.Json;
using System.Text.Json.Serialization;

namespace WarframeApiWrapper.Converters
{
    public class FissureTierConverter : JsonConverter<FissureTier>
    {
        public override FissureTier Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var factionString = reader.GetInt16();
            return factionString switch
            {
                4 => FissureTier.Axi,
                2 => FissureTier.Meso,
                3 => FissureTier.Neo,
                1 => FissureTier.Lith,
                6 => FissureTier.Omnia,
                5 => FissureTier.Requiem,
                _ => FissureTier.Unknown,
            };
        }

        public override void Write(Utf8JsonWriter writer, FissureTier value, JsonSerializerOptions options)
        {
            var fissureTierString = value switch
            {
                FissureTier.Axi => "Axi",
                FissureTier.Neo => "Neo",
                FissureTier.Lith => "Lith",
                FissureTier.Meso => "Meso",
                FissureTier.Requiem => "Requiem",
                FissureTier.Unknown => "Unknown",
                _ => "Unknown"
            };

            writer.WriteStringValue(fissureTierString);
        }
    }
}
