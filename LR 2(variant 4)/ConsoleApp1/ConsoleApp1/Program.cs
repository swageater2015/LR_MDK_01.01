using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Delivery
        {
            public string PartName;
            public int Quantity;
            public string Supplier;
        }
        static void Main(string[] args)
        {
            List<Delivery> deliveries = new List<Delivery>
        {
            new Delivery { PartName = "Колесо", Quantity = 10, Supplier = "МеталлПро" },
            new Delivery { PartName = "Ось", Quantity = 5, Supplier = "МеталлПро" },
            new Delivery { PartName = "Колесо", Quantity = 8, Supplier = "МеталлПро" },
            new Delivery { PartName = "Тормоз", Quantity = 15, Supplier = "ТекноСтар" }
        };

            Console.Write("Введите поставщика: ");
            string supplier = Console.ReadLine();

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var d in deliveries)
            {
                if (d.Supplier.ToLower() == supplier.ToLower())
                {
                    if (result.ContainsKey(d.PartName))
                        result[d.PartName] += d.Quantity;
                    else
                        result[d.PartName] = d.Quantity;
                }
            }

            if (result.Count > 0)
            {
                Console.WriteLine($"\nДетали {supplier}:");
                string popular = "";
                int max = 0;

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Key} -- {item.Value}");
                    if (item.Value > max)
                    {
                        max = item.Value;
                        popular = item.Key;
                    }
                }
                Console.WriteLine($"Самая популярная: {popular} ({max} шт.)");
            }
            else
            {
                Console.WriteLine("Поставщик не найден!");
            }
        }
    }
}
