using WarframeApiWrapper.Objects;

namespace WarframeApiWrapper
{
    public partial class WarframeApi
    {
        public static async Task<CetusStatus> GetCetusStatus()
            => await WarframeApiClient.Get<CetusStatus>(Endpoints.CetusStatus) ?? throw new Exception();

        public static async Task<CambionDriftStatus> GetDeimosStatus()
            => await WarframeApiClient.Get<CambionDriftStatus>(Endpoints.CambionDriftStatus) ?? throw new Exception();

        public static async Task<OrbVallisStatus> GetVallisStatus()
            => await WarframeApiClient.Get<OrbVallisStatus>(Endpoints.VallisStatus) ?? throw new Exception();

        public static async Task<List<Alert>> GetAlerts()
            => await WarframeApiClient.Get<List<Alert>>(Endpoints.Alerts) ?? throw new Exception();

        public static async Task<List<Fissure>> GetFissures()
            => await WarframeApiClient.Get<List<Fissure>>(Endpoints.Fissure) ?? throw new Exception();

        public static async Task<ArchonHunt> GetArchonHunt()
            => await WarframeApiClient.Get<ArchonHunt>(Endpoints.ArchonHunt) ?? throw new Exception();

        public static async Task<List<Invasion>> GetInvasions()
            => await WarframeApiClient.Get<List<Invasion>>(Endpoints.Invasions) ?? throw new Exception();

        public static async Task<Sortie> GetSortie()
            => await WarframeApiClient.Get<Sortie>(Endpoints.Sortie) ?? throw new Exception();

        public static async Task<VoidTrader> GetVoidtrader()
            => await WarframeApiClient.Get<VoidTrader>(Endpoints.VoidTrader) ?? throw new Exception();
    }
}
