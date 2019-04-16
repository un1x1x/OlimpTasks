using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            short n;
            Console.Write("How much iterations need to do (more iterations - more accuracy): ");
            n = System.Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Result: " + solve(0, 3.14, n));
        }
        static double Function(double x)
        {
            return Math.Log(2.0 + Math.Sin(x));
        }
        static double solve(double a, double b, double n)
        {
            double result = 0.0;
            double h = (b - a) / n;
            for(short i = 1; i<=n; i++)
            {
                result += Function(a+(i*h)-(h/2));
            }
            result *= h;
            return result;
        }
    }
}
