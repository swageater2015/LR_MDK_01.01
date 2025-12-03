using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class Employee
    {
        public int Id;
        public string FullName;
        public string Email;

     

       
        public Employee(int id, string name, string email)
        {
            Id = id;
            FullName = name;
            Email = email;
        }
    }
}
