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
            Assert.True(request.State == "night" || request.State == "day");

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
            foreach(var alert in request) {
                Assert.NotEqual(Faction.Unknown, alert.Mission.Faction);
                Assert.NotEqual(MissionType.Unknown, alert.Mission.Type);
            }
        }

        [Fact]
        public async Task GetFissuresTest() {
            var request = await WarframeApiWrapper.WAPI.GetFissures();
            Assert.IsType<List<Fissure>>(request);
            foreach(var fissure in request) {
                Assert.NotEqual(MissionType.Unknown, fissure.MissionType);
                Assert.NotEqual(FissureTier.Unknown, fissure.Tier);
            }
        }

        [Fact]
        public async Task GetArchonHuntTest() {
            var request = await WarframeApiWrapper.WAPI.GetArchonHunt();
            Assert.IsType<ArchonHunt>(request);
            Assert.NotNull(request.Id);
            Assert.NotEqual(Faction.Unknown, request.Faction);
            Assert.Equal(3, request.Missions.Count);
            foreach(var mission in request.Missions) {
                Assert.NotEqual(MissionType.Unknown, mission.Type);
            }
        }
    }
}
