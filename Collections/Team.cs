using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Collections {
    public class Team {
        public string Name { get; set; }
        public int League { get; set; }
        public int Position { get; set; }

        public override string ToString() {
            return $"{Name} ({League}, {Position})";
        }
    }

    public static class TeamRegister {
        public static IEnumerable<Team> GetTeams() {
            return new List<Team> {
                new Team () { Name = "Red", League = 1, Position = 1 },
                new Team () { Name = "Blue", League = 1, Position = 3 },
                new Team () { Name = "Black", League = 2, Position = 1 },
                new Team () { Name = "Green", League = 1, Position = 2 },
                new Team () { Name = "BlackAndWhite", League = 2, Position = 3 },
                new Team () { Name = "White", League = 2, Position = 2 }
            };
        }
    }

    public class TeamComparer : IComparer<Team> {
        public int Compare(Team teamOne, Team teamTwo) {
            if (ReferenceEquals(teamOne, teamTwo)) return 0;
            if (teamOne == null) return -1;
            if (teamTwo == null) return 1;

            int leaguesComparison = CompareLeagues(teamOne, teamTwo);
            if (leaguesComparison == 0) {
                return ComparePositions(teamOne, teamTwo);
            } else {
                return leaguesComparison;
            }
        }

        public int ComparePositions( Team teamOne, Team teamTwo ) {
            if (ReferenceEquals(teamOne, teamTwo)) return 0;
            if (teamOne == null) return -1;
            if (teamTwo == null) return 1;

            return teamTwo.Position - teamOne.Position;
        }

        public int CompareLeagues( Team teamOne, Team teamTwo ) {
            if (ReferenceEquals(teamOne, teamTwo)) return 0;
            if (teamOne == null) return -1;
            if (teamTwo == null) return 1;

            return teamTwo.League - teamOne.League;
        }
    }
}
