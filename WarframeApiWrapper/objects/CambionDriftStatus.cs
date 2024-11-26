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

/*
id	"cambionCycle1732390080000"
activation	"2024-11-23T17:48:00.000Z"
expiry	"2024-11-23T19:28:00.000Z"
timeLeft	"1h 4m 1s"
state	"fass"
active	"fass"
*/
