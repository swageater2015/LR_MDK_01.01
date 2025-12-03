using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class AccountantRole
    {
        public void Login()
        {
            Console.WriteLine("Бухгалтер вошел");
        }

        public void Logout()
        {
            Console.WriteLine("Бухгалтер вышел");
        }

        public bool HasAccessToModule(string module)
        {
            if (module == "Финансы")
                return true;
            return false;
        }
    }
}
