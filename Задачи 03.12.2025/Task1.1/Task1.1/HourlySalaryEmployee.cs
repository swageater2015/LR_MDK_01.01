using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class HourlySalaryEmployee
    {
        public double HoursWorked;
        public double HourlyRate;
        public double OvertimeHours;
        public AccountantRole Role; 

        public HourlySalaryEmployee(int id, string name, string email, double rate)
            : base(id, name, email)
        {
            HourlyRate = rate;
        }

        public new double CalculateSalary()
        {
            double overtimeRate = HourlyRate * 1.5;
            return (HoursWorked * HourlyRate) + (OvertimeHours * overtimeRate);
        }
    }
}
