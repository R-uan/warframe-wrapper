using WarframeApiWrapper;
using WarframeApiWrapper.Objects;

namespace WarframeApiWrapper.Tests
{
    public class WarframeApiWrapperTests
    {
        [Fact]
        public async Task GetCetusStatusTest()
        {
            var request = await WarframeApi.GetCetusStatus();
            Assert.IsType<CetusStatus>(request);
            Assert.NotNull(request.Id);
            Assert.True(request.Active == "night" || request.Active == "day");

        }

        [Fact]
        public async Task GetDeimosStatusTest()
        {
            var request = await WarframeApi.GetDeimosStatus();
            Assert.IsType<CambionDriftStatus>(request);
            Assert.True(request.Active == "vome" || request.Active == "fass");
            if (request.Active == "vome") Assert.True(request.IsVome);
            else Assert.False(request.IsVome);
        }

        [Fact]
        public async Task GetVallisStatusTest()
        {
            var request = await WarframeApi.GetVallisStatus();
            Assert.IsType<OrbVallisStatus>(request);
            Assert.True(request.Active == "cold" || request.Active == "warm");
        }

        [Fact]
        public async Task GetAlertsTest()
        {
            var request = await WarframeApi.GetAlerts();
            Assert.IsType<List<Alert>>(request);
            foreach (var alert in request)
            {
                Assert.NotNull(alert.Mission.Reward);
                Assert.NotEqual(Faction.Unknown, alert.Mission.Faction);
                Assert.NotEqual(MissionType.Unknown, alert.Mission.Type);
            }
        }

        [Fact]
        public async Task GetFissuresTest()
        {
            var request = await WarframeApi.GetFissures();
            Assert.IsType<List<Fissure>>(request);
            foreach (var fissure in request)
            {
                Assert.NotEqual(MissionType.Unknown, fissure.MissionType);
                Assert.NotEqual(FissureTier.Unknown, fissure.Tier);
                Assert.NotEqual(Faction.Unknown, fissure.Enemy);
            }
        }

        [Fact]
        public async Task GetArchonHuntTest()
        {
            var request = await WarframeApi.GetArchonHunt();
            Assert.IsType<ArchonHunt>(request);
            Assert.NotNull(request.Id);
            Assert.NotEqual(Faction.Unknown, request.Faction);
            Assert.Equal(3, request.Missions.Count);
            foreach (var mission in request.Missions)
            {
                Assert.NotEqual(MissionType.Unknown, mission.Type);
            }
        }

        [Fact]
        public async Task GetInvasions()
        {
            var request = await WarframeApi.GetInvasions();
            Assert.IsType<List<Invasion>>(request);
            foreach (var invasion in request)
            {
                Assert.NotEqual(Faction.Unknown, invasion.Attacker.Faction);
                Assert.NotEqual(Faction.Unknown, invasion.Defender.Faction);
            }
        }
    }
}
