using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcstions_with_lists
{
    class Program
    {
        static void Main()
        {
            List<string> list = ListStringModule.FillListLines();
            Console.WriteLine("Последний элемент списка:" + list[list.Count-1]);
            Console.WriteLine("Размер списка:" + list.Count);
        }
    }
}
