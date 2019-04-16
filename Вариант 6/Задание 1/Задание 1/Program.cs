using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input alpha");
            Console.WriteLine(Compute(Convert.ToSingle(Console.ReadLine())));
        }
        static double Compute(float alpha)
        {
            double sum_in, sum_out = 0;
            for (int k = 1; k <= 10; k++)
            {
                sum_in = 0;
                for (int n = 1; n <= alpha; n++)
                    sum_in += Math.Sin(k * n);
                sum_out += sum_in / Factorial(k);
            }
            return sum_out;
        }
        static long Factorial(long x)
        {
            return (x == 0) ? 1 : x * Factorial(x - 1);
        }
    }
}
