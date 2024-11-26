using WarframeApiWrapper.Objects;
namespace WarframeApiWrapper
{
    public partial class WAPI
    {
        public static async Task<CetusStatus> GetCetusStatus()
            => await WarframeApiClient.Get<CetusStatus>(Endpoints.CetusStatus) ?? throw new Exception();

        public static async Task<CambionDriftStatus> GetDeimosStatus()
            => await WarframeApiClient.Get<CambionDriftStatus>(Endpoints.CambionDriftStatus) ?? throw new Exception();

        public static async Task<OrbVallisStatus> GetVallisStatus() 
            => await WarframeApiClient.Get<OrbVallisStatus>(Endpoints.VallisStatus) ?? throw new Exception();
        
        public static async Task<List<Alert>> GetAlerts()
            => await WarframeApiClient.Get<List<Alert>>(Endpoints.Alerts) ?? throw new Exception();
    }
}
