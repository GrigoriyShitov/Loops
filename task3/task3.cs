using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class task3
    {
        static void Main(string[] args)
        {
            double  A=0, B=0, C = 0;
            int count = 0;
            Console.WriteLine("Введите сторону A ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону B");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону C");
            C = Convert.ToDouble(Console.ReadLine());

            while ((A - C) >= 0)
            {
                A -= C;
                double temp = B;
                while ((temp - C) >= 0)
                {
                    temp -= C;
                    count++;
                }
            }
            Console.WriteLine("Количество квадратов равно = {0} ", count);
            Console.ReadKey();
        }
    }
}
