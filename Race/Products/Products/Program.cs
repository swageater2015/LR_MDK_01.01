using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mers = new Product();
            mers.SetName("Мерседес");
            mers.SetPrice(1000000);
            Product yazik = new Product();
            yazik.SetName("Уазик");
            yazik.SetPrice(10000000);
            Storage storage = new Storage();
            storage.SetId(1);
            storage.SetLocation("Торжок студенческая 3");
            storage.SetProductQuantity(mers, 2);
            storage.SetProductQuantity(yazik, 5);
        }
    }
}
