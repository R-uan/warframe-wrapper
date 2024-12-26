using System.Text.Json.Serialization;

namespace WarframeApiWrapper.Objects
{
    public class CambionDriftStatus
    {
        public required string Id { get; set; }
        public DateTime Expiry { get; set; }
        public DateTime Activation { get; set; }


        public required string Active { get; set; }
        public bool IsVome { get; private set; }

        [JsonConstructor]
        public CambionDriftStatus(string active)
        {
            Active = active;
            IsVome = Active == "vome";
        }
    }
}

