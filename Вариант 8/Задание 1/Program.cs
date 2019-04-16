using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n: ");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int  i=0; i<=m; i++)
            {
                int num = Fibonacci_rec(i);
                if (num <= m && num >=n)
                    Console.WriteLine(num);
                else if (num > n)
                {
                    break;
                }
            }
        }
        static void Fibonacci_loop(int n, int m)
        {
            int f1 = 0;
            int f2 = 1;
            int next = 1;
            while (next <= m)
            {
                if (next >= n)
                    Console.Write(next + " ");
                next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
        }
        static int Fibonacci_rec(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fibonacci_rec(n - 1) + Fibonacci_rec(n - 2);
        }
    }
}
