using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> database = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                char[] delim = " ".ToCharArray();
                string[] tokens = Console.ReadLine().Split(delim, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Student student = new Student();
                student.Name = tokens[0];
                for (int j = 1; j < tokens.Length; j++)
                {
                    student.Grades.Add(double.Parse(tokens[j]));
                }
                database.Add(student);
            }
            foreach (var student in database
                .Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get { return Grades.Average(); }
        }

        public Student()
        {
            Grades = new List<double>();
        }
    }
}
