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
        }
    }
}
