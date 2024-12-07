namespace WarframeApiWrapper.Objects {
    public class OrbVallisStatus {
        public bool IsWarm {get;set;}
        public DateTime Expiry {get;set;}
        public required string Id {get;set;}
        public DateTime Activation {get;set;}
        public required string State {get;set;}
        public required string TimeLeft {get;set;}
        public required string ShortString {get;set;}
    }
}