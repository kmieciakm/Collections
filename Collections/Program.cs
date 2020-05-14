using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections {
    class Program {
        static void Main( string[] args ) {
            List<Team> teams = TeamRegister.GetTeams().ToList();

            Display("Not sorted", teams);

            teams.Sort(new TeamComparer().Compare);
            teams.Reverse(); // revers due to ascending nature of IList<T>.Sort()
            Display("Default sort", teams);

            teams.Sort(new TeamComparer().ComparePositions);
            teams.Reverse();
            Display("Position sort", teams);

            teams.Sort(new TeamComparer().CompareLeagues);
            teams.Reverse();
            Display("League sort", teams);
        }

        static void Display<T>( string title, IEnumerable<T> items) {
            Console.WriteLine("----------------------");
            Console.WriteLine(title);
            Console.WriteLine("----------------------");
            foreach (var item in items) {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
