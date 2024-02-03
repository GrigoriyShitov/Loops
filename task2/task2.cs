using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class task2
    {
        static void Main(string[] args)
        {
            int positive = 0;
            int negative = 0;
            int N;
            do
            {
                Console.WriteLine("Введите число ");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    positive++;
                }
                else if (N < 0)
                {
                    negative++;
                }
            } while (N != 0);
            if (positive > negative)
            {
                Console.WriteLine("Положительных чисел больше. Положительных:{0} ; Отрицательных: {1}",positive,negative);
            }
            else if( negative > positive)
            {
                Console.WriteLine("Отрицательных чисел больше. Положительных:{0} ; Отрицательных: {1}", positive, negative);
            }
            else
            {
                Console.WriteLine("Количество чисел равно" +
                    ". Положительных:{0} ; Отрицательных: {1}", positive, negative);
            }
            Console.ReadKey();
        }
    }
}
