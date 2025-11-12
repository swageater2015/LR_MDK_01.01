using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    struct Student
    {
        public string Name;
        public int Age;
        public double Grade;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[100];
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                students[i].Name = "Student" + (i + 1);
                students[i].Age = random.Next(17, 25);
                students[i].Grade = random.Next(2, 6) + random.NextDouble();
            }
        }
    }
}
