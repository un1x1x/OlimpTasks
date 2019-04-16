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
            Console.WriteLine(func(8, 1, 0));
        }
        static int func(int i, int num, int a)
        {
            if (i > 0)
            {
                return func(i - 1, num * 10, 10*a + num);
            }
            else
            {
                return a;
            }
        }
    }
}
