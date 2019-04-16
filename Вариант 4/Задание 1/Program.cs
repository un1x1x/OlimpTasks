using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = 1e-8;
            double PI = F(e);
            Console.WriteLine(PI);
        }
        static double F(double e)
        {
            double temp_result = 0;
            double prev_result = 0;
            double result = 0;
            int step = 2;
            int denominator = 1;
            do
            {
                prev_result = result;
                temp_result += Math.Pow(-1, step) * (double)1 / (double)denominator;
                denominator += 2;
                result = 4 * temp_result;
                step++;
            } while (Math.Abs(result - prev_result) >= e);
            return result;
        }
    }
}
