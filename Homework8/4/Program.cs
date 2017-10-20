using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get { return Grades.Average(); }
        }

        public Student(string name, List<double> inputGrades)
        {
            Name = name;
            this.Grades = new List<double>(inputGrades);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string name = tokens[0];
                List<double> tempList = tokens.Skip(1).Select(double.Parse).ToList();
                Student currStudent = new Student(name, tempList);
                students.Add(currStudent);
            }
            foreach (var currStudent in students
                .Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{currStudent.Name} -> {currStudent.AverageGrade:f2}");
            }
            int t = 0;
        }
    }
}
