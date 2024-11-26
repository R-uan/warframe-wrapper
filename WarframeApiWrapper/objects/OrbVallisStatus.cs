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

/*
    id	"vallisCycle1732558020000"
expiry	"2024-11-25T18:27:08.000Z"
isWarm	false
state	"cold"
activation	"2024-11-25T18:07:00.000Z"
timeLeft	"19m 7s"
shortString	"19m to Warm"
 */