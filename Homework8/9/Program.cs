using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char[] delim = "-".ToCharArray();
                string[] tokens = Console.ReadLine()
                    .Split(delim, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string creatorName = tokens[0];
                string teamNameToCreate = tokens[1];
                if (teams.Any(x => x.Name == teamNameToCreate))
                {
                    Console.WriteLine($"Team {teamNameToCreate} was already created!");
                }
                else
                {
                    if (teams.Any(x => x.Creator == creatorName))
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                    else
                    {
                        Team newTeam = new Team();
                        newTeam.Creator = creatorName;
                        newTeam.Name = teamNameToCreate;
                        teams.Add(newTeam);
                        Console.WriteLine($"Team {teamNameToCreate} has been created by {creatorName}!");
                    }
                }
            }
            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                char[] delim = "->".ToCharArray();
                string[] tokens = input
                    .Split(delim, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string nameToAdd = tokens[0];
                string teamToJoin = tokens[1];
                if (!teams.Any(x => x.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(x => x.Users.Contains(nameToAdd)) ||
                         teams.Any(x => x.Creator == nameToAdd))
                {
                    Console.WriteLine($"Member {nameToAdd} cannot join team {teamToJoin}!");
                }
                else
                {
                    int desiredTeamIndex = teams.FindIndex(x => x.Name == teamToJoin);
                    teams[desiredTeamIndex].Users.Add(nameToAdd);
                }
                input = Console.ReadLine();
            }
            var nonEmptyTeams = teams.Where(x => x.Users.Count != 0);
            var emptyTeams = teams.Where(x => x.Users.Count == 0);
            foreach (var team in nonEmptyTeams
                .OrderByDescending(x => x.Users.Count)
                .ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var user in team.Users.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in emptyTeams.OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);

            }
        }
    }

    class Team
    {
        public string Name { get; set; }
        public HashSet<string> Users { get; set; }
        public string Creator { get; set; }

        public Team()
        {
            Name = "none";
            Users = new HashSet<string>();
        }

    }
}
