using System.Text.Json;
using System.Text.Json.Serialization;

namespace WarframeApiWrapper.Converters {
    public class FactionConverter : JsonConverter<Faction>
    {
        public override Faction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString()?.ToLower();
            return value switch {
                "grineer" => Faction.Grineer,
                "corpus" => Faction.Corpus,
                "infested" => Faction.Infested,
                "orokin" => Faction.Orokin,
                _ => Faction.Unknown
            };
        }

        public override void Write(Utf8JsonWriter writer, Faction value, JsonSerializerOptions options)
        {
            var factionString = value switch {
                Faction.Orokin => "Orokin",
                Faction.Grineer => "Grineer",
                Faction.Corpus => "Corpus",
                Faction.Infested => "Infested",
                Faction.Unknown => "Unknown",
                _ => "Unknown"
            };

            writer.WriteStringValue(factionString);
        }
    }
}