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

            Student[] bestStudents = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].Grade < students[j].Grade)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                bestStudents[i] = students[i];
            }
        }
    }
}
