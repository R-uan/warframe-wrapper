using WarframeApiWrapper;
using WarframeApiWrapper.Objects;

namespace WAPI.Tests
{
    public class WAPITests
    {
        [Fact]
        public async Task GetCetusStatusTest()
        {
            var request = await WarframeApiWrapper.WAPI.GetCetusStatus();
            Assert.IsType<CetusStatus>(request);
            Assert.NotNull(request.Id);
        }

        [Fact]
        public async Task GetDeimosStatusTest() {
            var request = await WarframeApiWrapper.WAPI.GetDeimosStatus();
            Assert.IsType<CambionDriftStatus>(request);
            Assert.True(request.Active == "vome" || request.Active == "fass");
        }

        [Fact]
        public async Task GetVallisStatusTest() {
            var request = await WarframeApiWrapper.WAPI.GetVallisStatus();
            Assert.IsType<OrbVallisStatus>(request);
            Assert.True(request.State == "cold" || request.State == "warm");
        }

        [Fact]
        public async Task GetAlertsTest() {
            var request = await WarframeApiWrapper.WAPI.GetAlerts();
            Assert.IsType<List<Alert>>(request);
            Assert.NotEqual(Faction.Unknown, request[0].Mission.Faction);
        }
    }
}
