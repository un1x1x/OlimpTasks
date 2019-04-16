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
            Console.Write("Write number: ");
            long num = System.Convert.ToInt64(Console.ReadLine());
            num = Factorial(num);
            Console.WriteLine("Factorial: " + num);
            num = Check_Number(num);
            if (num == 0)
            {
                Console.WriteLine("Can't find this numbers");
            }
            else
            {
                Console.WriteLine("Numbers found: " + num + " " + (num - 1) + " " + (num - 2));
            }
        }
        static int Check_Number(long num)
        {
            for(int i = 3; i * (i - 1) * (i - 2) <= num; i++)
            {
                if (i * (i - 1) * (i - 2) == num)
                {
                    return i;
                }
            }
            return 0;
        }
        static long Factorial(long num)
        {
            return (num == 0) ? 1 : num * Factorial((num - 1));
        }
    }
}
