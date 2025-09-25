using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1__1_variant_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);


            int[] numbers = new int[n];
            Console.WriteLine($"Введите {n} чисел:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Число {i + 1}: ");
                string numInput = Console.ReadLine();
                numbers[i] = Convert.ToInt32(numInput);
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + numbers[i];
            }
            double average = (double)sum / n;

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < average)
                {
                    count = count + 1;
                }
            }

            Console.WriteLine("\nРезультаты:");
            Console.Write("Массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\nСреднее значение: " + average);
            Console.WriteLine("Элементов меньше среднего: " + count);
        }
    }
}
