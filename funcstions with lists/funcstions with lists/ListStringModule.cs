using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcstions_with_lists
{
    class ListStringModule
    {
        static public List<string> FillListLines()
        {
            Console.WriteLine("Введите количество элементов списка:");
            int countlines = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            for (int index = 0; index < countlines; index++)
            {
                list.Add(Console.ReadLine());
            }
            return list;
        }
        static public List<int> ListElementNumber(List<string> list, string text)
        {
            List<int> result = new List<int>();
            for(int index = 0; index < list.Count; index++)
            {

            }
        }
    }
}
