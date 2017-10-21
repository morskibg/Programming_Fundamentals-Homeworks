using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            List<Student> database = new List<Student>();
            for (int i = 1; i <= n; i++)
            {
                char[] delim = " ".ToCharArray();
                string[] tokens = input[i].Split(delim, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Student student = new Student();
                student.Name = tokens[0];
                for (int j = 1; j < tokens.Length; j++)
                {
                    student.Grades.Add(double.Parse(tokens[j]));
                }
                database.Add(student);
            }
            File.WriteAllText("output.txt", "");
            foreach (var student in database
                .Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade))
            {
                File.AppendAllText("output.txt",$"{student.Name} -> {student.AverageGrade:f2}" + Environment.NewLine);
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
