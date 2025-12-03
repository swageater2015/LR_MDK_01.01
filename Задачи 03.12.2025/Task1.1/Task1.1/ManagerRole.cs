using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class ManagerRole
    {
        public void Login()
        {
            Console.WriteLine("Менеджер вошел");
        }

        public void Logout()
        {
            Console.WriteLine("Менеджер вышел");
        }

        public bool HasAccessToModule(string module)
        {
            if (module == "Финансы" || module == "Отчеты")
                return true;
            return false;
        }
    }
}
