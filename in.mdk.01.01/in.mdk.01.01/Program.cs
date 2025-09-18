using System;
using System.Collections.Generic;
using System.Linq;
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
            for (int inde = 0; inde < array3.Length; inde++)
            {
                array3[inde] = inde+1;
                Console.Write($"[{array3[inde]},]");
            }
        }
    }
}
