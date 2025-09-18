using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace @in.mdk._01._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3] { "йцу", "енг", "мит" };
            array[1] = "кпрцкр";
            Console.WriteLine($"Элементы массива:{array[0]},{array[1]},{array[2]}");
            string[] array2 = new string[3];
            int[] array3 = new int[10000];
            for (int index = 0; index < array3.Length; index++)
            {
                array3[index] = (index + 1) * 2;
            }
            Console.Write("[");
            for (int index = 0; index < array3.Length - 1; index++)
            {
                Console.Write($"{array3[index]}, ");
            }
            Console.Write($"{array3[array3.Length - 1]}]");


            
        }
    }
}
