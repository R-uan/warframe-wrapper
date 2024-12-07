namespace WarframeApiWrapper.Objects
{
    public class CambionDriftStatus
    {
        public DateTime Expiry { get; set; }
        public required string Id { get; set; }
        public DateTime Activation { get; set; }
        public required string Active { get; set; }
        public required string TimeLeft { get; set; }
    }
}

