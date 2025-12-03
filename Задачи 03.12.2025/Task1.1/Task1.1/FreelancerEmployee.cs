using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class FreelancerEmployee
    {
        public double ProjectPayment;
        public double TaxRate;
        public int ProjectsCount;
        public ManagerRole Role;

        public FreelancerEmployee(int id, string name, string email, double payment, double tax)
            : base(id, name, email)
        {
            ProjectPayment = payment;
            TaxRate = tax;
        }

        public new double CalculateSalary()
        {
            double total = ProjectsCount * ProjectPayment;
            return total - (total * TaxRate / 100);
        }
    }
}
