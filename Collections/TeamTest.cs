using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Collections {
    public class TeamTest {
        [Fact]
        public void TeamPositionComparisonTest() {
            Team teamOne = new Team() { Name = "TeamOne", League = 1, Position = 3 };
            Team teamTwo = new Team() { Name = "TeamTwo", League = 2, Position = 6 };
            TeamComparer comparer = new TeamComparer();
            Assert.True(comparer.ComparePositions(
                    teamOne, teamTwo) > 0);
            Assert.True(comparer.ComparePositions(
                    teamOne, teamOne) == 0);
            Assert.True(comparer.ComparePositions(
                    teamTwo, teamOne) < 0);
        }

        [Fact]
        public void TeamLeagueComparisonTest() {
            Team teamOne = new Team() { Name = "TeamOne", League = 1, Position = 3 };
            Team teamTwo = new Team() { Name = "TeamTwo", League = 2, Position = 6 };
            TeamComparer comparer = new TeamComparer();
            Assert.True(comparer.CompareLeagues(
                    teamOne, teamTwo) > 0);
            Assert.True(comparer.CompareLeagues(
                    teamOne, teamOne) == 0);
            Assert.True(comparer.CompareLeagues(
                    teamTwo, teamOne) < 0);
        }

        [Fact]
        public void TeamGeneralComparisonTest() {
            Team teamOne = new Team() { Name = "TeamOne", League = 1, Position = 3 };
            Team teamTwo = new Team() { Name = "TeamTwo", League = 1, Position = 6 };
            TeamComparer comparer = new TeamComparer();
            Assert.True(comparer.Compare(
                    teamOne, teamTwo) > 0);
            Assert.True(comparer.Compare(
                    teamOne, teamOne) == 0);
            Assert.True(comparer.Compare(
                    teamTwo, teamOne) < 0);
        }
    }
}
