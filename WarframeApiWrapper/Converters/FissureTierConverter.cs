using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using WarframeApiWrapper.Objects;

namespace WarframeApiWrapper.Converters;

public class FissureTierConverter : JsonConverter<FissureTier>
{
    public override FissureTier Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var factionString = reader.GetString()?.ToLower();
        return factionString switch
        {
            "axi" => FissureTier.Axi,
            "meso" => FissureTier.Meso,
            "neo" => FissureTier.Neo,
            "lith" => FissureTier.Lith,
            "omnia" => FissureTier.Omnia,
            "requiem" => FissureTier.Requiem,
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
