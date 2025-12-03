using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedSalaryEmployee emp1 = new FixedSalaryEmployee(1, "Иванов И.И.", "ivanov@mail.ru", 50000);
            emp1.Role = new ManagerRole();

            HourlySalaryEmployee emp2 = new HourlySalaryEmployee(2, "Петров П.П.", "petrov@mail.ru", 500);
            emp2.HoursWorked = 160;
            emp2.OvertimeHours = 10;
            emp2.Role = new AccountantRole();

            FreelancerEmployee emp3 = new FreelancerEmployee(3, "Сидоров С.С.", "sidorov@mail.ru", 30000, 13);
            emp3.ProjectsCount = 2;
            emp3.Role = new ManagerRole();

            Console.WriteLine("Зарплаты:");
            Console.WriteLine(emp1.FullName + ": " + emp1.CalculateSalary() + " руб.");
            Console.WriteLine(emp2.FullName + ": " + emp2.CalculateSalary() + " руб.");
            Console.WriteLine(emp3.FullName + ": " + emp3.CalculateSalary() + " руб.");

            Console.WriteLine("\nДоступ к модулям:");
            emp1.Role.Login();
            bool access = emp1.Role.HasAccessToModule("Финансы");
            Console.WriteLine("Доступ к Финансам: " + access);
            emp1.Role.Logout();

            Console.ReadKey();
        }
    }
}
