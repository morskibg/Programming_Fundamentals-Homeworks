using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsDatabase = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end of dates")
            {
                char[] delim = " ,".ToCharArray();
                string[] tokens = input.Split(delim, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = tokens[0];
                tokens = tokens.Skip(1).ToArray();
                int idx = 0;

                if (!studentsDatabase.Exists(x => x.Name == name))
                {
                    Student currStudent = new Student(name);
                    studentsDatabase.Add(currStudent);
                }

                while (idx < tokens.Length)
                {
                    DateTime currDate = DateTime.ParseExact(tokens[idx], "dd/MM/yyyy", null);
                    Student tempStudent = studentsDatabase.Find(x => x.Name == name);
                    tempStudent.Dates.Add(currDate);
                    ++idx;
                }

                input = Console.ReadLine();

            }
            input = Console.ReadLine();
            while (input != "end of comments")
            {
                char[] delim = "-".ToCharArray();
                string[] tokens = input.Split(delim, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = tokens[0];
                if (studentsDatabase.Exists(x => x.Name == name) && tokens.Length > 1)
                {
                    Student foudedStudent = studentsDatabase.Find(x => x.Name == name);
                    foudedStudent.Comments.Add(tokens[1]);
                }
                input = Console.ReadLine();
            }
            foreach (var student in studentsDatabase.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine($"Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }

        public Student(string name)
        {
            Name = name;
            Dates = new List<DateTime>();
            Comments = new List<string>();
        }

    }
}
