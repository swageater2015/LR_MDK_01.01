using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum Color
        {
            Красный,
            Зеленый,
            Синий,
            Жёлтый
        }
        static void Main()
        {
            Console.WriteLine("Все цвета:");

            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine(color);
            }
        }
        
    }   
}
