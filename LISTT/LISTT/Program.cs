using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LISTT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("eee");
            list1.Add("zzz");
            list1.Add("xxx");
            list1.Add("ccc");
            list1.Add("vvv");
            Console.WriteLine("Введите текст:");
            string i = Convert.ToString(Console.ReadLine());
            Console.WriteLine(i);
            List<string> list2 = new List<string>();
            list1.Add($"{i}");
            foreach (string i in list1) ;
            if (list1.Contains(list1[0]))
            {

            }


        }
    }
}
