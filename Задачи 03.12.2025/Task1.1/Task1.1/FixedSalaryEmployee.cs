using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class FixedSalaryEmployee
    {
        public double MonthlySalary;
        public ManagerRole Role;

        public FixedSalaryEmployee(int id, string name, string email, double salary)
            : base(id, name, email)  
        {
            MonthlySalary = salary;
        }

        public double GetSalary()
        {
            return MonthlySalary;
        }
    }
}
