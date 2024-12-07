namespace WarframeApiWrapper.Objects
{
    public class CetusStatus
    {
        public bool IsDay { get; set; }
        public DateTime Expiry { get; set; }
        public required string Id { get; set; }
        public DateTime Activation { get; set; }
        public required string State { get; set; }
        public required string TimeLeft { get; set; }
    }
}
