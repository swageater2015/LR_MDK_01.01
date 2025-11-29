using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary1
{
    internal class Program
    {
        static public void Search(Dictionary<string,List<string>>dictionary)
        {
            Console.Write("Введите ключ:");
            string key = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Dictionary<string,List<string>>dictionary = new Dictionary<string,List<string>>();
            dictionary.Add("птицы", new List<string>() { "дятел", "воробей", "дрозд" });
            dictionary.Add("рептилии", new List<string> { "змея", "варан"  });
            dictionary.Add("млекопитающие", new List<string> { "собака" });
            Console.WriteLine(string.Join(",", dictionary.Keys));
            Console.WriteLine();
            Console.Write(string.Join(",", dictionary["птицы"]));
            Console.Write("Введите ключ");
        }
    }
}
