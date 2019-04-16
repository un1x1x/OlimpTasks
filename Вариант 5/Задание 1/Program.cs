using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ln(4));
            Console.WriteLine(Math.Log(4));
            Console.WriteLine("Похибка ~ " + (Ln(4) - Math.Log(4)));
        }
        static double Ln(double x)
        {
            double e = 1e-13;
            int pow = 1;
            double prev;
            double result = 0;
            do
            {
                prev = result;
                result += 2 * Math.Pow((x - 1), pow) / (pow * Math.Pow((x + 1), pow));
                pow += 2;
                
            } while (Math.Abs(result - prev) >= e);
            return result;
        }
    }
}
