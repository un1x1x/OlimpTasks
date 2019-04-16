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
            short d1 = 5, a1 = 2;
            short d2 = 7, a2 = 3;
            short sum = 0;
            short i = Math.Min(a1, a2);
            Console.Write("How much numbers need to find: ");
            short num = System.Convert.ToInt16(Console.ReadLine());
            while (num > 0)
            {
                if (Check_Belongs(a1, d1, i) && Check_Belongs(a2,d2,i))
                {
                    Console.Write(i + " ");
                    num--;
                    sum += i;
                    i += (short)(Math.Min(d1, d2));
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Result: " + sum);
        }
        static bool Check_Belongs(short a1, short d, short num)
        {
            bool result = ((num - a1 + d) % d) == 0;
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
