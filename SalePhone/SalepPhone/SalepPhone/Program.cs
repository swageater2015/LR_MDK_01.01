using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalepPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sale> sales = new List<Sale>();
            sales.Add(new Sale(new DateTime(2024, 1, 1), "iPhone 15", 2, 99999m));
            sales.Add(new Sale(new DateTime(2024, 1, 1), "Samsung Galaxy", 3, 89999m));
            sales.Add(new Sale(new DateTime(2024, 1, 1), "Xiaomi Redmi", 1, 29999m));
            sales.Add(new Sale(new DateTime(2024, 1, 2), "iPhone 15", 1, 99999m));
            sales.Add(new Sale(new DateTime(2024, 1, 2), "Xiaomi Redmi", 4, 29999m));
            sales.Add(new Sale(new DateTime(2024, 1, 2), "Google Pixel", 2, 79999m));
        }
    }
}
