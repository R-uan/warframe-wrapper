using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using WarframeApiWrapper.Objects;

namespace WarframeApiWrapper.Converters
{


    public class MissionTypeConverter : JsonConverter<MissionType>
    {
        public override MissionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var missionType = reader.GetString()?.ToLower();
            var placeholder = missionType switch
            {
                "spy" => MissionType.Spy,
                "rescue" => MissionType.Rescue,
                "capture" => MissionType.Capture,
                "defense" => MissionType.Defense,
                "sabotage" => MissionType.Sabotage,
                "survival" => MissionType.Survival,
                "excavation" => MissionType.Excavation,
                "interception" => MissionType.Interception,
                "assassination" => MissionType.Assassination,
                "extermination" => MissionType.Extermination,
                "mobile defense" => MissionType.MobileDefense,
                // Entrati Labs
                "alchemy" => MissionType.Alchemy,
                // Railjack
                "skirmish" => MissionType.Skirmish,
                "volatile" => MissionType.Volatile,
                // Zariman
                "void flood" => MissionType.VoidFlood,
                "void cascade" => MissionType.VoidCascade,
                "void armagedon" => MissionType.VoidArmagedon,
                // ?
                "unknown" => MissionType.Unknown,
                "corruption" => MissionType.Corruption,
                _ => MissionType.Unknown
            };


            return placeholder;
        }

        public override void Write(Utf8JsonWriter writer, MissionType value, JsonSerializerOptions options)
        {
            var missionTypeString = value switch
            {
                MissionType.Spy => "Spy",
                MissionType.Rescue => "Rescue",
                MissionType.Capture => "Capture",
                MissionType.Defense => "Defense",
                MissionType.Sabotage => "Sabotage",
                MissionType.Survival => "Survival",
                MissionType.Excavation => "Excavation",
                MissionType.Interception => "Interception",
                MissionType.Assassination => "Assassination",
                MissionType.Extermination => "Extermination",
                MissionType.MobileDefense => "Mobile Defense",

                MissionType.Alchemy => "Alchemy",
                
                MissionType.VoidFlood => "Void Flood",
                MissionType.VoidCascade => "Void Cascade",
                MissionType.VoidArmagedon => "Void Armagedon",
                
                MissionType.Volatile => "Volatile",
                MissionType.Skirmish => "Skirmish",
                
                MissionType.Unknown => "Unknown",
                MissionType.Corruption => "Corruption",
                _ => "Unknown"
            };

            writer.WriteStringValue(missionTypeString);
        }
    }
}
