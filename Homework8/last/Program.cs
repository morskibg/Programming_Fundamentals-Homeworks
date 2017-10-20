using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                char[] firstDelim = "=>".ToCharArray();
                string[] firstTokens = input.Split(firstDelim, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string townName = firstTokens[0].Trim();//Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                string[] seats = firstTokens[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (!towns.Any(x => x.Name == townName))
                {
                    Town newTown = new Town();
                    newTown.Name = townName;
                    newTown.Capacity = int.Parse(seats[0]);
                    towns.Add(newTown);
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
                input = Console.ReadLine();
                while (input.Contains("@"))
                {
                    char[] secondDelim = "|".ToCharArray();
                    string[] studentTokens = input
                        .Split(secondDelim, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string studentName = studentTokens[0].Trim();//Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                    string studentMail = studentTokens[1].Trim();//Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                    string rawDate = studentTokens[2].Trim();//Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    DateTime regDate = DateTime.ParseExact(rawDate, "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    Student newStd = new Student();
                    newStd.Name = studentName;
                    newStd.Email = studentMail;
                    newStd.RegiDate = regDate;
                    int currTownIdx = towns.FindIndex(x => x.Name == townName);
                    towns[currTownIdx].Students.Add(newStd);

                    input = Console.ReadLine();
                }
            }
            
            int townsCoun = towns.Count;
            int totalGroupsCount = 0;
            foreach (var currTown in towns)
            {
                int studentsInTown = currTown.Students.Count;
                int townCpacity = currTown.Capacity;
                Group currGroup = new Group();

                foreach (var student in currTown.Students
                    .OrderBy(x => x.RegiDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email))
                {
                    if (currGroup.StudentsMails.Count < townCpacity)
                    {
                        currGroup.StudentsMails.Add(student.Email);
                    }
                    else
                    {
                        currTown.Groups.Add(currGroup);
                        ++totalGroupsCount;
                        currGroup = new Group();
                        currGroup.StudentsMails.Add(student.Email);
                    }
                    
                }
                if (currGroup.StudentsMails.Count != 0)
                {
                    currTown.Groups.Add(currGroup);
                    ++totalGroupsCount;
                }
            }
            Console.WriteLine($"Created {totalGroupsCount} groups in {townsCoun} towns:");
            foreach (var town in towns.OrderBy(x => x.Name))
            {
                
                foreach (var group in town.Groups)
                {
                    Console.WriteLine($"{town.Name} => {string.Join(", ", group.StudentsMails)}");
                }
               
            }
        }

        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegiDate { get; set; }
        }

        class Town
        {
            public string Name { get; set; }
            public int Capacity { get; set; }
            public HashSet<Student> Students { get; set; }
            public List<Group> Groups { get; set; }
            public Town()
            {
                Students = new HashSet<Student>();
                Groups = new List<Group>();
            }
        }

        class Group
        {
            //public string Name { get; set; }
            public List<string> StudentsMails { get; set; }

            public Group()
            {
                StudentsMails = new List<string>();
            }
        }
    }
}
