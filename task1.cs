using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int N=Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for (int i = 1; i <= 2*N-1; i+=2)
            {
                Sum += i;
                Console.WriteLine("Сумма при {0} равна:{1}",i,Sum);
            }
            Console.ReadKey();
        }
    }
}
